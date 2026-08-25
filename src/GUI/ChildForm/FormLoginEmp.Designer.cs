namespace EcosystemApp.GUI.ChildForm
{
    partial class FormLoginEmp
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
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(104, 51);
            TxtUsername.Margin = new Padding(5, 5, 5, 5);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(316, 39);
            TxtUsername.TabIndex = 0;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(104, 131);
            TxtPassword.Margin = new Padding(5, 5, 5, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(316, 39);
            TxtPassword.TabIndex = 1;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(195, 216);
            ButtonLogin.Margin = new Padding(5, 5, 5, 5);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(153, 46);
            ButtonLogin.TabIndex = 2;
            ButtonLogin.Text = "Đăng nhập";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLoginClick;
            // 
            // FormLoginEmp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 438);
            Controls.Add(ButtonLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormLoginEmp";
            Text = "FormLoginEmp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Button ButtonLogin;
    }
}