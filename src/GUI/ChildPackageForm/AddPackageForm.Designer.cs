namespace EcosystemApp.GUI.ChildPackageForm
{
    partial class AddPackageForm
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

        #endregion#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbAddPackage = new Label();
            DgvPackagesListDetail = new DataGridView();
            PanelHeaderAddPackage = new Panel();
            PanelButton = new Panel();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnClose = new EcosystemApp.GUI.Components.RJButton();
            PanelPackageList = new Panel();
            PanelHeaderPackageList = new Panel();
            LbNewPackagesList = new Label();
            PanelInfoPackage = new Panel();
            LbPurchasePrice = new Label();
            TbMaterial = new TextBox();
            LbReuseLimit = new Label();
            TbReuseLimit = new TextBox();
            LbMaterial = new Label();
            TbPackageTypeName = new TextBox();
            LbPackageTypeName = new Label();
            TbSellingPrice = new TextBox();
            PanelHeaderInfoPackage = new Panel();
            LbPackageInformation = new Label();
            LbSerialCode = new Label();
            TbSerialCode = new TextBox();
            BtnAdd = new EcosystemApp.GUI.Components.RJButton();
            BtnRefesh = new EcosystemApp.GUI.Components.RJButton();
            LbSuggestions = new ListBox();
            PanelInfo = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvPackagesListDetail).BeginInit();
            PanelHeaderAddPackage.SuspendLayout();
            PanelButton.SuspendLayout();
            PanelPackageList.SuspendLayout();
            PanelHeaderPackageList.SuspendLayout();
            PanelInfoPackage.SuspendLayout();
            PanelHeaderInfoPackage.SuspendLayout();
            PanelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // LbAddPackage
            // 
            LbAddPackage.Anchor = AnchorStyles.Top;
            LbAddPackage.AutoSize = true;
            LbAddPackage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbAddPackage.ForeColor = Color.White;
            LbAddPackage.Location = new Point(551, 10);
            LbAddPackage.Name = "LbAddPackage";
            LbAddPackage.Size = new Size(177, 37);
            LbAddPackage.TabIndex = 12;
            LbAddPackage.Text = "Thêm bao bì";
            // 
            // DgvPackagesListDetail
            // 
            DgvPackagesListDetail.AllowUserToResizeRows = false;
            DgvPackagesListDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPackagesListDetail.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvPackagesListDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPackagesListDetail.Dock = DockStyle.Fill;
            DgvPackagesListDetail.Location = new Point(0, 50);
            DgvPackagesListDetail.Name = "DgvPackagesListDetail";
            DgvPackagesListDetail.RowHeadersVisible = false;
            DgvPackagesListDetail.RowHeadersWidth = 82;
            DgvPackagesListDetail.Size = new Size(1324, 352);
            DgvPackagesListDetail.TabIndex = 0;
            // 
            // PanelHeaderAddPackage
            // 
            PanelHeaderAddPackage.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeaderAddPackage.Controls.Add(LbAddPackage);
            PanelHeaderAddPackage.Dock = DockStyle.Top;
            PanelHeaderAddPackage.Location = new Point(0, 0);
            PanelHeaderAddPackage.Name = "PanelHeaderAddPackage";
            PanelHeaderAddPackage.Size = new Size(1324, 58);
            PanelHeaderAddPackage.TabIndex = 18;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnSave);
            PanelButton.Controls.Add(BtnDelete);
            PanelButton.Controls.Add(BtnClose);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 820);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1324, 82);
            PanelButton.TabIndex = 19;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(196, 238, 181);
            BtnSave.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSave.BoderSize = 2;
            BtnSave.BorderColor = Color.Black;
            BtnSave.BorderRadius = 40;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(1147, 3);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(159, 67);
            BtnSave.TabIndex = 25;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BoderSize = 2;
            BtnDelete.BorderColor = Color.Black;
            BtnDelete.BorderRadius = 40;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(982, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(159, 67);
            BtnDelete.TabIndex = 24;
            BtnDelete.Text = "Xóa";
            BtnDelete.TextColor = Color.Black;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDeleteClick;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(255, 224, 192);
            BtnClose.BackgroundColor = Color.FromArgb(255, 224, 192);
            BtnClose.BoderSize = 2;
            BtnClose.BorderColor = Color.Black;
            BtnClose.BorderRadius = 40;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.Black;
            BtnClose.Location = new Point(816, 3);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(159, 67);
            BtnClose.TabIndex = 17;
            BtnClose.Text = "Đóng";
            BtnClose.TextColor = Color.Black;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnCloseClick;
            // 
            // PanelPackageList
            // 
            PanelPackageList.Controls.Add(DgvPackagesListDetail);
            PanelPackageList.Controls.Add(PanelHeaderPackageList);
            PanelPackageList.Dock = DockStyle.Fill;
            PanelPackageList.Location = new Point(0, 418);
            PanelPackageList.Name = "PanelPackageList";
            PanelPackageList.Size = new Size(1324, 402);
            PanelPackageList.TabIndex = 20;
            // 
            // PanelHeaderPackageList
            // 
            PanelHeaderPackageList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackageList.Controls.Add(LbNewPackagesList);
            PanelHeaderPackageList.Dock = DockStyle.Top;
            PanelHeaderPackageList.Location = new Point(0, 0);
            PanelHeaderPackageList.Name = "PanelHeaderPackageList";
            PanelHeaderPackageList.Size = new Size(1324, 50);
            PanelHeaderPackageList.TabIndex = 0;
            // 
            // LbNewPackagesList
            // 
            LbNewPackagesList.AutoSize = true;
            LbNewPackagesList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNewPackagesList.Location = new Point(549, 3);
            LbNewPackagesList.Name = "LbNewPackagesList";
            LbNewPackagesList.Size = new Size(202, 32);
            LbNewPackagesList.TabIndex = 22;
            LbNewPackagesList.Text = "Danh sách bao bì";
            // 
            // PanelInfoPackage
            // 
            PanelInfoPackage.Controls.Add(LbSuggestions);
            PanelInfoPackage.Controls.Add(BtnRefesh);
            PanelInfoPackage.Controls.Add(BtnAdd);
            PanelInfoPackage.Controls.Add(TbSerialCode);
            PanelInfoPackage.Controls.Add(LbSerialCode);
            PanelInfoPackage.Controls.Add(TbSellingPrice);
            PanelInfoPackage.Controls.Add(LbPackageTypeName);
            PanelInfoPackage.Controls.Add(TbPackageTypeName);
            PanelInfoPackage.Controls.Add(LbMaterial);
            PanelInfoPackage.Controls.Add(TbReuseLimit);
            PanelInfoPackage.Controls.Add(LbReuseLimit);
            PanelInfoPackage.Controls.Add(TbMaterial);
            PanelInfoPackage.Controls.Add(LbPurchasePrice);
            PanelInfoPackage.Dock = DockStyle.Fill;
            PanelInfoPackage.Location = new Point(0, 50);
            PanelInfoPackage.Name = "PanelInfoPackage";
            PanelInfoPackage.Size = new Size(1322, 308);
            PanelInfoPackage.TabIndex = 22;
            // 
            // LbPurchasePrice
            // 
            LbPurchasePrice.AutoSize = true;
            LbPurchasePrice.Location = new Point(705, 17);
            LbPurchasePrice.Name = "LbPurchasePrice";
            LbPurchasePrice.Size = new Size(95, 32);
            LbPurchasePrice.TabIndex = 7;
            LbPurchasePrice.Text = "Giá bán";
            LbPurchasePrice.TextAlign = ContentAlignment.BottomLeft;
            // 
            // TbMaterial
            // 
            TbMaterial.BorderStyle = BorderStyle.FixedSingle;
            TbMaterial.Location = new Point(276, 74);
            TbMaterial.Name = "TbMaterial";
            TbMaterial.Size = new Size(407, 39);
            TbMaterial.TabIndex = 5;
            // 
            // LbReuseLimit
            // 
            LbReuseLimit.AutoSize = true;
            LbReuseLimit.Location = new Point(37, 137);
            LbReuseLimit.Name = "LbReuseLimit";
            LbReuseLimit.Size = new Size(230, 32);
            LbReuseLimit.TabIndex = 6;
            LbReuseLimit.Text = "Giới hạn tái sử dụng";
            // 
            // TbReuseLimit
            // 
            TbReuseLimit.BorderStyle = BorderStyle.FixedSingle;
            TbReuseLimit.Location = new Point(276, 134);
            TbReuseLimit.Name = "TbReuseLimit";
            TbReuseLimit.Size = new Size(407, 39);
            TbReuseLimit.TabIndex = 7;
            // 
            // LbMaterial
            // 
            LbMaterial.AutoSize = true;
            LbMaterial.Location = new Point(37, 74);
            LbMaterial.Name = "LbMaterial";
            LbMaterial.Size = new Size(109, 32);
            LbMaterial.TabIndex = 4;
            LbMaterial.Text = "Chất liệu";
            // 
            // TbPackageTypeName
            // 
            TbPackageTypeName.BorderStyle = BorderStyle.FixedSingle;
            TbPackageTypeName.Location = new Point(276, 14);
            TbPackageTypeName.Name = "TbPackageTypeName";
            TbPackageTypeName.Size = new Size(407, 39);
            TbPackageTypeName.TabIndex = 1;
            TbPackageTypeName.TextChanged += TbPackageTypeNameTextChanged;
            TbPackageTypeName.Leave += TbPackageTypeNameLeave;
            // 
            // LbPackageTypeName
            // 
            LbPackageTypeName.AutoSize = true;
            LbPackageTypeName.Location = new Point(37, 17);
            LbPackageTypeName.Name = "LbPackageTypeName";
            LbPackageTypeName.Size = new Size(126, 32);
            LbPackageTypeName.TabIndex = 0;
            LbPackageTypeName.Text = "Tên bao bì";
            // 
            // TbSellingPrice
            // 
            TbSellingPrice.BorderStyle = BorderStyle.FixedSingle;
            TbSellingPrice.Location = new Point(860, 17);
            TbSellingPrice.Name = "TbSellingPrice";
            TbSellingPrice.Size = new Size(445, 39);
            TbSellingPrice.TabIndex = 11;
            // 
            // PanelHeaderInfoPackage
            // 
            PanelHeaderInfoPackage.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderInfoPackage.Controls.Add(LbPackageInformation);
            PanelHeaderInfoPackage.Dock = DockStyle.Top;
            PanelHeaderInfoPackage.Location = new Point(0, 0);
            PanelHeaderInfoPackage.Name = "PanelHeaderInfoPackage";
            PanelHeaderInfoPackage.Size = new Size(1322, 50);
            PanelHeaderInfoPackage.TabIndex = 21;
            // 
            // LbPackageInformation
            // 
            LbPackageInformation.AutoSize = true;
            LbPackageInformation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPackageInformation.Location = new Point(548, 2);
            LbPackageInformation.Name = "LbPackageInformation";
            LbPackageInformation.Size = new Size(194, 32);
            LbPackageInformation.TabIndex = 20;
            LbPackageInformation.Text = "Thông tin bao bì";
            // 
            // LbSerialCode
            // 
            LbSerialCode.AutoSize = true;
            LbSerialCode.Location = new Point(705, 78);
            LbSerialCode.Name = "LbSerialCode";
            LbSerialCode.Size = new Size(113, 32);
            LbSerialCode.TabIndex = 22;
            LbSerialCode.Text = "Mã Serial";
            // 
            // TbSerialCode
            // 
            TbSerialCode.BorderStyle = BorderStyle.FixedSingle;
            TbSerialCode.Location = new Point(860, 74);
            TbSerialCode.Name = "TbSerialCode";
            TbSerialCode.Size = new Size(445, 39);
            TbSerialCode.TabIndex = 23;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(196, 238, 181);
            BtnAdd.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAdd.BoderSize = 2;
            BtnAdd.BorderColor = Color.Black;
            BtnAdd.BorderRadius = 40;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(1146, 228);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(159, 67);
            BtnAdd.TabIndex = 25;
            BtnAdd.Text = "Thêm";
            BtnAdd.TextColor = Color.Black;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAddClick;
            // 
            // BtnRefesh
            // 
            BtnRefesh.BackColor = Color.FromArgb(196, 238, 181);
            BtnRefesh.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnRefesh.BoderSize = 2;
            BtnRefesh.BorderColor = Color.Black;
            BtnRefesh.BorderRadius = 40;
            BtnRefesh.FlatAppearance.BorderSize = 0;
            BtnRefesh.FlatStyle = FlatStyle.Flat;
            BtnRefesh.ForeColor = Color.Black;
            BtnRefesh.Location = new Point(980, 228);
            BtnRefesh.Name = "BtnRefesh";
            BtnRefesh.Size = new Size(159, 67);
            BtnRefesh.TabIndex = 26;
            BtnRefesh.Text = "Làm mới";
            BtnRefesh.TextColor = Color.Black;
            BtnRefesh.UseVisualStyleBackColor = false;
            BtnRefesh.Click += BtnRefeshClick;
            // 
            // LbSuggestions
            // 
            LbSuggestions.FormattingEnabled = true;
            LbSuggestions.Location = new Point(276, 50);
            LbSuggestions.Margin = new Padding(5);
            LbSuggestions.Name = "LbSuggestions";
            LbSuggestions.Size = new Size(405, 164);
            LbSuggestions.TabIndex = 27;
            LbSuggestions.Visible = false;
            LbSuggestions.Click += LbSuggestionsClick;
            // 
            // PanelInfo
            // 
            PanelInfo.BorderStyle = BorderStyle.FixedSingle;
            PanelInfo.Controls.Add(PanelInfoPackage);
            PanelInfo.Controls.Add(PanelHeaderInfoPackage);
            PanelInfo.Dock = DockStyle.Top;
            PanelInfo.Location = new Point(0, 58);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(1324, 360);
            PanelInfo.TabIndex = 15;
            // 
            // AddPackageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1324, 902);
            Controls.Add(PanelPackageList);
            Controls.Add(PanelButton);
            Controls.Add(PanelInfo);
            Controls.Add(PanelHeaderAddPackage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddPackageForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPackageForm";
            ((System.ComponentModel.ISupportInitialize)DgvPackagesListDetail).EndInit();
            PanelHeaderAddPackage.ResumeLayout(false);
            PanelHeaderAddPackage.PerformLayout();
            PanelButton.ResumeLayout(false);
            PanelPackageList.ResumeLayout(false);
            PanelHeaderPackageList.ResumeLayout(false);
            PanelHeaderPackageList.PerformLayout();
            PanelInfoPackage.ResumeLayout(false);
            PanelInfoPackage.PerformLayout();
            PanelHeaderInfoPackage.ResumeLayout(false);
            PanelHeaderInfoPackage.PerformLayout();
            PanelInfo.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label LbAddPackage;
        private DataGridView DgvPackagesListDetail;
        private Panel PanelHeaderAddPackage;
        private Panel PanelButton;
        private Panel PanelPackageList;
        private Panel PanelHeaderPackageList;
        private Label LbNewPackagesList;
        private Components.RJButton BtnClose;
        private Components.RJButton BtnDelete;
        private Components.RJButton BtnSave;
        private Panel PanelInfoPackage;
        private ListBox LbSuggestions;
        private Components.RJButton BtnRefesh;
        private Components.RJButton BtnAdd;
        private TextBox TbSerialCode;
        private Label LbSerialCode;
        private Panel PanelHeaderInfoPackage;
        private Label LbPackageInformation;
        private TextBox TbSellingPrice;
        private Label LbPackageTypeName;
        private TextBox TbPackageTypeName;
        private Label LbMaterial;
        private TextBox TbReuseLimit;
        private Label LbReuseLimit;
        private TextBox TbMaterial;
        private Label LbPurchasePrice;
        private Panel PanelInfo;
    }
}