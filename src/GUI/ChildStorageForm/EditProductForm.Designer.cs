namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class EditProductForm
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
            PanelHeader = new Panel();
            LbHeaderInfoProduct = new Label();
            PanelInfoProduct = new Panel();
            BtnClose = new EcosystemApp.GUI.Components.RJButton();
            TbSellingPrice = new TextBox();
            LbSellingPrice = new Label();
            BtnEdit = new EcosystemApp.GUI.Components.RJButton();
            TbUnit = new TextBox();
            TbProductName = new TextBox();
            TbProductID = new TextBox();
            LbUnit = new Label();
            LbProductName = new Label();
            LbProductID = new Label();
            PanelHeaderAddNewProduct = new Panel();
            LbHeader = new Label();
            PanelHeader.SuspendLayout();
            PanelInfoProduct.SuspendLayout();
            PanelHeaderAddNewProduct.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeader.Controls.Add(LbHeaderInfoProduct);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 36);
            PanelHeader.Margin = new Padding(2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(769, 31);
            PanelHeader.TabIndex = 0;
            // 
            // LbHeaderInfoProduct
            // 
            LbHeaderInfoProduct.Anchor = AnchorStyles.Top;
            LbHeaderInfoProduct.AutoSize = true;
            LbHeaderInfoProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderInfoProduct.Location = new Point(326, 2);
            LbHeaderInfoProduct.Margin = new Padding(2, 0, 2, 0);
            LbHeaderInfoProduct.Name = "LbHeaderInfoProduct";
            LbHeaderInfoProduct.Size = new Size(149, 20);
            LbHeaderInfoProduct.TabIndex = 0;
            LbHeaderInfoProduct.Text = "Thông tin sản phẩm";
            // 
            // PanelInfoProduct
            // 
            PanelInfoProduct.Controls.Add(BtnClose);
            PanelInfoProduct.Controls.Add(TbSellingPrice);
            PanelInfoProduct.Controls.Add(LbSellingPrice);
            PanelInfoProduct.Controls.Add(BtnEdit);
            PanelInfoProduct.Controls.Add(TbUnit);
            PanelInfoProduct.Controls.Add(TbProductName);
            PanelInfoProduct.Controls.Add(TbProductID);
            PanelInfoProduct.Controls.Add(LbUnit);
            PanelInfoProduct.Controls.Add(LbProductName);
            PanelInfoProduct.Controls.Add(LbProductID);
            PanelInfoProduct.Dock = DockStyle.Top;
            PanelInfoProduct.Location = new Point(0, 67);
            PanelInfoProduct.Margin = new Padding(2);
            PanelInfoProduct.Name = "PanelInfoProduct";
            PanelInfoProduct.Size = new Size(769, 172);
            PanelInfoProduct.TabIndex = 1;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.FromArgb(196, 238, 181);
            BtnClose.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnClose.BoderSize = 2;
            BtnClose.BorderColor = Color.Black;
            BtnClose.BorderRadius = 36;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.Black;
            BtnClose.Location = new Point(554, 132);
            BtnClose.Margin = new Padding(2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(102, 36);
            BtnClose.TabIndex = 11;
            BtnClose.Text = "Đóng";
            BtnClose.TextColor = Color.Black;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnCloseClick;
            // 
            // TbSellingPrice
            // 
            TbSellingPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbSellingPrice.BorderStyle = BorderStyle.FixedSingle;
            TbSellingPrice.Location = new Point(476, 62);
            TbSellingPrice.Margin = new Padding(2);
            TbSellingPrice.Name = "TbSellingPrice";
            TbSellingPrice.Size = new Size(270, 27);
            TbSellingPrice.TabIndex = 10;
            // 
            // LbSellingPrice
            // 
            LbSellingPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSellingPrice.AutoSize = true;
            LbSellingPrice.Location = new Point(411, 64);
            LbSellingPrice.Margin = new Padding(2, 0, 2, 0);
            LbSellingPrice.Name = "LbSellingPrice";
            LbSellingPrice.Size = new Size(60, 20);
            LbSellingPrice.TabIndex = 9;
            LbSellingPrice.Text = "Giá bán";
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
            BtnEdit.Location = new Point(660, 132);
            BtnEdit.Margin = new Padding(2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(102, 36);
            BtnEdit.TabIndex = 8;
            BtnEdit.Text = "Sửa";
            BtnEdit.TextColor = Color.Black;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEditClick;
            // 
            // TbUnit
            // 
            TbUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbUnit.BorderStyle = BorderStyle.FixedSingle;
            TbUnit.Location = new Point(476, 24);
            TbUnit.Margin = new Padding(2);
            TbUnit.Name = "TbUnit";
            TbUnit.Size = new Size(270, 27);
            TbUnit.TabIndex = 7;
            // 
            // TbProductName
            // 
            TbProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbProductName.BorderStyle = BorderStyle.FixedSingle;
            TbProductName.Location = new Point(124, 61);
            TbProductName.Margin = new Padding(2);
            TbProductName.Name = "TbProductName";
            TbProductName.Size = new Size(264, 27);
            TbProductName.TabIndex = 5;
            // 
            // TbProductID
            // 
            TbProductID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbProductID.BorderStyle = BorderStyle.FixedSingle;
            TbProductID.Location = new Point(124, 26);
            TbProductID.Margin = new Padding(2);
            TbProductID.Name = "TbProductID";
            TbProductID.Size = new Size(264, 27);
            TbProductID.TabIndex = 4;
            // 
            // LbUnit
            // 
            LbUnit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbUnit.AutoSize = true;
            LbUnit.Location = new Point(418, 25);
            LbUnit.Margin = new Padding(2, 0, 2, 0);
            LbUnit.Name = "LbUnit";
            LbUnit.Size = new Size(52, 20);
            LbUnit.TabIndex = 3;
            LbUnit.Text = "Đơn vị";
            // 
            // LbProductName
            // 
            LbProductName.AutoSize = true;
            LbProductName.Location = new Point(20, 62);
            LbProductName.Margin = new Padding(2, 0, 2, 0);
            LbProductName.Name = "LbProductName";
            LbProductName.Size = new Size(100, 20);
            LbProductName.TabIndex = 1;
            LbProductName.Text = "Tên sản phẩm";
            // 
            // LbProductID
            // 
            LbProductID.AutoSize = true;
            LbProductID.Location = new Point(20, 27);
            LbProductID.Margin = new Padding(2, 0, 2, 0);
            LbProductID.Name = "LbProductID";
            LbProductID.Size = new Size(98, 20);
            LbProductID.TabIndex = 0;
            LbProductID.Text = "Mã sản phẩm";
            // 
            // PanelHeaderAddNewProduct
            // 
            PanelHeaderAddNewProduct.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeaderAddNewProduct.Controls.Add(LbHeader);
            PanelHeaderAddNewProduct.Dock = DockStyle.Top;
            PanelHeaderAddNewProduct.Location = new Point(0, 0);
            PanelHeaderAddNewProduct.Margin = new Padding(2);
            PanelHeaderAddNewProduct.Name = "PanelHeaderAddNewProduct";
            PanelHeaderAddNewProduct.Size = new Size(769, 36);
            PanelHeaderAddNewProduct.TabIndex = 4;
            // 
            // LbHeader
            // 
            LbHeader.Anchor = AnchorStyles.Top;
            LbHeader.AutoSize = true;
            LbHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeader.ForeColor = Color.White;
            LbHeader.Location = new Point(288, 9);
            LbHeader.Margin = new Padding(2, 0, 2, 0);
            LbHeader.Name = "LbHeader";
            LbHeader.Size = new Size(210, 20);
            LbHeader.TabIndex = 1;
            LbHeader.Text = "Thay đổi thông tin sản phẩm";
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(769, 239);
            Controls.Add(PanelInfoProduct);
            Controls.Add(PanelHeader);
            Controls.Add(PanelHeaderAddNewProduct);
            Margin = new Padding(2);
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thay đổi thông tin sản phẩm";
            Load += ProductEditFormLoad;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            PanelInfoProduct.ResumeLayout(false);
            PanelInfoProduct.PerformLayout();
            PanelHeaderAddNewProduct.ResumeLayout(false);
            PanelHeaderAddNewProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeader;
        private Label LbHeaderInfoProduct;
        private Panel PanelInfoProduct;
        private TextBox TbUnit;
        private TextBox TbProductName;
        private TextBox TbProductID;
        private Label LbUnit;
        private Label LbProductName;
        private Label LbProductID;
        private Components.RJButton BtnEdit;
        private TextBox TbSellingPrice;
        private Label LbSellingPrice;
        private Panel PanelHeaderAddNewProduct;
        private Label LbHeader;
        private Components.RJButton BtnClose;
    }
}