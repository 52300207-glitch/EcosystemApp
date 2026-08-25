namespace EcosystemApp.GUI.ChildEmployeeForm
{
    partial class UpdateDeliveryEmpForm
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
            BtnSaveDeliveryEmpInfor = new EcosystemApp.GUI.Components.RJButton();
            BtnCancelDeliveryEmpInfor = new EcosystemApp.GUI.Components.RJButton();
            Panel2 = new Panel();
            ComboOrderID = new ComboBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            TextManageOrderStatus = new TextBox();
            TextDeliveryEmpName = new TextBox();
            Label13 = new Label();
            TextDeliveyEmpId = new TextBox();
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
            Panel1.Size = new Size(1280, 421);
            Panel1.TabIndex = 0;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(228, 255, 207);
            Panel3.Controls.Add(BtnSaveDeliveryEmpInfor);
            Panel3.Controls.Add(BtnCancelDeliveryEmpInfor);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(0, 349);
            Panel3.Margin = new Padding(5, 5, 5, 5);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1280, 86);
            Panel3.TabIndex = 1;
            // 
            // BtnSaveDeliveryEmpInfor
            // 
            BtnSaveDeliveryEmpInfor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSaveDeliveryEmpInfor.BackColor = Color.Aquamarine;
            BtnSaveDeliveryEmpInfor.BackgroundColor = Color.Aquamarine;
            BtnSaveDeliveryEmpInfor.BoderSize = 1;
            BtnSaveDeliveryEmpInfor.BorderColor = Color.Black;
            BtnSaveDeliveryEmpInfor.BorderRadius = 35;
            BtnSaveDeliveryEmpInfor.FlatAppearance.BorderSize = 0;
            BtnSaveDeliveryEmpInfor.FlatStyle = FlatStyle.Flat;
            BtnSaveDeliveryEmpInfor.ForeColor = Color.Black;
            BtnSaveDeliveryEmpInfor.Location = new Point(1020, 2);
            BtnSaveDeliveryEmpInfor.Name = "BtnSaveDeliveryEmpInfor";
            BtnSaveDeliveryEmpInfor.Size = new Size(185, 56);
            BtnSaveDeliveryEmpInfor.TabIndex = 19;
            BtnSaveDeliveryEmpInfor.Text = "Lưu";
            BtnSaveDeliveryEmpInfor.TextColor = Color.Black;
            BtnSaveDeliveryEmpInfor.UseVisualStyleBackColor = false;
            BtnSaveDeliveryEmpInfor.Click += SaveDeliveryEmpInforClick;
            // 
            // BtnCancelDeliveryEmpInfor
            // 
            BtnCancelDeliveryEmpInfor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancelDeliveryEmpInfor.BackColor = Color.LightGray;
            BtnCancelDeliveryEmpInfor.BackgroundColor = Color.LightGray;
            BtnCancelDeliveryEmpInfor.BoderSize = 1;
            BtnCancelDeliveryEmpInfor.BorderColor = Color.Black;
            BtnCancelDeliveryEmpInfor.BorderRadius = 35;
            BtnCancelDeliveryEmpInfor.FlatAppearance.BorderSize = 0;
            BtnCancelDeliveryEmpInfor.FlatStyle = FlatStyle.Flat;
            BtnCancelDeliveryEmpInfor.ForeColor = Color.Black;
            BtnCancelDeliveryEmpInfor.Location = new Point(830, 2);
            BtnCancelDeliveryEmpInfor.Name = "BtnCancelDeliveryEmpInfor";
            BtnCancelDeliveryEmpInfor.Size = new Size(185, 56);
            BtnCancelDeliveryEmpInfor.TabIndex = 18;
            BtnCancelDeliveryEmpInfor.Text = "Hủy";
            BtnCancelDeliveryEmpInfor.TextColor = Color.Black;
            BtnCancelDeliveryEmpInfor.UseVisualStyleBackColor = false;
            BtnCancelDeliveryEmpInfor.Click += CancelDeliveryEmpInforClick;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.FromArgb(228, 255, 207);
            Panel2.Controls.Add(ComboOrderID);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label1);
            Panel2.Controls.Add(TextManageOrderStatus);
            Panel2.Controls.Add(TextDeliveryEmpName);
            Panel2.Controls.Add(Label13);
            Panel2.Controls.Add(TextDeliveyEmpId);
            Panel2.Dock = DockStyle.Top;
            Panel2.Location = new Point(0, 0);
            Panel2.Margin = new Padding(5, 5, 5, 5);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1280, 349);
            Panel2.TabIndex = 0;
            // 
            // ComboOrderID
            // 
            ComboOrderID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboOrderID.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboOrderID.FormattingEnabled = true;
            ComboOrderID.Location = new Point(288, 203);
            ComboOrderID.Margin = new Padding(5, 5, 5, 5);
            ComboOrderID.Name = "ComboOrderID";
            ComboOrderID.Size = new Size(917, 40);
            ComboOrderID.TabIndex = 43;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(70, 128);
            Label3.Name = "Label3";
            Label3.Size = new Size(193, 37);
            Label3.TabIndex = 42;
            Label3.Text = "Tên nhân viên";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(70, 211);
            Label2.Name = "Label2";
            Label2.Size = new Size(186, 37);
            Label2.TabIndex = 41;
            Label2.Text = "Mã đơn hàng";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(70, 291);
            Label1.Name = "Label1";
            Label1.Size = new Size(112, 37);
            Label1.TabIndex = 40;
            Label1.Text = "Ghi chú";
            // 
            // TextManageOrderStatus
            // 
            TextManageOrderStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextManageOrderStatus.BorderStyle = BorderStyle.FixedSingle;
            TextManageOrderStatus.Location = new Point(288, 277);
            TextManageOrderStatus.Multiline = true;
            TextManageOrderStatus.Name = "TextManageOrderStatus";
            TextManageOrderStatus.Size = new Size(918, 50);
            TextManageOrderStatus.TabIndex = 39;
            // 
            // TextDeliveryEmpName
            // 
            TextDeliveryEmpName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextDeliveryEmpName.BorderStyle = BorderStyle.FixedSingle;
            TextDeliveryEmpName.Location = new Point(288, 114);
            TextDeliveryEmpName.Multiline = true;
            TextDeliveryEmpName.Name = "TextDeliveryEmpName";
            TextDeliveryEmpName.Size = new Size(918, 50);
            TextDeliveryEmpName.TabIndex = 37;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label13.Location = new Point(70, 46);
            Label13.Name = "Label13";
            Label13.Size = new Size(189, 37);
            Label13.TabIndex = 36;
            Label13.Text = "Mã nhân viên";
            // 
            // TextDeliveyEmpId
            // 
            TextDeliveyEmpId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextDeliveyEmpId.BorderStyle = BorderStyle.FixedSingle;
            TextDeliveyEmpId.Location = new Point(288, 32);
            TextDeliveyEmpId.Multiline = true;
            TextDeliveyEmpId.Name = "TextDeliveyEmpId";
            TextDeliveyEmpId.Size = new Size(918, 50);
            TextDeliveyEmpId.TabIndex = 30;
            // 
            // UpdateDeliveryEmpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 421);
            Controls.Add(Panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "UpdateDeliveryEmpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập Thông Tin Nhân Viên";
            Panel1.ResumeLayout(false);
            Panel3.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private Panel Panel2;
        private TextBox TextDeliveyEmpId;
        private TextBox TextManageOrderStatus;
        private TextBox TextDeliveryEmpName;
        private Label Label13;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private Panel Panel3;
        private EcosystemApp.GUI.Components.RJButton BtnSaveDeliveryEmpInfor;
        private EcosystemApp.GUI.Components.RJButton BtnCancelDeliveryEmpInfor;
        private ComboBox ComboOrderID;
    }
}