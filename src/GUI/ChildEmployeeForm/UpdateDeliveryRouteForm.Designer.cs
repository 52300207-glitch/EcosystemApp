namespace EcosystemApp.GUI.ChildEmployeeForm
{
    partial class UpdateDeliveryRouteForm
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
            Panel3 = new Panel();
            BtnSaveRouteInfor = new EcosystemApp.GUI.Components.RJButton();
            BtnCancelRouteInfor = new EcosystemApp.GUI.Components.RJButton();
            Panel2 = new Panel();
            Label6 = new Label();
            TextStatus = new TextBox();
            ComboBoxOrderID = new ComboBox();
            Label5 = new Label();
            Label4 = new Label();
            TextRouteTime = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            TextRouteDistance = new TextBox();
            TextDeliveryAddress = new TextBox();
            TextReceivingAddress = new TextBox();
            Label13 = new Label();
            TextRouteEmpId = new TextBox();
            Panel1.SuspendLayout();
            Panel3.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Panel3);
            Panel1.Controls.Add(Panel2);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(5, 5, 5, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1339, 688);
            Panel1.TabIndex = 1;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(228, 255, 207);
            Panel3.Controls.Add(BtnSaveRouteInfor);
            Panel3.Controls.Add(BtnCancelRouteInfor);
            Panel3.Dock = DockStyle.Bottom;
            Panel3.Location = new Point(0, 616);
            Panel3.Margin = new Padding(5, 5, 5, 5);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1339, 72);
            Panel3.TabIndex = 1;
            // 
            // BtnSaveRouteInfor
            // 
            BtnSaveRouteInfor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSaveRouteInfor.BackColor = Color.Aquamarine;
            BtnSaveRouteInfor.BackgroundColor = Color.Aquamarine;
            BtnSaveRouteInfor.BoderSize = 1;
            BtnSaveRouteInfor.BorderColor = Color.Black;
            BtnSaveRouteInfor.BorderRadius = 35;
            BtnSaveRouteInfor.FlatAppearance.BorderSize = 0;
            BtnSaveRouteInfor.FlatStyle = FlatStyle.Flat;
            BtnSaveRouteInfor.ForeColor = Color.Black;
            BtnSaveRouteInfor.Location = new Point(1076, 3);
            BtnSaveRouteInfor.Name = "BtnSaveRouteInfor";
            BtnSaveRouteInfor.Size = new Size(185, 56);
            BtnSaveRouteInfor.TabIndex = 21;
            BtnSaveRouteInfor.Text = "Lưu";
            BtnSaveRouteInfor.TextColor = Color.Black;
            BtnSaveRouteInfor.UseVisualStyleBackColor = false;
            BtnSaveRouteInfor.Click += SaveRouteInforClick;
            // 
            // BtnCancelRouteInfor
            // 
            BtnCancelRouteInfor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancelRouteInfor.BackColor = Color.LightGray;
            BtnCancelRouteInfor.BackgroundColor = Color.LightGray;
            BtnCancelRouteInfor.BoderSize = 1;
            BtnCancelRouteInfor.BorderColor = Color.Black;
            BtnCancelRouteInfor.BorderRadius = 35;
            BtnCancelRouteInfor.FlatAppearance.BorderSize = 0;
            BtnCancelRouteInfor.FlatStyle = FlatStyle.Flat;
            BtnCancelRouteInfor.ForeColor = Color.Black;
            BtnCancelRouteInfor.Location = new Point(884, 3);
            BtnCancelRouteInfor.Name = "BtnCancelRouteInfor";
            BtnCancelRouteInfor.Size = new Size(185, 56);
            BtnCancelRouteInfor.TabIndex = 20;
            BtnCancelRouteInfor.Text = "Hủy";
            BtnCancelRouteInfor.TextColor = Color.Black;
            BtnCancelRouteInfor.UseVisualStyleBackColor = false;
            BtnCancelRouteInfor.Click += CancelRouteInforClick;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(228, 255, 207);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(TextStatus);
            Panel2.Controls.Add(ComboBoxOrderID);
            Panel2.Controls.Add(Label5);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(TextRouteTime);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(TextRouteDistance);
            Panel2.Controls.Add(TextDeliveryAddress);
            Panel2.Controls.Add(TextReceivingAddress);
            Panel2.Controls.Add(Label13);
            Panel2.Controls.Add(TextRouteEmpId);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(0, 0);
            Panel2.Margin = new Padding(5, 5, 5, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1339, 688);
            Panel2.TabIndex = 0;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(70, 571);
            Label6.Name = "Label6";
            Label6.Size = new Size(147, 37);
            Label6.TabIndex = 49;
            Label6.Text = "Trạng thái";
            // 
            // TextStatus
            // 
            TextStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextStatus.BorderStyle = BorderStyle.FixedSingle;
            TextStatus.Location = new Point(288, 557);
            TextStatus.Multiline = true;
            TextStatus.Name = "TextStatus";
            TextStatus.Size = new Size(977, 50);
            TextStatus.TabIndex = 48;
            // 
            // ComboBoxOrderID
            // 
            ComboBoxOrderID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxOrderID.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxOrderID.FormattingEnabled = true;
            ComboBoxOrderID.Location = new Point(288, 19);
            ComboBoxOrderID.Margin = new Padding(5, 5, 5, 5);
            ComboBoxOrderID.Name = "ComboBoxOrderID";
            ComboBoxOrderID.Size = new Size(976, 40);
            ComboBoxOrderID.TabIndex = 47;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(70, 482);
            Label5.Name = "Label5";
            Label5.Size = new Size(137, 37);
            Label5.TabIndex = 46;
            Label5.Text = "Thời gian";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(70, 27);
            Label4.Name = "Label4";
            Label4.Size = new Size(186, 37);
            Label4.TabIndex = 44;
            Label4.Text = "Mã đơn hàng";
            // 
            // TextRouteTime
            // 
            TextRouteTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextRouteTime.BorderStyle = BorderStyle.FixedSingle;
            TextRouteTime.Location = new Point(288, 467);
            TextRouteTime.Multiline = true;
            TextRouteTime.Name = "TextRouteTime";
            TextRouteTime.Size = new Size(977, 50);
            TextRouteTime.TabIndex = 43;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(70, 198);
            Label3.Name = "Label3";
            Label3.Size = new Size(174, 37);
            Label3.TabIndex = 42;
            Label3.Text = "Địa chỉ nhận";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(70, 291);
            Label2.Name = "Label2";
            Label2.Size = new Size(168, 37);
            Label2.TabIndex = 41;
            Label2.Text = "Địa chỉ giao";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(70, 384);
            Label1.Name = "Label1";
            Label1.Size = new Size(193, 37);
            Label1.TabIndex = 40;
            Label1.Text = "Quãng đường";
            // 
            // TextRouteDistance
            // 
            TextRouteDistance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextRouteDistance.BorderStyle = BorderStyle.FixedSingle;
            TextRouteDistance.Location = new Point(288, 370);
            TextRouteDistance.Multiline = true;
            TextRouteDistance.Name = "TextRouteDistance";
            TextRouteDistance.Size = new Size(977, 50);
            TextRouteDistance.TabIndex = 39;
            // 
            // TextDeliveryAddress
            // 
            TextDeliveryAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextDeliveryAddress.BorderStyle = BorderStyle.FixedSingle;
            TextDeliveryAddress.Location = new Point(288, 277);
            TextDeliveryAddress.Multiline = true;
            TextDeliveryAddress.Name = "TextDeliveryAddress";
            TextDeliveryAddress.Size = new Size(977, 50);
            TextDeliveryAddress.TabIndex = 38;
            // 
            // TextReceivingAddress
            // 
            TextReceivingAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextReceivingAddress.BorderStyle = BorderStyle.FixedSingle;
            TextReceivingAddress.Location = new Point(288, 184);
            TextReceivingAddress.Multiline = true;
            TextReceivingAddress.Name = "TextReceivingAddress";
            TextReceivingAddress.Size = new Size(977, 50);
            TextReceivingAddress.TabIndex = 37;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label13.Location = new Point(70, 110);
            Label13.Name = "Label13";
            Label13.Size = new Size(189, 37);
            Label13.TabIndex = 36;
            Label13.Text = "Mã nhân viên";
            // 
            // TextRouteEmpId
            // 
            TextRouteEmpId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextRouteEmpId.BorderStyle = BorderStyle.FixedSingle;
            TextRouteEmpId.Location = new Point(288, 96);
            TextRouteEmpId.Multiline = true;
            TextRouteEmpId.Name = "TextRouteEmpId";
            TextRouteEmpId.Size = new Size(977, 50);
            TextRouteEmpId.TabIndex = 30;
            // 
            // UpdateDeliveryRouteForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 688);
            Controls.Add(Panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "UpdateDeliveryRouteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập Lộ Trình Giao Hàng";
            Panel1.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private Panel Panel3;
        private Panel Panel2;
        private Label Label4;
        private TextBox TextRouteTime;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private TextBox TextRouteDistance;
        private TextBox TextDeliveryAddress;
        private TextBox TextReceivingAddress;
        private Label Label13;
        private TextBox TextRouteEmpId;
        private EcosystemApp.GUI.Components.RJButton BtnSaveRouteInfor;
        private EcosystemApp.GUI.Components.RJButton BtnCancelRouteInfor;
        private ComboBox ComboBoxOrderID;
        private Label Label5;
        private Label Label6;
        private TextBox TextStatus;
    }
}