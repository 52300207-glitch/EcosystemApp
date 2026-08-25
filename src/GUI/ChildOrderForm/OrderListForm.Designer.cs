namespace EcosystemApp.GUI.ChildOrderForm
{
    partial class OrderListForm
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            PanelFilter = new Panel();
            BtnApplyFilter = new EcosystemApp.GUI.Components.RJButton();
            BtnSearch = new EcosystemApp.GUI.Components.RJButton();
            CbStatus = new ComboBox();
            TbSearch = new TextBox();
            CbFilter = new ComboBox();
            LbStatus = new Label();
            DtpFilter = new DateTimePicker();
            LbFilter = new Label();
            PanelOrderList = new Panel();
            panel5 = new Panel();
            DgvOrderList = new DataGridView();
            PanelShowOrderQuantity = new Panel();
            LbOrderNumber = new Label();
            PanelHeaderOrderList = new Panel();
            LbHeader = new Label();
            PanelButton = new Panel();
            BtnViewDetail = new EcosystemApp.GUI.Components.RJButton();
            BtnExportReport = new EcosystemApp.GUI.Components.RJButton();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            BtnPrevPage = new EcosystemApp.GUI.Components.RJButton();
            LbPageInfo = new Label();
            BtnNextPage = new EcosystemApp.GUI.Components.RJButton();
            BtnExcel = new EcosystemApp.GUI.Components.RJButton();
            PanelFilter.SuspendLayout();
            PanelOrderList.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvOrderList).BeginInit();
            PanelShowOrderQuantity.SuspendLayout();
            PanelHeaderOrderList.SuspendLayout();
            PanelButton.SuspendLayout();
            SuspendLayout();
            // 
            // PanelFilter
            // 
            PanelFilter.BackColor = Color.FromArgb(228, 255, 207);
            PanelFilter.BorderStyle = BorderStyle.FixedSingle;
            PanelFilter.Controls.Add(BtnApplyFilter);
            PanelFilter.Controls.Add(BtnSearch);
            PanelFilter.Controls.Add(CbStatus);
            PanelFilter.Controls.Add(TbSearch);
            PanelFilter.Controls.Add(CbFilter);
            PanelFilter.Controls.Add(LbStatus);
            PanelFilter.Controls.Add(DtpFilter);
            PanelFilter.Controls.Add(LbFilter);
            PanelFilter.Dock = DockStyle.Top;
            PanelFilter.Location = new Point(0, 0);
            PanelFilter.Margin = new Padding(2, 2, 2, 2);
            PanelFilter.Name = "PanelFilter";
            PanelFilter.Size = new Size(1184, 62);
            PanelFilter.TabIndex = 0;
            // 
            // BtnApplyFilter
            // 
            BtnApplyFilter.BackColor = Color.FromArgb(196, 238, 181);
            BtnApplyFilter.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnApplyFilter.BoderSize = 2;
            BtnApplyFilter.BorderColor = Color.Black;
            BtnApplyFilter.BorderRadius = 28;
            BtnApplyFilter.FlatAppearance.BorderSize = 0;
            BtnApplyFilter.FlatStyle = FlatStyle.Flat;
            BtnApplyFilter.ForeColor = Color.Black;
            BtnApplyFilter.Location = new Point(596, 14);
            BtnApplyFilter.Margin = new Padding(2, 2, 2, 2);
            BtnApplyFilter.Name = "BtnApplyFilter";
            BtnApplyFilter.Size = new Size(79, 28);
            BtnApplyFilter.TabIndex = 11;
            BtnApplyFilter.Text = "Áp dụng";
            BtnApplyFilter.TextColor = Color.Black;
            BtnApplyFilter.UseVisualStyleBackColor = false;
            BtnApplyFilter.Click += BtnApplyFilterClick;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.FromArgb(196, 238, 181);
            BtnSearch.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSearch.BoderSize = 2;
            BtnSearch.BorderColor = Color.Black;
            BtnSearch.BorderRadius = 35;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.ForeColor = Color.Black;
            BtnSearch.Location = new Point(1066, 10);
            BtnSearch.Margin = new Padding(2, 2, 2, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(114, 35);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "Tìm kiếm";
            BtnSearch.TextColor = Color.Black;
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearchClick;
            // 
            // CbStatus
            // 
            CbStatus.FormattingEnabled = true;
            CbStatus.Location = new Point(441, 16);
            CbStatus.Name = "CbStatus";
            CbStatus.Size = new Size(151, 28);
            CbStatus.TabIndex = 10;
            // 
            // TbSearch
            // 
            TbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbSearch.BorderStyle = BorderStyle.FixedSingle;
            TbSearch.Location = new Point(737, 10);
            TbSearch.Margin = new Padding(2, 2, 2, 2);
            TbSearch.Multiline = true;
            TbSearch.Name = "TbSearch";
            TbSearch.Size = new Size(326, 36);
            TbSearch.TabIndex = 1;
            // 
            // CbFilter
            // 
            CbFilter.FormattingEnabled = true;
            CbFilter.Location = new Point(65, 16);
            CbFilter.Name = "CbFilter";
            CbFilter.Size = new Size(151, 28);
            CbFilter.TabIndex = 9;
            CbFilter.SelectedIndexChanged += CbFilterSelectedIndexChanged;
            // 
            // LbStatus
            // 
            LbStatus.AutoSize = true;
            LbStatus.Location = new Point(359, 18);
            LbStatus.Margin = new Padding(2, 0, 2, 0);
            LbStatus.Name = "LbStatus";
            LbStatus.Size = new Size(78, 20);
            LbStatus.TabIndex = 8;
            LbStatus.Text = "Trạng thái:";
            // 
            // DtpFilter
            // 
            DtpFilter.Format = DateTimePickerFormat.Short;
            DtpFilter.Location = new Point(221, 16);
            DtpFilter.Margin = new Padding(2, 2, 2, 2);
            DtpFilter.Name = "DtpFilter";
            DtpFilter.Size = new Size(125, 27);
            DtpFilter.TabIndex = 6;
            DtpFilter.Value = new DateTime(2025, 11, 5, 0, 0, 0, 0);
            // 
            // LbFilter
            // 
            LbFilter.AutoSize = true;
            LbFilter.Location = new Point(7, 18);
            LbFilter.Margin = new Padding(2, 0, 2, 0);
            LbFilter.Name = "LbFilter";
            LbFilter.Size = new Size(54, 20);
            LbFilter.TabIndex = 0;
            LbFilter.Text = "Bộ lọc:";
            // 
            // PanelOrderList
            // 
            PanelOrderList.Controls.Add(panel5);
            PanelOrderList.Controls.Add(PanelButton);
            PanelOrderList.Dock = DockStyle.Fill;
            PanelOrderList.Location = new Point(0, 62);
            PanelOrderList.Margin = new Padding(2, 2, 2, 2);
            PanelOrderList.Name = "PanelOrderList";
            PanelOrderList.Size = new Size(1184, 585);
            PanelOrderList.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(DgvOrderList);
            panel5.Controls.Add(PanelShowOrderQuantity);
            panel5.Controls.Add(PanelHeaderOrderList);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1184, 527);
            panel5.TabIndex = 7;
            // 
            // DgvOrderList
            // 
            DgvOrderList.AllowUserToResizeRows = false;
            DgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvOrderList.BackgroundColor = Color.FromArgb(248, 255, 245);
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            DgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            DgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvOrderList.Dock = DockStyle.Fill;
            DgvOrderList.Location = new Point(0, 70);
            DgvOrderList.Margin = new Padding(2, 2, 2, 2);
            DgvOrderList.MultiSelect = false;
            DgvOrderList.Name = "DgvOrderList";
            DgvOrderList.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            DgvOrderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            DgvOrderList.RowHeadersVisible = false;
            DgvOrderList.RowHeadersWidth = 82;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            DgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            DgvOrderList.RowTemplate.Height = 50;
            DgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvOrderList.Size = new Size(1184, 457);
            DgvOrderList.TabIndex = 0;
            // 
            // PanelShowOrderQuantity
            // 
            PanelShowOrderQuantity.BorderStyle = BorderStyle.FixedSingle;
            PanelShowOrderQuantity.Controls.Add(LbOrderNumber);
            PanelShowOrderQuantity.Dock = DockStyle.Top;
            PanelShowOrderQuantity.Location = new Point(0, 40);
            PanelShowOrderQuantity.Margin = new Padding(2, 2, 2, 2);
            PanelShowOrderQuantity.Name = "PanelShowOrderQuantity";
            PanelShowOrderQuantity.Size = new Size(1184, 30);
            PanelShowOrderQuantity.TabIndex = 5;
            // 
            // LbOrderNumber
            // 
            LbOrderNumber.AutoSize = true;
            LbOrderNumber.Location = new Point(7, 2);
            LbOrderNumber.Margin = new Padding(2, 0, 2, 0);
            LbOrderNumber.Name = "LbOrderNumber";
            LbOrderNumber.Size = new Size(139, 20);
            LbOrderNumber.TabIndex = 3;
            LbOrderNumber.Text = "Số lượng đơn hàng:";
            // 
            // PanelHeaderOrderList
            // 
            PanelHeaderOrderList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderOrderList.BorderStyle = BorderStyle.FixedSingle;
            PanelHeaderOrderList.Controls.Add(LbHeader);
            PanelHeaderOrderList.Dock = DockStyle.Top;
            PanelHeaderOrderList.Location = new Point(0, 0);
            PanelHeaderOrderList.Margin = new Padding(2, 2, 2, 2);
            PanelHeaderOrderList.Name = "PanelHeaderOrderList";
            PanelHeaderOrderList.Size = new Size(1184, 40);
            PanelHeaderOrderList.TabIndex = 6;
            // 
            // LbHeader
            // 
            LbHeader.AutoSize = true;
            LbHeader.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeader.Location = new Point(577, 8);
            LbHeader.Margin = new Padding(2, 0, 2, 0);
            LbHeader.Name = "LbHeader";
            LbHeader.Size = new Size(173, 23);
            LbHeader.TabIndex = 4;
            LbHeader.Text = "Danh sách đơn hàng";
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnViewDetail);
            PanelButton.Controls.Add(BtnExcel);
            PanelButton.Controls.Add(BtnExportReport);
            PanelButton.Controls.Add(BtnDelete);
            PanelButton.Controls.Add(BtnPrevPage);
            PanelButton.Controls.Add(LbPageInfo);
            PanelButton.Controls.Add(BtnNextPage);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 527);
            PanelButton.Margin = new Padding(2, 2, 2, 2);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1184, 58);
            PanelButton.TabIndex = 6;
            // 
            // BtnViewDetail
            // 
            BtnViewDetail.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnViewDetail.BackColor = Color.FromArgb(192, 255, 255);
            BtnViewDetail.BackgroundColor = Color.FromArgb(192, 255, 255);
            BtnViewDetail.BoderSize = 2;
            BtnViewDetail.BorderColor = Color.Black;
            BtnViewDetail.BorderRadius = 40;
            BtnViewDetail.FlatAppearance.BorderSize = 0;
            BtnViewDetail.FlatStyle = FlatStyle.Flat;
            BtnViewDetail.ForeColor = Color.Black;
            BtnViewDetail.Location = new Point(615, 7);
            BtnViewDetail.Margin = new Padding(2, 2, 2, 2);
            BtnViewDetail.Name = "BtnViewDetail";
            BtnViewDetail.Size = new Size(116, 44);
            BtnViewDetail.TabIndex = 12;
            BtnViewDetail.Text = "Xem chi tiết";
            BtnViewDetail.TextColor = Color.Black;
            BtnViewDetail.UseVisualStyleBackColor = false;
            BtnViewDetail.Click += BtnViewDetailClick;
            // 
            // BtnExportReport
            // 
            BtnExportReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnExportReport.BackColor = Color.FromArgb(196, 238, 181);
            BtnExportReport.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnExportReport.BoderSize = 2;
            BtnExportReport.BorderColor = Color.Black;
            BtnExportReport.BorderRadius = 40;
            BtnExportReport.FlatAppearance.BorderSize = 0;
            BtnExportReport.FlatStyle = FlatStyle.Flat;
            BtnExportReport.ForeColor = Color.Black;
            BtnExportReport.Location = new Point(1036, 7);
            BtnExportReport.Margin = new Padding(2, 2, 2, 2);
            BtnExportReport.Name = "BtnExportReport";
            BtnExportReport.Size = new Size(137, 44);
            BtnExportReport.TabIndex = 8;
            BtnExportReport.Text = "Xuất báo cáo PDF";
            BtnExportReport.TextColor = Color.Black;
            BtnExportReport.UseVisualStyleBackColor = false;
            BtnExportReport.Click += BtnExportReportClick;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(255, 192, 192);
            BtnDelete.BackgroundColor = Color.FromArgb(255, 192, 192);
            BtnDelete.BoderSize = 2;
            BtnDelete.BorderColor = Color.Black;
            BtnDelete.BorderRadius = 40;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(735, 7);
            BtnDelete.Margin = new Padding(2, 2, 2, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 44);
            BtnDelete.TabIndex = 7;
            BtnDelete.Text = "Xóa đơn";
            BtnDelete.TextColor = Color.Black;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDeleteClick;
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
            BtnPrevPage.Location = new Point(2, 16);
            BtnPrevPage.Margin = new Padding(2, 2, 2, 2);
            BtnPrevPage.Name = "BtnPrevPage";
            BtnPrevPage.Size = new Size(68, 25);
            BtnPrevPage.TabIndex = 9;
            BtnPrevPage.Text = "←";
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
            LbPageInfo.Location = new Point(79, 16);
            LbPageInfo.Margin = new Padding(2, 0, 2, 0);
            LbPageInfo.Name = "LbPageInfo";
            LbPageInfo.Size = new Size(101, 25);
            LbPageInfo.TabIndex = 10;
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
            BtnNextPage.Location = new Point(186, 17);
            BtnNextPage.Margin = new Padding(2, 2, 2, 2);
            BtnNextPage.Name = "BtnNextPage";
            BtnNextPage.Size = new Size(68, 25);
            BtnNextPage.TabIndex = 11;
            BtnNextPage.Text = "→";
            BtnNextPage.TextColor = Color.Black;
            BtnNextPage.UseVisualStyleBackColor = false;
            BtnNextPage.Click += BtnNextPageClick;
            // 
            // BtnExcel
            // 
            BtnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnExcel.BackColor = Color.FromArgb(196, 238, 181);
            BtnExcel.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnExcel.BoderSize = 2;
            BtnExcel.BorderColor = Color.Black;
            BtnExcel.BorderRadius = 40;
            BtnExcel.FlatAppearance.BorderSize = 0;
            BtnExcel.FlatStyle = FlatStyle.Flat;
            BtnExcel.ForeColor = Color.Black;
            BtnExcel.Location = new Point(855, 7);
            BtnExcel.Margin = new Padding(2);
            BtnExcel.Name = "BtnExcel";
            BtnExcel.Size = new Size(177, 44);
            BtnExcel.TabIndex = 8;
            BtnExcel.Text = "Xuất báo cáo Excel";
            BtnExcel.TextColor = Color.Black;
            BtnExcel.UseVisualStyleBackColor = false;
            BtnExcel.Click += BtnExcelClick;
            // 
            // OrderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 647);
            Controls.Add(PanelOrderList);
            Controls.Add(PanelFilter);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrderListForm";
            Text = "DataListForm";
            PanelFilter.ResumeLayout(false);
            PanelFilter.PerformLayout();
            PanelOrderList.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvOrderList).EndInit();
            PanelShowOrderQuantity.ResumeLayout(false);
            PanelShowOrderQuantity.PerformLayout();
            PanelHeaderOrderList.ResumeLayout(false);
            PanelHeaderOrderList.PerformLayout();
            PanelButton.ResumeLayout(false);
            PanelButton.PerformLayout();
            ResumeLayout(false);


        }

        #endregion

        private Panel PanelFilter;
        private Panel PanelOrderList;
        private TextBox TbSearch;
        private DataGridView DgvOrderList;
        private Label LbOrderNumber;
        private Panel PanelShowOrderQuantity;
        private DateTimePicker DtpFilter;
        private Panel panel5;
        private Panel PanelButton;
        private Panel PanelHeaderOrderList;
        private Label LbFilter;
        private Label LbStatus;
        private ComboBox CbStatus;
        private ComboBox CbFilter;
        private Components.RJButton BtnSearch;
        private Components.RJButton BtnApplyFilter;
        private Components.RJButton BtnDelete;
        private Components.RJButton BtnExportReport;
        private EcosystemApp.GUI.Components.RJButton BtnPrevPage;
        private EcosystemApp.GUI.Components.RJButton BtnNextPage;
        private System.Windows.Forms.Label LbPageInfo;
        private Components.RJButton BtnViewDetail;
        private Label LbHeader;
        private Components.RJButton BtnExcel;
    }
}