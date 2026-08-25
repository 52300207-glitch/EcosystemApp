namespace EcosystemApp.GUI
{
    partial class OrderForm
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
            PanelMenuOrderForm = new Panel();
            BtnOrderList = new Button();
            BtnCollectData = new Button();
            PanelChildOrderForm = new Panel();
            PanelLeft = new Panel();
            PanelBottom = new Panel();
            PanelRight = new Panel();
            PanelMenuOrderForm.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenuOrderForm
            // 
            PanelMenuOrderForm.Controls.Add(BtnOrderList);
            PanelMenuOrderForm.Controls.Add(BtnCollectData);
            PanelMenuOrderForm.Dock = DockStyle.Top;
            PanelMenuOrderForm.Location = new Point(0, 0);
            PanelMenuOrderForm.Name = "PanelMenuOrderForm";
            PanelMenuOrderForm.Size = new Size(2147, 63);
            PanelMenuOrderForm.TabIndex = 2;
            // 
            // BtnOrderList
            // 
            BtnOrderList.FlatAppearance.BorderSize = 0;
            BtnOrderList.FlatStyle = FlatStyle.Flat;
            BtnOrderList.Location = new Point(230, 11);
            BtnOrderList.Name = "BtnOrderList";
            BtnOrderList.Size = new Size(255, 46);
            BtnOrderList.TabIndex = 3;
            BtnOrderList.Text = "Danh sách đơn hàng";
            BtnOrderList.UseVisualStyleBackColor = true;
            BtnOrderList.Click += BtnDataListClick;
            // 
            // BtnCollectData
            // 
            BtnCollectData.FlatAppearance.BorderSize = 0;
            BtnCollectData.FlatStyle = FlatStyle.Flat;
            BtnCollectData.Location = new Point(12, 11);
            BtnCollectData.Name = "BtnCollectData";
            BtnCollectData.Size = new Size(212, 46);
            BtnCollectData.TabIndex = 2;
            BtnCollectData.Text = "Thu thập dữ liệu";
            BtnCollectData.UseVisualStyleBackColor = true;
            BtnCollectData.Click += BtnCollectDataClick;
            // 
            // PanelChildOrderForm
            // 
            PanelChildOrderForm.Dock = DockStyle.Fill;
            PanelChildOrderForm.Location = new Point(30, 63);
            PanelChildOrderForm.Name = "PanelChildOrderForm";
            PanelChildOrderForm.Size = new Size(2087, 1076);
            PanelChildOrderForm.TabIndex = 3;
            // 
            // PanelLeft
            // 
            PanelLeft.Dock = DockStyle.Left;
            PanelLeft.Location = new Point(0, 63);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(30, 1106);
            PanelLeft.TabIndex = 4;
            // 
            // PanelBottom
            // 
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(30, 1139);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(2117, 30);
            PanelBottom.TabIndex = 5;
            // 
            // PanelRight
            // 
            PanelRight.Dock = DockStyle.Right;
            PanelRight.Location = new Point(2117, 63);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(30, 1076);
            PanelRight.TabIndex = 6;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(2147, 1169);
            Controls.Add(PanelChildOrderForm);
            Controls.Add(PanelRight);
            Controls.Add(PanelBottom);
            Controls.Add(PanelLeft);
            Controls.Add(PanelMenuOrderForm);
            Name = "OrderForm";
            Text = "Quản lý đơn hàng";
            Load += OrderFormLoad;
            PanelMenuOrderForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelMenuOrderForm;
        private Panel PanelChildOrderForm;
        private Button BtnCollectData;
        private Button BtnOrderList;
        private Panel PanelLeft;
        private Panel PanelBottom;
        private Panel PanelRight;
    }
}