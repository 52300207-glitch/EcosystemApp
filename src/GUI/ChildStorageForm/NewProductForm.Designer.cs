namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class NewProductForm
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
            PanelHeaderInfoProduct = new Panel();
            LbHeaderInfoProduct = new Label();
            PanelInfoProduct = new Panel();
            BtnRefesh = new EcosystemApp.GUI.Components.RJButton();
            TbSellingPrice = new TextBox();
            LbSellingPrice = new Label();
            BtnAddNewProduct = new EcosystemApp.GUI.Components.RJButton();
            TbUnit = new TextBox();
            TbNewProductName = new TextBox();
            TbNewProductID = new TextBox();
            LbUnit = new Label();
            LbNewProductName = new Label();
            LbNewProductID = new Label();
            PanelHeaderNewProductList = new Panel();
            LbHeaderNewProductList = new Label();
            PanelNewProductList = new Panel();
            DgvNewProductList = new DataGridView();
            PanelButton = new Panel();
            BtnDeleteProduct = new EcosystemApp.GUI.Components.RJButton();
            BtnCancel = new EcosystemApp.GUI.Components.RJButton();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderAddNewProduct = new Panel();
            LbHeaderAddNewProduct = new Label();
            PanelHeaderInfoProduct.SuspendLayout();
            PanelInfoProduct.SuspendLayout();
            PanelHeaderNewProductList.SuspendLayout();
            PanelNewProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvNewProductList).BeginInit();
            PanelButton.SuspendLayout();
            PanelHeaderAddNewProduct.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeaderInfoProduct
            // 
            PanelHeaderInfoProduct.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderInfoProduct.Controls.Add(LbHeaderInfoProduct);
            PanelHeaderInfoProduct.Dock = DockStyle.Top;
            PanelHeaderInfoProduct.Location = new Point(0, 36);
            PanelHeaderInfoProduct.Margin = new Padding(2);
            PanelHeaderInfoProduct.Name = "PanelHeaderInfoProduct";
            PanelHeaderInfoProduct.Size = new Size(769, 31);
            PanelHeaderInfoProduct.TabIndex = 0;
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
            PanelInfoProduct.Controls.Add(BtnRefesh);
            PanelInfoProduct.Controls.Add(TbSellingPrice);
            PanelInfoProduct.Controls.Add(LbSellingPrice);
            PanelInfoProduct.Controls.Add(BtnAddNewProduct);
            PanelInfoProduct.Controls.Add(TbUnit);
            PanelInfoProduct.Controls.Add(TbNewProductName);
            PanelInfoProduct.Controls.Add(TbNewProductID);
            PanelInfoProduct.Controls.Add(LbUnit);
            PanelInfoProduct.Controls.Add(LbNewProductName);
            PanelInfoProduct.Controls.Add(LbNewProductID);
            PanelInfoProduct.Dock = DockStyle.Top;
            PanelInfoProduct.Location = new Point(0, 67);
            PanelInfoProduct.Margin = new Padding(2);
            PanelInfoProduct.Name = "PanelInfoProduct";
            PanelInfoProduct.Size = new Size(769, 172);
            PanelInfoProduct.TabIndex = 1;
            // 
            // BtnRefesh
            // 
            BtnRefesh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRefesh.BackColor = Color.FromArgb(196, 238, 181);
            BtnRefesh.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnRefesh.BoderSize = 2;
            BtnRefesh.BorderColor = Color.Black;
            BtnRefesh.BorderRadius = 36;
            BtnRefesh.FlatAppearance.BorderSize = 0;
            BtnRefesh.FlatStyle = FlatStyle.Flat;
            BtnRefesh.ForeColor = Color.Black;
            BtnRefesh.Location = new Point(554, 132);
            BtnRefesh.Margin = new Padding(2);
            BtnRefesh.Name = "BtnRefesh";
            BtnRefesh.Size = new Size(102, 36);
            BtnRefesh.TabIndex = 11;
            BtnRefesh.Text = "Làm mới";
            BtnRefesh.TextColor = Color.Black;
            BtnRefesh.UseVisualStyleBackColor = false;
            BtnRefesh.Click += BtnRefeshClick;
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
            // BtnAddNewProduct
            // 
            BtnAddNewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddNewProduct.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddNewProduct.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddNewProduct.BoderSize = 2;
            BtnAddNewProduct.BorderColor = Color.Black;
            BtnAddNewProduct.BorderRadius = 36;
            BtnAddNewProduct.FlatAppearance.BorderSize = 0;
            BtnAddNewProduct.FlatStyle = FlatStyle.Flat;
            BtnAddNewProduct.ForeColor = Color.Black;
            BtnAddNewProduct.Location = new Point(660, 132);
            BtnAddNewProduct.Margin = new Padding(2);
            BtnAddNewProduct.Name = "BtnAddNewProduct";
            BtnAddNewProduct.Size = new Size(102, 36);
            BtnAddNewProduct.TabIndex = 8;
            BtnAddNewProduct.Text = "Thêm";
            BtnAddNewProduct.TextColor = Color.Black;
            BtnAddNewProduct.UseVisualStyleBackColor = false;
            BtnAddNewProduct.Click += BtnAddNewProductClick;
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
            // TbNewProductName
            // 
            TbNewProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbNewProductName.BorderStyle = BorderStyle.FixedSingle;
            TbNewProductName.Location = new Point(124, 61);
            TbNewProductName.Margin = new Padding(2);
            TbNewProductName.Name = "TbNewProductName";
            TbNewProductName.Size = new Size(264, 27);
            TbNewProductName.TabIndex = 5;
            // 
            // TbNewProductID
            // 
            TbNewProductID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbNewProductID.BorderStyle = BorderStyle.FixedSingle;
            TbNewProductID.Location = new Point(124, 26);
            TbNewProductID.Margin = new Padding(2);
            TbNewProductID.Name = "TbNewProductID";
            TbNewProductID.Size = new Size(264, 27);
            TbNewProductID.TabIndex = 4;
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
            // LbNewProductName
            // 
            LbNewProductName.AutoSize = true;
            LbNewProductName.Location = new Point(20, 62);
            LbNewProductName.Margin = new Padding(2, 0, 2, 0);
            LbNewProductName.Name = "LbNewProductName";
            LbNewProductName.Size = new Size(100, 20);
            LbNewProductName.TabIndex = 1;
            LbNewProductName.Text = "Tên sản phẩm";
            // 
            // LbNewProductID
            // 
            LbNewProductID.AutoSize = true;
            LbNewProductID.Location = new Point(20, 27);
            LbNewProductID.Margin = new Padding(2, 0, 2, 0);
            LbNewProductID.Name = "LbNewProductID";
            LbNewProductID.Size = new Size(98, 20);
            LbNewProductID.TabIndex = 0;
            LbNewProductID.Text = "Mã sản phẩm";
            // 
            // PanelHeaderNewProductList
            // 
            PanelHeaderNewProductList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderNewProductList.Controls.Add(LbHeaderNewProductList);
            PanelHeaderNewProductList.Dock = DockStyle.Top;
            PanelHeaderNewProductList.Location = new Point(0, 239);
            PanelHeaderNewProductList.Margin = new Padding(2);
            PanelHeaderNewProductList.Name = "PanelHeaderNewProductList";
            PanelHeaderNewProductList.Size = new Size(769, 31);
            PanelHeaderNewProductList.TabIndex = 2;
            // 
            // LbHeaderNewProductList
            // 
            LbHeaderNewProductList.Anchor = AnchorStyles.Top;
            LbHeaderNewProductList.AutoSize = true;
            LbHeaderNewProductList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderNewProductList.Location = new Point(322, 2);
            LbHeaderNewProductList.Margin = new Padding(2, 0, 2, 0);
            LbHeaderNewProductList.Name = "LbHeaderNewProductList";
            LbHeaderNewProductList.Size = new Size(184, 20);
            LbHeaderNewProductList.TabIndex = 1;
            LbHeaderNewProductList.Text = "Danh sách sản phẩm mới";
            // 
            // PanelNewProductList
            // 
            PanelNewProductList.Controls.Add(DgvNewProductList);
            PanelNewProductList.Controls.Add(PanelButton);
            PanelNewProductList.Dock = DockStyle.Fill;
            PanelNewProductList.Location = new Point(0, 270);
            PanelNewProductList.Margin = new Padding(2);
            PanelNewProductList.Name = "PanelNewProductList";
            PanelNewProductList.Size = new Size(769, 204);
            PanelNewProductList.TabIndex = 3;
            // 
            // DgvNewProductList
            // 
            DgvNewProductList.AllowUserToResizeRows = false;
            DgvNewProductList.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvNewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNewProductList.Dock = DockStyle.Fill;
            DgvNewProductList.Location = new Point(0, 0);
            DgvNewProductList.Margin = new Padding(2);
            DgvNewProductList.Name = "DgvNewProductList";
            DgvNewProductList.RowHeadersVisible = false;
            DgvNewProductList.RowHeadersWidth = 82;
            DgvNewProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvNewProductList.Size = new Size(769, 161);
            DgvNewProductList.TabIndex = 0;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnDeleteProduct);
            PanelButton.Controls.Add(BtnCancel);
            PanelButton.Controls.Add(BtnSave);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 161);
            PanelButton.Margin = new Padding(2);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(769, 43);
            PanelButton.TabIndex = 1;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteProduct.BackColor = Color.FromArgb(196, 238, 181);
            BtnDeleteProduct.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnDeleteProduct.BoderSize = 2;
            BtnDeleteProduct.BorderColor = Color.Black;
            BtnDeleteProduct.BorderRadius = 36;
            BtnDeleteProduct.FlatAppearance.BorderSize = 0;
            BtnDeleteProduct.FlatStyle = FlatStyle.Flat;
            BtnDeleteProduct.ForeColor = Color.Black;
            BtnDeleteProduct.Location = new Point(448, 4);
            BtnDeleteProduct.Margin = new Padding(2);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(102, 36);
            BtnDeleteProduct.TabIndex = 11;
            BtnDeleteProduct.Text = "Xóa";
            BtnDeleteProduct.TextColor = Color.Black;
            BtnDeleteProduct.UseVisualStyleBackColor = false;
            BtnDeleteProduct.Click += BtnDeleteProductClick;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.BackColor = Color.FromArgb(196, 238, 181);
            BtnCancel.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnCancel.BoderSize = 2;
            BtnCancel.BorderColor = Color.Black;
            BtnCancel.BorderRadius = 36;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(660, 4);
            BtnCancel.Margin = new Padding(2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(102, 36);
            BtnCancel.TabIndex = 10;
            BtnCancel.Text = "Đóng";
            BtnCancel.TextColor = Color.Black;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancelClick;
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
            BtnSave.Location = new Point(554, 4);
            BtnSave.Margin = new Padding(2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(102, 36);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.Black;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSaveClick;
            // 
            // PanelHeaderAddNewProduct
            // 
            PanelHeaderAddNewProduct.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeaderAddNewProduct.Controls.Add(LbHeaderAddNewProduct);
            PanelHeaderAddNewProduct.Dock = DockStyle.Top;
            PanelHeaderAddNewProduct.Location = new Point(0, 0);
            PanelHeaderAddNewProduct.Margin = new Padding(2);
            PanelHeaderAddNewProduct.Name = "PanelHeaderAddNewProduct";
            PanelHeaderAddNewProduct.Size = new Size(769, 36);
            PanelHeaderAddNewProduct.TabIndex = 4;
            // 
            // LbHeaderAddNewProduct
            // 
            LbHeaderAddNewProduct.Anchor = AnchorStyles.Top;
            LbHeaderAddNewProduct.AutoSize = true;
            LbHeaderAddNewProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderAddNewProduct.ForeColor = Color.White;
            LbHeaderAddNewProduct.Location = new Point(311, 6);
            LbHeaderAddNewProduct.Margin = new Padding(2, 0, 2, 0);
            LbHeaderAddNewProduct.Name = "LbHeaderAddNewProduct";
            LbHeaderAddNewProduct.Size = new Size(170, 20);
            LbHeaderAddNewProduct.TabIndex = 1;
            LbHeaderAddNewProduct.Text = "THÊM SẢN PHẨM MỚI";
            // 
            // NewProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(769, 474);
            Controls.Add(PanelNewProductList);
            Controls.Add(PanelHeaderNewProductList);
            Controls.Add(PanelInfoProduct);
            Controls.Add(PanelHeaderInfoProduct);
            Controls.Add(PanelHeaderAddNewProduct);
            Margin = new Padding(2);
            Name = "NewProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm sản phẩm mới";
            PanelHeaderInfoProduct.ResumeLayout(false);
            PanelHeaderInfoProduct.PerformLayout();
            PanelInfoProduct.ResumeLayout(false);
            PanelInfoProduct.PerformLayout();
            PanelHeaderNewProductList.ResumeLayout(false);
            PanelHeaderNewProductList.PerformLayout();
            PanelNewProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvNewProductList).EndInit();
            PanelButton.ResumeLayout(false);
            PanelHeaderAddNewProduct.ResumeLayout(false);
            PanelHeaderAddNewProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeaderInfoProduct;
        private Label LbHeaderInfoProduct;
        private Panel PanelInfoProduct;
        private Panel PanelHeaderNewProductList;
        private Label LbHeaderNewProductList;
        private Panel PanelNewProductList;
        private TextBox TbUnit;
        private TextBox TbNewProductName;
        private TextBox TbNewProductID;
        private Label LbUnit;
        private Label LbNewProductName;
        private Label LbNewProductID;
        private DataGridView DgvNewProductList;
        private Components.RJButton BtnAddNewProduct;
        private TextBox TbSellingPrice;
        private Label LbSellingPrice;
        private Panel PanelButton;
        private Components.RJButton BtnSave;
        private Panel PanelHeaderAddNewProduct;
        private Label LbHeaderAddNewProduct;
        private Components.RJButton BtnRefesh;
        private Components.RJButton BtnDeleteProduct;
        private Components.RJButton BtnCancel;
    }
}