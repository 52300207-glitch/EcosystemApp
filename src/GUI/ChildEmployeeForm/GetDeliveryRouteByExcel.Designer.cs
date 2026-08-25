namespace EcosystemApp.GUI.ChildEmployeeForm
{
    partial class GetDeliveryRouteByExcel
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
            Panel1 = new Panel();
            LbImportFile = new Label();
            LbSheet = new Label();
            LbText3 = new Label();
            LbText1 = new Label();
            LbText2 = new Label();
            TbOrderExcelFault = new TextBox();
            TbOrderExcelSucess = new TextBox();
            BtnGetDataExcel = new EcosystemApp.GUI.Components.RJButton();
            ChosenFile = new EcosystemApp.GUI.Components.RJButton();
            CbbSheetNameFromExcel = new ComboBox();
            TbFile = new TextBox();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(228, 255, 207);
            Panel1.Controls.Add(LbImportFile);
            Panel1.Controls.Add(LbSheet);
            Panel1.Controls.Add(LbText3);
            Panel1.Controls.Add(LbText1);
            Panel1.Controls.Add(LbText2);
            Panel1.Controls.Add(TbOrderExcelFault);
            Panel1.Controls.Add(TbOrderExcelSucess);
            Panel1.Controls.Add(BtnGetDataExcel);
            Panel1.Controls.Add(ChosenFile);
            Panel1.Controls.Add(CbbSheetNameFromExcel);
            Panel1.Controls.Add(TbFile);
            Panel1.Location = new Point(-2, 2);
            Panel1.Margin = new Padding(5, 5, 5, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1302, 720);
            Panel1.TabIndex = 1;
            // 
            // LbImportFile
            // 
            LbImportFile.AutoSize = true;
            LbImportFile.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbImportFile.Location = new Point(20, 94);
            LbImportFile.Name = "LbImportFile";
            LbImportFile.Size = new Size(304, 37);
            LbImportFile.TabIndex = 40;
            LbImportFile.Text = "Import file Excel / CSV";
            // 
            // LbSheet
            // 
            LbSheet.AutoSize = true;
            LbSheet.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbSheet.Location = new Point(242, 218);
            LbSheet.Margin = new Padding(8, 0, 8, 0);
            LbSheet.Name = "LbSheet";
            LbSheet.Size = new Size(89, 37);
            LbSheet.TabIndex = 39;
            LbSheet.Text = "Sheet";
            // 
            // LbText3
            // 
            LbText3.AutoSize = true;
            LbText3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText3.ForeColor = Color.Red;
            LbText3.Location = new Point(595, 614);
            LbText3.Margin = new Padding(8, 0, 8, 0);
            LbText3.Name = "LbText3";
            LbText3.Size = new Size(345, 32);
            LbText3.TabIndex = 38;
            LbText3.Text = "đơn hàng bị lỗi do sai cú pháp.";
            LbText3.Visible = false;
            // 
            // LbText1
            // 
            LbText1.AutoSize = true;
            LbText1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText1.ForeColor = Color.FromArgb(86, 142, 89);
            LbText1.Location = new Point(595, 525);
            LbText1.Margin = new Padding(8, 0, 8, 0);
            LbText1.Name = "LbText1";
            LbText1.Size = new Size(325, 32);
            LbText1.TabIndex = 37;
            LbText1.Text = "đơn hàng mới từ Excel / CSV.";
            LbText1.Visible = false;
            // 
            // LbText2
            // 
            LbText2.AutoSize = true;
            LbText2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbText2.ForeColor = Color.FromArgb(86, 142, 89);
            LbText2.Location = new Point(351, 525);
            LbText2.Margin = new Padding(8, 0, 8, 0);
            LbText2.Name = "LbText2";
            LbText2.Size = new Size(104, 32);
            LbText2.TabIndex = 36;
            LbText2.Text = "Đã nhận";
            LbText2.Visible = false;
            // 
            // TbOrderExcelFault
            // 
            TbOrderExcelFault.BackColor = Color.FromArgb(228, 255, 207);
            TbOrderExcelFault.BorderStyle = BorderStyle.FixedSingle;
            TbOrderExcelFault.Enabled = false;
            TbOrderExcelFault.ForeColor = Color.Red;
            TbOrderExcelFault.Location = new Point(486, 600);
            TbOrderExcelFault.Margin = new Padding(8, 8, 8, 8);
            TbOrderExcelFault.Multiline = true;
            TbOrderExcelFault.Name = "TbOrderExcelFault";
            TbOrderExcelFault.Size = new Size(91, 45);
            TbOrderExcelFault.TabIndex = 35;
            TbOrderExcelFault.TextAlign = HorizontalAlignment.Center;
            TbOrderExcelFault.Visible = false;
            // 
            // TbOrderExcelSucess
            // 
            TbOrderExcelSucess.BackColor = Color.FromArgb(228, 255, 207);
            TbOrderExcelSucess.BorderStyle = BorderStyle.FixedSingle;
            TbOrderExcelSucess.Enabled = false;
            TbOrderExcelSucess.ForeColor = Color.FromArgb(86, 142, 89);
            TbOrderExcelSucess.Location = new Point(488, 509);
            TbOrderExcelSucess.Margin = new Padding(8, 8, 8, 8);
            TbOrderExcelSucess.Multiline = true;
            TbOrderExcelSucess.Name = "TbOrderExcelSucess";
            TbOrderExcelSucess.Size = new Size(90, 47);
            TbOrderExcelSucess.TabIndex = 34;
            TbOrderExcelSucess.TextAlign = HorizontalAlignment.Center;
            TbOrderExcelSucess.Visible = false;
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
            BtnGetDataExcel.Location = new Point(367, 349);
            BtnGetDataExcel.Margin = new Padding(8, 8, 8, 8);
            BtnGetDataExcel.Name = "BtnGetDataExcel";
            BtnGetDataExcel.Size = new Size(292, 77);
            BtnGetDataExcel.TabIndex = 33;
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
            ChosenFile.Location = new Point(1037, 66);
            ChosenFile.Name = "ChosenFile";
            ChosenFile.Size = new Size(247, 66);
            ChosenFile.TabIndex = 32;
            ChosenFile.Text = "Chọn file";
            ChosenFile.TextColor = Color.Black;
            ChosenFile.UseVisualStyleBackColor = false;
            ChosenFile.Click += ChosenFileClick;
            // 
            // CbbSheetNameFromExcel
            // 
            CbbSheetNameFromExcel.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbSheetNameFromExcel.FormattingEnabled = true;
            CbbSheetNameFromExcel.Location = new Point(367, 216);
            CbbSheetNameFromExcel.Margin = new Padding(8, 8, 8, 8);
            CbbSheetNameFromExcel.Name = "CbbSheetNameFromExcel";
            CbbSheetNameFromExcel.Size = new Size(342, 40);
            CbbSheetNameFromExcel.TabIndex = 29;
            // 
            // TbFile
            // 
            TbFile.BorderStyle = BorderStyle.FixedSingle;
            TbFile.Location = new Point(367, 64);
            TbFile.Multiline = true;
            TbFile.Name = "TbFile";
            TbFile.Size = new Size(641, 66);
            TbFile.TabIndex = 18;
            // 
            // GetDeliveryRouteByExcel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(Panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "GetDeliveryRouteByExcel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GetDeliveryRouteByExcel";
            Load += GetDeliveryRouteByExcelLoad;
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private TextBox TbFile;
        private ComboBox CbbSheetNameFromExcel;
        private EcosystemApp.GUI.Components.RJButton ChosenFile;
        private EcosystemApp.GUI.Components.RJButton BtnGetDataExcel;
        private TextBox TbOrderExcelSucess;
        private TextBox TbOrderExcelFault;
        private Label LbText2;
        private Label LbText1;
        private Label LbText3;
        private Label LbSheet;
        private Label LbImportFile;
    }
}