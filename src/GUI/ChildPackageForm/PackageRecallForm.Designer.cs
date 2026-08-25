namespace EcosystemApp.GUI.ChildPackageForm
{
    partial class PackageRecallForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BtnAdd = new EcosystemApp.GUI.Components.RJButton();
            TbPackageID = new TextBox();
            LbPackageID = new Label();
            PanelHeaderPackingRecall = new Panel();
            LbHeaderPackingRecall = new Label();
            PanelInputPackageID = new Panel();
            Status = new Label();
            CbbStatus = new ComboBox();
            PanelButton = new Panel();
            BtnClose = new EcosystemApp.GUI.Components.RJButton();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderPackingRecallList = new Panel();
            LbHeaderPackingRecallList = new Label();
            DgvPackingRecallList = new DataGridView();
            PanelHeaderPackingRecall.SuspendLayout();
            PanelInputPackageID.SuspendLayout();
            PanelButton.SuspendLayout();
            PanelHeaderPackingRecallList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPackingRecallList).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(196, 238, 181);
            BtnAdd.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAdd.BoderSize = 1;
            BtnAdd.BorderColor = Color.Black;
            BtnAdd.BorderRadius = 20;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(772, 10);
            BtnAdd.Margin = new Padding(2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(101, 34);
            BtnAdd.TabIndex = 8;
            BtnAdd.Text = "Thêm";
            BtnAdd.TextColor = Color.Black;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAddClick;
            // 
            // TbPackageID
            // 
            TbPackageID.BorderStyle = BorderStyle.FixedSingle;
            TbPackageID.Location = new Point(130, 12);
            TbPackageID.Margin = new Padding(2);
            TbPackageID.Name = "TbPackageID";
            TbPackageID.Size = new Size(210, 27);
            TbPackageID.TabIndex = 7;
            // 
            // LbPackageID
            // 
            LbPackageID.AutoSize = true;
            LbPackageID.Location = new Point(8, 14);
            LbPackageID.Margin = new Padding(2, 0, 2, 0);
            LbPackageID.Name = "LbPackageID";
            LbPackageID.Size = new Size(118, 20);
            LbPackageID.TabIndex = 6;
            LbPackageID.Text = "Mã Serial bao bì";
            // 
            // PanelHeaderPackingRecall
            // 
            PanelHeaderPackingRecall.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeaderPackingRecall.Controls.Add(LbHeaderPackingRecall);
            PanelHeaderPackingRecall.Dock = DockStyle.Top;
            PanelHeaderPackingRecall.ForeColor = Color.White;
            PanelHeaderPackingRecall.Location = new Point(0, 0);
            PanelHeaderPackingRecall.Margin = new Padding(2);
            PanelHeaderPackingRecall.Name = "PanelHeaderPackingRecall";
            PanelHeaderPackingRecall.Size = new Size(884, 34);
            PanelHeaderPackingRecall.TabIndex = 9;
            // 
            // LbHeaderPackingRecall
            // 
            LbHeaderPackingRecall.Anchor = AnchorStyles.Top;
            LbHeaderPackingRecall.AutoSize = true;
            LbHeaderPackingRecall.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderPackingRecall.Location = new Point(344, 6);
            LbHeaderPackingRecall.Margin = new Padding(2, 0, 2, 0);
            LbHeaderPackingRecall.Name = "LbHeaderPackingRecall";
            LbHeaderPackingRecall.Size = new Size(207, 20);
            LbHeaderPackingRecall.TabIndex = 9;
            LbHeaderPackingRecall.Text = "GHI NHẬN THU HỒI BAO BÌ";
            // 
            // PanelInputPackageID
            // 
            PanelInputPackageID.Controls.Add(Status);
            PanelInputPackageID.Controls.Add(CbbStatus);
            PanelInputPackageID.Controls.Add(TbPackageID);
            PanelInputPackageID.Controls.Add(LbPackageID);
            PanelInputPackageID.Controls.Add(BtnAdd);
            PanelInputPackageID.Dock = DockStyle.Top;
            PanelInputPackageID.Location = new Point(0, 34);
            PanelInputPackageID.Margin = new Padding(2);
            PanelInputPackageID.Name = "PanelInputPackageID";
            PanelInputPackageID.Size = new Size(884, 62);
            PanelInputPackageID.TabIndex = 10;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(403, 16);
            Status.Name = "Status";
            Status.Size = new Size(75, 20);
            Status.TabIndex = 12;
            Status.Text = "Trạng thái";
            // 
            // CbbStatus
            // 
            CbbStatus.FormattingEnabled = true;
            CbbStatus.Location = new Point(484, 12);
            CbbStatus.Name = "CbbStatus";
            CbbStatus.Size = new Size(210, 28);
            CbbStatus.TabIndex = 11;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnClose);
            PanelButton.Controls.Add(BtnDelete);
            PanelButton.Controls.Add(BtnSave);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 389);
            PanelButton.Margin = new Padding(2);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(884, 39);
            PanelButton.TabIndex = 11;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.FromArgb(196, 238, 181);
            BtnClose.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnClose.BoderSize = 2;
            BtnClose.BorderColor = Color.Black;
            BtnClose.BorderRadius = 35;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.Black;
            BtnClose.Location = new Point(592, 0);
            BtnClose.Margin = new Padding(2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 35);
            BtnClose.TabIndex = 11;
            BtnClose.Text = "Đóng";
            BtnClose.TextColor = Color.Black;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnCloseClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BoderSize = 2;
            BtnDelete.BorderColor = Color.Black;
            BtnDelete.BorderRadius = 35;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(690, 2);
            BtnDelete.Margin = new Padding(2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 35);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "Xóa";
            BtnDelete.TextColor = Color.Black;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDeleteClick;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.BackColor = Color.FromArgb(196, 238, 181);
            BtnSave.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSave.BoderSize = 2;
            BtnSave.BorderColor = Color.Black;
            BtnSave.BorderRadius = 35;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(788, 2);
            BtnSave.Margin = new Padding(2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 35);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // PanelHeaderPackingRecallList
            // 
            PanelHeaderPackingRecallList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackingRecallList.Controls.Add(LbHeaderPackingRecallList);
            PanelHeaderPackingRecallList.Dock = DockStyle.Top;
            PanelHeaderPackingRecallList.Location = new Point(0, 96);
            PanelHeaderPackingRecallList.Margin = new Padding(2);
            PanelHeaderPackingRecallList.Name = "PanelHeaderPackingRecallList";
            PanelHeaderPackingRecallList.Size = new Size(884, 31);
            PanelHeaderPackingRecallList.TabIndex = 12;
            // 
            // LbHeaderPackingRecallList
            // 
            LbHeaderPackingRecallList.Anchor = AnchorStyles.Top;
            LbHeaderPackingRecallList.AutoSize = true;
            LbHeaderPackingRecallList.Location = new Point(358, 2);
            LbHeaderPackingRecallList.Margin = new Padding(2, 0, 2, 0);
            LbHeaderPackingRecallList.Name = "LbHeaderPackingRecallList";
            LbHeaderPackingRecallList.Size = new Size(174, 20);
            LbHeaderPackingRecallList.TabIndex = 10;
            LbHeaderPackingRecallList.Text = "Danh sách bao bì thu hồi";
            // 
            // DgvPackingRecallList
            // 
            DgvPackingRecallList.AllowUserToResizeRows = false;
            DgvPackingRecallList.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvPackingRecallList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPackingRecallList.Dock = DockStyle.Fill;
            DgvPackingRecallList.Location = new Point(0, 127);
            DgvPackingRecallList.Margin = new Padding(2);
            DgvPackingRecallList.Name = "DgvPackingRecallList";
            DgvPackingRecallList.RowHeadersVisible = false;
            DgvPackingRecallList.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(248, 255, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DgvPackingRecallList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DgvPackingRecallList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPackingRecallList.Size = new Size(884, 262);
            DgvPackingRecallList.TabIndex = 13;
            // 
            // PackageRecallForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(884, 428);
            Controls.Add(DgvPackingRecallList);
            Controls.Add(PanelHeaderPackingRecallList);
            Controls.Add(PanelButton);
            Controls.Add(PanelInputPackageID);
            Controls.Add(PanelHeaderPackingRecall);
            Margin = new Padding(2);
            Name = "PackageRecallForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PackageRecallForm";
            PanelHeaderPackingRecall.ResumeLayout(false);
            PanelHeaderPackingRecall.PerformLayout();
            PanelInputPackageID.ResumeLayout(false);
            PanelInputPackageID.PerformLayout();
            PanelButton.ResumeLayout(false);
            PanelHeaderPackingRecallList.ResumeLayout(false);
            PanelHeaderPackingRecallList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPackingRecallList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private EcosystemApp.GUI.Components.RJButton BtnAdd;
        private TextBox TbPackageID;
        private Label LbPackageID;
        private Panel PanelHeaderPackingRecall;
        private Panel PanelInputPackageID;
        private Panel PanelButton;
        private EcosystemApp.GUI.Components.RJButton BtnSave;
        private Panel PanelHeaderPackingRecallList;
        private DataGridView DgvPackingRecallList;
        private Label LbHeaderPackingRecall;
        private Label LbHeaderPackingRecallList;
        private Components.RJButton BtnDelete;
        private Components.RJButton BtnClose;
        private Label Status;
        private ComboBox CbbStatus;
    }
}