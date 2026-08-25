namespace EcosystemApp.GUI.ChildOrderForm
{
    partial class OrderDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailForm));
            LbOrderID = new Label();
            TbOrderID = new TextBox();
            TbOrderDay = new TextBox();
            LbOrderDay = new Label();
            TbStatus = new TextBox();
            LbStatus = new Label();
            LbHeaderDetailView = new Label();
            panel1 = new Panel();
            PanelInfoOrder = new Panel();
            PanelHeaderInfoOrder = new Panel();
            Header2 = new Label();
            TbTransactionType = new TextBox();
            LbTransactionType = new Label();
            PanelInfoCustomer = new Panel();
            PanelHeaderInfoCustomer = new Panel();
            LbHeader2 = new Label();
            LbPhoneNumber = new Label();
            TbPhoneNumber = new TextBox();
            LbCustomerName = new Label();
            TbCustomerName = new TextBox();
            TbAddress = new TextBox();
            LbEmail = new Label();
            LbAddress = new Label();
            TbEmail = new TextBox();
            DgvProductListDetail = new DataGridView();
            PanelHeader = new Panel();
            PanelButton = new Panel();
            LbTotalPrice = new Label();
            BtnClose = new EcosystemApp.GUI.Components.RJButton();
            PanelProductList = new Panel();
            PanelHeaderProductList = new Panel();
            LbProductListDetail = new Label();
            panel1.SuspendLayout();
            PanelInfoOrder.SuspendLayout();
            PanelHeaderInfoOrder.SuspendLayout();
            PanelInfoCustomer.SuspendLayout();
            PanelHeaderInfoCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductListDetail).BeginInit();
            PanelHeader.SuspendLayout();
            PanelButton.SuspendLayout();
            PanelProductList.SuspendLayout();
            PanelHeaderProductList.SuspendLayout();
            SuspendLayout();
            // 
            // LbOrderID
            // 
            LbOrderID.AutoSize = true;
            LbOrderID.Location = new Point(37, 58);
            LbOrderID.Name = "LbOrderID";
            LbOrderID.Size = new Size(158, 32);
            LbOrderID.TabIndex = 0;
            LbOrderID.Text = "Mã đơn hàng";
            // 
            // TbOrderID
            // 
            TbOrderID.BorderStyle = BorderStyle.FixedSingle;
            TbOrderID.Location = new Point(214, 58);
            TbOrderID.Name = "TbOrderID";
            TbOrderID.Size = new Size(424, 39);
            TbOrderID.TabIndex = 1;
            // 
            // TbOrderDay
            // 
            TbOrderDay.BorderStyle = BorderStyle.FixedSingle;
            TbOrderDay.Location = new Point(214, 118);
            TbOrderDay.Name = "TbOrderDay";
            TbOrderDay.Size = new Size(424, 39);
            TbOrderDay.TabIndex = 5;
            // 
            // LbOrderDay
            // 
            LbOrderDay.AutoSize = true;
            LbOrderDay.Location = new Point(80, 120);
            LbOrderDay.Name = "LbOrderDay";
            LbOrderDay.Size = new Size(111, 32);
            LbOrderDay.TabIndex = 4;
            LbOrderDay.Text = "Ngày đặt";
            // 
            // TbStatus
            // 
            TbStatus.BorderStyle = BorderStyle.FixedSingle;
            TbStatus.Location = new Point(214, 178);
            TbStatus.Name = "TbStatus";
            TbStatus.Size = new Size(424, 39);
            TbStatus.TabIndex = 7;
            // 
            // LbStatus
            // 
            LbStatus.AutoSize = true;
            LbStatus.Location = new Point(80, 179);
            LbStatus.Name = "LbStatus";
            LbStatus.Size = new Size(120, 32);
            LbStatus.TabIndex = 6;
            LbStatus.Text = "Trạng thái";
            // 
            // LbHeaderDetailView
            // 
            LbHeaderDetailView.Anchor = AnchorStyles.Top;
            LbHeaderDetailView.AutoSize = true;
            LbHeaderDetailView.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderDetailView.ForeColor = Color.White;
            LbHeaderDetailView.Location = new Point(551, 10);
            LbHeaderDetailView.Name = "LbHeaderDetailView";
            LbHeaderDetailView.Size = new Size(238, 37);
            LbHeaderDetailView.TabIndex = 12;
            LbHeaderDetailView.Text = "Chi tiết đơn hàng";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PanelInfoOrder);
            panel1.Controls.Add(PanelInfoCustomer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1324, 360);
            panel1.TabIndex = 15;
            // 
            // PanelInfoOrder
            // 
            PanelInfoOrder.Controls.Add(PanelHeaderInfoOrder);
            PanelInfoOrder.Controls.Add(TbTransactionType);
            PanelInfoOrder.Controls.Add(LbOrderID);
            PanelInfoOrder.Controls.Add(TbOrderID);
            PanelInfoOrder.Controls.Add(LbOrderDay);
            PanelInfoOrder.Controls.Add(TbStatus);
            PanelInfoOrder.Controls.Add(LbStatus);
            PanelInfoOrder.Controls.Add(TbOrderDay);
            PanelInfoOrder.Controls.Add(LbTransactionType);
            PanelInfoOrder.Dock = DockStyle.Fill;
            PanelInfoOrder.Location = new Point(672, 0);
            PanelInfoOrder.Name = "PanelInfoOrder";
            PanelInfoOrder.Size = new Size(650, 358);
            PanelInfoOrder.TabIndex = 22;
            // 
            // PanelHeaderInfoOrder
            // 
            PanelHeaderInfoOrder.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderInfoOrder.Controls.Add(Header2);
            PanelHeaderInfoOrder.Dock = DockStyle.Top;
            PanelHeaderInfoOrder.Location = new Point(0, 0);
            PanelHeaderInfoOrder.Name = "PanelHeaderInfoOrder";
            PanelHeaderInfoOrder.Size = new Size(650, 50);
            PanelHeaderInfoOrder.TabIndex = 21;
            // 
            // Header2
            // 
            Header2.AutoSize = true;
            Header2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header2.Location = new Point(214, 3);
            Header2.Name = "Header2";
            Header2.Size = new Size(232, 32);
            Header2.TabIndex = 20;
            Header2.Text = "Thông tin đơn hàng";
            // 
            // TbTransactionType
            // 
            TbTransactionType.BorderStyle = BorderStyle.FixedSingle;
            TbTransactionType.Location = new Point(214, 242);
            TbTransactionType.Name = "TbTransactionType";
            TbTransactionType.Size = new Size(424, 39);
            TbTransactionType.TabIndex = 11;
            // 
            // LbTransactionType
            // 
            LbTransactionType.AutoSize = true;
            LbTransactionType.Location = new Point(28, 245);
            LbTransactionType.Name = "LbTransactionType";
            LbTransactionType.Size = new Size(162, 32);
            LbTransactionType.TabIndex = 7;
            LbTransactionType.Text = "Loại giao dịch";
            // 
            // PanelInfoCustomer
            // 
            PanelInfoCustomer.BorderStyle = BorderStyle.FixedSingle;
            PanelInfoCustomer.Controls.Add(PanelHeaderInfoCustomer);
            PanelInfoCustomer.Controls.Add(LbPhoneNumber);
            PanelInfoCustomer.Controls.Add(TbPhoneNumber);
            PanelInfoCustomer.Controls.Add(LbCustomerName);
            PanelInfoCustomer.Controls.Add(TbCustomerName);
            PanelInfoCustomer.Controls.Add(TbAddress);
            PanelInfoCustomer.Controls.Add(LbEmail);
            PanelInfoCustomer.Controls.Add(LbAddress);
            PanelInfoCustomer.Controls.Add(TbEmail);
            PanelInfoCustomer.Dock = DockStyle.Left;
            PanelInfoCustomer.Location = new Point(0, 0);
            PanelInfoCustomer.Name = "PanelInfoCustomer";
            PanelInfoCustomer.Size = new Size(672, 358);
            PanelInfoCustomer.TabIndex = 21;
            // 
            // PanelHeaderInfoCustomer
            // 
            PanelHeaderInfoCustomer.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderInfoCustomer.Controls.Add(LbHeader2);
            PanelHeaderInfoCustomer.Dock = DockStyle.Top;
            PanelHeaderInfoCustomer.Location = new Point(0, 0);
            PanelHeaderInfoCustomer.Name = "PanelHeaderInfoCustomer";
            PanelHeaderInfoCustomer.Size = new Size(670, 48);
            PanelHeaderInfoCustomer.TabIndex = 23;
            // 
            // LbHeader2
            // 
            LbHeader2.AutoSize = true;
            LbHeader2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeader2.Location = new Point(218, 3);
            LbHeader2.Name = "LbHeader2";
            LbHeader2.Size = new Size(253, 32);
            LbHeader2.TabIndex = 22;
            LbHeader2.Text = "Thông tin khách hàng";
            // 
            // LbPhoneNumber
            // 
            LbPhoneNumber.AutoSize = true;
            LbPhoneNumber.Location = new Point(32, 240);
            LbPhoneNumber.Name = "LbPhoneNumber";
            LbPhoneNumber.Size = new Size(156, 32);
            LbPhoneNumber.TabIndex = 4;
            LbPhoneNumber.Text = "Số điện thoại";
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            TbPhoneNumber.Location = new Point(218, 238);
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(408, 39);
            TbPhoneNumber.TabIndex = 10;
            // 
            // LbCustomerName
            // 
            LbCustomerName.AutoSize = true;
            LbCustomerName.Location = new Point(136, 56);
            LbCustomerName.Name = "LbCustomerName";
            LbCustomerName.Size = new Size(52, 32);
            LbCustomerName.TabIndex = 2;
            LbCustomerName.Text = "Tên";
            // 
            // TbCustomerName
            // 
            TbCustomerName.BorderStyle = BorderStyle.FixedSingle;
            TbCustomerName.Location = new Point(218, 54);
            TbCustomerName.Name = "TbCustomerName";
            TbCustomerName.Size = new Size(408, 39);
            TbCustomerName.TabIndex = 3;
            // 
            // TbAddress
            // 
            TbAddress.BorderStyle = BorderStyle.FixedSingle;
            TbAddress.Location = new Point(218, 178);
            TbAddress.Name = "TbAddress";
            TbAddress.Size = new Size(408, 39);
            TbAddress.TabIndex = 9;
            // 
            // LbEmail
            // 
            LbEmail.AutoSize = true;
            LbEmail.Location = new Point(117, 118);
            LbEmail.Name = "LbEmail";
            LbEmail.Size = new Size(71, 32);
            LbEmail.TabIndex = 5;
            LbEmail.Text = "Email";
            // 
            // LbAddress
            // 
            LbAddress.AutoSize = true;
            LbAddress.Location = new Point(101, 179);
            LbAddress.Name = "LbAddress";
            LbAddress.Size = new Size(87, 32);
            LbAddress.TabIndex = 6;
            LbAddress.Text = "Địa chỉ";
            // 
            // TbEmail
            // 
            TbEmail.BorderStyle = BorderStyle.FixedSingle;
            TbEmail.Location = new Point(218, 115);
            TbEmail.Multiline = true;
            TbEmail.Name = "TbEmail";
            TbEmail.Size = new Size(408, 39);
            TbEmail.TabIndex = 8;
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
            PanelButton.Controls.Add(LbTotalPrice);
            PanelButton.Controls.Add(BtnClose);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 820);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1324, 82);
            PanelButton.TabIndex = 19;
            // 
            // LbTotalPrice
            // 
            LbTotalPrice.AutoSize = true;
            LbTotalPrice.Location = new Point(14, 20);
            LbTotalPrice.Margin = new Padding(5, 0, 5, 0);
            LbTotalPrice.Name = "LbTotalPrice";
            LbTotalPrice.Size = new Size(142, 32);
            LbTotalPrice.TabIndex = 19;
            LbTotalPrice.Text = "Tổng tiền: 0";
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
            BtnClose.Location = new Point(1152, 6);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(159, 67);
            BtnClose.TabIndex = 17;
            BtnClose.Text = "Đóng";
            BtnClose.TextColor = Color.Black;
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnCloseClick;
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
            LbProductListDetail.AutoSize = true;
            LbProductListDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbProductListDetail.Location = new Point(549, 3);
            LbProductListDetail.Name = "LbProductListDetail";
            LbProductListDetail.Size = new Size(240, 32);
            LbProductListDetail.TabIndex = 22;
            LbProductListDetail.Text = "Danh sách sản phẩm";
            // 
            // OrderDetailForm
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OrderDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OrderDetailForm";
            Load += OrderDetailFormLoad;
            panel1.ResumeLayout(false);
            PanelInfoOrder.ResumeLayout(false);
            PanelInfoOrder.PerformLayout();
            PanelHeaderInfoOrder.ResumeLayout(false);
            PanelHeaderInfoOrder.PerformLayout();
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

        private Label LbOrderID;
        private TextBox TbOrderID;
        private TextBox TbOrderDay;
        private Label LbOrderDay;
        private TextBox TbStatus;
        private Label LbStatus;
        private Label LbHeaderDetailView;
        private Panel panel1;
        private DataGridView DgvProductListDetail;
        private Panel PanelHeader;
        private Panel PanelButton;
        private TextBox TbTransactionType;
        private TextBox TbPhoneNumber;
        private TextBox TbAddress;
        private TextBox TbEmail;
        private Label LbTransactionType;
        private Label LbAddress;
        private Label LbEmail;
        private Label LbPhoneNumber;
        private TextBox TbCustomerName;
        private Label LbCustomerName;
        private Panel PanelInfoCustomer;
        private Label LbHeader2;
        private Label Header2;
        private Panel PanelProductList;
        private Panel PanelHeaderProductList;
        private Label LbProductListDetail;
        private Panel PanelInfoOrder;
        private Panel PanelHeaderInfoCustomer;
        private Panel PanelHeaderInfoOrder;
        private Label LbTotalPrice;
        private Components.RJButton BtnClose;
    }
}