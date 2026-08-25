using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcosystemApp.Utils;
using EcosystemApp.DTO;
using System.Data;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu cho OrderDetail, bao gồm lưu và truy xuất chi tiết đơn hàng.
    /// </summary>
    public class OrderDetailDAL
    {

        private readonly DatabaseHelper Db = new DatabaseHelper();
        public OrderDetailDAL() { }

        /// <summary>
        /// Lưu thông tin chi tiết đơn hàng vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="orderDetail">Đối tượng OrderDetailDTO cần lưu.</param>
        /// <param name="orderID">ID của đơn hàng chứa chi tiết này.</param>
        public void Save(OrderDetailDTO orderDetail, string orderID)
        {
            string sqlQuery = "INSERT INTO OrderDetail (OrderDetailID, OrderID, ProductID, ProductQuantity, TotalPrice) " +
                "VALUES (@OrderDetailID, @OrderID, @ProductID, @Quantity, @TotalPrice)";

            Db.ExecuteNonQuery(sqlQuery,
                new System.Data.SQLite.SQLiteParameter("@OrderDetailID", orderDetail.GetID()),
                new System.Data.SQLite.SQLiteParameter("@OrderID", orderID),
                new System.Data.SQLite.SQLiteParameter("@ProductID", orderDetail.GetProduct().GetID()),
                new System.Data.SQLite.SQLiteParameter("@Quantity", orderDetail.GetQuantity()),
                new System.Data.SQLite.SQLiteParameter("@TotalPrice", orderDetail.GetToTalPrice())
            );

            // TODO: Cập nhật số lượng sản phẩm trong kho nếu cần
        }

        /// <summary>
        /// Lấy danh sách chi tiết đơn hàng dựa trên OrderID.
        /// </summary>
        /// <param name="orderID">ID của đơn hàng cần truy xuất.</param>
        /// <returns>Danh sách OrderDetailDTO chứa chi tiết đơn hàng.</returns>
        public List<OrderDetailDTO> GetOrderDetailsByOrderID(string orderID)
        {
            List<OrderDetailDTO> orderDetails = new List<OrderDetailDTO>();

            string sqlQuery = "SELECT * FROM OrderDetail WHERE OrderID = @OrderID";

            var result = Db.ExecuteQuery(sqlQuery,
                new System.Data.SQLite.SQLiteParameter("@OrderID", orderID)
            );

            foreach (DataRow row in result.Rows)
            {
                string orderDetailID = row["OrderDetailID"].ToString();
                string productID = row["ProductID"].ToString();
                int quantity = Convert.ToInt32(row["ProductQuantity"]);
                decimal totalPrice = Convert.ToDecimal(row["TotalPrice"] == DBNull.Value ? "0" : row["TotalPrice"]);

                // Lấy thông tin sản phẩm từ ProductDAL
                ProductDAL productDAL = new ProductDAL();
                var product = productDAL.GetByID(productID);

                OrderDetailDTO orderDetail = new OrderDetailDTO(orderDetailID, product, quantity, totalPrice);

                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }
    }
}
