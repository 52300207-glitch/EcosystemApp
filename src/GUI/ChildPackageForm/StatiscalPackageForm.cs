using EcosystemApp.DTO;
using EcosystemApp.BUS;
using System.Windows.Forms.DataVisualization.Charting;

namespace EcosystemApp.GUI.ChildPackageForm
{
    public partial class StatiscalPackageForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private List<PackageDTO> AllPackage;
        private List<PackagingTypeDTO> PackageType = new PackagingTypeBUS().GetAllPackagingType();
        private OrderPackagingBUS OrderPackagingBUS = new OrderPackagingBUS();
        List<int> TotalReturnPackageType;
        List<int> TotalIssuePackageType;

        Dictionary<string, int> issuedData = new Dictionary<string, int>();
        Dictionary<string, int> returnedData = new Dictionary<string, int>();
        Dictionary<string, int> issuedWeekData = new Dictionary<string, int>();
        Dictionary<string, int> returnedWeekData = new Dictionary<string, int>();
        Dictionary<string, int> issuedMonthData = new Dictionary<string, int>();
        Dictionary<string, int> returnedMonthData = new Dictionary<string, int>();

        public StatiscalPackageForm()
        {
            InitializeComponent();
            AllPackage = new PackageBUS().GetAll();
            InitailizeDefaultValues();
        }

        public StatiscalPackageForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
        }

        private void BtnPackagingRecallClick(object sender, EventArgs e)
        {
            var newForm = new PackageRecallForm(AllPackage, CurrentEmployee.GetStation().GetWarehouseID());
            newForm.ShowDialog();
        }

        private void InitailizeDefaultValues()
        {
            SetupDgvPackagingEmit();
            SetupDgvRetrievePackage();

            TotalReturnPackageType = OrderPackagingBUS.GetTotalReturnPackageTypes(PackageType);
            TotalIssuePackageType = OrderPackagingBUS.GetTotalIssuePackageTypes(PackageType);
            ShowPackagingData();
            SetupLineChart(LineChart);

            // Gán dữ liệu 12 tháng trước
            issuedData = OrderPackagingBUS.GetIssueData("12 tháng trước");
            returnedData = OrderPackagingBUS.GetReturnData("12 tháng trước");

            // Gán dữ liệu tuần trước
            issuedWeekData = OrderPackagingBUS.GetIssueData("Tuần trước");
            returnedWeekData = OrderPackagingBUS.GetReturnData("Tuần trước");

            // Gán dữ liệu 1 tháng trước
            issuedMonthData = OrderPackagingBUS.GetIssueData("1 tháng trước");
            returnedMonthData = OrderPackagingBUS.GetReturnData("1 tháng trước");

            CbbRangeTime.Items.Clear();
            CbbRangeTime.Items.Add("Tuần trước");
            CbbRangeTime.Items.Add("Tháng trước");
            CbbRangeTime.Items.Add("12 tháng trước");
            CbbRangeTime.DropDownStyle = ComboBoxStyle.DropDownList; // chỉ chọn, không nhập
            CbbRangeTime.SelectedIndex = 0; // mặc định chọn Tuần trước
            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;

        }

        private void CbbRangeTimeSelectedIndexChanged(object sender, EventArgs e)
        {
            string range = CbbRangeTime.SelectedItem.ToString();
            if (range == "Tuần trước")
            {
                DrawLineChartFromDictionary(LineChart, issuedWeekData, returnedWeekData);

            }
            else if (range == "Tháng trước")
            {
                DrawLineChartFromDictionary(LineChart, issuedMonthData, returnedMonthData);
            }
            else
            {
                DrawLineChartFromDictionary(LineChart, issuedData, returnedData);
            }
            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;

        }

        private void SetupDgvPackagingEmit()
        {
            DgvPackagingEmit.Columns.Clear();

            // Không cho sửa dữ liệu trực tiếp
            DgvPackagingEmit.ReadOnly = true;

            // Không cho thêm dòng mới
            DgvPackagingEmit.AllowUserToAddRows = false;

            // Không cho xóa dòng
            DgvPackagingEmit.AllowUserToDeleteRows = false;

            // Không cho người dùng chỉnh kích thước hàng
            DgvPackagingEmit.AllowUserToResizeRows = false;

            // --- CỘT STT ---
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.Name = "STT";
            colSTT.HeaderText = "STT";
            colSTT.Width = 50;
            colSTT.ReadOnly = true;
            DgvPackagingEmit.Columns.Add(colSTT);

            // --- CỘT TÊN BAO BÌ ---
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "PackagingName";
            colName.HeaderText = "Tên bao bì";
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.ReadOnly = true;
            DgvPackagingEmit.Columns.Add(colName);

            // --- CỘT SỐ LƯỢNG PHÁT RA ---
            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
            colQty.Name = "Quantity";
            colQty.HeaderText = "Số lượng phát ra";
            colQty.Width = 120;
            colQty.ReadOnly = true;
            DgvPackagingEmit.Columns.Add(colQty);

            // Tạo STT tự động
            DgvPackagingEmit.RowPostPaint += (s, e) =>
            {
                DgvPackagingEmit.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            };

            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;
        }

        private void SetupDgvRetrievePackage()
        {
            DgvRetrievePackage.Columns.Clear();

            // Không cho sửa dữ liệu trực tiếp
            DgvRetrievePackage.ReadOnly = true;

            // Không cho thêm dòng mới
            DgvRetrievePackage.AllowUserToAddRows = false;

            // Không cho xóa dòng
            DgvRetrievePackage.AllowUserToDeleteRows = false;

            // Không cho người dùng chỉnh kích thước hàng
            DgvRetrievePackage.AllowUserToResizeRows = false;

            // --- CỘT STT ---
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.Name = "STT";
            colSTT.HeaderText = "STT";
            colSTT.Width = 50;
            colSTT.ReadOnly = true;
            DgvRetrievePackage.Columns.Add(colSTT);

            // --- CỘT TÊN BAO BÌ ---
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "PackagingName";
            colName.HeaderText = "Tên bao bì";
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.ReadOnly = true;
            DgvRetrievePackage.Columns.Add(colName);

            // --- CỘT SỐ LƯỢNG PHÁT RA ---
            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
            colQty.Name = "Quantity";
            colQty.HeaderText = "Số lượng thu hồi";
            colQty.Width = 120;
            colQty.ReadOnly = true;
            DgvRetrievePackage.Columns.Add(colQty);

            // Tạo STT tự động
            DgvRetrievePackage.RowPostPaint += (s, e) =>
            {
                DgvRetrievePackage.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            };

            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;
        }

        private void ShowPackagingData()
        {
            if (PackageType == null) return;

            // Xóa dữ liệu cũ
            DgvPackagingEmit.Rows.Clear();
            DgvRetrievePackage.Rows.Clear();

            // Hiển thị dữ liệu phát ra
            for (int i = 0; i < PackageType.Count; i++)
            {
                string name = PackageType[i].GetTypeName();

                int issueQty = (i < TotalIssuePackageType.Count) ? TotalIssuePackageType[i] : 0;
                int returnQty = (i < TotalReturnPackageType.Count) ? TotalReturnPackageType[i] : 0;

                // Thêm vào DgvPackagingEmit (phát ra)
                DgvPackagingEmit.Rows.Add(null, name, issueQty);

                // Thêm vào DgvRetrievePackage (thu hồi)
                DgvRetrievePackage.Rows.Add(null, name, returnQty);
            }

            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;
        }

        private void SetupLineChart(Chart chart)
        {
            // Xóa mọi thứ cũ
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            // Tạo ChartArea
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Thời gian";
            area.AxisY.Title = "Số lượng";

            // Ẩn lưới
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            // Trục X kiểu số, nghiêng nhãn 45 độ
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.Interval = 1;

            // Bỏ padding, chiếm hết diện tích chart
            area.Position.Auto = false;
            area.Position.X = 5;     // cách viền trái 5%
            area.Position.Y = 5;     // cách viền trên 5%
            area.Position.Width = 90;  // chiếm 90% chiều rộng
            area.Position.Height = 90; // chiếm 90% chiều cao

            chart.ChartAreas.Add(area);

            // Thêm Legend
            Legend legend = new Legend();
            legend.Docking = Docking.Top;
            chart.Legends.Add(legend);

            // Series Phát ra
            Series seriesIssued = new Series("Phát ra");
            seriesIssued.ChartType = SeriesChartType.Line;
            seriesIssued.Color = Color.CornflowerBlue;
            seriesIssued.MarkerStyle = MarkerStyle.Circle;
            seriesIssued.MarkerSize = 7;
            chart.Series.Add(seriesIssued);

            // Series Thu hồi
            Series seriesReturned = new Series("Thu hồi");
            seriesReturned.ChartType = SeriesChartType.Line;
            seriesReturned.Color = Color.OrangeRed;
            seriesReturned.MarkerStyle = MarkerStyle.Circle;
            seriesReturned.MarkerSize = 7;
            chart.Series.Add(seriesReturned);

            // Chart chiếm toàn bộ vùng control
            chart.Dock = DockStyle.Fill;

            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;
        }

        private void DrawLineChartFromDictionary(Chart chart, Dictionary<string, int> issuedData, Dictionary<string, int> returnedData)
        {
            chart.Series["Phát ra"].Points.Clear();
            chart.Series["Thu hồi"].Points.Clear();

            var keys = issuedData.Keys.OrderBy(k => DateTime.Parse(k, new System.Globalization.CultureInfo("vi-VN"))).ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                int x = i + 1;
                chart.Series["Phát ra"].Points.AddXY(x, issuedData[keys[i]]);

                // chuẩn hóa key cho returnedData
                string keyReturned = keys[i];
                if (!returnedData.ContainsKey(keyReturned))
                {
                    // thử cắt năm nếu key có 3 phần (dd/MM/yyyy -> dd/MM)
                    var parts = keyReturned.Split('/');
                    if (parts.Length == 3)
                    {
                        keyReturned = $"{parts[0]}/{parts[1]}";
                    }
                }

                int yReturned = returnedData.ContainsKey(keyReturned) ? returnedData[keyReturned] : 0;
                chart.Series["Thu hồi"].Points.AddXY(x, yReturned);
            }

            // Xóa nhãn cũ trên trục X
            chart.ChartAreas[0].AxisX.CustomLabels.Clear();

            for (int i = 0; i < keys.Count; i++)
            {
                double position = i + 1;
                CustomLabel label = new CustomLabel(position - 0.5, position + 0.5, keys[i], 0, LabelMarkStyle.None);
                chart.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].RecalculateAxesScale();

            this.BtnPackagingRecall.Enabled = true;
            this.CbbRangeTime.Enabled = true;
        }
    }
}
