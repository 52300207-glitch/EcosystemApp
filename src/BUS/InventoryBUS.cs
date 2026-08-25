using EcosystemApp.DAL;
using EcosystemApp.DTO;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// Xử lý nghiệp vụ liên quan đến tồn kho (Inventory).
    /// </summary>
    public class InventoryBUS
    {
        // Data Access Layer dùng để thao tác với dữ liệu tồn kho trong database
        private InventoryDAL InventoryDAL = new InventoryDAL();

        /// <summary>
        /// Lấy danh sách tồn kho theo mã kho.
        /// </summary>
        /// <param name="warehouseID">Mã kho cần lấy tồn.</param>
        /// <returns>Danh sách tồn kho theo mã kho.</returns>
        public List<InventoryDTO> GetByWarehouseID(string warehouseID)
        {
            return InventoryDAL.GetByWarehouseID(warehouseID);
        }

        /// <summary>
        /// Cập nhật số lượng tồn của bao bì sau khi đơn hàng được xử lý.
        /// </summary>
        /// <param name="orderPackagingDTOs">Danh sách bao bì trong đơn hàng.</param>
        /// <param name="warehouseID">Mã kho cần cập nhật.</param>
        public void UpdatePackageStockQuantity(List<OrderPackagingDTO> orderPackagingDTOs, string warehouseID)
        {
            InventoryDAL.UpdatePackageStockQuantity(orderPackagingDTOs, warehouseID);
        }

        /// <summary>
        /// Cập nhật lại mã sản phẩm trong tồn kho (khi đổi ID sản phẩm).
        /// </summary>
        /// <param name="oldProductId">Mã sản phẩm cũ.</param>
        /// <param name="newProductId">Mã sản phẩm mới.</param>
        public void UpdateProductIdInStock(string oldProductId, string newProductId)
        {
            InventoryDAL.UpdateProductIdInStock(oldProductId, newProductId);
        }

    }
}
