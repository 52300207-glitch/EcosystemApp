namespace EcosystemApp.GUI
{
    partial class FormLogin
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
            panelBackground = new Panel();
            panelMain = new Panel();
            panelChildForm = new Panel();
            panel1 = new Panel();
            ButAdmin = new Button();
            panelButEmp = new Panel();
            ButEmployee = new Button();
            panelButAd = new Panel();
            panelBackground.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panelButEmp.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.BackgroundImage = src.assets.Image.Resource.background;
            panelBackground.Controls.Add(panelMain);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Margin = new Padding(5);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1300, 720);
            panelBackground.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.AutoSize = true;
            panelMain.BackColor = Color.Transparent;
            panelMain.BackgroundImage = src.assets.Image.Resource.home;
            panelMain.BackgroundImageLayout = ImageLayout.Zoom;
            panelMain.Controls.Add(panelChildForm);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panelButEmp);
            panelMain.Location = new Point(166, 0);
            panelMain.Margin = new Padding(5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(930, 722);
            panelMain.TabIndex = 0;
            // 
            // panelChildForm
            // 
            panelChildForm.Anchor = AnchorStyles.None;
            panelChildForm.Location = new Point(216, 301);
            panelChildForm.Margin = new Padding(5);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(520, 304);
            panelChildForm.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(ButAdmin);
            panel1.Location = new Point(473, 232);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 77);
            panel1.TabIndex = 2;
            // 
            // ButAdmin
            // 
            ButAdmin.Dock = DockStyle.Fill;
            ButAdmin.Location = new Point(0, 0);
            ButAdmin.Margin = new Padding(5);
            ButAdmin.Name = "ButAdmin";
            ButAdmin.Size = new Size(268, 77);
            ButAdmin.TabIndex = 1;
            ButAdmin.Text = "Quản trị";
            ButAdmin.UseVisualStyleBackColor = true;
            ButAdmin.Click += ButAdminClick;
            // 
            // panelButEmp
            // 
            panelButEmp.Controls.Add(ButEmployee);
            panelButEmp.Controls.Add(panelButAd);
            panelButEmp.Location = new Point(216, 232);
            panelButEmp.Margin = new Padding(5);
            panelButEmp.Name = "panelButEmp";
            panelButEmp.Size = new Size(265, 77);
            panelButEmp.TabIndex = 0;
            // 
            // ButEmployee
            // 
            ButEmployee.Dock = DockStyle.Fill;
            ButEmployee.Location = new Point(0, 0);
            ButEmployee.Margin = new Padding(5);
            ButEmployee.Name = "ButEmployee";
            ButEmployee.Size = new Size(265, 77);
            ButEmployee.TabIndex = 2;
            ButEmployee.Text = "Nhân viên";
            ButEmployee.UseVisualStyleBackColor = true;
            ButEmployee.Click += ButEmployeeClick;
            // 
            // panelButAd
            // 
            panelButAd.Location = new Point(252, 0);
            panelButAd.Margin = new Padding(5);
            panelButAd.Name = "panelButAd";
            panelButAd.Size = new Size(273, 77);
            panelButAd.TabIndex = 1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            FormClosed += FormLoginFormClosed;
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelButEmp.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBackground;
        private Panel panelMain;
        private Panel panelChildForm;
        private Panel panel1;
        private Button ButAdmin;
        private Panel panelButEmp;
        private Button ButEmployee;
        private Panel panelButAd;
    }
}