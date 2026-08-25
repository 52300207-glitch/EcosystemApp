namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class ImportProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportProductForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgvProductList = new DataGridView();
            productID = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            unit = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            PanelImport = new Panel();
            LbSuggestions2 = new ListBox();
            TbPackageType = new TextBox();
            LbProductUnit = new Label();
            CbbProductUnit = new ComboBox();
            TbSerialCode = new TextBox();
            LbSuggestions = new ListBox();
            BtnImportProduct = new EcosystemApp.GUI.Components.RJButton();
            TbPurchasePrice = new TextBox();
            LbPurchasePrice = new Label();
            BtnImportPackage = new EcosystemApp.GUI.Components.RJButton();
            TbProductName = new TextBox();
            BtnAddProduct = new EcosystemApp.GUI.Components.RJButton();
            LbQuantityProduct = new Label();
            LbProductInformation = new Label();
            TbQuantityProduct = new TextBox();
            PanelImportFooter = new Panel();
            BtnDelete = new EcosystemApp.GUI.Components.RJButton();
            LbTotalCost = new Label();
            PanelInfoImport = new Panel();
            TbNamePlaceSupply = new TextBox();
            CbbStorageOther = new ComboBox();
            CbbStorage = new ComboBox();
            LbStorge = new Label();
            LbHeaderInfoInport = new Label();
            RbtnStorageOther = new RadioButton();
            RbtnSupplier = new RadioButton();
            LbImportDay = new Label();
            LbNamePlaceSupply = new Label();
            DtpImport = new DateTimePicker();
            RbtnSelf = new RadioButton();
            LbSource = new Label();
            PanelImportButton = new Panel();
            BtnCancle = new EcosystemApp.GUI.Components.RJButton();
            BtnConfirm = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderImportStorage = new Panel();
            LbHeaderImportStorage = new Label();
            PanelImportHistory = new Panel();
            DgvImportHistory = new DataGridView();
            PanelImportHistoryButton = new Panel();
            BtnViewDetail = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderImportHistory = new Panel();
            LbHeaderImportHistory = new Label();
            PanelSeparation = new Panel();
            PanelImportStorage = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvProductList).BeginInit();
            PanelImport.SuspendLayout();
            PanelImportFooter.SuspendLayout();
            PanelInfoImport.SuspendLayout();
            PanelImportButton.SuspendLayout();
            PanelHeaderImportStorage.SuspendLayout();
            PanelImportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvImportHistory).BeginInit();
            PanelImportHistoryButton.SuspendLayout();
            PanelHeaderImportHistory.SuspendLayout();
            PanelImportStorage.SuspendLayout();
            SuspendLayout();
            // 
            // DgvProductList
            // 
            DgvProductList.AllowUserToResizeRows = false;
            DgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductList.BackgroundColor = Color.White;
            DgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductList.Columns.AddRange(new DataGridViewColumn[] { productID, nameProduct, quantity, unit, cost });
            DgvProductList.Dock = DockStyle.Fill;
            DgvProductList.Location = new Point(0, 576);
            DgvProductList.Margin = new Padding(5);
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
            DgvProductList.Size = new Size(1051, 301);
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
            // PanelImport
            // 
            PanelImport.BorderStyle = BorderStyle.FixedSingle;
            PanelImport.Controls.Add(LbSuggestions2);
            PanelImport.Controls.Add(TbPackageType);
            PanelImport.Controls.Add(LbProductUnit);
            PanelImport.Controls.Add(CbbProductUnit);
            PanelImport.Controls.Add(TbSerialCode);
            PanelImport.Controls.Add(LbSuggestions);
            PanelImport.Controls.Add(BtnImportProduct);
            PanelImport.Controls.Add(TbPurchasePrice);
            PanelImport.Controls.Add(LbPurchasePrice);
            PanelImport.Controls.Add(BtnImportPackage);
            PanelImport.Controls.Add(TbProductName);
            PanelImport.Controls.Add(BtnAddProduct);
            PanelImport.Controls.Add(LbQuantityProduct);
            PanelImport.Controls.Add(LbProductInformation);
            PanelImport.Controls.Add(TbQuantityProduct);
            PanelImport.Dock = DockStyle.Top;
            PanelImport.Location = new Point(0, 328);
            PanelImport.Margin = new Padding(5);
            PanelImport.Name = "PanelImport";
            PanelImport.Size = new Size(1051, 248);
            PanelImport.TabIndex = 2;
            // 
            // LbSuggestions2
            // 
            LbSuggestions2.FormattingEnabled = true;
            LbSuggestions2.Location = new Point(236, 120);
            LbSuggestions2.Margin = new Padding(5);
            LbSuggestions2.Name = "LbSuggestions2";
            LbSuggestions2.Size = new Size(334, 164);
            LbSuggestions2.TabIndex = 31;
            LbSuggestions2.Click += LbSuggestions2Click;
            // 
            // TbPackageType
            // 
            TbPackageType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbPackageType.BorderStyle = BorderStyle.FixedSingle;
            TbPackageType.Location = new Point(237, 67);
            TbPackageType.Margin = new Padding(5);
            TbPackageType.Name = "TbPackageType";
            TbPackageType.Size = new Size(335, 39);
            TbPackageType.TabIndex = 30;
            TbPackageType.Click += LbSuggestions2Click;
            TbPackageType.TextChanged += TbPackageTypeTextChanged;
            // 
            // LbProductUnit
            // 
            LbProductUnit.AutoSize = true;
            LbProductUnit.Location = new Point(627, 126);
            LbProductUnit.Margin = new Padding(5, 0, 5, 0);
            LbProductUnit.Name = "LbProductUnit";
            LbProductUnit.Size = new Size(84, 32);
            LbProductUnit.TabIndex = 29;
            LbProductUnit.Text = "Đơn vị";
            // 
            // CbbProductUnit
            // 
            CbbProductUnit.FormattingEnabled = true;
            CbbProductUnit.Location = new Point(723, 118);
            CbbProductUnit.Margin = new Padding(5);
            CbbProductUnit.Name = "CbbProductUnit";
            CbbProductUnit.Size = new Size(314, 40);
            CbbProductUnit.TabIndex = 28;
            // 
            // TbSerialCode
            // 
            TbSerialCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbSerialCode.BorderStyle = BorderStyle.FixedSingle;
            TbSerialCode.Location = new Point(723, 64);
            TbSerialCode.Margin = new Padding(5);
            TbSerialCode.Name = "TbSerialCode";
            TbSerialCode.Size = new Size(317, 39);
            TbSerialCode.TabIndex = 26;
            TbSerialCode.Visible = false;
            // 
            // LbSuggestions
            // 
            LbSuggestions.FormattingEnabled = true;
            LbSuggestions.Location = new Point(234, 117);
            LbSuggestions.Margin = new Padding(5);
            LbSuggestions.Name = "LbSuggestions";
            LbSuggestions.Size = new Size(336, 164);
            LbSuggestions.TabIndex = 27;
            LbSuggestions.Click += LbSuggestionsClick;
            // 
            // BtnImportProduct
            // 
            BtnImportProduct.BackColor = Color.FromArgb(228, 255, 207);
            BtnImportProduct.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnImportProduct.BoderSize = 0;
            BtnImportProduct.BorderColor = Color.FromArgb(228, 255, 207);
            BtnImportProduct.BorderRadius = 0;
            BtnImportProduct.FlatAppearance.BorderSize = 0;
            BtnImportProduct.FlatStyle = FlatStyle.Flat;
            BtnImportProduct.Font = new Font("Segoe UI", 9F);
            BtnImportProduct.ForeColor = Color.Black;
            BtnImportProduct.Location = new Point(-2, -2);
            BtnImportProduct.Margin = new Padding(5);
            BtnImportProduct.Name = "BtnImportProduct";
            BtnImportProduct.Size = new Size(200, 64);
            BtnImportProduct.TabIndex = 25;
            BtnImportProduct.Text = "Sản phẩm";
            BtnImportProduct.TextColor = Color.Black;
            BtnImportProduct.UseVisualStyleBackColor = false;
            BtnImportProduct.Click += BtnImportProductClick;
            // 
            // TbPurchasePrice
            // 
            TbPurchasePrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbPurchasePrice.BorderStyle = BorderStyle.FixedSingle;
            TbPurchasePrice.Location = new Point(235, 120);
            TbPurchasePrice.Margin = new Padding(5);
            TbPurchasePrice.Name = "TbPurchasePrice";
            TbPurchasePrice.Size = new Size(337, 39);
            TbPurchasePrice.TabIndex = 24;
            // 
            // LbPurchasePrice
            // 
            LbPurchasePrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbPurchasePrice.AutoSize = true;
            LbPurchasePrice.Font = new Font("Segoe UI", 9F);
            LbPurchasePrice.Location = new Point(113, 118);
            LbPurchasePrice.Margin = new Padding(5, 0, 5, 0);
            LbPurchasePrice.Name = "LbPurchasePrice";
            LbPurchasePrice.Size = new Size(102, 32);
            LbPurchasePrice.TabIndex = 22;
            LbPurchasePrice.Text = "Giá mua";
            // 
            // BtnImportPackage
            // 
            BtnImportPackage.BackColor = Color.FromArgb(228, 255, 207);
            BtnImportPackage.BackgroundColor = Color.FromArgb(228, 255, 207);
            BtnImportPackage.BoderSize = 0;
            BtnImportPackage.BorderColor = Color.FromArgb(228, 255, 207);
            BtnImportPackage.BorderRadius = 0;
            BtnImportPackage.FlatAppearance.BorderSize = 0;
            BtnImportPackage.FlatStyle = FlatStyle.Flat;
            BtnImportPackage.Font = new Font("Segoe UI", 9F);
            BtnImportPackage.ForeColor = Color.Black;
            BtnImportPackage.Location = new Point(208, -2);
            BtnImportPackage.Margin = new Padding(5);
            BtnImportPackage.Name = "BtnImportPackage";
            BtnImportPackage.Size = new Size(154, 64);
            BtnImportPackage.TabIndex = 20;
            BtnImportPackage.Text = "Bao bì";
            BtnImportPackage.TextColor = Color.Black;
            BtnImportPackage.UseVisualStyleBackColor = false;
            BtnImportPackage.Click += BtnImportPackageClick;
            // 
            // TbProductName
            // 
            TbProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbProductName.BorderStyle = BorderStyle.FixedSingle;
            TbProductName.Location = new Point(236, 67);
            TbProductName.Margin = new Padding(5);
            TbProductName.Name = "TbProductName";
            TbProductName.Size = new Size(338, 39);
            TbProductName.TabIndex = 13;
            TbProductName.TextChanged += TbProductNameTextChanged;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAddProduct.BackColor = Color.White;
            BtnAddProduct.BackgroundColor = Color.White;
            BtnAddProduct.BoderSize = 3;
            BtnAddProduct.BorderColor = Color.DeepSkyBlue;
            BtnAddProduct.BorderRadius = 30;
            BtnAddProduct.FlatAppearance.BorderSize = 0;
            BtnAddProduct.FlatStyle = FlatStyle.Flat;
            BtnAddProduct.ForeColor = Color.DeepSkyBlue;
            BtnAddProduct.Location = new Point(905, 181);
            BtnAddProduct.Margin = new Padding(5);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(136, 54);
            BtnAddProduct.TabIndex = 19;
            BtnAddProduct.Text = "Thêm";
            BtnAddProduct.TextColor = Color.DeepSkyBlue;
            BtnAddProduct.UseVisualStyleBackColor = false;
            BtnAddProduct.Click += BtnAddProductClick;
            // 
            // LbQuantityProduct
            // 
            LbQuantityProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbQuantityProduct.AutoSize = true;
            LbQuantityProduct.Font = new Font("Segoe UI", 9F);
            LbQuantityProduct.Location = new Point(601, 66);
            LbQuantityProduct.Margin = new Padding(5, 0, 5, 0);
            LbQuantityProduct.Name = "LbQuantityProduct";
            LbQuantityProduct.Size = new Size(110, 32);
            LbQuantityProduct.TabIndex = 16;
            LbQuantityProduct.Text = "Số lượng";
            // 
            // LbProductInformation
            // 
            LbProductInformation.AutoSize = true;
            LbProductInformation.Font = new Font("Segoe UI", 9F);
            LbProductInformation.Location = new Point(52, 69);
            LbProductInformation.Margin = new Padding(5, 0, 5, 0);
            LbProductInformation.Name = "LbProductInformation";
            LbProductInformation.Size = new Size(163, 32);
            LbProductInformation.TabIndex = 13;
            LbProductInformation.Text = "Tên sản phẩm";
            // 
            // TbQuantityProduct
            // 
            TbQuantityProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbQuantityProduct.BorderStyle = BorderStyle.FixedSingle;
            TbQuantityProduct.Location = new Point(724, 64);
            TbQuantityProduct.Margin = new Padding(5);
            TbQuantityProduct.Name = "TbQuantityProduct";
            TbQuantityProduct.Size = new Size(317, 39);
            TbQuantityProduct.TabIndex = 15;
            // 
            // PanelImportFooter
            // 
            PanelImportFooter.BorderStyle = BorderStyle.FixedSingle;
            PanelImportFooter.Controls.Add(BtnDelete);
            PanelImportFooter.Controls.Add(LbTotalCost);
            PanelImportFooter.Dock = DockStyle.Bottom;
            PanelImportFooter.Location = new Point(0, 877);
            PanelImportFooter.Margin = new Padding(5);
            PanelImportFooter.Name = "PanelImportFooter";
            PanelImportFooter.Size = new Size(1051, 56);
            PanelImportFooter.TabIndex = 1;
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
            LbTotalCost.Location = new Point(734, 14);
            LbTotalCost.Margin = new Padding(5, 0, 5, 0);
            LbTotalCost.Name = "LbTotalCost";
            LbTotalCost.Size = new Size(129, 32);
            LbTotalCost.TabIndex = 20;
            LbTotalCost.Text = "Tổng tiền: ";
            // 
            // PanelInfoImport
            // 
            PanelInfoImport.BorderStyle = BorderStyle.FixedSingle;
            PanelInfoImport.Controls.Add(TbNamePlaceSupply);
            PanelInfoImport.Controls.Add(CbbStorageOther);
            PanelInfoImport.Controls.Add(CbbStorage);
            PanelInfoImport.Controls.Add(LbStorge);
            PanelInfoImport.Controls.Add(LbHeaderInfoInport);
            PanelInfoImport.Controls.Add(RbtnStorageOther);
            PanelInfoImport.Controls.Add(RbtnSupplier);
            PanelInfoImport.Controls.Add(LbImportDay);
            PanelInfoImport.Controls.Add(LbNamePlaceSupply);
            PanelInfoImport.Controls.Add(DtpImport);
            PanelInfoImport.Controls.Add(RbtnSelf);
            PanelInfoImport.Controls.Add(LbSource);
            PanelInfoImport.Dock = DockStyle.Top;
            PanelInfoImport.Location = new Point(0, 0);
            PanelInfoImport.Name = "PanelInfoImport";
            PanelInfoImport.Size = new Size(1051, 328);
            PanelInfoImport.TabIndex = 19;
            // 
            // TbNamePlaceSupply
            // 
            TbNamePlaceSupply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TbNamePlaceSupply.Location = new Point(237, 253);
            TbNamePlaceSupply.Margin = new Padding(5);
            TbNamePlaceSupply.Name = "TbNamePlaceSupply";
            TbNamePlaceSupply.Size = new Size(802, 39);
            TbNamePlaceSupply.TabIndex = 24;
            // 
            // CbbStorageOther
            // 
            CbbStorageOther.FormattingEnabled = true;
            CbbStorageOther.Location = new Point(239, 253);
            CbbStorageOther.Margin = new Padding(5);
            CbbStorageOther.Name = "CbbStorageOther";
            CbbStorageOther.Size = new Size(799, 40);
            CbbStorageOther.TabIndex = 23;
            // 
            // CbbStorage
            // 
            CbbStorage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CbbStorage.FormattingEnabled = true;
            CbbStorage.Location = new Point(235, 56);
            CbbStorage.Margin = new Padding(5);
            CbbStorage.Name = "CbbStorage";
            CbbStorage.Size = new Size(800, 40);
            CbbStorage.TabIndex = 22;
            // 
            // LbStorge
            // 
            LbStorge.AutoSize = true;
            LbStorge.Font = new Font("Segoe UI", 9F);
            LbStorge.Location = new Point(130, 61);
            LbStorge.Margin = new Padding(5, 0, 5, 0);
            LbStorge.Name = "LbStorge";
            LbStorge.Size = new Size(95, 32);
            LbStorge.TabIndex = 21;
            LbStorge.Text = "Mã kho";
            // 
            // LbHeaderInfoInport
            // 
            LbHeaderInfoInport.Anchor = AnchorStyles.Top;
            LbHeaderInfoInport.AutoSize = true;
            LbHeaderInfoInport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderInfoInport.Location = new Point(390, 3);
            LbHeaderInfoInport.Margin = new Padding(5, 0, 5, 0);
            LbHeaderInfoInport.Name = "LbHeaderInfoInport";
            LbHeaderInfoInport.Size = new Size(238, 32);
            LbHeaderInfoInport.TabIndex = 20;
            LbHeaderInfoInport.Text = "Thông tin nhập kho";
            // 
            // RbtnStorageOther
            // 
            RbtnStorageOther.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RbtnStorageOther.AutoSize = true;
            RbtnStorageOther.Font = new Font("Segoe UI", 9F);
            RbtnStorageOther.Location = new Point(869, 194);
            RbtnStorageOther.Margin = new Padding(5);
            RbtnStorageOther.Name = "RbtnStorageOther";
            RbtnStorageOther.Size = new Size(153, 36);
            RbtnStorageOther.TabIndex = 11;
            RbtnStorageOther.TabStop = true;
            RbtnStorageOther.Text = "Trạm khác";
            RbtnStorageOther.UseVisualStyleBackColor = true;
            RbtnStorageOther.CheckedChanged += RbtnStorageOtherCheckedChanged;
            // 
            // RbtnSupplier
            // 
            RbtnSupplier.AutoSize = true;
            RbtnSupplier.Font = new Font("Segoe UI", 9F);
            RbtnSupplier.Location = new Point(522, 194);
            RbtnSupplier.Margin = new Padding(5);
            RbtnSupplier.Name = "RbtnSupplier";
            RbtnSupplier.Size = new Size(193, 36);
            RbtnSupplier.TabIndex = 10;
            RbtnSupplier.TabStop = true;
            RbtnSupplier.Text = "Nhà cung cấp";
            RbtnSupplier.UseVisualStyleBackColor = true;
            RbtnSupplier.CheckedChanged += RbtnSupplierCheckedChanged;
            // 
            // LbImportDay
            // 
            LbImportDay.AutoSize = true;
            LbImportDay.Font = new Font("Segoe UI", 9F);
            LbImportDay.Location = new Point(94, 126);
            LbImportDay.Margin = new Padding(5, 0, 5, 0);
            LbImportDay.Name = "LbImportDay";
            LbImportDay.Size = new Size(131, 32);
            LbImportDay.TabIndex = 2;
            LbImportDay.Text = "Ngày nhập";
            // 
            // LbNamePlaceSupply
            // 
            LbNamePlaceSupply.AutoSize = true;
            LbNamePlaceSupply.Font = new Font("Segoe UI", 9F);
            LbNamePlaceSupply.Location = new Point(28, 253);
            LbNamePlaceSupply.Margin = new Padding(5, 0, 5, 0);
            LbNamePlaceSupply.Name = "LbNamePlaceSupply";
            LbNamePlaceSupply.RightToLeft = RightToLeft.No;
            LbNamePlaceSupply.Size = new Size(197, 32);
            LbNamePlaceSupply.TabIndex = 4;
            LbNamePlaceSupply.Text = "Tên nơi cung cấp";
            // 
            // DtpImport
            // 
            DtpImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DtpImport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpImport.Format = DateTimePickerFormat.Short;
            DtpImport.Location = new Point(235, 125);
            DtpImport.Margin = new Padding(5);
            DtpImport.Name = "DtpImport";
            DtpImport.Size = new Size(800, 39);
            DtpImport.TabIndex = 12;
            // 
            // RbtnSelf
            // 
            RbtnSelf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RbtnSelf.AutoSize = true;
            RbtnSelf.Font = new Font("Segoe UI", 9F);
            RbtnSelf.Location = new Point(236, 194);
            RbtnSelf.Margin = new Padding(5);
            RbtnSelf.Name = "RbtnSelf";
            RbtnSelf.Size = new Size(167, 36);
            RbtnSelf.TabIndex = 9;
            RbtnSelf.TabStop = true;
            RbtnSelf.Text = "Tự sản xuất";
            RbtnSelf.UseVisualStyleBackColor = true;
            RbtnSelf.CheckedChanged += RbtnSelfCheckedChanged;
            // 
            // LbSource
            // 
            LbSource.AutoSize = true;
            LbSource.Font = new Font("Segoe UI", 9F);
            LbSource.Location = new Point(76, 195);
            LbSource.Margin = new Padding(5, 0, 5, 0);
            LbSource.Name = "LbSource";
            LbSource.Size = new Size(149, 32);
            LbSource.TabIndex = 3;
            LbSource.Text = "Nguồn hàng";
            // 
            // PanelImportButton
            // 
            PanelImportButton.Controls.Add(BtnCancle);
            PanelImportButton.Controls.Add(BtnConfirm);
            PanelImportButton.Dock = DockStyle.Bottom;
            PanelImportButton.Location = new Point(0, 933);
            PanelImportButton.Margin = new Padding(5);
            PanelImportButton.Name = "PanelImportButton";
            PanelImportButton.Size = new Size(1051, 67);
            PanelImportButton.TabIndex = 18;
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
            BtnCancle.Location = new Point(748, 5);
            BtnCancle.Margin = new Padding(5);
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
            BtnConfirm.Location = new Point(876, 6);
            BtnConfirm.Margin = new Padding(5);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new Size(172, 54);
            BtnConfirm.TabIndex = 14;
            BtnConfirm.Text = "Xác nhận";
            BtnConfirm.TextColor = Color.Black;
            BtnConfirm.UseVisualStyleBackColor = false;
            BtnConfirm.Click += BtnConfirmClick;
            // 
            // PanelHeaderImportStorage
            // 
            PanelHeaderImportStorage.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderImportStorage.BorderStyle = BorderStyle.FixedSingle;
            PanelHeaderImportStorage.Controls.Add(LbHeaderImportStorage);
            PanelHeaderImportStorage.Dock = DockStyle.Top;
            PanelHeaderImportStorage.Location = new Point(0, 0);
            PanelHeaderImportStorage.Name = "PanelHeaderImportStorage";
            PanelHeaderImportStorage.Size = new Size(1924, 52);
            PanelHeaderImportStorage.TabIndex = 1;
            // 
            // LbHeaderImportStorage
            // 
            LbHeaderImportStorage.Anchor = AnchorStyles.Top;
            LbHeaderImportStorage.AutoSize = true;
            LbHeaderImportStorage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderImportStorage.Location = new Point(927, 8);
            LbHeaderImportStorage.Margin = new Padding(5, 0, 5, 0);
            LbHeaderImportStorage.Name = "LbHeaderImportStorage";
            LbHeaderImportStorage.Size = new Size(191, 32);
            LbHeaderImportStorage.TabIndex = 0;
            LbHeaderImportStorage.Text = "Phiếu nhập kho";
            // 
            // PanelImportHistory
            // 
            PanelImportHistory.BackColor = Color.FromArgb(228, 255, 207);
            PanelImportHistory.BorderStyle = BorderStyle.FixedSingle;
            PanelImportHistory.Controls.Add(DgvImportHistory);
            PanelImportHistory.Controls.Add(PanelImportHistoryButton);
            PanelImportHistory.Controls.Add(PanelHeaderImportHistory);
            PanelImportHistory.Dock = DockStyle.Fill;
            PanelImportHistory.Location = new Point(1075, 52);
            PanelImportHistory.Margin = new Padding(5);
            PanelImportHistory.Name = "PanelImportHistory";
            PanelImportHistory.Size = new Size(849, 1002);
            PanelImportHistory.TabIndex = 2;
            // 
            // DgvImportHistory
            // 
            DgvImportHistory.AllowUserToResizeRows = false;
            DgvImportHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvImportHistory.BackgroundColor = Color.White;
            DgvImportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvImportHistory.Dock = DockStyle.Fill;
            DgvImportHistory.Location = new Point(0, 48);
            DgvImportHistory.Name = "DgvImportHistory";
            DgvImportHistory.RowHeadersVisible = false;
            DgvImportHistory.RowHeadersWidth = 82;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvImportHistory.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DgvImportHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvImportHistory.Size = new Size(847, 885);
            DgvImportHistory.TabIndex = 2;
            // 
            // PanelImportHistoryButton
            // 
            PanelImportHistoryButton.Controls.Add(BtnViewDetail);
            PanelImportHistoryButton.Dock = DockStyle.Bottom;
            PanelImportHistoryButton.Location = new Point(0, 933);
            PanelImportHistoryButton.Margin = new Padding(5);
            PanelImportHistoryButton.Name = "PanelImportHistoryButton";
            PanelImportHistoryButton.Size = new Size(847, 67);
            PanelImportHistoryButton.TabIndex = 19;
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
            BtnViewDetail.Location = new Point(670, 8);
            BtnViewDetail.Margin = new Padding(5);
            BtnViewDetail.Name = "BtnViewDetail";
            BtnViewDetail.Size = new Size(172, 54);
            BtnViewDetail.TabIndex = 16;
            BtnViewDetail.Text = "Xem chi tiết";
            BtnViewDetail.TextColor = Color.Black;
            BtnViewDetail.UseVisualStyleBackColor = false;
            BtnViewDetail.Click += BtnViewDetailClick;
            // 
            // PanelHeaderImportHistory
            // 
            PanelHeaderImportHistory.BackColor = Color.FromArgb(228, 255, 207);
            PanelHeaderImportHistory.Controls.Add(LbHeaderImportHistory);
            PanelHeaderImportHistory.Dock = DockStyle.Top;
            PanelHeaderImportHistory.Location = new Point(0, 0);
            PanelHeaderImportHistory.Name = "PanelHeaderImportHistory";
            PanelHeaderImportHistory.Size = new Size(847, 48);
            PanelHeaderImportHistory.TabIndex = 1;
            // 
            // LbHeaderImportHistory
            // 
            LbHeaderImportHistory.Anchor = AnchorStyles.Top;
            LbHeaderImportHistory.AutoSize = true;
            LbHeaderImportHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHeaderImportHistory.Location = new Point(329, 3);
            LbHeaderImportHistory.Margin = new Padding(5, 0, 5, 0);
            LbHeaderImportHistory.Name = "LbHeaderImportHistory";
            LbHeaderImportHistory.Size = new Size(206, 32);
            LbHeaderImportHistory.TabIndex = 0;
            LbHeaderImportHistory.Text = "Lịch sử nhập kho";
            // 
            // PanelSeparation
            // 
            PanelSeparation.BorderStyle = BorderStyle.FixedSingle;
            PanelSeparation.Dock = DockStyle.Left;
            PanelSeparation.Location = new Point(1053, 52);
            PanelSeparation.Margin = new Padding(5);
            PanelSeparation.Name = "PanelSeparation";
            PanelSeparation.Size = new Size(22, 1002);
            PanelSeparation.TabIndex = 3;
            // 
            // PanelImportStorage
            // 
            PanelImportStorage.BackColor = Color.FromArgb(228, 255, 207);
            PanelImportStorage.BorderStyle = BorderStyle.FixedSingle;
            PanelImportStorage.Controls.Add(DgvProductList);
            PanelImportStorage.Controls.Add(PanelImportFooter);
            PanelImportStorage.Controls.Add(PanelImportButton);
            PanelImportStorage.Controls.Add(PanelImport);
            PanelImportStorage.Controls.Add(PanelInfoImport);
            PanelImportStorage.Dock = DockStyle.Left;
            PanelImportStorage.Location = new Point(0, 52);
            PanelImportStorage.Margin = new Padding(5);
            PanelImportStorage.Name = "PanelImportStorage";
            PanelImportStorage.Size = new Size(1053, 1002);
            PanelImportStorage.TabIndex = 0;
            // 
            // ImportProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1924, 1054);
            Controls.Add(PanelImportHistory);
            Controls.Add(PanelSeparation);
            Controls.Add(PanelImportStorage);
            Controls.Add(PanelHeaderImportStorage);
            Name = "ImportProductForm";
            Text = "ImportProductForm";
            Load += ImportProductFormLoad;
            ((System.ComponentModel.ISupportInitialize)DgvProductList).EndInit();
            PanelImport.ResumeLayout(false);
            PanelImport.PerformLayout();
            PanelImportFooter.ResumeLayout(false);
            PanelImportFooter.PerformLayout();
            PanelInfoImport.ResumeLayout(false);
            PanelInfoImport.PerformLayout();
            PanelImportButton.ResumeLayout(false);
            PanelHeaderImportStorage.ResumeLayout(false);
            PanelHeaderImportStorage.PerformLayout();
            PanelImportHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvImportHistory).EndInit();
            PanelImportHistoryButton.ResumeLayout(false);
            PanelHeaderImportHistory.ResumeLayout(false);
            PanelHeaderImportHistory.PerformLayout();
            PanelImportStorage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label LbNamePlaceSupply;
        private Label LbSource;
        private Label LbImportDay;
        private DateTimePicker DtpImport;
        private RadioButton RbtnStorageOther;
        private RadioButton RbtnSupplier;
        private RadioButton RbtnSelf;
        private Components.RJButton BtnConfirm;
        private Components.RJButton BtnCancle;
        private Label LbQuantityProduct;
        private TextBox TbQuantityProduct;
        private DataGridView DgvProductList;
        private TextBox TbProductName;
        private Label LbProductInformation;
        private Components.RJButton BtnAddProduct;
        private Panel PanelImportFooter;
        private Label LbTotalCost;
        private Components.RJButton BtnDelete;
        private Panel PanelImportButton;
        private Panel PanelHeaderImportStorage;
        private Panel PanelImportHistory;
        private Label LbHeaderImportHistory;
        private Label LbHeaderImportStorage;
        private Panel PanelInfoImport;
        private Panel PanelImport;
        private Label LbHeaderInfoInport;
        private Panel PanelSeparation;
        private Panel PanelHeaderImportHistory;
        private Label LbStorge;
        private DataGridView DgvImportHistory;
        private Panel PanelImportHistoryButton;
        private Components.RJButton BtnViewDetail;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn cost;
        private Components.RJButton BtnImportPackage;
        private Panel PanelImportStorage;
        private Components.RJButton BtnImportProduct;
        private TextBox TbPurchasePrice;
        private Label LbPurchasePrice;
        private TextBox TbSerialCode;
        private ComboBox CbbStorageOther;
        private ComboBox CbbStorage;
        private ListBox LbSuggestions;
        private TextBox TbNamePlaceSupply;
        private ComboBox CbbProductUnit;
        private Label LbProductUnit;
        private TextBox TbPackageType;
        private ListBox LbSuggestions2;
        private TextBox TbReuseLimit;
    }
}