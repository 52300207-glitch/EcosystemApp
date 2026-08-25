namespace EcosystemApp.GUI
{
    partial class PackageForm
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
            PanelMenuPackageForm = new Panel();
            BtnPackageCleaning = new EcosystemApp.GUI.Components.RJButton();
            BtnStatiscalPackage = new EcosystemApp.GUI.Components.RJButton();
            BtnPackageList = new EcosystemApp.GUI.Components.RJButton();
            panel3 = new Panel();
            panel4 = new Panel();
            PanelChildPackageForm = new Panel();
            panel2 = new Panel();
            PanelMenuPackageForm.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuPackageForm
            // 
            PanelMenuPackageForm.Controls.Add(BtnPackageCleaning);
            PanelMenuPackageForm.Controls.Add(BtnStatiscalPackage);
            PanelMenuPackageForm.Controls.Add(BtnPackageList);
            PanelMenuPackageForm.Dock = DockStyle.Top;
            PanelMenuPackageForm.Location = new Point(0, 0);
            PanelMenuPackageForm.Margin = new Padding(2);
            PanelMenuPackageForm.Name = "PanelMenuPackageForm";
            PanelMenuPackageForm.Size = new Size(1184, 43);
            PanelMenuPackageForm.TabIndex = 0;
            // 
            // BtnPackageCleaning
            // 
            BtnPackageCleaning.BackColor = Color.FromArgb(248, 255, 245);
            BtnPackageCleaning.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnPackageCleaning.BoderSize = 0;
            BtnPackageCleaning.BorderColor = Color.FromArgb(248, 255, 245);
            BtnPackageCleaning.BorderRadius = 0;
            BtnPackageCleaning.FlatAppearance.BorderSize = 0;
            BtnPackageCleaning.FlatStyle = FlatStyle.Flat;
            BtnPackageCleaning.ForeColor = Color.Black;
            BtnPackageCleaning.Location = new Point(337, 2);
            BtnPackageCleaning.Margin = new Padding(2);
            BtnPackageCleaning.Name = "BtnPackageCleaning";
            BtnPackageCleaning.Size = new Size(164, 39);
            BtnPackageCleaning.TabIndex = 4;
            BtnPackageCleaning.Text = "Lịch vệ sinh bao bì";
            BtnPackageCleaning.TextColor = Color.Black;
            BtnPackageCleaning.UseVisualStyleBackColor = false;
            BtnPackageCleaning.Click += BtnPackageCleaningClick;
            // 
            // BtnStatiscalPackage
            // 
            BtnStatiscalPackage.BackColor = Color.FromArgb(248, 255, 245);
            BtnStatiscalPackage.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnStatiscalPackage.BoderSize = 0;
            BtnStatiscalPackage.BorderColor = Color.FromArgb(248, 255, 245);
            BtnStatiscalPackage.BorderRadius = 0;
            BtnStatiscalPackage.FlatAppearance.BorderSize = 0;
            BtnStatiscalPackage.FlatStyle = FlatStyle.Flat;
            BtnStatiscalPackage.ForeColor = Color.Black;
            BtnStatiscalPackage.Location = new Point(169, 2);
            BtnStatiscalPackage.Margin = new Padding(2);
            BtnStatiscalPackage.Name = "BtnStatiscalPackage";
            BtnStatiscalPackage.Size = new Size(164, 35);
            BtnStatiscalPackage.TabIndex = 3;
            BtnStatiscalPackage.Text = "Thống kê bao bì";
            BtnStatiscalPackage.TextColor = Color.Black;
            BtnStatiscalPackage.UseVisualStyleBackColor = false;
            BtnStatiscalPackage.Click += BtnStatiscalPackageClick;
            // 
            // BtnPackageList
            // 
            BtnPackageList.BackColor = Color.FromArgb(248, 255, 245);
            BtnPackageList.BackgroundColor = Color.FromArgb(248, 255, 245);
            BtnPackageList.BoderSize = 0;
            BtnPackageList.BorderColor = Color.FromArgb(248, 255, 245);
            BtnPackageList.BorderRadius = 0;
            BtnPackageList.FlatAppearance.BorderSize = 0;
            BtnPackageList.FlatStyle = FlatStyle.Flat;
            BtnPackageList.ForeColor = Color.Black;
            BtnPackageList.Location = new Point(2, 2);
            BtnPackageList.Margin = new Padding(2);
            BtnPackageList.Name = "BtnPackageList";
            BtnPackageList.Size = new Size(164, 35);
            BtnPackageList.TabIndex = 2;
            BtnPackageList.Text = "Danh sách bao bì";
            BtnPackageList.TextColor = Color.Black;
            BtnPackageList.UseVisualStyleBackColor = false;
            BtnPackageList.Click += BtnPackageListClick;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(18, 640);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1166, 19);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1166, 43);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 597);
            panel4.TabIndex = 5;
            // 
            // PanelChildPackageForm
            // 
            PanelChildPackageForm.Dock = DockStyle.Fill;
            PanelChildPackageForm.Location = new Point(18, 43);
            PanelChildPackageForm.Margin = new Padding(2);
            PanelChildPackageForm.Name = "PanelChildPackageForm";
            PanelChildPackageForm.Size = new Size(1148, 597);
            PanelChildPackageForm.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 616);
            panel2.TabIndex = 3;
            // 
            // PackageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 659);
            Controls.Add(PanelChildPackageForm);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PanelMenuPackageForm);
            Margin = new Padding(2);
            Name = "PackageForm";
            Text = "Quản lý bao bì";
            PanelMenuPackageForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuPackageForm;
        private Components.RJButton BtnPackageList;
        private Components.RJButton BtnPackageCleaning;
        private Components.RJButton BtnStatiscalPackage;
        private Panel panel3;
        private Panel panel4;
        private Panel PanelChildPackageForm;
        private Panel panel2;
    }
}