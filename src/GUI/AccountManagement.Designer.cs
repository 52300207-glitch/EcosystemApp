namespace EcosystemApp.GUI
{
    partial class AccountManagement
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
            PanelHeaderCreateEmployee = new Panel();
            LbHeader = new Label();
            PanelInfoAccount = new Panel();
            TlpInfoAccount = new TableLayoutPanel();
            TbEmployeeName = new TextBox();
            LbHeaderInfoAccount = new Label();
            FlpInfoAccountButton = new FlowLayoutPanel();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            BtnAdd = new EcosystemApp.GUI.Components.RJButton();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnFix = new EcosystemApp.GUI.Components.RJButton();
            BtnView = new EcosystemApp.GUI.Components.RJButton();
            BtnCancel = new EcosystemApp.GUI.Components.RJButton();
            LbEmployeeName = new Label();
            LbAccountName = new Label();
            LbEmployeePhone = new Label();
            TbUserName = new TextBox();
            TbEmployeePhone = new TextBox();
            LbPassword = new Label();
            TbPassword = new TextBox();
            PanelAccountList = new Panel();
            DgvAccountList = new DataGridView();
            LbHeaaderAccountList = new Label();
            PanelHeaderCreateEmployee.SuspendLayout();
            PanelInfoAccount.SuspendLayout();
            TlpInfoAccount.SuspendLayout();
            FlpInfoAccountButton.SuspendLayout();
            PanelAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvAccountList).BeginInit();
            SuspendLayout();
            // 
            // PanelHeaderCreateEmployee
            // 
            PanelHeaderCreateEmployee.Controls.Add(LbHeader);
            PanelHeaderCreateEmployee.Dock = DockStyle.Top;
            PanelHeaderCreateEmployee.Location = new Point(0, 0);
            PanelHeaderCreateEmployee.Name = "PanelHeaderCreateEmployee";
            PanelHeaderCreateEmployee.Size = new Size(1874, 91);
            PanelHeaderCreateEmployee.TabIndex = 0;
            // 
            // LbHeader
            // 
            LbHeader.Anchor = AnchorStyles.Top;
            LbHeader.AutoSize = true;
            LbHeader.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeader.ForeColor = Color.FromArgb(86, 142, 89);
            LbHeader.Location = new Point(750, 30);
            LbHeader.Name = "LbHeader";
            LbHeader.Size = new Size(385, 37);
            LbHeader.TabIndex = 0;
            LbHeader.Text = "TẠO TÀI KHOẢN NHÂN VIÊN";
            LbHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelInfoAccount
            // 
            PanelInfoAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelInfoAccount.BackColor = Color.FromArgb(248, 255, 245);
            PanelInfoAccount.BorderStyle = BorderStyle.FixedSingle;
            PanelInfoAccount.Controls.Add(TlpInfoAccount);
            PanelInfoAccount.Location = new Point(80, 118);
            PanelInfoAccount.Name = "PanelInfoAccount";
            PanelInfoAccount.Size = new Size(1666, 213);
            PanelInfoAccount.TabIndex = 1;
            // 
            // TlpInfoAccount
            // 
            TlpInfoAccount.AutoSize = true;
            TlpInfoAccount.ColumnCount = 4;
            TlpInfoAccount.ColumnStyles.Add(new ColumnStyle());
            TlpInfoAccount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpInfoAccount.ColumnStyles.Add(new ColumnStyle());
            TlpInfoAccount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpInfoAccount.Controls.Add(TbEmployeeName, 1, 1);
            TlpInfoAccount.Controls.Add(LbHeaderInfoAccount, 0, 0);
            TlpInfoAccount.Controls.Add(FlpInfoAccountButton, 1, 3);
            TlpInfoAccount.Controls.Add(LbEmployeeName, 0, 1);
            TlpInfoAccount.Controls.Add(LbAccountName, 2, 1);
            TlpInfoAccount.Controls.Add(LbEmployeePhone, 0, 2);
            TlpInfoAccount.Controls.Add(TbUserName, 3, 1);
            TlpInfoAccount.Controls.Add(TbEmployeePhone, 1, 2);
            TlpInfoAccount.Controls.Add(LbPassword, 2, 2);
            TlpInfoAccount.Controls.Add(TbPassword, 3, 2);
            TlpInfoAccount.Dock = DockStyle.Fill;
            TlpInfoAccount.Location = new Point(0, 0);
            TlpInfoAccount.Name = "TlpInfoAccount";
            TlpInfoAccount.RightToLeft = RightToLeft.No;
            TlpInfoAccount.RowCount = 4;
            TlpInfoAccount.RowStyles.Add(new RowStyle());
            TlpInfoAccount.RowStyles.Add(new RowStyle());
            TlpInfoAccount.RowStyles.Add(new RowStyle());
            TlpInfoAccount.RowStyles.Add(new RowStyle());
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TlpInfoAccount.Size = new Size(1664, 211);
            TlpInfoAccount.TabIndex = 0;
            // 
            // TbEmployeeName
            // 
            TbEmployeeName.Dock = DockStyle.Fill;
            TbEmployeeName.Location = new Point(170, 37);
            TbEmployeeName.Margin = new Padding(5);
            TbEmployeeName.Name = "TbEmployeeName";
            TbEmployeeName.Size = new Size(657, 39);
            TbEmployeeName.TabIndex = 6;
            // 
            // LbHeaderInfoAccount
            // 
            LbHeaderInfoAccount.AutoSize = true;
            TlpInfoAccount.SetColumnSpan(LbHeaderInfoAccount, 4);
            LbHeaderInfoAccount.Dock = DockStyle.Fill;
            LbHeaderInfoAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderInfoAccount.Location = new Point(3, 0);
            LbHeaderInfoAccount.Name = "LbHeaderInfoAccount";
            LbHeaderInfoAccount.Size = new Size(1658, 32);
            LbHeaderInfoAccount.TabIndex = 5;
            LbHeaderInfoAccount.Text = "Thông tin tài khoản";
            LbHeaderInfoAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlpInfoAccountButton
            // 
            TlpInfoAccount.SetColumnSpan(FlpInfoAccountButton, 4);
            FlpInfoAccountButton.Controls.Add(BtnSave);
            FlpInfoAccountButton.Controls.Add(BtnAdd);
            FlpInfoAccountButton.Controls.Add(BtnDelete);
            FlpInfoAccountButton.Controls.Add(BtnFix);
            FlpInfoAccountButton.Controls.Add(BtnView);
            FlpInfoAccountButton.Controls.Add(BtnCancel);
            FlpInfoAccountButton.Dock = DockStyle.Fill;
            FlpInfoAccountButton.FlowDirection = FlowDirection.RightToLeft;
            FlpInfoAccountButton.Location = new Point(3, 133);
            FlpInfoAccountButton.Name = "FlpInfoAccountButton";
            FlpInfoAccountButton.Padding = new Padding(0, 10, 0, 0);
            FlpInfoAccountButton.Size = new Size(1658, 75);
            FlpInfoAccountButton.TabIndex = 10;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(192, 255, 192);
            BtnSave.BackgroundColor = Color.FromArgb(192, 255, 192);
            BtnSave.BoderSize = 0;
            BtnSave.BorderColor = Color.FromArgb(192, 255, 192);
            BtnSave.BorderRadius = 31;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(1524, 13);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(131, 53);
            BtnSave.TabIndex = 16;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(192, 255, 255);
            BtnAdd.BackgroundColor = Color.FromArgb(192, 255, 255);
            BtnAdd.BoderSize = 0;
            BtnAdd.BorderColor = Color.FromArgb(192, 255, 255);
            BtnAdd.BorderRadius = 31;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(1387, 13);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(131, 53);
            BtnAdd.TabIndex = 17;
            BtnAdd.Text = "Thêm";
            BtnAdd.TextColor = Color.Black;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAddClick;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(255, 192, 192);
            BtnDelete.BackgroundColor = Color.FromArgb(255, 192, 192);
            BtnDelete.BoderSize = 0;
            BtnDelete.BorderColor = Color.FromArgb(255, 192, 192);
            BtnDelete.BorderRadius = 31;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(1250, 13);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(131, 53);
            BtnDelete.TabIndex = 18;
            BtnDelete.Text = "Xóa";
            BtnDelete.TextColor = Color.Black;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDeleteClick;
            // 
            // BtnFix
            // 
            BtnFix.BackColor = Color.FromArgb(255, 224, 192);
            BtnFix.BackgroundColor = Color.FromArgb(255, 224, 192);
            BtnFix.BoderSize = 0;
            BtnFix.BorderColor = Color.FromArgb(255, 224, 192);
            BtnFix.BorderRadius = 31;
            BtnFix.FlatAppearance.BorderSize = 0;
            BtnFix.FlatStyle = FlatStyle.Flat;
            BtnFix.ForeColor = Color.Black;
            BtnFix.Location = new Point(1113, 13);
            BtnFix.Name = "BtnFix";
            BtnFix.Size = new Size(131, 53);
            BtnFix.TabIndex = 19;
            BtnFix.Text = "Sửa";
            BtnFix.TextColor = Color.Black;
            BtnFix.UseVisualStyleBackColor = false;
            BtnFix.Click += BtnFixClick;
            // 
            // BtnView
            // 
            BtnView.BackColor = Color.FromArgb(255, 255, 192);
            BtnView.BackgroundColor = Color.FromArgb(255, 255, 192);
            BtnView.BoderSize = 0;
            BtnView.BorderColor = Color.FromArgb(255, 255, 192);
            BtnView.BorderRadius = 31;
            BtnView.FlatAppearance.BorderSize = 0;
            BtnView.FlatStyle = FlatStyle.Flat;
            BtnView.ForeColor = Color.Black;
            BtnView.Location = new Point(976, 13);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(131, 53);
            BtnView.TabIndex = 20;
            BtnView.Text = "Xem";
            BtnView.TextColor = Color.Black;
            BtnView.UseVisualStyleBackColor = false;
            BtnView.Click += BtnViewClick;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCancel.BoderSize = 0;
            BtnCancel.BorderColor = Color.FromArgb(224, 224, 224);
            BtnCancel.BorderRadius = 31;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(839, 13);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(131, 53);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "Hủy";
            BtnCancel.TextColor = Color.Black;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancelClick;
            // 
            // LbEmployeeName
            // 
            LbEmployeeName.AutoSize = true;
            LbEmployeeName.Location = new Point(0, 32);
            LbEmployeeName.Margin = new Padding(0);
            LbEmployeeName.Name = "LbEmployeeName";
            LbEmployeeName.Size = new Size(165, 32);
            LbEmployeeName.TabIndex = 1;
            LbEmployeeName.Text = "Tên nhân viên";
            // 
            // LbAccountName
            // 
            LbAccountName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbAccountName.AutoSize = true;
            LbAccountName.Location = new Point(835, 32);
            LbAccountName.Name = "LbAccountName";
            LbAccountName.Size = new Size(158, 32);
            LbAccountName.TabIndex = 2;
            LbAccountName.Text = "Tên tài khoản";
            // 
            // LbEmployeePhone
            // 
            LbEmployeePhone.AutoSize = true;
            LbEmployeePhone.Location = new Point(3, 81);
            LbEmployeePhone.Name = "LbEmployeePhone";
            LbEmployeePhone.Size = new Size(156, 32);
            LbEmployeePhone.TabIndex = 0;
            LbEmployeePhone.Text = "Số điện thoại";
            // 
            // TbUserName
            // 
            TbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbUserName.Location = new Point(1001, 37);
            TbUserName.Margin = new Padding(5);
            TbUserName.Name = "TbUserName";
            TbUserName.Size = new Size(658, 39);
            TbUserName.TabIndex = 9;
            // 
            // TbEmployeePhone
            // 
            TbEmployeePhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmployeePhone.Location = new Point(170, 86);
            TbEmployeePhone.Margin = new Padding(5);
            TbEmployeePhone.Name = "TbEmployeePhone";
            TbEmployeePhone.Size = new Size(657, 39);
            TbEmployeePhone.TabIndex = 7;
            // 
            // LbPassword
            // 
            LbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbPassword.AutoSize = true;
            LbPassword.Location = new Point(878, 81);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(115, 32);
            LbPassword.TabIndex = 3;
            LbPassword.Text = "Mật khẩu";
            // 
            // TbPassword
            // 
            TbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbPassword.Location = new Point(1001, 86);
            TbPassword.Margin = new Padding(5);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(658, 39);
            TbPassword.TabIndex = 8;
            // 
            // PanelAccountList
            // 
            PanelAccountList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelAccountList.BackColor = Color.FromArgb(248, 255, 245);
            PanelAccountList.BorderStyle = BorderStyle.FixedSingle;
            PanelAccountList.Controls.Add(DgvAccountList);
            PanelAccountList.Controls.Add(LbHeaaderAccountList);
            PanelAccountList.Location = new Point(79, 360);
            PanelAccountList.Name = "PanelAccountList";
            PanelAccountList.Size = new Size(1666, 375);
            PanelAccountList.TabIndex = 2;
            // 
            // DgvAccountList
            // 
            DgvAccountList.AllowUserToResizeRows = false;
            DgvAccountList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvAccountList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvAccountList.BackgroundColor = SystemColors.Window;
            DgvAccountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAccountList.Location = new Point(55, 43);
            DgvAccountList.Name = "DgvAccountList";
            DgvAccountList.RowHeadersVisible = false;
            DgvAccountList.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 255, 245);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DgvAccountList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvAccountList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAccountList.Size = new Size(1582, 301);
            DgvAccountList.TabIndex = 7;
            // 
            // LbHeaaderAccountList
            // 
            LbHeaaderAccountList.Anchor = AnchorStyles.Top;
            LbHeaaderAccountList.AutoSize = true;
            LbHeaaderAccountList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaaderAccountList.Location = new Point(727, 0);
            LbHeaaderAccountList.Name = "LbHeaaderAccountList";
            LbHeaaderAccountList.Size = new Size(244, 32);
            LbHeaaderAccountList.TabIndex = 6;
            LbHeaaderAccountList.Text = "Danh sách tài khoản";
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 255, 210);
            ClientSize = new Size(1874, 764);
            Controls.Add(PanelAccountList);
            Controls.Add(PanelInfoAccount);
            Controls.Add(PanelHeaderCreateEmployee);
            Name = "AccountManagement";
            Text = "AccountManage";
            Load += AccountManagementLoad;
            PanelHeaderCreateEmployee.ResumeLayout(false);
            PanelHeaderCreateEmployee.PerformLayout();
            PanelInfoAccount.ResumeLayout(false);
            PanelInfoAccount.PerformLayout();
            TlpInfoAccount.ResumeLayout(false);
            TlpInfoAccount.PerformLayout();
            FlpInfoAccountButton.ResumeLayout(false);
            PanelAccountList.ResumeLayout(false);
            PanelAccountList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvAccountList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeaderCreateEmployee;
        private Label LbHeader;
        private Panel PanelInfoAccount;
        private Label LbPassword;
        private Label LbAccountName;
        private Label LbEmployeeName;
        private Label LbEmployeePhone;
        private Panel PanelAccountList;
        private Label LbHeaderInfoAccount;
        private Label LbHeaaderAccountList;
        private DataGridView DgvAccountList;
        private TextBox TbUserName;
        private TextBox TbPassword;
        private TextBox TbEmployeePhone;
        private TextBox TbEmployeeName;
        private TableLayoutPanel TlpInfoAccount;
        private FlowLayoutPanel FlpInfoAccountButton;
        private EcosystemApp.GUI.Components.RJButton BtnSave;
        private EcosystemApp.GUI.Components.RJButton BtnAdd;
        private EcosystemApp.GUI.Components.RJButton BtnDelete;
        private EcosystemApp.GUI.Components.RJButton BtnFix;
        private EcosystemApp.GUI.Components.RJButton BtnView;
        private EcosystemApp.GUI.Components.RJButton BtnCancel;
    }
}