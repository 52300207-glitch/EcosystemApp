using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến kho (Warehouse)
    /// </summary>
    public class WarehouseBUS
    {
        // DAL xử lý dữ liệu kho
        private readonly WarehouseDAL WarehouseDAL = new WarehouseDAL();

        /// <summary>
        /// Lấy danh sách tất cả các kho
        /// </summary>
        /// <returns>Danh sách WarehouseDTO</returns>
        public List<WarehouseDTO> GetAllWarehouse()
        {
            return WarehouseDAL.GetAllWarehouse();
        }

        /// <summary>
        /// Lấy thông tin kho theo ID
        /// </summary>
        /// <param name="id">ID của kho</param>
        /// <returns>WarehouseDTO nếu tìm thấy, ngược lại trả về null</returns>
        public WarehouseDTO GetWarehouseByID(string id)
        {
            return WarehouseDAL.GetWarehouseByID(id);
        }
    }
}
