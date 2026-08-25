namespace EcosystemApp.GUI.ChildPackageForm
{
    partial class StatiscalPackageForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PanelPackagingEmit = new Panel();
            DgvPackagingEmit = new DataGridView();
            PanelHeaderPackagingEmit = new Panel();
            LbHeaderPackagingEmit = new Label();
            PanelPackagingRecall = new Panel();
            DgvRetrievePackage = new DataGridView();
            PanelHeaderPackagingRecall = new Panel();
            LbHeaderPackagingRecall = new Label();
            PanelTop = new Panel();
            BtnPackagingRecall = new EcosystemApp.GUI.Components.RJButton();
            PanelChartCompare = new Panel();
            LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PanelHeaderChartCompare = new Panel();
            LbHeaderChartCompare = new Label();
            PanelMain = new Panel();
            CbbRangeTime = new ComboBox();
            PanelPackagingEmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPackagingEmit).BeginInit();
            PanelHeaderPackagingEmit.SuspendLayout();
            PanelPackagingRecall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRetrievePackage).BeginInit();
            PanelHeaderPackagingRecall.SuspendLayout();
            PanelTop.SuspendLayout();
            PanelChartCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LineChart).BeginInit();
            PanelHeaderChartCompare.SuspendLayout();
            PanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPackagingEmit
            // 
            PanelPackagingEmit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelPackagingEmit.BorderStyle = BorderStyle.FixedSingle;
            PanelPackagingEmit.Controls.Add(DgvPackagingEmit);
            PanelPackagingEmit.Controls.Add(PanelHeaderPackagingEmit);
            PanelPackagingEmit.Location = new Point(11, 6);
            PanelPackagingEmit.Name = "PanelPackagingEmit";
            PanelPackagingEmit.Size = new Size(792, 466);
            PanelPackagingEmit.TabIndex = 1;
            // 
            // DgvPackagingEmit
            // 
            DgvPackagingEmit.AllowUserToResizeRows = false;
            DgvPackagingEmit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPackagingEmit.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvPackagingEmit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPackagingEmit.Dock = DockStyle.Fill;
            DgvPackagingEmit.Location = new Point(0, 67);
            DgvPackagingEmit.Name = "DgvPackagingEmit";
            DgvPackagingEmit.RowHeadersVisible = false;
            DgvPackagingEmit.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPackagingEmit.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPackagingEmit.RowTemplate.Height = 45;
            DgvPackagingEmit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPackagingEmit.Size = new Size(790, 397);
            DgvPackagingEmit.TabIndex = 2;
            // 
            // PanelHeaderPackagingEmit
            // 
            PanelHeaderPackagingEmit.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackagingEmit.Controls.Add(LbHeaderPackagingEmit);
            PanelHeaderPackagingEmit.Dock = DockStyle.Top;
            PanelHeaderPackagingEmit.Location = new Point(0, 0);
            PanelHeaderPackagingEmit.Name = "PanelHeaderPackagingEmit";
            PanelHeaderPackagingEmit.Size = new Size(790, 67);
            PanelHeaderPackagingEmit.TabIndex = 1;
            // 
            // LbHeaderPackagingEmit
            // 
            LbHeaderPackagingEmit.Anchor = AnchorStyles.Top;
            LbHeaderPackagingEmit.AutoSize = true;
            LbHeaderPackagingEmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderPackagingEmit.Location = new Point(231, 18);
            LbHeaderPackagingEmit.Name = "LbHeaderPackagingEmit";
            LbHeaderPackagingEmit.Size = new Size(298, 32);
            LbHeaderPackagingEmit.TabIndex = 1;
            LbHeaderPackagingEmit.Text = "Danh sách bao bì phát ra";
            // 
            // PanelPackagingRecall
            // 
            PanelPackagingRecall.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelPackagingRecall.BorderStyle = BorderStyle.FixedSingle;
            PanelPackagingRecall.Controls.Add(DgvRetrievePackage);
            PanelPackagingRecall.Controls.Add(PanelHeaderPackagingRecall);
            PanelPackagingRecall.Location = new Point(819, 6);
            PanelPackagingRecall.Name = "PanelPackagingRecall";
            PanelPackagingRecall.Size = new Size(1071, 466);
            PanelPackagingRecall.TabIndex = 2;
            // 
            // DgvRetrievePackage
            // 
            DgvRetrievePackage.AllowUserToResizeRows = false;
            DgvRetrievePackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvRetrievePackage.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvRetrievePackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRetrievePackage.Dock = DockStyle.Fill;
            DgvRetrievePackage.Location = new Point(0, 67);
            DgvRetrievePackage.Name = "DgvRetrievePackage";
            DgvRetrievePackage.RowHeadersVisible = false;
            DgvRetrievePackage.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvRetrievePackage.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DgvRetrievePackage.RowTemplate.Height = 45;
            DgvRetrievePackage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRetrievePackage.Size = new Size(1069, 397);
            DgvRetrievePackage.TabIndex = 3;
            // 
            // PanelHeaderPackagingRecall
            // 
            PanelHeaderPackagingRecall.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackagingRecall.Controls.Add(LbHeaderPackagingRecall);
            PanelHeaderPackagingRecall.Dock = DockStyle.Top;
            PanelHeaderPackagingRecall.Location = new Point(0, 0);
            PanelHeaderPackagingRecall.Name = "PanelHeaderPackagingRecall";
            PanelHeaderPackagingRecall.Size = new Size(1069, 67);
            PanelHeaderPackagingRecall.TabIndex = 1;
            // 
            // LbHeaderPackagingRecall
            // 
            LbHeaderPackagingRecall.Anchor = AnchorStyles.Top;
            LbHeaderPackagingRecall.AutoSize = true;
            LbHeaderPackagingRecall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderPackagingRecall.Location = new Point(393, 18);
            LbHeaderPackagingRecall.Name = "LbHeaderPackagingRecall";
            LbHeaderPackagingRecall.Size = new Size(298, 32);
            LbHeaderPackagingRecall.TabIndex = 1;
            LbHeaderPackagingRecall.Text = "Danh sách bao bì thu hồi";
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(BtnPackagingRecall);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1903, 86);
            PanelTop.TabIndex = 3;
            // 
            // BtnPackagingRecall
            // 
            BtnPackagingRecall.BackColor = Color.FromArgb(196, 238, 181);
            BtnPackagingRecall.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnPackagingRecall.BoderSize = 2;
            BtnPackagingRecall.BorderColor = Color.Black;
            BtnPackagingRecall.BorderRadius = 39;
            BtnPackagingRecall.FlatAppearance.BorderSize = 0;
            BtnPackagingRecall.FlatStyle = FlatStyle.Flat;
            BtnPackagingRecall.ForeColor = Color.Black;
            BtnPackagingRecall.Location = new Point(11, 13);
            BtnPackagingRecall.Name = "BtnPackagingRecall";
            BtnPackagingRecall.Size = new Size(291, 62);
            BtnPackagingRecall.TabIndex = 2;
            BtnPackagingRecall.Text = "Ghi nhận bao bì thu hồi";
            BtnPackagingRecall.TextColor = Color.Black;
            BtnPackagingRecall.UseVisualStyleBackColor = false;
            BtnPackagingRecall.Click += BtnPackagingRecallClick;
            // 
            // PanelChartCompare
            // 
            PanelChartCompare.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelChartCompare.BorderStyle = BorderStyle.FixedSingle;
            PanelChartCompare.Controls.Add(LineChart);
            PanelChartCompare.Controls.Add(PanelHeaderChartCompare);
            PanelChartCompare.Location = new Point(11, 530);
            PanelChartCompare.Name = "PanelChartCompare";
            PanelChartCompare.Size = new Size(1879, 664);
            PanelChartCompare.TabIndex = 4;
            // 
            // LineChart
            // 
            chartArea1.Name = "ChartArea1";
            LineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            LineChart.Legends.Add(legend1);
            LineChart.Location = new Point(6, 75);
            LineChart.Margin = new Padding(5);
            LineChart.Name = "LineChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            LineChart.Series.Add(series1);
            LineChart.Size = new Size(1864, 600);
            LineChart.TabIndex = 3;
            LineChart.Text = "chart1";
            // 
            // PanelHeaderChartCompare
            // 
            PanelHeaderChartCompare.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderChartCompare.Controls.Add(LbHeaderChartCompare);
            PanelHeaderChartCompare.Dock = DockStyle.Top;
            PanelHeaderChartCompare.Location = new Point(0, 0);
            PanelHeaderChartCompare.Name = "PanelHeaderChartCompare";
            PanelHeaderChartCompare.Size = new Size(1877, 67);
            PanelHeaderChartCompare.TabIndex = 2;
            // 
            // LbHeaderChartCompare
            // 
            LbHeaderChartCompare.Anchor = AnchorStyles.Top;
            LbHeaderChartCompare.AutoSize = true;
            LbHeaderChartCompare.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderChartCompare.Location = new Point(817, 13);
            LbHeaderChartCompare.Name = "LbHeaderChartCompare";
            LbHeaderChartCompare.Size = new Size(194, 32);
            LbHeaderChartCompare.TabIndex = 1;
            LbHeaderChartCompare.Text = "Biểu đồ so sánh";
            // 
            // PanelMain
            // 
            PanelMain.Controls.Add(CbbRangeTime);
            PanelMain.Controls.Add(PanelChartCompare);
            PanelMain.Controls.Add(PanelPackagingRecall);
            PanelMain.Controls.Add(PanelPackagingEmit);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(0, 86);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1903, 1199);
            PanelMain.TabIndex = 6;
            // 
            // CbbRangeTime
            // 
            CbbRangeTime.FormattingEnabled = true;
            CbbRangeTime.Location = new Point(11, 477);
            CbbRangeTime.Margin = new Padding(5);
            CbbRangeTime.Name = "CbbRangeTime";
            CbbRangeTime.Size = new Size(243, 40);
            CbbRangeTime.TabIndex = 5;
            CbbRangeTime.SelectedIndexChanged += CbbRangeTimeSelectedIndexChanged;
            // 
            // StatiscalPackageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1903, 1285);
            Controls.Add(PanelMain);
            Controls.Add(PanelTop);
            Name = "StatiscalPackageForm";
            Text = "StatiscalPackageForm";
            PanelPackagingEmit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPackagingEmit).EndInit();
            PanelHeaderPackagingEmit.ResumeLayout(false);
            PanelHeaderPackagingEmit.PerformLayout();
            PanelPackagingRecall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvRetrievePackage).EndInit();
            PanelHeaderPackagingRecall.ResumeLayout(false);
            PanelHeaderPackagingRecall.PerformLayout();
            PanelTop.ResumeLayout(false);
            PanelChartCompare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LineChart).EndInit();
            PanelHeaderChartCompare.ResumeLayout(false);
            PanelHeaderChartCompare.PerformLayout();
            PanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelPackagingEmit;
        private Panel PanelPackagingRecall;
        private Panel PanelHeaderPackagingEmit;
        private Label LbHeaderPackagingEmit;
        private Panel PanelHeaderPackagingRecall;
        private Label LbHeaderPackagingRecall;
        private Panel PanelTop;
        private Panel PanelChartCompare;
        private Panel PanelHeaderChartCompare;
        private Label LbHeaderChartCompare;
        private Panel PanelMain;
        private DataGridView DgvPackagingEmit;
        private DataGridView DgvRetrievePackage;
        private Components.RJButton BtnPackagingRecall;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private ComboBox CbbRangeTime;
    }
}