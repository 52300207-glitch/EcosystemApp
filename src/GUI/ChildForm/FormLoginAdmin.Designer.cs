namespace EcosystemApp.GUI.ChildForm
{
    partial class FormLoginAdmin
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
            ButLogin = new Button();
            LabelForgetPassword = new Label();
            SuspendLayout();
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(117, 32);
            TxtUsername.Margin = new Padding(5, 5, 5, 5);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(308, 39);
            TxtUsername.TabIndex = 0;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(117, 136);
            TxtPassword.Margin = new Padding(5, 5, 5, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(308, 39);
            TxtPassword.TabIndex = 1;
            // 
            // ButLogin
            // 
            ButLogin.Location = new Point(195, 243);
            ButLogin.Margin = new Padding(5, 5, 5, 5);
            ButLogin.Name = "ButLogin";
            ButLogin.Size = new Size(153, 46);
            ButLogin.TabIndex = 2;
            ButLogin.Text = "Đăng nhập";
            ButLogin.UseVisualStyleBackColor = true;
            ButLogin.Click += ButtonLoginClick;
            // 
            // LabelForgetPassword
            // 
            LabelForgetPassword.AutoSize = true;
            LabelForgetPassword.Location = new Point(250, 184);
            LabelForgetPassword.Margin = new Padding(5, 0, 5, 0);
            LabelForgetPassword.Name = "LabelForgetPassword";
            LabelForgetPassword.Size = new Size(180, 32);
            LabelForgetPassword.TabIndex = 3;
            LabelForgetPassword.Text = "Quên mật khẩu";
            LabelForgetPassword.Click += LabelForgotPasswordClick;
            // 
            // FormLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(LabelForgetPassword);
            Controls.Add(ButLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormLoginAdmin";
            Text = "FormLoginAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Button ButLogin;
        private Label LabelForgetPassword;
    }
}