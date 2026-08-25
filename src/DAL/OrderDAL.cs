using DocumentFormat.OpenXml.Drawing.Charts;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;
using System.Data.SQLite;

namespace EcosystemApp.DAL
{
    public class OrderDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper(); // Khởi tạo helper để thao tác DB
        private readonly CustomerDAL CusDAL = new CustomerDAL(); // Khởi tạo DAL để thao tác Customer
        private readonly OrderDetailDAL OrderDetailDAL = new OrderDetailDAL(); // Khởi tạo DAL để thao tác chi tiết đơn hàng
        private readonly OrderPackagingDAL OrderPackagingDAL; // DAL quản lý đóng gói đơn hàng
        private readonly EmployeeDAL EmpDAL = new EmployeeDAL(); // DAL quản lý nhân viên

        public OrderDAL()
        {
            OrderPackagingDAL = new OrderPackagingDAL(this); // Khởi tạo DAL đóng gói và truyền OrderDAL hiện tại
        }

        /// <summary>
        /// Lưu một đơn hàng vào database, bao gồm chi tiết sản phẩm và đóng gói
        /// </summary>
        /// <param name="order">Đối tượng OrderDTO cần lưu</param>
        public void SaveOrder(OrderDTO order)
        {
            if (order != null) // Kiểm tra order không null
            {
                CusDAL.SaveCustomer(order.GetCustomer()); // Lưu thông tin khách hàng trước
                string sqlQuery = "INSERT INTO Orders (OrderID, OrderDate, TotalAmount, TransactionType, CustomerID, EmployeeID," +
                    " DeliveryEmployeeID, Status, DeliveryAddress, OrderAddress) VALUES (@OrderID, @OrderDate, @TotalAmount, @TransactionType," +
                    " @CustomerID, @EmployeeID, @DeliveryEmployeeID, @Status, @DeliveryAddress, @OrderAddress)"; // Chuẩn bị câu lệnh SQL
                Db.ExecuteNonQuery(sqlQuery,
                    new SQLiteParameter("@OrderID", order.GetID()), // ID đơn hàng
                    new SQLiteParameter("@OrderDate", order.GetOrderDate().ToString("yyyy-MM-dd HH:mm:ss")), // Ngày tạo đơn
                    new SQLiteParameter("@TotalAmount", order.GetTotalAmount()), // Tổng tiền đơn
                    new SQLiteParameter("@TransactionType", order.GetTransactionType()), // Loại giao dịch
                    new SQLiteParameter("@CustomerID", order.GetCustomer()?.GetID()), // ID khách hàng
                    new SQLiteParameter("@EmployeeID", order.GetEmployee()?.GetID()), // ID nhân viên tạo đơn
                    new SQLiteParameter("@DeliveryEmployeeID", order.GetDeliveryEmployeeID()), // ID nhân viên giao hàng
                    new SQLiteParameter("@Status", string.IsNullOrEmpty(order.GetDeliveryAddress()) ? "Complete" : order.GetStatus()), // Trạng thái đơn
                    new SQLiteParameter("@DeliveryAddress", order.GetDeliveryAddress()), // Địa chỉ giao hàng
                    new SQLiteParameter("@OrderAddress", order.GetOrderAddress()) // Địa chỉ đặt hàng
                );

                foreach (var o in order.GetOrderDetails()) // Duyệt từng chi tiết sản phẩm
                {
                    OrderDetailDAL.Save(o, order.GetID()); // Lưu chi tiết sản phẩm
                }

                foreach (var o in order.GetOrderPackagings()) // Duyệt từng đóng gói
                {
                    OrderPackagingDAL.Save(o, order.GetID()); // Lưu chi tiết đóng gói
                }
            }
        }

        /// <summary>
        /// Lưu nhiều đơn hàng cùng lúc
        /// </summary>
        /// <param name="orders">Danh sách OrderDTO cần lưu</param>
        public void SaveOrders(List<OrderDTO> orders)
        {
            foreach (var order in orders) // Duyệt danh sách đơn hàng
            {
                SaveOrder(order); // Gọi hàm SaveOrder cho từng đơn
            }
        }

        /// <summary>
        /// Lọc hóa đơn theo khoảng thời gian và trạng thái
        /// </summary>
        /// <param name="startDate">Ngày bắt đầu lọc</param>
        /// <param name="endDate">Ngày kết thúc lọc</param>
        /// <param name="status">Trạng thái đơn hàng (All lấy tất cả)</param>
        /// <returns>Danh sách OrderDTO thỏa điều kiện</returns>
        public List<OrderDTO> GetFilteredOrders(DateTime startDate, DateTime endDate, string status)
        {
            List<OrderDTO> FilteredOrders = new List<OrderDTO>(); // Khởi tạo danh sách kết quả
            string sqlQuery;

            if (status.Equals("All")) // Kiểm tra trạng thái "All"
            {
                sqlQuery = "SELECT * FROM Orders WHERE OrderDate >= @StartDate AND OrderDate <= @EndDate AND isDelete = @isDelete"; // Lấy tất cả trạng thái
            }
            else
            {
                sqlQuery = "SELECT * FROM Orders WHERE OrderDate >= @StartDate AND OrderDate <= @EndDate AND Status = @Status AND isDelete = @isDelete"; // Lọc theo trạng thái cụ thể
            }

            sqlQuery = sqlQuery.Replace("@StartDate", $"'{startDate.ToString("yyyy-MM-dd HH:mm:ss")}'"); // Thay StartDate
            sqlQuery = sqlQuery.Replace("@EndDate", $"'{endDate.ToString("yyyy-MM-dd HH:mm:ss")}'"); // Thay EndDate
            sqlQuery = sqlQuery.Replace("@Status", $"'{status}'"); // Thay Status
            var result = Db.ExecuteQuery(sqlQuery,
                    new SQLiteParameter("@isDelete", false) // Lọc các đơn chưa xóa
                );

            foreach (DataRow row in result.Rows) // Duyệt từng dòng kết quả
            {
                string orderID = row["OrderID"].ToString(); // Lấy OrderID
                string transactionType = row["TransactionType"].ToString(); // Lấy loại giao dịch
                string deliveryEmployeeID = row["DeliveryEmployeeID"].ToString(); // Lấy nhân viên giao hàng
                string employeeID = row["EmployeeID"].ToString(); // Lấy nhân viên tạo đơn
                string customerID = row["CustomerID"].ToString(); // Lấy khách hàng
                DateTime orderDate = DateTime.Parse(row["OrderDate"].ToString()); // Lấy ngày đơn
                status = row["Status"].ToString(); // Lấy trạng thái
                decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]); // Lấy tổng tiền
                string deliveryAddress = row["DeliveryAddress"].ToString(); // Lấy địa chỉ giao
                string orderAddress = row["OrderAddress"].ToString(); // Lấy địa chỉ đặt

                var customer = CusDAL.GetById(customerID); // Lấy thông tin khách hàng
                var employee = EmpDAL.GetById(employeeID); // Lấy thông tin nhân viên
                var orderDetails = OrderDetailDAL.GetOrderDetailsByOrderID(orderID); // Lấy chi tiết sản phẩm
                var orderPackagings = OrderPackagingDAL.GetOrderPackagingByOrderID(orderID); // Lấy chi tiết đóng gói
                OrderDTO order = new OrderDTO(orderID, orderDate, transactionType, customer, employee,
                    deliveryEmployeeID, status, orderDetails, orderPackagings, totalAmount, deliveryAddress, orderAddress); // Tạo đối tượng OrderDTO
                FilteredOrders.Add(order); // Thêm vào danh sách
            }
            return FilteredOrders; // Trả về danh sách kết quả
        }

        /// <summary>
        /// Xóa mềm đơn hàng
        /// </summary>
        /// <param name="orderID">ID đơn hàng cần xóa</param>
        public void DeleteOrder(string orderID)
        {
            string sqlQuery = "UPDATE Orders SET isDelete = @isDelete WHERE OrderID = @orderID"; // Câu lệnh xóa mềm
            Db.ExecuteNonQuery(sqlQuery,
                    new SQLiteParameter("@orderID", orderID), // OrderID cần xóa
                    new SQLiteParameter("@isDelete", 1) // Đánh dấu xóa
            );
        }

        /// <summary>
        /// Cập nhật trạng thái đơn hàng dựa trên hành động đóng gói (issue/return)
        /// </summary>
        /// <param name="orderID">ID đơn hàng cần cập nhật</param>
        public void UpdateOrderStatus(string orderID)
        {
            string sqlQuery = "SELECT * FROM OrderPackaging WHERE OrderID = @OrderID"; // Lấy đóng gói của đơn
            var dt = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@OrderID", orderID) // Tham số OrderID
            );

            int trackingCount = 0; // Biến đếm hành động
            if (dt.Rows.Count > 0) // Nếu có đóng gói
            {
                foreach (DataRow row in dt.Rows) // Duyệt từng dòng
                {
                    if (row["ActionType"].ToString().ToLower().Equals("issue")) // Nếu phát hành
                    {
                        trackingCount++; // Cộng
                    }
                    else // Nếu trả lại
                    {
                        trackingCount--; // Trừ
                    }
                }
            }

            if (trackingCount == 0) // Nếu tất cả package đã trả
            {
                sqlQuery = "Update Orders Set Status = @Status Where OrderID  = @OrderID"; // Cập nhật trạng thái
                Db.ExecuteNonQuery(sqlQuery,
                    new SQLiteParameter("@Status", "Recall Package"), // Cập nhật trạng thái
                    new SQLiteParameter("@OrderID", orderID) // OrderID
                );
            }
        }

        /// <summary>
        /// Thống kê doanh thu theo ngày/tuần/tháng
        /// </summary>
        /// <param name="type">Ngày, Tuần, Tháng</param>
        /// <param name="date">Ngày/tháng/năm làm cơ sở thống kê</param>
        /// <returns>DataTable thống kê doanh thu</returns>
        public System.Data.DataTable GetRevenue(string type, DateTime date)
        {
            string sql = ""; // Chuỗi SQL
            SQLiteParameter[] param; // Tham số query

            if (type == "Ngày") // Nếu theo ngày
            {
                sql = @"
                    SELECT 
                        strftime('%d/%m/%Y', OrderDate) AS Ngay,
                        COUNT(*) AS SoDon,
                        SUM(TotalAmount) AS DoanhThu
                    FROM Orders
                    WHERE 
                        strftime('%Y', OrderDate) = @Year AND
                        strftime('%m', OrderDate) = @Month AND
                        isDelete = 0
                    GROUP BY strftime('%d/%m/%Y', OrderDate)
                    ORDER BY date(OrderDate) ASC;
                ";
                param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")), // Năm
                    new SQLiteParameter("@Month", date.ToString("MM")) // Tháng
                };
            }
            else if (type == "Tuần") // Nếu theo tuần
            {
                sql = @"
                    SELECT 
                        'Tuần ' || (CAST((strftime('%d', OrderDate)-1)/7 AS INTEGER)+1) AS Ngay,
                        COUNT(*) AS SoDon,
                        SUM(TotalAmount) AS DoanhThu
                    FROM Orders
                    WHERE 
                        strftime('%Y', OrderDate) = @Year AND
                        strftime('%m', OrderDate) = @Month AND
                        isDelete = 0
                    GROUP BY CAST((strftime('%d', OrderDate)-1)/7 AS INTEGER)+1
                    ORDER BY MIN(date(OrderDate)) ASC;
                ";
                param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")), // Năm
                    new SQLiteParameter("@Month", date.ToString("MM")) // Tháng
                };
            }
            else // Theo tháng
            {
                sql = @"
                    SELECT 
                        strftime('%m/%Y', OrderDate) AS Ngay,
                        COUNT(*) AS SoDon,
                        SUM(TotalAmount) AS DoanhThu
                    FROM Orders
                    WHERE 
                        strftime('%Y', OrderDate) = @Year AND
                        isDelete = 0
                    GROUP BY strftime('%m/%Y', OrderDate)
                    ORDER BY strftime('%m', OrderDate) ASC;
                ";
                param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")) // Năm
                };
            }

            return Db.ExecuteQuery(sql, param); // Trả về DataTable
        }

        /// <summary>
        /// Thống kê tần suất khách hàng đặt lại (refill) theo tháng hoặc năm
        /// </summary>
        /// <param name="date">Ngày cơ sở thống kê</param>
        /// <param name="type">Loại: Tháng hoặc Năm</param>
        /// <returns>DataTable thống kê refill</returns>
        public System.Data.DataTable GetCustomerRefillFrequency(DateTime date, string type)
        {
            string dateFilter = ""; // Biến filter

            if (type == "Tháng") // Nếu lọc theo tháng
            {
                dateFilter = "WHERE strftime('%Y-%m', OrderDate) = @Period"; // Filter tháng
            }
            else if (type == "Năm") // Nếu lọc theo năm
            {
                dateFilter = "WHERE strftime('%Y', OrderDate) = @Period"; // Filter năm
            }

            string query = $@"
                SELECT 
                    CustomerID,
                    COUNT(OrderID) AS TotalOrders,
                    COUNT(OrderID) - 1 AS RefillCount
                FROM Orders
                {dateFilter}
                GROUP BY CustomerID
                ORDER BY RefillCount DESC;
            ";

            string periodValue = type == "Tháng"
                                    ? date.ToString("yyyy-MM") // Giá trị tháng
                                    : date.ToString("yyyy"); // Giá trị năm

            return Db.ExecuteQuery(query,
                new SQLiteParameter("@Period", periodValue) // Tham số Period
            );
        }

        /// <summary>
        /// Thống kê giảm rác (waste reduction) theo ngày/tuần/tháng
        /// </summary>
        /// <param name="type">Ngày, Tuần, Tháng</param>
        /// <param name="date">Ngày/tháng/năm cơ sở</param>
        /// <returns>DataTable thống kê ReuseCount</returns>
        public System.Data.DataTable GetWasteReduction(string type, DateTime date)
        {
            string sql = ""; // Chuỗi SQL
            SQLiteParameter[] param; // Tham số

            string baseWhere = @"
                (
                    (op.ActionType = 'ISSUE' AND op.TotalBill = 0) 
                    OR 
                    (op.ActionType = 'RETURN' AND op.TotalBill > 0)
                )
            "; // Điều kiện tái sử dụng

            if (type == "Ngày") // Nếu theo ngày
            {
                sql = $@"
                    SELECT 
                        strftime('%d/%m/%Y', op.ActionDate) AS Day,
                        COUNT(op.OrderPackagingID) AS ReuseCount
                    FROM OrderPackaging op
                    WHERE 
                        {baseWhere}
                        AND strftime('%Y', op.ActionDate) = @Year
                        AND strftime('%m', op.ActionDate) = @Month
                    GROUP BY strftime('%d/%m/%Y', op.ActionDate)
                    ORDER BY date(op.ActionDate) ASC;
                ";
                param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")), // Năm
                    new SQLiteParameter("@Month", date.ToString("MM")) // Tháng
                };
            }
            else if (type == "Tuần") // Nếu theo tuần
            {
                sql = $@"
                    SELECT 
                        'Tuần ' || (CAST((strftime('%d', op.ActionDate)-1)/7 AS INTEGER)+1) AS Day,
                        COUNT(op.OrderPackagingID) AS ReuseCount
                    FROM OrderPackaging op
                    WHERE 
                        {baseWhere} AND
                        strftime('%Y', op.ActionDate) = @Year AND
                        strftime('%m', op.ActionDate) = @Month
                    GROUP BY CAST((strftime('%d', op.ActionDate)-1)/7 AS INTEGER)+1
                    ORDER BY MIN(date(op.ActionDate)) ASC;
                ";
                param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")), // Năm
                    new SQLiteParameter("@Month", date.ToString("MM")) // Tháng
                };
            }
            else // Nếu theo tháng
            {
                sql = $@"
                    SELECT 
                        strftime('%m/%Y', op.ActionDate) AS Day,
                        COUNT(op.OrderPackagingID) AS ReuseCount
                    FROM OrderPackaging op
                    WHERE 
                        {baseWhere} AND
                        strftime('%Y', op.ActionDate) = @Year
                    GROUP BY strftime('%m/%Y', op.ActionDate)
                    ORDER BY strftime('%m', op.ActionDate) ASC;
                ";
                param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")) // Năm
                };
            }

            return Db.ExecuteQuery(sql, param); // Trả về DataTable
        }

        /// <summary>
        /// Lấy thông tin đơn hàng theo ID
        /// </summary>
        /// <param name="orderID">ID đơn hàng</param>
        /// <returns>OrderDTO nếu tồn tại, null nếu không</returns>
        public OrderDTO GetOrderByID(string orderID)
        {
            string query = @"SELECT * FROM Orders WHERE OrderID = @OrderID AND isDelete = 0";
            var dt = Db.ExecuteQuery(query, new SQLiteParameter("@OrderID", orderID));

            if (dt.Rows.Count == 0)
                return null;

            var row = dt.Rows[0];

            OrderDTO order = new OrderDTO();
            order.SetID(row["OrderID"].ToString());

            // Khởi tạo CustomerDTO và EmployeeDTO
            CustomerDTO customer = new CustomerDTO();
            customer.SetID(row["CustomerID"].ToString());
            order.SetCustomer(customer);

            EmployeeDTO employee = new EmployeeDTO();
            employee.SetID(row["EmployeeID"].ToString());
            order.SetEmployee(employee);

            order.SetDeliveryEmployeeID(row["DeliveryEmployeeID"].ToString());

            order.SetStatus(row["Status"].ToString());
            order.SetDeliveryAddress(row["DeliveryAddress"].ToString());
            order.SetOrderAddress(row["OrderAddress"].ToString());

            return order;
        }

        /// <summary>
        /// Lấy danh sách đơn hàng mới
        /// </summary>
        /// <returns>DataTable chứa các đơn hàng mới</returns>
        public System.Data.DataTable GetNewOrders()
        {
            string query = "SELECT o.OrderID, o.OrderDate, o.TotalAmount, o.Status, o.DeliveryAddress" +
                            "FROM Orders o" +
                            "INNER JOIN Employee e ON o.EmployeeID = e.EmployeeID" +
                            "WHERE e.StationID = @StationID  AND o.Status = 'New';";
            return Db.ExecuteQuery(query);
        }

        /// <summary>
        /// Lấy danh sách đơn hàng mới theo trạm
        /// </summary>
        /// <param name="stationID">ID trạm</param>
        /// <returns>DataTable các đơn hàng mới tại trạm</returns>
        public System.Data.DataTable GetNewOrdersByStation(string stationID)
        {
            string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount, o.Status, o.DeliveryAddress
                                FROM Orders o
                                INNER JOIN Employee e ON o.EmployeeID = e.EmployeeID
                                WHERE e.StationID = @StationID
                                AND o.Status = 'New' ";

            SQLiteParameter param = new SQLiteParameter("@StationID", stationID);
            return Db.ExecuteQuery(query, param);
        }

        /// <summary>
        /// Lấy danh sách đơn hàng chuẩn bị theo trạm
        /// </summary>
        /// <param name="stationID">ID trạm</param>
        /// <returns>DataTable các đơn hàng chuẩn bị tại trạm</returns>
        public System.Data.DataTable GetPrepareOrdersByStation(string stationID)
        {
            string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount, o.Status, o.DeliveryAddress
                                FROM Orders o
                                INNER JOIN Employee e ON o.EmployeeID = e.EmployeeID
                                WHERE e.StationID = @StationID
                                AND o.Status = 'Prepare' ";

            SQLiteParameter param = new SQLiteParameter("@StationID", stationID);
            return Db.ExecuteQuery(query, param);
        }

    }
}
