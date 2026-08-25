namespace EcosystemApp.GUI.ChildStorageForm
{
    partial class ImportExportProductForm
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
            PanelMenuImportExport = new Panel();
            BtnExportProduct = new EcosystemApp.GUI.Components.RJButton();
            BtnImportProduct = new EcosystemApp.GUI.Components.RJButton();
            PanelImportExport = new Panel();
            PanelMenuImportExport.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuImportExport
            // 
            PanelMenuImportExport.Controls.Add(BtnExportProduct);
            PanelMenuImportExport.Controls.Add(BtnImportProduct);
            PanelMenuImportExport.Dock = DockStyle.Top;
            PanelMenuImportExport.Location = new Point(0, 0);
            PanelMenuImportExport.Name = "PanelMenuImportExport";
            PanelMenuImportExport.Size = new Size(2121, 89);
            PanelMenuImportExport.TabIndex = 0;
            // 
            // BtnExportProduct
            // 
            BtnExportProduct.BackColor = Color.FromArgb(248, 255, 245);
            BtnExportProduct.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnExportProduct.BoderSize = 2;
            BtnExportProduct.BorderColor = Color.Black;
            BtnExportProduct.BorderRadius = 40;
            BtnExportProduct.FlatAppearance.BorderSize = 0;
            BtnExportProduct.FlatStyle = FlatStyle.Flat;
            BtnExportProduct.ForeColor = Color.Black;
            BtnExportProduct.Location = new Point(275, 12);
            BtnExportProduct.Name = "BtnExportProduct";
            BtnExportProduct.Size = new Size(269, 61);
            BtnExportProduct.TabIndex = 1;
            BtnExportProduct.Text = "Phiếu xuất kho";
            BtnExportProduct.TextColor = Color.Black;
            BtnExportProduct.UseVisualStyleBackColor = false;
            BtnExportProduct.Click += BtnExportProductClick;
            // 
            // BtnImportProduct
            // 
            BtnImportProduct.BackColor = Color.FromArgb(248, 255, 245);
            BtnImportProduct.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnImportProduct.BoderSize = 2;
            BtnImportProduct.BorderColor = Color.Black;
            BtnImportProduct.BorderRadius = 40;
            BtnImportProduct.FlatAppearance.BorderSize = 0;
            BtnImportProduct.FlatStyle = FlatStyle.Flat;
            BtnImportProduct.ForeColor = Color.Black;
            BtnImportProduct.Location = new Point(0, 12);
            BtnImportProduct.Name = "BtnImportProduct";
            BtnImportProduct.Size = new Size(269, 61);
            BtnImportProduct.TabIndex = 0;
            BtnImportProduct.Text = "Phiếu nhập kho";
            BtnImportProduct.TextColor = Color.Black;
            BtnImportProduct.UseVisualStyleBackColor = false;
            BtnImportProduct.Click += BtnImportProductClick;
            // 
            // PanelImportExport
            // 
            PanelImportExport.Dock = DockStyle.Fill;
            PanelImportExport.Location = new Point(0, 89);
            PanelImportExport.Name = "PanelImportExport";
            PanelImportExport.Size = new Size(2121, 940);
            PanelImportExport.TabIndex = 1;
            // 
            // ImportExportProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(2121, 1029);
            Controls.Add(PanelImportExport);
            Controls.Add(PanelMenuImportExport);
            Name = "ImportExportProductForm";
            Text = "ImportExportProductForm";
            Load += ImportExportProductFormLoad;
            PanelMenuImportExport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuImportExport;
        private Components.RJButton rjButton2;
        private Components.RJButton BtnImportProduct;
        private Components.RJButton BtnExportProduct;
        private Panel PanelImportExport;
    }
}