using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// DAL quản lý chi tiết hóa đơn (InvoiceDetail)
    /// </summary>
    public class InvoiceDetailDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper(); // Hỗ trợ thao tác với database
        private readonly ProductDAL ProductDAL = new ProductDAL(); // DAL lấy thông tin sản phẩm
        private readonly PackageDAL PackageDAL = new PackageDAL(); // DAL lấy thông tin gói sản phẩm
        private readonly InventoryDAL InventoryDAL = new InventoryDAL(); // DAL tồn kho

        /// <summary>
        /// Lưu danh sách chi tiết hóa đơn
        /// </summary>
        public void SaveDetails(List<InvoiceDetailDTO> details, string invoiceID, string type, string warehouseID)
        {
            foreach (var detail in details)
            {
                SaveDetail(detail, invoiceID, type, warehouseID);
            }
        }

        /// <summary>
        /// Lưu một chi tiết hóa đơn
        /// </summary>
        public void SaveDetail(InvoiceDetailDTO detail, string invoiceID, string type, string warehouseID)
        {
            if (detail == null) return;

            string sqlQuery = @"
                INSERT INTO InvoiceDetail 
                (InvoiceDetailID, InvoiceID, ProductID, Quantity, TotalAmount, PackageID) 
                VALUES (@InvoiceDetailID, @InvoiceID, @ProductID, @Quantity, @TotalAmount, @PackageID)";

            if (detail.GetProduct() != null)
            {
                // Nếu chi tiết là sản phẩm
                Db.ExecuteNonQuery(sqlQuery,
                    new System.Data.SQLite.SQLiteParameter("@InvoiceDetailID", detail.GetID()),
                    new System.Data.SQLite.SQLiteParameter("@InvoiceID", invoiceID),
                    new System.Data.SQLite.SQLiteParameter("@ProductID", detail.GetProduct().GetID()),
                    new System.Data.SQLite.SQLiteParameter("@Quantity", detail.GetQuantity()),
                    new System.Data.SQLite.SQLiteParameter("@TotalAmount", detail.GetTotalAmount()),
                    new System.Data.SQLite.SQLiteParameter("@PackageID", DBNull.Value)
                );
            }
            else if (detail.GetPackage() != null)
            {
                // Nếu chi tiết là gói sản phẩm
                string packageID = PackageDAL.Insert(detail.GetPackage()); // Lưu gói nếu chưa có
                Db.ExecuteNonQuery(sqlQuery,
                    new System.Data.SQLite.SQLiteParameter("@InvoiceDetailID", detail.GetID()),
                    new System.Data.SQLite.SQLiteParameter("@InvoiceID", invoiceID),
                    new System.Data.SQLite.SQLiteParameter("@ProductID", DBNull.Value),
                    new System.Data.SQLite.SQLiteParameter("@Quantity", detail.GetQuantity()),
                    new System.Data.SQLite.SQLiteParameter("@TotalAmount", detail.GetTotalAmount()),
                    new System.Data.SQLite.SQLiteParameter("@PackageID", packageID)
                );

                // Cập nhật tồn kho
                if (type.ToUpper() == "IMPORT")
                    InventoryDAL.UpdateImportStockQuantity(detail, warehouseID);
                else
                    InventoryDAL.UpdateExportStockQuantity(detail, warehouseID);
            }
        }

        /// <summary>
        /// Lấy danh sách chi tiết hóa đơn theo InvoiceID
        /// </summary>
        public List<InvoiceDetailDTO> GetByInvoiceID(string invoiceID)
        {
            List<InvoiceDetailDTO> details = new List<InvoiceDetailDTO>();

            string sqlQuery = "SELECT * FROM InvoiceDetail WHERE InvoiceID = @InvoiceID";
            var table = Db.ExecuteQuery(sqlQuery, new System.Data.SQLite.SQLiteParameter("@InvoiceID", invoiceID));

            foreach (DataRow row in table.Rows)
            {
                // Lấy thông tin Product nếu có
                string productID = row["ProductID"] != DBNull.Value ? row["ProductID"].ToString() : null;
                ProductDTO product = productID == null ? null : ProductDAL.GetByID(productID);

                // Lấy thông tin Package nếu có
                string packageID = row["PackageID"] != DBNull.Value ? row["PackageID"].ToString() : null;
                PackageDTO package = packageID == null ? null : PackageDAL.GetByID(packageID);

                // Tạo DTO chi tiết hóa đơn
                InvoiceDetailDTO detail = new InvoiceDetailDTO(
                    row["InvoiceDetailID"].ToString(),
                    product,
                    package,
                    Convert.ToInt32(row["Quantity"]),
                    Convert.ToDecimal(row["TotalAmount"])
                );

                details.Add(detail);
            }

            return details;
        }
    }
}
