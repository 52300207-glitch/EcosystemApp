namespace EcosystemApp.GUI.ChildEmployeeForm
{
    partial class ManageLogisticForm
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
            Panel4 = new Panel();
            DgvDeliveryRoute = new DataGridView();
            Panel8 = new Panel();
            BtnAddDeliveryRoute = new EcosystemApp.GUI.Components.RJButton();
            BtnUpdateDeliveryRoute = new EcosystemApp.GUI.Components.RJButton();
            BtnDeleteDeliveryRoute = new EcosystemApp.GUI.Components.RJButton();
            Panel3 = new Panel();
            BtnRefesh = new EcosystemApp.GUI.Components.RJButton();
            ButExport = new EcosystemApp.GUI.Components.RJButton();
            BtnImportExcel = new EcosystemApp.GUI.Components.RJButton();
            Panel1 = new Panel();
            Label1 = new Label();
            PanelSeparation = new Panel();
            Panel2 = new Panel();
            DgvLogisticEmployeeList = new DataGridView();
            Panel7 = new Panel();
            BtnDeleteDeliveryEmp = new EcosystemApp.GUI.Components.RJButton();
            BtnAddDeliveryEmp = new EcosystemApp.GUI.Components.RJButton();
            BtnUpdateDeliveryEmp = new EcosystemApp.GUI.Components.RJButton();
            Panel6 = new Panel();
            RjButton10 = new EcosystemApp.GUI.Components.RJButton();
            Panel5 = new Panel();
            TbManageLogisticSearch = new TextBox();
            BtnSearchManageLogistic = new EcosystemApp.GUI.Components.RJButton();
            BtnApplyManageLogisticFilters = new EcosystemApp.GUI.Components.RJButton();
            CbManageLogisticFilters = new ComboBox();
            LbFilter = new Label();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDeliveryRoute).BeginInit();
            Panel8.SuspendLayout();
            Panel3.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLogisticEmployeeList).BeginInit();
            Panel7.SuspendLayout();
            Panel6.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.FromArgb(248, 255, 245);
            Panel4.Controls.Add(DgvDeliveryRoute);
            Panel4.Controls.Add(Panel8);
            Panel4.Controls.Add(Panel3);
            Panel4.Controls.Add(Panel1);
            Panel4.Controls.Add(PanelSeparation);
            Panel4.Controls.Add(Panel2);
            Panel4.Controls.Add(Panel6);
            Panel4.Controls.Add(Panel5);
            Panel4.Dock = DockStyle.Fill;
            Panel4.Location = new Point(0, 0);
            Panel4.Margin = new Padding(5, 5, 5, 5);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1924, 1354);
            Panel4.TabIndex = 14;
            // 
            // DgvDeliveryRoute
            // 
            DgvDeliveryRoute.BackgroundColor = Color.White;
            DgvDeliveryRoute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDeliveryRoute.Dock = DockStyle.Fill;
            DgvDeliveryRoute.Location = new Point(0, 750);
            DgvDeliveryRoute.Margin = new Padding(5, 5, 5, 5);
            DgvDeliveryRoute.Name = "DgvDeliveryRoute";
            DgvDeliveryRoute.RowHeadersWidth = 51;
            DgvDeliveryRoute.Size = new Size(1924, 433);
            DgvDeliveryRoute.TabIndex = 13;
            // 
            // Panel8
            // 
            Panel8.BackColor = Color.FromArgb(228, 255, 207);
            Panel8.Controls.Add(BtnAddDeliveryRoute);
            Panel8.Controls.Add(BtnUpdateDeliveryRoute);
            Panel8.Controls.Add(BtnDeleteDeliveryRoute);
            Panel8.Dock = DockStyle.Bottom;
            Panel8.Location = new Point(0, 1183);
            Panel8.Name = "Panel8";
            Panel8.Size = new Size(1924, 83);
            Panel8.TabIndex = 23;
            // 
            // BtnAddDeliveryRoute
            // 
            BtnAddDeliveryRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddDeliveryRoute.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddDeliveryRoute.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddDeliveryRoute.BoderSize = 1;
            BtnAddDeliveryRoute.BorderColor = Color.Black;
            BtnAddDeliveryRoute.BorderRadius = 35;
            BtnAddDeliveryRoute.FlatAppearance.BorderSize = 0;
            BtnAddDeliveryRoute.FlatStyle = FlatStyle.Flat;
            BtnAddDeliveryRoute.ForeColor = Color.Black;
            BtnAddDeliveryRoute.Location = new Point(1739, 8);
            BtnAddDeliveryRoute.Name = "BtnAddDeliveryRoute";
            BtnAddDeliveryRoute.Size = new Size(185, 56);
            BtnAddDeliveryRoute.TabIndex = 15;
            BtnAddDeliveryRoute.Text = "Thêm";
            BtnAddDeliveryRoute.TextColor = Color.Black;
            BtnAddDeliveryRoute.UseVisualStyleBackColor = false;
            BtnAddDeliveryRoute.Click += AddDeliveryRouteClick;
            // 
            // BtnUpdateDeliveryRoute
            // 
            BtnUpdateDeliveryRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUpdateDeliveryRoute.BackColor = Color.NavajoWhite;
            BtnUpdateDeliveryRoute.BackgroundColor = Color.NavajoWhite;
            BtnUpdateDeliveryRoute.BoderSize = 1;
            BtnUpdateDeliveryRoute.BorderColor = Color.Black;
            BtnUpdateDeliveryRoute.BorderRadius = 35;
            BtnUpdateDeliveryRoute.FlatAppearance.BorderSize = 0;
            BtnUpdateDeliveryRoute.FlatStyle = FlatStyle.Flat;
            BtnUpdateDeliveryRoute.ForeColor = Color.Black;
            BtnUpdateDeliveryRoute.Location = new Point(1547, 8);
            BtnUpdateDeliveryRoute.Name = "BtnUpdateDeliveryRoute";
            BtnUpdateDeliveryRoute.Size = new Size(185, 56);
            BtnUpdateDeliveryRoute.TabIndex = 16;
            BtnUpdateDeliveryRoute.Text = "Sửa";
            BtnUpdateDeliveryRoute.TextColor = Color.Black;
            BtnUpdateDeliveryRoute.UseVisualStyleBackColor = false;
            BtnUpdateDeliveryRoute.Click += UpdateDeliveryRouteClick;
            // 
            // BtnDeleteDeliveryRoute
            // 
            BtnDeleteDeliveryRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteDeliveryRoute.BackColor = Color.Salmon;
            BtnDeleteDeliveryRoute.BackgroundColor = Color.Salmon;
            BtnDeleteDeliveryRoute.BoderSize = 1;
            BtnDeleteDeliveryRoute.BorderColor = Color.Black;
            BtnDeleteDeliveryRoute.BorderRadius = 35;
            BtnDeleteDeliveryRoute.FlatAppearance.BorderSize = 0;
            BtnDeleteDeliveryRoute.FlatStyle = FlatStyle.Flat;
            BtnDeleteDeliveryRoute.ForeColor = Color.Black;
            BtnDeleteDeliveryRoute.Location = new Point(1357, 8);
            BtnDeleteDeliveryRoute.Name = "BtnDeleteDeliveryRoute";
            BtnDeleteDeliveryRoute.Size = new Size(185, 56);
            BtnDeleteDeliveryRoute.TabIndex = 17;
            BtnDeleteDeliveryRoute.Text = "Xóa";
            BtnDeleteDeliveryRoute.TextColor = Color.Black;
            BtnDeleteDeliveryRoute.UseVisualStyleBackColor = false;
            BtnDeleteDeliveryRoute.Click += DeleteDeliveryRouteClick;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(196, 238, 181);
            Panel3.Controls.Add(BtnRefesh);
            Panel3.Controls.Add(ButExport);
            Panel3.Controls.Add(BtnImportExcel);
            Panel3.Dock = DockStyle.Bottom;
            Panel3.Location = new Point(0, 1266);
            Panel3.Margin = new Padding(5, 5, 5, 5);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1924, 88);
            Panel3.TabIndex = 22;
            // 
            // BtnRefesh
            // 
            BtnRefesh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRefesh.BackColor = Color.FromArgb(192, 255, 255);
            BtnRefesh.BackgroundColor = Color.FromArgb(192, 255, 255);
            BtnRefesh.BoderSize = 1;
            BtnRefesh.BorderColor = Color.Black;
            BtnRefesh.BorderRadius = 35;
            BtnRefesh.FlatAppearance.BorderSize = 0;
            BtnRefesh.FlatStyle = FlatStyle.Flat;
            BtnRefesh.ForeColor = Color.Black;
            BtnRefesh.Location = new Point(1693, 13);
            BtnRefesh.Name = "BtnRefesh";
            BtnRefesh.Size = new Size(219, 66);
            BtnRefesh.TabIndex = 19;
            BtnRefesh.Text = "Làm mới";
            BtnRefesh.TextColor = Color.Black;
            BtnRefesh.UseVisualStyleBackColor = false;
            BtnRefesh.Click += BtnRefeshClick;
            // 
            // ButExport
            // 
            ButExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButExport.BackColor = Color.FromArgb(255, 255, 192);
            ButExport.BackgroundColor = Color.FromArgb(255, 255, 192);
            ButExport.BoderSize = 1;
            ButExport.BorderColor = Color.Black;
            ButExport.BorderRadius = 35;
            ButExport.FlatAppearance.BorderSize = 0;
            ButExport.FlatStyle = FlatStyle.Flat;
            ButExport.ForeColor = Color.Black;
            ButExport.Location = new Point(1458, 13);
            ButExport.Name = "ButExport";
            ButExport.Size = new Size(229, 66);
            ButExport.TabIndex = 19;
            ButExport.Text = "Xuất File Excel";
            ButExport.TextColor = Color.Black;
            ButExport.UseVisualStyleBackColor = false;
            ButExport.Click += ButExportClick;
            // 
            // BtnImportExcel
            // 
            BtnImportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnImportExcel.BackColor = Color.FromArgb(192, 255, 192);
            BtnImportExcel.BackgroundColor = Color.FromArgb(192, 255, 192);
            BtnImportExcel.BoderSize = 1;
            BtnImportExcel.BorderColor = Color.Black;
            BtnImportExcel.BorderRadius = 35;
            BtnImportExcel.FlatAppearance.BorderSize = 0;
            BtnImportExcel.FlatStyle = FlatStyle.Flat;
            BtnImportExcel.ForeColor = Color.Black;
            BtnImportExcel.Location = new Point(1222, 13);
            BtnImportExcel.Name = "BtnImportExcel";
            BtnImportExcel.Size = new Size(229, 66);
            BtnImportExcel.TabIndex = 18;
            BtnImportExcel.Text = "Nhận file Excel";
            BtnImportExcel.TextColor = Color.Black;
            BtnImportExcel.UseVisualStyleBackColor = false;
            BtnImportExcel.Click += BtnImportExcelClick;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(196, 238, 181);
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(Label1);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 665);
            Panel1.Margin = new Padding(5, 5, 5, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1924, 85);
            Panel1.TabIndex = 19;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(1050, 18);
            Label1.Name = "Label1";
            Label1.Size = new Size(252, 37);
            Label1.TabIndex = 0;
            Label1.Text = "Lộ trình giao hàng";
            // 
            // PanelSeparation
            // 
            PanelSeparation.Dock = DockStyle.Top;
            PanelSeparation.Location = new Point(0, 638);
            PanelSeparation.Name = "PanelSeparation";
            PanelSeparation.Size = new Size(1924, 27);
            PanelSeparation.TabIndex = 20;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(228, 255, 207);
            Panel2.BorderStyle = BorderStyle.FixedSingle;
            Panel2.Controls.Add(DgvLogisticEmployeeList);
            Panel2.Controls.Add(Panel7);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 158);
            Panel2.Margin = new Padding(5, 5, 5, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1924, 480);
            Panel2.TabIndex = 16;
            // 
            // DgvLogisticEmployeeList
            // 
            DgvLogisticEmployeeList.BackgroundColor = Color.White;
            DgvLogisticEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLogisticEmployeeList.Dock = DockStyle.Fill;
            DgvLogisticEmployeeList.Location = new Point(0, 0);
            DgvLogisticEmployeeList.Margin = new Padding(5, 5, 5, 5);
            DgvLogisticEmployeeList.Name = "DgvLogisticEmployeeList";
            DgvLogisticEmployeeList.RowHeadersWidth = 51;
            DgvLogisticEmployeeList.Size = new Size(1922, 395);
            DgvLogisticEmployeeList.TabIndex = 12;
            // 
            // Panel7
            // 
            Panel7.BackColor = Color.FromArgb(228, 255, 207);
            Panel7.Controls.Add(BtnDeleteDeliveryEmp);
            Panel7.Controls.Add(BtnAddDeliveryEmp);
            Panel7.Controls.Add(BtnUpdateDeliveryEmp);
            Panel7.Dock = DockStyle.Bottom;
            Panel7.Location = new Point(0, 395);
            Panel7.Margin = new Padding(5, 5, 5, 5);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(1922, 83);
            Panel7.TabIndex = 18;
            // 
            // BtnDeleteDeliveryEmp
            // 
            BtnDeleteDeliveryEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteDeliveryEmp.BackColor = Color.Salmon;
            BtnDeleteDeliveryEmp.BackgroundColor = Color.Salmon;
            BtnDeleteDeliveryEmp.BoderSize = 1;
            BtnDeleteDeliveryEmp.BorderColor = Color.Black;
            BtnDeleteDeliveryEmp.BorderRadius = 35;
            BtnDeleteDeliveryEmp.FlatAppearance.BorderSize = 0;
            BtnDeleteDeliveryEmp.FlatStyle = FlatStyle.Flat;
            BtnDeleteDeliveryEmp.ForeColor = Color.Black;
            BtnDeleteDeliveryEmp.Location = new Point(1343, 8);
            BtnDeleteDeliveryEmp.Name = "BtnDeleteDeliveryEmp";
            BtnDeleteDeliveryEmp.Size = new Size(185, 56);
            BtnDeleteDeliveryEmp.TabIndex = 18;
            BtnDeleteDeliveryEmp.Text = "Xóa";
            BtnDeleteDeliveryEmp.TextColor = Color.Black;
            BtnDeleteDeliveryEmp.UseVisualStyleBackColor = false;
            BtnDeleteDeliveryEmp.Click += DeleteDeliveryEmpClick;
            // 
            // BtnAddDeliveryEmp
            // 
            BtnAddDeliveryEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddDeliveryEmp.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddDeliveryEmp.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddDeliveryEmp.BoderSize = 1;
            BtnAddDeliveryEmp.BorderColor = Color.Black;
            BtnAddDeliveryEmp.BorderRadius = 35;
            BtnAddDeliveryEmp.FlatAppearance.BorderSize = 0;
            BtnAddDeliveryEmp.FlatStyle = FlatStyle.Flat;
            BtnAddDeliveryEmp.ForeColor = Color.Black;
            BtnAddDeliveryEmp.Location = new Point(1727, 8);
            BtnAddDeliveryEmp.Name = "BtnAddDeliveryEmp";
            BtnAddDeliveryEmp.Size = new Size(185, 56);
            BtnAddDeliveryEmp.TabIndex = 16;
            BtnAddDeliveryEmp.Text = "Thêm";
            BtnAddDeliveryEmp.TextColor = Color.Black;
            BtnAddDeliveryEmp.UseVisualStyleBackColor = false;
            BtnAddDeliveryEmp.Click += AddDeliveryEmpClick;
            // 
            // BtnUpdateDeliveryEmp
            // 
            BtnUpdateDeliveryEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUpdateDeliveryEmp.BackColor = Color.NavajoWhite;
            BtnUpdateDeliveryEmp.BackgroundColor = Color.NavajoWhite;
            BtnUpdateDeliveryEmp.BoderSize = 1;
            BtnUpdateDeliveryEmp.BorderColor = Color.Black;
            BtnUpdateDeliveryEmp.BorderRadius = 35;
            BtnUpdateDeliveryEmp.FlatAppearance.BorderSize = 0;
            BtnUpdateDeliveryEmp.FlatStyle = FlatStyle.Flat;
            BtnUpdateDeliveryEmp.ForeColor = Color.Black;
            BtnUpdateDeliveryEmp.Location = new Point(1535, 8);
            BtnUpdateDeliveryEmp.Name = "BtnUpdateDeliveryEmp";
            BtnUpdateDeliveryEmp.Size = new Size(185, 56);
            BtnUpdateDeliveryEmp.TabIndex = 17;
            BtnUpdateDeliveryEmp.Text = "Sửa";
            BtnUpdateDeliveryEmp.TextColor = Color.Black;
            BtnUpdateDeliveryEmp.UseVisualStyleBackColor = false;
            BtnUpdateDeliveryEmp.Click += UpdateDeliveryEmpClick;
            // 
            // Panel6
            // 
            Panel6.BackColor = Color.FromArgb(228, 255, 207);
            Panel6.BorderStyle = BorderStyle.FixedSingle;
            Panel6.Controls.Add(RjButton10);
            Panel6.Dock = DockStyle.Top;
            Panel6.Location = new Point(0, 82);
            Panel6.Margin = new Padding(5, 5, 5, 5);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(1924, 76);
            Panel6.TabIndex = 15;
            // 
            // RjButton10
            // 
            RjButton10.BackColor = Color.FromArgb(196, 238, 181);
            RjButton10.BackgroundColor = Color.FromArgb(196, 238, 181);
            RjButton10.BoderSize = 0;
            RjButton10.BorderColor = Color.Black;
            RjButton10.BorderRadius = 40;
            RjButton10.Dock = DockStyle.Fill;
            RjButton10.FlatAppearance.BorderSize = 0;
            RjButton10.FlatStyle = FlatStyle.Flat;
            RjButton10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RjButton10.ForeColor = Color.Black;
            RjButton10.Location = new Point(0, 0);
            RjButton10.Margin = new Padding(5, 5, 5, 5);
            RjButton10.Name = "RjButton10";
            RjButton10.Size = new Size(1922, 74);
            RjButton10.TabIndex = 10;
            RjButton10.Text = "Danh sách phân công chuẩn bị hàng";
            RjButton10.TextColor = Color.Black;
            RjButton10.UseVisualStyleBackColor = false;
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.FromArgb(228, 255, 207);
            Panel5.BorderStyle = BorderStyle.FixedSingle;
            Panel5.Controls.Add(TbManageLogisticSearch);
            Panel5.Controls.Add(BtnSearchManageLogistic);
            Panel5.Controls.Add(BtnApplyManageLogisticFilters);
            Panel5.Controls.Add(CbManageLogisticFilters);
            Panel5.Controls.Add(LbFilter);
            Panel5.Dock = DockStyle.Top;
            Panel5.Location = new Point(0, 0);
            Panel5.Margin = new Padding(5, 5, 5, 5);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(1924, 82);
            Panel5.TabIndex = 14;
            // 
            // TbManageLogisticSearch
            // 
            TbManageLogisticSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbManageLogisticSearch.BorderStyle = BorderStyle.FixedSingle;
            TbManageLogisticSearch.Location = new Point(1119, 11);
            TbManageLogisticSearch.Multiline = true;
            TbManageLogisticSearch.Name = "TbManageLogisticSearch";
            TbManageLogisticSearch.Size = new Size(602, 56);
            TbManageLogisticSearch.TabIndex = 16;
            // 
            // BtnSearchManageLogistic
            // 
            BtnSearchManageLogistic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchManageLogistic.BackColor = Color.FromArgb(196, 238, 181);
            BtnSearchManageLogistic.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSearchManageLogistic.BoderSize = 1;
            BtnSearchManageLogistic.BorderColor = Color.Black;
            BtnSearchManageLogistic.BorderRadius = 35;
            BtnSearchManageLogistic.FlatAppearance.BorderSize = 0;
            BtnSearchManageLogistic.FlatStyle = FlatStyle.Flat;
            BtnSearchManageLogistic.ForeColor = Color.Black;
            BtnSearchManageLogistic.Location = new Point(1727, 11);
            BtnSearchManageLogistic.Name = "BtnSearchManageLogistic";
            BtnSearchManageLogistic.Size = new Size(185, 56);
            BtnSearchManageLogistic.TabIndex = 15;
            BtnSearchManageLogistic.Text = "Tìm kiếm";
            BtnSearchManageLogistic.TextColor = Color.Black;
            BtnSearchManageLogistic.UseVisualStyleBackColor = false;
            BtnSearchManageLogistic.Click += BtnSearchManageLogisticClick;
            // 
            // BtnApplyManageLogisticFilters
            // 
            BtnApplyManageLogisticFilters.BackColor = Color.Aquamarine;
            BtnApplyManageLogisticFilters.BackgroundColor = Color.Aquamarine;
            BtnApplyManageLogisticFilters.BoderSize = 1;
            BtnApplyManageLogisticFilters.BorderColor = Color.Black;
            BtnApplyManageLogisticFilters.BorderRadius = 28;
            BtnApplyManageLogisticFilters.FlatAppearance.BorderSize = 0;
            BtnApplyManageLogisticFilters.FlatStyle = FlatStyle.Flat;
            BtnApplyManageLogisticFilters.ForeColor = Color.Black;
            BtnApplyManageLogisticFilters.Location = new Point(512, 22);
            BtnApplyManageLogisticFilters.Name = "BtnApplyManageLogisticFilters";
            BtnApplyManageLogisticFilters.Size = new Size(128, 45);
            BtnApplyManageLogisticFilters.TabIndex = 14;
            BtnApplyManageLogisticFilters.Text = "Áp dụng";
            BtnApplyManageLogisticFilters.TextColor = Color.Black;
            BtnApplyManageLogisticFilters.UseVisualStyleBackColor = false;
            BtnApplyManageLogisticFilters.Click += ApplyManageLogisticClick;
            // 
            // CbManageLogisticFilters
            // 
            CbManageLogisticFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            CbManageLogisticFilters.FormattingEnabled = true;
            CbManageLogisticFilters.Location = new Point(159, 22);
            CbManageLogisticFilters.Margin = new Padding(5, 5, 5, 5);
            CbManageLogisticFilters.Name = "CbManageLogisticFilters";
            CbManageLogisticFilters.Size = new Size(324, 40);
            CbManageLogisticFilters.TabIndex = 13;
            // 
            // LbFilter
            // 
            LbFilter.AutoSize = true;
            LbFilter.Location = new Point(63, 27);
            LbFilter.Name = "LbFilter";
            LbFilter.Size = new Size(85, 32);
            LbFilter.TabIndex = 12;
            LbFilter.Text = "Bộ lọc:";
            // 
            // ManageLogisticForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1924, 1354);
            Controls.Add(Panel4);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ManageLogisticForm";
            Text = "ManageLogisticForm";
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDeliveryRoute).EndInit();
            Panel8.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvLogisticEmployeeList).EndInit();
            Panel7.ResumeLayout(false);
            Panel6.ResumeLayout(false);
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Panel4;
        private Panel Panel5;
        private Panel Panel6;
        private Components.RJButton RjButton10;
        private Panel Panel2;
        private DataGridView DgvLogisticEmployeeList;
        private Panel Panel1;
        private Components.RJButton BtnAddDeliveryRoute;
        private Components.RJButton BtnUpdateDeliveryRoute;
        private Components.RJButton BtnDeleteDeliveryRoute;
        private Components.RJButton BtnDeleteDeliveryEmp;
        private Components.RJButton BtnUpdateDeliveryEmp;
        private Components.RJButton BtnAddDeliveryEmp;
        private Label LbFilter;
        private ComboBox CbManageLogisticFilters;
        private Components.RJButton BtnApplyManageLogisticFilters;
        private TextBox TbManageLogisticSearch;
        private Components.RJButton BtnSearchManageLogistic;
        private Panel Panel3;
        private DataGridView DgvDeliveryRoute;
        private Panel Panel7;
        private Components.RJButton BtnImportExcel;
        private Components.RJButton ButExport;
        private Components.RJButton BtnRefesh;
        private Label Label1;
        private Panel PanelSeparation;
        private Panel Panel8;
    }
}