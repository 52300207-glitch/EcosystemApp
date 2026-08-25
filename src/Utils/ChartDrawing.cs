using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace EcosystemApp.Utils
{
    public class ChartDrawing
    {
        public static Chart MakeNewLineChart(DataTable table, int width = 800, int height = 400)
        {
            Chart chart = new Chart();
            chart.Width = width;
            chart.Height = height;

            // Xóa mọi thứ cũ
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            // ChartArea
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Doanh thu (VNĐ)";

            // Tăng kích thước chữ
            area.AxisY.IsLabelAutoFit = false;
            area.AxisX.LabelStyle.Font = new Font("Arial", 16);
            area.AxisY.LabelStyle.Font = new Font("Arial", 16);
            area.AxisX.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Arial", 20, FontStyle.Bold);

            // Ẩn lưới
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            // Trục X nghiêng 45 độ
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            // Trục Y định dạng VNĐ
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.MajorTickMark.Enabled = true;

            chart.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            legend.Font = new Font("Arial", 16); // tăng chữ legend
            chart.Legends.Add(legend);

            // Series Doanh thu
            Series seriesRevenue = new Series("Doanh thu");
            seriesRevenue.ChartType = SeriesChartType.Line;
            seriesRevenue.Color = Color.CornflowerBlue;
            seriesRevenue.MarkerStyle = MarkerStyle.Circle;
            seriesRevenue.MarkerSize = 7;
            seriesRevenue.ToolTip = "#VALY{N0} VNĐ";

            // Tăng font label của series (nếu có hiển thị label)
            seriesRevenue.Font = new Font("Arial", 16);

            chart.Series.Add(seriesRevenue);

            chart.Dock = DockStyle.Fill;

            if (table == null || table.Rows.Count == 0)
            {
                chart.Series["Doanh thu"].Points.Clear();
                chart.ChartAreas[0].AxisX.CustomLabels.Clear();
                return null;
            }


            // Chuyển DataTable thành Dictionary
            Dictionary<string, double> revenueData = new Dictionary<string, double>();
            foreach (DataRow row in table.Rows)
            {
                string key = row["Ngay"].ToString(); // Ngày/Tuần/Tháng
                double revenue = row["DoanhThu"] != DBNull.Value ? Convert.ToDouble(row["DoanhThu"]) : 0;
                revenueData[key] = revenue;
            }

            //Series seriesRevenue = chart.Series["Doanh thu"];
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

            return chart;
        }



        // --- Pie Chart ---
        public static Chart MakeNewPieChart(Dictionary<string, decimal> refillGroups, int width = 600, int height = 400, string seriesName = "Khách hàng")
        {
            Chart chart = new Chart { Width = width, Height = height };
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            // ChartArea
            ChartArea area = new ChartArea("MainArea");
            area.Position = new ElementPosition(5, 5, 90, 90);
            area.InnerPlotPosition = new ElementPosition(10, 15, 75, 75);
            chart.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend { Docking = Docking.Right, Font = new Font("Arial", 20), Alignment = StringAlignment.Near };
            chart.Legends.Add(legend);

            // Series
            Series series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Pie,
                Font = new Font("Arial", 20, FontStyle.Bold),
                IsValueShownAsLabel = true
            };
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            chart.Series.Add(series);

            if (refillGroups != null && refillGroups.Count > 0)
            {
                decimal total = refillGroups.Values.Sum();
                if (total == 0) total = 1;

                Color[] colors = { Color.CornflowerBlue, Color.OrangeRed, Color.MediumSeaGreen, Color.Goldenrod, Color.MediumPurple };
                int colorIndex = 0;

                foreach (var kv in refillGroups)
                {
                    if (kv.Value <= 0) continue;
                    double percent = (double)(kv.Value / total * 100);
                    int pointIndex = series.Points.AddXY(kv.Key, kv.Value);
                    series.Points[pointIndex].Label = $"{percent:0.0}%";
                    series.Points[pointIndex].LegendText = kv.Key;
                    series.Points[pointIndex].Color = colors[colorIndex % colors.Length];
                    colorIndex++;
                }
            }

            return chart;
        }

        // --- Column Chart ---
        public static Chart MakeNewColumnChart(DataTable table, int width = 800, int height = 400, string yTitle = "Số lượng")
        {
            Chart chart = new Chart { Width = width, Height = height };
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = yTitle;

            // Font cố định 20 cho label
            area.AxisX.LabelStyle.Font = new Font("Arial", 20);
            area.AxisY.LabelStyle.Font = new Font("Arial", 20);
            area.AxisX.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            area.AxisX.IsLabelAutoFit = false;
            area.AxisY.IsLabelAutoFit = false;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            chart.ChartAreas.Add(area);

            // Legend
            Legend legend = new Legend { Docking = Docking.Top, Font = new Font("Arial", 20) };
            chart.Legends.Add(legend);

            // Series
            Series seriesIssued = new Series("Bao bì thoát ra") { ChartType = SeriesChartType.Column, Color = Color.CornflowerBlue, Font = new Font("Arial", 20) };
            Series seriesReturned = new Series("Thu hồi") { ChartType = SeriesChartType.Column, Color = Color.OrangeRed, Font = new Font("Arial", 20) };
            chart.Series.Add(seriesIssued);
            chart.Series.Add(seriesReturned);

            // Thêm dữ liệu
            if (table != null && table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string label = table.Rows[i]["TimePeriod"].ToString();
                    double issued = table.Rows[i]["Issued"] != DBNull.Value ? Convert.ToDouble(table.Rows[i]["Issued"]) : 0;
                    double returned = table.Rows[i]["Returned"] != DBNull.Value ? Convert.ToDouble(table.Rows[i]["Returned"]) : 0;

                    seriesIssued.Points.AddXY(i + 1, issued);
                    seriesReturned.Points.AddXY(i + 1, returned);

                    // Label trục X, font lấy từ AxisX.LabelStyle.Font
                    CustomLabel customLabel = new CustomLabel(i + 0.5, i + 1.5, label, 0, LabelMarkStyle.None);
                    customLabel.ForeColor = Color.Black;
                    chart.ChartAreas[0].AxisX.CustomLabels.Add(customLabel);
                }
            }

            return chart;
        }

        // --- Line Chart ---
        public static Chart MakeNewLineChartWasteReduction(DataTable table, int width = 800, int height = 400, string yTitle = "Giảm nhựa (kg)")
        {
            Chart chart = new Chart { Width = width, Height = height };
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = yTitle;

            area.AxisX.LabelStyle.Font = new Font("Arial", 20);
            area.AxisY.LabelStyle.Font = new Font("Arial", 20);
            area.AxisX.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            area.AxisY.TitleFont = new Font("Arial", 20, FontStyle.Bold);
            area.AxisX.IsLabelAutoFit = false;
            area.AxisY.IsLabelAutoFit = false;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;
            area.AxisY.LabelStyle.Format = "N2";

            chart.ChartAreas.Add(area);

            Legend legend = new Legend { Docking = Docking.Top, Font = new Font("Arial", 20) };
            chart.Legends.Add(legend);

            Series series = new Series("Giảm nhựa")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.CornflowerBlue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                ToolTip = "#VALY{N2} kg",
                Font = new Font("Arial", 20)
            };
            chart.Series.Add(series);

            if (table != null && table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string label = table.Rows[i]["Day"].ToString();
                    double value = table.Rows[i]["AmountOfReducingWaste"] != DBNull.Value ? Convert.ToDouble(table.Rows[i]["AmountOfReducingWaste"]) : 0;
                    series.Points.AddXY(i + 1, value);

                    // Label trục X, font lấy từ AxisX.LabelStyle.Font
                    CustomLabel customLabel = new CustomLabel(i + 0.5, i + 1.5, label, 0, LabelMarkStyle.None);
                    customLabel.ForeColor = Color.Black;
                    chart.ChartAreas[0].AxisX.CustomLabels.Add(customLabel);
                }
            }

            return chart;
        }
    }
}


