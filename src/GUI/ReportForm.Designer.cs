namespace EcosystemApp.GUI
{
    partial class ReportForm
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
            PanelMenuReportForm = new Panel();
            BtnStatistics = new EcosystemApp.GUI.Components.RJButton();
            BtnRevenueReport = new EcosystemApp.GUI.Components.RJButton();
            PanelLeft = new Panel();
            PanelRight = new Panel();
            PanelBottom = new Panel();
            PanelChildReportForm = new Panel();
            PanelMenuReportForm.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuReportForm
            // 
            PanelMenuReportForm.Controls.Add(BtnStatistics);
            PanelMenuReportForm.Controls.Add(BtnRevenueReport);
            PanelMenuReportForm.Dock = DockStyle.Top;
            PanelMenuReportForm.Location = new Point(0, 0);
            PanelMenuReportForm.Name = "PanelMenuReportForm";
            PanelMenuReportForm.Size = new Size(2497, 72);
            PanelMenuReportForm.TabIndex = 0;
            // 
            // BtnStatistics
            // 
            BtnStatistics.BackColor = Color.FromArgb(248, 255, 245);
            BtnStatistics.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnStatistics.BoderSize = 0;
            BtnStatistics.BorderColor = Color.FromArgb(248, 255, 245);
            BtnStatistics.BorderRadius = 0;
            BtnStatistics.FlatAppearance.BorderSize = 0;
            BtnStatistics.FlatStyle = FlatStyle.Flat;
            BtnStatistics.ForeColor = Color.Black;
            BtnStatistics.Location = new Point(272, 0);
            BtnStatistics.Name = "BtnStatistics";
            BtnStatistics.Size = new Size(170, 56);
            BtnStatistics.TabIndex = 3;
            BtnStatistics.Text = "Thống kê";
            BtnStatistics.TextColor = Color.Black;
            BtnStatistics.UseVisualStyleBackColor = false;
            BtnStatistics.Click += BtnFrequencyCustomerRefillClick;
            // 
            // BtnRevenueReport
            // 
            BtnRevenueReport.BackColor = Color.FromArgb(248, 255, 245);
            BtnRevenueReport.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnRevenueReport.BoderSize = 0;
            BtnRevenueReport.BorderColor = Color.FromArgb(248, 255, 245);
            BtnRevenueReport.BorderRadius = 0;
            BtnRevenueReport.FlatAppearance.BorderSize = 0;
            BtnRevenueReport.FlatStyle = FlatStyle.Flat;
            BtnRevenueReport.ForeColor = Color.Black;
            BtnRevenueReport.Location = new Point(0, 0);
            BtnRevenueReport.Name = "BtnRevenueReport";
            BtnRevenueReport.Size = new Size(266, 56);
            BtnRevenueReport.TabIndex = 2;
            BtnRevenueReport.Text = "Báo cáo doanh thu";
            BtnRevenueReport.TextColor = Color.Black;
            BtnRevenueReport.UseVisualStyleBackColor = false;
            BtnRevenueReport.Click += BtnRevenueReportClick;
            // 
            // PanelLeft
            // 
            PanelLeft.Dock = DockStyle.Left;
            PanelLeft.Location = new Point(0, 72);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(29, 1252);
            PanelLeft.TabIndex = 4;
            // 
            // PanelRight
            // 
            PanelRight.Dock = DockStyle.Right;
            PanelRight.Location = new Point(2468, 72);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(29, 1252);
            PanelRight.TabIndex = 5;
            // 
            // PanelBottom
            // 
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(29, 1294);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(2439, 30);
            PanelBottom.TabIndex = 6;
            // 
            // PanelChildReportForm
            // 
            PanelChildReportForm.Dock = DockStyle.Fill;
            PanelChildReportForm.Location = new Point(29, 72);
            PanelChildReportForm.Name = "PanelChildReportForm";
            PanelChildReportForm.Size = new Size(2439, 1222);
            PanelChildReportForm.TabIndex = 7;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(2497, 1324);
            Controls.Add(PanelChildReportForm);
            Controls.Add(PanelBottom);
            Controls.Add(PanelRight);
            Controls.Add(PanelLeft);
            Controls.Add(PanelMenuReportForm);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý báo cáo";
            Load += ReportFormLoad;
            PanelMenuReportForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuReportForm;
        private Components.RJButton BtnRevenueReport;
        private Components.RJButton BtnStatistics;
        private Panel PanelLeft;
        private Panel PanelRight;
        private Panel PanelBottom;
        private Panel PanelChildReportForm;
    }
}