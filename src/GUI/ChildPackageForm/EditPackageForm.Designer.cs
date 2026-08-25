namespace EcosystemApp.GUI.ChildPackageForm
{
    partial class EditPackageForm
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
            LbPackageTypeName = new Label();
            TbPackageTypeName = new TextBox();
            TbMaterial = new TextBox();
            LbMaterial = new Label();
            TbReuseLimit = new TextBox();
            LbReuseLimit = new Label();
            LbEditPackage = new Label();
            PanelInfo = new Panel();
            PanelInfoPackage = new Panel();
            BtnChangeAll = new EcosystemApp.GUI.Components.RJButton();
            BtnClose = new EcosystemApp.GUI.Components.RJButton();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            LbSuggestions = new ListBox();
            TbSerialCode = new TextBox();
            LbSerialCode = new Label();
            PanelHeaderInfoPackage = new Panel();
            LbPackageInformation = new Label();
            TbSellingPrice = new TextBox();
            LbPurchasePrice = new Label();
            PanelHeaderEditPackage = new Panel();
            PanelInfo.SuspendLayout();
            PanelInfoPackage.SuspendLayout();
            PanelHeaderInfoPackage.SuspendLayout();
            PanelHeaderEditPackage.SuspendLayout();
            SuspendLayout();
            // 
            // LbPackageTypeName
            // 
            LbPackageTypeName.AutoSize = true;
            LbPackageTypeName.Location = new Point(37, 61);
            LbPackageTypeName.Name = "LbPackageTypeName";
            LbPackageTypeName.Size = new Size(126, 32);
            LbPackageTypeName.TabIndex = 0;
            LbPackageTypeName.Text = "Tên bao bì";
            // 
            // TbPackageTypeName
            // 
            TbPackageTypeName.BorderStyle = BorderStyle.FixedSingle;
            TbPackageTypeName.Location = new Point(276, 58);
            TbPackageTypeName.Name = "TbPackageTypeName";
            TbPackageTypeName.Size = new Size(407, 39);
            TbPackageTypeName.TabIndex = 1;
            TbPackageTypeName.TextChanged += TbPackageTypeNameTextChanged;
            TbPackageTypeName.Leave += TbPackageTypeNameLeave;
            // 
            // TbMaterial
            // 
            TbMaterial.BorderStyle = BorderStyle.FixedSingle;
            TbMaterial.Location = new Point(276, 118);
            TbMaterial.Name = "TbMaterial";
            TbMaterial.Size = new Size(407, 39);
            TbMaterial.TabIndex = 5;
            // 
            // LbMaterial
            // 
            LbMaterial.AutoSize = true;
            LbMaterial.Location = new Point(37, 118);
            LbMaterial.Name = "LbMaterial";
            LbMaterial.Size = new Size(109, 32);
            LbMaterial.TabIndex = 4;
            LbMaterial.Text = "Chất liệu";
            // 
            // TbReuseLimit
            // 
            TbReuseLimit.BorderStyle = BorderStyle.FixedSingle;
            TbReuseLimit.Location = new Point(276, 178);
            TbReuseLimit.Name = "TbReuseLimit";
            TbReuseLimit.Size = new Size(407, 39);
            TbReuseLimit.TabIndex = 7;
            // 
            // LbReuseLimit
            // 
            LbReuseLimit.AutoSize = true;
            LbReuseLimit.Location = new Point(37, 181);
            LbReuseLimit.Name = "LbReuseLimit";
            LbReuseLimit.Size = new Size(230, 32);
            LbReuseLimit.TabIndex = 6;
            LbReuseLimit.Text = "Giới hạn tái sử dụng";
            // 
            // LbEditPackage
            // 
            LbEditPackage.Anchor = AnchorStyles.Top;
            LbEditPackage.AutoSize = true;
            LbEditPackage.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbEditPackage.ForeColor = Color.White;
            LbEditPackage.Location = new Point(540, 9);
            LbEditPackage.Name = "LbEditPackage";
            LbEditPackage.Size = new Size(230, 37);
            LbEditPackage.TabIndex = 12;
            LbEditPackage.Text = "Chỉnh sửa bao bì";
            // 
            // PanelInfo
            // 
            PanelInfo.BorderStyle = BorderStyle.FixedSingle;
            PanelInfo.Controls.Add(PanelInfoPackage);
            PanelInfo.Dock = DockStyle.Top;
            PanelInfo.Location = new Point(0, 58);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(1324, 360);
            PanelInfo.TabIndex = 15;
            // 
            // PanelInfoPackage
            // 
            PanelInfoPackage.Controls.Add(BtnChangeAll);
            PanelInfoPackage.Controls.Add(BtnClose);
            PanelInfoPackage.Controls.Add(BtnSave);
            PanelInfoPackage.Controls.Add(LbSuggestions);
            PanelInfoPackage.Controls.Add(TbSerialCode);
            PanelInfoPackage.Controls.Add(LbSerialCode);
            PanelInfoPackage.Controls.Add(PanelHeaderInfoPackage);
            PanelInfoPackage.Controls.Add(TbSellingPrice);
            PanelInfoPackage.Controls.Add(LbPackageTypeName);
            PanelInfoPackage.Controls.Add(TbPackageTypeName);
            PanelInfoPackage.Controls.Add(LbMaterial);
            PanelInfoPackage.Controls.Add(TbReuseLimit);
            PanelInfoPackage.Controls.Add(LbReuseLimit);
            PanelInfoPackage.Controls.Add(TbMaterial);
            PanelInfoPackage.Controls.Add(LbPurchasePrice);
            PanelInfoPackage.Dock = DockStyle.Fill;
            PanelInfoPackage.Location = new Point(0, 0);
            PanelInfoPackage.Name = "PanelInfoPackage";
            PanelInfoPackage.Size = new Size(1322, 358);
            PanelInfoPackage.TabIndex = 22;
            // 
            // BtnChangeAll
            // 
            BtnChangeAll.BackColor = Color.FromArgb(196, 238, 181);
            BtnChangeAll.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnChangeAll.BoderSize = 2;
            BtnChangeAll.BorderColor = Color.Black;
            BtnChangeAll.BorderRadius = 40;
            BtnChangeAll.FlatAppearance.BorderSize = 0;
            BtnChangeAll.FlatStyle = FlatStyle.Flat;
            BtnChangeAll.ForeColor = Color.Black;
            BtnChangeAll.Location = new Point(900, 274);
            BtnChangeAll.Name = "BtnChangeAll";
            BtnChangeAll.Size = new Size(239, 67);
            BtnChangeAll.TabIndex = 29;
            BtnChangeAll.Text = "Thay đổi tất cả";
            BtnChangeAll.TextColor = Color.Black;
            BtnChangeAll.UseVisualStyleBackColor = false;
            BtnChangeAll.Click += BtnChangeAllClick;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(196, 238, 181);
            BtnClose.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnClose.BoderSize = 2;
            BtnClose.BorderColor = Color.Black;
            BtnClose.BorderRadius = 40;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.Black;
            BtnClose.Location = new Point(734, 274);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(159, 67);
            BtnClose.TabIndex = 28;
            BtnClose.Text = "Hủy";
            BtnClose.TextColor = Color.Black;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnCloseClick;
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
            BtnSave.Location = new Point(1146, 274);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(159, 67);
            BtnSave.TabIndex = 25;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // LbSuggestions
            // 
            LbSuggestions.FormattingEnabled = true;
            LbSuggestions.Location = new Point(276, 109);
            LbSuggestions.Margin = new Padding(5, 5, 5, 5);
            LbSuggestions.Name = "LbSuggestions";
            LbSuggestions.Size = new Size(405, 164);
            LbSuggestions.TabIndex = 27;
            LbSuggestions.Visible = false;
            LbSuggestions.Click += LbSuggestionsClick;
            // 
            // TbSerialCode
            // 
            TbSerialCode.BorderStyle = BorderStyle.FixedSingle;
            TbSerialCode.Location = new Point(860, 118);
            TbSerialCode.Name = "TbSerialCode";
            TbSerialCode.Size = new Size(424, 39);
            TbSerialCode.TabIndex = 23;
            // 
            // LbSerialCode
            // 
            LbSerialCode.AutoSize = true;
            LbSerialCode.Location = new Point(705, 122);
            LbSerialCode.Name = "LbSerialCode";
            LbSerialCode.Size = new Size(113, 32);
            LbSerialCode.TabIndex = 22;
            LbSerialCode.Text = "Mã Serial";
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
            LbPackageInformation.Location = new Point(550, 2);
            LbPackageInformation.Name = "LbPackageInformation";
            LbPackageInformation.Size = new Size(194, 32);
            LbPackageInformation.TabIndex = 20;
            LbPackageInformation.Text = "Thông tin bao bì";
            // 
            // TbSellingPrice
            // 
            TbSellingPrice.BorderStyle = BorderStyle.FixedSingle;
            TbSellingPrice.Location = new Point(860, 61);
            TbSellingPrice.Name = "TbSellingPrice";
            TbSellingPrice.Size = new Size(424, 39);
            TbSellingPrice.TabIndex = 11;
            // 
            // LbPurchasePrice
            // 
            LbPurchasePrice.AutoSize = true;
            LbPurchasePrice.Location = new Point(705, 61);
            LbPurchasePrice.Name = "LbPurchasePrice";
            LbPurchasePrice.Size = new Size(95, 32);
            LbPurchasePrice.TabIndex = 7;
            LbPurchasePrice.Text = "Giá bán";
            LbPurchasePrice.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PanelHeaderEditPackage
            // 
            PanelHeaderEditPackage.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeaderEditPackage.Controls.Add(LbEditPackage);
            PanelHeaderEditPackage.Dock = DockStyle.Top;
            PanelHeaderEditPackage.Location = new Point(0, 0);
            PanelHeaderEditPackage.Name = "PanelHeaderEditPackage";
            PanelHeaderEditPackage.Size = new Size(1324, 58);
            PanelHeaderEditPackage.TabIndex = 18;
            // 
            // EditPackageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1324, 418);
            Controls.Add(PanelInfo);
            Controls.Add(PanelHeaderEditPackage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditPackageForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditPackageForm";
            PanelInfo.ResumeLayout(false);
            PanelInfoPackage.ResumeLayout(false);
            PanelInfoPackage.PerformLayout();
            PanelHeaderInfoPackage.ResumeLayout(false);
            PanelHeaderInfoPackage.PerformLayout();
            PanelHeaderEditPackage.ResumeLayout(false);
            PanelHeaderEditPackage.PerformLayout();
            ResumeLayout(false);
        }


        private Label LbPackageTypeName;
        private TextBox TbPackageTypeName;
        private TextBox TbMaterial;
        private Label LbMaterial;
        private TextBox TbReuseLimit;
        private Label LbReuseLimit;
        private Label LbEditPackage;
        private Panel PanelInfo;
        private Panel PanelHeaderEditPackage;
        private TextBox TbSellingPrice;
        private Label LbPurchasePrice;
        private Label LbPackageInformation;
        private Panel PanelInfoPackage;
        private Panel PanelHeaderInfoPackage;
        private TextBox TbSerialCode;
        private Label LbSerialCode;
        private Components.RJButton BtnSave;
        private ListBox LbSuggestions;
        private Components.RJButton BtnClose;
        private Components.RJButton BtnChangeAll;
    }
}