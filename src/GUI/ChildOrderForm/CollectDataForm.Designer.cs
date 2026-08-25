namespace EcosystemApp.GUI.ChildOrderForm
{
    partial class CollectDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectDataForm));
            BtnManual = new Button();
            BtnFromExcel = new Button();
            BtnFromGGSheet = new Button();
            PanelFromExcel = new Panel();
            BtnGetDataExcel = new EcosystemApp.GUI.Components.RJButton();
            ChosenFile = new EcosystemApp.GUI.Components.RJButton();
            LbExcelWarning = new Label();
            LbSheet = new Label();
            CbbSheetNameFromExcel = new ComboBox();
            TbOrderExcelFault = new TextBox();
            LbText3 = new Label();
            TbOrderExcelSucess = new TextBox();
            LbText1 = new Label();
            LbText2 = new Label();
            LbWarningFile = new Label();
            TbFile = new TextBox();
            LbImportFile = new Label();
            PanelGGSheet = new Panel();
            BtnCopy = new EcosystemApp.GUI.Components.RJButton();
            TbEmailClientInformation = new TextBox();
            LbEmailSharing = new Label();
            BtnCancelSync = new EcosystemApp.GUI.Components.RJButton();
            BtnSyncNow = new EcosystemApp.GUI.Components.RJButton();
            BtnTestConnection = new EcosystemApp.GUI.Components.RJButton();
            LbSheetName = new Label();
            TbSheetName = new TextBox();
            TbOrderSheetFault = new TextBox();
            LbErrorOrderNumber = new Label();
            TbOrderSheetSuccess = new TextBox();
            TbTime = new TextBox();
            LbSuccessOrderNumber = new Label();
            LbSuccessOrderNumber1 = new Label();
            Label14 = new Label();
            CbbSynchronizeTime = new ComboBox();
            LbSynchronizeTime = new Label();
            TbLinkGGSheet = new TextBox();
            LbGoogleSheetLink = new Label();
            LbNameCustomer = new Label();
            LbPhoneNumber = new Label();
            TbPhoneNumber = new TextBox();
            LbEmail = new Label();
            TbEmail = new TextBox();
            LbDeliveryAddress = new Label();
            TbDeliveryAddress = new TextBox();
            LbTransactionType = new Label();
            PanelOrderDetails = new Panel();
            Panel1 = new Panel();
            LbProductName = new Label();
            BtnAddPackage = new EcosystemApp.GUI.Components.RJButton();
            LbQuantity = new Label();
            BtnAddProduct = new EcosystemApp.GUI.Components.RJButton();
            TbQuantity = new TextBox();
            LbSuggestions = new ListBox();
            LbPackageID = new Label();
            TbProductName = new TextBox();
            TbPackageID = new TextBox();
            BtnAdd = new EcosystemApp.GUI.Components.RJButton();
            DgvProduct = new DataGridView();
            NumberColumn = new DataGridViewTextBoxColumn();
            IDColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            TotalPriceColumn = new DataGridViewTextBoxColumn();
            PanelTotalAmount = new Panel();
            BtnDeleteItem = new EcosystemApp.GUI.Components.RJButton();
            LbTotalPrice = new Label();
            LbWarning = new Label();
            PanelManual = new Panel();
            BtnCancel = new EcosystemApp.GUI.Components.RJButton();
            BtnAddOrder = new EcosystemApp.GUI.Components.RJButton();
            RadioBanking = new RadioButton();
            RadioCash = new RadioButton();
            TbExtraInformation = new Label();
            TbNameCustomer = new TextBox();
            PanelFromExcel.SuspendLayout();
            PanelGGSheet.SuspendLayout();
            PanelOrderDetails.SuspendLayout();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).BeginInit();
            PanelTotalAmount.SuspendLayout();
            PanelManual.SuspendLayout();
            SuspendLayout();
            // 
            // BtnManual
            // 
            BtnManual.BackColor = Color.FromArgb(228, 255, 207);
            BtnManual.Dock = DockStyle.Top;
            BtnManual.FlatStyle = FlatStyle.Flat;
            BtnManual.Location = new Point(0, 0);
            BtnManual.Margin = new Padding(2, 2, 2, 2);
            BtnManual.Name = "BtnManual";
            BtnManual.Size = new Size(1184, 62);
            BtnManual.TabIndex = 0;
            BtnManual.Text = "Nhập thủ công";
            BtnManual.UseVisualStyleBackColor = false;
            BtnManual.Click += BtnManualClick;
            // 
            // BtnFromExcel
            // 
            BtnFromExcel.BackColor = Color.FromArgb(228, 255, 207);
            BtnFromExcel.Dock = DockStyle.Top;
            BtnFromExcel.FlatStyle = FlatStyle.Flat;
            BtnFromExcel.Location = new Point(0, 504);
            BtnFromExcel.Margin = new Padding(2, 2, 2, 2);
            BtnFromExcel.Name = "BtnFromExcel";
            BtnFromExcel.Size = new Size(1184, 66);
            BtnFromExcel.TabIndex = 1;
            BtnFromExcel.Text = "Nhập từ Excel / CSV";
            BtnFromExcel.UseVisualStyleBackColor = false;
            BtnFromExcel.Click += BtnFromExcelClick;
            // 
            // BtnFromGGSheet
            // 
            BtnFromGGSheet.BackColor = Color.FromArgb(228, 255, 207);
            BtnFromGGSheet.Dock = DockStyle.Top;
            BtnFromGGSheet.FlatStyle = FlatStyle.Flat;
            BtnFromGGSheet.Location = new Point(0, 818);
            BtnFromGGSheet.Margin = new Padding(2, 2, 2, 2);
            BtnFromGGSheet.Name = "BtnFromGGSheet";
            BtnFromGGSheet.Size = new Size(1184, 62);
            BtnFromGGSheet.TabIndex = 2;
            BtnFromGGSheet.Text = "Nhập từ Google Sheet";
            BtnFromGGSheet.UseVisualStyleBackColor = false;
            BtnFromGGSheet.Click += BtnFromGGSheetClick;
            // 
            // PanelFromExcel
            // 
            PanelFromExcel.BackColor = Color.FromArgb(228, 255, 207);
            PanelFromExcel.Controls.Add(BtnGetDataExcel);
            PanelFromExcel.Controls.Add(ChosenFile);
            PanelFromExcel.Controls.Add(LbExcelWarning);
            PanelFromExcel.Controls.Add(LbSheet);
            PanelFromExcel.Controls.Add(CbbSheetNameFromExcel);
            PanelFromExcel.Controls.Add(TbOrderExcelFault);
            PanelFromExcel.Controls.Add(LbText3);
            PanelFromExcel.Controls.Add(TbOrderExcelSucess);
            PanelFromExcel.Controls.Add(LbText1);
            PanelFromExcel.Controls.Add(LbText2);
            PanelFromExcel.Controls.Add(LbWarningFile);
            PanelFromExcel.Controls.Add(TbFile);
            PanelFromExcel.Controls.Add(LbImportFile);
            PanelFromExcel.Dock = DockStyle.Top;
            PanelFromExcel.Location = new Point(0, 570);
            PanelFromExcel.Margin = new Padding(2, 2, 2, 2);
            PanelFromExcel.Name = "PanelFromExcel";
            PanelFromExcel.Size = new Size(1184, 248);
            PanelFromExcel.TabIndex = 4;
            // 
            // BtnGetDataExcel
            // 
            BtnGetDataExcel.BackColor = Color.FromArgb(196, 238, 181);
            BtnGetDataExcel.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnGetDataExcel.BoderSize = 2;
            BtnGetDataExcel.BorderColor = Color.Black;
            BtnGetDataExcel.BorderRadius = 40;
            BtnGetDataExcel.FlatAppearance.BorderSize = 0;
            BtnGetDataExcel.FlatStyle = FlatStyle.Flat;
            BtnGetDataExcel.ForeColor = Color.Black;
            BtnGetDataExcel.Location = new Point(266, 172);
            BtnGetDataExcel.Margin = new Padding(5, 5, 5, 5);
            BtnGetDataExcel.Name = "BtnGetDataExcel";
            BtnGetDataExcel.Size = new Size(180, 48);
            BtnGetDataExcel.TabIndex = 32;
            BtnGetDataExcel.Text = "Lấy dữ liệu";
            BtnGetDataExcel.TextColor = Color.Black;
            BtnGetDataExcel.UseVisualStyleBackColor = false;
            BtnGetDataExcel.Click += BtnGetDataExcelClick;
            // 
            // ChosenFile
            // 
            ChosenFile.BackColor = Color.FromArgb(224, 224, 224);
            ChosenFile.BackgroundColor = Color.FromArgb(224, 224, 224);
            ChosenFile.BoderSize = 2;
            ChosenFile.BorderColor = Color.Black;
            ChosenFile.BorderRadius = 40;
            ChosenFile.FlatAppearance.BorderSize = 0;
            ChosenFile.FlatStyle = FlatStyle.Flat;
            ChosenFile.ForeColor = Color.Black;
            ChosenFile.Location = new Point(769, 34);
            ChosenFile.Margin = new Padding(2, 2, 2, 2);
            ChosenFile.Name = "ChosenFile";
            ChosenFile.Size = new Size(152, 41);
            ChosenFile.TabIndex = 31;
            ChosenFile.Text = "Chọn file";
            ChosenFile.TextColor = Color.Black;
            ChosenFile.UseVisualStyleBackColor = false;
            ChosenFile.Click += ChosenFileClick;
            // 
            // LbExcelWarning
            // 
            LbExcelWarning.AutoSize = true;
            LbExcelWarning.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbExcelWarning.ForeColor = Color.Red;
            LbExcelWarning.Location = new Point(501, 91);
            LbExcelWarning.Margin = new Padding(2, 0, 2, 0);
            LbExcelWarning.Name = "LbExcelWarning";
            LbExcelWarning.Size = new Size(0, 20);
            LbExcelWarning.TabIndex = 30;
            // 
            // LbSheet
            // 
            LbSheet.AutoSize = true;
            LbSheet.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbSheet.Location = new Point(155, 116);
            LbSheet.Margin = new Padding(5, 0, 5, 0);
            LbSheet.Name = "LbSheet";
            LbSheet.Size = new Size(55, 23);
            LbSheet.TabIndex = 29;
            LbSheet.Text = "Sheet";
            // 
            // CbbSheetNameFromExcel
            // 
            CbbSheetNameFromExcel.FormattingEnabled = true;
            CbbSheetNameFromExcel.Location = new Point(266, 117);
            CbbSheetNameFromExcel.Margin = new Padding(5, 5, 5, 5);
            CbbSheetNameFromExcel.Name = "CbbSheetNameFromExcel";
            CbbSheetNameFromExcel.Size = new Size(182, 28);
            CbbSheetNameFromExcel.TabIndex = 28;
            // 
            // TbOrderExcelFault
            // 
            TbOrderExcelFault.BackColor = Color.FromArgb(228, 255, 207);
            TbOrderExcelFault.BorderStyle = BorderStyle.FixedSingle;
            TbOrderExcelFault.Enabled = false;
            TbOrderExcelFault.ForeColor = Color.Red;
            TbOrderExcelFault.Location = new Point(480, 204);
            TbOrderExcelFault.Margin = new Padding(5, 5, 5, 5);
            TbOrderExcelFault.Multiline = true;
            TbOrderExcelFault.Name = "TbOrderExcelFault";
            TbOrderExcelFault.Size = new Size(57, 29);
            TbOrderExcelFault.TabIndex = 27;
            TbOrderExcelFault.TextAlign = HorizontalAlignment.Center;
            TbOrderExcelFault.Visible = false;
            // 
            // LbText3
            // 
            LbText3.AutoSize = true;
            LbText3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText3.ForeColor = Color.Red;
            LbText3.Location = new Point(546, 212);
            LbText3.Margin = new Padding(5, 0, 5, 0);
            LbText3.Name = "LbText3";
            LbText3.Size = new Size(214, 20);
            LbText3.TabIndex = 26;
            LbText3.Text = "đơn hàng bị lỗi do sai cú pháp.";
            LbText3.Visible = false;
            // 
            // TbOrderExcelSucess
            // 
            TbOrderExcelSucess.BackColor = Color.FromArgb(228, 255, 207);
            TbOrderExcelSucess.BorderStyle = BorderStyle.FixedSingle;
            TbOrderExcelSucess.Enabled = false;
            TbOrderExcelSucess.ForeColor = Color.FromArgb(86, 142, 89);
            TbOrderExcelSucess.Location = new Point(548, 156);
            TbOrderExcelSucess.Margin = new Padding(5, 5, 5, 5);
            TbOrderExcelSucess.Multiline = true;
            TbOrderExcelSucess.Name = "TbOrderExcelSucess";
            TbOrderExcelSucess.Size = new Size(56, 30);
            TbOrderExcelSucess.TabIndex = 24;
            TbOrderExcelSucess.TextAlign = HorizontalAlignment.Center;
            TbOrderExcelSucess.Visible = false;
            // 
            // LbText1
            // 
            LbText1.AutoSize = true;
            LbText1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText1.ForeColor = Color.FromArgb(86, 142, 89);
            LbText1.Location = new Point(614, 166);
            LbText1.Margin = new Padding(5, 0, 5, 0);
            LbText1.Name = "LbText1";
            LbText1.Size = new Size(201, 20);
            LbText1.TabIndex = 23;
            LbText1.Text = "đơn hàng mới từ Excel / CSV.";
            LbText1.Visible = false;
            // 
            // LbText2
            // 
            LbText2.AutoSize = true;
            LbText2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText2.ForeColor = Color.FromArgb(86, 142, 89);
            LbText2.Location = new Point(474, 166);
            LbText2.Margin = new Padding(5, 0, 5, 0);
            LbText2.Name = "LbText2";
            LbText2.Size = new Size(64, 20);
            LbText2.TabIndex = 22;
            LbText2.Text = "Đã nhận";
            LbText2.Visible = false;
            // 
            // LbWarningFile
            // 
            LbWarningFile.AutoSize = true;
            LbWarningFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbWarningFile.ForeColor = Color.Red;
            LbWarningFile.Location = new Point(266, 77);
            LbWarningFile.Name = "LbWarningFile";
            LbWarningFile.Size = new Size(213, 20);
            LbWarningFile.TabIndex = 20;
            LbWarningFile.Text = "Lưu ý: chấp nhận đuôi .csv/.xlsx";
            // 
            // TbFile
            // 
            TbFile.BorderStyle = BorderStyle.FixedSingle;
            TbFile.Location = new Point(266, 34);
            TbFile.Margin = new Padding(2, 2, 2, 2);
            TbFile.Multiline = true;
            TbFile.Name = "TbFile";
            TbFile.Size = new Size(489, 42);
            TbFile.TabIndex = 17;
            TbFile.TextChanged += TbFileTextChanged;
            // 
            // LbImportFile
            // 
            LbImportFile.AutoSize = true;
            LbImportFile.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbImportFile.Location = new Point(23, 46);
            LbImportFile.Margin = new Padding(2, 0, 2, 0);
            LbImportFile.Name = "LbImportFile";
            LbImportFile.Size = new Size(192, 23);
            LbImportFile.TabIndex = 17;
            LbImportFile.Text = "Import file Excel / CSV";
            // 
            // PanelGGSheet
            // 
            PanelGGSheet.BackColor = Color.FromArgb(228, 255, 207);
            PanelGGSheet.Controls.Add(BtnCopy);
            PanelGGSheet.Controls.Add(TbEmailClientInformation);
            PanelGGSheet.Controls.Add(LbEmailSharing);
            PanelGGSheet.Controls.Add(BtnCancelSync);
            PanelGGSheet.Controls.Add(BtnSyncNow);
            PanelGGSheet.Controls.Add(BtnTestConnection);
            PanelGGSheet.Controls.Add(LbSheetName);
            PanelGGSheet.Controls.Add(TbSheetName);
            PanelGGSheet.Controls.Add(TbOrderSheetFault);
            PanelGGSheet.Controls.Add(LbErrorOrderNumber);
            PanelGGSheet.Controls.Add(TbOrderSheetSuccess);
            PanelGGSheet.Controls.Add(TbTime);
            PanelGGSheet.Controls.Add(LbSuccessOrderNumber);
            PanelGGSheet.Controls.Add(LbSuccessOrderNumber1);
            PanelGGSheet.Controls.Add(Label14);
            PanelGGSheet.Controls.Add(CbbSynchronizeTime);
            PanelGGSheet.Controls.Add(LbSynchronizeTime);
            PanelGGSheet.Controls.Add(TbLinkGGSheet);
            PanelGGSheet.Controls.Add(LbGoogleSheetLink);
            PanelGGSheet.Dock = DockStyle.Top;
            PanelGGSheet.Location = new Point(0, 880);
            PanelGGSheet.Margin = new Padding(2, 2, 2, 2);
            PanelGGSheet.Name = "PanelGGSheet";
            PanelGGSheet.Size = new Size(1184, 358);
            PanelGGSheet.TabIndex = 5;
            // 
            // BtnCopy
            // 
            BtnCopy.BackColor = Color.FromArgb(196, 238, 181);
            BtnCopy.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnCopy.BoderSize = 2;
            BtnCopy.BorderColor = Color.Black;
            BtnCopy.BorderRadius = 40;
            BtnCopy.FlatAppearance.BorderSize = 0;
            BtnCopy.FlatStyle = FlatStyle.Flat;
            BtnCopy.ForeColor = Color.Black;
            BtnCopy.Location = new Point(890, 128);
            BtnCopy.Margin = new Padding(2, 2, 2, 2);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(131, 41);
            BtnCopy.TabIndex = 45;
            BtnCopy.Text = "Sao chép";
            BtnCopy.TextColor = Color.Black;
            BtnCopy.UseVisualStyleBackColor = false;
            BtnCopy.Click += BtnCopyClick;
            // 
            // TbEmailClientInformation
            // 
            TbEmailClientInformation.BorderStyle = BorderStyle.FixedSingle;
            TbEmailClientInformation.Location = new Point(375, 128);
            TbEmailClientInformation.Margin = new Padding(2, 2, 2, 2);
            TbEmailClientInformation.Multiline = true;
            TbEmailClientInformation.Name = "TbEmailClientInformation";
            TbEmailClientInformation.Size = new Size(507, 42);
            TbEmailClientInformation.TabIndex = 44;
            // 
            // LbEmailSharing
            // 
            LbEmailSharing.AutoSize = true;
            LbEmailSharing.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbEmailSharing.Location = new Point(199, 137);
            LbEmailSharing.Margin = new Padding(2, 0, 2, 0);
            LbEmailSharing.Name = "LbEmailSharing";
            LbEmailSharing.Size = new Size(127, 23);
            LbEmailSharing.TabIndex = 43;
            LbEmailSharing.Text = "Email đồng bộ";
            // 
            // BtnCancelSync
            // 
            BtnCancelSync.BackColor = Color.FromArgb(196, 238, 181);
            BtnCancelSync.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnCancelSync.BoderSize = 2;
            BtnCancelSync.BorderColor = Color.Black;
            BtnCancelSync.BorderRadius = 40;
            BtnCancelSync.FlatAppearance.BorderSize = 0;
            BtnCancelSync.FlatStyle = FlatStyle.Flat;
            BtnCancelSync.ForeColor = Color.Black;
            BtnCancelSync.Location = new Point(716, 239);
            BtnCancelSync.Margin = new Padding(2, 2, 2, 2);
            BtnCancelSync.Name = "BtnCancelSync";
            BtnCancelSync.Size = new Size(147, 45);
            BtnCancelSync.TabIndex = 42;
            BtnCancelSync.Text = "Hủy đồng bộ";
            BtnCancelSync.TextColor = Color.Black;
            BtnCancelSync.UseVisualStyleBackColor = false;
            BtnCancelSync.Click += BtnCancelSyncClick;
            // 
            // BtnSyncNow
            // 
            BtnSyncNow.BackColor = Color.FromArgb(196, 238, 181);
            BtnSyncNow.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnSyncNow.BoderSize = 2;
            BtnSyncNow.BorderColor = Color.Black;
            BtnSyncNow.BorderRadius = 40;
            BtnSyncNow.FlatAppearance.BorderSize = 0;
            BtnSyncNow.FlatStyle = FlatStyle.Flat;
            BtnSyncNow.ForeColor = Color.Black;
            BtnSyncNow.Location = new Point(546, 239);
            BtnSyncNow.Margin = new Padding(2, 2, 2, 2);
            BtnSyncNow.Name = "BtnSyncNow";
            BtnSyncNow.Size = new Size(147, 45);
            BtnSyncNow.TabIndex = 41;
            BtnSyncNow.Text = "Đồng bộ ngay";
            BtnSyncNow.TextColor = Color.Black;
            BtnSyncNow.UseVisualStyleBackColor = false;
            BtnSyncNow.Click += BtnSyncNowClick;
            // 
            // BtnTestConnection
            // 
            BtnTestConnection.BackColor = Color.FromArgb(196, 238, 181);
            BtnTestConnection.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnTestConnection.BoderSize = 2;
            BtnTestConnection.BorderColor = Color.Black;
            BtnTestConnection.BorderRadius = 40;
            BtnTestConnection.FlatAppearance.BorderSize = 0;
            BtnTestConnection.FlatStyle = FlatStyle.Flat;
            BtnTestConnection.ForeColor = Color.Black;
            BtnTestConnection.Location = new Point(373, 239);
            BtnTestConnection.Margin = new Padding(2, 2, 2, 2);
            BtnTestConnection.Name = "BtnTestConnection";
            BtnTestConnection.Size = new Size(147, 45);
            BtnTestConnection.TabIndex = 40;
            BtnTestConnection.Text = "Kiểm tra kết nối";
            BtnTestConnection.TextColor = Color.Black;
            BtnTestConnection.UseVisualStyleBackColor = false;
            BtnTestConnection.Click += BtnTestConnectionClick;
            // 
            // LbSheetName
            // 
            LbSheetName.AutoSize = true;
            LbSheetName.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbSheetName.Location = new Point(242, 75);
            LbSheetName.Margin = new Padding(2, 0, 2, 0);
            LbSheetName.Name = "LbSheetName";
            LbSheetName.Size = new Size(84, 23);
            LbSheetName.TabIndex = 37;
            LbSheetName.Text = "Tên sheet";
            // 
            // TbSheetName
            // 
            TbSheetName.BorderStyle = BorderStyle.FixedSingle;
            TbSheetName.Location = new Point(375, 68);
            TbSheetName.Margin = new Padding(2, 2, 2, 2);
            TbSheetName.Multiline = true;
            TbSheetName.Name = "TbSheetName";
            TbSheetName.Size = new Size(646, 42);
            TbSheetName.TabIndex = 36;
            // 
            // TbOrderSheetFault
            // 
            TbOrderSheetFault.BackColor = Color.FromArgb(228, 255, 207);
            TbOrderSheetFault.BorderStyle = BorderStyle.FixedSingle;
            TbOrderSheetFault.Enabled = false;
            TbOrderSheetFault.ForeColor = Color.Red;
            TbOrderSheetFault.Location = new Point(754, 306);
            TbOrderSheetFault.Margin = new Padding(2, 2, 2, 2);
            TbOrderSheetFault.Multiline = true;
            TbOrderSheetFault.Name = "TbOrderSheetFault";
            TbOrderSheetFault.Size = new Size(57, 30);
            TbOrderSheetFault.TabIndex = 32;
            TbOrderSheetFault.TextAlign = HorizontalAlignment.Center;
            // 
            // LbErrorOrderNumber
            // 
            LbErrorOrderNumber.AutoSize = true;
            LbErrorOrderNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbErrorOrderNumber.ForeColor = Color.Red;
            LbErrorOrderNumber.Location = new Point(814, 308);
            LbErrorOrderNumber.Margin = new Padding(2, 0, 2, 0);
            LbErrorOrderNumber.Name = "LbErrorOrderNumber";
            LbErrorOrderNumber.Size = new Size(214, 20);
            LbErrorOrderNumber.TabIndex = 31;
            LbErrorOrderNumber.Text = "đơn hàng bị lỗi do sai cú pháp.";
            // 
            // TbOrderSheetSuccess
            // 
            TbOrderSheetSuccess.BackColor = Color.FromArgb(228, 255, 207);
            TbOrderSheetSuccess.BorderStyle = BorderStyle.FixedSingle;
            TbOrderSheetSuccess.Enabled = false;
            TbOrderSheetSuccess.ForeColor = Color.FromArgb(86, 142, 89);
            TbOrderSheetSuccess.Location = new Point(450, 306);
            TbOrderSheetSuccess.Margin = new Padding(2, 2, 2, 2);
            TbOrderSheetSuccess.Multiline = true;
            TbOrderSheetSuccess.Name = "TbOrderSheetSuccess";
            TbOrderSheetSuccess.Size = new Size(56, 30);
            TbOrderSheetSuccess.TabIndex = 30;
            TbOrderSheetSuccess.TextAlign = HorizontalAlignment.Center;
            // 
            // TbTime
            // 
            TbTime.BackColor = Color.FromArgb(228, 255, 207);
            TbTime.BorderStyle = BorderStyle.FixedSingle;
            TbTime.ForeColor = Color.Black;
            TbTime.Location = new Point(789, 185);
            TbTime.Margin = new Padding(2, 2, 2, 2);
            TbTime.Multiline = true;
            TbTime.Name = "TbTime";
            TbTime.Size = new Size(75, 27);
            TbTime.TabIndex = 28;
            TbTime.Text = "00:00:00";
            TbTime.TextAlign = HorizontalAlignment.Center;
            // 
            // LbSuccessOrderNumber
            // 
            LbSuccessOrderNumber.AutoSize = true;
            LbSuccessOrderNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbSuccessOrderNumber.ForeColor = Color.FromArgb(86, 142, 89);
            LbSuccessOrderNumber.Location = new Point(509, 308);
            LbSuccessOrderNumber.Margin = new Padding(2, 0, 2, 0);
            LbSuccessOrderNumber.Name = "LbSuccessOrderNumber";
            LbSuccessOrderNumber.Size = new Size(201, 20);
            LbSuccessOrderNumber.TabIndex = 29;
            LbSuccessOrderNumber.Text = "đơn hàng mới từ Excel / CSV.";
            // 
            // LbSuccessOrderNumber1
            // 
            LbSuccessOrderNumber1.AutoSize = true;
            LbSuccessOrderNumber1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbSuccessOrderNumber1.ForeColor = Color.FromArgb(86, 142, 89);
            LbSuccessOrderNumber1.Location = new Point(373, 308);
            LbSuccessOrderNumber1.Margin = new Padding(2, 0, 2, 0);
            LbSuccessOrderNumber1.Name = "LbSuccessOrderNumber1";
            LbSuccessOrderNumber1.Size = new Size(64, 20);
            LbSuccessOrderNumber1.TabIndex = 28;
            LbSuccessOrderNumber1.Text = "Đã nhận";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Segoe UI", 10.125F);
            Label14.ForeColor = Color.Black;
            Label14.Location = new Point(598, 188);
            Label14.Margin = new Padding(2, 0, 2, 0);
            Label14.Name = "Label14";
            Label14.Size = new Size(204, 23);
            Label14.TabIndex = 28;
            Label14.Text = "Lần đồng bộ gần nhất là ";
            // 
            // CbbSynchronizeTime
            // 
            CbbSynchronizeTime.AutoCompleteCustomSource.AddRange(new string[] { "1", "3", "5", "10", "15", "20", "30" });
            CbbSynchronizeTime.FormattingEnabled = true;
            CbbSynchronizeTime.ItemHeight = 20;
            CbbSynchronizeTime.Location = new Point(375, 188);
            CbbSynchronizeTime.Margin = new Padding(2, 2, 2, 2);
            CbbSynchronizeTime.Name = "CbbSynchronizeTime";
            CbbSynchronizeTime.Size = new Size(147, 28);
            CbbSynchronizeTime.TabIndex = 30;
            // 
            // LbSynchronizeTime
            // 
            LbSynchronizeTime.AutoSize = true;
            LbSynchronizeTime.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbSynchronizeTime.Location = new Point(215, 189);
            LbSynchronizeTime.Margin = new Padding(2, 0, 2, 0);
            LbSynchronizeTime.Name = "LbSynchronizeTime";
            LbSynchronizeTime.Size = new Size(115, 23);
            LbSynchronizeTime.TabIndex = 29;
            LbSynchronizeTime.Text = "Lịch đồng bộ";
            // 
            // TbLinkGGSheet
            // 
            TbLinkGGSheet.BorderStyle = BorderStyle.FixedSingle;
            TbLinkGGSheet.Location = new Point(375, 13);
            TbLinkGGSheet.Margin = new Padding(2, 2, 2, 2);
            TbLinkGGSheet.Multiline = true;
            TbLinkGGSheet.Name = "TbLinkGGSheet";
            TbLinkGGSheet.Size = new Size(646, 42);
            TbLinkGGSheet.TabIndex = 28;
            TbLinkGGSheet.TextChanged += TbLinkGGSheetTextChanged;
            // 
            // LbGoogleSheetLink
            // 
            LbGoogleSheetLink.AutoSize = true;
            LbGoogleSheetLink.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbGoogleSheetLink.Location = new Point(174, 22);
            LbGoogleSheetLink.Margin = new Padding(2, 0, 2, 0);
            LbGoogleSheetLink.Name = "LbGoogleSheetLink";
            LbGoogleSheetLink.Size = new Size(156, 23);
            LbGoogleSheetLink.TabIndex = 28;
            LbGoogleSheetLink.Text = "Link Google Sheet";
            // 
            // LbNameCustomer
            // 
            LbNameCustomer.AutoSize = true;
            LbNameCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbNameCustomer.Location = new Point(23, 113);
            LbNameCustomer.Margin = new Padding(2, 0, 2, 0);
            LbNameCustomer.Name = "LbNameCustomer";
            LbNameCustomer.Size = new Size(118, 20);
            LbNameCustomer.TabIndex = 0;
            LbNameCustomer.Text = "Tên khách hàng";
            // 
            // LbPhoneNumber
            // 
            LbPhoneNumber.AutoSize = true;
            LbPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbPhoneNumber.Location = new Point(23, 66);
            LbPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            LbPhoneNumber.Name = "LbPhoneNumber";
            LbPhoneNumber.Size = new Size(100, 20);
            LbPhoneNumber.TabIndex = 2;
            LbPhoneNumber.Text = "Số điện thoại";
            // 
            // TbPhoneNumber
            // 
            TbPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            TbPhoneNumber.Location = new Point(158, 61);
            TbPhoneNumber.Margin = new Padding(2, 2, 2, 2);
            TbPhoneNumber.Multiline = true;
            TbPhoneNumber.Name = "TbPhoneNumber";
            TbPhoneNumber.Size = new Size(263, 33);
            TbPhoneNumber.TabIndex = 3;
            // 
            // LbEmail
            // 
            LbEmail.AutoSize = true;
            LbEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbEmail.Location = new Point(26, 171);
            LbEmail.Margin = new Padding(2, 0, 2, 0);
            LbEmail.Name = "LbEmail";
            LbEmail.Size = new Size(47, 20);
            LbEmail.TabIndex = 4;
            LbEmail.Text = "Email";
            // 
            // TbEmail
            // 
            TbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbEmail.BorderStyle = BorderStyle.FixedSingle;
            TbEmail.Location = new Point(159, 156);
            TbEmail.Margin = new Padding(2, 2, 2, 2);
            TbEmail.Multiline = true;
            TbEmail.Name = "TbEmail";
            TbEmail.Size = new Size(263, 34);
            TbEmail.TabIndex = 5;
            // 
            // LbDeliveryAddress
            // 
            LbDeliveryAddress.AutoSize = true;
            LbDeliveryAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbDeliveryAddress.Location = new Point(23, 260);
            LbDeliveryAddress.Margin = new Padding(2, 0, 2, 0);
            LbDeliveryAddress.Name = "LbDeliveryAddress";
            LbDeliveryAddress.Size = new Size(129, 20);
            LbDeliveryAddress.TabIndex = 6;
            LbDeliveryAddress.Text = "Địa chỉ giao hàng";
            // 
            // TbDeliveryAddress
            // 
            TbDeliveryAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbDeliveryAddress.BorderStyle = BorderStyle.FixedSingle;
            TbDeliveryAddress.Location = new Point(158, 258);
            TbDeliveryAddress.Margin = new Padding(2, 2, 2, 2);
            TbDeliveryAddress.Multiline = true;
            TbDeliveryAddress.Name = "TbDeliveryAddress";
            TbDeliveryAddress.Size = new Size(264, 63);
            TbDeliveryAddress.TabIndex = 7;
            // 
            // LbTransactionType
            // 
            LbTransactionType.AutoSize = true;
            LbTransactionType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LbTransactionType.Location = new Point(26, 219);
            LbTransactionType.Margin = new Padding(2, 0, 2, 0);
            LbTransactionType.Name = "LbTransactionType";
            LbTransactionType.Size = new Size(105, 20);
            LbTransactionType.TabIndex = 8;
            LbTransactionType.Text = "Loại giao dịch";
            // 
            // PanelOrderDetails
            // 
            PanelOrderDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelOrderDetails.BackColor = Color.White;
            PanelOrderDetails.BorderStyle = BorderStyle.FixedSingle;
            PanelOrderDetails.Controls.Add(Panel1);
            PanelOrderDetails.Controls.Add(PanelTotalAmount);
            PanelOrderDetails.Location = new Point(463, 22);
            PanelOrderDetails.Margin = new Padding(2, 2, 2, 2);
            PanelOrderDetails.Name = "PanelOrderDetails";
            PanelOrderDetails.Size = new Size(675, 346);
            PanelOrderDetails.TabIndex = 10;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(LbProductName);
            Panel1.Controls.Add(BtnAddPackage);
            Panel1.Controls.Add(LbQuantity);
            Panel1.Controls.Add(BtnAddProduct);
            Panel1.Controls.Add(TbQuantity);
            Panel1.Controls.Add(LbSuggestions);
            Panel1.Controls.Add(LbPackageID);
            Panel1.Controls.Add(TbProductName);
            Panel1.Controls.Add(TbPackageID);
            Panel1.Controls.Add(BtnAdd);
            Panel1.Controls.Add(DgvProduct);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(2, 2, 2, 2);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(673, 307);
            Panel1.TabIndex = 23;
            // 
            // LbProductName
            // 
            LbProductName.AutoSize = true;
            LbProductName.Location = new Point(23, 52);
            LbProductName.Margin = new Padding(2, 0, 2, 0);
            LbProductName.Name = "LbProductName";
            LbProductName.Size = new Size(100, 20);
            LbProductName.TabIndex = 1;
            LbProductName.Text = "Tên sản phẩm";
            // 
            // BtnAddPackage
            // 
            BtnAddPackage.BackColor = Color.White;
            BtnAddPackage.BackgroundColor = Color.White;
            BtnAddPackage.BoderSize = 0;
            BtnAddPackage.BorderColor = Color.White;
            BtnAddPackage.BorderRadius = 0;
            BtnAddPackage.FlatAppearance.BorderSize = 0;
            BtnAddPackage.FlatStyle = FlatStyle.Flat;
            BtnAddPackage.ForeColor = Color.Black;
            BtnAddPackage.Location = new Point(139, 4);
            BtnAddPackage.Margin = new Padding(2, 2, 2, 2);
            BtnAddPackage.Name = "BtnAddPackage";
            BtnAddPackage.Size = new Size(134, 34);
            BtnAddPackage.TabIndex = 22;
            BtnAddPackage.Text = "Thêm bao bì";
            BtnAddPackage.TextColor = Color.Black;
            BtnAddPackage.UseVisualStyleBackColor = false;
            BtnAddPackage.Click += BtnAddPackageClick;
            // 
            // LbQuantity
            // 
            LbQuantity.AutoSize = true;
            LbQuantity.Location = new Point(314, 51);
            LbQuantity.Margin = new Padding(2, 0, 2, 0);
            LbQuantity.Name = "LbQuantity";
            LbQuantity.Size = new Size(69, 20);
            LbQuantity.TabIndex = 3;
            LbQuantity.Text = "Số lượng";
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.BackColor = Color.White;
            BtnAddProduct.BackgroundColor = Color.White;
            BtnAddProduct.BoderSize = 0;
            BtnAddProduct.BorderColor = Color.White;
            BtnAddProduct.BorderRadius = 0;
            BtnAddProduct.FlatAppearance.BorderSize = 0;
            BtnAddProduct.FlatStyle = FlatStyle.Flat;
            BtnAddProduct.ForeColor = Color.Black;
            BtnAddProduct.Location = new Point(2, 4);
            BtnAddProduct.Margin = new Padding(2, 2, 2, 2);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(134, 34);
            BtnAddProduct.TabIndex = 21;
            BtnAddProduct.Text = "Thêm sản phẩm";
            BtnAddProduct.TextColor = Color.Black;
            BtnAddProduct.UseVisualStyleBackColor = false;
            BtnAddProduct.Click += BtnAddProductClick;
            // 
            // TbQuantity
            // 
            TbQuantity.BorderStyle = BorderStyle.FixedSingle;
            TbQuantity.Location = new Point(386, 50);
            TbQuantity.Margin = new Padding(2, 2, 2, 2);
            TbQuantity.Name = "TbQuantity";
            TbQuantity.Size = new Size(70, 27);
            TbQuantity.TabIndex = 11;
            TbQuantity.KeyPress += TbQuantityKeyPress;
            // 
            // LbSuggestions
            // 
            LbSuggestions.FormattingEnabled = true;
            LbSuggestions.Location = new Point(128, 79);
            LbSuggestions.Name = "LbSuggestions";
            LbSuggestions.Size = new Size(175, 64);
            LbSuggestions.TabIndex = 20;
            LbSuggestions.Click += LbSuggestionsClick;
            // 
            // LbPackageID
            // 
            LbPackageID.AutoSize = true;
            LbPackageID.Location = new Point(18, 52);
            LbPackageID.Margin = new Padding(2, 0, 2, 0);
            LbPackageID.Name = "LbPackageID";
            LbPackageID.Size = new Size(106, 20);
            LbPackageID.TabIndex = 16;
            LbPackageID.Text = "Mã serial code";
            // 
            // TbProductName
            // 
            TbProductName.BorderStyle = BorderStyle.FixedSingle;
            TbProductName.Location = new Point(128, 49);
            TbProductName.Name = "TbProductName";
            TbProductName.Size = new Size(174, 27);
            TbProductName.TabIndex = 19;
            TbProductName.TextChanged += TbProductNameTextChanged;
            TbProductName.Enter += TbProductNameEnter;
            TbProductName.KeyDown += TbProductNameKeyDown;
            TbProductName.Leave += TbProductNameLeave;
            // 
            // TbPackageID
            // 
            TbPackageID.BorderStyle = BorderStyle.FixedSingle;
            TbPackageID.Location = new Point(128, 49);
            TbPackageID.Margin = new Padding(2, 2, 2, 2);
            TbPackageID.Name = "TbPackageID";
            TbPackageID.Size = new Size(174, 27);
            TbPackageID.TabIndex = 17;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.White;
            BtnAdd.BackgroundColor = Color.White;
            BtnAdd.BoderSize = 3;
            BtnAdd.BorderColor = Color.DeepSkyBlue;
            BtnAdd.BorderRadius = 32;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.DeepSkyBlue;
            BtnAdd.Location = new Point(458, 46);
            BtnAdd.Margin = new Padding(2, 2, 2, 2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(65, 32);
            BtnAdd.TabIndex = 18;
            BtnAdd.Text = "Thêm";
            BtnAdd.TextColor = Color.DeepSkyBlue;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAddClick;
            BtnAdd.MouseEnter += BtnAddProductMouseEnter;
            BtnAdd.MouseLeave += BtnAddProductMouseLeave;
            BtnAdd.MouseHover += BtnAddProductMouseHover;
            // 
            // DgvProduct
            // 
            DgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProduct.BackgroundColor = Color.White;
            DgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProduct.Columns.AddRange(new DataGridViewColumn[] { NumberColumn, IDColumn, ProductNameColumn, QuantityColumn, TotalPriceColumn });
            DgvProduct.Dock = DockStyle.Bottom;
            DgvProduct.Location = new Point(0, 106);
            DgvProduct.Margin = new Padding(2, 2, 2, 2);
            DgvProduct.Name = "DgvProduct";
            DgvProduct.RowHeadersVisible = false;
            DgvProduct.RowHeadersWidth = 82;
            DgvProduct.Size = new Size(673, 201);
            DgvProduct.TabIndex = 0;
            DgvProduct.CellClick += DgvCellClick;
            // 
            // NumberColumn
            // 
            NumberColumn.FillWeight = 30F;
            NumberColumn.HeaderText = "STT";
            NumberColumn.MinimumWidth = 6;
            NumberColumn.Name = "NumberColumn";
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "Mã sản phẩm";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.FillWeight = 183.91806F;
            ProductNameColumn.HeaderText = "Tên sản phẩm";
            ProductNameColumn.MinimumWidth = 6;
            ProductNameColumn.Name = "ProductNameColumn";
            // 
            // QuantityColumn
            // 
            QuantityColumn.FillWeight = 141.176437F;
            QuantityColumn.HeaderText = "Số lượng";
            QuantityColumn.MinimumWidth = 6;
            QuantityColumn.Name = "QuantityColumn";
            // 
            // TotalPriceColumn
            // 
            TotalPriceColumn.FillWeight = 75.56112F;
            TotalPriceColumn.HeaderText = "Thành tiền";
            TotalPriceColumn.MinimumWidth = 6;
            TotalPriceColumn.Name = "TotalPriceColumn";
            // 
            // PanelTotalAmount
            // 
            PanelTotalAmount.Controls.Add(BtnDeleteItem);
            PanelTotalAmount.Controls.Add(LbTotalPrice);
            PanelTotalAmount.Dock = DockStyle.Bottom;
            PanelTotalAmount.Location = new Point(0, 307);
            PanelTotalAmount.Margin = new Padding(2, 2, 2, 2);
            PanelTotalAmount.Name = "PanelTotalAmount";
            PanelTotalAmount.Size = new Size(673, 37);
            PanelTotalAmount.TabIndex = 13;
            // 
            // BtnDeleteItem
            // 
            BtnDeleteItem.BackColor = Color.White;
            BtnDeleteItem.BackgroundColor = Color.White;
            BtnDeleteItem.BoderSize = 0;
            BtnDeleteItem.BorderColor = Color.Red;
            BtnDeleteItem.BorderRadius = 0;
            BtnDeleteItem.FlatAppearance.BorderSize = 0;
            BtnDeleteItem.FlatStyle = FlatStyle.Flat;
            BtnDeleteItem.ForeColor = Color.White;
            BtnDeleteItem.Image = (Image)resources.GetObject("BtnDeleteItem.Image");
            BtnDeleteItem.Location = new Point(1, 1);
            BtnDeleteItem.Margin = new Padding(1, 1, 1, 1);
            BtnDeleteItem.Name = "BtnDeleteItem";
            BtnDeleteItem.Size = new Size(55, 36);
            BtnDeleteItem.TabIndex = 20;
            BtnDeleteItem.TextColor = Color.White;
            BtnDeleteItem.UseVisualStyleBackColor = false;
            BtnDeleteItem.Click += BtnDeleteItemClick;
            // 
            // LbTotalPrice
            // 
            LbTotalPrice.AutoSize = true;
            LbTotalPrice.Location = new Point(505, 8);
            LbTotalPrice.Margin = new Padding(2, 0, 2, 0);
            LbTotalPrice.Name = "LbTotalPrice";
            LbTotalPrice.Size = new Size(87, 20);
            LbTotalPrice.TabIndex = 15;
            LbTotalPrice.Text = "Tổng tiền: 0";
            // 
            // LbWarning
            // 
            LbWarning.AutoSize = true;
            LbWarning.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbWarning.ForeColor = Color.Red;
            LbWarning.Location = new Point(464, 382);
            LbWarning.Name = "LbWarning";
            LbWarning.Size = new Size(107, 17);
            LbWarning.TabIndex = 15;
            LbWarning.Text = "Chỉ được điền số";
            LbWarning.Visible = false;
            // 
            // PanelManual
            // 
            PanelManual.BackColor = Color.FromArgb(228, 255, 207);
            PanelManual.Controls.Add(BtnCancel);
            PanelManual.Controls.Add(BtnAddOrder);
            PanelManual.Controls.Add(RadioBanking);
            PanelManual.Controls.Add(RadioCash);
            PanelManual.Controls.Add(LbTransactionType);
            PanelManual.Controls.Add(LbWarning);
            PanelManual.Controls.Add(TbDeliveryAddress);
            PanelManual.Controls.Add(TbExtraInformation);
            PanelManual.Controls.Add(LbDeliveryAddress);
            PanelManual.Controls.Add(TbEmail);
            PanelManual.Controls.Add(LbEmail);
            PanelManual.Controls.Add(TbPhoneNumber);
            PanelManual.Controls.Add(LbPhoneNumber);
            PanelManual.Controls.Add(TbNameCustomer);
            PanelManual.Controls.Add(LbNameCustomer);
            PanelManual.Controls.Add(PanelOrderDetails);
            PanelManual.Dock = DockStyle.Top;
            PanelManual.Location = new Point(0, 62);
            PanelManual.Margin = new Padding(2, 2, 2, 2);
            PanelManual.Name = "PanelManual";
            PanelManual.Size = new Size(1184, 442);
            PanelManual.TabIndex = 3;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.BackgroundColor = Color.FromArgb(224, 224, 224);
            BtnCancel.BoderSize = 2;
            BtnCancel.BorderColor = Color.Black;
            BtnCancel.BorderRadius = 40;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.Location = new Point(906, 382);
            BtnCancel.Margin = new Padding(2, 2, 2, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(97, 44);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "Hủy";
            BtnCancel.TextColor = Color.Black;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancelClick;
            // 
            // BtnAddOrder
            // 
            BtnAddOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAddOrder.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddOrder.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAddOrder.BoderSize = 2;
            BtnAddOrder.BorderColor = Color.Black;
            BtnAddOrder.BorderRadius = 40;
            BtnAddOrder.FlatAppearance.BorderSize = 0;
            BtnAddOrder.FlatStyle = FlatStyle.Flat;
            BtnAddOrder.ForeColor = Color.Black;
            BtnAddOrder.Location = new Point(1007, 382);
            BtnAddOrder.Margin = new Padding(2, 2, 2, 2);
            BtnAddOrder.Name = "BtnAddOrder";
            BtnAddOrder.Size = new Size(130, 44);
            BtnAddOrder.TabIndex = 20;
            BtnAddOrder.Text = "Thêm đơn hàng";
            BtnAddOrder.TextColor = Color.Black;
            BtnAddOrder.UseVisualStyleBackColor = false;
            BtnAddOrder.Click += BtnAddOrderClick;
            // 
            // RadioBanking
            // 
            RadioBanking.AutoSize = true;
            RadioBanking.Location = new Point(299, 219);
            RadioBanking.Name = "RadioBanking";
            RadioBanking.Size = new Size(122, 24);
            RadioBanking.TabIndex = 19;
            RadioBanking.TabStop = true;
            RadioBanking.Text = "Chuyển khoản";
            RadioBanking.UseVisualStyleBackColor = true;
            // 
            // RadioCash
            // 
            RadioCash.AutoSize = true;
            RadioCash.Location = new Point(159, 218);
            RadioCash.Name = "RadioCash";
            RadioCash.Size = new Size(88, 24);
            RadioCash.TabIndex = 18;
            RadioCash.TabStop = true;
            RadioCash.Text = "Tiền mặt";
            RadioCash.UseVisualStyleBackColor = true;
            // 
            // TbExtraInformation
            // 
            TbExtraInformation.AutoSize = true;
            TbExtraInformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TbExtraInformation.Location = new Point(23, 280);
            TbExtraInformation.Margin = new Padding(2, 0, 2, 0);
            TbExtraInformation.Name = "TbExtraInformation";
            TbExtraInformation.Size = new Size(67, 20);
            TbExtraInformation.TabIndex = 6;
            TbExtraInformation.Text = "(nếu có)";
            // 
            // TbNameCustomer
            // 
            TbNameCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbNameCustomer.BorderStyle = BorderStyle.FixedSingle;
            TbNameCustomer.Location = new Point(158, 111);
            TbNameCustomer.Margin = new Padding(2, 2, 2, 2);
            TbNameCustomer.Multiline = true;
            TbNameCustomer.Name = "TbNameCustomer";
            TbNameCustomer.Size = new Size(263, 31);
            TbNameCustomer.TabIndex = 1;
            // 
            // CollectDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 1055);
            Controls.Add(PanelGGSheet);
            Controls.Add(BtnFromGGSheet);
            Controls.Add(PanelFromExcel);
            Controls.Add(BtnFromExcel);
            Controls.Add(PanelManual);
            Controls.Add(BtnManual);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CollectDataForm";
            Text = "CollectDataForm";
            FormClosing += CollectDataFormFormClosing;
            Load += CollectDataFormLoad;
            PanelFromExcel.ResumeLayout(false);
            PanelFromExcel.PerformLayout();
            PanelGGSheet.ResumeLayout(false);
            PanelGGSheet.PerformLayout();
            PanelOrderDetails.ResumeLayout(false);
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).EndInit();
            PanelTotalAmount.ResumeLayout(false);
            PanelTotalAmount.PerformLayout();
            PanelManual.ResumeLayout(false);
            PanelManual.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnManual;
        private Button BtnFromExcel;
        private Button BtnFromGGSheet;
        private Panel PanelFromExcel;
        private Panel PanelGGSheet;
        private Label LbImportFile;
        private Label LbWarningFile;
        private TextBox TbFile;
        private TextBox TbOrderExcelSucess;
        private Label LbText1;
        private Label LbText2;
        private TextBox TbOrderExcelFault;
        private Label LbText3;
        private Label LbGoogleSheetLink;
        private TextBox TbTime;
        private Label Label14;
        private ComboBox CbbSynchronizeTime;
        private Label LbSynchronizeTime;
        private TextBox TbLinkGGSheet;
        private TextBox TbOrderSheetFault;
        private Label LbErrorOrderNumber;
        private TextBox TbOrderSheetSuccess;
        private Label LbSuccessOrderNumber;
        private Label LbSuccessOrderNumber1;
        private ComboBox CbbSheetNameFromExcel;
        private Label LbSheet;
        private Label LbNameCustomer;
        private Label LbPhoneNumber;
        private TextBox TbPhoneNumber;
        private Label LbEmail;
        private TextBox TbEmail;
        private Label LbDeliveryAddress;
        private TextBox TbDeliveryAddress;
        private Label LbTransactionType;
        private Panel PanelOrderDetails;
        private TextBox TbPackageID;
        private Label LbPackageID;
        private Label LbWarning;
        private Panel PanelTotalAmount;
        private Label LbTotalPrice;
        private TextBox TbQuantity;
        private Label LbQuantity;
        private Label LbProductName;
        private Panel PanelManual;
        private TextBox TbNameCustomer;
        private RadioButton RadioBanking;
        private RadioButton RadioCash;
        private Label LbExcelWarning;
        private Label LbSheetName;
        private TextBox TbSheetName;
        private Components.RJButton BtnAdd;
        private Components.RJButton BtnDeleteItem;
        private Components.RJButton BtnAddOrder;
        private Components.RJButton BtnCancel;
        private Components.RJButton ChosenFile;
        private Components.RJButton BtnGetDataExcel;
        private Components.RJButton BtnTestConnection;
        private Components.RJButton BtnSyncNow;
        private Components.RJButton BtnCancelSync;
        private Label LbEmailSharing;
        private Components.RJButton BtnCopy;
        private TextBox TbEmailClientInformation;
        private TextBox TbProductName;
        private ListBox LbSuggestions;
        private Components.RJButton BtnAddProduct;
        private Components.RJButton BtnAddPackage;
        private Panel Panel1;
        private DataGridView DgvProduct;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn TotalPriceColumn;
        private Label TbExtraInformation;
    }
}