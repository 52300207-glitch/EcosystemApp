using EcosystemApp.GUI.ChildOrderForm;

namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class ImportExportDetailForm
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
            LbHeaderDetailView = new Label();
            panel1 = new Panel();
            PanelInfoCustomer = new Panel();
            TbNote = new TextBox();
            LbNote = new Label();
            PanelHeaderInfoCustomer = new Panel();
            LbHeader2 = new Label();
            LbInvoiceID = new Label();
            TbInvoiceID = new TextBox();
            TbAddress = new TextBox();
            LbInvoiceDate = new Label();
            LbAddress = new Label();
            TbDate = new TextBox();
            DgvProductListDetail = new DataGridView();
            PanelHeader = new Panel();
            PanelButton = new Panel();
            BtnClose = new EcosystemApp.GUI.Components.RJButton();
            LbTotalPrice = new Label();
            PanelProductList = new Panel();
            PanelHeaderProductList = new Panel();
            LbProductListDetail = new Label();
            panel1.SuspendLayout();
            PanelInfoCustomer.SuspendLayout();
            PanelHeaderInfoCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductListDetail).BeginInit();
            PanelHeader.SuspendLayout();
            PanelButton.SuspendLayout();
            PanelProductList.SuspendLayout();
            PanelHeaderProductList.SuspendLayout();
            SuspendLayout();
            // 
            // LbHeaderDetailView
            // 
            LbHeaderDetailView.Anchor = AnchorStyles.Top;
            LbHeaderDetailView.AutoSize = true;
            LbHeaderDetailView.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderDetailView.ForeColor = Color.White;
            LbHeaderDetailView.Location = new Point(551, 10);
            LbHeaderDetailView.Name = "LbHeaderDetailView";
            LbHeaderDetailView.Size = new Size(229, 37);
            LbHeaderDetailView.TabIndex = 12;
            LbHeaderDetailView.Text = "Chi tiết xuất kho";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PanelInfoCustomer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1324, 360);
            panel1.TabIndex = 15;
            // 
            // PanelInfoCustomer
            // 
            PanelInfoCustomer.BorderStyle = BorderStyle.FixedSingle;
            PanelInfoCustomer.Controls.Add(TbNote);
            PanelInfoCustomer.Controls.Add(LbNote);
            PanelInfoCustomer.Controls.Add(PanelHeaderInfoCustomer);
            PanelInfoCustomer.Controls.Add(LbInvoiceID);
            PanelInfoCustomer.Controls.Add(TbInvoiceID);
            PanelInfoCustomer.Controls.Add(TbAddress);
            PanelInfoCustomer.Controls.Add(LbInvoiceDate);
            PanelInfoCustomer.Controls.Add(LbAddress);
            PanelInfoCustomer.Controls.Add(TbDate);
            PanelInfoCustomer.Dock = DockStyle.Left;
            PanelInfoCustomer.Location = new Point(0, 0);
            PanelInfoCustomer.Name = "PanelInfoCustomer";
            PanelInfoCustomer.Size = new Size(1322, 358);
            PanelInfoCustomer.TabIndex = 21;
            // 
            // TbNote
            // 
            TbNote.Enabled = false;
            TbNote.Location = new Point(286, 240);
            TbNote.Margin = new Padding(5, 5, 5, 5);
            TbNote.Multiline = true;
            TbNote.Name = "TbNote";
            TbNote.Size = new Size(950, 89);
            TbNote.TabIndex = 25;
            // 
            // LbNote
            // 
            LbNote.AutoSize = true;
            LbNote.Location = new Point(32, 245);
            LbNote.Margin = new Padding(5, 0, 5, 0);
            LbNote.Name = "LbNote";
            LbNote.Size = new Size(96, 32);
            LbNote.TabIndex = 24;
            LbNote.Text = "Ghi chú";
            // 
            // PanelHeaderInfoCustomer
            // 
            PanelHeaderInfoCustomer.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderInfoCustomer.Controls.Add(LbHeader2);
            PanelHeaderInfoCustomer.Dock = DockStyle.Top;
            PanelHeaderInfoCustomer.Location = new Point(0, 0);
            PanelHeaderInfoCustomer.Name = "PanelHeaderInfoCustomer";
            PanelHeaderInfoCustomer.Size = new Size(1320, 61);
            PanelHeaderInfoCustomer.TabIndex = 23;
            // 
            // LbHeader2
            // 
            LbHeader2.Anchor = AnchorStyles.Top;
            LbHeader2.AutoSize = true;
            LbHeader2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeader2.Location = new Point(555, 19);
            LbHeader2.Name = "LbHeader2";
            LbHeader2.Size = new Size(222, 32);
            LbHeader2.TabIndex = 22;
            LbHeader2.Text = "Thông tin xuất kho";
            // 
            // LbInvoiceID
            // 
            LbInvoiceID.AutoSize = true;
            LbInvoiceID.Location = new Point(32, 86);
            LbInvoiceID.Name = "LbInvoiceID";
            LbInvoiceID.Size = new Size(168, 32);
            LbInvoiceID.TabIndex = 2;
            LbInvoiceID.Text = "Mã phiếu xuất";
            // 
            // TbInvoiceID
            // 
            TbInvoiceID.BorderStyle = BorderStyle.FixedSingle;
            TbInvoiceID.Enabled = false;
            TbInvoiceID.Location = new Point(286, 83);
            TbInvoiceID.Name = "TbInvoiceID";
            TbInvoiceID.Size = new Size(951, 39);
            TbInvoiceID.TabIndex = 3;
            // 
            // TbAddress
            // 
            TbAddress.BorderStyle = BorderStyle.FixedSingle;
            TbAddress.Enabled = false;
            TbAddress.Location = new Point(286, 165);
            TbAddress.Name = "TbAddress";
            TbAddress.Size = new Size(363, 39);
            TbAddress.TabIndex = 9;
            // 
            // LbInvoiceDate
            // 
            LbInvoiceDate.AutoSize = true;
            LbInvoiceDate.Location = new Point(694, 171);
            LbInvoiceDate.Name = "LbInvoiceDate";
            LbInvoiceDate.Size = new Size(125, 32);
            LbInvoiceDate.TabIndex = 5;
            LbInvoiceDate.Text = "Ngày Xuất";
            // 
            // LbAddress
            // 
            LbAddress.AutoSize = true;
            LbAddress.Location = new Point(32, 179);
            LbAddress.Name = "LbAddress";
            LbAddress.Size = new Size(108, 32);
            LbAddress.TabIndex = 6;
            LbAddress.Text = "Kho xuất";
            // 
            // TbDate
            // 
            TbDate.BorderStyle = BorderStyle.FixedSingle;
            TbDate.Enabled = false;
            TbDate.Location = new Point(852, 168);
            TbDate.Multiline = true;
            TbDate.Name = "TbDate";
            TbDate.Size = new Size(386, 39);
            TbDate.TabIndex = 8;
            // 
            // DgvProductListDetail
            // 
            DgvProductListDetail.AllowUserToResizeRows = false;
            DgvProductListDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductListDetail.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvProductListDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductListDetail.Dock = DockStyle.Fill;
            DgvProductListDetail.Location = new Point(0, 50);
            DgvProductListDetail.Name = "DgvProductListDetail";
            DgvProductListDetail.RowHeadersVisible = false;
            DgvProductListDetail.RowHeadersWidth = 82;
            DgvProductListDetail.Size = new Size(1324, 352);
            DgvProductListDetail.TabIndex = 0;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(86, 142, 89);
            PanelHeader.Controls.Add(LbHeaderDetailView);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1324, 58);
            PanelHeader.TabIndex = 18;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnClose);
            PanelButton.Controls.Add(LbTotalPrice);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 820);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1324, 82);
            PanelButton.TabIndex = 19;
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
            BtnClose.Location = new Point(1172, 8);
            BtnClose.Margin = new Padding(5, 5, 5, 5);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(147, 66);
            BtnClose.TabIndex = 26;
            BtnClose.Text = "Đóng";
            BtnClose.TextColor = Color.Black;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnCloseClick;
            // 
            // LbTotalPrice
            // 
            LbTotalPrice.AutoSize = true;
            LbTotalPrice.Location = new Point(15, 19);
            LbTotalPrice.Margin = new Padding(5, 0, 5, 0);
            LbTotalPrice.Name = "LbTotalPrice";
            LbTotalPrice.Size = new Size(142, 32);
            LbTotalPrice.TabIndex = 19;
            LbTotalPrice.Text = "Tổng tiền: 0";
            // 
            // PanelProductList
            // 
            PanelProductList.Controls.Add(DgvProductListDetail);
            PanelProductList.Controls.Add(PanelHeaderProductList);
            PanelProductList.Dock = DockStyle.Fill;
            PanelProductList.Location = new Point(0, 418);
            PanelProductList.Name = "PanelProductList";
            PanelProductList.Size = new Size(1324, 402);
            PanelProductList.TabIndex = 20;
            // 
            // PanelHeaderProductList
            // 
            PanelHeaderProductList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderProductList.Controls.Add(LbProductListDetail);
            PanelHeaderProductList.Dock = DockStyle.Top;
            PanelHeaderProductList.Location = new Point(0, 0);
            PanelHeaderProductList.Name = "PanelHeaderProductList";
            PanelHeaderProductList.Size = new Size(1324, 50);
            PanelHeaderProductList.TabIndex = 0;
            // 
            // LbProductListDetail
            // 
            LbProductListDetail.Anchor = AnchorStyles.Top;
            LbProductListDetail.AutoSize = true;
            LbProductListDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbProductListDetail.Location = new Point(551, 3);
            LbProductListDetail.Name = "LbProductListDetail";
            LbProductListDetail.Size = new Size(230, 32);
            LbProductListDetail.TabIndex = 22;
            LbProductListDetail.Text = "Danh sách xuất kho";
            // 
            // ImportExportDetailForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1324, 902);
            Controls.Add(PanelProductList);
            Controls.Add(PanelButton);
            Controls.Add(panel1);
            Controls.Add(PanelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ImportExportDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OrderDetailForm";
            panel1.ResumeLayout(false);
            PanelInfoCustomer.ResumeLayout(false);
            PanelInfoCustomer.PerformLayout();
            PanelHeaderInfoCustomer.ResumeLayout(false);
            PanelHeaderInfoCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductListDetail).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            PanelButton.ResumeLayout(false);
            PanelButton.PerformLayout();
            PanelProductList.ResumeLayout(false);
            PanelHeaderProductList.ResumeLayout(false);
            PanelHeaderProductList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LbHeaderDetailView;
        private Panel panel1;
        private DataGridView DgvProductListDetail;
        private Panel PanelHeader;
        private Panel PanelButton;
        private TextBox TbAddress;
        private TextBox TbDate;
        private Label LbAddress;
        private Label LbInvoiceDate;
        private TextBox TbInvoiceID;
        private Label LbInvoiceID;
        private Panel PanelInfoCustomer;
        private Label LbHeader2;
        private Panel PanelProductList;
        private Panel PanelHeaderProductList;
        private Label LbProductListDetail;
        private Panel PanelHeaderInfoCustomer;
        private Label LbTotalPrice;
        private RichTextBox richTextBox1;
        private TextBox TbNote;
        private Label LbNote;
        private Components.RJButton BtnClose;
    }
}