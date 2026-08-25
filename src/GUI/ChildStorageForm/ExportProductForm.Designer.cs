namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class ExportProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportProductForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PanelExport = new Panel();
            PanelInputExport = new Panel();
            DgvProductList = new DataGridView();
            productID = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            PanelProductListFooter = new Panel();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            LbTotalCost = new Label();
            PanelInput = new Panel();
            LbSuggestions = new ListBox();
            TbSerialCode = new TextBox();
            BtnExportProduct = new EcosystemApp.GUI.Components.RJButton();
            BtnExportPackage = new EcosystemApp.GUI.Components.RJButton();
            TbProductName = new TextBox();
            BtnAddProduct = new EcosystemApp.GUI.Components.RJButton();
            LbQuantityProduct = new Label();
            LbProductInformation = new Label();
            TbQuantityProduct = new TextBox();
            PanelButtonExport = new Panel();
            BtnCancle = new EcosystemApp.GUI.Components.RJButton();
            BtnConfirm = new EcosystemApp.GUI.Components.RJButton();
            PanelInfoExport = new Panel();
            CbbStorage = new ComboBox();
            LbStorageID = new Label();
            LbHeaderInfoExport = new Label();
            LbExportDay = new Label();
            DtpExport = new DateTimePicker();
            PanelHeaderExportStorage = new Panel();
            LbHeaderExportStorage = new Label();
            PanelExportHistory = new Panel();
            DgvExportHistory = new DataGridView();
            receiptID = new DataGridViewTextBoxColumn();
            receivePlace = new DataGridViewTextBoxColumn();
            exportDay = new DataGridViewTextBoxColumn();
            totalProduct = new DataGridViewTextBoxColumn();
            PanelButtonExportHistory = new Panel();
            BtnViewDetail = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderExportHistory = new Panel();
            LbHeaderExportHistory = new Label();
            PanelSeparation = new Panel();
            PanelExport.SuspendLayout();
            PanelInputExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductList).BeginInit();
            PanelProductListFooter.SuspendLayout();
            PanelInput.SuspendLayout();
            PanelButtonExport.SuspendLayout();
            PanelInfoExport.SuspendLayout();
            PanelHeaderExportStorage.SuspendLayout();
            PanelExportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvExportHistory).BeginInit();
            PanelButtonExportHistory.SuspendLayout();
            PanelHeaderExportHistory.SuspendLayout();
            SuspendLayout();
            // 
            // PanelExport
            // 
            PanelExport.BackColor = Color.FromArgb(228, 255, 207);
            PanelExport.BorderStyle = BorderStyle.FixedSingle;
            PanelExport.Controls.Add(PanelInputExport);
            PanelExport.Controls.Add(PanelButtonExport);
            PanelExport.Controls.Add(PanelInfoExport);
            PanelExport.Dock = DockStyle.Left;
            PanelExport.Location = new Point(0, 52);
            PanelExport.Name = "PanelExport";
            PanelExport.Size = new Size(1034, 1002);
            PanelExport.TabIndex = 0;
            // 
            // PanelInputExport
            // 
            PanelInputExport.Controls.Add(DgvProductList);
            PanelInputExport.Controls.Add(PanelProductListFooter);
            PanelInputExport.Controls.Add(PanelInput);
            PanelInputExport.Dock = DockStyle.Fill;
            PanelInputExport.Location = new Point(0, 335);
            PanelInputExport.Name = "PanelInputExport";
            PanelInputExport.Size = new Size(1032, 599);
            PanelInputExport.TabIndex = 20;
            // 
            // DgvProductList
            // 
            DgvProductList.AllowUserToResizeRows = false;
            DgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductList.BackgroundColor = Color.White;
            DgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductList.Columns.AddRange(new DataGridViewColumn[] { productID, nameProduct, quantity, unit, cost });
            DgvProductList.Dock = DockStyle.Fill;
            DgvProductList.Location = new Point(0, 188);
            DgvProductList.Name = "DgvProductList";
            DgvProductList.RowHeadersVisible = false;
            DgvProductList.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvProductList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProductList.Size = new Size(1032, 350);
            DgvProductList.TabIndex = 14;
            // 
            // productID
            // 
            productID.FillWeight = 107.942085F;
            productID.HeaderText = "Mã sản phẩm";
            productID.MinimumWidth = 10;
            productID.Name = "productID";
            // 
            // nameProduct
            // 
            nameProduct.FillWeight = 112.179489F;
            nameProduct.HeaderText = "Tên sản phẩm";
            nameProduct.MinimumWidth = 10;
            nameProduct.Name = "nameProduct";
            // 
            // quantity
            // 
            quantity.FillWeight = 93.2928F;
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 10;
            quantity.Name = "quantity";
            // 
            // unit
            // 
            unit.FillWeight = 93.2928F;
            unit.HeaderText = "Đơn vị";
            unit.MinimumWidth = 10;
            unit.Name = "unit";
            // 
            // cost
            // 
            cost.FillWeight = 93.2928F;
            cost.HeaderText = "Giá";
            cost.MinimumWidth = 10;
            cost.Name = "cost";
            // 
            // PanelProductListFooter
            // 
            PanelProductListFooter.BorderStyle = BorderStyle.FixedSingle;
            PanelProductListFooter.Controls.Add(BtnDelete);
            PanelProductListFooter.Controls.Add(LbTotalCost);
            PanelProductListFooter.Dock = DockStyle.Bottom;
            PanelProductListFooter.Location = new Point(0, 538);
            PanelProductListFooter.Name = "PanelProductListFooter";
            PanelProductListFooter.Size = new Size(1032, 61);
            PanelProductListFooter.TabIndex = 1;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.FromArgb(228, 255, 207);
            BtnDelete.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnDelete.BoderSize = 0;
            BtnDelete.BorderColor = Color.Red;
            BtnDelete.BorderRadius = 0;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(8, 3);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(62, 54);
            BtnDelete.TabIndex = 21;
            BtnDelete.TextColor = Color.White;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDeleteClick;
            // 
            // LbTotalCost
            // 
            LbTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbTotalCost.AutoSize = true;
            LbTotalCost.Font = new Font("Segoe UI", 9F);
            LbTotalCost.Location = new Point(765, 14);
            LbTotalCost.Name = "LbTotalCost";
            LbTotalCost.Size = new Size(142, 32);
            LbTotalCost.TabIndex = 20;
            LbTotalCost.Text = "Tổng tiền: 0";
            // 
            // PanelInput
            // 
            PanelInput.BorderStyle = BorderStyle.FixedSingle;
            PanelInput.Controls.Add(LbSuggestions);
            PanelInput.Controls.Add(TbSerialCode);
            PanelInput.Controls.Add(BtnExportProduct);
            PanelInput.Controls.Add(BtnExportPackage);
            PanelInput.Controls.Add(TbProductName);
            PanelInput.Controls.Add(BtnAddProduct);
            PanelInput.Controls.Add(LbQuantityProduct);
            PanelInput.Controls.Add(LbProductInformation);
            PanelInput.Controls.Add(TbQuantityProduct);
            PanelInput.Dock = DockStyle.Top;
            PanelInput.Location = new Point(0, 0);
            PanelInput.Name = "PanelInput";
            PanelInput.Size = new Size(1032, 188);
            PanelInput.TabIndex = 2;
            // 
            // LbSuggestions
            // 
            LbSuggestions.FormattingEnabled = true;
            LbSuggestions.Location = new Point(231, 109);
            LbSuggestions.Margin = new Padding(5, 5, 5, 5);
            LbSuggestions.Name = "LbSuggestions";
            LbSuggestions.Size = new Size(308, 164);
            LbSuggestions.TabIndex = 37;
            LbSuggestions.Click += LbSuggestionsClick;
            // 
            // TbSerialCode
            // 
            TbSerialCode.BorderStyle = BorderStyle.FixedSingle;
            TbSerialCode.Location = new Point(231, 58);
            TbSerialCode.Name = "TbSerialCode";
            TbSerialCode.Size = new Size(309, 39);
            TbSerialCode.TabIndex = 36;
            // 
            // BtnExportProduct
            // 
            BtnExportProduct.BackColor = Color.FromArgb(228, 255, 207);
            BtnExportProduct.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnExportProduct.BoderSize = 0;
            BtnExportProduct.BorderColor = Color.FromArgb(228, 255, 207);
            BtnExportProduct.BorderRadius = 0;
            BtnExportProduct.FlatAppearance.BorderSize = 0;
            BtnExportProduct.FlatStyle = FlatStyle.Flat;
            BtnExportProduct.Font = new Font("Segoe UI", 9F);
            BtnExportProduct.ForeColor = Color.Black;
            BtnExportProduct.Location = new Point(-2, 3);
            BtnExportProduct.Name = "BtnExportProduct";
            BtnExportProduct.Size = new Size(211, 40);
            BtnExportProduct.TabIndex = 29;
            BtnExportProduct.Text = "Sản phẩm";
            BtnExportProduct.TextColor = Color.Black;
            BtnExportProduct.UseVisualStyleBackColor = false;
            BtnExportProduct.Click += BtnExportProductClick;
            // 
            // BtnExportPackage
            // 
            BtnExportPackage.BackColor = Color.FromArgb(228, 255, 207);
            BtnExportPackage.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnExportPackage.BoderSize = 0;
            BtnExportPackage.BorderColor = Color.FromArgb(228, 255, 207);
            BtnExportPackage.BorderRadius = 0;
            BtnExportPackage.FlatAppearance.BorderSize = 0;
            BtnExportPackage.FlatStyle = FlatStyle.Flat;
            BtnExportPackage.Font = new Font("Segoe UI", 9F);
            BtnExportPackage.ForeColor = Color.Black;
            BtnExportPackage.Location = new Point(216, 2);
            BtnExportPackage.Name = "BtnExportPackage";
            BtnExportPackage.Size = new Size(172, 40);
            BtnExportPackage.TabIndex = 28;
            BtnExportPackage.Text = "Bao bì";
            BtnExportPackage.TextColor = Color.Black;
            BtnExportPackage.UseVisualStyleBackColor = false;
            BtnExportPackage.Click += BtnExportPackageClick;
            // 
            // TbProductName
            // 
            TbProductName.BorderStyle = BorderStyle.FixedSingle;
            TbProductName.Location = new Point(231, 58);
            TbProductName.Name = "TbProductName";
            TbProductName.Size = new Size(309, 39);
            TbProductName.TabIndex = 13;
            TbProductName.TextChanged += TbProductNameTextChanged;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.BackColor = Color.White;
            BtnAddProduct.BackgroundColor = Color.White;
            BtnAddProduct.BoderSize = 3;
            BtnAddProduct.BorderColor = Color.DeepSkyBlue;
            BtnAddProduct.BorderRadius = 32;
            BtnAddProduct.FlatAppearance.BorderSize = 0;
            BtnAddProduct.FlatStyle = FlatStyle.Flat;
            BtnAddProduct.ForeColor = Color.DeepSkyBlue;
            BtnAddProduct.Location = new Point(853, 122);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(128, 53);
            BtnAddProduct.TabIndex = 19;
            BtnAddProduct.Text = "Thêm";
            BtnAddProduct.TextColor = Color.DeepSkyBlue;
            BtnAddProduct.UseVisualStyleBackColor = false;
            BtnAddProduct.Click += BtnAddProductClick;
            // 
            // LbQuantityProduct
            // 
            LbQuantityProduct.AutoSize = true;
            LbQuantityProduct.Font = new Font("Segoe UI", 9F);
            LbQuantityProduct.Location = new Point(592, 61);
            LbQuantityProduct.Name = "LbQuantityProduct";
            LbQuantityProduct.Size = new Size(110, 32);
            LbQuantityProduct.TabIndex = 16;
            LbQuantityProduct.Text = "Số lượng";
            // 
            // LbProductInformation
            // 
            LbProductInformation.AutoSize = true;
            LbProductInformation.Font = new Font("Segoe UI", 9F);
            LbProductInformation.Location = new Point(32, 62);
            LbProductInformation.Name = "LbProductInformation";
            LbProductInformation.Size = new Size(163, 32);
            LbProductInformation.TabIndex = 13;
            LbProductInformation.Text = "Tên sản phẩm";
            // 
            // TbQuantityProduct
            // 
            TbQuantityProduct.BorderStyle = BorderStyle.FixedSingle;
            TbQuantityProduct.Location = new Point(718, 58);
            TbQuantityProduct.Name = "TbQuantityProduct";
            TbQuantityProduct.Size = new Size(264, 39);
            TbQuantityProduct.TabIndex = 15;
            // 
            // PanelButtonExport
            // 
            PanelButtonExport.Controls.Add(BtnCancle);
            PanelButtonExport.Controls.Add(BtnConfirm);
            PanelButtonExport.Dock = DockStyle.Bottom;
            PanelButtonExport.Location = new Point(0, 934);
            PanelButtonExport.Name = "PanelButtonExport";
            PanelButtonExport.Size = new Size(1032, 66);
            PanelButtonExport.TabIndex = 18;
            // 
            // BtnCancle
            // 
            BtnCancle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancle.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancle.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCancle.BoderSize = 2;
            BtnCancle.BorderColor = Color.Black;
            BtnCancle.BorderRadius = 34;
            BtnCancle.FlatAppearance.BorderSize = 0;
            BtnCancle.FlatStyle = FlatStyle.Flat;
            BtnCancle.ForeColor = Color.Black;
            BtnCancle.Location = new Point(730, 8);
            BtnCancle.Name = "BtnCancle";
            BtnCancle.Size = new Size(119, 54);
            BtnCancle.TabIndex = 13;
            BtnCancle.Text = "Hủy";
            BtnCancle.TextColor = Color.Black;
            BtnCancle.UseVisualStyleBackColor = false;
            BtnCancle.Click += BtnCancelClick;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnConfirm.BackColor = Color.FromArgb(196, 238, 181);
            BtnConfirm.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnConfirm.BoderSize = 2;
            BtnConfirm.BorderColor = Color.Black;
            BtnConfirm.BorderRadius = 34;
            BtnConfirm.FlatAppearance.BorderSize = 0;
            BtnConfirm.FlatStyle = FlatStyle.Flat;
            BtnConfirm.ForeColor = Color.Black;
            BtnConfirm.Location = new Point(855, 8);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(172, 54);
            BtnConfirm.TabIndex = 14;
            BtnConfirm.Text = "Xác nhận";
            BtnConfirm.TextColor = Color.Black;
            BtnConfirm.UseVisualStyleBackColor = false;
            BtnConfirm.Click += BtnConfirmClick;
            // 
            // PanelInfoExport
            // 
            PanelInfoExport.BorderStyle = BorderStyle.FixedSingle;
            PanelInfoExport.Controls.Add(CbbStorage);
            PanelInfoExport.Controls.Add(LbStorageID);
            PanelInfoExport.Controls.Add(LbHeaderInfoExport);
            PanelInfoExport.Controls.Add(LbExportDay);
            PanelInfoExport.Controls.Add(DtpExport);
            PanelInfoExport.Dock = DockStyle.Top;
            PanelInfoExport.Location = new Point(0, 0);
            PanelInfoExport.Name = "PanelInfoExport";
            PanelInfoExport.Size = new Size(1032, 335);
            PanelInfoExport.TabIndex = 19;
            // 
            // CbbStorage
            // 
            CbbStorage.FormattingEnabled = true;
            CbbStorage.Location = new Point(231, 86);
            CbbStorage.Margin = new Padding(5, 5, 5, 5);
            CbbStorage.Name = "CbbStorage";
            CbbStorage.Size = new Size(750, 40);
            CbbStorage.TabIndex = 26;
            // 
            // LbStorageID
            // 
            LbStorageID.AutoSize = true;
            LbStorageID.Font = new Font("Segoe UI", 9F);
            LbStorageID.Location = new Point(39, 82);
            LbStorageID.Name = "LbStorageID";
            LbStorageID.Size = new Size(160, 32);
            LbStorageID.TabIndex = 25;
            LbStorageID.Text = "Tên kho nhận";
            // 
            // LbHeaderInfoExport
            // 
            LbHeaderInfoExport.Anchor = AnchorStyles.Top;
            LbHeaderInfoExport.AutoSize = true;
            LbHeaderInfoExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderInfoExport.Location = new Point(383, 2);
            LbHeaderInfoExport.Name = "LbHeaderInfoExport";
            LbHeaderInfoExport.Size = new Size(231, 32);
            LbHeaderInfoExport.TabIndex = 20;
            LbHeaderInfoExport.Text = "Thông tin xuất kho";
            // 
            // LbExportDay
            // 
            LbExportDay.AutoSize = true;
            LbExportDay.Font = new Font("Segoe UI", 9F);
            LbExportDay.Location = new Point(72, 160);
            LbExportDay.Name = "LbExportDay";
            LbExportDay.Size = new Size(122, 32);
            LbExportDay.TabIndex = 2;
            LbExportDay.Text = "Ngày xuất";
            // 
            // DtpExport
            // 
            DtpExport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpExport.Format = DateTimePickerFormat.Short;
            DtpExport.Location = new Point(229, 155);
            DtpExport.Name = "DtpExport";
            DtpExport.Size = new Size(750, 39);
            DtpExport.TabIndex = 12;
            // 
            // PanelHeaderExportStorage
            // 
            PanelHeaderExportStorage.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderExportStorage.BorderStyle = BorderStyle.FixedSingle;
            PanelHeaderExportStorage.Controls.Add(LbHeaderExportStorage);
            PanelHeaderExportStorage.Dock = DockStyle.Top;
            PanelHeaderExportStorage.Location = new Point(0, 0);
            PanelHeaderExportStorage.Name = "PanelHeaderExportStorage";
            PanelHeaderExportStorage.Size = new Size(1924, 52);
            PanelHeaderExportStorage.TabIndex = 1;
            // 
            // LbHeaderExportStorage
            // 
            LbHeaderExportStorage.Anchor = AnchorStyles.Top;
            LbHeaderExportStorage.AutoSize = true;
            LbHeaderExportStorage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderExportStorage.Location = new Point(908, 8);
            LbHeaderExportStorage.Name = "LbHeaderExportStorage";
            LbHeaderExportStorage.Size = new Size(184, 32);
            LbHeaderExportStorage.TabIndex = 0;
            LbHeaderExportStorage.Text = "Phiếu xuất kho";
            // 
            // PanelExportHistory
            // 
            PanelExportHistory.BackColor = Color.FromArgb(228, 255, 207);
            PanelExportHistory.BorderStyle = BorderStyle.FixedSingle;
            PanelExportHistory.Controls.Add(DgvExportHistory);
            PanelExportHistory.Controls.Add(PanelButtonExportHistory);
            PanelExportHistory.Controls.Add(PanelHeaderExportHistory);
            PanelExportHistory.Dock = DockStyle.Fill;
            PanelExportHistory.Location = new Point(1055, 52);
            PanelExportHistory.Name = "PanelExportHistory";
            PanelExportHistory.Size = new Size(869, 1002);
            PanelExportHistory.TabIndex = 2;
            // 
            // DgvExportHistory
            // 
            DgvExportHistory.AllowUserToResizeRows = false;
            DgvExportHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvExportHistory.BackgroundColor = Color.White;
            DgvExportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvExportHistory.Columns.AddRange(new DataGridViewColumn[] { receiptID, receivePlace, exportDay, totalProduct });
            DgvExportHistory.Dock = DockStyle.Fill;
            DgvExportHistory.Location = new Point(0, 45);
            DgvExportHistory.Name = "DgvExportHistory";
            DgvExportHistory.RowHeadersVisible = false;
            DgvExportHistory.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvExportHistory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DgvExportHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvExportHistory.Size = new Size(867, 891);
            DgvExportHistory.TabIndex = 2;
            // 
            // receiptID
            // 
            receiptID.HeaderText = "Mã phiếu";
            receiptID.MinimumWidth = 10;
            receiptID.Name = "receiptID";
            // 
            // receivePlace
            // 
            receivePlace.HeaderText = "Nơi nhận";
            receivePlace.MinimumWidth = 10;
            receivePlace.Name = "receivePlace";
            // 
            // exportDay
            // 
            exportDay.HeaderText = "Ngày xuất";
            exportDay.MinimumWidth = 10;
            exportDay.Name = "exportDay";
            // 
            // totalProduct
            // 
            totalProduct.HeaderText = "Tổng sản phẩm";
            totalProduct.MinimumWidth = 10;
            totalProduct.Name = "totalProduct";
            // 
            // PanelButtonExportHistory
            // 
            PanelButtonExportHistory.Controls.Add(BtnViewDetail);
            PanelButtonExportHistory.Dock = DockStyle.Bottom;
            PanelButtonExportHistory.Location = new Point(0, 936);
            PanelButtonExportHistory.Name = "PanelButtonExportHistory";
            PanelButtonExportHistory.Size = new Size(867, 64);
            PanelButtonExportHistory.TabIndex = 19;
            // 
            // BtnViewDetail
            // 
            BtnViewDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnViewDetail.BackColor = Color.FromArgb(196, 238, 181);
            BtnViewDetail.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnViewDetail.BoderSize = 2;
            BtnViewDetail.BorderColor = Color.Black;
            BtnViewDetail.BorderRadius = 34;
            BtnViewDetail.FlatAppearance.BorderSize = 0;
            BtnViewDetail.FlatStyle = FlatStyle.Flat;
            BtnViewDetail.ForeColor = Color.Black;
            BtnViewDetail.Location = new Point(689, 6);
            BtnViewDetail.Name = "BtnViewDetail";
            BtnViewDetail.Size = new Size(171, 54);
            BtnViewDetail.TabIndex = 16;
            BtnViewDetail.Text = "Xem chi tiết";
            BtnViewDetail.TextColor = Color.Black;
            BtnViewDetail.UseVisualStyleBackColor = false;
            BtnViewDetail.Click += BtnViewDetailClick;
            // 
            // PanelHeaderExportHistory
            // 
            PanelHeaderExportHistory.BackColor = Color.FromArgb(228, 255, 207);
            PanelHeaderExportHistory.Controls.Add(LbHeaderExportHistory);
            PanelHeaderExportHistory.Dock = DockStyle.Top;
            PanelHeaderExportHistory.Location = new Point(0, 0);
            PanelHeaderExportHistory.Name = "PanelHeaderExportHistory";
            PanelHeaderExportHistory.Size = new Size(867, 45);
            PanelHeaderExportHistory.TabIndex = 1;
            // 
            // LbHeaderExportHistory
            // 
            LbHeaderExportHistory.Anchor = AnchorStyles.Top;
            LbHeaderExportHistory.AutoSize = true;
            LbHeaderExportHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderExportHistory.Location = new Point(333, 2);
            LbHeaderExportHistory.Name = "LbHeaderExportHistory";
            LbHeaderExportHistory.Size = new Size(199, 32);
            LbHeaderExportHistory.TabIndex = 0;
            LbHeaderExportHistory.Text = "Lịch sử xuất kho";
            // 
            // PanelSeparation
            // 
            PanelSeparation.Dock = DockStyle.Left;
            PanelSeparation.Location = new Point(1034, 52);
            PanelSeparation.Name = "PanelSeparation";
            PanelSeparation.Size = new Size(21, 1002);
            PanelSeparation.TabIndex = 3;
            // 
            // ExportProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1924, 1054);
            Controls.Add(PanelExportHistory);
            Controls.Add(PanelSeparation);
            Controls.Add(PanelExport);
            Controls.Add(PanelHeaderExportStorage);
            Name = "ExportProductForm";
            Text = "ImportProductForm";
            Load += ExportProductFormLoad;
            PanelExport.ResumeLayout(false);
            PanelInputExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvProductList).EndInit();
            PanelProductListFooter.ResumeLayout(false);
            PanelProductListFooter.PerformLayout();
            PanelInput.ResumeLayout(false);
            PanelInput.PerformLayout();
            PanelButtonExport.ResumeLayout(false);
            PanelInfoExport.ResumeLayout(false);
            PanelInfoExport.PerformLayout();
            PanelHeaderExportStorage.ResumeLayout(false);
            PanelHeaderExportStorage.PerformLayout();
            PanelExportHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvExportHistory).EndInit();
            PanelButtonExportHistory.ResumeLayout(false);
            PanelHeaderExportHistory.ResumeLayout(false);
            PanelHeaderExportHistory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelExport;
        private Label LbExportDay;
        private DateTimePicker DtpExport;
        private RadioButton RbtnStorageOther;
        private RadioButton RbtnSupplier;
        private RadioButton RbtnSelf;
        private Label LbQuantityProduct;
        private TextBox TbQuantityProduct;
        private DataGridView DgvProductList;
        private TextBox TbProductName;
        private Label LbProductInformation;
        private Components.RJButton BtnAddProduct;
        private Panel PanelProductListFooter;
        private Label LbTotalCost;
        private Components.RJButton BtnDelete;
        private Panel PanelHeaderExportStorage;
        private Panel PanelExportHistory;
        private Label LbHeaderExportHistory;
        private Label LbHeaderExportStorage;
        private Panel PanelInfoExport;
        private Panel PanelInput;
        private Label LbHeaderInfoExport;
        private Panel PanelSeparation;
        private Panel PanelHeaderExportHistory;
        private DataGridView DgvExportHistory;
        private Panel PanelButtonExportHistory;
        private Components.RJButton BtnViewDetail;
        private Label LbStorageID;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewTextBoxColumn receiptID;
        private DataGridViewTextBoxColumn receivePlace;
        private DataGridViewTextBoxColumn exportDay;
        private DataGridViewTextBoxColumn totalProduct;
        private Components.RJButton BtnConfirm;
        private Components.RJButton BtnCancle;
        private Panel PanelButtonExport;
        private Panel PanelInputExport;
        private Components.RJButton BtnExportProduct;
        private Components.RJButton BtnExportPackage;
        private TextBox TbSerialCode;
        private ListBox LbSuggestions;
        private ComboBox CbbStorage;
    }
}