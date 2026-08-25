namespace EcosystemApp.GUI
{
    partial class HomePageForm
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
            LbHeaderHomePage = new Label();
            PanelHeaderHomePage = new Panel();
            PbLogoApp = new PictureBox();
            PanelHomePage = new Panel();
            PanelMain = new Panel();
            BtnLogout = new EcosystemApp.GUI.Components.RJButton();
            LabelEmployeeID = new Label();
            LabelEmployee = new Label();
            LabelHello = new Label();
            BtnOrder = new EcosystemApp.GUI.Components.RJButton();
            BtnStorage = new EcosystemApp.GUI.Components.RJButton();
            BtnPackage = new EcosystemApp.GUI.Components.RJButton();
            LbReportManagement = new Label();
            BtnEmployee = new EcosystemApp.GUI.Components.RJButton();
            LbEmployeeManagement = new Label();
            BtnReport = new EcosystemApp.GUI.Components.RJButton();
            LbPackagingManagement = new Label();
            LbOrderManagement = new Label();
            LbStorageManagement = new Label();
            PanelHeaderHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogoApp).BeginInit();
            PanelHomePage.SuspendLayout();
            PanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // LbHeaderHomePage
            // 
            LbHeaderHomePage.Anchor = AnchorStyles.Top;
            LbHeaderHomePage.AutoSize = true;
            LbHeaderHomePage.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderHomePage.ForeColor = Color.White;
            LbHeaderHomePage.Location = new Point(648, 29);
            LbHeaderHomePage.Name = "LbHeaderHomePage";
            LbHeaderHomePage.Size = new Size(710, 59);
            LbHeaderHomePage.TabIndex = 0;
            LbHeaderHomePage.Text = "HỆ THỐNG QUẢN LÍ ECOSTATION";
            // 
            // PanelHeaderHomePage
            // 
            PanelHeaderHomePage.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeaderHomePage.Controls.Add(PbLogoApp);
            PanelHeaderHomePage.Controls.Add(LbHeaderHomePage);
            PanelHeaderHomePage.Dock = DockStyle.Top;
            PanelHeaderHomePage.Location = new Point(0, 0);
            PanelHeaderHomePage.Name = "PanelHeaderHomePage";
            PanelHeaderHomePage.Size = new Size(1924, 123);
            PanelHeaderHomePage.TabIndex = 1;
            // 
            // PbLogoApp
            // 
            PbLogoApp.Image = src.assets.Image.Resource.logoapp;
            PbLogoApp.Location = new Point(0, 0);
            PbLogoApp.Name = "PbLogoApp";
            PbLogoApp.Size = new Size(134, 123);
            PbLogoApp.SizeMode = PictureBoxSizeMode.CenterImage;
            PbLogoApp.TabIndex = 21;
            PbLogoApp.TabStop = false;
            // 
            // PanelHomePage
            // 
            PanelHomePage.Controls.Add(PanelMain);
            PanelHomePage.Dock = DockStyle.Fill;
            PanelHomePage.Location = new Point(0, 123);
            PanelHomePage.Name = "PanelHomePage";
            PanelHomePage.Size = new Size(1924, 1255);
            PanelHomePage.TabIndex = 2;
            // 
            // PanelMain
            // 
            PanelMain.Controls.Add(BtnLogout);
            PanelMain.Controls.Add(LabelEmployeeID);
            PanelMain.Controls.Add(LabelEmployee);
            PanelMain.Controls.Add(LabelHello);
            PanelMain.Controls.Add(BtnOrder);
            PanelMain.Controls.Add(BtnStorage);
            PanelMain.Controls.Add(BtnPackage);
            PanelMain.Controls.Add(LbReportManagement);
            PanelMain.Controls.Add(BtnEmployee);
            PanelMain.Controls.Add(LbEmployeeManagement);
            PanelMain.Controls.Add(BtnReport);
            PanelMain.Controls.Add(LbPackagingManagement);
            PanelMain.Controls.Add(LbOrderManagement);
            PanelMain.Controls.Add(LbStorageManagement);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(0, 0);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1924, 1255);
            PanelMain.TabIndex = 21;
            // 
            // BtnLogout
            // 
            BtnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnLogout.BackColor = Color.White;
            BtnLogout.BackgroundColor = Color.White;
            BtnLogout.BoderSize = 0;
            BtnLogout.BorderColor = Color.Black;
            BtnLogout.BorderRadius = 0;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.ForeColor = Color.Black;
            BtnLogout.Image = src.assets.Image.Resource.logout;
            BtnLogout.Location = new Point(0, 1195);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(196, 60);
            BtnLogout.TabIndex = 17;
            BtnLogout.Text = "    Đăng xuất";
            BtnLogout.TextAlign = ContentAlignment.MiddleLeft;
            BtnLogout.TextColor = Color.Black;
            BtnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogoutClick;
            // 
            // LabelEmployeeID
            // 
            LabelEmployeeID.Anchor = AnchorStyles.Top;
            LabelEmployeeID.AutoSize = true;
            LabelEmployeeID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LabelEmployeeID.ForeColor = Color.FromArgb(86, 142, 89);
            LabelEmployeeID.Location = new Point(606, 175);
            LabelEmployeeID.Name = "LabelEmployeeID";
            LabelEmployeeID.Size = new Size(227, 45);
            LabelEmployeeID.TabIndex = 20;
            LabelEmployeeID.Text = "Mã nhân viên:";
            // 
            // LabelEmployee
            // 
            LabelEmployee.Anchor = AnchorStyles.Top;
            LabelEmployee.AutoSize = true;
            LabelEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            LabelEmployee.ForeColor = Color.FromArgb(86, 142, 89);
            LabelEmployee.Location = new Point(606, 101);
            LabelEmployee.Name = "LabelEmployee";
            LabelEmployee.Size = new Size(186, 45);
            LabelEmployee.TabIndex = 19;
            LabelEmployee.Text = "Nhân viên: ";
            // 
            // LabelHello
            // 
            LabelHello.Anchor = AnchorStyles.Top;
            LabelHello.AutoSize = true;
            LabelHello.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelHello.ForeColor = Color.FromArgb(86, 142, 89);
            LabelHello.Location = new Point(855, 19);
            LabelHello.Name = "LabelHello";
            LabelHello.Size = new Size(282, 71);
            LabelHello.TabIndex = 18;
            LabelHello.Text = "XIN CHÀO";
            // 
            // BtnOrder
            // 
            BtnOrder.Anchor = AnchorStyles.Top;
            BtnOrder.BackColor = Color.FromArgb(228, 255, 207);
            BtnOrder.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnOrder.BoderSize = 2;
            BtnOrder.BorderColor = Color.FromArgb(86, 142, 89);
            BtnOrder.BorderRadius = 40;
            BtnOrder.FlatAppearance.BorderSize = 0;
            BtnOrder.FlatStyle = FlatStyle.Flat;
            BtnOrder.ForeColor = Color.Black;
            BtnOrder.Image = src.assets.Image.Resource.order3;
            BtnOrder.Location = new Point(342, 328);
            BtnOrder.Name = "BtnOrder";
            BtnOrder.Size = new Size(370, 270);
            BtnOrder.TabIndex = 0;
            BtnOrder.TextColor = Color.Black;
            BtnOrder.UseVisualStyleBackColor = false;
            BtnOrder.Click += BtnOrderClick;
            // 
            // BtnStorage
            // 
            BtnStorage.Anchor = AnchorStyles.Top;
            BtnStorage.BackColor = Color.FromArgb(228, 255, 207);
            BtnStorage.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnStorage.BoderSize = 2;
            BtnStorage.BorderColor = Color.FromArgb(86, 142, 89);
            BtnStorage.BorderRadius = 40;
            BtnStorage.FlatAppearance.BorderSize = 0;
            BtnStorage.FlatStyle = FlatStyle.Flat;
            BtnStorage.ForeColor = Color.Black;
            BtnStorage.Image = src.assets.Image.Resource.storage3;
            BtnStorage.Location = new Point(822, 328);
            BtnStorage.Name = "BtnStorage";
            BtnStorage.Size = new Size(370, 270);
            BtnStorage.TabIndex = 1;
            BtnStorage.TextColor = Color.Black;
            BtnStorage.UseVisualStyleBackColor = false;
            BtnStorage.Click += BtnStorageClick;
            // 
            // BtnPackage
            // 
            BtnPackage.Anchor = AnchorStyles.Top;
            BtnPackage.BackColor = Color.FromArgb(228, 255, 207);
            BtnPackage.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnPackage.BoderSize = 2;
            BtnPackage.BorderColor = Color.FromArgb(86, 142, 89);
            BtnPackage.BorderRadius = 40;
            BtnPackage.FlatAppearance.BorderSize = 0;
            BtnPackage.FlatStyle = FlatStyle.Flat;
            BtnPackage.ForeColor = Color.Black;
            BtnPackage.Image = src.assets.Image.Resource.packaging3;
            BtnPackage.Location = new Point(1300, 328);
            BtnPackage.Name = "BtnPackage";
            BtnPackage.Size = new Size(370, 270);
            BtnPackage.TabIndex = 2;
            BtnPackage.TextColor = Color.Black;
            BtnPackage.UseVisualStyleBackColor = false;
            BtnPackage.Click += BtnPackageClick;
            // 
            // LbReportManagement
            // 
            LbReportManagement.Anchor = AnchorStyles.Top;
            LbReportManagement.AutoSize = true;
            LbReportManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbReportManagement.ForeColor = Color.FromArgb(86, 142, 89);
            LbReportManagement.Location = new Point(1163, 1014);
            LbReportManagement.Name = "LbReportManagement";
            LbReportManagement.Size = new Size(193, 32);
            LbReportManagement.TabIndex = 11;
            LbReportManagement.Text = "Quản lí báo cáo";
            // 
            // BtnEmployee
            // 
            BtnEmployee.Anchor = AnchorStyles.Top;
            BtnEmployee.BackColor = Color.FromArgb(228, 255, 207);
            BtnEmployee.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnEmployee.BoderSize = 2;
            BtnEmployee.BorderColor = Color.FromArgb(86, 142, 89);
            BtnEmployee.BorderRadius = 40;
            BtnEmployee.FlatAppearance.BorderSize = 0;
            BtnEmployee.FlatStyle = FlatStyle.Flat;
            BtnEmployee.ForeColor = Color.Black;
            BtnEmployee.Image = src.assets.Image.Resource.employee3;
            BtnEmployee.Location = new Point(576, 741);
            BtnEmployee.Name = "BtnEmployee";
            BtnEmployee.Size = new Size(370, 270);
            BtnEmployee.TabIndex = 3;
            BtnEmployee.TextColor = Color.Black;
            BtnEmployee.UseVisualStyleBackColor = false;
            BtnEmployee.Click += BtnEmployeeClick;
            // 
            // LbEmployeeManagement
            // 
            LbEmployeeManagement.Anchor = AnchorStyles.Top;
            LbEmployeeManagement.AutoSize = true;
            LbEmployeeManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbEmployeeManagement.ForeColor = Color.FromArgb(86, 142, 89);
            LbEmployeeManagement.Location = new Point(666, 1014);
            LbEmployeeManagement.Name = "LbEmployeeManagement";
            LbEmployeeManagement.Size = new Size(194, 32);
            LbEmployeeManagement.TabIndex = 9;
            LbEmployeeManagement.Text = "Quản lí nhân sự";
            // 
            // BtnReport
            // 
            BtnReport.Anchor = AnchorStyles.Top;
            BtnReport.BackColor = Color.FromArgb(228, 255, 207);
            BtnReport.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnReport.BoderSize = 2;
            BtnReport.BorderColor = Color.FromArgb(86, 142, 89);
            BtnReport.BorderRadius = 40;
            BtnReport.FlatAppearance.BorderSize = 0;
            BtnReport.FlatStyle = FlatStyle.Flat;
            BtnReport.ForeColor = Color.Black;
            BtnReport.Image = src.assets.Image.Resource.report3;
            BtnReport.Location = new Point(1061, 741);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(370, 270);
            BtnReport.TabIndex = 5;
            BtnReport.TextColor = Color.Black;
            BtnReport.UseVisualStyleBackColor = false;
            BtnReport.Click += BtnReportClick;
            // 
            // LbPackagingManagement
            // 
            LbPackagingManagement.Anchor = AnchorStyles.Top;
            LbPackagingManagement.AutoSize = true;
            LbPackagingManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbPackagingManagement.ForeColor = Color.FromArgb(86, 142, 89);
            LbPackagingManagement.Location = new Point(1402, 601);
            LbPackagingManagement.Name = "LbPackagingManagement";
            LbPackagingManagement.Size = new Size(175, 32);
            LbPackagingManagement.TabIndex = 8;
            LbPackagingManagement.Text = "Quản lí bao bì";
            // 
            // LbOrderManagement
            // 
            LbOrderManagement.Anchor = AnchorStyles.Top;
            LbOrderManagement.AutoSize = true;
            LbOrderManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbOrderManagement.ForeColor = Color.FromArgb(86, 142, 89);
            LbOrderManagement.Location = new Point(420, 601);
            LbOrderManagement.Name = "LbOrderManagement";
            LbOrderManagement.Size = new Size(212, 32);
            LbOrderManagement.TabIndex = 6;
            LbOrderManagement.Text = "Quản lí đơn hàng";
            // 
            // LbStorageManagement
            // 
            LbStorageManagement.Anchor = AnchorStyles.Top;
            LbStorageManagement.AutoSize = true;
            LbStorageManagement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbStorageManagement.ForeColor = Color.FromArgb(86, 142, 89);
            LbStorageManagement.Location = new Point(892, 601);
            LbStorageManagement.Name = "LbStorageManagement";
            LbStorageManagement.Size = new Size(223, 32);
            LbStorageManagement.TabIndex = 7;
            LbStorageManagement.Text = "Quản lí kho - trạm";
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 255, 210);
            ClientSize = new Size(1924, 1378);
            Controls.Add(PanelHomePage);
            Controls.Add(PanelHeaderHomePage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HomePageForm";
            StartPosition = FormStartPosition.Manual;
            Text = "EcoManagement Application";
            FormClosed += HomePageFormFormClosed;
            Load += HomePageFormLoad;
            PanelHeaderHomePage.ResumeLayout(false);
            PanelHeaderHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogoApp).EndInit();
            PanelHomePage.ResumeLayout(false);
            PanelMain.ResumeLayout(false);
            PanelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LbHeaderHomePage;
        private Panel PanelHeaderHomePage;
        private Panel PanelHomePage;
        private Components.RJButton BtnPackage;
        private Components.RJButton BtnStorage;
        private Components.RJButton BtnOrder;
        private Components.RJButton BtnReport;
        private Components.RJButton BtnEmployee;
        private Label LbReportManagement;
        private Label LbEmployeeManagement;
        private Label LbPackagingManagement;
        private Label LbStorageManagement;
        private Label LbOrderManagement;
        private Panel PanelMain;
        private Components.RJButton BtnLogout;
        private Label LabelEmployeeID;
        private Label LabelEmployee;
        private Label LabelHello;
        private PictureBox PbLogoApp;
    }
}