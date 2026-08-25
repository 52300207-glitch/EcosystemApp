using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến bao bì trong đơn hàng
    /// </summary>
    public class OrderPackagingBUS
    {
        // DAL tương tác dữ liệu cho bao bì, phụ thuộc vào OrderDAL
        private OrderPackagingDAL OrderPackagingDAL = new OrderPackagingDAL(new OrderDAL());

        /// <summary>
        /// Lưu thông tin bao bì trả lại
        /// </summary>
        /// <param name="orderPackagings">Danh sách bao bì trả lại</param>
        public void SaveReturnOrderPackagings(List<OrderPackagingDTO> orderPackagings)
        {
            OrderPackagingDAL.SaveReturnOrderPackagings(orderPackagings);
        }

        /// <summary>
        /// Lấy tổng số lượng từng loại bao bì đã trả về
        /// </summary>
        /// <param name="orderPackagings">Danh sách loại bao bì</param>
        /// <returns>Danh sách số lượng trả về theo thứ tự đầu vào</returns>
        public List<int> GetTotalReturnPackageTypes(List<PackagingTypeDTO> orderPackagings)
        {
            var table = OrderPackagingDAL.GetTotalReturnPackageTypes(orderPackagings);

            // Dictionary lưu tổng số lượng theo typeID
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (DataRow row in table.Rows)
            {
                string typeID = row["PackagingTypeID"].ToString();
                int total = Convert.ToInt32(row["TotalIssued"]);

                dict[typeID] = total;
            }

            // Trả về List<int theo đúng thứ tự của orderPackaging
            List<int> totals = new List<int>();

            foreach (var item in orderPackagings)
            {
                string key = item.GetID().ToString();  // ép DTO sang string

                if (dict.ContainsKey(key))
                    totals.Add(dict[key]);
                else
                    totals.Add(0); // nếu không có dữ liệu, trả về 0
            }

            return totals;
        }

        /// <summary>
        /// Lấy tổng số lượng từng loại bao bì đã xuất
        /// </summary>
        /// <param name="orderPackagings">Danh sách loại bao bì</param>
        /// <returns>Danh sách số lượng xuất theo thứ tự đầu vào</returns>
        public List<int> GetTotalIssuePackageTypes(List<PackagingTypeDTO> orderPackagings)
        {
            var table = OrderPackagingDAL.GetTotalIssuePackageTypes(orderPackagings);

            // Dictionary lưu tổng số lượng theo typeID
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (DataRow row in table.Rows)
            {
                string typeID = row["PackagingTypeID"].ToString();
                int total = Convert.ToInt32(row["TotalIssued"]);

                dict[typeID] = total;
            }

            // Trả về List<int theo đúng thứ tự của orderPackaging
            List<int> totals = new List<int>();

            foreach (var item in orderPackagings)
            {
                string key = item.GetID().ToString();  // ép DTO sang string

                if (dict.ContainsKey(key))
                    totals.Add(dict[key]);
                else
                    totals.Add(0);
            }

            return totals;
        }

        /// <summary>
        /// Lấy dữ liệu xuất bao bì theo khoảng thời gian
        /// </summary>
        /// <param name="range">Khoảng thời gian ("Tuần trước", "1 tháng trước", "12 tháng trước")</param>
        /// <returns>Dictionary với key = ngày/tháng, value = số lượng xuất</returns>
        public Dictionary<string, int> GetIssueData(string range)
        {
            DateTime today = DateTime.Now.Date;
            DateTime startDate, endDate;
            string dateFormat;

            // Xác định khoảng thời gian dựa trên range
            switch (range)
            {
                case "Tuần trước":
                    endDate = today.AddDays(-1);
                    startDate = endDate.AddDays(-6);
                    dateFormat = "dd/MM"; // hiển thị ngày/tháng
                    break;
                case "1 tháng trước":
                    startDate = new DateTime(today.Year, today.Month, today.Day).AddMonths(-1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    dateFormat = "dd/MM"; // hiển thị ngày/tháng
                    break;
                case "12 tháng trước":
                    startDate = new DateTime(today.Year, today.Month, 1).AddMonths(-12);
                    endDate = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);
                    dateFormat = "MM/yyyy"; // hiển thị tháng/năm
                    break;
                default:
                    return new Dictionary<string, int>();
            }

            return OrderPackagingDAL.GetPackageData("ISSUE", startDate, endDate, dateFormat);
        }

        /// <summary>
        /// Lấy dữ liệu trả bao bì theo khoảng thời gian
        /// </summary>
        /// <param name="range">Khoảng thời gian ("Tuần trước", "1 tháng trước", "12 tháng trước")</param>
        /// <returns>Dictionary với key = ngày/tháng, value = số lượng trả</returns>
        public Dictionary<string, int> GetReturnData(string range)
        {
            DateTime today = DateTime.Now.Date;
            DateTime startDate, endDate;
            string dateFormat;

            // Xác định khoảng thời gian dựa trên range
            switch (range)
            {
                case "Tuần trước":
                    endDate = today.AddDays(-1);
                    startDate = endDate.AddDays(-6);
                    dateFormat = "dd/MM";
                    break;
                case "1 tháng trước":
                    startDate = new DateTime(today.Year, today.Month, today.Day).AddMonths(-1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    dateFormat = "dd/MM"; // hiển thị ngày/tháng
                    break;
                case "12 tháng trước":
                    // 12 tháng tính từ tháng hiện tại
                    startDate = new DateTime(today.Year, today.Month, 1).AddMonths(-12);
                    endDate = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);
                    dateFormat = "MM/yyyy"; // hiển thị tháng/năm
                    break;
                default:
                    return new Dictionary<string, int>();
            }

            return OrderPackagingDAL.GetPackageData("RETURN", startDate, endDate, dateFormat);
        }

        /// <summary>
        /// Lấy bảng tổng hợp số lượng xuất/trả bao bì theo loại
        /// </summary>
        /// <param name="type">Loại dữ liệu ("ISSUE" hoặc "RETURN")</param>
        /// <param name="date">Ngày cần thống kê</param>
        /// <returns>DataTable chứa tổng hợp</returns>
        public DataTable GetPackageReturnAndIssueSummary(string type, DateTime date)
        {
            return OrderPackagingDAL.GetPackageReturnAndIssueSummary(type, date);
        }
    }
}
