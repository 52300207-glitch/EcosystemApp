namespace EcosystemApp.GUI.ChildForm
{
    partial class ForgotPasswordForm
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
            PanelOTP = new Panel();
            PanelChangePassword = new Panel();
            TbEnterAgain = new TextBox();
            LbEnterAgain = new Label();
            BtnPasswordConfirmation = new EcosystemApp.GUI.Components.RJButton();
            TbChangePassword = new TextBox();
            LbNewPassword = new Label();
            BtnOTPConfirmation = new EcosystemApp.GUI.Components.RJButton();
            BtnResend = new EcosystemApp.GUI.Components.RJButton();
            TbOTPCode = new TextBox();
            LbOTPCode = new Label();
            Panel1.SuspendLayout();
            PanelOTP.SuspendLayout();
            PanelChangePassword.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.FromArgb(248, 255, 245);
            Panel1.Controls.Add(PanelOTP);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(408, 204);
            Panel1.TabIndex = 5;
            // 
            // PanelOTP
            // 
            PanelOTP.Controls.Add(PanelChangePassword);
            PanelOTP.Controls.Add(BtnOTPConfirmation);
            PanelOTP.Controls.Add(BtnResend);
            PanelOTP.Controls.Add(TbOTPCode);
            PanelOTP.Controls.Add(LbOTPCode);
            PanelOTP.Location = new Point(12, 12);
            PanelOTP.Name = "PanelOTP";
            PanelOTP.Size = new Size(384, 184);
            PanelOTP.TabIndex = 5;
            // 
            // PanelChangePassword
            // 
            PanelChangePassword.Controls.Add(TbEnterAgain);
            PanelChangePassword.Controls.Add(LbEnterAgain);
            PanelChangePassword.Controls.Add(BtnPasswordConfirmation);
            PanelChangePassword.Controls.Add(TbChangePassword);
            PanelChangePassword.Controls.Add(LbNewPassword);
            PanelChangePassword.Location = new Point(0, 0);
            PanelChangePassword.Name = "PanelChangePassword";
            PanelChangePassword.Size = new Size(384, 184);
            PanelChangePassword.TabIndex = 6;
            PanelChangePassword.Visible = false;
            // 
            // TbEnterAgain
            // 
            TbEnterAgain.Location = new Point(155, 77);
            TbEnterAgain.Name = "TbEnterAgain";
            TbEnterAgain.Size = new Size(191, 27);
            TbEnterAgain.TabIndex = 6;
            // 
            // LbEnterAgain
            // 
            LbEnterAgain.AutoSize = true;
            LbEnterAgain.Location = new Point(13, 84);
            LbEnterAgain.Name = "LbEnterAgain";
            LbEnterAgain.Size = new Size(130, 20);
            LbEnterAgain.TabIndex = 5;
            LbEnterAgain.Text = "Nhập lại mật khẩu";
            // 
            // BtnPasswordConfirmation
            // 
            BtnPasswordConfirmation.BackColor = Color.MediumSlateBlue;
            BtnPasswordConfirmation.BackgroundColor = Color.MediumSlateBlue;
            BtnPasswordConfirmation.BoderSize = 0;
            BtnPasswordConfirmation.BorderColor = Color.PaleVioletRed;
            BtnPasswordConfirmation.BorderRadius = 22;
            BtnPasswordConfirmation.FlatAppearance.BorderSize = 0;
            BtnPasswordConfirmation.FlatStyle = FlatStyle.Flat;
            BtnPasswordConfirmation.ForeColor = Color.White;
            BtnPasswordConfirmation.Location = new Point(245, 114);
            BtnPasswordConfirmation.Name = "BtnPasswordConfirmation";
            BtnPasswordConfirmation.Size = new Size(94, 39);
            BtnPasswordConfirmation.TabIndex = 4;
            BtnPasswordConfirmation.Text = "Xác nhận";
            BtnPasswordConfirmation.TextColor = Color.White;
            BtnPasswordConfirmation.UseVisualStyleBackColor = false;
            // 
            // TbChangePassword
            // 
            TbChangePassword.Location = new Point(155, 30);
            TbChangePassword.Name = "TbChangePassword";
            TbChangePassword.Size = new Size(182, 27);
            TbChangePassword.TabIndex = 2;
            // 
            // LbNewPassword
            // 
            LbNewPassword.AutoSize = true;
            LbNewPassword.Location = new Point(13, 33);
            LbNewPassword.Name = "LbNewPassword";
            LbNewPassword.Size = new Size(100, 20);
            LbNewPassword.TabIndex = 1;
            LbNewPassword.Text = "Mật khẩu mới";
            // 
            // BtnOTPConfirmation
            // 
            BtnOTPConfirmation.BackColor = Color.MediumSlateBlue;
            BtnOTPConfirmation.BackgroundColor = Color.MediumSlateBlue;
            BtnOTPConfirmation.BoderSize = 0;
            BtnOTPConfirmation.BorderColor = Color.PaleVioletRed;
            BtnOTPConfirmation.BorderRadius = 22;
            BtnOTPConfirmation.FlatAppearance.BorderSize = 0;
            BtnOTPConfirmation.FlatStyle = FlatStyle.Flat;
            BtnOTPConfirmation.ForeColor = Color.White;
            BtnOTPConfirmation.Location = new Point(282, 91);
            BtnOTPConfirmation.Name = "BtnOTPConfirmation";
            BtnOTPConfirmation.Size = new Size(94, 39);
            BtnOTPConfirmation.TabIndex = 4;
            BtnOTPConfirmation.Text = "Xác nhận";
            BtnOTPConfirmation.TextColor = Color.White;
            BtnOTPConfirmation.UseVisualStyleBackColor = false;
            // 
            // BtnResend
            // 
            BtnResend.BackColor = Color.MediumSlateBlue;
            BtnResend.BackgroundColor = Color.MediumSlateBlue;
            BtnResend.BoderSize = 0;
            BtnResend.BorderColor = Color.PaleVioletRed;
            BtnResend.BorderRadius = 22;
            BtnResend.FlatAppearance.BorderSize = 0;
            BtnResend.FlatStyle = FlatStyle.Flat;
            BtnResend.ForeColor = Color.White;
            BtnResend.Location = new Point(182, 91);
            BtnResend.Name = "BtnResend";
            BtnResend.Size = new Size(94, 39);
            BtnResend.TabIndex = 3;
            BtnResend.Text = "Gửi lại";
            BtnResend.TextColor = Color.White;
            BtnResend.UseVisualStyleBackColor = false;
            // 
            // TbOTPCode
            // 
            TbOTPCode.Location = new Point(131, 21);
            TbOTPCode.Name = "TbOTPCode";
            TbOTPCode.Size = new Size(208, 27);
            TbOTPCode.TabIndex = 1;
            // 
            // LbOTPCode
            // 
            LbOTPCode.AutoSize = true;
            LbOTPCode.Location = new Point(41, 24);
            LbOTPCode.Name = "LbOTPCode";
            LbOTPCode.Size = new Size(75, 20);
            LbOTPCode.TabIndex = 0;
            LbOTPCode.Text = "Nhập OTP";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 204);
            Controls.Add(Panel1);
            Name = "ForgotPasswordForm";
            Text = "Quên mật khẩu";
            Panel1.ResumeLayout(false);
            PanelOTP.ResumeLayout(false);
            PanelOTP.PerformLayout();
            PanelChangePassword.ResumeLayout(false);
            PanelChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Panel1;
        private Panel PanelOTP;
        private TextBox TbOTPCode;
        private Label LbOTPCode;
        private Panel PanelChangePassword;
        private Button btnChangePassword;
        private TextBox TbChangePassword;
        private Label LbNewPassword;
        private EcosystemApp.GUI.Components.RJButton BtnOTPConfirmation;
        private EcosystemApp.GUI.Components.RJButton BtnResend;
        private EcosystemApp.GUI.Components.RJButton BtnPasswordConfirmation;
        private TextBox TbEnterAgain;
        private Label LbEnterAgain;
    }
}