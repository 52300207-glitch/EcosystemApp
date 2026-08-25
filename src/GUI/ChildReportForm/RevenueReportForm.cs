using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace EcosystemApp.GUI.ChildReportForm
{
    public partial class RevenueReportForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private OrderBUS OrderBUS = new OrderBUS();
        private DataTable RevenueData;

        public RevenueReportForm()
        {
            InitializeComponent();
            InitializeDefautValue();
        }

        public RevenueReportForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
        }


        private void InitializeDefautValue()
        {
            CbbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbFilter.Items.Clear();

            CbbFilter.Items.Add("Ngày");
            CbbFilter.Items.Add("Tuần");
            CbbFilter.Items.Add("Tháng");

            // Giá trị mặc định
            CbbFilter.SelectedIndex = 0;
            SetupRevenueLineChart(RevenueChart);

            InitializeRevenueReportGrid();

            BtnFilterClick(null, null);


        }


        private void CbbFilterSelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = CbbFilter.SelectedItem.ToString();

            // Bật chế độ chỉ xoay số, không dùng dropdown chọn ngày
            DtpFilter.ShowUpDown = true;

            if (mode == "Ngày" || mode == "Tuần")
            {
                // Chỉ hiển thị THÁNG + NĂM
                DtpFilter.Format = DateTimePickerFormat.Custom;
                DtpFilter.CustomFormat = "MM/yyyy";
            }
            else if (mode == "Tháng")
            {
                // Chỉ hiển thị NĂM
                DtpFilter.Format = DateTimePickerFormat.Custom;
                DtpFilter.CustomFormat = "yyyy";
            }
        }

        private void BtnFilterClick(object sender, EventArgs e)
        {
            string type = CbbFilter.Text;
            DateTime date = DtpFilter.Value;
            RevenueData = OrderBUS.GetRevenue(type, date);
            DisplayRevenueReport(RevenueData);
            DrawRevenueLineChart(RevenueChart, RevenueData);
        }


        private void SetupRevenueLineChart(Chart chart)
        {
            // Xóa mọi thứ cũ
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            // ChartArea
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Doanh thu (VNĐ)";

            // Ẩn lưới
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            // Trục X nghiêng 45 độ
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            // Trục Y định dạng VNĐ
            area.AxisY.LabelStyle.Format = "N0"; // 1,200,000
            area.AxisY.MajorTickMark.Enabled = true;

            chart.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            chart.Legends.Add(legend);

            // Series Doanh thu
            Series seriesRevenue = new Series("Doanh thu");
            seriesRevenue.ChartType = SeriesChartType.Line;
            seriesRevenue.Color = System.Drawing.Color.CornflowerBlue;
            seriesRevenue.MarkerStyle = MarkerStyle.Circle;
            seriesRevenue.MarkerSize = 7;
            seriesRevenue.ToolTip = "#VALY{N0} VNĐ"; // tooltip hiển thị VNĐ
            chart.Series.Add(seriesRevenue);

            chart.Dock = DockStyle.Fill;
        }

        private void DrawRevenueLineChart(Chart chart, DataTable table)
        {
            if (table == null || table.Rows.Count == 0)
            {
                chart.Series["Doanh thu"].Points.Clear();
                chart.ChartAreas[0].AxisX.CustomLabels.Clear();
                return;
            }

            // Chuyển DataTable thành Dictionary
            Dictionary<string, double> revenueData = new Dictionary<string, double>();
            foreach (DataRow row in table.Rows)
            {
                string key = row["Ngay"].ToString(); // Ngày/Tuần/Tháng
                double revenue = row["DoanhThu"] != DBNull.Value ? Convert.ToDouble(row["DoanhThu"]) : 0;
                revenueData[key] = revenue;
            }

            Series seriesRevenue = chart.Series["Doanh thu"];
            seriesRevenue.Points.Clear();
            chart.ChartAreas[0].AxisX.CustomLabels.Clear();

            // Sắp xếp keys theo ngày, tuần hoặc tháng
            var sortedKeys = revenueData.Keys.ToList(); // giữ nguyên thứ tự nếu cần
                                                        // Nếu muốn sắp xếp tuần/tháng theo thứ tự tự nhiên, có thể parse riêng

            for (int i = 0; i < sortedKeys.Count; i++)
            {
                double value = revenueData[sortedKeys[i]];
                seriesRevenue.Points.AddXY(i + 1, value);

                // Label trục X
                CustomLabel label = new CustomLabel(i + 0.5, i + 1.5, sortedKeys[i], 0, LabelMarkStyle.None);
                chart.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].RecalculateAxesScale();
        }

        private void InitializeRevenueReportGrid()
        {
            if (DgvRevenueReport == null)
            {
                DgvRevenueReport = new DataGridView();
                DgvRevenueReport.Dock = DockStyle.Fill;
                this.Controls.Add(DgvRevenueReport);
            }

            DgvRevenueReport.Columns.Clear();
            DgvRevenueReport.AutoGenerateColumns = false;
            DgvRevenueReport.AllowUserToAddRows = false;
            DgvRevenueReport.AllowUserToDeleteRows = false;
            DgvRevenueReport.ReadOnly = true;
            DgvRevenueReport.RowHeadersVisible = false;
            DgvRevenueReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRevenueReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string[] columnNames = { "Ngày/Tháng/Năm", "Số đơn", "Doanh thu", "Tăng trưởng so với ngày trước" };
            foreach (var colName in columnNames)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    Name = colName,
                    HeaderText = colName,
                    DataPropertyName = colName,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = (colName == "Doanh thu" || colName.Contains("Tăng trưởng")) ?
                                    DataGridViewContentAlignment.MiddleRight : DataGridViewContentAlignment.MiddleCenter,
                        Format = (colName == "Doanh thu") ? "N0" : ""
                    }
                };
                DgvRevenueReport.Columns.Add(col);
            }
        }

        private void DisplayRevenueReport(DataTable table)
        {
            if (table == null || table.Rows.Count == 0)
            {
                DgvRevenueReport.DataSource = null;
                return;
            }

            DataTable displayTable = new DataTable();
            displayTable.Columns.Add("Ngày/Tháng/Năm", typeof(string));
            displayTable.Columns.Add("Số đơn", typeof(int));
            displayTable.Columns.Add("Doanh thu", typeof(decimal));
            displayTable.Columns.Add("Tăng trưởng so với ngày trước", typeof(string));

            decimal lastRevenue = 0m;

            foreach (DataRow row in table.Rows)
            {
                int soDon = row["SoDon"] != DBNull.Value ? Convert.ToInt32(row["SoDon"]) : 0;
                decimal doanhThu = row["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(row["DoanhThu"]) : 0m;

                string growth = "0";
                if (lastRevenue != 0)
                    growth = ((doanhThu - lastRevenue) / lastRevenue * 100).ToString("0.##") + "%";

                lastRevenue = doanhThu;

                displayTable.Rows.Add(
                    row["Ngay"].ToString(),
                    soDon,
                    doanhThu,
                    growth
                );
            }

            DgvRevenueReport.DataSource = displayTable;
        }


        private void BtnExportPDFClick(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Kiểm tra có dữ liệu hay không
                if (DgvRevenueReport == null || DgvRevenueReport.RowCount == 0)
                {
                    RJMessageBox.Show("Không có đơn hàng nào để xuất báo cáo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Hiển thị hộp thoại chọn nơi lưu file
                using (SaveFileDialog SaveFileDialog = new SaveFileDialog())
                {
                    SaveFileDialog.Title = "Chọn nơi lưu báo cáo";
                    SaveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    SaveFileDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = SaveFileDialog.FileName;
                        QuestPDF.Settings.License = LicenseType.Community;

                        // Lấy DataTable

                        // Tạo chart từ DataTable
                        var chart = ChartDrawing.MakeNewLineChart(RevenueData, 2000, 800);

                        // Vẽ chart vào bitmap
                        Bitmap bmp = new Bitmap(chart.Width, chart.Height);
                        chart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                        // Chuyển Bitmap sang MemoryStream (QuestPDF cần)
                        MemoryStream chartStream = new MemoryStream();
                        bmp.Save(chartStream, System.Drawing.Imaging.ImageFormat.Png);
                        chartStream.Seek(0, SeekOrigin.Begin);

                        // Tạo báo cáo PDF bằng QuestPDF
                        var report = new RevenueReport(chartStream, RevenueData);

                        // Xuất file PDF
                        report.GeneratePdf(filePath);

                        RJMessageBox.Show("Xuất PDF thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Đã xảy ra lỗi khi xuất báo cáo:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void BtnExportExcelClick(object sender, EventArgs e)
        {
            try
            {
                if (DgvRevenueReport == null || DgvRevenueReport.RowCount == 0)
                {
                    RJMessageBox.Show("Không có dữ liệu để xuất Excel.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Lưu báo cáo Excel";
                    dialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    dialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelHelper.ExportRevenueReport(RevenueData, dialog.FileName);
                        RJMessageBox.Show("Xuất Excel thành công!",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
