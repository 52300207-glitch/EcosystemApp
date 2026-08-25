namespace EcosystemApp.GUI
{
    partial class EmployeeForm
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
            Panel01 = new Panel();
            PanelMenuEmployeeForm = new Panel();
            BtnManageLogistic = new Button();
            BtnEmployeeList = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            PanelChildEmployeeForm = new Panel();
            Panel01.SuspendLayout();
            PanelMenuEmployeeForm.SuspendLayout();
            SuspendLayout();
            // 
            // Panel01
            // 
            Panel01.BackColor = Color.FromArgb(248, 255, 245);
            Panel01.Controls.Add(PanelChildEmployeeForm);
            Panel01.Controls.Add(panel4);
            Panel01.Controls.Add(panel3);
            Panel01.Controls.Add(panel2);
            Panel01.Dock = DockStyle.Fill;
            Panel01.Location = new Point(0, 39);
            Panel01.Margin = new Padding(2);
            Panel01.Name = "Panel01";
            Panel01.Size = new Size(1184, 620);
            Panel01.TabIndex = 5;
            // 
            // PanelMenuEmployeeForm
            // 
            PanelMenuEmployeeForm.BackColor = Color.FromArgb(248, 255, 245);
            PanelMenuEmployeeForm.Controls.Add(BtnManageLogistic);
            PanelMenuEmployeeForm.Controls.Add(BtnEmployeeList);
            PanelMenuEmployeeForm.Dock = DockStyle.Top;
            PanelMenuEmployeeForm.Location = new Point(0, 0);
            PanelMenuEmployeeForm.Margin = new Padding(2);
            PanelMenuEmployeeForm.Name = "PanelMenuEmployeeForm";
            PanelMenuEmployeeForm.Size = new Size(1184, 39);
            PanelMenuEmployeeForm.TabIndex = 4;
            // 
            // BtnManageLogistic
            // 
            BtnManageLogistic.FlatAppearance.BorderSize = 0;
            BtnManageLogistic.FlatStyle = FlatStyle.Flat;
            BtnManageLogistic.Location = new Point(168, 7);
            BtnManageLogistic.Margin = new Padding(2);
            BtnManageLogistic.Name = "BtnManageLogistic";
            BtnManageLogistic.Size = new Size(157, 29);
            BtnManageLogistic.TabIndex = 3;
            BtnManageLogistic.Text = "Quản lí giao vận";
            BtnManageLogistic.UseVisualStyleBackColor = true;
            BtnManageLogistic.Click += BtnManageLogisticClick;
            // 
            // BtnEmployeeList
            // 
            BtnEmployeeList.FlatAppearance.BorderSize = 0;
            BtnEmployeeList.FlatStyle = FlatStyle.Flat;
            BtnEmployeeList.Location = new Point(7, 7);
            BtnEmployeeList.Margin = new Padding(2);
            BtnEmployeeList.Name = "BtnEmployeeList";
            BtnEmployeeList.Size = new Size(157, 29);
            BtnEmployeeList.TabIndex = 2;
            BtnEmployeeList.Text = "Danh sách nhân sự ";
            BtnEmployeeList.UseVisualStyleBackColor = true;
            BtnEmployeeList.Click += BtnEmployeeListClick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 620);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(18, 601);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1166, 19);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1166, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 601);
            panel4.TabIndex = 7;
            // 
            // PanelChildEmployeeForm
            // 
            PanelChildEmployeeForm.Dock = DockStyle.Fill;
            PanelChildEmployeeForm.Location = new Point(18, 0);
            PanelChildEmployeeForm.Margin = new Padding(2);
            PanelChildEmployeeForm.Name = "PanelChildEmployeeForm";
            PanelChildEmployeeForm.Size = new Size(1148, 601);
            PanelChildEmployeeForm.TabIndex = 8;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(Panel01);
            Controls.Add(PanelMenuEmployeeForm);
            Margin = new Padding(2);
            Name = "EmployeeForm";
            Text = "Quản lý nhân sự";
            Panel01.ResumeLayout(false);
            PanelMenuEmployeeForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel01;
        private Panel PanelMenuEmployeeForm;
        private Button BtnManageLogistic;
        private Button BtnEmployeeList;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel PanelChildEmployeeForm;
    }
}