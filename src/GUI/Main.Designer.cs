namespace EcosystemApp.GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            PanelMenu = new Panel();
            BtnSetting = new EcosystemApp.GUI.Components.RJButton();
            BtnReport = new EcosystemApp.GUI.Components.RJButton();
            BtnEmployee = new EcosystemApp.GUI.Components.RJButton();
            BtnPackage = new EcosystemApp.GUI.Components.RJButton();
            BtnStorage = new EcosystemApp.GUI.Components.RJButton();
            BtnOrder = new EcosystemApp.GUI.Components.RJButton();
            PictureBox1 = new PictureBox();
            BtnLogout = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderForm = new Panel();
            BtnHomePage = new EcosystemApp.GUI.Components.RJButton();
            lbHeaderFrom = new Label();
            PanelChildForm = new Panel();
            PanelBackup = new Panel();
            BtnExcel = new EcosystemApp.GUI.Components.RJButton();
            BtnPDF = new EcosystemApp.GUI.Components.RJButton();
            PanelSetting = new Panel();
            BtnBackup = new EcosystemApp.GUI.Components.RJButton();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            PanelHeaderForm.SuspendLayout();
            PanelChildForm.SuspendLayout();
            PanelBackup.SuspendLayout();
            PanelSetting.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(86, 142, 89);
            PanelMenu.Controls.Add(BtnSetting);
            PanelMenu.Controls.Add(BtnReport);
            PanelMenu.Controls.Add(BtnEmployee);
            PanelMenu.Controls.Add(BtnPackage);
            PanelMenu.Controls.Add(BtnStorage);
            PanelMenu.Controls.Add(BtnOrder);
            PanelMenu.Controls.Add(PictureBox1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(361, 1054);
            PanelMenu.TabIndex = 1;
            // 
            // BtnSetting
            // 
            BtnSetting.BackColor = Color.FromArgb(86, 142, 89);
            BtnSetting.BackgroundColor = Color.FromArgb(86, 142, 89);
            BtnSetting.BoderSize = 0;
            BtnSetting.BorderColor = Color.Black;
            BtnSetting.BorderRadius = 15;
            BtnSetting.Dock = DockStyle.Bottom;
            BtnSetting.FlatAppearance.BorderSize = 0;
            BtnSetting.FlatStyle = FlatStyle.Flat;
            BtnSetting.ForeColor = Color.Transparent;
            BtnSetting.Image = src.assets.Image.Resource.setting1;
            BtnSetting.Location = new Point(0, 982);
            BtnSetting.Name = "BtnSetting";
            BtnSetting.Size = new Size(361, 72);
            BtnSetting.TabIndex = 19;
            BtnSetting.Text = "                  Cài đặt     ";
            BtnSetting.TextAlign = ContentAlignment.MiddleLeft;
            BtnSetting.TextColor = Color.Transparent;
            BtnSetting.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnSetting.UseVisualStyleBackColor = false;
            BtnSetting.Click += BtnSettingClick;
            // 
            // BtnReport
            // 
            BtnReport.BackColor = Color.FromArgb(86, 142, 89);
            BtnReport.BackgroundColor = Color.FromArgb(86, 142, 89);
            BtnReport.BoderSize = 0;
            BtnReport.BorderColor = Color.FromArgb(86, 142, 89);
            BtnReport.BorderRadius = 40;
            BtnReport.Dock = DockStyle.Top;
            BtnReport.FlatAppearance.BorderSize = 0;
            BtnReport.FlatStyle = FlatStyle.Flat;
            BtnReport.Font = new Font("Segoe UI", 10.125F);
            BtnReport.ForeColor = Color.White;
            BtnReport.Image = src.assets.Image.Resource.report1;
            BtnReport.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReport.Location = new Point(0, 526);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(361, 99);
            BtnReport.TabIndex = 15;
            BtnReport.Text = "              Báo cáo          ";
            BtnReport.TextAlign = ContentAlignment.MiddleLeft;
            BtnReport.TextColor = Color.White;
            BtnReport.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnReport.UseVisualStyleBackColor = false;
            BtnReport.Click += BtnReportClick;
            // 
            // BtnEmployee
            // 
            BtnEmployee.BackColor = Color.FromArgb(86, 142, 89);
            BtnEmployee.BackgroundColor = Color.FromArgb(86, 142, 89);
            BtnEmployee.BoderSize = 0;
            BtnEmployee.BorderColor = Color.FromArgb(86, 142, 89);
            BtnEmployee.BorderRadius = 40;
            BtnEmployee.Dock = DockStyle.Top;
            BtnEmployee.FlatAppearance.BorderSize = 0;
            BtnEmployee.FlatStyle = FlatStyle.Flat;
            BtnEmployee.Font = new Font("Segoe UI", 10.125F);
            BtnEmployee.ForeColor = Color.White;
            BtnEmployee.Image = src.assets.Image.Resource.employee1;
            BtnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEmployee.Location = new Point(0, 427);
            BtnEmployee.Name = "BtnEmployee";
            BtnEmployee.Size = new Size(361, 99);
            BtnEmployee.TabIndex = 13;
            BtnEmployee.Text = "              Nhân sự         ";
            BtnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            BtnEmployee.TextColor = Color.White;
            BtnEmployee.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnEmployee.UseVisualStyleBackColor = false;
            BtnEmployee.Click += BtnEmployeeClick;
            // 
            // BtnPackage
            // 
            BtnPackage.BackColor = Color.FromArgb(86, 142, 89);
            BtnPackage.BackgroundColor = Color.FromArgb(86, 142, 89);
            BtnPackage.BoderSize = 0;
            BtnPackage.BorderColor = Color.FromArgb(86, 142, 89);
            BtnPackage.BorderRadius = 40;
            BtnPackage.Dock = DockStyle.Top;
            BtnPackage.FlatAppearance.BorderSize = 0;
            BtnPackage.FlatStyle = FlatStyle.Flat;
            BtnPackage.Font = new Font("Segoe UI", 10.125F);
            BtnPackage.ForeColor = Color.White;
            BtnPackage.Image = src.assets.Image.Resource.packaging1;
            BtnPackage.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPackage.Location = new Point(0, 328);
            BtnPackage.Name = "BtnPackage";
            BtnPackage.Size = new Size(361, 99);
            BtnPackage.TabIndex = 12;
            BtnPackage.Text = "              Bao bì             ";
            BtnPackage.TextAlign = ContentAlignment.MiddleLeft;
            BtnPackage.TextColor = Color.White;
            BtnPackage.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnPackage.UseVisualStyleBackColor = false;
            BtnPackage.Click += BtnPackageClick;
            // 
            // BtnStorage
            // 
            BtnStorage.BackColor = Color.FromArgb(86, 142, 89);
            BtnStorage.BackgroundColor = Color.FromArgb(86, 142, 89);
            BtnStorage.BoderSize = 0;
            BtnStorage.BorderColor = Color.FromArgb(86, 142, 89);
            BtnStorage.BorderRadius = 40;
            BtnStorage.Dock = DockStyle.Top;
            BtnStorage.FlatAppearance.BorderSize = 0;
            BtnStorage.FlatStyle = FlatStyle.Flat;
            BtnStorage.Font = new Font("Segoe UI", 10.125F);
            BtnStorage.ForeColor = Color.White;
            BtnStorage.Image = src.assets.Image.Resource.storage1;
            BtnStorage.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStorage.Location = new Point(0, 229);
            BtnStorage.Name = "BtnStorage";
            BtnStorage.Size = new Size(361, 99);
            BtnStorage.TabIndex = 11;
            BtnStorage.Text = "              Kho - Trạm     ";
            BtnStorage.TextAlign = ContentAlignment.MiddleLeft;
            BtnStorage.TextColor = Color.White;
            BtnStorage.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnStorage.UseVisualStyleBackColor = false;
            BtnStorage.Click += BtnStorageClick;
            // 
            // BtnOrder
            // 
            BtnOrder.BackColor = Color.FromArgb(86, 142, 89);
            BtnOrder.BackgroundColor = Color.FromArgb(86, 142, 89);
            BtnOrder.BoderSize = 0;
            BtnOrder.BorderColor = Color.FromArgb(86, 142, 89);
            BtnOrder.BorderRadius = 40;
            BtnOrder.Dock = DockStyle.Top;
            BtnOrder.FlatAppearance.BorderSize = 0;
            BtnOrder.FlatStyle = FlatStyle.Flat;
            BtnOrder.Font = new Font("Segoe UI", 10.125F);
            BtnOrder.ForeColor = Color.White;
            BtnOrder.Image = src.assets.Image.Resource.order1;
            BtnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            BtnOrder.Location = new Point(0, 130);
            BtnOrder.Name = "BtnOrder";
            BtnOrder.Size = new Size(361, 99);
            BtnOrder.TabIndex = 0;
            BtnOrder.Text = "              Đơn hàng       ";
            BtnOrder.TextAlign = ContentAlignment.MiddleLeft;
            BtnOrder.TextColor = Color.White;
            BtnOrder.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnOrder.UseVisualStyleBackColor = false;
            BtnOrder.Click += BtnOrderClick;
            // 
            // PictureBox1
            // 
            PictureBox1.Dock = DockStyle.Top;
            PictureBox1.Image = src.assets.Image.Resource.logoapp;
            PictureBox1.Location = new Point(0, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(361, 130);
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.White;
            BtnLogout.BackgroundColor = Color.White;
            BtnLogout.BoderSize = 0;
            BtnLogout.BorderColor = Color.Black;
            BtnLogout.BorderRadius = 0;
            BtnLogout.Dock = DockStyle.Bottom;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.ForeColor = Color.Black;
            BtnLogout.Image = src.assets.Image.Resource.logout;
            BtnLogout.Location = new Point(0, 86);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(310, 77);
            BtnLogout.TabIndex = 16;
            BtnLogout.Text = "   Đăng xuất    ";
            BtnLogout.TextAlign = ContentAlignment.MiddleRight;
            BtnLogout.TextColor = Color.Black;
            BtnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogoutClick;
            // 
            // PanelHeaderForm
            // 
            PanelHeaderForm.BackColor = Color.FromArgb(211, 255, 210);
            PanelHeaderForm.Controls.Add(BtnHomePage);
            PanelHeaderForm.Controls.Add(lbHeaderFrom);
            PanelHeaderForm.Dock = DockStyle.Top;
            PanelHeaderForm.Location = new Point(361, 0);
            PanelHeaderForm.Name = "PanelHeaderForm";
            PanelHeaderForm.Size = new Size(1563, 130);
            PanelHeaderForm.TabIndex = 2;
            // 
            // BtnHomePage
            // 
            BtnHomePage.BackColor = Color.FromArgb(211, 255, 210);
            BtnHomePage.BackgroundColor = Color.FromArgb(211, 255, 210);
            BtnHomePage.BoderSize = 0;
            BtnHomePage.BorderColor = Color.PaleVioletRed;
            BtnHomePage.BorderRadius = 40;
            BtnHomePage.FlatAppearance.BorderSize = 0;
            BtnHomePage.FlatStyle = FlatStyle.Flat;
            BtnHomePage.ForeColor = Color.White;
            BtnHomePage.Image = src.assets.Image.Resource.homepage;
            BtnHomePage.Location = new Point(20, 13);
            BtnHomePage.Name = "BtnHomePage";
            BtnHomePage.Size = new Size(109, 98);
            BtnHomePage.TabIndex = 1;
            BtnHomePage.TextColor = Color.White;
            BtnHomePage.UseVisualStyleBackColor = false;
            BtnHomePage.Click += BtnHomePageClick;
            // 
            // lbHeaderFrom
            // 
            lbHeaderFrom.Anchor = AnchorStyles.None;
            lbHeaderFrom.AutoSize = true;
            lbHeaderFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeaderFrom.Location = new Point(722, 48);
            lbHeaderFrom.Name = "lbHeaderFrom";
            lbHeaderFrom.Size = new Size(236, 45);
            lbHeaderFrom.TabIndex = 0;
            lbHeaderFrom.Text = "HEADER NAME";
            // 
            // PanelChildForm
            // 
            PanelChildForm.BackColor = Color.FromArgb(248, 255, 245);
            PanelChildForm.Controls.Add(PanelBackup);
            PanelChildForm.Controls.Add(PanelSetting);
            PanelChildForm.Dock = DockStyle.Fill;
            PanelChildForm.Location = new Point(361, 130);
            PanelChildForm.Name = "PanelChildForm";
            PanelChildForm.Size = new Size(1563, 924);
            PanelChildForm.TabIndex = 3;
            // 
            // PanelBackup
            // 
            PanelBackup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PanelBackup.BorderStyle = BorderStyle.FixedSingle;
            PanelBackup.Controls.Add(BtnExcel);
            PanelBackup.Controls.Add(BtnPDF);
            PanelBackup.Location = new Point(318, 759);
            PanelBackup.Name = "PanelBackup";
            PanelBackup.Size = new Size(168, 122);
            PanelBackup.TabIndex = 21;
            PanelBackup.Visible = false;
            // 
            // BtnExcel
            // 
            BtnExcel.BackColor = Color.White;
            BtnExcel.BackgroundColor = Color.White;
            BtnExcel.BoderSize = 0;
            BtnExcel.BorderColor = Color.Black;
            BtnExcel.BorderRadius = 0;
            BtnExcel.Dock = DockStyle.Fill;
            BtnExcel.FlatAppearance.BorderSize = 0;
            BtnExcel.FlatStyle = FlatStyle.Flat;
            BtnExcel.ForeColor = Color.Black;
            BtnExcel.Location = new Point(0, 61);
            BtnExcel.Name = "BtnExcel";
            BtnExcel.Size = new Size(166, 59);
            BtnExcel.TabIndex = 19;
            BtnExcel.Text = "Excel";
            BtnExcel.TextColor = Color.Black;
            BtnExcel.UseVisualStyleBackColor = false;
            BtnExcel.Click += BtnExcelClick;
            // 
            // BtnPDF
            // 
            BtnPDF.BackColor = Color.White;
            BtnPDF.BackgroundColor = Color.White;
            BtnPDF.BoderSize = 0;
            BtnPDF.BorderColor = Color.Black;
            BtnPDF.BorderRadius = 0;
            BtnPDF.Dock = DockStyle.Top;
            BtnPDF.FlatAppearance.BorderSize = 0;
            BtnPDF.FlatStyle = FlatStyle.Flat;
            BtnPDF.ForeColor = Color.Black;
            BtnPDF.Location = new Point(0, 0);
            BtnPDF.Name = "BtnPDF";
            BtnPDF.Size = new Size(166, 61);
            BtnPDF.TabIndex = 18;
            BtnPDF.Text = "PDF";
            BtnPDF.TextColor = Color.Black;
            BtnPDF.UseVisualStyleBackColor = false;
            BtnPDF.Click += BtnPDFClick;
            // 
            // PanelSetting
            // 
            PanelSetting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PanelSetting.BorderStyle = BorderStyle.FixedSingle;
            PanelSetting.Controls.Add(BtnBackup);
            PanelSetting.Controls.Add(BtnLogout);
            PanelSetting.Location = new Point(0, 759);
            PanelSetting.Name = "PanelSetting";
            PanelSetting.Size = new Size(312, 165);
            PanelSetting.TabIndex = 20;
            PanelSetting.Visible = false;
            // 
            // BtnBackup
            // 
            BtnBackup.BackColor = Color.White;
            BtnBackup.BackgroundColor = Color.White;
            BtnBackup.BoderSize = 0;
            BtnBackup.BorderColor = Color.Black;
            BtnBackup.BorderRadius = 0;
            BtnBackup.Dock = DockStyle.Fill;
            BtnBackup.FlatAppearance.BorderSize = 0;
            BtnBackup.FlatStyle = FlatStyle.Flat;
            BtnBackup.ForeColor = Color.Black;
            BtnBackup.Image = src.assets.Image.Resource.backup;
            BtnBackup.Location = new Point(0, 0);
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Size = new Size(310, 86);
            BtnBackup.TabIndex = 17;
            BtnBackup.Text = "  Sao lưu      >";
            BtnBackup.TextAlign = ContentAlignment.MiddleRight;
            BtnBackup.TextColor = Color.Black;
            BtnBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBackup.UseVisualStyleBackColor = false;
            BtnBackup.Click += BtnBackupClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1054);
            Controls.Add(PanelChildForm);
            Controls.Add(PanelHeaderForm);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Main";
            StartPosition = FormStartPosition.Manual;
            Text = "EcoSystem Management";
            FormClosed += MainFormClosed;
            Load += MainLoad;
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            PanelHeaderForm.ResumeLayout(false);
            PanelHeaderForm.PerformLayout();
            PanelChildForm.ResumeLayout(false);
            PanelBackup.ResumeLayout(false);
            PanelSetting.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel PanelMenu;
        private PictureBox PictureBox1;
        private Panel PanelHeaderForm;
        private Label lbHeaderFrom;
        private Panel PanelChildForm;
        private GUI.Components.RJButton BtnHomePage;
        private GUI.Components.RJButton BtnOrder;
        private GUI.Components.RJButton BtnReport;
        private GUI.Components.RJButton BtnEmployee;
        private GUI.Components.RJButton BtnPackage;
        private GUI.Components.RJButton BtnStorage;
        private GUI.Components.RJButton BtnLogout;
        private GUI.Components.RJButton BtnSetting;
        private Panel PanelSetting;
        private GUI.Components.RJButton BtnBackup;
        private Panel PanelBackup;
        private GUI.Components.RJButton BtnPDF;
        private GUI.Components.RJButton BtnExcel;
    }
}

