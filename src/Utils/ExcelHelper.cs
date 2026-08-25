using ClosedXML.Excel;
using CsvHelper;
using EcosystemApp.DTO;
using System.ComponentModel;
using System.Data;

namespace EcosystemApp.Utils
{
    public class ExcelHelper
    {
        private string FilePath;
        private string SheetName;

        public ExcelHelper(string filePath, string sheetName)
        {
            FilePath = filePath;
            SheetName = sheetName;
        }

        public static List<string> GetSheetNames(string filePath)
        {
            // Mở Excel và đọc danh sách sheet
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var sheetNames = workbook.Worksheets.Select(ws => ws.Name).ToList();
                    return sheetNames;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File excel đang được sử dụng!");
            }
        }
        public List<string> ReadExcelLines()
        {
            List<string> lines = new List<string>();
            string ext = Path.GetExtension(FilePath).ToLower();

            if (ext == ".xlsx" || ext == ".xls")
            {
                using (var workbook = new XLWorkbook(FilePath))
                {
                    var worksheet = string.IsNullOrEmpty(SheetName)
                        ? workbook.Worksheet(1)
                        : workbook.Worksheet(SheetName);

                    var range = worksheet?.RangeUsed();
                    if (range == null)
                        return lines;

                    int totalColumns = range.ColumnCount();

                    foreach (var row in range.RowsUsed().Skip(1)) // bỏ header
                    {
                        // Lấy đủ tất cả cell từ cột 1 -> totalColumns (kể cả trống)
                        var values = row.Cells(1, totalColumns)
                                        .Select(c => c.GetValue<string>().Trim().Replace(",", " ")); // tránh lỗi khi trong ô có dấu ,

                        string line = string.Join(",", values);
                        lines.Add(line);
                    }
                }
            }
            else if (ext == ".csv")
            {
                using (var reader = new StreamReader(FilePath))
                {
                    string? line;
                    bool isFirstLine = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false; // bỏ header
                            continue;
                        }

                        // Chuẩn hóa dòng CSV
                        line = line.Trim().Replace("\r", "").Replace("\n", "");
                        lines.Add(line);
                    }
                }
            }
            else
            {
                throw new Exception("File không hợp lệ. Chỉ hỗ trợ .xlsx, .xls, .csv");
            }

            return lines;
        }

        //getter
        public string GetFilePath() { return FilePath; }
        public string GetSheetName() { return SheetName; }

        //setter
        public void SetFilePath(string filePath) { FilePath = filePath; }
        public void SetSheetID(string sheetName) { SheetName = sheetName; }


        public static void ExportRevenueReport(System.Data.DataTable table, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("BaoCaoDoanhThu");

                // ===== Tạo bản sao của DataTable để đổi tên cột =====
                var tableCopy = table.Copy();

                if (tableCopy.Columns.Count >= 4)
                {
                    tableCopy.Columns[0].ColumnName = "Ngày";
                    tableCopy.Columns[1].ColumnName = "Số đơn";
                    tableCopy.Columns[2].ColumnName = "Doanh thu";
                    tableCopy.Columns[3].ColumnName = "Tăng trưởng";
                }

                // ===== Đổ DataTable vào Excel =====
                ws.Cell(1, 1).InsertTable(tableCopy, "Data", true);

                // ===== Style Header =====
                var header = ws.Range(1, 1, 1, tableCopy.Columns.Count);
                header.Style.Font.Bold = true;
                header.Style.Fill.BackgroundColor = XLColor.SkyBlue; // màu xanh
                header.Style.Font.FontColor = XLColor.White; // chữ màu trắng
                header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // ===== Style dữ liệu =====
                var dataRange = ws.Range(2, 1, tableCopy.Rows.Count + 1, tableCopy.Columns.Count);
                dataRange.Style.Fill.BackgroundColor = XLColor.White; // màu nền trắng

                // ===== AutoFit =====
                ws.Columns().AdjustToContents();

                // ===== Format cột Doanh Thu =====
                if (tableCopy.Columns.Contains("Doanh thu"))
                {
                    int col = tableCopy.Columns["Doanh thu"].Ordinal + 1;
                    ws.Column(col).Style.NumberFormat.Format = "#,##0";
                }

                // ===== Thêm border toàn bảng =====
                var used = ws.RangeUsed();
                used.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                used.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                // ===== Lưu file =====
                workbook.SaveAs(filePath);
            }
        }


        public static void ExportStatisticsReport(
            DataTable customerRefillTable,
            DataTable plasticReductionTable,
            DataTable packagingTable,
            Dictionary<string, decimal> groupCustomerRefill,
            string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                // ================================
                // 1. SHEET - KHÁCH HÀNG REFILL
                // ================================
                var ws1 = workbook.Worksheets.Add("KhachHangRefill");

                // Header lớn
                ws1.Cell("A1").Value = "Thống kê khách hàng Refill";
                ws1.Range("A1:D1").Merge().Style
                    .Font.SetBold().Font.SetFontSize(18)
                    .Fill.SetBackgroundColor(XLColor.LightGoldenrodYellow)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                int row = 3;

                // --- BẢNG TỔNG HỢP ---
                ws1.Cell(row, 1).Value = "Tổng quan";
                ws1.Cell(row, 1).Style.Font.SetBold().Font.SetFontSize(13);
                row += 1;

                ws1.Cell(row, 1).Value = "Số khách hàng duy nhất:";
                ws1.Cell(row + 1, 1).Value = "Số lần refill";
                ws1.Cell(row + 2, 1).Value = "Tần suất trung bình refill";

                // === LOGIC MỚI ===
                int totalCustomers = customerRefillTable.Rows.Count;

                int refillCount = customerRefillTable.AsEnumerable()
                    .Where(r => r["RefillCount"] != DBNull.Value)
                    .Sum(r => Convert.ToInt32(r["RefillCount"]));

                double avgOrders = totalCustomers > 0
                    ? (double)refillCount / totalCustomers
                    : 0;

                // GÁN GIÁ TRỊ
                ws1.Cell(row, 2).Value = totalCustomers;
                ws1.Cell(row + 1, 2).Value = refillCount;
                ws1.Cell(row + 2, 2).Value = avgOrders;

                // Style bảng tổng hợp
                ws1.Range(row, 1, row + 3, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws1.Range(row, 1, row + 3, 2).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                ws1.Range(row, 1, row + 3, 2).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                row += 6;


                // --- BẢNG CHI TIẾT ---
                ws1.Cell(row, 1).Value = "Chi tiết khách hàng refill";
                ws1.Cell(row, 1).Style.Font.SetBold().Font.SetFontSize(13);
                row++;

                ws1.Cell(row, 1).Value = "Số lần refill";
                ws1.Cell(row, 2).Value = "Số khách";
                ws1.Range(row, 1, row, 2).Style.Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.LightGray);

                row++;

                foreach (var kv in groupCustomerRefill)
                {
                    ws1.Cell(row, 1).Value = kv.Key;
                    ws1.Cell(row, 2).Value = kv.Value;
                    row++;
                }

                // Border bảng
                ws1.Range((row - groupCustomerRefill.Count - 1), 1, row - 1, 2)
                    .Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                ws1.Columns().AdjustToContents();


                // ================================
                // 2. SHEET - GIẢM NHỰA
                // ================================
                var ws2 = workbook.Worksheets.Add("GiamNhua");
                ws2.Cell("A1").Value = "Giảm nhựa từ Refill";
                ws2.Range("A1:D1").Merge().Style
                    .Font.SetBold().Font.SetFontSize(18)
                    .Fill.SetBackgroundColor(XLColor.LightCyan)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                row = 3;
                double totalPlastic = plasticReductionTable.AsEnumerable()
                    .Where(r => r["AmountOfReducingWaste"] != DBNull.Value)
                    .Sum(r => Convert.ToDouble(r["AmountOfReducingWaste"]));

                ws2.Cell(row, 1).Value = "Tổng lượng nhựa giảm (kg)";
                ws2.Cell(row, 2).Value = totalPlastic;

                ws2.Range(row, 1, row, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws2.Range(row, 1, row, 2).Style.Fill.SetBackgroundColor(XLColor.Snow);

                row += 3;

                // Chi tiết giảm nhựa
                ws2.Cell(row, 1).Value = "Thời gian";
                ws2.Cell(row, 2).Value = "Lượng nhựa giảm (kg)";
                ws2.Range(row, 1, row, 2).Style.Font.SetBold()
                    .Fill.SetBackgroundColor(XLColor.LightGray);

                row++;

                foreach (DataRow dr in plasticReductionTable.Rows)
                {
                    ws2.Cell(row, 1).Value = dr["Day"].ToString();
                    ws2.Cell(row, 2).Value = Convert.ToDouble(dr["AmountOfReducingWaste"]);
                    row++;
                }

                ws2.Range("A6:B" + (row - 1)).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws2.Columns().AdjustToContents();


                // ================================
                // 3. SHEET - BAO BÌ
                // ================================
                var ws3 = workbook.Worksheets.Add("BaoBi");
                ws3.Cell("A1").Value = "Bao bì phát ra và thu hồi";
                ws3.Range("A1:D1").Merge().Style
                    .Font.SetBold().Font.SetFontSize(18)
                    .Fill.SetBackgroundColor(XLColor.LightGreen)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                int issued = packagingTable.AsEnumerable().Sum(r => r["Issued"] == DBNull.Value ? 0 : Convert.ToInt32(r["Issued"]));
                int returned = packagingTable.AsEnumerable().Sum(r => r["Returned"] == DBNull.Value ? 0 : Convert.ToInt32(r["Returned"]));
                double recallRate = issued > 0 ? (double)returned / issued * 100 : 0;

                row = 3;
                ws3.Cell(row, 1).Value = "Tổng phát ra";
                ws3.Cell(row, 2).Value = issued;
                ws3.Cell(row + 1, 1).Value = "Tổng thu hồi";
                ws3.Cell(row + 1, 2).Value = returned;
                ws3.Cell(row + 2, 1).Value = "Tỉ lệ thu hồi (%)";
                ws3.Cell(row + 2, 2).Value = recallRate;

                ws3.Range(row, 1, row + 2, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                row += 4;
                ws3.Cell(row, 1).Value = "Thời gian";
                ws3.Cell(row, 2).Value = "Phát ra";
                ws3.Cell(row, 3).Value = "Thu hồi";
                ws3.Range(row, 1, row, 3).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);

                row++;

                foreach (DataRow dr in packagingTable.Rows)
                {
                    ws3.Cell(row, 1).Value = dr["TimePeriod"].ToString();
                    ws3.Cell(row, 2).Value = dr["Issued"].ToString();
                    ws3.Cell(row, 3).Value = dr["Returned"].ToString();
                    row++;
                }

                ws3.Range("A" + (row - packagingTable.Rows.Count - 1) + ":C" + (row - 1))
                    .Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                ws3.Columns().AdjustToContents();

                // ================================
                // LƯU FILE
                // ================================
                workbook.SaveAs(filePath);
            }
        }

        public static void ExportOrdersReport(List<OrderDTO> orders, string filePath, string fromDate, string toDate)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("DoanhThu");

                // ===== Tiêu đề =====
                ws.Cell("A1").Value = "BÁO CÁO DOANH THU";
                ws.Range("A1:F1").Merge().Style
                    .Font.SetBold().Font.SetFontSize(16)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Fill.SetBackgroundColor(XLColor.LightBlue);

                // ===== Khoảng thời gian =====
                ws.Cell("A2").Value = $"Từ ngày: {fromDate}    Đến ngày: {toDate}";
                ws.Range("A2:F2").Merge().Style
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    .Font.SetFontSize(11);

                int headerRow = 4;

                // ===== Header bảng =====
                ws.Cell(headerRow, 1).Value = "STT";
                ws.Cell(headerRow, 2).Value = "Mã đơn";
                ws.Cell(headerRow, 3).Value = "Khách hàng";
                ws.Cell(headerRow, 4).Value = "Ngày đặt";
                ws.Cell(headerRow, 5).Value = "Trạng thái";
                ws.Cell(headerRow, 6).Value = "Tổng tiền";

                var headerRange = ws.Range(headerRow, 1, headerRow, 6);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                headerRange.Style.Font.FontColor = XLColor.White;
                headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                headerRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                // ===== Dữ liệu =====
                int row = headerRow + 1;
                int index = 1;
                decimal totalAmount = 0;

                foreach (var order in orders)
                {
                    ws.Cell(row, 1).Value = index++;
                    ws.Cell(row, 2).Value = order.GetID();
                    ws.Cell(row, 3).Value = order.GetCustomer()?.GetFullName() ?? "Không có";
                    ws.Cell(row, 4).Value = order.GetOrderDate().ToString("dd/MM/yyyy HH:mm");
                    ws.Cell(row, 5).Value = ConvertStatusToVietnamese(order.GetStatus()); // <-- chuyển sang English
                    ws.Cell(row, 6).Value = order.GetTotalAmount();

                    ws.Cell(row, 6).Style.NumberFormat.Format = "#,##0";
                    ws.Cell(row, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    ws.Range(row, 1, row, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    ws.Range(row, 1, row, 6).Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    totalAmount += order.GetTotalAmount();
                    row++;
                }

                // ===== Tổng số đơn & tổng tiền =====
                ws.Cell(row, 5).Value = "TỔNG";
                ws.Cell(row, 5).Style.Font.SetBold();

                ws.Cell(row, 6).Value = totalAmount;
                ws.Cell(row, 6).Style.NumberFormat.Format = "#,##0";
                ws.Cell(row, 6).Style.Font.SetBold();
                ws.Cell(row, 6).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                ws.Range(row, 5, row, 6).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                ws.Range(row, 5, row, 6).Style.Fill.BackgroundColor = XLColor.LightGray;

                // ===== AutoFit =====
                ws.Columns().AdjustToContents();

                // ===== Lưu file =====
                workbook.SaveAs(filePath);
            }
        }

        // Hàm chuyển trạng thái sang English
        private static string ConvertStatusToVietnamese(string status)
        {
            return status.ToLower() switch
            {
                "new" => "Mới",
                "prepare" => "Chuẩn bị",
                "shipping" => "Đang Giao",
                "complete" => "Hoàn thành",
                "recall package" => "Thu hồi bao bì",
                _ => status, // giữ nguyên nếu không khớp
            };
        }




    }
}
