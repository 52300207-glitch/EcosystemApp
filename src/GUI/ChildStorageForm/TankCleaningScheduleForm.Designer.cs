namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class TankCleaningScheduleForm
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
            PanelTop = new Panel();
            LbDateEnd = new Label();
            DtpDateEnd = new DateTimePicker();
            BtnFilter = new EcosystemApp.GUI.Components.RJButton();
            LbDateStart = new Label();
            DtpDateStart = new DateTimePicker();
            LbWarehouseName = new Label();
            CbbWarehouseNames = new ComboBox();
            PanelTankCleaningSchedule = new Panel();
            DgvTankCleaningSchedule = new DataGridView();
            PanelHeaderTankCleaningScheduleButton = new Panel();
            LbEditedColumnNumber = new Label();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnEdit = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderTankCleaningSchedule = new Panel();
            LbHeaderStorageCleaningSchedule = new Label();
            PanelSeparation = new Panel();
            PanelCreateCleaningSchedule = new Panel();
            PanelInputCreateCleaningSchedule = new Panel();
            DtpTimeStart = new DateTimePicker();
            DtpTimeEnd = new DateTimePicker();
            CbbStorageName = new ComboBox();
            DtpCleaningScheduleDate = new DateTimePicker();
            LbTimeEnd = new Label();
            LbTimeStart = new Label();
            LbCleaningDay = new Label();
            PanelCreateCleaningScheduleButton = new Panel();
            BtnCreate = new EcosystemApp.GUI.Components.RJButton();
            LbWarehouse = new Label();
            PanelHeaderCreateCleaningSchedule = new Panel();
            LbHeaderCreateCleaningSchedule = new Label();
            PanelTop.SuspendLayout();
            PanelTankCleaningSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTankCleaningSchedule).BeginInit();
            PanelHeaderTankCleaningScheduleButton.SuspendLayout();
            PanelHeaderTankCleaningSchedule.SuspendLayout();
            PanelCreateCleaningSchedule.SuspendLayout();
            PanelInputCreateCleaningSchedule.SuspendLayout();
            PanelCreateCleaningScheduleButton.SuspendLayout();
            PanelHeaderCreateCleaningSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(LbDateEnd);
            PanelTop.Controls.Add(DtpDateEnd);
            PanelTop.Controls.Add(BtnFilter);
            PanelTop.Controls.Add(LbDateStart);
            PanelTop.Controls.Add(DtpDateStart);
            PanelTop.Controls.Add(LbWarehouseName);
            PanelTop.Controls.Add(CbbWarehouseNames);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Margin = new Padding(2, 2, 2, 2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1184, 51);
            PanelTop.TabIndex = 0;
            // 
            // LbDateEnd
            // 
            LbDateEnd.AutoSize = true;
            LbDateEnd.Location = new Point(518, 17);
            LbDateEnd.Name = "LbDateEnd";
            LbDateEnd.Size = new Size(72, 20);
            LbDateEnd.TabIndex = 17;
            LbDateEnd.Text = "Đến ngày";
            // 
            // DtpDateEnd
            // 
            DtpDateEnd.Location = new Point(606, 16);
            DtpDateEnd.Margin = new Padding(2, 2, 2, 2);
            DtpDateEnd.Name = "DtpDateEnd";
            DtpDateEnd.Size = new Size(170, 27);
            DtpDateEnd.TabIndex = 16;
            // 
            // BtnFilter
            // 
            BtnFilter.BackColor = Color.FromArgb(196, 238, 181);
            BtnFilter.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnFilter.BoderSize = 2;
            BtnFilter.BorderColor = Color.Black;
            BtnFilter.BorderRadius = 36;
            BtnFilter.FlatAppearance.BorderSize = 0;
            BtnFilter.FlatStyle = FlatStyle.Flat;
            BtnFilter.ForeColor = Color.Black;
            BtnFilter.Location = new Point(793, 7);
            BtnFilter.Margin = new Padding(2, 2, 2, 2);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(100, 36);
            BtnFilter.TabIndex = 15;
            BtnFilter.Text = "Lọc";
            BtnFilter.TextColor = Color.Black;
            BtnFilter.UseVisualStyleBackColor = false;
            BtnFilter.Click += BtnFilterClick;
            // 
            // LbDateStart
            // 
            LbDateStart.AutoSize = true;
            LbDateStart.Location = new Point(262, 16);
            LbDateStart.Name = "LbDateStart";
            LbDateStart.Size = new Size(62, 20);
            LbDateStart.TabIndex = 14;
            LbDateStart.Text = "Từ ngày";
            // 
            // DtpDateStart
            // 
            DtpDateStart.Location = new Point(329, 14);
            DtpDateStart.Margin = new Padding(2, 2, 2, 2);
            DtpDateStart.Name = "DtpDateStart";
            DtpDateStart.Size = new Size(170, 27);
            DtpDateStart.TabIndex = 13;
            // 
            // LbWarehouseName
            // 
            LbWarehouseName.AutoSize = true;
            LbWarehouseName.Location = new Point(22, 16);
            LbWarehouseName.Name = "LbWarehouseName";
            LbWarehouseName.Size = new Size(60, 20);
            LbWarehouseName.TabIndex = 6;
            LbWarehouseName.Text = "Tên kho";
            // 
            // CbbWarehouseNames
            // 
            CbbWarehouseNames.FormattingEnabled = true;
            CbbWarehouseNames.Location = new Point(88, 13);
            CbbWarehouseNames.Name = "CbbWarehouseNames";
            CbbWarehouseNames.Size = new Size(151, 28);
            CbbWarehouseNames.TabIndex = 5;
            CbbWarehouseNames.SelectedIndexChanged += CbbWarehouseNamesSelectedIndexChanged;
            // 
            // PanelTankCleaningSchedule
            // 
            PanelTankCleaningSchedule.BorderStyle = BorderStyle.FixedSingle;
            PanelTankCleaningSchedule.Controls.Add(DgvTankCleaningSchedule);
            PanelTankCleaningSchedule.Controls.Add(PanelHeaderTankCleaningScheduleButton);
            PanelTankCleaningSchedule.Controls.Add(PanelHeaderTankCleaningSchedule);
            PanelTankCleaningSchedule.Dock = DockStyle.Top;
            PanelTankCleaningSchedule.Location = new Point(0, 51);
            PanelTankCleaningSchedule.Margin = new Padding(2, 2, 2, 2);
            PanelTankCleaningSchedule.Name = "PanelTankCleaningSchedule";
            PanelTankCleaningSchedule.Size = new Size(1184, 346);
            PanelTankCleaningSchedule.TabIndex = 2;
            // 
            // DgvTankCleaningSchedule
            // 
            DgvTankCleaningSchedule.AllowUserToResizeRows = false;
            DgvTankCleaningSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvTankCleaningSchedule.BackgroundColor = Color.White;
            DgvTankCleaningSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTankCleaningSchedule.Dock = DockStyle.Fill;
            DgvTankCleaningSchedule.Location = new Point(0, 41);
            DgvTankCleaningSchedule.Margin = new Padding(2, 2, 2, 2);
            DgvTankCleaningSchedule.Name = "DgvTankCleaningSchedule";
            DgvTankCleaningSchedule.RowHeadersVisible = false;
            DgvTankCleaningSchedule.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvTankCleaningSchedule.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvTankCleaningSchedule.RowTemplate.Height = 45;
            DgvTankCleaningSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTankCleaningSchedule.Size = new Size(1182, 257);
            DgvTankCleaningSchedule.TabIndex = 2;
            // 
            // PanelHeaderTankCleaningScheduleButton
            // 
            PanelHeaderTankCleaningScheduleButton.BackColor = Color.FromArgb(228, 255, 207);
            PanelHeaderTankCleaningScheduleButton.Controls.Add(LbEditedColumnNumber);
            PanelHeaderTankCleaningScheduleButton.Controls.Add(BtnSave);
            PanelHeaderTankCleaningScheduleButton.Controls.Add(BtnDelete);
            PanelHeaderTankCleaningScheduleButton.Controls.Add(BtnEdit);
            PanelHeaderTankCleaningScheduleButton.Dock = DockStyle.Bottom;
            PanelHeaderTankCleaningScheduleButton.Location = new Point(0, 298);
            PanelHeaderTankCleaningScheduleButton.Margin = new Padding(2, 2, 2, 2);
            PanelHeaderTankCleaningScheduleButton.Name = "PanelHeaderTankCleaningScheduleButton";
            PanelHeaderTankCleaningScheduleButton.Size = new Size(1182, 46);
            PanelHeaderTankCleaningScheduleButton.TabIndex = 1;
            // 
            // LbEditedColumnNumber
            // 
            LbEditedColumnNumber.AutoSize = true;
            LbEditedColumnNumber.Location = new Point(27, 12);
            LbEditedColumnNumber.Name = "LbEditedColumnNumber";
            LbEditedColumnNumber.Size = new Size(153, 20);
            LbEditedColumnNumber.TabIndex = 8;
            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa:";
            LbEditedColumnNumber.Visible = false;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.BackColor = Color.FromArgb(196, 238, 181);
            BtnSave.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSave.BoderSize = 2;
            BtnSave.BorderColor = Color.Black;
            BtnSave.BorderRadius = 36;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(1073, 4);
            BtnSave.Margin = new Padding(2, 2, 2, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 36);
            BtnSave.TabIndex = 7;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BoderSize = 2;
            BtnDelete.BorderColor = Color.Black;
            BtnDelete.BorderRadius = 36;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(803, 4);
            BtnDelete.Margin = new Padding(2, 2, 2, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(100, 36);
            BtnDelete.TabIndex = 6;
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
            BtnEdit.BorderRadius = 36;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.Location = new Point(907, 4);
            BtnEdit.Margin = new Padding(2, 2, 2, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(162, 36);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "Cập nhật trạng thái";
            BtnEdit.TextColor = Color.Black;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEditClick;
            // 
            // PanelHeaderTankCleaningSchedule
            // 
            PanelHeaderTankCleaningSchedule.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderTankCleaningSchedule.Controls.Add(LbHeaderStorageCleaningSchedule);
            PanelHeaderTankCleaningSchedule.Dock = DockStyle.Top;
            PanelHeaderTankCleaningSchedule.Location = new Point(0, 0);
            PanelHeaderTankCleaningSchedule.Margin = new Padding(2, 2, 2, 2);
            PanelHeaderTankCleaningSchedule.Name = "PanelHeaderTankCleaningSchedule";
            PanelHeaderTankCleaningSchedule.Size = new Size(1182, 41);
            PanelHeaderTankCleaningSchedule.TabIndex = 0;
            // 
            // LbHeaderStorageCleaningSchedule
            // 
            LbHeaderStorageCleaningSchedule.Anchor = AnchorStyles.Top;
            LbHeaderStorageCleaningSchedule.AutoSize = true;
            LbHeaderStorageCleaningSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderStorageCleaningSchedule.Location = new Point(505, 9);
            LbHeaderStorageCleaningSchedule.Margin = new Padding(2, 0, 2, 0);
            LbHeaderStorageCleaningSchedule.Name = "LbHeaderStorageCleaningSchedule";
            LbHeaderStorageCleaningSchedule.Size = new Size(159, 20);
            LbHeaderStorageCleaningSchedule.TabIndex = 0;
            LbHeaderStorageCleaningSchedule.Text = "Lịch vệ sinh bồn chưa";
            // 
            // PanelSeparation
            // 
            PanelSeparation.Dock = DockStyle.Top;
            PanelSeparation.Location = new Point(0, 397);
            PanelSeparation.Margin = new Padding(2, 2, 2, 2);
            PanelSeparation.Name = "PanelSeparation";
            PanelSeparation.Size = new Size(1184, 18);
            PanelSeparation.TabIndex = 3;
            // 
            // PanelCreateCleaningSchedule
            // 
            PanelCreateCleaningSchedule.Controls.Add(PanelInputCreateCleaningSchedule);
            PanelCreateCleaningSchedule.Dock = DockStyle.Fill;
            PanelCreateCleaningSchedule.Location = new Point(0, 415);
            PanelCreateCleaningSchedule.Margin = new Padding(2, 2, 2, 2);
            PanelCreateCleaningSchedule.Name = "PanelCreateCleaningSchedule";
            PanelCreateCleaningSchedule.Size = new Size(1184, 228);
            PanelCreateCleaningSchedule.TabIndex = 4;
            // 
            // PanelInputCreateCleaningSchedule
            // 
            PanelInputCreateCleaningSchedule.BackColor = Color.FromArgb(228, 255, 207);
            PanelInputCreateCleaningSchedule.BorderStyle = BorderStyle.FixedSingle;
            PanelInputCreateCleaningSchedule.Controls.Add(DtpTimeStart);
            PanelInputCreateCleaningSchedule.Controls.Add(DtpTimeEnd);
            PanelInputCreateCleaningSchedule.Controls.Add(CbbStorageName);
            PanelInputCreateCleaningSchedule.Controls.Add(DtpCleaningScheduleDate);
            PanelInputCreateCleaningSchedule.Controls.Add(LbTimeEnd);
            PanelInputCreateCleaningSchedule.Controls.Add(LbTimeStart);
            PanelInputCreateCleaningSchedule.Controls.Add(LbCleaningDay);
            PanelInputCreateCleaningSchedule.Controls.Add(PanelCreateCleaningScheduleButton);
            PanelInputCreateCleaningSchedule.Controls.Add(LbWarehouse);
            PanelInputCreateCleaningSchedule.Controls.Add(PanelHeaderCreateCleaningSchedule);
            PanelInputCreateCleaningSchedule.Dock = DockStyle.Top;
            PanelInputCreateCleaningSchedule.Location = new Point(0, 0);
            PanelInputCreateCleaningSchedule.Margin = new Padding(2, 2, 2, 2);
            PanelInputCreateCleaningSchedule.Name = "PanelInputCreateCleaningSchedule";
            PanelInputCreateCleaningSchedule.Size = new Size(1184, 230);
            PanelInputCreateCleaningSchedule.TabIndex = 2;
            // 
            // DtpTimeStart
            // 
            DtpTimeStart.Location = new Point(737, 71);
            DtpTimeStart.Margin = new Padding(2, 2, 2, 2);
            DtpTimeStart.Name = "DtpTimeStart";
            DtpTimeStart.Size = new Size(419, 27);
            DtpTimeStart.TabIndex = 18;
            // 
            // DtpTimeEnd
            // 
            DtpTimeEnd.Location = new Point(737, 122);
            DtpTimeEnd.Margin = new Padding(2, 2, 2, 2);
            DtpTimeEnd.Name = "DtpTimeEnd";
            DtpTimeEnd.Size = new Size(419, 27);
            DtpTimeEnd.TabIndex = 17;
            // 
            // CbbStorageName
            // 
            CbbStorageName.FormattingEnabled = true;
            CbbStorageName.Location = new Point(151, 73);
            CbbStorageName.Name = "CbbStorageName";
            CbbStorageName.Size = new Size(419, 28);
            CbbStorageName.TabIndex = 16;
            // 
            // DtpCleaningScheduleDate
            // 
            DtpCleaningScheduleDate.Format = DateTimePickerFormat.Short;
            DtpCleaningScheduleDate.Location = new Point(151, 119);
            DtpCleaningScheduleDate.Margin = new Padding(2, 2, 2, 2);
            DtpCleaningScheduleDate.Name = "DtpCleaningScheduleDate";
            DtpCleaningScheduleDate.Size = new Size(419, 27);
            DtpCleaningScheduleDate.TabIndex = 12;
            // 
            // LbTimeEnd
            // 
            LbTimeEnd.AutoSize = true;
            LbTimeEnd.Location = new Point(606, 123);
            LbTimeEnd.Margin = new Padding(2, 0, 2, 0);
            LbTimeEnd.Name = "LbTimeEnd";
            LbTimeEnd.Size = new Size(127, 20);
            LbTimeEnd.TabIndex = 5;
            LbTimeEnd.Text = "Thời gian kết thúc";
            // 
            // LbTimeStart
            // 
            LbTimeStart.AutoSize = true;
            LbTimeStart.Location = new Point(609, 73);
            LbTimeStart.Margin = new Padding(2, 0, 2, 0);
            LbTimeStart.Name = "LbTimeStart";
            LbTimeStart.Size = new Size(126, 20);
            LbTimeStart.TabIndex = 4;
            LbTimeStart.Text = "Thời gian bắt đầu";
            // 
            // LbCleaningDay
            // 
            LbCleaningDay.AutoSize = true;
            LbCleaningDay.Location = new Point(40, 122);
            LbCleaningDay.Margin = new Padding(2, 0, 2, 0);
            LbCleaningDay.Name = "LbCleaningDay";
            LbCleaningDay.Size = new Size(93, 20);
            LbCleaningDay.TabIndex = 3;
            LbCleaningDay.Text = "Ngày vệ sinh";
            // 
            // PanelCreateCleaningScheduleButton
            // 
            PanelCreateCleaningScheduleButton.Controls.Add(BtnCreate);
            PanelCreateCleaningScheduleButton.Dock = DockStyle.Bottom;
            PanelCreateCleaningScheduleButton.Location = new Point(0, 186);
            PanelCreateCleaningScheduleButton.Margin = new Padding(2, 2, 2, 2);
            PanelCreateCleaningScheduleButton.Name = "PanelCreateCleaningScheduleButton";
            PanelCreateCleaningScheduleButton.Size = new Size(1182, 42);
            PanelCreateCleaningScheduleButton.TabIndex = 2;
            // 
            // BtnCreate
            // 
            BtnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCreate.BackColor = Color.FromArgb(196, 238, 181);
            BtnCreate.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnCreate.BoderSize = 2;
            BtnCreate.BorderColor = Color.Black;
            BtnCreate.BorderRadius = 36;
            BtnCreate.FlatAppearance.BorderSize = 0;
            BtnCreate.FlatStyle = FlatStyle.Flat;
            BtnCreate.ForeColor = Color.Black;
            BtnCreate.Location = new Point(1080, 2);
            BtnCreate.Margin = new Padding(2, 2, 2, 2);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(100, 36);
            BtnCreate.TabIndex = 7;
            BtnCreate.Text = "Tạo";
            BtnCreate.TextColor = Color.Black;
            BtnCreate.UseVisualStyleBackColor = false;
            BtnCreate.Click += BtnCreateClick;
            // 
            // LbWarehouse
            // 
            LbWarehouse.AutoSize = true;
            LbWarehouse.Location = new Point(73, 73);
            LbWarehouse.Margin = new Padding(2, 0, 2, 0);
            LbWarehouse.Name = "LbWarehouse";
            LbWarehouse.Size = new Size(60, 20);
            LbWarehouse.TabIndex = 1;
            LbWarehouse.Text = "Tên kho";
            // 
            // PanelHeaderCreateCleaningSchedule
            // 
            PanelHeaderCreateCleaningSchedule.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderCreateCleaningSchedule.Controls.Add(LbHeaderCreateCleaningSchedule);
            PanelHeaderCreateCleaningSchedule.Dock = DockStyle.Top;
            PanelHeaderCreateCleaningSchedule.Location = new Point(0, 0);
            PanelHeaderCreateCleaningSchedule.Margin = new Padding(2, 2, 2, 2);
            PanelHeaderCreateCleaningSchedule.Name = "PanelHeaderCreateCleaningSchedule";
            PanelHeaderCreateCleaningSchedule.Size = new Size(1182, 42);
            PanelHeaderCreateCleaningSchedule.TabIndex = 0;
            // 
            // LbHeaderCreateCleaningSchedule
            // 
            LbHeaderCreateCleaningSchedule.Anchor = AnchorStyles.Top;
            LbHeaderCreateCleaningSchedule.AutoSize = true;
            LbHeaderCreateCleaningSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderCreateCleaningSchedule.Location = new Point(528, 11);
            LbHeaderCreateCleaningSchedule.Margin = new Padding(2, 0, 2, 0);
            LbHeaderCreateCleaningSchedule.Name = "LbHeaderCreateCleaningSchedule";
            LbHeaderCreateCleaningSchedule.Size = new Size(116, 20);
            LbHeaderCreateCleaningSchedule.TabIndex = 1;
            LbHeaderCreateCleaningSchedule.Text = "Tạo lịch vệ sinh";
            // 
            // TankCleaningScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 643);
            Controls.Add(PanelCreateCleaningSchedule);
            Controls.Add(PanelSeparation);
            Controls.Add(PanelTankCleaningSchedule);
            Controls.Add(PanelTop);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TankCleaningScheduleForm";
            Text = "TankCleaningScheduleForm";
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            PanelTankCleaningSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvTankCleaningSchedule).EndInit();
            PanelHeaderTankCleaningScheduleButton.ResumeLayout(false);
            PanelHeaderTankCleaningScheduleButton.PerformLayout();
            PanelHeaderTankCleaningSchedule.ResumeLayout(false);
            PanelHeaderTankCleaningSchedule.PerformLayout();
            PanelCreateCleaningSchedule.ResumeLayout(false);
            PanelInputCreateCleaningSchedule.ResumeLayout(false);
            PanelInputCreateCleaningSchedule.PerformLayout();
            PanelCreateCleaningScheduleButton.ResumeLayout(false);
            PanelHeaderCreateCleaningSchedule.ResumeLayout(false);
            PanelHeaderCreateCleaningSchedule.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Panel PanelTankCleaningSchedule;
        private DataGridView DgvTankCleaningSchedule;
        private Panel PanelHeaderTankCleaningScheduleButton;
        private Panel PanelHeaderTankCleaningSchedule;
        private Label LbHeaderStorageCleaningSchedule;
        private Components.RJButton BtnEdit;
        private Panel PanelSeparation;
        private Panel PanelCreateCleaningSchedule;
        private Panel PanelInputCreateCleaningSchedule;
        //private TextBox textBox3;
        private Label LbWarehouseName;
        private Label LbTimeEnd;
        private Label LbTimeStart;
        private Label LbCleaningDay;
        private Panel PanelCreateCleaningScheduleButton;
        private Components.RJButton BtnCreate;
        private Label LbWarehouse;
        private DateTimePicker DtpCleaningScheduleDate;
        //private TextBox textBox5;
        private DateTimePicker DtpTimeStart;
        private DateTimePicker DtpTimeEnd;
        private ComboBox CbbStorageName;
        private ComboBox CbbWarehouseNames;
        private Components.RJButton BtnDelete;
        private Components.RJButton BtnFilter;
        private Label LbDateStart;
        private DateTimePicker DtpDateStart;
        private Label LbDateEnd;
        private DateTimePicker DtpDateEnd;
        private Components.RJButton BtnSave;
        private Label LbEditedColumnNumber;
        private Panel PanelHeaderCreateCleaningSchedule;
        private Label LbHeaderCreateCleaningSchedule;
    }
}