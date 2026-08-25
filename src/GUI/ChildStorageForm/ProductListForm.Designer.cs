namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class ProductListForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PanelTop = new Panel();
            BtnSearch = new EcosystemApp.GUI.Components.RJButton();
            TbSearch = new TextBox();
            BtnPrevPage = new EcosystemApp.GUI.Components.RJButton();
            LbPageInfo = new Label();
            BtnNextPage = new EcosystemApp.GUI.Components.RJButton();
            DgvProductList = new DataGridView();
            PanelButton = new Panel();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnEdit = new EcosystemApp.GUI.Components.RJButton();
            BtnAddNewProduct = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderProductList = new Panel();
            LbHeaderProductList = new Label();
            PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductList).BeginInit();
            PanelButton.SuspendLayout();
            PanelHeaderProductList.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(BtnSearch);
            PanelTop.Controls.Add(TbSearch);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1924, 94);
            PanelTop.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.FromArgb(196, 238, 181);
            BtnSearch.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSearch.BoderSize = 2;
            BtnSearch.BorderColor = Color.Black;
            BtnSearch.BorderRadius = 39;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.ForeColor = Color.Black;
            BtnSearch.Location = new Point(1739, 13);
            BtnSearch.Margin = new Padding(2, 2, 2, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(184, 62);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Tìm kiếm";
            BtnSearch.TextColor = Color.Black;
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearchClick;
            // 
            // TbSearch
            // 
            TbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbSearch.BorderStyle = BorderStyle.FixedSingle;
            TbSearch.Location = new Point(1082, 13);
            TbSearch.Multiline = true;
            TbSearch.Name = "TbSearch";
            TbSearch.Size = new Size(650, 63);
            TbSearch.TabIndex = 1;
            TbSearch.TextChanged += TbSearchTextChanged;
            // 
            // BtnPrevPage
            // 
            BtnPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnPrevPage.BackColor = Color.FromArgb(196, 238, 181);
            BtnPrevPage.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnPrevPage.BoderSize = 1;
            BtnPrevPage.BorderColor = Color.Black;
            BtnPrevPage.BorderRadius = 25;
            BtnPrevPage.FlatAppearance.BorderSize = 0;
            BtnPrevPage.FlatStyle = FlatStyle.Flat;
            BtnPrevPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnPrevPage.ForeColor = Color.Black;
            BtnPrevPage.Location = new Point(0, 18);
            BtnPrevPage.Name = "BtnPrevPage";
            BtnPrevPage.Size = new Size(110, 40);
            BtnPrevPage.TabIndex = 10;
            BtnPrevPage.Text = "← Trước";
            BtnPrevPage.TextColor = Color.Black;
            BtnPrevPage.UseVisualStyleBackColor = false;
            BtnPrevPage.Click += BtnPrevPageClick;
            // 
            // LbPageInfo
            // 
            LbPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbPageInfo.AutoSize = true;
            LbPageInfo.Font = new Font("Segoe UI", 11F);
            LbPageInfo.ForeColor = Color.Black;
            LbPageInfo.Location = new Point(116, 19);
            LbPageInfo.Name = "LbPageInfo";
            LbPageInfo.Size = new Size(159, 41);
            LbPageInfo.TabIndex = 11;
            LbPageInfo.Text = "Trang 1 / 1";
            LbPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnNextPage
            // 
            BtnNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNextPage.BackColor = Color.FromArgb(196, 238, 181);
            BtnNextPage.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnNextPage.BoderSize = 1;
            BtnNextPage.BorderColor = Color.Black;
            BtnNextPage.BorderRadius = 25;
            BtnNextPage.FlatAppearance.BorderSize = 0;
            BtnNextPage.FlatStyle = FlatStyle.Flat;
            BtnNextPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnNextPage.ForeColor = Color.Black;
            BtnNextPage.Location = new Point(295, 20);
            BtnNextPage.Name = "BtnNextPage";
            BtnNextPage.Size = new Size(110, 40);
            BtnNextPage.TabIndex = 12;
            BtnNextPage.Text = "→";
            BtnNextPage.TextColor = Color.Black;
            BtnNextPage.UseVisualStyleBackColor = false;
            BtnNextPage.Click += BtnNextPageClick;
            // 
            // DgvProductList
            // 
            DgvProductList.AllowUserToResizeRows = false;
            DgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductList.BackgroundColor = Color.FromArgb(248, 255, 245);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 238, 181);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductList.Dock = DockStyle.Fill;
            DgvProductList.GridColor = Color.Black;
            DgvProductList.Location = new Point(0, 169);
            DgvProductList.Name = "DgvProductList";
            DgvProductList.RowHeadersVisible = false;
            DgvProductList.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvProductList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DgvProductList.RowTemplate.Height = 50;
            DgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProductList.Size = new Size(1924, 785);
            DgvProductList.TabIndex = 2;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnDelete);
            PanelButton.Controls.Add(BtnEdit);
            PanelButton.Controls.Add(BtnAddNewProduct);
            PanelButton.Controls.Add(BtnNextPage);
            PanelButton.Controls.Add(LbPageInfo);
            PanelButton.Controls.Add(BtnPrevPage);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 954);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1924, 78);
            PanelButton.TabIndex = 3;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnDelete.BoderSize = 2;
            BtnDelete.BorderColor = Color.Black;
            BtnDelete.BorderRadius = 39;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(1232, 5);
            BtnDelete.Margin = new Padding(2, 2, 2, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(210, 62);
            BtnDelete.TabIndex = 14;
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
            BtnEdit.BorderRadius = 39;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.Location = new Point(1698, 5);
            BtnEdit.Margin = new Padding(2, 2, 2, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(210, 62);
            BtnEdit.TabIndex = 13;
            BtnEdit.Text = "Sửa";
            BtnEdit.TextColor = Color.Black;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEditClick;
            // 
            // BtnAddNewProduct
            // 
            BtnAddNewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddNewProduct.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddNewProduct.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddNewProduct.BoderSize = 2;
            BtnAddNewProduct.BorderColor = Color.Black;
            BtnAddNewProduct.BorderRadius = 39;
            BtnAddNewProduct.FlatAppearance.BorderSize = 0;
            BtnAddNewProduct.FlatStyle = FlatStyle.Flat;
            BtnAddNewProduct.ForeColor = Color.Black;
            BtnAddNewProduct.Location = new Point(1445, 5);
            BtnAddNewProduct.Margin = new Padding(2, 2, 2, 2);
            BtnAddNewProduct.Name = "BtnAddNewProduct";
            BtnAddNewProduct.Size = new Size(250, 62);
            BtnAddNewProduct.TabIndex = 5;
            BtnAddNewProduct.Text = "Thêm sản phẩm";
            BtnAddNewProduct.TextColor = Color.Black;
            BtnAddNewProduct.UseVisualStyleBackColor = false;
            BtnAddNewProduct.Click += BtnAddNewProductClick;
            // 
            // PanelHeaderProductList
            // 
            PanelHeaderProductList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderProductList.Controls.Add(LbHeaderProductList);
            PanelHeaderProductList.Dock = DockStyle.Top;
            PanelHeaderProductList.Location = new Point(0, 94);
            PanelHeaderProductList.Name = "PanelHeaderProductList";
            PanelHeaderProductList.Size = new Size(1924, 75);
            PanelHeaderProductList.TabIndex = 4;
            // 
            // LbHeaderProductList
            // 
            LbHeaderProductList.Anchor = AnchorStyles.Top;
            LbHeaderProductList.AutoSize = true;
            LbHeaderProductList.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderProductList.Location = new Point(899, 19);
            LbHeaderProductList.Name = "LbHeaderProductList";
            LbHeaderProductList.Size = new Size(277, 37);
            LbHeaderProductList.TabIndex = 0;
            LbHeaderProductList.Text = "Danh sách sản phẩm";
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1924, 1032);
            Controls.Add(DgvProductList);
            Controls.Add(PanelHeaderProductList);
            Controls.Add(PanelButton);
            Controls.Add(PanelTop);
            Name = "ProductListForm";
            Text = "ProductListForm";
            Load += ProductListForm_Load;
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductList).EndInit();
            PanelButton.ResumeLayout(false);
            PanelButton.PerformLayout();
            PanelHeaderProductList.ResumeLayout(false);
            PanelHeaderProductList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelTop;
        private Components.RJButton BtnSearch;
        private TextBox TbSearch;
        private Components.RJButton BtnPrevPage;
        private Label LbPageInfo;
        private Components.RJButton BtnNextPage;
        private DataGridView DgvProductList;
        private Panel PanelButton;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn note;
        private Components.RJButton BtnAddNewProduct;
        private Panel PanelHeaderProductList;
        private Label LbHeaderProductList;
        private Components.RJButton BtnEdit;
        private Components.RJButton BtnDelete;
    }
}