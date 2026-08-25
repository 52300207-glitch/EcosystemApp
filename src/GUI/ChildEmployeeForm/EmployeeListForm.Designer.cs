namespace EcosystemApp.GUI.ChildEmployeeForm
{
    partial class EmployeeListForm
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
            RjButton4 = new EcosystemApp.GUI.Components.RJButton();
            TbSearchEmployee = new TextBox();
            Panel1 = new Panel();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            Panel4 = new Panel();
            DgvEmployeeList = new DataGridView();
            PanelEmployee1 = new Panel();
            BtnDeleteEmployeeList = new EcosystemApp.GUI.Components.RJButton();
            BtnAddEmployeeList = new EcosystemApp.GUI.Components.RJButton();
            BtnUpdateEmployeeList = new EcosystemApp.GUI.Components.RJButton();
            RjButton7 = new EcosystemApp.GUI.Components.RJButton();
            Panel6 = new Panel();
            TbEmployeePhone = new TextBox();
            TbEmployeeEmail = new TextBox();
            TbEmployeeStation = new TextBox();
            Label2 = new Label();
            Label5 = new Label();
            Label8 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Label13 = new Label();
            TbEmployeePosition = new TextBox();
            TbBirthDate = new TextBox();
            TbEmpFullName = new TextBox();
            Panel2 = new Panel();
            BtnCancelEmployeeInformations = new EcosystemApp.GUI.Components.RJButton();
            BtnSaveEmployeeInformations = new EcosystemApp.GUI.Components.RJButton();
            Panel5 = new Panel();
            BtnApplyEmployeeListFilters = new EcosystemApp.GUI.Components.RJButton();
            LbFilter = new Label();
            BtnSearchEmployeeList = new EcosystemApp.GUI.Components.RJButton();
            CbSortBy = new ComboBox();
            Panel3 = new Panel();
            TabPage2 = new TabPage();
            Panel12 = new Panel();
            CbEmployeeID = new ComboBox();
            BtnCancel = new EcosystemApp.GUI.Components.RJButton();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            DateTimePicker1 = new DateTimePicker();
            Label10 = new Label();
            Label9 = new Label();
            TbNote = new TextBox();
            TbStatus = new TextBox();
            CbShift = new ComboBox();
            Label7 = new Label();
            Label6 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            TbNameEmployeeShift = new TextBox();
            Panel10 = new Panel();
            Panel14 = new Panel();
            BtnDeleteShift = new EcosystemApp.GUI.Components.RJButton();
            BtnUpdateShift = new EcosystemApp.GUI.Components.RJButton();
            BtnAddShift = new EcosystemApp.GUI.Components.RJButton();
            DgvShiftList = new DataGridView();
            airRadioButton1 = new ReaLTaiizor.Controls.AirRadioButton();
            Panel9 = new Panel();
            Label1 = new Label();
            CbShiftListFilters = new ComboBox();
            BtnApplySortShift = new EcosystemApp.GUI.Components.RJButton();
            TbSearchShift = new TextBox();
            BtnSearchShiftList = new EcosystemApp.GUI.Components.RJButton();
            Panel8 = new Panel();
            RjButton1 = new EcosystemApp.GUI.Components.RJButton();
            Panel1.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEmployeeList).BeginInit();
            PanelEmployee1.SuspendLayout();
            Panel6.SuspendLayout();
            Panel2.SuspendLayout();
            Panel5.SuspendLayout();
            Panel3.SuspendLayout();
            TabPage2.SuspendLayout();
            Panel12.SuspendLayout();
            Panel10.SuspendLayout();
            Panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvShiftList).BeginInit();
            Panel9.SuspendLayout();
            Panel8.SuspendLayout();
            SuspendLayout();
            // 
            // RjButton4
            // 
            RjButton4.BackColor = Color.FromArgb(196, 238, 181);
            RjButton4.BackgroundColor = Color.FromArgb(196, 238, 181);
            RjButton4.BoderSize = 0;
            RjButton4.BorderColor = Color.PaleVioletRed;
            RjButton4.BorderRadius = 0;
            RjButton4.Dock = DockStyle.Top;
            RjButton4.FlatAppearance.BorderSize = 0;
            RjButton4.FlatStyle = FlatStyle.Flat;
            RjButton4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RjButton4.ForeColor = Color.Black;
            RjButton4.Location = new Point(0, 0);
            RjButton4.Margin = new Padding(5);
            RjButton4.Name = "RjButton4";
            RjButton4.Size = new Size(1896, 86);
            RjButton4.TabIndex = 0;
            RjButton4.Text = "Danh sách nhân viên";
            RjButton4.TextColor = Color.Black;
            RjButton4.UseVisualStyleBackColor = false;
            // 
            // TbSearchEmployee
            // 
            TbSearchEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbSearchEmployee.BorderStyle = BorderStyle.FixedSingle;
            TbSearchEmployee.Location = new Point(1088, 6);
            TbSearchEmployee.Multiline = true;
            TbSearchEmployee.Name = "TbSearchEmployee";
            TbSearchEmployee.Size = new Size(602, 56);
            TbSearchEmployee.TabIndex = 6;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(TabControl1);
            Panel1.Dock = DockStyle.Fill;
            Panel1.ForeColor = SystemColors.ControlText;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1924, 1245);
            Panel1.TabIndex = 4;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Location = new Point(0, 0);
            TabControl1.Margin = new Padding(5);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1924, 1245);
            TabControl1.TabIndex = 11;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.FromArgb(248, 255, 245);
            TabPage1.Controls.Add(Panel4);
            TabPage1.Controls.Add(PanelEmployee1);
            TabPage1.Controls.Add(RjButton7);
            TabPage1.Controls.Add(Panel6);
            TabPage1.Controls.Add(Panel2);
            TabPage1.Controls.Add(Panel5);
            TabPage1.Controls.Add(Panel3);
            TabPage1.Location = new Point(8, 46);
            TabPage1.Margin = new Padding(5);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(5);
            TabPage1.Size = new Size(1908, 1191);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Nhân viên";
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.FromArgb(228, 255, 207);
            Panel4.BorderStyle = BorderStyle.FixedSingle;
            Panel4.Controls.Add(DgvEmployeeList);
            Panel4.Dock = DockStyle.Fill;
            Panel4.ImeMode = ImeMode.Off;
            Panel4.Location = new Point(5, 164);
            Panel4.Margin = new Padding(5);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1898, 256);
            Panel4.TabIndex = 6;
            // 
            // DgvEmployeeList
            // 
            DgvEmployeeList.BackgroundColor = Color.White;
            DgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEmployeeList.Dock = DockStyle.Fill;
            DgvEmployeeList.Location = new Point(0, 0);
            DgvEmployeeList.Margin = new Padding(5);
            DgvEmployeeList.Name = "DgvEmployeeList";
            DgvEmployeeList.RowHeadersWidth = 51;
            DgvEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEmployeeList.Size = new Size(1896, 254);
            DgvEmployeeList.TabIndex = 2;
            // 
            // PanelEmployee1
            // 
            PanelEmployee1.BackColor = Color.FromArgb(228, 255, 207);
            PanelEmployee1.Controls.Add(BtnDeleteEmployeeList);
            PanelEmployee1.Controls.Add(BtnAddEmployeeList);
            PanelEmployee1.Controls.Add(BtnUpdateEmployeeList);
            PanelEmployee1.Dock = DockStyle.Bottom;
            PanelEmployee1.Location = new Point(5, 420);
            PanelEmployee1.Margin = new Padding(5);
            PanelEmployee1.Name = "PanelEmployee1";
            PanelEmployee1.Size = new Size(1898, 82);
            PanelEmployee1.TabIndex = 3;
            PanelEmployee1.Tag = "";
            // 
            // BtnDeleteEmployeeList
            // 
            BtnDeleteEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteEmployeeList.BackColor = Color.Salmon;
            BtnDeleteEmployeeList.BackgroundColor = Color.Salmon;
            BtnDeleteEmployeeList.BoderSize = 1;
            BtnDeleteEmployeeList.BorderColor = Color.Black;
            BtnDeleteEmployeeList.BorderRadius = 35;
            BtnDeleteEmployeeList.FlatAppearance.BorderSize = 0;
            BtnDeleteEmployeeList.FlatStyle = FlatStyle.Flat;
            BtnDeleteEmployeeList.ForeColor = Color.Black;
            BtnDeleteEmployeeList.Location = new Point(1317, 8);
            BtnDeleteEmployeeList.Name = "BtnDeleteEmployeeList";
            BtnDeleteEmployeeList.Size = new Size(185, 56);
            BtnDeleteEmployeeList.TabIndex = 16;
            BtnDeleteEmployeeList.Text = "Xóa";
            BtnDeleteEmployeeList.TextColor = Color.Black;
            BtnDeleteEmployeeList.UseVisualStyleBackColor = false;
            BtnDeleteEmployeeList.Click += BtnDeleteEmployeeListClick;
            // 
            // BtnAddEmployeeList
            // 
            BtnAddEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddEmployeeList.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddEmployeeList.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddEmployeeList.BoderSize = 1;
            BtnAddEmployeeList.BorderColor = Color.Black;
            BtnAddEmployeeList.BorderRadius = 35;
            BtnAddEmployeeList.FlatAppearance.BorderSize = 0;
            BtnAddEmployeeList.FlatStyle = FlatStyle.Flat;
            BtnAddEmployeeList.ForeColor = Color.Black;
            BtnAddEmployeeList.Location = new Point(1698, 8);
            BtnAddEmployeeList.Name = "BtnAddEmployeeList";
            BtnAddEmployeeList.Size = new Size(185, 56);
            BtnAddEmployeeList.TabIndex = 14;
            BtnAddEmployeeList.Text = "Thêm";
            BtnAddEmployeeList.TextColor = Color.Black;
            BtnAddEmployeeList.UseVisualStyleBackColor = false;
            BtnAddEmployeeList.Click += BtnAddEmployeeListClick;
            // 
            // BtnUpdateEmployeeList
            // 
            BtnUpdateEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUpdateEmployeeList.BackColor = Color.NavajoWhite;
            BtnUpdateEmployeeList.BackgroundColor = Color.NavajoWhite;
            BtnUpdateEmployeeList.BoderSize = 1;
            BtnUpdateEmployeeList.BorderColor = Color.Black;
            BtnUpdateEmployeeList.BorderRadius = 35;
            BtnUpdateEmployeeList.FlatAppearance.BorderSize = 0;
            BtnUpdateEmployeeList.FlatStyle = FlatStyle.Flat;
            BtnUpdateEmployeeList.ForeColor = Color.Black;
            BtnUpdateEmployeeList.Location = new Point(1507, 8);
            BtnUpdateEmployeeList.Name = "BtnUpdateEmployeeList";
            BtnUpdateEmployeeList.Size = new Size(185, 56);
            BtnUpdateEmployeeList.TabIndex = 15;
            BtnUpdateEmployeeList.Text = "Sửa";
            BtnUpdateEmployeeList.TextColor = Color.Black;
            BtnUpdateEmployeeList.UseVisualStyleBackColor = false;
            BtnUpdateEmployeeList.Click += BtnUpdateEmployeeListClick;
            // 
            // RjButton7
            // 
            RjButton7.BackColor = Color.FromArgb(196, 238, 181);
            RjButton7.BackgroundColor = Color.FromArgb(196, 238, 181);
            RjButton7.BoderSize = 0;
            RjButton7.BorderColor = Color.PaleVioletRed;
            RjButton7.BorderRadius = 0;
            RjButton7.Dock = DockStyle.Bottom;
            RjButton7.FlatAppearance.BorderSize = 0;
            RjButton7.FlatStyle = FlatStyle.Flat;
            RjButton7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RjButton7.ForeColor = Color.Black;
            RjButton7.Location = new Point(5, 502);
            RjButton7.Margin = new Padding(5);
            RjButton7.Name = "RjButton7";
            RjButton7.Size = new Size(1898, 85);
            RjButton7.TabIndex = 1;
            RjButton7.Text = "Thông tin nhân viên";
            RjButton7.TextColor = Color.Black;
            RjButton7.UseVisualStyleBackColor = false;
            // 
            // Panel6
            // 
            Panel6.BackColor = Color.FromArgb(228, 255, 207);
            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(TbEmployeePhone);
            Panel6.Controls.Add(TbEmployeeEmail);
            Panel6.Controls.Add(TbEmployeeStation);
            Panel6.Controls.Add(Label2);
            Panel6.Controls.Add(Label5);
            Panel6.Controls.Add(Label8);
            Panel6.Controls.Add(Label11);
            Panel6.Controls.Add(Label12);
            Panel6.Controls.Add(Label13);
            Panel6.Controls.Add(TbEmployeePosition);
            Panel6.Controls.Add(TbBirthDate);
            Panel6.Controls.Add(TbEmpFullName);
            Panel6.Dock = DockStyle.Bottom;
            Panel6.Location = new Point(5, 587);
            Panel6.Margin = new Padding(5);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(1898, 511);
            Panel6.TabIndex = 8;
            // 
            // TbEmployeePhone
            // 
            TbEmployeePhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmployeePhone.BorderStyle = BorderStyle.FixedSingle;
            TbEmployeePhone.Location = new Point(1531, 24);
            TbEmployeePhone.Multiline = true;
            TbEmployeePhone.Name = "TbEmployeePhone";
            TbEmployeePhone.Size = new Size(237, 66);
            TbEmployeePhone.TabIndex = 55;
            // 
            // TbEmployeeEmail
            // 
            TbEmployeeEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmployeeEmail.BorderStyle = BorderStyle.FixedSingle;
            TbEmployeeEmail.Location = new Point(1531, 122);
            TbEmployeeEmail.Multiline = true;
            TbEmployeeEmail.Name = "TbEmployeeEmail";
            TbEmployeeEmail.Size = new Size(237, 66);
            TbEmployeeEmail.TabIndex = 54;
            // 
            // TbEmployeeStation
            // 
            TbEmployeeStation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmployeeStation.BorderStyle = BorderStyle.FixedSingle;
            TbEmployeeStation.Location = new Point(1531, 222);
            TbEmployeeStation.Multiline = true;
            TbEmployeeStation.Name = "TbEmployeeStation";
            TbEmployeeStation.Size = new Size(237, 66);
            TbEmployeeStation.TabIndex = 53;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(1284, 237);
            Label2.Name = "Label2";
            Label2.Size = new Size(82, 37);
            Label2.TabIndex = 52;
            Label2.Text = "Trạm";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(1284, 38);
            Label5.Name = "Label5";
            Label5.Size = new Size(186, 37);
            Label5.TabIndex = 51;
            Label5.Text = "Số điện thoại";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(1284, 136);
            Label8.Name = "Label8";
            Label8.Size = new Size(87, 37);
            Label8.TabIndex = 50;
            Label8.Text = "Email";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label11.Location = new Point(41, 237);
            Label11.Name = "Label11";
            Label11.Size = new Size(80, 37);
            Label11.TabIndex = 49;
            Label11.Text = "Vị trí";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label12.Location = new Point(41, 136);
            Label12.Name = "Label12";
            Label12.Size = new Size(144, 37);
            Label12.TabIndex = 48;
            Label12.Text = "Ngày sinh";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label13.Location = new Point(41, 38);
            Label13.Name = "Label13";
            Label13.Size = new Size(104, 37);
            Label13.TabIndex = 47;
            Label13.Text = "Họ tên";
            // 
            // TbEmployeePosition
            // 
            TbEmployeePosition.BorderStyle = BorderStyle.FixedSingle;
            TbEmployeePosition.Location = new Point(192, 222);
            TbEmployeePosition.Multiline = true;
            TbEmployeePosition.Name = "TbEmployeePosition";
            TbEmployeePosition.Size = new Size(684, 66);
            TbEmployeePosition.TabIndex = 46;
            // 
            // TbBirthDate
            // 
            TbBirthDate.BorderStyle = BorderStyle.FixedSingle;
            TbBirthDate.Location = new Point(192, 122);
            TbBirthDate.Multiline = true;
            TbBirthDate.Name = "TbBirthDate";
            TbBirthDate.Size = new Size(684, 66);
            TbBirthDate.TabIndex = 45;
            // 
            // TbEmpFullName
            // 
            TbEmpFullName.BorderStyle = BorderStyle.FixedSingle;
            TbEmpFullName.Location = new Point(192, 24);
            TbEmpFullName.Multiline = true;
            TbEmpFullName.Name = "TbEmpFullName";
            TbEmpFullName.Size = new Size(684, 66);
            TbEmpFullName.TabIndex = 44;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(228, 255, 207);
            Panel2.Controls.Add(BtnCancelEmployeeInformations);
            Panel2.Controls.Add(BtnSaveEmployeeInformations);
            Panel2.Dock = DockStyle.Bottom;
            Panel2.Location = new Point(5, 1098);
            Panel2.Margin = new Padding(5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1898, 88);
            Panel2.TabIndex = 56;
            // 
            // BtnCancelEmployeeInformations
            // 
            BtnCancelEmployeeInformations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancelEmployeeInformations.BackColor = Color.LightGray;
            BtnCancelEmployeeInformations.BackgroundColor = Color.LightGray;
            BtnCancelEmployeeInformations.BoderSize = 1;
            BtnCancelEmployeeInformations.BorderColor = Color.Black;
            BtnCancelEmployeeInformations.BorderRadius = 35;
            BtnCancelEmployeeInformations.FlatAppearance.BorderSize = 0;
            BtnCancelEmployeeInformations.FlatStyle = FlatStyle.Flat;
            BtnCancelEmployeeInformations.ForeColor = Color.Black;
            BtnCancelEmployeeInformations.Location = new Point(1505, 19);
            BtnCancelEmployeeInformations.Name = "BtnCancelEmployeeInformations";
            BtnCancelEmployeeInformations.Size = new Size(185, 56);
            BtnCancelEmployeeInformations.TabIndex = 16;
            BtnCancelEmployeeInformations.Text = "Hủy";
            BtnCancelEmployeeInformations.TextColor = Color.Black;
            BtnCancelEmployeeInformations.UseVisualStyleBackColor = false;
            BtnCancelEmployeeInformations.Click += BtnCancelEmployeeInformationsClick;
            // 
            // BtnSaveEmployeeInformations
            // 
            BtnSaveEmployeeInformations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSaveEmployeeInformations.BackColor = Color.Aquamarine;
            BtnSaveEmployeeInformations.BackgroundColor = Color.Aquamarine;
            BtnSaveEmployeeInformations.BoderSize = 1;
            BtnSaveEmployeeInformations.BorderColor = Color.Black;
            BtnSaveEmployeeInformations.BorderRadius = 35;
            BtnSaveEmployeeInformations.FlatAppearance.BorderSize = 0;
            BtnSaveEmployeeInformations.FlatStyle = FlatStyle.Flat;
            BtnSaveEmployeeInformations.ForeColor = Color.Black;
            BtnSaveEmployeeInformations.Location = new Point(1697, 19);
            BtnSaveEmployeeInformations.Name = "BtnSaveEmployeeInformations";
            BtnSaveEmployeeInformations.Size = new Size(185, 56);
            BtnSaveEmployeeInformations.TabIndex = 17;
            BtnSaveEmployeeInformations.Text = "Lưu";
            BtnSaveEmployeeInformations.TextColor = Color.Black;
            BtnSaveEmployeeInformations.UseVisualStyleBackColor = false;
            BtnSaveEmployeeInformations.Click += BtnSaveEmployeeInformationsClick;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(228, 255, 207);
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(TbSearchEmployee);
            Panel5.Controls.Add(BtnApplyEmployeeListFilters);
            Panel5.Controls.Add(LbFilter);
            Panel5.Controls.Add(BtnSearchEmployeeList);
            Panel5.Controls.Add(CbSortBy);
            Panel5.Dock = DockStyle.Top;
            Panel5.Location = new Point(5, 87);
            Panel5.Margin = new Padding(5);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(1898, 77);
            Panel5.TabIndex = 7;
            // 
            // BtnApplyEmployeeListFilters
            // 
            BtnApplyEmployeeListFilters.BackColor = Color.Aquamarine;
            BtnApplyEmployeeListFilters.BackgroundColor = Color.Aquamarine;
            BtnApplyEmployeeListFilters.BoderSize = 1;
            BtnApplyEmployeeListFilters.BorderColor = Color.Black;
            BtnApplyEmployeeListFilters.BorderRadius = 28;
            BtnApplyEmployeeListFilters.FlatAppearance.BorderSize = 0;
            BtnApplyEmployeeListFilters.FlatStyle = FlatStyle.Flat;
            BtnApplyEmployeeListFilters.ForeColor = Color.Black;
            BtnApplyEmployeeListFilters.Location = new Point(535, 11);
            BtnApplyEmployeeListFilters.Name = "BtnApplyEmployeeListFilters";
            BtnApplyEmployeeListFilters.Size = new Size(128, 45);
            BtnApplyEmployeeListFilters.TabIndex = 12;
            BtnApplyEmployeeListFilters.Text = "Áp dụng";
            BtnApplyEmployeeListFilters.TextColor = Color.Black;
            BtnApplyEmployeeListFilters.UseVisualStyleBackColor = false;
            BtnApplyEmployeeListFilters.Click += BtnApplyEmployeeListFiltersClick;
            // 
            // LbFilter
            // 
            LbFilter.AutoSize = true;
            LbFilter.Location = new Point(75, 18);
            LbFilter.Name = "LbFilter";
            LbFilter.Size = new Size(85, 32);
            LbFilter.TabIndex = 7;
            LbFilter.Text = "Bộ lọc:";
            // 
            // BtnSearchEmployeeList
            // 
            BtnSearchEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchEmployeeList.BackColor = Color.FromArgb(196, 238, 181);
            BtnSearchEmployeeList.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSearchEmployeeList.BoderSize = 1;
            BtnSearchEmployeeList.BorderColor = Color.Black;
            BtnSearchEmployeeList.BorderRadius = 35;
            BtnSearchEmployeeList.FlatAppearance.BorderSize = 0;
            BtnSearchEmployeeList.FlatStyle = FlatStyle.Flat;
            BtnSearchEmployeeList.ForeColor = Color.Black;
            BtnSearchEmployeeList.Location = new Point(1696, 6);
            BtnSearchEmployeeList.Name = "BtnSearchEmployeeList";
            BtnSearchEmployeeList.Size = new Size(185, 56);
            BtnSearchEmployeeList.TabIndex = 13;
            BtnSearchEmployeeList.Text = "Tìm kiếm";
            BtnSearchEmployeeList.TextColor = Color.Black;
            BtnSearchEmployeeList.UseVisualStyleBackColor = false;
            BtnSearchEmployeeList.Click += BtnSearchEmployeeListClick;
            // 
            // CbSortBy
            // 
            CbSortBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSortBy.FormattingEnabled = true;
            CbSortBy.Location = new Point(192, 11);
            CbSortBy.Margin = new Padding(5);
            CbSortBy.Name = "CbSortBy";
            CbSortBy.Size = new Size(324, 40);
            CbSortBy.TabIndex = 10;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(228, 255, 207);
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(RjButton4);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(5, 5);
            Panel3.Margin = new Padding(5);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1898, 82);
            Panel3.TabIndex = 5;
            // 
            // TabPage2
            // 
            TabPage2.BackColor = Color.FromArgb(248, 255, 245);
            TabPage2.Controls.Add(Panel12);
            TabPage2.Controls.Add(Panel10);
            TabPage2.Controls.Add(Panel9);
            TabPage2.Controls.Add(Panel8);
            TabPage2.Location = new Point(8, 46);
            TabPage2.Margin = new Padding(5);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(5);
            TabPage2.Size = new Size(1908, 1191);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Phân công";
            // 
            // Panel12
            // 
            Panel12.BackColor = Color.FromArgb(228, 255, 207);
            Panel12.BorderStyle = BorderStyle.FixedSingle;
            Panel12.Controls.Add(CbEmployeeID);
            Panel12.Controls.Add(BtnCancel);
            Panel12.Controls.Add(BtnSave);
            Panel12.Controls.Add(DateTimePicker1);
            Panel12.Controls.Add(Label10);
            Panel12.Controls.Add(Label9);
            Panel12.Controls.Add(TbNote);
            Panel12.Controls.Add(TbStatus);
            Panel12.Controls.Add(CbShift);
            Panel12.Controls.Add(Label7);
            Panel12.Controls.Add(Label6);
            Panel12.Controls.Add(Label4);
            Panel12.Controls.Add(Label3);
            Panel12.Controls.Add(TbNameEmployeeShift);
            Panel12.Dock = DockStyle.Fill;
            Panel12.Location = new Point(5, 734);
            Panel12.Margin = new Padding(5);
            Panel12.Name = "Panel12";
            Panel12.Size = new Size(1898, 452);
            Panel12.TabIndex = 4;
            // 
            // CbEmployeeID
            // 
            CbEmployeeID.FormattingEnabled = true;
            CbEmployeeID.Location = new Point(278, 53);
            CbEmployeeID.Margin = new Padding(5);
            CbEmployeeID.Name = "CbEmployeeID";
            CbEmployeeID.Size = new Size(683, 40);
            CbEmployeeID.TabIndex = 62;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.BackColor = Color.DarkGray;
            BtnCancel.BackgroundColor = Color.DarkGray;
            BtnCancel.BoderSize = 1;
            BtnCancel.BorderColor = Color.Black;
            BtnCancel.BorderRadius = 35;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(1498, 392);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(185, 56);
            BtnCancel.TabIndex = 61;
            BtnCancel.Text = "Hủy";
            BtnCancel.TextColor = Color.Black;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancelClick;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.BackColor = Color.FromArgb(196, 238, 181);
            BtnSave.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSave.BoderSize = 1;
            BtnSave.BorderColor = Color.Black;
            BtnSave.BorderRadius = 35;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(1688, 392);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(185, 56);
            BtnSave.TabIndex = 19;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Location = new Point(1547, 54);
            DateTimePicker1.Margin = new Padding(5);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(683, 39);
            DateTimePicker1.TabIndex = 60;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.Location = new Point(1375, 274);
            Label10.Name = "Label10";
            Label10.Size = new Size(112, 37);
            Label10.TabIndex = 59;
            Label10.Text = "Ghi chú";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.Location = new Point(52, 274);
            Label9.Name = "Label9";
            Label9.Size = new Size(147, 37);
            Label9.TabIndex = 58;
            Label9.Text = "Trạng thái";
            // 
            // TbNote
            // 
            TbNote.BorderStyle = BorderStyle.FixedSingle;
            TbNote.Location = new Point(1547, 243);
            TbNote.Multiline = true;
            TbNote.Name = "TbNote";
            TbNote.Size = new Size(684, 66);
            TbNote.TabIndex = 57;
            // 
            // TbStatus
            // 
            TbStatus.BorderStyle = BorderStyle.FixedSingle;
            TbStatus.Location = new Point(278, 243);
            TbStatus.Multiline = true;
            TbStatus.Name = "TbStatus";
            TbStatus.Size = new Size(684, 66);
            TbStatus.TabIndex = 56;
            // 
            // CbShift
            // 
            CbShift.IntegralHeight = false;
            CbShift.ItemHeight = 32;
            CbShift.Location = new Point(1547, 168);
            CbShift.Margin = new Padding(5);
            CbShift.MaxDropDownItems = 10;
            CbShift.Name = "CbShift";
            CbShift.Size = new Size(683, 40);
            CbShift.TabIndex = 55;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(1375, 61);
            Label7.Name = "Label7";
            Label7.Size = new Size(146, 37);
            Label7.TabIndex = 54;
            Label7.Text = "Ngày Làm";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(1375, 176);
            Label6.Name = "Label6";
            Label6.Size = new Size(104, 37);
            Label6.TabIndex = 53;
            Label6.Text = "Ca làm";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(52, 61);
            Label4.Name = "Label4";
            Label4.Size = new Size(189, 37);
            Label4.TabIndex = 52;
            Label4.Text = "Mã nhân viên";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(52, 176);
            Label3.Name = "Label3";
            Label3.Size = new Size(193, 37);
            Label3.TabIndex = 48;
            Label3.Text = "Tên nhân viên";
            // 
            // TbNameEmployeeShift
            // 
            TbNameEmployeeShift.BorderStyle = BorderStyle.FixedSingle;
            TbNameEmployeeShift.Location = new Point(278, 146);
            TbNameEmployeeShift.Multiline = true;
            TbNameEmployeeShift.Name = "TbNameEmployeeShift";
            TbNameEmployeeShift.Size = new Size(684, 66);
            TbNameEmployeeShift.TabIndex = 45;
            // 
            // Panel10
            // 
            Panel10.BackColor = Color.FromArgb(228, 255, 207);
            Panel10.BorderStyle = BorderStyle.FixedSingle;
            Panel10.Controls.Add(Panel14);
            Panel10.Controls.Add(DgvShiftList);
            Panel10.Controls.Add(airRadioButton1);
            Panel10.Dock = DockStyle.Top;
            Panel10.Location = new Point(5, 177);
            Panel10.Margin = new Padding(5);
            Panel10.Name = "Panel10";
            Panel10.Size = new Size(1898, 557);
            Panel10.TabIndex = 2;
            // 
            // Panel14
            // 
            Panel14.BackColor = Color.FromArgb(228, 255, 207);
            Panel14.Controls.Add(BtnDeleteShift);
            Panel14.Controls.Add(BtnUpdateShift);
            Panel14.Controls.Add(BtnAddShift);
            Panel14.Dock = DockStyle.Bottom;
            Panel14.Location = new Point(0, 473);
            Panel14.Margin = new Padding(5);
            Panel14.Name = "Panel14";
            Panel14.Size = new Size(1896, 82);
            Panel14.TabIndex = 7;
            // 
            // BtnDeleteShift
            // 
            BtnDeleteShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteShift.BackColor = Color.Salmon;
            BtnDeleteShift.BackgroundColor = Color.Salmon;
            BtnDeleteShift.BoderSize = 1;
            BtnDeleteShift.BorderColor = Color.Black;
            BtnDeleteShift.BorderRadius = 35;
            BtnDeleteShift.FlatAppearance.BorderSize = 0;
            BtnDeleteShift.FlatStyle = FlatStyle.Flat;
            BtnDeleteShift.ForeColor = Color.Black;
            BtnDeleteShift.Location = new Point(1306, 3);
            BtnDeleteShift.Name = "BtnDeleteShift";
            BtnDeleteShift.Size = new Size(185, 56);
            BtnDeleteShift.TabIndex = 17;
            BtnDeleteShift.Text = "Xóa";
            BtnDeleteShift.TextColor = Color.Black;
            BtnDeleteShift.UseVisualStyleBackColor = false;
            BtnDeleteShift.Click += BtnDeleteShiftClick;
            // 
            // BtnUpdateShift
            // 
            BtnUpdateShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUpdateShift.BackColor = Color.NavajoWhite;
            BtnUpdateShift.BackgroundColor = Color.NavajoWhite;
            BtnUpdateShift.BoderSize = 1;
            BtnUpdateShift.BorderColor = Color.Black;
            BtnUpdateShift.BorderRadius = 35;
            BtnUpdateShift.FlatAppearance.BorderSize = 0;
            BtnUpdateShift.FlatStyle = FlatStyle.Flat;
            BtnUpdateShift.ForeColor = Color.Black;
            BtnUpdateShift.Location = new Point(1498, 3);
            BtnUpdateShift.Name = "BtnUpdateShift";
            BtnUpdateShift.Size = new Size(185, 56);
            BtnUpdateShift.TabIndex = 16;
            BtnUpdateShift.Text = "Sửa";
            BtnUpdateShift.TextColor = Color.Black;
            BtnUpdateShift.UseVisualStyleBackColor = false;
            BtnUpdateShift.Click += BtnUpdateShiftClick;
            // 
            // BtnAddShift
            // 
            BtnAddShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddShift.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddShift.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddShift.BoderSize = 1;
            BtnAddShift.BorderColor = Color.Black;
            BtnAddShift.BorderRadius = 35;
            BtnAddShift.FlatAppearance.BorderSize = 0;
            BtnAddShift.FlatStyle = FlatStyle.Flat;
            BtnAddShift.ForeColor = Color.Black;
            BtnAddShift.Location = new Point(1688, 3);
            BtnAddShift.Name = "BtnAddShift";
            BtnAddShift.Size = new Size(185, 56);
            BtnAddShift.TabIndex = 15;
            BtnAddShift.Text = "Thêm";
            BtnAddShift.TextColor = Color.Black;
            BtnAddShift.UseVisualStyleBackColor = false;
            BtnAddShift.Click += BtnAddShiftClick;
            // 
            // DgvShiftList
            // 
            DgvShiftList.BackgroundColor = Color.White;
            DgvShiftList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvShiftList.Dock = DockStyle.Top;
            DgvShiftList.Location = new Point(0, 0);
            DgvShiftList.Margin = new Padding(5);
            DgvShiftList.Name = "DgvShiftList";
            DgvShiftList.RowHeadersWidth = 51;
            DgvShiftList.Size = new Size(1896, 469);
            DgvShiftList.TabIndex = 1;
            // 
            // airRadioButton1
            // 
            airRadioButton1.Checked = false;
            airRadioButton1.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            airRadioButton1.Field = 16;
            airRadioButton1.Font = new Font("Segoe UI", 9F);
            airRadioButton1.Image = null;
            airRadioButton1.Location = new Point(0, 0);
            airRadioButton1.Margin = new Padding(5);
            airRadioButton1.Name = "airRadioButton1";
            airRadioButton1.NoRounding = false;
            airRadioButton1.Size = new Size(224, 16);
            airRadioButton1.TabIndex = 0;
            airRadioButton1.Text = "airRadioButton1";
            airRadioButton1.Transparent = false;
            // 
            // Panel9
            // 
            Panel9.BackColor = Color.FromArgb(228, 255, 207);
            Panel9.BorderStyle = BorderStyle.FixedSingle;
            Panel9.Controls.Add(Label1);
            Panel9.Controls.Add(CbShiftListFilters);
            Panel9.Controls.Add(BtnApplySortShift);
            Panel9.Controls.Add(TbSearchShift);
            Panel9.Controls.Add(BtnSearchShiftList);
            Panel9.Dock = DockStyle.Top;
            Panel9.Location = new Point(5, 90);
            Panel9.Margin = new Padding(5);
            Panel9.Name = "Panel9";
            Panel9.Size = new Size(1898, 87);
            Panel9.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(52, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(85, 32);
            Label1.TabIndex = 18;
            Label1.Text = "Bộ lọc:";
            // 
            // CbShiftListFilters
            // 
            CbShiftListFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            CbShiftListFilters.FormattingEnabled = true;
            CbShiftListFilters.Location = new Point(148, 18);
            CbShiftListFilters.Margin = new Padding(5);
            CbShiftListFilters.Name = "CbShiftListFilters";
            CbShiftListFilters.Size = new Size(324, 40);
            CbShiftListFilters.TabIndex = 17;
            // 
            // BtnApplySortShift
            // 
            BtnApplySortShift.BackColor = Color.Aquamarine;
            BtnApplySortShift.BackgroundColor = Color.Aquamarine;
            BtnApplySortShift.BoderSize = 1;
            BtnApplySortShift.BorderColor = Color.Black;
            BtnApplySortShift.BorderRadius = 28;
            BtnApplySortShift.FlatAppearance.BorderSize = 0;
            BtnApplySortShift.FlatStyle = FlatStyle.Flat;
            BtnApplySortShift.ForeColor = Color.Black;
            BtnApplySortShift.Location = new Point(502, 16);
            BtnApplySortShift.Name = "BtnApplySortShift";
            BtnApplySortShift.Size = new Size(128, 45);
            BtnApplySortShift.TabIndex = 16;
            BtnApplySortShift.Text = "Áp dụng";
            BtnApplySortShift.TextColor = Color.Black;
            BtnApplySortShift.UseVisualStyleBackColor = false;
            BtnApplySortShift.Click += BtnApplySortShiftClick;
            // 
            // TbSearchShift
            // 
            TbSearchShift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbSearchShift.BorderStyle = BorderStyle.FixedSingle;
            TbSearchShift.Location = new Point(1079, 11);
            TbSearchShift.Multiline = true;
            TbSearchShift.Name = "TbSearchShift";
            TbSearchShift.Size = new Size(602, 56);
            TbSearchShift.TabIndex = 15;
            // 
            // BtnSearchShiftList
            // 
            BtnSearchShiftList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchShiftList.BackColor = Color.FromArgb(196, 238, 181);
            BtnSearchShiftList.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSearchShiftList.BoderSize = 1;
            BtnSearchShiftList.BorderColor = Color.Black;
            BtnSearchShiftList.BorderRadius = 35;
            BtnSearchShiftList.FlatAppearance.BorderSize = 0;
            BtnSearchShiftList.FlatStyle = FlatStyle.Flat;
            BtnSearchShiftList.ForeColor = Color.Black;
            BtnSearchShiftList.Location = new Point(1688, 11);
            BtnSearchShiftList.Name = "BtnSearchShiftList";
            BtnSearchShiftList.Size = new Size(185, 56);
            BtnSearchShiftList.TabIndex = 14;
            BtnSearchShiftList.Text = "Tìm kiếm";
            BtnSearchShiftList.TextColor = Color.Black;
            BtnSearchShiftList.UseVisualStyleBackColor = false;
            BtnSearchShiftList.Click += BtnSearchShiftListClick;
            // 
            // Panel8
            // 
            Panel8.BackColor = Color.FromArgb(228, 255, 207);
            Panel8.BorderStyle = BorderStyle.FixedSingle;
            Panel8.Controls.Add(RjButton1);
            Panel8.Dock = DockStyle.Top;
            Panel8.Location = new Point(5, 5);
            Panel8.Margin = new Padding(5);
            Panel8.Name = "Panel8";
            Panel8.Size = new Size(1898, 85);
            Panel8.TabIndex = 0;
            // 
            // RjButton1
            // 
            RjButton1.BackColor = Color.FromArgb(196, 238, 181);
            RjButton1.BackgroundColor = Color.FromArgb(196, 238, 181);
            RjButton1.BoderSize = 0;
            RjButton1.BorderColor = Color.PaleVioletRed;
            RjButton1.BorderRadius = 27;
            RjButton1.Dock = DockStyle.Top;
            RjButton1.FlatAppearance.BorderSize = 0;
            RjButton1.FlatStyle = FlatStyle.Flat;
            RjButton1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RjButton1.ForeColor = Color.Black;
            RjButton1.Location = new Point(0, 0);
            RjButton1.Margin = new Padding(5);
            RjButton1.Name = "RjButton1";
            RjButton1.Size = new Size(1896, 85);
            RjButton1.TabIndex = 0;
            RjButton1.Text = "Danh sách phân công ca làm";
            RjButton1.TextColor = Color.Black;
            RjButton1.UseVisualStyleBackColor = false;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1924, 1245);
            Controls.Add(Panel1);
            Margin = new Padding(5);
            Name = "EmployeeListForm";
            Text = "EmployeeListForm";
            Panel1.ResumeLayout(false);
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvEmployeeList).EndInit();
            PanelEmployee1.ResumeLayout(false);
            Panel6.ResumeLayout(false);
            Panel6.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            Panel3.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            Panel12.ResumeLayout(false);
            Panel12.PerformLayout();
            Panel10.ResumeLayout(false);
            Panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvShiftList).EndInit();
            Panel9.ResumeLayout(false);
            Panel9.PerformLayout();
            Panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox TbSearchEmployee;
        private Panel Panel1;
        private Panel Panel3;
        private Label LbFilter;
        private ComboBox CbSortBy;
        private Components.RJButton BtnApplyEmployeeListFilters;
        private Components.RJButton BtnSearchEmployeeList;
        private Panel Panel4;
        private Panel Panel5;
        private Panel Panel6;
        private Components.RJButton BtnSaveEmployeeInformations;
        private Components.RJButton BtnCancelEmployeeInformations;
        private Components.RJButton RjButton4;
        private Components.RJButton RjButton7;
        private TabControl TabControl1;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private DataGridView DgvEmployeeList;
        private TextBox TbEmployeePhone;
        private TextBox TbEmployeeEmail;
        private TextBox TbEmployeeStation;
        private Label Label2;
        private Label Label5;
        private Label Label8;
        private Label Label11;
        private Label Label12;
        private Label Label13;
        private TextBox TbEmployeePosition;
        private TextBox TbBirthDate;
        private TextBox TbEmpFullName;
        private Panel Panel12;
        private Panel Panel10;
        private Panel Panel9;
        private Panel Panel8;
        private Components.RJButton RjButton1;
        private Components.RJButton BtnDeleteShift;
        private Components.RJButton BtnUpdateShift;
        private Components.RJButton BtnAddShift;
        private DataGridView DgvShiftList;
        private ReaLTaiizor.Controls.AirRadioButton airRadioButton1;
        private Label Label1;
        private Components.RJButton BtnApplySortShift;
        private TextBox TbSearchShift;
        private Components.RJButton BtnSearchShiftList;
        private Label Label7;
        private Label Label6;
        private Label Label4;
        private Label Label3;
        private TextBox TbNameEmployeeShift;
        private ComboBox CbShift;
        private ComboBox CbShiftListFilters;
        private Panel PanelEmployee1;
        private Components.RJButton BtnDeleteEmployeeList;
        private Components.RJButton BtnAddEmployeeList;
        private Components.RJButton BtnUpdateEmployeeList;
        private Panel Panel2;
        private Panel Panel14;
        private Label Label10;
        private Label Label9;
        private TextBox TbNote;
        private TextBox TbStatus;
        private DateTimePicker DateTimePicker1;
        private Components.RJButton BtnCancel;
        private Components.RJButton BtnSave;
        private ComboBox CbEmployeeID;
    }
}