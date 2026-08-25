using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace EcosystemApp.GUI.ChildReportForm
{
    public partial class StatisticsForm : Form
    {
        private OrderBUS OrderBUS = new OrderBUS();
        private OrderPackagingBUS PackagingBUS = new OrderPackagingBUS();
        private EmployeeDTO EmployeeDTO = new EmployeeDTO();
        private DataTable DataCustomerRefill;
        private DataTable DataAmountWasteEmit;
        private DataTable DataIssueAndReturnPackages;

        public StatisticsForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        public StatisticsForm(EmployeeDTO emp) : this()
        {
            EmployeeDTO = emp;
        }

        private void InitializeDefaultValues()
        {
            SetupReducePlasticPackagingChart(ChartReducePlasticPackaging);
            SetupPieChart(ChartCustomerRefill);
            SetupChartPackagingRecall(ChartPackagingRecall);

            DataCustomerRefill = OrderBUS.GetCustomerRefillFrequency(DtpFilterCustomerRefill.Value, CbbFilterCustomerRefill.Text);

            CbbFilterCustomerRefill.Items.Clear();
            CbbFilterCustomerRefill.Items.Add("Tháng");
            CbbFilterCustomerRefill.Items.Add("Năm");
            CbbFilterCustomerRefill.SelectedIndex = 0; // mặc định là Tháng

            CbbFilterCustomerRefill.DropDownStyle = ComboBoxStyle.DropDownList;
            DtpFilterCustomerRefill.ShowUpDown = true;


            // Giống như CbbFilterCustomerRefill, chỉnh sửa CbbFilterReducePlasticPackaging
            CbbFilterReducePlasticPackaging.Items.Clear();
            CbbFilterReducePlasticPackaging.Items.Add("Ngày");
            CbbFilterReducePlasticPackaging.Items.Add("Tuần");
            CbbFilterReducePlasticPackaging.Items.Add("Tháng");
            CbbFilterReducePlasticPackaging.SelectedIndex = 0; // Mặc định là Ngày

            // Thiết lập ComboBox thành DropDownList để chỉ cho phép chọn từ danh sách
            CbbFilterReducePlasticPackaging.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cũng như DtpFilterCustomerRefill, chỉnh sửa DtpFilterReducePlasticPackaging
            DtpFilterReducePlasticPackaging.ShowUpDown = true; // Hiển thị chỉ các ngày mà không cần chọn thời gian



            // --- ComboBox ---
            CbbTypeOfDate.Items.Clear();
            CbbTypeOfDate.Items.Add("Tháng");
            CbbTypeOfDate.Items.Add("Năm");
            CbbTypeOfDate.SelectedIndex = 0; // mặc định là Tháng
            CbbTypeOfDate.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- DateTimePicker ---
            DtpDate.ShowUpDown = true; // chỉ chọn tháng/năm
            // --- Chart ---


        }

        private void SetupChartPackagingRecall(Chart chart)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Số lượng";

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            // Trục X nghiêng 45 độ
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            chart.ChartAreas.Add(area);

            Legend legend = new Legend();
            legend.Docking = Docking.Top; // Chuyển sang góc phải
            legend.Alignment = StringAlignment.Far; // Căn top
            chart.Legends.Add(legend);

            // Series Bao bì thoát ra
            Series seriesIssued = new Series("Bao bì thoát ra");
            seriesIssued.ChartType = SeriesChartType.Column;
            seriesIssued.Color = System.Drawing.Color.CornflowerBlue;
            chart.Series.Add(seriesIssued);

            // Series Bao bì thu hồi
            Series seriesReturned = new Series("Thu hồi");
            seriesReturned.ChartType = SeriesChartType.Column;
            seriesReturned.Color = System.Drawing.Color.OrangeRed;
            chart.Series.Add(seriesReturned);

            chart.Dock = DockStyle.None;
        }

        private void CbbTypeOfDateSelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy chế độ từ ComboBox
            string mode = CbbTypeOfDate.SelectedItem.ToString();

            // Cập nhật format của DateTimePicker ngay trong đây
            DtpDate.ShowUpDown = true;
            if (mode == "Tháng")
                DtpDate.CustomFormat = "MM/yyyy";
            else if (mode == "Năm")
                DtpDate.CustomFormat = "yyyy";
            DtpDate.Format = DateTimePickerFormat.Custom;


            DataIssueAndReturnPackages = PackagingBUS.GetPackageReturnAndIssueSummary(CbbTypeOfDate.Text, DtpDate.Value);
            DrawChartPackagingRecall(ChartPackagingRecall, DataIssueAndReturnPackages);

        }

        private void DrawChartPackagingRecall(Chart chart, DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                chart.Series["Bao bì thoát ra"].Points.Clear();
                chart.Series["Thu hồi"].Points.Clear();
                chart.ChartAreas[0].AxisX.CustomLabels.Clear();
                return;
            }

            chart.Series["Bao bì thoát ra"].Points.Clear();
            chart.Series["Thu hồi"].Points.Clear();
            chart.ChartAreas[0].AxisX.CustomLabels.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                string timeLabel = row["TimePeriod"].ToString();
                int issued = row["Issued"] != DBNull.Value ? Convert.ToInt32(row["Issued"]) : 0;
                int returned = row["Returned"] != DBNull.Value ? Convert.ToInt32(row["Returned"]) : 0;

                // Thêm dữ liệu vào series
                chart.Series["Bao bì thoát ra"].Points.AddXY(i + 1, issued);
                chart.Series["Thu hồi"].Points.AddXY(i + 1, returned);

                // Label trục X
                CustomLabel label = new CustomLabel(i + 0.5, i + 1.5, timeLabel, 0, LabelMarkStyle.None);
                chart.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }

            // Trục X nghiêng 45 độ và interval
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].RecalculateAxesScale();

            // cập nhật dữ liệu về tổng số bao bì phát ra và thu thôi
            UpdatePackagingSummaryLabels(data);
        }

        private void DtpDateValueChanged(object sender, EventArgs e)
        {
            DataIssueAndReturnPackages = PackagingBUS.GetPackageReturnAndIssueSummary(CbbTypeOfDate.Text, DtpDate.Value);
            DrawChartPackagingRecall(ChartPackagingRecall, DataIssueAndReturnPackages);
        }

        private void UpdatePackagingSummaryLabels(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                LbTotalEmission.Text = "Tổng phát ra: 0";
                LbTotalRecalling.Text = "Tổng thu hồi: 0";
                LbPackagingRecallRate.Text = "Tỉ lệ thu hồi bao bì: 0%";
                return;
            }

            int totalIssued = 0;
            int totalReturned = 0;

            foreach (DataRow row in data.Rows)
            {
                totalIssued += row["Issued"] != DBNull.Value ? Convert.ToInt32(row["Issued"]) : 0;
                totalReturned += row["Returned"] != DBNull.Value ? Convert.ToInt32(row["Returned"]) : 0;
            }

            double recallRate = totalIssued > 0 ? (double)totalReturned / totalIssued * 100 : 0;

            LbTotalEmission.Text = $"Tổng phát ra: {totalIssued}";
            LbTotalRecalling.Text = $"Tổng thu hồi: {totalReturned}";
            LbPackagingRecallRate.Text = $"Tỉ lệ thu hồi bao bì: {recallRate:0.##}%";
        }

        // 5) Draw chart (bổ sung sắp xếp cho Tuần)
        private void SetupReducePlasticPackagingChart(Chart chart)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Ước tính (kg)";
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;
            area.AxisY.LabelStyle.Format = "N0";
            chart.ChartAreas.Add(area);

            Legend legend = new Legend { Docking = Docking.Top };
            chart.Legends.Add(legend);

            Series series = new Series("Lượng rác giảm nhờ refill");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 7;

            chart.Series.Add(series);
            chart.Dock = DockStyle.Fill;
        }

        private void DrawReducePlasticPackagingChart(Chart chart, DataTable table)
        {
            if (table == null || table.Rows.Count == 0)
            {
                chart.Series["Lượng rác giảm nhờ refill"].Points.Clear();
                chart.ChartAreas[0].AxisX.CustomLabels.Clear();
                return;
            }

            Series series = chart.Series["Lượng rác giảm nhờ refill"];
            series.Points.Clear();
            chart.ChartAreas[0].AxisX.CustomLabels.Clear();

            int index = 1;

            foreach (DataRow row in table.Rows)
            {
                string label = row["Day"].ToString();        // "01/2025", "2025", "Tuần 23", v.v.
                int value = Convert.ToInt32(row["AmountOfReducingWaste"]);  // Số lượng

                series.Points.AddXY(index, value);

                // Label trục X
                CustomLabel customLabel = new CustomLabel(index - 0.5, index + 0.5, label, 0, LabelMarkStyle.None);
                chart.ChartAreas[0].AxisX.CustomLabels.Add(customLabel);

                index++;
            }

            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].RecalculateAxesScale();
            // tính tổng lượng ước tính giảm rác thải
            if (table == null || table.Rows.Count == 0)
            {
                LbTotalPlasticEmit.Text = $"Tổng bao bì nhựa giảm: {0.ToString("N2")} kg";
                return;
            }

            double total = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row["AmountOfReducingWaste"] != DBNull.Value)
                    total += Convert.ToDouble(row["AmountOfReducingWaste"]);
            }

            LbTotalPlasticEmit.Text = $"Tổng bao bì nhựa giảm: {total.ToString("N2")} kg";
        }

        private void CbbFilterReducePlasticPackagingSelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = CbbFilterReducePlasticPackaging.SelectedItem.ToString();
            DtpFilterReducePlasticPackaging.ShowUpDown = true;

            if (mode == "Ngày")
            {
                // Hiển thị ngày để người dùng chọn 1 ngày thuộc tuần cần thống kê
                DtpFilterReducePlasticPackaging.Format = DateTimePickerFormat.Custom;
                DtpFilterReducePlasticPackaging.CustomFormat = "MM/yyyy";
            }
            else if (mode == "Tuần")
            {
                // Hiển thị THÁNG + NĂM
                DtpFilterReducePlasticPackaging.Format = DateTimePickerFormat.Custom;
                DtpFilterReducePlasticPackaging.CustomFormat = "MM/yyyy";
            }
            else if (mode == "Tháng")
            {
                // Chỉ hiển thị NĂM
                DtpFilterReducePlasticPackaging.Format = DateTimePickerFormat.Custom;
                DtpFilterReducePlasticPackaging.CustomFormat = "yyyy";
            }

            DataAmountWasteEmit = OrderBUS.SummarizeWatseReduction(CbbFilterReducePlasticPackaging.Text, DtpFilterReducePlasticPackaging.Value);

            DrawReducePlasticPackagingChart(ChartReducePlasticPackaging, DataAmountWasteEmit);
        }

        private void SetupPieChart(Chart chart, int pieSizePercent = 75)
        {
            chart.Series.Clear();
            chart.Legends.Clear();
            chart.ChartAreas.Clear();

            // ChartArea
            ChartArea area = new ChartArea("MainArea");
            //area.BackColor = Color.Transparent;
            //area.Position.Auto = false;

            // Vị trí tổng thể ChartArea (chiếm % panel)
            area.Position.X = 5; // cách lề trái 5%
            area.Position.Y = 5; // cách lề trên 5%
            area.Position.Width = 100;
            area.Position.Height = 100;

            // Vị trí vẽ vòng tròn bên trong ChartArea
            // Giữ tỷ lệ 1:1 và khoảng cách cho label
            area.InnerPlotPosition.X = 10;
            area.InnerPlotPosition.Y = 15;
            area.InnerPlotPosition.Width = pieSizePercent; // điều chỉnh kích thước vòng tròn
            area.InnerPlotPosition.Height = pieSizePercent;

            chart.ChartAreas.Add(area);

            // Legend bên phải
            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            legend.Alignment = StringAlignment.Far;
            legend.LegendStyle = LegendStyle.Table;
            legend.Font = new Font("Segoe UI", 9);
            legend.IsTextAutoFit = true;
            chart.Legends.Add(legend);

            // Series Pie
            Series s = new Series("Tần suất refill");
            s.ChartType = SeriesChartType.Pie;
            s.IsValueShownAsLabel = true;
            s["PieLabelStyle"] = "Outside"; // nhãn ngoài
            s["PieLineColor"] = "Black";     // màu đường nối
            //s["PieDrawingStyle"] = "SoftEdge";
            s.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            chart.Series.Add(s);

            chart.Dock = DockStyle.None; // chart co giãn theo panel
        }

        private void DrawPieChartPercentage(Chart chart, Dictionary<string, decimal> refillData)
        {
            if (refillData == null || refillData.Count == 0)
                return;

            Series s = chart.Series["Tần suất refill"];
            s.Points.Clear();

            decimal total = refillData.Values.Sum();
            if (total == 0) total = 1;

            // Màu các nhóm
            System.Drawing.Color[] colors = new System.Drawing.Color[]
            {
                System.Drawing.Color.CornflowerBlue,
                System.Drawing.Color.OrangeRed,
                System.Drawing.Color.MediumSeaGreen,
                System.Drawing.Color.Goldenrod,
                System.Drawing.Color.MediumPurple
            };

            int colorIndex = 0;

            foreach (var kv in refillData)
            {
                string group = kv.Key;
                decimal count = kv.Value;

                double percent = (double)(count / total * 100);

                if (count > 0)
                {
                    int pIndex = s.Points.AddXY(group, count);

                    s.Points[pIndex].Label = $"{percent:0.0}%";
                    // Legend hiển thị tên nhóm
                    s.Points[pIndex].LegendText = group;

                    // Màu
                    s.Points[pIndex].Color = colors[colorIndex % colors.Length];
                    colorIndex++;
                }
            }

            chart.ChartAreas[0].RecalculateAxesScale();
        }

        private void CbbFilterCustomerRefillSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = CbbFilterCustomerRefill.SelectedItem.ToString();

            DtpFilterCustomerRefill.MaxDate = DateTime.Today;
            if (selectedType == "Tháng")
            {
                DtpFilterCustomerRefill.Format = DateTimePickerFormat.Custom;
                DtpFilterCustomerRefill.CustomFormat = "MM/yyyy"; // chỉ hiển thị tháng/năm
                DtpFilterCustomerRefill.ShowUpDown = true; // dùng nút tăng giảm
            }
            else // Năm
            {
                DtpFilterCustomerRefill.Format = DateTimePickerFormat.Custom;
                DtpFilterCustomerRefill.CustomFormat = "yyyy"; // chỉ hiển thị năm
                DtpFilterCustomerRefill.ShowUpDown = true;
            }

            DataCustomerRefill = OrderBUS.GetCustomerRefillFrequency(DtpFilterCustomerRefill.Value, CbbFilterCustomerRefill.Text);
            // 2) Chuyển sang dictionary nhóm
            var refillGroups = OrderBUS.GroupCustomerRefillToDict(DataCustomerRefill);

            // 3) Setup chart

            // 4) Vẽ biểu đồ
            UpdateLabelPanelCustomer(DataCustomerRefill);
            DrawPieChartPercentage(ChartCustomerRefill, refillGroups);
        }

        private void UpdateLabelPanelCustomer(DataTable dt)
        {


            if (dt == null || dt.Rows.Count == 0)
            {
                LbTotalCustomer.Text = "Tổng khách hàng: 0";
                LbTotalCustomerRefill.Text = "Khách quay lại: 0";
                FrequencyCustomerRefill.Text = "Tần suất trung bình: 0";
                return;
            }

            DataTable dtSummary = OrderBUS.GetCustomerRefillSummary(dt);
            DataRow row = dtSummary.Rows[0];

            int totalCustomers = Convert.ToInt32(row["TotalCustomers"]);
            int refillCustomers = Convert.ToInt32(row["RefillCount"]);
            double avgOrders = Convert.ToDouble(row["AvgRefillPerCustomer"]);

            LbTotalCustomer.Text = $"Số khách hàng duy nhất: {totalCustomers}";
            LbTotalCustomerRefill.Text = $"Số lần refill: {refillCustomers}";
            FrequencyCustomerRefill.Text = $"Tần suất trung bình refill: {avgOrders:0.0}";
        }

        private void DtpFilterCustomerRefillValueChanged(object sender, EventArgs e)
        {
            DataCustomerRefill = OrderBUS.GetCustomerRefillFrequency(DtpFilterCustomerRefill.Value, CbbFilterCustomerRefill.Text);
            // 2) Chuyển sang dictionary nhóm
            var refillGroups = OrderBUS.GroupCustomerRefillToDict(DataCustomerRefill);

            // 3) Setup chart

            // 4) Vẽ biểu đồ
            UpdateLabelPanelCustomer(DataCustomerRefill);
            DrawPieChartPercentage(ChartCustomerRefill, refillGroups);
        }

        private void DtpFilterReducePlasticPackagingValueChanged(object sender, EventArgs e)
        {
            DataAmountWasteEmit = OrderBUS.SummarizeWatseReduction(CbbFilterReducePlasticPackaging.Text, DtpFilterReducePlasticPackaging.Value);
            DrawReducePlasticPackagingChart(ChartReducePlasticPackaging, DataAmountWasteEmit);
        }

        private void BtnExportPDFClick(object sender, EventArgs e)
        {
            try
            {
                // 1. Chọn nơi lưu file PDF
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    QuestPDF.Settings.License = LicenseType.Community;
                    saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "Báo cáo thống kê.pdf";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    string filePath = saveFileDialog.FileName;

                    // 2. Tạo chart mới từ DataTable và xuất ra MemoryStream
                    MemoryStream pieChartStream;
                    MemoryStream lineChartStream;
                    MemoryStream columnChartStream;

                    using (Chart pieChart = ChartDrawing.MakeNewPieChart(OrderBUS.GroupCustomerRefillToDict(DataCustomerRefill), 2000, 800, "Khách hàng"))
                    using (Chart lineChart = ChartDrawing.MakeNewLineChartWasteReduction(DataAmountWasteEmit, 2000, 800, "Giảm nhựa (kg)"))
                    using (Chart columnChart = ChartDrawing.MakeNewColumnChart(DataIssueAndReturnPackages, 2000, 800, "Số lượng"))
                    {
                        // MemoryStream cho PDF
                        pieChartStream = new MemoryStream();
                        lineChartStream = new MemoryStream();
                        columnChartStream = new MemoryStream();

                        pieChart.SaveImage(pieChartStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        lineChart.SaveImage(lineChartStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        columnChart.SaveImage(columnChartStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                        pieChartStream.Position = 0;
                        lineChartStream.Position = 0;
                        columnChartStream.Position = 0;
                    }

                    // 3. Lấy thời gian từ ComboBox/DateTimePicker
                    string timeCustomerRefill = CbbFilterCustomerRefill.Text == "Tháng" ? DtpFilterCustomerRefill.Value.ToString("MM/yyyy") : DtpFilterCustomerRefill.Value.ToString("yyyy");
                    string timePlasticReduction = (CbbFilterReducePlasticPackaging.Text == "Ngày" || CbbFilterReducePlasticPackaging.Text == "Tuần") ?
                        DtpFilterReducePlasticPackaging.Value.ToString("MM/yyyy") : DtpFilterReducePlasticPackaging.Value.ToString("MM/yyyy");
                    string timePackingRecall = CbbTypeOfDate.Text == "Tháng" ? DtpDate.Value.ToString("MM/yyyy") : DtpDate.Value.ToString("yyyy");

                    // 4. Tạo report
                    StatisticsReport report = new StatisticsReport(
                         pieChartStream, lineChartStream, columnChartStream, OrderBUS.GroupCustomerRefillToDict(DataCustomerRefill),
                         DataCustomerRefill, DataAmountWasteEmit, DataIssueAndReturnPackages,
                         timeCustomerRefill, timePlasticReduction, timePackingRecall
                    );

                    // 5. Xuất PDF
                    report.GeneratePdf(filePath);

                    RJMessageBox.Show("Xuất báo cáo PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportExcelClick(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Lưu báo cáo Excel";
                    dialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    dialog.FileName = $"BaoCaoThongKe_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelHelper.ExportStatisticsReport(
                            DataCustomerRefill,
                            DataAmountWasteEmit,
                            DataIssueAndReturnPackages,
                            OrderBUS.GroupCustomerRefillToDict(DataCustomerRefill),
                            dialog.FileName
                        );

                        RJMessageBox.Show("Xuất Excel thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Lỗi khi xuất Excel:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
