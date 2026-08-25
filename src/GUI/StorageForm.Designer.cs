namespace EcosystemApp.GUI
{
    partial class StorageForm
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
            PanelMenuStorageForm = new Panel();
            BtnProductList = new EcosystemApp.GUI.Components.RJButton();
            BtnTankCleaningSchedule = new EcosystemApp.GUI.Components.RJButton();
            BtnImportExportProduct = new EcosystemApp.GUI.Components.RJButton();
            BtnInventoryList = new EcosystemApp.GUI.Components.RJButton();
            PanelChildStorageForm = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            PanelMenuStorageForm.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuStorageForm
            // 
            PanelMenuStorageForm.Controls.Add(BtnProductList);
            PanelMenuStorageForm.Controls.Add(BtnTankCleaningSchedule);
            PanelMenuStorageForm.Controls.Add(BtnImportExportProduct);
            PanelMenuStorageForm.Controls.Add(BtnInventoryList);
            PanelMenuStorageForm.Dock = DockStyle.Top;
            PanelMenuStorageForm.Location = new Point(0, 0);
            PanelMenuStorageForm.Name = "PanelMenuStorageForm";
            PanelMenuStorageForm.Size = new Size(2147, 69);
            PanelMenuStorageForm.TabIndex = 0;
            // 
            // BtnProductList
            // 
            BtnProductList.BackColor = Color.FromArgb(248, 255, 245);
            BtnProductList.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnProductList.BoderSize = 0;
            BtnProductList.BorderColor = Color.FromArgb(248, 255, 245);
            BtnProductList.BorderRadius = 0;
            BtnProductList.FlatAppearance.BorderSize = 0;
            BtnProductList.FlatStyle = FlatStyle.Flat;
            BtnProductList.ForeColor = Color.Black;
            BtnProductList.Location = new Point(849, 0);
            BtnProductList.Name = "BtnProductList";
            BtnProductList.Size = new Size(266, 56);
            BtnProductList.TabIndex = 4;
            BtnProductList.Text = "Danh sách sản phẩm";
            BtnProductList.TextColor = Color.Black;
            BtnProductList.UseVisualStyleBackColor = false;
            BtnProductList.Click += BtnProductListClick;
            // 
            // BtnTankCleaningSchedule
            // 
            BtnTankCleaningSchedule.BackColor = Color.FromArgb(248, 255, 245);
            BtnTankCleaningSchedule.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnTankCleaningSchedule.BoderSize = 0;
            BtnTankCleaningSchedule.BorderColor = Color.FromArgb(248, 255, 245);
            BtnTankCleaningSchedule.BorderRadius = 0;
            BtnTankCleaningSchedule.FlatAppearance.BorderSize = 0;
            BtnTankCleaningSchedule.FlatStyle = FlatStyle.Flat;
            BtnTankCleaningSchedule.ForeColor = Color.Black;
            BtnTankCleaningSchedule.Location = new Point(572, 0);
            BtnTankCleaningSchedule.Name = "BtnTankCleaningSchedule";
            BtnTankCleaningSchedule.Size = new Size(271, 56);
            BtnTankCleaningSchedule.TabIndex = 3;
            BtnTankCleaningSchedule.Text = "Lịch vệ sinh bồn chứa";
            BtnTankCleaningSchedule.TextColor = Color.Black;
            BtnTankCleaningSchedule.UseVisualStyleBackColor = false;
            BtnTankCleaningSchedule.Click += BtnTankCleaningScheduleClick;
            // 
            // BtnImportExportProduct
            // 
            BtnImportExportProduct.BackColor = Color.FromArgb(248, 255, 245);
            BtnImportExportProduct.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnImportExportProduct.BoderSize = 0;
            BtnImportExportProduct.BorderColor = Color.FromArgb(248, 255, 245);
            BtnImportExportProduct.BorderRadius = 0;
            BtnImportExportProduct.FlatAppearance.BorderSize = 0;
            BtnImportExportProduct.FlatStyle = FlatStyle.Flat;
            BtnImportExportProduct.ForeColor = Color.Black;
            BtnImportExportProduct.Location = new Point(272, 0);
            BtnImportExportProduct.Name = "BtnImportExportProduct";
            BtnImportExportProduct.Size = new Size(294, 56);
            BtnImportExportProduct.TabIndex = 2;
            BtnImportExportProduct.Text = "Nhập / xuất sản phẩm";
            BtnImportExportProduct.TextColor = Color.Black;
            BtnImportExportProduct.UseVisualStyleBackColor = false;
            BtnImportExportProduct.Click += BtnImportExportProductClick;
            // 
            // BtnInventoryList
            // 
            BtnInventoryList.BackColor = Color.FromArgb(248, 255, 245);
            BtnInventoryList.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnInventoryList.BoderSize = 0;
            BtnInventoryList.BorderColor = Color.FromArgb(248, 255, 245);
            BtnInventoryList.BorderRadius = 0;
            BtnInventoryList.FlatAppearance.BorderSize = 0;
            BtnInventoryList.FlatStyle = FlatStyle.Flat;
            BtnInventoryList.ForeColor = Color.Black;
            BtnInventoryList.Location = new Point(0, 0);
            BtnInventoryList.Name = "BtnInventoryList";
            BtnInventoryList.Size = new Size(266, 56);
            BtnInventoryList.TabIndex = 1;
            BtnInventoryList.Text = "Danh sách tồn kho";
            BtnInventoryList.TextColor = Color.Black;
            BtnInventoryList.UseVisualStyleBackColor = false;
            BtnInventoryList.Click += BtnInventoryListClick;
            // 
            // PanelChildStorageForm
            // 
            PanelChildStorageForm.Dock = DockStyle.Fill;
            PanelChildStorageForm.Location = new Point(30, 69);
            PanelChildStorageForm.Name = "PanelChildStorageForm";
            PanelChildStorageForm.Size = new Size(2087, 1070);
            PanelChildStorageForm.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 1100);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(30, 1139);
            panel2.Name = "panel2";
            panel2.Size = new Size(2117, 30);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(2117, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 1070);
            panel3.TabIndex = 4;
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(2147, 1169);
            Controls.Add(PanelChildStorageForm);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PanelMenuStorageForm);
            Name = "StorageForm";
            Text = "Quản lý Kho - Trạm";
            Load += StorageFormLoad;
            PanelMenuStorageForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuStorageForm;
        private Components.RJButton BtnTankCleaningSchedule;
        private Components.RJButton BtnImportExportProduct;
        private Components.RJButton BtnInventoryList;
        private Panel PanelChildStorageForm;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Components.RJButton BtnProductList;
    }
}