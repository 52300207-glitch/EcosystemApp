namespace EcosystemApp.GUI.ChildPackageForm
{
    partial class PackageCleaningForm
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
            PanelFilter = new Panel();
            BtnFilter = new EcosystemApp.GUI.Components.RJButton();
            LbDateEnd = new Label();
            DtpDateEnd = new DateTimePicker();
            LbDateStart = new Label();
            DtpDateStart = new DateTimePicker();
            LbWarehouseName = new Label();
            CbbTypePackageName = new ComboBox();
            PanelHeaderPackageCleaningSchedule = new Panel();
            LbHeaderPackageCleaningSchedule = new Label();
            PanelPackageCleaningSchedule = new Panel();
            DgvPackageCleaningSchedule = new DataGridView();
            PanelButtonPackageCleaningSchedule = new Panel();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnEdit = new EcosystemApp.GUI.Components.RJButton();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            LbEditedColumnNumber = new Label();
            PanelSeparation = new Panel();
            PanelCreateCleaningSchedule = new Panel();
            DtpTimeStart = new DateTimePicker();
            DtpTimeEnd = new DateTimePicker();
            CbbPackageTypeName = new ComboBox();
            DtpCleaningScheduleDate = new DateTimePicker();
            LbTimeEnd = new Label();
            LbTimeStart = new Label();
            LbCleaningSchedule = new Label();
            LbPackageTypeName = new Label();
            PanelButtonCreateCleaningSchedule = new Panel();
            BtnCreate = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderCreateCleaningSchedule = new Panel();
            LbHeaderCreateCleaningSchedule = new Label();
            PanelFilter.SuspendLayout();
            PanelHeaderPackageCleaningSchedule.SuspendLayout();
            PanelPackageCleaningSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPackageCleaningSchedule).BeginInit();
            PanelButtonPackageCleaningSchedule.SuspendLayout();
            PanelCreateCleaningSchedule.SuspendLayout();
            PanelButtonCreateCleaningSchedule.SuspendLayout();
            PanelHeaderCreateCleaningSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // PanelFilter
            // 
            PanelFilter.Controls.Add(BtnFilter);
            PanelFilter.Controls.Add(LbDateEnd);
            PanelFilter.Controls.Add(DtpDateEnd);
            PanelFilter.Controls.Add(LbDateStart);
            PanelFilter.Controls.Add(DtpDateStart);
            PanelFilter.Controls.Add(LbWarehouseName);
            PanelFilter.Controls.Add(CbbTypePackageName);
            PanelFilter.Dock = DockStyle.Top;
            PanelFilter.Location = new Point(0, 0);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(2501, 82);
            PanelFilter.TabIndex = 1;
            // 
            // BtnFilter
            // 
            BtnFilter.BackColor = Color.FromArgb(196, 238, 181);
            BtnFilter.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnFilter.BoderSize = 2;
            BtnFilter.BorderColor = Color.Black;
            BtnFilter.BorderRadius = 40;
            BtnFilter.FlatAppearance.BorderSize = 0;
            BtnFilter.FlatStyle = FlatStyle.Flat;
            BtnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFilter.ForeColor = Color.Black;
            BtnFilter.Location = new Point(1316, 22);
            BtnFilter.Margin = new Padding(5, 5, 5, 5);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(135, 42);
            BtnFilter.TabIndex = 18;
            BtnFilter.Text = "Lọc";
            BtnFilter.TextColor = Color.Black;
            BtnFilter.UseVisualStyleBackColor = false;
            BtnFilter.Click += BtnFilterClick;
            // 
            // LbDateEnd
            // 
            LbDateEnd.AutoSize = true;
            LbDateEnd.Location = new Point(889, 24);
            LbDateEnd.Margin = new Padding(5, 0, 5, 0);
            LbDateEnd.Name = "LbDateEnd";
            LbDateEnd.Size = new Size(117, 32);
            LbDateEnd.TabIndex = 17;
            LbDateEnd.Text = "Đến ngày";
            // 
            // DtpDateEnd
            // 
            DtpDateEnd.Format = DateTimePickerFormat.Short;
            DtpDateEnd.Location = new Point(1014, 22);
            DtpDateEnd.Name = "DtpDateEnd";
            DtpDateEnd.Size = new Size(274, 39);
            DtpDateEnd.TabIndex = 16;
            // 
            // LbDateStart
            // 
            LbDateStart.AutoSize = true;
            LbDateStart.Location = new Point(471, 24);
            LbDateStart.Margin = new Padding(5, 0, 5, 0);
            LbDateStart.Name = "LbDateStart";
            LbDateStart.Size = new Size(100, 32);
            LbDateStart.TabIndex = 14;
            LbDateStart.Text = "Từ ngày";
            // 
            // DtpDateStart
            // 
            DtpDateStart.Format = DateTimePickerFormat.Short;
            DtpDateStart.Location = new Point(578, 22);
            DtpDateStart.Name = "DtpDateStart";
            DtpDateStart.Size = new Size(274, 39);
            DtpDateStart.TabIndex = 13;
            // 
            // LbWarehouseName
            // 
            LbWarehouseName.AutoSize = true;
            LbWarehouseName.Location = new Point(36, 26);
            LbWarehouseName.Margin = new Padding(5, 0, 5, 0);
            LbWarehouseName.Name = "LbWarehouseName";
            LbWarehouseName.Size = new Size(171, 32);
            LbWarehouseName.TabIndex = 6;
            LbWarehouseName.Text = "Tên loại bao bì";
            // 
            // CbbTypePackageName
            // 
            CbbTypePackageName.FormattingEnabled = true;
            CbbTypePackageName.Location = new Point(218, 24);
            CbbTypePackageName.Margin = new Padding(5, 5, 5, 5);
            CbbTypePackageName.Name = "CbbTypePackageName";
            CbbTypePackageName.Size = new Size(243, 40);
            CbbTypePackageName.TabIndex = 5;
            // 
            // PanelHeaderPackageCleaningSchedule
            // 
            PanelHeaderPackageCleaningSchedule.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackageCleaningSchedule.Controls.Add(LbHeaderPackageCleaningSchedule);
            PanelHeaderPackageCleaningSchedule.Dock = DockStyle.Top;
            PanelHeaderPackageCleaningSchedule.Location = new Point(0, 0);
            PanelHeaderPackageCleaningSchedule.Name = "PanelHeaderPackageCleaningSchedule";
            PanelHeaderPackageCleaningSchedule.Size = new Size(2501, 67);
            PanelHeaderPackageCleaningSchedule.TabIndex = 2;
            // 
            // LbHeaderPackageCleaningSchedule
            // 
            LbHeaderPackageCleaningSchedule.Anchor = AnchorStyles.Top;
            LbHeaderPackageCleaningSchedule.AutoSize = true;
            LbHeaderPackageCleaningSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderPackageCleaningSchedule.Location = new Point(1136, 16);
            LbHeaderPackageCleaningSchedule.Name = "LbHeaderPackageCleaningSchedule";
            LbHeaderPackageCleaningSchedule.Size = new Size(225, 32);
            LbHeaderPackageCleaningSchedule.TabIndex = 0;
            LbHeaderPackageCleaningSchedule.Text = "Lịch vệ sinh bao bì";
            // 
            // PanelPackageCleaningSchedule
            // 
            PanelPackageCleaningSchedule.Controls.Add(DgvPackageCleaningSchedule);
            PanelPackageCleaningSchedule.Controls.Add(PanelButtonPackageCleaningSchedule);
            PanelPackageCleaningSchedule.Controls.Add(PanelHeaderPackageCleaningSchedule);
            PanelPackageCleaningSchedule.Dock = DockStyle.Fill;
            PanelPackageCleaningSchedule.Location = new Point(0, 82);
            PanelPackageCleaningSchedule.Name = "PanelPackageCleaningSchedule";
            PanelPackageCleaningSchedule.Size = new Size(2501, 567);
            PanelPackageCleaningSchedule.TabIndex = 3;
            // 
            // DgvPackageCleaningSchedule
            // 
            DgvPackageCleaningSchedule.AllowUserToResizeRows = false;
            DgvPackageCleaningSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPackageCleaningSchedule.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvPackageCleaningSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPackageCleaningSchedule.Dock = DockStyle.Fill;
            DgvPackageCleaningSchedule.Location = new Point(0, 67);
            DgvPackageCleaningSchedule.Name = "DgvPackageCleaningSchedule";
            DgvPackageCleaningSchedule.RowHeadersVisible = false;
            DgvPackageCleaningSchedule.RowHeadersWidth = 82;
            DgvPackageCleaningSchedule.RowTemplate.Height = 45;
            DgvPackageCleaningSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPackageCleaningSchedule.Size = new Size(2501, 426);
            DgvPackageCleaningSchedule.TabIndex = 4;
            DgvPackageCleaningSchedule.CellClick += DgvPackageCleaningScheduleCellClick;
            // 
            // PanelButtonPackageCleaningSchedule
            // 
            PanelButtonPackageCleaningSchedule.BackColor = Color.FromArgb(228, 255, 207);
            PanelButtonPackageCleaningSchedule.Controls.Add(BtnDelete);
            PanelButtonPackageCleaningSchedule.Controls.Add(BtnEdit);
            PanelButtonPackageCleaningSchedule.Controls.Add(BtnSave);
            PanelButtonPackageCleaningSchedule.Controls.Add(LbEditedColumnNumber);
            PanelButtonPackageCleaningSchedule.Dock = DockStyle.Bottom;
            PanelButtonPackageCleaningSchedule.Location = new Point(0, 493);
            PanelButtonPackageCleaningSchedule.Name = "PanelButtonPackageCleaningSchedule";
            PanelButtonPackageCleaningSchedule.Size = new Size(2501, 74);
            PanelButtonPackageCleaningSchedule.TabIndex = 3;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(224, 224, 224);
            BtnDelete.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnDelete.BoderSize = 2;
            BtnDelete.BorderColor = Color.Black;
            BtnDelete.BorderRadius = 40;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe UI", 9F);
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(2002, 12);
            BtnDelete.Margin = new Padding(5, 5, 5, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(122, 53);
            BtnDelete.TabIndex = 11;
            BtnDelete.Text = "Xóa";
            BtnDelete.TextColor = Color.Black;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDeleteClick;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.FromArgb(196, 238, 181);
            BtnEdit.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnEdit.BoderSize = 2;
            BtnEdit.BorderColor = Color.Black;
            BtnEdit.BorderRadius = 40;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Font = new Font("Segoe UI", 9F);
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.Location = new Point(2134, 12);
            BtnEdit.Margin = new Padding(5, 5, 5, 5);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(236, 53);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Cập nhật trạng thái";
            BtnEdit.TextColor = Color.Black;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEditClick;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.BackColor = Color.FromArgb(196, 238, 181);
            BtnSave.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSave.BoderSize = 2;
            BtnSave.BorderColor = Color.Black;
            BtnSave.BorderRadius = 40;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Segoe UI", 9F);
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(2380, 12);
            BtnSave.Margin = new Padding(5, 5, 5, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(116, 53);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // LbEditedColumnNumber
            // 
            LbEditedColumnNumber.AutoSize = true;
            LbEditedColumnNumber.Location = new Point(44, 19);
            LbEditedColumnNumber.Margin = new Padding(5, 0, 5, 0);
            LbEditedColumnNumber.Name = "LbEditedColumnNumber";
            LbEditedColumnNumber.Size = new Size(249, 32);
            LbEditedColumnNumber.TabIndex = 8;
            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa:";
            LbEditedColumnNumber.Visible = false;
            // 
            // PanelSeparation
            // 
            PanelSeparation.Dock = DockStyle.Bottom;
            PanelSeparation.Location = new Point(0, 649);
            PanelSeparation.Name = "PanelSeparation";
            PanelSeparation.Size = new Size(2501, 29);
            PanelSeparation.TabIndex = 4;
            // 
            // PanelCreateCleaningSchedule
            // 
            PanelCreateCleaningSchedule.Controls.Add(DtpTimeStart);
            PanelCreateCleaningSchedule.Controls.Add(DtpTimeEnd);
            PanelCreateCleaningSchedule.Controls.Add(CbbPackageTypeName);
            PanelCreateCleaningSchedule.Controls.Add(DtpCleaningScheduleDate);
            PanelCreateCleaningSchedule.Controls.Add(LbTimeEnd);
            PanelCreateCleaningSchedule.Controls.Add(LbTimeStart);
            PanelCreateCleaningSchedule.Controls.Add(LbCleaningSchedule);
            PanelCreateCleaningSchedule.Controls.Add(LbPackageTypeName);
            PanelCreateCleaningSchedule.Controls.Add(PanelButtonCreateCleaningSchedule);
            PanelCreateCleaningSchedule.Controls.Add(PanelHeaderCreateCleaningSchedule);
            PanelCreateCleaningSchedule.Dock = DockStyle.Bottom;
            PanelCreateCleaningSchedule.Location = new Point(0, 678);
            PanelCreateCleaningSchedule.Name = "PanelCreateCleaningSchedule";
            PanelCreateCleaningSchedule.Size = new Size(2501, 474);
            PanelCreateCleaningSchedule.TabIndex = 5;
            // 
            // DtpTimeStart
            // 
            DtpTimeStart.Location = new Point(1316, 150);
            DtpTimeStart.Name = "DtpTimeStart";
            DtpTimeStart.Size = new Size(677, 39);
            DtpTimeStart.TabIndex = 26;
            // 
            // DtpTimeEnd
            // 
            DtpTimeEnd.Location = new Point(1316, 232);
            DtpTimeEnd.Name = "DtpTimeEnd";
            DtpTimeEnd.Size = new Size(677, 39);
            DtpTimeEnd.TabIndex = 25;
            // 
            // CbbPackageTypeName
            // 
            CbbPackageTypeName.FormattingEnabled = true;
            CbbPackageTypeName.Location = new Point(361, 154);
            CbbPackageTypeName.Margin = new Padding(5, 5, 5, 5);
            CbbPackageTypeName.Name = "CbbPackageTypeName";
            CbbPackageTypeName.Size = new Size(677, 40);
            CbbPackageTypeName.TabIndex = 24;
            // 
            // DtpCleaningScheduleDate
            // 
            DtpCleaningScheduleDate.Format = DateTimePickerFormat.Short;
            DtpCleaningScheduleDate.Location = new Point(361, 227);
            DtpCleaningScheduleDate.Name = "DtpCleaningScheduleDate";
            DtpCleaningScheduleDate.Size = new Size(677, 39);
            DtpCleaningScheduleDate.TabIndex = 23;
            // 
            // LbTimeEnd
            // 
            LbTimeEnd.AutoSize = true;
            LbTimeEnd.Location = new Point(1098, 229);
            LbTimeEnd.Name = "LbTimeEnd";
            LbTimeEnd.Size = new Size(208, 32);
            LbTimeEnd.TabIndex = 22;
            LbTimeEnd.Text = "Thời gian kết thúc";
            // 
            // LbTimeStart
            // 
            LbTimeStart.AutoSize = true;
            LbTimeStart.Location = new Point(1108, 154);
            LbTimeStart.Name = "LbTimeStart";
            LbTimeStart.Size = new Size(202, 32);
            LbTimeStart.TabIndex = 21;
            LbTimeStart.Text = "Thời gian bắt đầu";
            // 
            // LbCleaningSchedule
            // 
            LbCleaningSchedule.AutoSize = true;
            LbCleaningSchedule.Location = new Point(179, 232);
            LbCleaningSchedule.Name = "LbCleaningSchedule";
            LbCleaningSchedule.Size = new Size(153, 32);
            LbCleaningSchedule.TabIndex = 20;
            LbCleaningSchedule.Text = "Ngày vệ sinh";
            // 
            // LbPackageTypeName
            // 
            LbPackageTypeName.AutoSize = true;
            LbPackageTypeName.Location = new Point(162, 157);
            LbPackageTypeName.Name = "LbPackageTypeName";
            LbPackageTypeName.Size = new Size(171, 32);
            LbPackageTypeName.TabIndex = 19;
            LbPackageTypeName.Text = "Tên loại bao bì";
            // 
            // PanelButtonCreateCleaningSchedule
            // 
            PanelButtonCreateCleaningSchedule.BackColor = Color.FromArgb(228, 255, 207);
            PanelButtonCreateCleaningSchedule.Controls.Add(BtnCreate);
            PanelButtonCreateCleaningSchedule.Dock = DockStyle.Bottom;
            PanelButtonCreateCleaningSchedule.Location = new Point(0, 405);
            PanelButtonCreateCleaningSchedule.Name = "PanelButtonCreateCleaningSchedule";
            PanelButtonCreateCleaningSchedule.Size = new Size(2501, 69);
            PanelButtonCreateCleaningSchedule.TabIndex = 2;
            // 
            // BtnCreate
            // 
            BtnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCreate.BackColor = Color.FromArgb(196, 238, 181);
            BtnCreate.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnCreate.BoderSize = 2;
            BtnCreate.BorderColor = Color.Black;
            BtnCreate.BorderRadius = 40;
            BtnCreate.FlatAppearance.BorderSize = 0;
            BtnCreate.FlatStyle = FlatStyle.Flat;
            BtnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCreate.ForeColor = Color.Black;
            BtnCreate.Location = new Point(2380, 5);
            BtnCreate.Margin = new Padding(5, 5, 5, 5);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(116, 59);
            BtnCreate.TabIndex = 12;
            BtnCreate.Text = "Tạo";
            BtnCreate.TextColor = Color.Black;
            BtnCreate.UseVisualStyleBackColor = false;
            BtnCreate.Click += BtnCreateClick;
            // 
            // PanelHeaderCreateCleaningSchedule
            // 
            PanelHeaderCreateCleaningSchedule.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderCreateCleaningSchedule.Controls.Add(LbHeaderCreateCleaningSchedule);
            PanelHeaderCreateCleaningSchedule.Dock = DockStyle.Top;
            PanelHeaderCreateCleaningSchedule.Location = new Point(0, 0);
            PanelHeaderCreateCleaningSchedule.Name = "PanelHeaderCreateCleaningSchedule";
            PanelHeaderCreateCleaningSchedule.Size = new Size(2501, 67);
            PanelHeaderCreateCleaningSchedule.TabIndex = 1;
            // 
            // LbHeaderCreateCleaningSchedule
            // 
            LbHeaderCreateCleaningSchedule.Anchor = AnchorStyles.Top;
            LbHeaderCreateCleaningSchedule.AutoSize = true;
            LbHeaderCreateCleaningSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderCreateCleaningSchedule.Location = new Point(1170, 18);
            LbHeaderCreateCleaningSchedule.Name = "LbHeaderCreateCleaningSchedule";
            LbHeaderCreateCleaningSchedule.Size = new Size(190, 32);
            LbHeaderCreateCleaningSchedule.TabIndex = 1;
            LbHeaderCreateCleaningSchedule.Text = "Tạo lịch vệ sinh";
            // 
            // PackageCleaningForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(2501, 1152);
            Controls.Add(PanelPackageCleaningSchedule);
            Controls.Add(PanelSeparation);
            Controls.Add(PanelFilter);
            Controls.Add(PanelCreateCleaningSchedule);
            Name = "PackageCleaningForm";
            Text = "PackageCleaningForm";
            PanelFilter.ResumeLayout(false);
            PanelFilter.PerformLayout();
            PanelHeaderPackageCleaningSchedule.ResumeLayout(false);
            PanelHeaderPackageCleaningSchedule.PerformLayout();
            PanelPackageCleaningSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPackageCleaningSchedule).EndInit();
            PanelButtonPackageCleaningSchedule.ResumeLayout(false);
            PanelButtonPackageCleaningSchedule.PerformLayout();
            PanelCreateCleaningSchedule.ResumeLayout(false);
            PanelCreateCleaningSchedule.PerformLayout();
            PanelButtonCreateCleaningSchedule.ResumeLayout(false);
            PanelHeaderCreateCleaningSchedule.ResumeLayout(false);
            PanelHeaderCreateCleaningSchedule.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelFilter;
        private Label LbDateEnd;
        private DateTimePicker DtpDateEnd;
        private Label LbDateStart;
        private DateTimePicker DtpDateStart;
        private Label LbWarehouseName;
        private ComboBox CbbTypePackageName;
        private Panel PanelHeaderPackageCleaningSchedule;
        private Label LbHeaderPackageCleaningSchedule;
        private Panel PanelPackageCleaningSchedule;
        private Panel PanelButtonPackageCleaningSchedule;
        private Label LbEditedColumnNumber;
        private DataGridView DgvPackageCleaningSchedule;
        private Panel PanelSeparation;
        private Panel PanelCreateCleaningSchedule;
        private Panel PanelHeaderCreateCleaningSchedule;
        private Label LbHeaderCreateCleaningSchedule;
        private Panel PanelButtonCreateCleaningSchedule;
        private DateTimePicker DtpTimeStart;
        private DateTimePicker DtpTimeEnd;
        private ComboBox CbbPackageTypeName;
        private DateTimePicker DtpCleaningScheduleDate;
        private Label LbTimeEnd;
        private Label LbTimeStart;
        private Label LbCleaningSchedule;
        private Label LbPackageTypeName;
        private Components.RJButton BtnDelete;
        private Components.RJButton BtnEdit;
        private Components.RJButton BtnSave;
        private Components.RJButton BtnCreate;
        private Components.RJButton BtnFilter;
    }
}