using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// DAL quản lý tồn kho (Inventory) cho sản phẩm và bao bì
    /// </summary>
    public class InventoryDAL
    {
        // Hỗ trợ thao tác với database
        private readonly DatabaseHelper Db = new DatabaseHelper();

        // DAL xử lý thông tin sản phẩm
        private readonly ProductDAL Product = new ProductDAL();

        // DAL xử lý thông tin bao bì
        private readonly PackageDAL Package = new PackageDAL();

        /// <summary>
        /// Lấy danh sách tồn kho theo WarehouseID
        /// </summary>
        public List<InventoryDTO> GetByWarehouseID(string warehouseID)
        {
            string sql = "SELECT * FROM Inventory WHERE WarehouseID = @WarehouseID";
            var dt = Db.ExecuteQuery(sql, new SQLiteParameter("@WarehouseID", warehouseID));

            List<InventoryDTO> inventories = new List<InventoryDTO>();

            foreach (DataRow r in dt.Rows)
            {
                // Nếu tồn kho thuộc sản phẩm
                if (r["ProductID"] != DBNull.Value && !string.IsNullOrEmpty(r["ProductID"].ToString()))
                {
                    var product = Product.GetByID(r["ProductID"].ToString());
                    var inventory = new InventoryDTO(
                        ID: r["InventoryID"].ToString(),
                        product: product,
                        wareHouseID: r["WarehouseID"].ToString(),
                        stockQuantity: Convert.ToInt32(r["StockQuantity"])
                    );
                    inventories.Add(inventory);
                }
                // Nếu tồn kho thuộc bao bì
                else if (r["PackageID"] != DBNull.Value && !string.IsNullOrEmpty(r["PackageID"].ToString()))
                {
                    var package = Package.GetByID(r["PackageID"].ToString());
                    var inventory = new InventoryDTO(
                        ID: r["InventoryID"].ToString(),
                        package: package,
                        wareHouseID: r["WarehouseID"].ToString(),
                        stockQuantity: Convert.ToInt32(r["StockQuantity"])
                    );
                    inventories.Add(inventory);
                }
            }

            return inventories;
        }

        /// <summary>
        /// Cập nhật tồn kho khi nhận bao bì từ OrderPackaging
        /// </summary>
        public void UpdatePackageStockQuantity(List<OrderPackagingDTO> orderPackagingDTOs, string warehouseID)
        {
            foreach (var item in orderPackagingDTOs)
            {
                string packageID = item.GetPackage().GetID();
                int quantity = 1; // Mỗi bao bì tính là 1

                // Kiểm tra tồn tại
                string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Inventory
                    WHERE WarehouseID = @WarehouseID
                      AND PackageID = @PackageID
                      AND isDelete = 0;
                ";

                DataTable dt = Db.ExecuteQuery(checkQuery,
                    new SQLiteParameter("@WarehouseID", warehouseID),
                    new SQLiteParameter("@PackageID", packageID)
                );

                int count = dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;

                if (count > 0)
                {
                    // Nếu đã tồn tại → UPDATE
                    string updateQuery = @"
                        UPDATE Inventory
                        SET StockQuantity = StockQuantity + @Quantity
                        WHERE WarehouseID = @WarehouseID
                          AND PackageID = @PackageID
                          AND isDelete = 0;
                    ";

                    Db.ExecuteNonQuery(updateQuery,
                        new SQLiteParameter("@Quantity", quantity),
                        new SQLiteParameter("@WarehouseID", warehouseID),
                        new SQLiteParameter("@PackageID", packageID)
                    );
                }
                else
                {
                    // Nếu chưa tồn tại → INSERT
                    string insertQuery = @"
                        INSERT INTO Inventory (ProductID, PackageID, WarehouseID, StockQuantity, isDelete)
                        VALUES (NULL, @PackageID, @WarehouseID, @Quantity, 0);
                    ";

                    Db.ExecuteNonQuery(insertQuery,
                        new SQLiteParameter("@PackageID", packageID),
                        new SQLiteParameter("@WarehouseID", warehouseID),
                        new SQLiteParameter("@Quantity", quantity)
                    );
                }
            }
        }

        /// <summary>
        /// Cập nhật ProductID khi thay đổi sản phẩm
        /// </summary>
        public void UpdateProductIdInStock(string oldProductID, string newProductID)
        {
            string query = @"
                UPDATE Inventory
                SET ProductID = @NewProductID
                WHERE ProductID = @OldProductID
            ";

            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@NewProductID", newProductID),
                new SQLiteParameter("@OldProductID", oldProductID)
            );
        }

        /// <summary>
        /// Cập nhật số lượng tồn kho khi nhập hàng (chỉ bao bì)
        /// </summary>
        public void UpdateImportStockQuantity(InvoiceDetailDTO detail, string warehouseID)
        {
            string packageID = detail.GetPackage().GetID();
            int quantity = 1;

            if (string.IsNullOrEmpty(packageID))
                return;

            // Kiểm tra tồn kho
            string checkQuery = @"
                SELECT COUNT(*) 
                FROM Inventory
                WHERE WarehouseID = @WarehouseID
                  AND PackageID = @PackageID
                  AND ProductID IS NULL
                  AND isDelete = 0;
            ";

            DataTable dt = Db.ExecuteQuery(checkQuery,
                new SQLiteParameter("@WarehouseID", warehouseID),
                new SQLiteParameter("@PackageID", packageID)
            );

            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                string updateQuery = @"
                    UPDATE Inventory
                    SET StockQuantity = StockQuantity + @Quantity
                    WHERE WarehouseID = @WarehouseID
                      AND PackageID = @PackageID
                      AND ProductID IS NULL
                      AND isDelete = 0;
                ";

                Db.ExecuteNonQuery(updateQuery,
                    new SQLiteParameter("@Quantity", quantity),
                    new SQLiteParameter("@WarehouseID", warehouseID),
                    new SQLiteParameter("@PackageID", packageID)
                );
            }
            else
            {
                string insertQuery = @"
                    INSERT INTO Inventory (ProductID, PackageID, WarehouseID, StockQuantity, isDelete)
                    VALUES (NULL, @PackageID, @WarehouseID, @Quantity, 0);
                ";

                Db.ExecuteNonQuery(insertQuery,
                    new SQLiteParameter("@PackageID", packageID),
                    new SQLiteParameter("@WarehouseID", warehouseID),
                    new SQLiteParameter("@Quantity", quantity)
                );
            }
        }

        /// <summary>
        /// Cập nhật số lượng tồn kho khi xuất hàng (chỉ bao bì)
        /// </summary>
        public void UpdateExportStockQuantity(InvoiceDetailDTO detail, string warehouseID)
        {
            string packageID = detail.GetPackage().GetID();
            int quantity = 1;

            if (string.IsNullOrEmpty(packageID))
                return;

            // Kiểm tra tồn kho
            string checkQuery = @"
                SELECT StockQuantity
                FROM Inventory
                WHERE WarehouseID = @WarehouseID
                  AND PackageID = @PackageID
                  AND ProductID IS NULL
                  AND isDelete = 0;
            ";

            DataTable dt = Db.ExecuteQuery(
                checkQuery,
                new SQLiteParameter("@WarehouseID", warehouseID),
                new SQLiteParameter("@PackageID", packageID)
            );

            if (dt.Rows.Count == 0)
                throw new Exception("Lỗi: Sản phẩm không tồn tại trong kho!");

            int currentStock = Convert.ToInt32(dt.Rows[0]["StockQuantity"]);

            if (currentStock < quantity)
                throw new Exception("Lỗi: Số lượng tồn kho không đủ để xuất!");

            string updateQuery = @"
                UPDATE Inventory
                SET StockQuantity = StockQuantity - @Quantity
                WHERE WarehouseID = @WarehouseID
                  AND PackageID = @PackageID
                  AND ProductID IS NULL
                  AND isDelete = 0;
            ";

            Db.ExecuteNonQuery(
                updateQuery,
                new SQLiteParameter("@Quantity", quantity),
                new SQLiteParameter("@WarehouseID", warehouseID),
                new SQLiteParameter("@PackageID", packageID)
            );
        }
    }
}
