namespace EcosystemApp.GUI
{
    partial class EmailUpdatingForm
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
            LbEnterRecoveryEmail = new Label();
            TbEnterRecoveryEmail = new TextBox();
            BtnSave = new EcosystemApp.GUI.Components.RJButton();
            SuspendLayout();
            // 
            // LbEnterRecoveryEmail
            // 
            LbEnterRecoveryEmail.AutoSize = true;
            LbEnterRecoveryEmail.Location = new Point(33, 39);
            LbEnterRecoveryEmail.Name = "LbEnterRecoveryEmail";
            LbEnterRecoveryEmail.Size = new Size(230, 20);
            LbEnterRecoveryEmail.TabIndex = 0;
            LbEnterRecoveryEmail.Text = "Nhập email khôi phục để bắt đầu";
            // 
            // TbEnterRecoveryEmail
            // 
            TbEnterRecoveryEmail.Location = new Point(278, 36);
            TbEnterRecoveryEmail.Name = "TbEnterRecoveryEmail";
            TbEnterRecoveryEmail.Size = new Size(279, 27);
            TbEnterRecoveryEmail.TabIndex = 1;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.MediumSlateBlue;
            BtnSave.BackgroundColor = Color.MediumSlateBlue;
            BtnSave.BoderSize = 0;
            BtnSave.BorderColor = Color.PaleVioletRed;
            BtnSave.BorderRadius = 28;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(447, 69);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(123, 46);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Lưu";
            BtnSave.TextColor = Color.White;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // EmailUpdating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 127);
            Controls.Add(BtnSave);
            Controls.Add(TbEnterRecoveryEmail);
            Controls.Add(LbEnterRecoveryEmail);
            Name = "EmailUpdating";
            Text = "EmailUpdating";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbEnterRecoveryEmail;
        private TextBox TbEnterRecoveryEmail;
        private Components.RJButton BtnSave;
    }
}