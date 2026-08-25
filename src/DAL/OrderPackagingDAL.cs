using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;
using System.Data.SQLite;


namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu cho OrderPackaging, bao gồm lưu, truy xuất và thống kê hành động bao bì.
    /// </summary>
    public class OrderPackagingDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();
        private readonly PackageDAL PackageDAL = new PackageDAL();
        private readonly OrderDAL OrderDAL;

        /// <summary>
        /// Constructor khởi tạo OrderPackagingDAL với đối tượng OrderDAL.
        /// </summary>
        /// <param name="orderDAL">Đối tượng OrderDAL để thao tác dữ liệu Order.</param>
        public OrderPackagingDAL(OrderDAL orderDAL)
        {
            OrderDAL = orderDAL;
        }

        /// <summary>
        /// Lưu thông tin OrderPackaging vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="orderPackaging">Đối tượng OrderPackagingDTO cần lưu.</param>
        /// <param name="orderID">ID của đơn hàng.</param>
        public void Save(OrderPackagingDTO orderPackaging, string orderID)
        {
            string sqlQuery = "INSERT INTO OrderPackaging (OrderPackagingID, OrderID, PackageID, ActionType, ActionDate, TotalBill) " +
                              "VALUES (@OrderPackagingID, @OrderID, @PackageID, @ActionType, @ActionDate, @TotalBill)";

            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@OrderPackagingID", orderPackaging.GetID()),
                new SQLiteParameter("@OrderID", orderID),
                new SQLiteParameter("@PackageID", orderPackaging.GetPackage().GetID()),
                new SQLiteParameter("@ActionType", orderPackaging.GetActionType()),
                new SQLiteParameter("@ActionDate", orderPackaging.GetActionDate().ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@TotalBill", orderPackaging.GetTotalBill())
           );

            // Cập nhật Package liên quan sau khi lưu OrderPackaging
            PackageDAL.Update(orderPackaging.GetPackage());
        }

        /// <summary>
        /// Lấy danh sách OrderPackaging theo OrderID.
        /// </summary>
        /// <param name="orderID">ID của đơn hàng.</param>
        /// <returns>Danh sách OrderPackagingDTO.</returns>
        public List<OrderPackagingDTO> GetOrderPackagingByOrderID(string orderID)
        {
            List<OrderPackagingDTO> orderPackagings = new List<OrderPackagingDTO>();
            string sqlQuery = "SELECT * FROM OrderPackaging WHERE OrderID = @OrderID";

            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@OrderID", orderID)
            );

            foreach (DataRow row in result.Rows)
            {
                string orderPackagingID = row["OrderPackagingID"].ToString();
                string packageID = row["PackageID"].ToString();
                string actionType = row["ActionType"].ToString();
                DateTime actionDate = DateTime.Parse(row["ActionDate"].ToString());
                decimal totalBill = decimal.Parse(row["TotalBill"].ToString());

                var package = PackageDAL.GetByID(packageID);
                var orderPackaging = new OrderPackagingDTO(orderPackagingID, package, actionType, actionDate, totalBill);
                orderPackagings.Add(orderPackaging);
            }

            return orderPackagings;
        }

        /// <summary>
        /// Lưu danh sách OrderPackaging trả về.
        /// </summary>
        /// <param name="orderPackagings">Danh sách OrderPackagingDTO cần lưu.</param>
        public void SaveReturnOrderPackagings(List<OrderPackagingDTO> orderPackagings)
        {
            foreach (var orderPackaging in orderPackagings)
            {
                SaveReturnOrderPackaging(orderPackaging);
            }
        }

        /// <summary>
        /// Lưu thông tin OrderPackaging trả về một Order.
        /// </summary>
        /// <param name="orderPackaging">Đối tượng OrderPackagingDTO.</param>
        public void SaveReturnOrderPackaging(OrderPackagingDTO orderPackaging)
        {
            DateTime startDate = orderPackaging.GetActionDate().Date;
            DateTime endDate = startDate.AddDays(1);

            // Lấy danh sách Orders hợp lệ chưa trả Package
            string sqlSelectOrders = @"
                SELECT O.OrderID, OP.TotalBill
                FROM Orders O
                LEFT JOIN OrderPackaging OP
                    ON OP.OrderID = O.OrderID
                    AND OP.PackageID = @PackageID
                    AND OP.ActionType = 'RETURN'
                WHERE O.Status <> 'Đã thu hồi bao bì'
                    AND OP.OrderID IS NULL
                    AND O.OrderDate < @Date
                ORDER BY O.OrderID
            ";

            DataTable dtOrders = Db.ExecuteQuery(sqlSelectOrders,
                new SQLiteParameter("@PackageID", orderPackaging.GetPackage().GetID()),
                new SQLiteParameter("@Date", endDate.ToString("yyyy-MM-dd HH:mm:ss"))
            );

            bool firstInsert = true;

            foreach (DataRow row in dtOrders.Rows)
            {
                string orderID = row["OrderID"].ToString();

                // Kiểm tra Order này có Package không
                string checkSql = @"
                        SELECT 1 
                        FROM OrderPackaging
                        WHERE OrderID = @OrderID
                          AND PackageID = @PackageID
                          AND ActionType = 'ISSUE'
                        LIMIT 1
                    ";
                var check = Db.ExecuteQuery(checkSql,
                    new SQLiteParameter("@OrderID", orderID),
                    new SQLiteParameter("@PackageID", orderPackaging.GetPackage().GetID())
                );

                if (check.Rows.Count == 0)
                {
                    // Order không sử dụng Package -> bỏ qua
                    continue;
                }

                decimal totalBill = firstInsert ? orderPackaging.GetPackage().GetPackagingType().GetDeposit() : 0;
                firstInsert = false;

                // Thêm bản ghi RETURN
                string insertSql = @"
                        INSERT INTO OrderPackaging
                        (OrderPackagingID, OrderID, PackageID, ActionType, TotalBill, ActionDate)
                        VALUES
                        (@OrderPackagingID, @OrderID, @PackageID, 'RETURN', @TotalBill, @Date)
                    ";

                Db.ExecuteNonQuery(insertSql,
                    new SQLiteParameter("@OrderPackagingID", Guid.NewGuid().ToString()),
                    new SQLiteParameter("@OrderID", orderID),
                    new SQLiteParameter("@PackageID", orderPackaging.GetPackage().GetID()),
                    new SQLiteParameter("@TotalBill", totalBill),
                    new SQLiteParameter("@Date", orderPackaging.GetActionDate())
                );

                // Cập nhật trạng thái Order
                OrderDAL.UpdateOrderStatus(orderID);
            }

            // Cập nhật Package sau khi thu hồi
            var package = orderPackaging.GetPackage();
            package.SetReuseCount(package.GetReuseCount() + 1);
            PackageDAL.Update(package);
        }

        /// <summary>
        /// Lấy tổng số lượng RETURN theo các loại PackagingType.
        /// </summary>
        /// <param name="orderPackaging">Danh sách PackagingTypeDTO (tham số hiện chưa sử dụng trong SQL).</param>
        /// <returns>DataTable chứa tổng số RETURN theo loại PackagingType.</returns>
        public DataTable GetTotalReturnPackageTypes(List<PackagingTypeDTO> orderPackaging)
        {
            string sqlQuery =
                "SELECT PT.PackagingTypeID, COUNT(*) AS TotalIssued " +
                "FROM PackagingType PT " +
                "INNER JOIN Package P ON P.PackagingTypeID = PT.PackagingTypeID " +
                "INNER JOIN OrderPackaging OP ON P.PackageID = OP.PackageID " +
                "WHERE OP.ActionType = 'RETURN' AND OP.TotalBill > 0 " +
                "GROUP BY PT.PackagingTypeID;";

            return Db.ExecuteQuery(sqlQuery);
        }

        /// <summary>
        /// Lấy tổng số lượng ISSUE theo các loại PackagingType.
        /// </summary>
        /// <param name="orderPackaging">Danh sách PackagingTypeDTO (tham số hiện chưa sử dụng trong SQL).</param>
        /// <returns>DataTable chứa tổng số ISSUE theo loại PackagingType.</returns>
        public DataTable GetTotalIssuePackageTypes(List<PackagingTypeDTO> orderPackaging)
        {
            string sqlQuery =
                "SELECT PT.PackagingTypeID, COUNT(*) AS TotalIssued " +
                "FROM PackagingType PT " +
                "INNER JOIN Package P ON P.PackagingTypeID = PT.PackagingTypeID " +
                "INNER JOIN OrderPackaging OP ON P.PackageID = OP.PackageID " +
                "WHERE OP.ActionType = 'ISSUE' AND OP.TotalBill > 0 " +
                "GROUP BY PT.PackagingTypeID;";

            return Db.ExecuteQuery(sqlQuery);
        }

        /// <summary>
        /// Lấy dữ liệu thống kê Package theo ActionType và khoảng thời gian.
        /// </summary>
        /// <param name="actionType">ActionType ('ISSUE' hoặc 'RETURN').</param>
        /// <param name="startDate">Ngày bắt đầu.</param>
        /// <param name="endDate">Ngày kết thúc.</param>
        /// <param name="dateFormat">Định dạng ngày hiển thị (ví dụ 'dd/MM/yyyy').</param>
        /// <returns>Dictionary: key là ngày/tháng, value là số lượng.</returns>
        public Dictionary<string, int> GetPackageData(string actionType, DateTime startDate, DateTime endDate, string dateFormat)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            DateTime date = startDate.Date;
            while (date <= endDate.Date)
            {
                string label = date.ToString(dateFormat);
                result[label] = 0;

                DateTime nextDate;
                if (dateFormat.Contains("d"))
                    nextDate = date.AddDays(1);
                else if (dateFormat.Contains("M") && dateFormat.Contains("y"))
                    nextDate = date.AddMonths(1);
                else
                    nextDate = date.AddDays(1);

                string sqlQuery = @"
                    SELECT COUNT(*) AS Total
                    FROM OrderPackaging
                    WHERE ActionType = @actionType
                      AND ActionDate >= @startDate
                      AND ActionDate < @endDate
                      AND TotalBill > 0;";

                SQLiteParameter[] parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@actionType", actionType),
                    new SQLiteParameter("@startDate", date.ToString("yyyy-MM-dd HH:mm:ss")),
                    new SQLiteParameter("@endDate", nextDate.ToString("yyyy-MM-dd HH:mm:ss"))
                };

                DataTable dt = Db.ExecuteQuery(sqlQuery, parameters);

                if (dt.Rows.Count > 0)
                    result[label] = Convert.ToInt32(dt.Rows[0]["Total"]);

                date = nextDate;
            }

            return result;
        }

        /// <summary>
        /// Lấy bảng tổng hợp RETURN và ISSUE theo tháng hoặc năm.
        /// </summary>
        /// <param name="type">"Tháng" hoặc "Năm".</param>
        /// <param name="date">Ngày đại diện cho tháng hoặc năm cần thống kê.</param>
        /// <returns>DataTable tổng hợp số lượng RETURN và ISSUE.</returns>
        public DataTable GetPackageReturnAndIssueSummary(string type, DateTime date)
        {
            string sql = "";
            SQLiteParameter[] parameters;

            if (type == "Tháng")
            {
                sql = @"
                    SELECT 
                        'Tuần ' || ((CAST(strftime('%d', ActionDate) AS INTEGER)-1)/7 + 1) AS TimePeriod,
                        SUM(CASE WHEN ActionType = 'ISSUE' AND TotalBill > 0 THEN 1 ELSE 0 END) AS Issued,
                        SUM(CASE WHEN ActionType = 'RETURN' AND TotalBill > 0 THEN 1 ELSE 0 END) AS Returned
                    FROM OrderPackaging
                    WHERE strftime('%Y', ActionDate) = @Year
                      AND strftime('%m', ActionDate) = @Month
                    GROUP BY ((CAST(strftime('%d', ActionDate) AS INTEGER)-1)/7 + 1)
                    ORDER BY MIN(date(ActionDate)) ASC;
                ";

                parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy")),
                    new SQLiteParameter("@Month", date.ToString("MM"))
                };
            }
            else
            {
                sql = @"
                    SELECT 
                        strftime('%m/%Y', ActionDate) AS TimePeriod,
                        SUM(CASE WHEN ActionType = 'ISSUE' AND TotalBill > 0 THEN 1 ELSE 0 END) AS Issued,
                        SUM(CASE WHEN ActionType = 'RETURN' AND TotalBill > 0 THEN 1 ELSE 0 END) AS Returned
                    FROM OrderPackaging
                    WHERE strftime('%Y', ActionDate) = @Year
                    GROUP BY strftime('%m', ActionDate)
                    ORDER BY strftime('%m', ActionDate) ASC;
                ";

                parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Year", date.ToString("yyyy"))
                };
            }

            return Db.ExecuteQuery(sql, parameters);
        }
    }
}
