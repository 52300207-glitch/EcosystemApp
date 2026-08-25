namespace EcosystemApp.GUI.ChildReportForm
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PanelButton = new Panel();
            BtnExportPDF = new EcosystemApp.GUI.Components.RJButton();
            BtnExportExcel = new EcosystemApp.GUI.Components.RJButton();
            PanelReducePlasticPackaging = new Panel();
            ChartReducePlasticPackaging = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PanelLeftReducePlasticPackaging = new Panel();
            LbTotalPlasticEmit = new Label();
            DtpFilterReducePlasticPackaging = new DateTimePicker();
            CbbFilterReducePlasticPackaging = new ComboBox();
            PanelHeaderReducePlasticPackaging = new Panel();
            LbHeaderReducePlasticPackaging = new Label();
            PanelCustomerRefill = new Panel();
            FrequencyCustomerRefill = new Label();
            LbTotalCustomerRefill = new Label();
            LbTotalCustomer = new Label();
            DtpFilterCustomerRefill = new DateTimePicker();
            CbbFilterCustomerRefill = new ComboBox();
            PanelHeaderCustomerRefill = new Panel();
            LbHeaderCustomerRefill = new Label();
            ChartCustomerRefill = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PanelPackagingRecall = new Panel();
            DtpDate = new DateTimePicker();
            CbbTypeOfDate = new ComboBox();
            LbPackagingRecallRate = new Label();
            LbTotalRecalling = new Label();
            LbTotalEmission = new Label();
            ChartPackagingRecall = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PanelHeaderPackagingRecall = new Panel();
            LbHeaderPackagingRecall = new Label();
            PanelButton.SuspendLayout();
            PanelReducePlasticPackaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartReducePlasticPackaging).BeginInit();
            PanelLeftReducePlasticPackaging.SuspendLayout();
            PanelHeaderReducePlasticPackaging.SuspendLayout();
            PanelCustomerRefill.SuspendLayout();
            PanelHeaderCustomerRefill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartCustomerRefill).BeginInit();
            PanelPackagingRecall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartPackagingRecall).BeginInit();
            PanelHeaderPackagingRecall.SuspendLayout();
            SuspendLayout();
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnExportPDF);
            PanelButton.Controls.Add(BtnExportExcel);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 607);
            PanelButton.Margin = new Padding(2);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1184, 52);
            PanelButton.TabIndex = 0;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnExportPDF.BackColor = Color.FromArgb(196, 238, 181);
            BtnExportPDF.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnExportPDF.BoderSize = 2;
            BtnExportPDF.BorderColor = Color.Black;
            BtnExportPDF.BorderRadius = 40;
            BtnExportPDF.FlatAppearance.BorderSize = 0;
            BtnExportPDF.FlatStyle = FlatStyle.Flat;
            BtnExportPDF.ForeColor = Color.Black;
            BtnExportPDF.Location = new Point(1066, 4);
            BtnExportPDF.Margin = new Padding(2);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(116, 42);
            BtnExportPDF.TabIndex = 3;
            BtnExportPDF.Text = "Xuất PDF";
            BtnExportPDF.TextColor = Color.Black;
            BtnExportPDF.UseVisualStyleBackColor = false;
            BtnExportPDF.Click += BtnExportPDFClick;
            // 
            // BtnExportExcel
            // 
            BtnExportExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnExportExcel.BackColor = Color.FromArgb(196, 238, 181);
            BtnExportExcel.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnExportExcel.BoderSize = 2;
            BtnExportExcel.BorderColor = Color.Black;
            BtnExportExcel.BorderRadius = 40;
            BtnExportExcel.FlatAppearance.BorderSize = 0;
            BtnExportExcel.FlatStyle = FlatStyle.Flat;
            BtnExportExcel.ForeColor = Color.Black;
            BtnExportExcel.Location = new Point(944, 4);
            BtnExportExcel.Margin = new Padding(2);
            BtnExportExcel.Name = "BtnExportExcel";
            BtnExportExcel.Size = new Size(119, 42);
            BtnExportExcel.TabIndex = 2;
            BtnExportExcel.Text = "Xuất Excel";
            BtnExportExcel.TextColor = Color.Black;
            BtnExportExcel.UseVisualStyleBackColor = false;
            BtnExportExcel.Click += BtnExportExcelClick;
            // 
            // PanelReducePlasticPackaging
            // 
            PanelReducePlasticPackaging.BorderStyle = BorderStyle.FixedSingle;
            PanelReducePlasticPackaging.Controls.Add(ChartReducePlasticPackaging);
            PanelReducePlasticPackaging.Controls.Add(PanelLeftReducePlasticPackaging);
            PanelReducePlasticPackaging.Controls.Add(PanelHeaderReducePlasticPackaging);
            PanelReducePlasticPackaging.Dock = DockStyle.Bottom;
            PanelReducePlasticPackaging.Location = new Point(0, 293);
            PanelReducePlasticPackaging.Margin = new Padding(2);
            PanelReducePlasticPackaging.Name = "PanelReducePlasticPackaging";
            PanelReducePlasticPackaging.Size = new Size(1184, 314);
            PanelReducePlasticPackaging.TabIndex = 1;
            // 
            // ChartReducePlasticPackaging
            // 
            ChartReducePlasticPackaging.BackColor = Color.FromArgb(228, 255, 207);
            ChartReducePlasticPackaging.BorderlineColor = Color.FromArgb(228, 255, 207);
            chartArea1.Name = "ChartArea1";
            ChartReducePlasticPackaging.ChartAreas.Add(chartArea1);
            ChartReducePlasticPackaging.Enabled = false;
            legend1.Name = "Legend1";
            ChartReducePlasticPackaging.Legends.Add(legend1);
            ChartReducePlasticPackaging.Location = new Point(278, 39);
            ChartReducePlasticPackaging.Margin = new Padding(2);
            ChartReducePlasticPackaging.Name = "ChartReducePlasticPackaging";
            ChartReducePlasticPackaging.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartReducePlasticPackaging.Series.Add(series1);
            ChartReducePlasticPackaging.Size = new Size(904, 274);
            ChartReducePlasticPackaging.TabIndex = 3;
            ChartReducePlasticPackaging.Text = "Biểu đồ ước tính lượng bao bì nhựa giảm phát thải nhờ refill ";
            // 
            // PanelLeftReducePlasticPackaging
            // 
            PanelLeftReducePlasticPackaging.BackColor = Color.FromArgb(228, 255, 207);
            PanelLeftReducePlasticPackaging.Controls.Add(LbTotalPlasticEmit);
            PanelLeftReducePlasticPackaging.Controls.Add(DtpFilterReducePlasticPackaging);
            PanelLeftReducePlasticPackaging.Controls.Add(CbbFilterReducePlasticPackaging);
            PanelLeftReducePlasticPackaging.Dock = DockStyle.Left;
            PanelLeftReducePlasticPackaging.Location = new Point(0, 39);
            PanelLeftReducePlasticPackaging.Margin = new Padding(2);
            PanelLeftReducePlasticPackaging.Name = "PanelLeftReducePlasticPackaging";
            PanelLeftReducePlasticPackaging.Size = new Size(293, 273);
            PanelLeftReducePlasticPackaging.TabIndex = 4;
            // 
            // LbTotalPlasticEmit
            // 
            LbTotalPlasticEmit.AutoSize = true;
            LbTotalPlasticEmit.Location = new Point(14, 80);
            LbTotalPlasticEmit.Name = "LbTotalPlasticEmit";
            LbTotalPlasticEmit.Size = new Size(180, 20);
            LbTotalPlasticEmit.TabIndex = 5;
            LbTotalPlasticEmit.Text = "Tổng bao bì nhựa giảm: 0";
            // 
            // DtpFilterReducePlasticPackaging
            // 
            DtpFilterReducePlasticPackaging.CustomFormat = "MM/yyyy";
            DtpFilterReducePlasticPackaging.Format = DateTimePickerFormat.Custom;
            DtpFilterReducePlasticPackaging.Location = new Point(145, 27);
            DtpFilterReducePlasticPackaging.Margin = new Padding(2);
            DtpFilterReducePlasticPackaging.Name = "DtpFilterReducePlasticPackaging";
            DtpFilterReducePlasticPackaging.ShowUpDown = true;
            DtpFilterReducePlasticPackaging.Size = new Size(119, 27);
            DtpFilterReducePlasticPackaging.TabIndex = 4;
            DtpFilterReducePlasticPackaging.ValueChanged += DtpFilterReducePlasticPackagingValueChanged;
            // 
            // CbbFilterReducePlasticPackaging
            // 
            CbbFilterReducePlasticPackaging.AutoCompleteCustomSource.AddRange(new string[] { "Tháng", "Năm" });
            CbbFilterReducePlasticPackaging.AutoCompleteMode = AutoCompleteMode.Suggest;
            CbbFilterReducePlasticPackaging.FormattingEnabled = true;
            CbbFilterReducePlasticPackaging.Location = new Point(14, 26);
            CbbFilterReducePlasticPackaging.Margin = new Padding(2);
            CbbFilterReducePlasticPackaging.Name = "CbbFilterReducePlasticPackaging";
            CbbFilterReducePlasticPackaging.Size = new Size(119, 28);
            CbbFilterReducePlasticPackaging.TabIndex = 3;
            CbbFilterReducePlasticPackaging.Text = "Tháng / Năm";
            CbbFilterReducePlasticPackaging.SelectedIndexChanged += CbbFilterReducePlasticPackagingSelectedIndexChanged;
            // 
            // PanelHeaderReducePlasticPackaging
            // 
            PanelHeaderReducePlasticPackaging.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderReducePlasticPackaging.Controls.Add(LbHeaderReducePlasticPackaging);
            PanelHeaderReducePlasticPackaging.Dock = DockStyle.Top;
            PanelHeaderReducePlasticPackaging.Location = new Point(0, 0);
            PanelHeaderReducePlasticPackaging.Margin = new Padding(2);
            PanelHeaderReducePlasticPackaging.Name = "PanelHeaderReducePlasticPackaging";
            PanelHeaderReducePlasticPackaging.Size = new Size(1182, 39);
            PanelHeaderReducePlasticPackaging.TabIndex = 2;
            // 
            // LbHeaderReducePlasticPackaging
            // 
            LbHeaderReducePlasticPackaging.Anchor = AnchorStyles.Top;
            LbHeaderReducePlasticPackaging.AutoSize = true;
            LbHeaderReducePlasticPackaging.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderReducePlasticPackaging.Location = new Point(402, 9);
            LbHeaderReducePlasticPackaging.Margin = new Padding(2, 0, 2, 0);
            LbHeaderReducePlasticPackaging.Name = "LbHeaderReducePlasticPackaging";
            LbHeaderReducePlasticPackaging.Size = new Size(370, 20);
            LbHeaderReducePlasticPackaging.TabIndex = 0;
            LbHeaderReducePlasticPackaging.Text = "Ước tính lượng bao bì nhựa giảm phát thải nhờ refill ";
            // 
            // PanelCustomerRefill
            // 
            PanelCustomerRefill.BackColor = Color.FromArgb(228, 255, 207);
            PanelCustomerRefill.BorderStyle = BorderStyle.FixedSingle;
            PanelCustomerRefill.Controls.Add(FrequencyCustomerRefill);
            PanelCustomerRefill.Controls.Add(LbTotalCustomerRefill);
            PanelCustomerRefill.Controls.Add(LbTotalCustomer);
            PanelCustomerRefill.Controls.Add(DtpFilterCustomerRefill);
            PanelCustomerRefill.Controls.Add(CbbFilterCustomerRefill);
            PanelCustomerRefill.Controls.Add(PanelHeaderCustomerRefill);
            PanelCustomerRefill.Controls.Add(ChartCustomerRefill);
            PanelCustomerRefill.Dock = DockStyle.Left;
            PanelCustomerRefill.Location = new Point(0, 0);
            PanelCustomerRefill.Margin = new Padding(2);
            PanelCustomerRefill.Name = "PanelCustomerRefill";
            PanelCustomerRefill.Size = new Size(694, 293);
            PanelCustomerRefill.TabIndex = 2;
            // 
            // FrequencyCustomerRefill
            // 
            FrequencyCustomerRefill.AutoSize = true;
            FrequencyCustomerRefill.Location = new Point(14, 181);
            FrequencyCustomerRefill.Margin = new Padding(2, 0, 2, 0);
            FrequencyCustomerRefill.Name = "FrequencyCustomerRefill";
            FrequencyCustomerRefill.Size = new Size(173, 20);
            FrequencyCustomerRefill.TabIndex = 6;
            FrequencyCustomerRefill.Text = "Tần suất trung bình refill:";
            // 
            // LbTotalCustomerRefill
            // 
            LbTotalCustomerRefill.AutoSize = true;
            LbTotalCustomerRefill.Location = new Point(14, 148);
            LbTotalCustomerRefill.Margin = new Padding(2, 0, 2, 0);
            LbTotalCustomerRefill.Name = "LbTotalCustomerRefill";
            LbTotalCustomerRefill.Size = new Size(91, 20);
            LbTotalCustomerRefill.TabIndex = 5;
            LbTotalCustomerRefill.Text = "Số lần refill: ";
            // 
            // LbTotalCustomer
            // 
            LbTotalCustomer.AccessibleRole = AccessibleRole.None;
            LbTotalCustomer.AutoSize = true;
            LbTotalCustomer.Location = new Point(14, 111);
            LbTotalCustomer.Margin = new Padding(2, 0, 2, 0);
            LbTotalCustomer.Name = "LbTotalCustomer";
            LbTotalCustomer.Size = new Size(169, 20);
            LbTotalCustomer.TabIndex = 4;
            LbTotalCustomer.Text = "Số khách hàng duy nhất:";
            // 
            // DtpFilterCustomerRefill
            // 
            DtpFilterCustomerRefill.CustomFormat = "MM/yyyy";
            DtpFilterCustomerRefill.Format = DateTimePickerFormat.Custom;
            DtpFilterCustomerRefill.Location = new Point(145, 58);
            DtpFilterCustomerRefill.Margin = new Padding(2);
            DtpFilterCustomerRefill.Name = "DtpFilterCustomerRefill";
            DtpFilterCustomerRefill.ShowUpDown = true;
            DtpFilterCustomerRefill.Size = new Size(119, 27);
            DtpFilterCustomerRefill.TabIndex = 3;
            DtpFilterCustomerRefill.ValueChanged += DtpFilterCustomerRefillValueChanged;
            // 
            // CbbFilterCustomerRefill
            // 
            CbbFilterCustomerRefill.AutoCompleteCustomSource.AddRange(new string[] { "Tháng", "Năm" });
            CbbFilterCustomerRefill.AutoCompleteMode = AutoCompleteMode.Suggest;
            CbbFilterCustomerRefill.FormattingEnabled = true;
            CbbFilterCustomerRefill.Location = new Point(14, 58);
            CbbFilterCustomerRefill.Margin = new Padding(2);
            CbbFilterCustomerRefill.Name = "CbbFilterCustomerRefill";
            CbbFilterCustomerRefill.Size = new Size(119, 28);
            CbbFilterCustomerRefill.TabIndex = 2;
            CbbFilterCustomerRefill.Text = "Tháng / Năm";
            CbbFilterCustomerRefill.SelectedIndexChanged += CbbFilterCustomerRefillSelectedIndexChanged;
            // 
            // PanelHeaderCustomerRefill
            // 
            PanelHeaderCustomerRefill.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderCustomerRefill.Controls.Add(LbHeaderCustomerRefill);
            PanelHeaderCustomerRefill.Dock = DockStyle.Top;
            PanelHeaderCustomerRefill.Location = new Point(0, 0);
            PanelHeaderCustomerRefill.Margin = new Padding(2);
            PanelHeaderCustomerRefill.Name = "PanelHeaderCustomerRefill";
            PanelHeaderCustomerRefill.Size = new Size(692, 43);
            PanelHeaderCustomerRefill.TabIndex = 1;
            // 
            // LbHeaderCustomerRefill
            // 
            LbHeaderCustomerRefill.Anchor = AnchorStyles.Top;
            LbHeaderCustomerRefill.AutoSize = true;
            LbHeaderCustomerRefill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderCustomerRefill.Location = new Point(168, 12);
            LbHeaderCustomerRefill.Margin = new Padding(2, 0, 2, 0);
            LbHeaderCustomerRefill.Name = "LbHeaderCustomerRefill";
            LbHeaderCustomerRefill.Size = new Size(335, 20);
            LbHeaderCustomerRefill.TabIndex = 0;
            LbHeaderCustomerRefill.Text = "Thống kê tần suất khách hàng quay trở lại Refill";
            // 
            // ChartCustomerRefill
            // 
            ChartCustomerRefill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChartCustomerRefill.BackColor = Color.FromArgb(228, 255, 207);
            ChartCustomerRefill.BorderlineColor = Color.FromArgb(228, 255, 207);
            chartArea2.Name = "ChartArea1";
            ChartCustomerRefill.ChartAreas.Add(chartArea2);
            ChartCustomerRefill.Enabled = false;
            legend2.Name = "Legend1";
            ChartCustomerRefill.Legends.Add(legend2);
            ChartCustomerRefill.Location = new Point(295, 58);
            ChartCustomerRefill.Margin = new Padding(2);
            ChartCustomerRefill.Name = "ChartCustomerRefill";
            ChartCustomerRefill.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ChartCustomerRefill.Series.Add(series2);
            ChartCustomerRefill.Size = new Size(378, 201);
            ChartCustomerRefill.TabIndex = 0;
            ChartCustomerRefill.Text = "Biểu đồ thống kê tần suất khách hàng quay trở lại Refill";
            // 
            // PanelPackagingRecall
            // 
            PanelPackagingRecall.BackColor = Color.FromArgb(228, 255, 207);
            PanelPackagingRecall.BorderStyle = BorderStyle.FixedSingle;
            PanelPackagingRecall.Controls.Add(DtpDate);
            PanelPackagingRecall.Controls.Add(CbbTypeOfDate);
            PanelPackagingRecall.Controls.Add(LbPackagingRecallRate);
            PanelPackagingRecall.Controls.Add(LbTotalRecalling);
            PanelPackagingRecall.Controls.Add(LbTotalEmission);
            PanelPackagingRecall.Controls.Add(ChartPackagingRecall);
            PanelPackagingRecall.Controls.Add(PanelHeaderPackagingRecall);
            PanelPackagingRecall.Dock = DockStyle.Fill;
            PanelPackagingRecall.Location = new Point(694, 0);
            PanelPackagingRecall.Margin = new Padding(2);
            PanelPackagingRecall.Name = "PanelPackagingRecall";
            PanelPackagingRecall.Size = new Size(490, 293);
            PanelPackagingRecall.TabIndex = 3;
            // 
            // DtpDate
            // 
            DtpDate.CustomFormat = "MM/yyyy";
            DtpDate.Format = DateTimePickerFormat.Custom;
            DtpDate.Location = new Point(134, 57);
            DtpDate.Margin = new Padding(2);
            DtpDate.Name = "DtpDate";
            DtpDate.ShowUpDown = true;
            DtpDate.Size = new Size(119, 27);
            DtpDate.TabIndex = 10;
            DtpDate.ValueChanged += DtpDateValueChanged;
            // 
            // CbbTypeOfDate
            // 
            CbbTypeOfDate.AutoCompleteCustomSource.AddRange(new string[] { "Tháng", "Năm" });
            CbbTypeOfDate.AutoCompleteMode = AutoCompleteMode.Suggest;
            CbbTypeOfDate.FormattingEnabled = true;
            CbbTypeOfDate.Location = new Point(3, 57);
            CbbTypeOfDate.Margin = new Padding(2);
            CbbTypeOfDate.Name = "CbbTypeOfDate";
            CbbTypeOfDate.Size = new Size(119, 28);
            CbbTypeOfDate.TabIndex = 9;
            CbbTypeOfDate.Text = "Tháng / Năm";
            CbbTypeOfDate.SelectedIndexChanged += CbbTypeOfDateSelectedIndexChanged;
            // 
            // LbPackagingRecallRate
            // 
            LbPackagingRecallRate.AutoSize = true;
            LbPackagingRecallRate.Location = new Point(16, 181);
            LbPackagingRecallRate.Margin = new Padding(2, 0, 2, 0);
            LbPackagingRecallRate.Name = "LbPackagingRecallRate";
            LbPackagingRecallRate.Size = new Size(149, 20);
            LbPackagingRecallRate.TabIndex = 8;
            LbPackagingRecallRate.Text = "Tỉ lệ thu hồi bao bì: 0";
            // 
            // LbTotalRecalling
            // 
            LbTotalRecalling.AutoSize = true;
            LbTotalRecalling.Location = new Point(16, 146);
            LbTotalRecalling.Margin = new Padding(2, 0, 2, 0);
            LbTotalRecalling.Name = "LbTotalRecalling";
            LbTotalRecalling.Size = new Size(93, 20);
            LbTotalRecalling.TabIndex = 7;
            LbTotalRecalling.Text = "Tổng thu hồi";
            // 
            // LbTotalEmission
            // 
            LbTotalEmission.AutoSize = true;
            LbTotalEmission.Location = new Point(15, 111);
            LbTotalEmission.Margin = new Padding(2, 0, 2, 0);
            LbTotalEmission.Name = "LbTotalEmission";
            LbTotalEmission.Size = new Size(94, 20);
            LbTotalEmission.TabIndex = 6;
            LbTotalEmission.Text = "Tổng phát ra";
            // 
            // ChartPackagingRecall
            // 
            ChartPackagingRecall.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChartPackagingRecall.BackColor = Color.FromArgb(228, 255, 207);
            chartArea3.Name = "ChartArea1";
            ChartPackagingRecall.ChartAreas.Add(chartArea3);
            ChartPackagingRecall.Enabled = false;
            legend3.Name = "Legend1";
            ChartPackagingRecall.Legends.Add(legend3);
            ChartPackagingRecall.Location = new Point(242, 58);
            ChartPackagingRecall.Margin = new Padding(2);
            ChartPackagingRecall.Name = "ChartPackagingRecall";
            ChartPackagingRecall.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            ChartPackagingRecall.Series.Add(series3);
            ChartPackagingRecall.Size = new Size(239, 203);
            ChartPackagingRecall.TabIndex = 3;
            ChartPackagingRecall.Text = "Biểu đồ tỉ lệ thu hồi bao bì";
            // 
            // PanelHeaderPackagingRecall
            // 
            PanelHeaderPackagingRecall.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackagingRecall.Controls.Add(LbHeaderPackagingRecall);
            PanelHeaderPackagingRecall.Dock = DockStyle.Top;
            PanelHeaderPackagingRecall.Location = new Point(0, 0);
            PanelHeaderPackagingRecall.Margin = new Padding(2);
            PanelHeaderPackagingRecall.Name = "PanelHeaderPackagingRecall";
            PanelHeaderPackagingRecall.Size = new Size(488, 43);
            PanelHeaderPackagingRecall.TabIndex = 2;
            // 
            // LbHeaderPackagingRecall
            // 
            LbHeaderPackagingRecall.Anchor = AnchorStyles.Top;
            LbHeaderPackagingRecall.AutoSize = true;
            LbHeaderPackagingRecall.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderPackagingRecall.Location = new Point(166, 12);
            LbHeaderPackagingRecall.Margin = new Padding(2, 0, 2, 0);
            LbHeaderPackagingRecall.Name = "LbHeaderPackagingRecall";
            LbHeaderPackagingRecall.Size = new Size(137, 20);
            LbHeaderPackagingRecall.TabIndex = 0;
            LbHeaderPackagingRecall.Text = "Tỉ lệ thu hồi bao bì";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 659);
            Controls.Add(PanelPackagingRecall);
            Controls.Add(PanelCustomerRefill);
            Controls.Add(PanelReducePlasticPackaging);
            Controls.Add(PanelButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "StatisticsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrequencyCustomerReturnForm";
            PanelButton.ResumeLayout(false);
            PanelReducePlasticPackaging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartReducePlasticPackaging).EndInit();
            PanelLeftReducePlasticPackaging.ResumeLayout(false);
            PanelLeftReducePlasticPackaging.PerformLayout();
            PanelHeaderReducePlasticPackaging.ResumeLayout(false);
            PanelHeaderReducePlasticPackaging.PerformLayout();
            PanelCustomerRefill.ResumeLayout(false);
            PanelCustomerRefill.PerformLayout();
            PanelHeaderCustomerRefill.ResumeLayout(false);
            PanelHeaderCustomerRefill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChartCustomerRefill).EndInit();
            PanelPackagingRecall.ResumeLayout(false);
            PanelPackagingRecall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChartPackagingRecall).EndInit();
            PanelHeaderPackagingRecall.ResumeLayout(false);
            PanelHeaderPackagingRecall.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelButton;
        private Panel PanelReducePlasticPackaging;
        private Panel PanelCustomerRefill;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCustomerRefill;
        private Panel PanelPackagingRecall;
        private Panel PanelHeaderCustomerRefill;
        private Label LbHeaderCustomerRefill;
        private ComboBox CbbFilterCustomerRefill;
        private DateTimePicker DtpFilterCustomerRefill;
        private Label LbTotalCustomerRefill;
        private Label LbTotalCustomer;
        private Label FrequencyCustomerRefill;
        private Panel PanelHeaderPackagingRecall;
        private Label LbHeaderPackagingRecall;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPackagingRecall;
        private Label LbTotalEmission;
        private Label LbTotalRecalling;
        private Label LbPackagingRecallRate;
        private Panel PanelHeaderReducePlasticPackaging;
        private Label LbHeaderReducePlasticPackaging;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReducePlasticPackaging;
        private Panel PanelLeftReducePlasticPackaging;
        private ComboBox CbbFilterReducePlasticPackaging;
        private DateTimePicker DtpFilterReducePlasticPackaging;
        private Components.RJButton BtnExportExcel;
        private Components.RJButton BtnExportPDF;
        private DateTimePicker DtpDate;
        private ComboBox CbbTypeOfDate;
        private Label LbTotalPlasticEmit;
    }
}