using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.GUI.ChildOrderForm;
using EcosystemApp.Utils;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace EcosystemApp.GUI.ChildOrderForm
{
    public partial class OrderListForm : Form
    {
        private List<OrderDTO> FilteredOrders = new List<OrderDTO>();
        private List<OrderDTO> OrdersShowInDataGridView = new List<OrderDTO>();
        private SearchHelper SearchHelper = new SearchHelper();
        private EmployeeDTO? CurrentUser;
        private OrderBUS OrderB = new OrderBUS();
        private DateTime Start, End;
        private int CurrentPage = 1;
        private int PageSize = 25;
        private int TotalPages = 1;

        public OrderListForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        public OrderListForm(EmployeeDTO user) : this()
        {
            CurrentUser = user;

        }

        private void InitializeDefaultValues()
        {
            CbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFilter.Items.Clear();
            CbFilter.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Tất cả" });
            CbFilter.SelectedIndex = 0;

            //
            CbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CbStatus.Items.Clear();
            CbStatus.Items.AddRange(new object[] { "Mới", "Chuẩn bị", "Đang Giao", "Hoàn thành", "Thu hồi bao bì" });
            CbStatus.SelectedIndex = 0;

            //
            // Tắt tự tạo cột theo nguồn dữ liệu
            DgvOrderList.AutoGenerateColumns = false;

            // Quan trọng: Đặt chế độ Fill cho toàn bộ DataGridView
            DgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Xóa thuộc tính Width cố định, thay bằng FillWeight để phân bổ tỉ lệ

            // Cột STT - hẹp nhất
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.HeaderText = "STT";
            colSTT.Name = "STT";
            colSTT.FillWeight = 10;
            colSTT.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Mã đơn hàng
            DataGridViewTextBoxColumn colOrderID = new DataGridViewTextBoxColumn();
            colOrderID.HeaderText = "Mã đơn hàng";
            colOrderID.Name = "OrderID";
            colOrderID.FillWeight = 25;
            colOrderID.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Khách hàng
            DataGridViewTextBoxColumn colCustomer = new DataGridViewTextBoxColumn();
            colCustomer.HeaderText = "Khách hàng";
            colCustomer.Name = "Customer";
            colCustomer.FillWeight = 35;
            colCustomer.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Địa chỉ giao - rộng hơn
            DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
            colAddress.HeaderText = "Địa chỉ giao";
            colAddress.Name = "Address";
            colAddress.FillWeight = 50;
            colAddress.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Ngày đặt
            DataGridViewTextBoxColumn colOrderDate = new DataGridViewTextBoxColumn();
            colOrderDate.HeaderText = "Ngày đặt";
            colOrderDate.Name = "OrderDate";
            colOrderDate.FillWeight = 30;
            colOrderDate.DefaultCellStyle.Format = "dd/MM/yyyy";
            colOrderDate.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Trạng thái
            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.HeaderText = "Trạng thái";
            colStatus.Name = "Status";
            colStatus.FillWeight = 25;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tổng tiền
            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
            colTotal.HeaderText = "Tổng tiền";
            colTotal.Name = "Total";
            colTotal.FillWeight = 20;
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTotal.DefaultCellStyle.Format = "N0";
            colTotal.SortMode = DataGridViewColumnSortMode.NotSortable;

            // Thêm tất cả cột vào DataGridView
            DgvOrderList.Columns.AddRange(new DataGridViewColumn[] {
                colSTT, colOrderID, colCustomer, colAddress, colOrderDate, colStatus, colTotal
            });

            // Tùy chọn thêm: căn giữa header, auto-size, v.v.
            DgvOrderList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvOrderList.AllowUserToAddRows = false;
            DgvOrderList.RowHeadersVisible = false;
            DgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnApplyFilterClick(object? sender, EventArgs e)
        {
            // Lấy giá trị lọc từ ComboBox
            string filterType = CbFilter.SelectedItem.ToString();
            string status = ConvertStatusToEnglish(CbStatus.SelectedItem.ToString());
            // Xác định khoảng thời gian dựa trên lựa chọn lọc
            // Giả sử bạn có một DateTimePicker tên là DtpFilter
            DateTime selectedDate = DtpFilter.Value.Date;

            switch (CbFilter.SelectedItem?.ToString())
            {
                case "Ngày":
                    // Lấy đúng ngày đang chọn trong DateTimePicker
                    Start = selectedDate;
                    End = selectedDate.AddDays(1);
                    break;

                case "Tuần":
                    Start = selectedDate;
                    End = selectedDate.AddDays(7).AddSeconds(-1);
                    break;

                case "Tháng":
                    // Lấy ngày đầu và cuối của tháng hiện tại theo ngày chọn
                    Start = selectedDate;
                    End = selectedDate.AddMonths(1).AddDays(-1);
                    break;

                case "Tất cả":
                    Start = DateTime.MinValue;
                    End = DateTime.MaxValue;
                    break;

                default:
                    // Mặc định: chỉ ngày được chọn
                    Start = selectedDate;
                    End = selectedDate;
                    break;
            }


            // Gọi hàm lọc theo ngày (đã có sẵn)
            FilteredOrders = OrderB.GetFilteredOrders(Start, End, status) ?? new List<OrderDTO>();
            OrdersShowInDataGridView = FilteredOrders;
            //CurrentPage = 1; // Đặt lại trang hiện tại về 1 mỗi khi áp dụng bộ lọc
            ShowOrderDataGridView();
            LbOrderNumber.Text = $"Số lượng đơn hàng: {FilteredOrders.Count}";
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {

            OrdersShowInDataGridView = SearchHelper.SearchOrdersByKeyword(FilteredOrders, TbSearch.Text);
            ShowOrderDataGridView();
            LbOrderNumber.Text = $"Số lượng đơn hàng: {OrdersShowInDataGridView.Count}";
        }

        private void BtnExportReportClick(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Kiểm tra có dữ liệu hay không
                if (OrdersShowInDataGridView == null || OrdersShowInDataGridView.Count == 0)
                {
                    RJMessageBox.Show("Không có đơn hàng nào để xuất báo cáo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Hiển thị hộp thoại chọn nơi lưu file
                using (SaveFileDialog SaveFileDialog = new SaveFileDialog())
                {
                    SaveFileDialog.Title = "Chọn nơi lưu báo cáo";
                    SaveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    SaveFileDialog.FileName = $"BaoCaoDonHang_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = SaveFileDialog.FileName;

                        // 3️⃣ Tạo tài liệu PDF
                        string fromDate = Start.ToString("dd/MM/yyyy");
                        string toDate = End.ToString("dd/MM/yyyy");

                        QuestPDF.Settings.License = LicenseType.Community;
                        var document = new OrderReportPDF(OrdersShowInDataGridView, fromDate, toDate);

                        // 4️⃣ Xuất file PDF
                        document.GeneratePdf(filePath);
                        RJMessageBox.Show("Xuất báo cáo PDF thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Đã xảy ra lỗi khi xuất báo cáo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnViewDetailClick(object sender, EventArgs e)
        {
            // Kiểm tra dòng được chọn
            if (DgvOrderList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một đơn hàng để xem chi tiết!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã đơn hàng từ dòng được chọn
            DataGridViewRow selectedRow = DgvOrderList.SelectedRows[0];
            int selectedIndex = (CurrentPage - 1) * PageSize + DgvOrderList.SelectedRows[0].Index;
            var order = OrdersShowInDataGridView[selectedIndex];

            // Tạo form xem chi tiết (tạm thời chỉ hiển thị thông tin cơ bản)
            OrderDetailForm detailForm = new OrderDetailForm(order, OrderB);

            // Hiển thị form dưới dạng dialog
            detailForm.ShowDialog();
        }

        private void BtnPrevPageClick(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                ShowOrderDataGridView();
            }
        }

        private void BtnNextPageClick(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                ShowOrderDataGridView();
            }
        }

        private void CbFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            string typeOfTime = CbFilter.SelectedItem.ToString();
            switch (typeOfTime)
            {
                case "Ngày":
                    DtpFilter.Enabled = true;
                    DtpFilter.Format = DateTimePickerFormat.Custom;
                    DtpFilter.CustomFormat = "dd/MM/yyyy";
                    break;
                case "Tuần":
                    DtpFilter.Enabled = true;
                    DtpFilter.Format = DateTimePickerFormat.Custom;
                    DtpFilter.CustomFormat = "dd/MM/yyyy";

                    break;
                case "Tháng":
                    DtpFilter.Enabled = true;
                    DtpFilter.Format = DateTimePickerFormat.Custom;
                    DtpFilter.CustomFormat = "MM/yyyy";
                    break;
                case "Tất cả":
                    DtpFilter.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void ShowOrderDataGridView()
        {
            DgvOrderList.Rows.Clear();

            if (OrdersShowInDataGridView == null || OrdersShowInDataGridView.Count == 0)
            {
                LbOrderNumber.Text = "0";
                LbPageInfo.Text = "Trang 0 / 0";
                BtnPrevPage.Visible = false;
                BtnNextPage.Visible = false;
                LbPageInfo.Visible = false;
                return;
            }

            TotalPages = (int)Math.Ceiling((double)OrdersShowInDataGridView.Count / PageSize);
            if (CurrentPage > TotalPages) CurrentPage = TotalPages;

            int startIndex = (CurrentPage - 1) * PageSize;
            int endIndex = Math.Min(startIndex + PageSize, OrdersShowInDataGridView.Count);
            int stt = startIndex + 1;

            var CurrentPageData = OrdersShowInDataGridView.Skip(startIndex).Take(PageSize).ToList();

            System.Data.DataTable dt = OrderB.ConvertToDataTable(CurrentPageData);
            foreach (DataRow row in dt.Rows)
            {
                DgvOrderList.Rows.Add(
                    stt++,
                    row["Mã đơn hàng"],
                    row["Khách hàng"],
                    row["Địa chỉ giao"],
                    row["Ngày đặt"],
                    TranslateOrderStatus(row["Trạng thái"].ToString()),
                    row["Tổng tiền"]
                );
            }

            LbOrderNumber.Text = $"Số lượng đơn hàng: {FilteredOrders.Count}";
            LbPageInfo.Text = $"Trang {CurrentPage} / {TotalPages}";

            // Hiển thị hoặc ẩn các nút nếu chỉ có 1 trang
            bool showPaging = TotalPages > 1;
            BtnPrevPage.Visible = showPaging;
            BtnNextPage.Visible = showPaging;
            LbPageInfo.Visible = showPaging;

            // Cập nhật trạng thái nút
            BtnPrevPage.Enabled = CurrentPage > 1;
            BtnNextPage.Enabled = CurrentPage < TotalPages;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (DgvOrderList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Bạn chưa chọn đơn hàng nào để hủy!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Nếu có chọn -> xử lý hủy đơn
            DataGridViewRow selectedRow = DgvOrderList.SelectedRows[0];

            string orderId = selectedRow.Cells["OrderID"].Value?.ToString();

            var confirm = RJMessageBox.Show($"Bạn có chắc muốn hủy đơn hàng {orderId}?",
                                          "Xác nhận",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // TODO: Xử lý logic hủy đơn ở đây
                OrderB.DeleteOrder(orderId);
                RJMessageBox.Show("Đã xóa đơn hàng thành công", "Thành công!");
                // Cập nhật lại danh sách hiển thị
                BtnApplyFilterClick(null, null);
            }
        }

        private string ConvertStatusToEnglish(string status)
        {
            return status switch
            {
                "Mới" => "New",
                "Chuẩn bị" => "Prepare",
                "Đang Giao" => "Shipping",
                "Hoàn thành" => "Complete",
                "Thu hồi bao bì" => "Recall Package",
                _ => status,
            };
        }

        private static string TranslateOrderStatus(string status)
        {
            switch (status)
            {
                case "New":
                    return "Mới";
                case "Prepare":
                    return "Chuẩn bị";
                case "Shipping":
                    return "Đang giao";
                case "Complete":
                    return "Hoàn thành";
                case "Recall Package":
                    return "Thu hồi bao bì";
                default:
                    return "Không xác định";
            }
        }

        private void BtnExcelClick(object sender, EventArgs e)
        {
            if (OrdersShowInDataGridView == null || OrdersShowInDataGridView.Count == 0)
            {
                RJMessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Chọn nơi lưu báo cáo doanh thu";
                saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveDialog.FileName;
                    // 3️⃣ Tạo tài liệu PDF
                    string fromDate = Start.ToString("dd/MM/yyyy");
                    string toDate = End.ToString("dd/MM/yyyy");
                    ExcelHelper.ExportOrdersReport(OrdersShowInDataGridView, path, fromDate, toDate);
                    RJMessageBox.Show("Xuất báo cáo Excel thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
