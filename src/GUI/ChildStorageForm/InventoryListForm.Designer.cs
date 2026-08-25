namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class InventoryListForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PanelTop = new Panel();
            CbbWarehouseNames = new ComboBox();
            LbWarehouseName = new Label();
            BtnPrevPage = new EcosystemApp.GUI.Components.RJButton();
            LbPageInfo = new Label();
            BtnNextPage = new EcosystemApp.GUI.Components.RJButton();
            DgvInventoryList = new DataGridView();
            PanelButton = new Panel();
            PanelHeaderInventoryList = new Panel();
            LbHeaderInventoryList = new Label();
            BtnSearch = new EcosystemApp.GUI.Components.RJButton();
            TbSearch = new TextBox();
            PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvInventoryList).BeginInit();
            PanelButton.SuspendLayout();
            PanelHeaderInventoryList.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(BtnSearch);
            PanelTop.Controls.Add(TbSearch);
            PanelTop.Controls.Add(CbbWarehouseNames);
            PanelTop.Controls.Add(LbWarehouseName);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Margin = new Padding(2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1184, 55);
            PanelTop.TabIndex = 1;
            // 
            // CbbWarehouseNames
            // 
            CbbWarehouseNames.FormattingEnabled = true;
            CbbWarehouseNames.Location = new Point(101, 14);
            CbbWarehouseNames.Name = "CbbWarehouseNames";
            CbbWarehouseNames.Size = new Size(151, 28);
            CbbWarehouseNames.TabIndex = 4;
            CbbWarehouseNames.SelectedIndexChanged += CbbWarehouseNamesSelectedIndexChanged;
            // 
            // LbWarehouseName
            // 
            LbWarehouseName.AutoSize = true;
            LbWarehouseName.Location = new Point(21, 17);
            LbWarehouseName.Name = "LbWarehouseName";
            LbWarehouseName.Size = new Size(60, 20);
            LbWarehouseName.TabIndex = 3;
            LbWarehouseName.Text = "Tên kho";
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
            BtnPrevPage.Location = new Point(0, 11);
            BtnPrevPage.Margin = new Padding(2);
            BtnPrevPage.Name = "BtnPrevPage";
            BtnPrevPage.Size = new Size(68, 25);
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
            LbPageInfo.Location = new Point(71, 12);
            LbPageInfo.Margin = new Padding(2, 0, 2, 0);
            LbPageInfo.Name = "LbPageInfo";
            LbPageInfo.Size = new Size(101, 25);
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
            BtnNextPage.Location = new Point(173, 12);
            BtnNextPage.Margin = new Padding(2);
            BtnNextPage.Name = "BtnNextPage";
            BtnNextPage.Size = new Size(68, 25);
            BtnNextPage.TabIndex = 12;
            BtnNextPage.Text = "→";
            BtnNextPage.TextColor = Color.Black;
            BtnNextPage.UseVisualStyleBackColor = false;
            BtnNextPage.Click += BtnNextPageClick;
            // 
            // DgvInventoryList
            // 
            DgvInventoryList.AllowUserToResizeRows = false;
            DgvInventoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvInventoryList.BackgroundColor = Color.FromArgb(248, 255, 245);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(196, 238, 181);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvInventoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvInventoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInventoryList.Dock = DockStyle.Fill;
            DgvInventoryList.GridColor = Color.Black;
            DgvInventoryList.Location = new Point(0, 102);
            DgvInventoryList.Margin = new Padding(2);
            DgvInventoryList.Name = "DgvInventoryList";
            DgvInventoryList.RowHeadersVisible = false;
            DgvInventoryList.RowHeadersWidth = 82;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DgvInventoryList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DgvInventoryList.RowTemplate.Height = 50;
            DgvInventoryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvInventoryList.Size = new Size(1184, 494);
            DgvInventoryList.TabIndex = 2;
            DgvInventoryList.CellFormatting += DgvProductListCellFormatting;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnNextPage);
            PanelButton.Controls.Add(LbPageInfo);
            PanelButton.Controls.Add(BtnPrevPage);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 596);
            PanelButton.Margin = new Padding(2);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1184, 49);
            PanelButton.TabIndex = 3;
            // 
            // PanelHeaderInventoryList
            // 
            PanelHeaderInventoryList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderInventoryList.Controls.Add(LbHeaderInventoryList);
            PanelHeaderInventoryList.Dock = DockStyle.Top;
            PanelHeaderInventoryList.Location = new Point(0, 55);
            PanelHeaderInventoryList.Margin = new Padding(2);
            PanelHeaderInventoryList.Name = "PanelHeaderInventoryList";
            PanelHeaderInventoryList.Size = new Size(1184, 47);
            PanelHeaderInventoryList.TabIndex = 4;
            // 
            // LbHeaderInventoryList
            // 
            LbHeaderInventoryList.Anchor = AnchorStyles.Top;
            LbHeaderInventoryList.AutoSize = true;
            LbHeaderInventoryList.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderInventoryList.Location = new Point(500, 12);
            LbHeaderInventoryList.Margin = new Padding(2, 0, 2, 0);
            LbHeaderInventoryList.Name = "LbHeaderInventoryList";
            LbHeaderInventoryList.Size = new Size(240, 23);
            LbHeaderInventoryList.TabIndex = 0;
            LbHeaderInventoryList.Text = "Danh sách sản phẩm tồn kho";
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
            BtnSearch.Location = new Point(1069, 8);
            BtnSearch.Margin = new Padding(1);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(113, 39);
            BtnSearch.TabIndex = 6;
            BtnSearch.Text = "Tìm kiếm";
            BtnSearch.TextColor = Color.Black;
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearchClick;
            // 
            // TbSearch
            // 
            TbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbSearch.BorderStyle = BorderStyle.FixedSingle;
            TbSearch.Location = new Point(665, 8);
            TbSearch.Margin = new Padding(2);
            TbSearch.Multiline = true;
            TbSearch.Name = "TbSearch";
            TbSearch.Size = new Size(401, 40);
            TbSearch.TabIndex = 5;
            // 
            // InventoryListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 645);
            Controls.Add(DgvInventoryList);
            Controls.Add(PanelHeaderInventoryList);
            Controls.Add(PanelButton);
            Controls.Add(PanelTop);
            Margin = new Padding(2);
            Name = "InventoryListForm";
            Text = "InventoryListForm";
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvInventoryList).EndInit();
            PanelButton.ResumeLayout(false);
            PanelButton.PerformLayout();
            PanelHeaderInventoryList.ResumeLayout(false);
            PanelHeaderInventoryList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelTop;
        private Components.RJButton BtnPrevPage;
        private Label LbPageInfo;
        private Components.RJButton BtnNextPage;
        private DataGridView DgvInventoryList;
        private Panel PanelButton;
        private ComboBox CbbWarehouseNames;
        private Label LbWarehouseName;
        //private DataGridViewTextBoxColumn productID;
        //private DataGridViewTextBoxColumn productName;
        //private DataGridViewTextBoxColumn quantity;
        //private DataGridViewTextBoxColumn unit;
        //private DataGridViewTextBoxColumn note;
        private Panel PanelHeaderInventoryList;
        private Label LbHeaderInventoryList;
        private Components.RJButton BtnSearch;
        private TextBox TbSearch;
    }
}