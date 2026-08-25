using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;


namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu Warehouse, bao gồm các thao tác truy vấn thông tin kho.
    /// </summary>
    public class WarehouseDAL
    {
        private DatabaseHelper Db = new DatabaseHelper();

        /// <summary>
        /// Lấy danh sách tất cả các kho.
        /// </summary>
        /// <returns>Danh sách WarehouseDTO.</returns>
        public List<WarehouseDTO> GetAllWarehouse()
        {
            string sqlQuery = "SELECT WarehouseID, WarehouseName, Address, isCentral FROM Warehouse";
            var dt = Db.ExecuteQuery(sqlQuery);

            List<WarehouseDTO> warehouses = new List<WarehouseDTO>();

            foreach (DataRow row in dt.Rows)
            {
                var warehouse = new WarehouseDTO(
                    row["WarehouseID"].ToString(),
                    row["Address"].ToString(),
                    row["WarehouseName"].ToString(),
                    Convert.ToBoolean(row["isCentral"])
                );

                warehouses.Add(warehouse);
            }

            return warehouses;
        }

        /// <summary>
        /// Lấy thông tin kho theo WarehouseID.
        /// </summary>
        /// <param name="warehouseID">ID của kho cần lấy.</param>
        /// <returns>WarehouseDTO nếu tồn tại, ngược lại null.</returns>
        public WarehouseDTO GetWarehouseByID(string warehouseID)
        {
            string sqlQuery = "SELECT WarehouseID, WarehouseName, Address, isCentral FROM Warehouse WHERE WarehouseID = @WarehouseID";
            var dt = Db.ExecuteQuery(sqlQuery,
                new System.Data.SQLite.SQLiteParameter("@WarehouseID", warehouseID)
            );

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var warehouse = new WarehouseDTO(
                    row["WarehouseID"].ToString(),
                    row["Address"].ToString(),
                    row["WarehouseName"].ToString(),
                    Convert.ToBoolean(row["isCentral"])
                );

                return warehouse;
            }

            return null;
        }
    }
}