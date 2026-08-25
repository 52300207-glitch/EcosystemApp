namespace EcosystemApp.GUI
{
    partial class FormMessageBox
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
            PanelTitleBar = new Panel();
            LabelCaption = new Label();
            BtnClose = new Button();
            PanelButtons = new Panel();
            BtnThird = new Button();
            BtnSecond = new Button();
            BtnFirst = new Button();
            PanelBody = new Panel();
            LabelMessage = new Label();
            PictureBoxIcon = new PictureBox();
            PanelTitleBar.SuspendLayout();
            PanelButtons.SuspendLayout();
            PanelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // PanelTitleBar
            // 
            PanelTitleBar.BackColor = Color.CornflowerBlue;
            PanelTitleBar.Controls.Add(LabelCaption);
            PanelTitleBar.Controls.Add(BtnClose);
            PanelTitleBar.Dock = DockStyle.Top;
            PanelTitleBar.Location = new Point(3, 3);
            PanelTitleBar.Margin = new Padding(4, 5, 4, 5);
            PanelTitleBar.Name = "PanelTitleBar";
            PanelTitleBar.Size = new Size(461, 54);
            PanelTitleBar.TabIndex = 0;
            PanelTitleBar.MouseDown += PanelTitleBar_MouseDown;
            // 
            // LabelCaption
            // 
            LabelCaption.AutoSize = true;
            LabelCaption.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelCaption.ForeColor = Color.White;
            LabelCaption.Location = new Point(12, 12);
            LabelCaption.Margin = new Padding(4, 0, 4, 0);
            LabelCaption.Name = "LabelCaption";
            LabelCaption.Size = new Size(107, 20);
            LabelCaption.TabIndex = 4;
            LabelCaption.Text = "LabelCaption";
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 79, 95);
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClose.ForeColor = Color.White;
            BtnClose.Location = new Point(408, 0);
            BtnClose.Margin = new Padding(4, 5, 4, 5);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(53, 54);
            BtnClose.TabIndex = 3;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // PanelButtons
            // 
            PanelButtons.BackColor = Color.FromArgb(235, 235, 235);
            PanelButtons.Controls.Add(BtnThird);
            PanelButtons.Controls.Add(BtnSecond);
            PanelButtons.Controls.Add(BtnFirst);
            PanelButtons.Dock = DockStyle.Bottom;
            PanelButtons.Location = new Point(3, 136);
            PanelButtons.Margin = new Padding(4, 5, 4, 5);
            PanelButtons.Name = "PanelButtons";
            PanelButtons.Size = new Size(461, 92);
            PanelButtons.TabIndex = 1;
            // 
            // BtnThird
            // 
            BtnThird.BackColor = Color.SeaGreen;
            BtnThird.FlatAppearance.BorderSize = 0;
            BtnThird.FlatStyle = FlatStyle.Flat;
            BtnThird.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnThird.ForeColor = Color.WhiteSmoke;
            BtnThird.Location = new Point(308, 18);
            BtnThird.Margin = new Padding(4, 5, 4, 5);
            BtnThird.Name = "BtnThird";
            BtnThird.Size = new Size(133, 54);
            BtnThird.TabIndex = 2;
            BtnThird.Text = "BtnThird";
            BtnThird.UseVisualStyleBackColor = false;
            // 
            // BtnSecond
            // 
            BtnSecond.BackColor = Color.SeaGreen;
            BtnSecond.FlatAppearance.BorderSize = 0;
            BtnSecond.FlatStyle = FlatStyle.Flat;
            BtnSecond.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSecond.ForeColor = Color.WhiteSmoke;
            BtnSecond.Location = new Point(167, 18);
            BtnSecond.Margin = new Padding(4, 5, 4, 5);
            BtnSecond.Name = "BtnSecond";
            BtnSecond.Size = new Size(133, 54);
            BtnSecond.TabIndex = 1;
            BtnSecond.Text = "BtnSecond";
            BtnSecond.UseVisualStyleBackColor = false;
            // 
            // BtnFirst
            // 
            BtnFirst.BackColor = Color.SeaGreen;
            BtnFirst.FlatAppearance.BorderSize = 0;
            BtnFirst.FlatStyle = FlatStyle.Flat;
            BtnFirst.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFirst.ForeColor = Color.WhiteSmoke;
            BtnFirst.Location = new Point(25, 18);
            BtnFirst.Margin = new Padding(4, 5, 4, 5);
            BtnFirst.Name = "BtnFirst";
            BtnFirst.Size = new Size(133, 54);
            BtnFirst.TabIndex = 0;
            BtnFirst.Text = "BtnFirst";
            BtnFirst.UseVisualStyleBackColor = false;
            // 
            // PanelBody
            // 
            PanelBody.BackColor = Color.WhiteSmoke;
            PanelBody.Controls.Add(LabelMessage);
            PanelBody.Controls.Add(PictureBoxIcon);
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(3, 57);
            PanelBody.Margin = new Padding(4, 5, 4, 5);
            PanelBody.Name = "PanelBody";
            PanelBody.Padding = new Padding(13, 15, 0, 0);
            PanelBody.Size = new Size(461, 79);
            PanelBody.TabIndex = 2;
            // 
            // LabelMessage
            // 
            LabelMessage.AutoSize = true;
            LabelMessage.Dock = DockStyle.Fill;
            LabelMessage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            LabelMessage.Location = new Point(66, 15);
            LabelMessage.Margin = new Padding(4, 0, 4, 0);
            LabelMessage.MaximumSize = new Size(800, 0);
            LabelMessage.Name = "LabelMessage";
            LabelMessage.Padding = new Padding(7, 8, 13, 23);
            LabelMessage.Size = new Size(138, 51);
            LabelMessage.TabIndex = 1;
            LabelMessage.Text = "LabelMessage";
            LabelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBoxIcon
            // 
            PictureBoxIcon.Dock = DockStyle.Left;
            PictureBoxIcon.Image = src.assets.Image.Resource.success;
            PictureBoxIcon.Location = new Point(13, 15);
            PictureBoxIcon.Margin = new Padding(4, 5, 4, 5);
            PictureBoxIcon.Name = "PictureBoxIcon";
            PictureBoxIcon.Size = new Size(53, 64);
            PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxIcon.TabIndex = 0;
            PictureBoxIcon.TabStop = false;
            // 
            // FormMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(467, 231);
            Controls.Add(PanelBody);
            Controls.Add(PanelButtons);
            Controls.Add(PanelTitleBar);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(461, 205);
            Name = "FormMessageBox";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            PanelTitleBar.ResumeLayout(false);
            PanelTitleBar.PerformLayout();
            PanelButtons.ResumeLayout(false);
            PanelBody.ResumeLayout(false);
            PanelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxIcon).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Button BtnThird;
        private System.Windows.Forms.Button BtnSecond;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelCaption;
    }
}

