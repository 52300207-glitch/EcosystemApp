namespace EcosystemApp.GUI.ChildReportForm
{
    partial class RevenueReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PanelHeader = new Panel();
            LabelHeader = new Label();
            DgvRevenueReport = new DataGridView();
            PanelHeaderRevenueChart = new Panel();
            LbHeaderRevenueChart = new Label();
            PanelButton = new Panel();
            BtnExportExcel = new EcosystemApp.GUI.Components.RJButton();
            BtnExportPDF = new EcosystemApp.GUI.Components.RJButton();
            PanelTop = new Panel();
            BtnFilter = new EcosystemApp.GUI.Components.RJButton();
            DtpFilter = new DateTimePicker();
            CbbFilter = new ComboBox();
            PanelRevenueChart = new Panel();
            RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRevenueReport).BeginInit();
            PanelHeaderRevenueChart.SuspendLayout();
            PanelButton.SuspendLayout();
            PanelTop.SuspendLayout();
            PanelRevenueChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RevenueChart).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeader.BorderStyle = BorderStyle.FixedSingle;
            PanelHeader.Controls.Add(LabelHeader);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 72);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1924, 60);
            PanelHeader.TabIndex = 1;
            // 
            // LabelHeader
            // 
            LabelHeader.Anchor = AnchorStyles.Top;
            LabelHeader.AutoSize = true;
            LabelHeader.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelHeader.Location = new Point(854, 14);
            LabelHeader.Name = "LabelHeader";
            LabelHeader.Size = new Size(256, 37);
            LabelHeader.TabIndex = 0;
            LabelHeader.Text = "Báo cáo doanh thu";
            // 
            // DgvRevenueReport
            // 
            DgvRevenueReport.AllowUserToResizeRows = false;
            DgvRevenueReport.BackgroundColor = Color.White;
            DgvRevenueReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRevenueReport.Dock = DockStyle.Top;
            DgvRevenueReport.Location = new Point(0, 132);
            DgvRevenueReport.Name = "DgvRevenueReport";
            DgvRevenueReport.RowHeadersWidth = 82;
            DgvRevenueReport.Size = new Size(1924, 419);
            DgvRevenueReport.TabIndex = 2;
            // 
            // PanelHeaderRevenueChart
            // 
            PanelHeaderRevenueChart.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderRevenueChart.BorderStyle = BorderStyle.FixedSingle;
            PanelHeaderRevenueChart.Controls.Add(LbHeaderRevenueChart);
            PanelHeaderRevenueChart.Dock = DockStyle.Top;
            PanelHeaderRevenueChart.Location = new Point(0, 551);
            PanelHeaderRevenueChart.Name = "PanelHeaderRevenueChart";
            PanelHeaderRevenueChart.Size = new Size(1924, 63);
            PanelHeaderRevenueChart.TabIndex = 3;
            // 
            // LbHeaderRevenueChart
            // 
            LbHeaderRevenueChart.Anchor = AnchorStyles.Top;
            LbHeaderRevenueChart.AutoSize = true;
            LbHeaderRevenueChart.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderRevenueChart.Location = new Point(854, 13);
            LbHeaderRevenueChart.Name = "LbHeaderRevenueChart";
            LbHeaderRevenueChart.Size = new Size(252, 37);
            LbHeaderRevenueChart.TabIndex = 1;
            LbHeaderRevenueChart.Text = "Biểu đồ doanh thu";
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnExportExcel);
            PanelButton.Controls.Add(BtnExportPDF);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 977);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1924, 77);
            PanelButton.TabIndex = 4;
            // 
            // BtnExportExcel
            // 
            BtnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExportExcel.BackColor = Color.FromArgb(196, 238, 181);
            BtnExportExcel.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnExportExcel.BoderSize = 2;
            BtnExportExcel.BorderColor = Color.Black;
            BtnExportExcel.BorderRadius = 40;
            BtnExportExcel.FlatAppearance.BorderSize = 0;
            BtnExportExcel.FlatStyle = FlatStyle.Flat;
            BtnExportExcel.ForeColor = Color.Black;
            BtnExportExcel.Location = new Point(1534, 6);
            BtnExportExcel.Name = "BtnExportExcel";
            BtnExportExcel.Size = new Size(193, 67);
            BtnExportExcel.TabIndex = 1;
            BtnExportExcel.Text = "Xuất Excel";
            BtnExportExcel.TextColor = Color.Black;
            BtnExportExcel.UseVisualStyleBackColor = false;
            BtnExportExcel.Click += BtnExportExcelClick;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExportPDF.BackColor = Color.FromArgb(196, 238, 181);
            BtnExportPDF.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnExportPDF.BoderSize = 2;
            BtnExportPDF.BorderColor = Color.Black;
            BtnExportPDF.BorderRadius = 40;
            BtnExportPDF.FlatAppearance.BorderSize = 0;
            BtnExportPDF.FlatStyle = FlatStyle.Flat;
            BtnExportPDF.ForeColor = Color.Black;
            BtnExportPDF.Location = new Point(1732, 6);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(188, 67);
            BtnExportPDF.TabIndex = 0;
            BtnExportPDF.Text = "Xuất PDF";
            BtnExportPDF.TextColor = Color.Black;
            BtnExportPDF.UseVisualStyleBackColor = false;
            BtnExportPDF.Click += BtnExportPDFClick;
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(BtnFilter);
            PanelTop.Controls.Add(DtpFilter);
            PanelTop.Controls.Add(CbbFilter);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1924, 72);
            PanelTop.TabIndex = 0;
            // 
            // BtnFilter
            // 
            BtnFilter.BackColor = Color.FromArgb(196, 238, 181);
            BtnFilter.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnFilter.BoderSize = 2;
            BtnFilter.BorderColor = Color.Black;
            BtnFilter.BorderRadius = 20;
            BtnFilter.FlatAppearance.BorderSize = 0;
            BtnFilter.FlatStyle = FlatStyle.Flat;
            BtnFilter.ForeColor = Color.Black;
            BtnFilter.Location = new Point(411, 13);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(104, 40);
            BtnFilter.TabIndex = 2;
            BtnFilter.Text = "Lọc";
            BtnFilter.TextColor = Color.Black;
            BtnFilter.UseVisualStyleBackColor = false;
            BtnFilter.Click += BtnFilterClick;
            // 
            // DtpFilter
            // 
            DtpFilter.CustomFormat = "MM/yyyy";
            DtpFilter.Format = DateTimePickerFormat.Custom;
            DtpFilter.Location = new Point(255, 13);
            DtpFilter.Name = "DtpFilter";
            DtpFilter.ShowUpDown = true;
            DtpFilter.Size = new Size(150, 39);
            DtpFilter.TabIndex = 1;
            // 
            // CbbFilter
            // 
            CbbFilter.FormattingEnabled = true;
            CbbFilter.Location = new Point(11, 13);
            CbbFilter.Name = "CbbFilter";
            CbbFilter.Size = new Size(236, 40);
            CbbFilter.TabIndex = 0;
            CbbFilter.SelectedIndexChanged += CbbFilterSelectedIndexChanged;
            // 
            // PanelRevenueChart
            // 
            PanelRevenueChart.Controls.Add(RevenueChart);
            PanelRevenueChart.Dock = DockStyle.Fill;
            PanelRevenueChart.Location = new Point(0, 614);
            PanelRevenueChart.Name = "PanelRevenueChart";
            PanelRevenueChart.Size = new Size(1924, 363);
            PanelRevenueChart.TabIndex = 5;
            // 
            // RevenueChart
            // 
            chartArea2.Name = "ChartArea1";
            RevenueChart.ChartAreas.Add(chartArea2);
            RevenueChart.Dock = DockStyle.Fill;
            RevenueChart.Enabled = false;
            legend2.Name = "Legend1";
            RevenueChart.Legends.Add(legend2);
            RevenueChart.Location = new Point(0, 0);
            RevenueChart.Name = "RevenueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            RevenueChart.Series.Add(series2);
            RevenueChart.Size = new Size(1924, 363);
            RevenueChart.TabIndex = 0;
            RevenueChart.Text = "chart1";
            // 
            // RevenueReportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1924, 1054);
            Controls.Add(PanelRevenueChart);
            Controls.Add(PanelButton);
            Controls.Add(PanelHeaderRevenueChart);
            Controls.Add(DgvRevenueReport);
            Controls.Add(PanelHeader);
            Controls.Add(PanelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RevenueReportForm";
            Text = "RevenueReportForm";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRevenueReport).EndInit();
            PanelHeaderRevenueChart.ResumeLayout(false);
            PanelHeaderRevenueChart.PerformLayout();
            PanelButton.ResumeLayout(false);
            PanelTop.ResumeLayout(false);
            PanelRevenueChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RevenueChart).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelHeader;
        private Label LabelHeader;
        private DataGridView DgvRevenueReport;
        private Panel PanelHeaderRevenueChart;
        private Label LbHeaderRevenueChart;
        private Panel PanelButton;
        private Components.RJButton BtnExportPDF;
        private Components.RJButton BtnExportExcel;
        private Panel PanelTop;
        private DateTimePicker DtpFilter;
        private ComboBox CbbFilter;
        private Components.RJButton BtnFilter;
        private Panel PanelRevenueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
    }
}