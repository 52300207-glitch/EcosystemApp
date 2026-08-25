namespace EcosystemApp.GUI.ChildPackageForm
{
    partial class PackageListForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            PanelTop = new Panel();
            CbbFilterPackage = new ComboBox();
            PanelButton = new Panel();
            BtnEdit = new EcosystemApp.GUI.Components.RJButton();
            BtnAdd = new EcosystemApp.GUI.Components.RJButton();
            BtnPrevPage = new EcosystemApp.GUI.Components.RJButton();
            LbPageInfo = new Label();
            BtnNextPage = new EcosystemApp.GUI.Components.RJButton();
            PanelHeaderPackageList = new Panel();
            LbPackageList = new Label();
            PanelPackageList = new Panel();
            DgvPackageList = new DataGridView();
            PanelTop.SuspendLayout();
            PanelButton.SuspendLayout();
            PanelHeaderPackageList.SuspendLayout();
            PanelPackageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPackageList).BeginInit();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.Controls.Add(CbbFilterPackage);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Margin = new Padding(2);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1184, 52);
            PanelTop.TabIndex = 0;
            // 
            // CbbFilterPackage
            // 
            CbbFilterPackage.BackColor = Color.White;
            CbbFilterPackage.FormattingEnabled = true;
            CbbFilterPackage.Location = new Point(0, 14);
            CbbFilterPackage.Margin = new Padding(2);
            CbbFilterPackage.Name = "CbbFilterPackage";
            CbbFilterPackage.Size = new Size(150, 28);
            CbbFilterPackage.TabIndex = 1;
            CbbFilterPackage.Text = "Lọc";
            CbbFilterPackage.SelectedIndexChanged += CbbFilterPackageSelectedIndexChanged;
            // 
            // PanelButton
            // 
            PanelButton.Controls.Add(BtnEdit);
            PanelButton.Controls.Add(BtnAdd);
            PanelButton.Controls.Add(BtnPrevPage);
            PanelButton.Controls.Add(LbPageInfo);
            PanelButton.Controls.Add(BtnNextPage);
            PanelButton.Dock = DockStyle.Bottom;
            PanelButton.Location = new Point(0, 610);
            PanelButton.Margin = new Padding(2);
            PanelButton.Name = "PanelButton";
            PanelButton.Size = new Size(1184, 49);
            PanelButton.TabIndex = 1;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.FromArgb(196, 238, 181);
            BtnEdit.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnEdit.BoderSize = 2;
            BtnEdit.BorderColor = Color.Black;
            BtnEdit.BorderRadius = 38;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.Location = new Point(1071, 6);
            BtnEdit.Margin = new Padding(2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(111, 38);
            BtnEdit.TabIndex = 19;
            BtnEdit.Text = "Sửa";
            BtnEdit.TextColor = Color.Black;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEditClick;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdd.BackColor = Color.FromArgb(196, 238, 181);
            BtnAdd.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnAdd.BoderSize = 2;
            BtnAdd.BorderColor = Color.Black;
            BtnAdd.BorderRadius = 38;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(956, 6);
            BtnAdd.Margin = new Padding(2);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(111, 38);
            BtnAdd.TabIndex = 18;
            BtnAdd.Text = "Thêm";
            BtnAdd.TextColor = Color.Black;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAddClick;
            // 
            // BtnPrevPage
            // 
            BtnPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnPrevPage.BackColor = Color.FromArgb(196, 238, 181);
            BtnPrevPage.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnPrevPage.BoderSize = 1;
            BtnPrevPage.BorderColor = Color.Black;
            BtnPrevPage.BorderRadius = 25;
            BtnPrevPage.FlatAppearance.BorderSize = 0;
            BtnPrevPage.FlatStyle = FlatStyle.Flat;
            BtnPrevPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnPrevPage.ForeColor = Color.Black;
            BtnPrevPage.Location = new Point(2, 11);
            BtnPrevPage.Margin = new Padding(2);
            BtnPrevPage.Name = "BtnPrevPage";
            BtnPrevPage.Size = new Size(68, 25);
            BtnPrevPage.TabIndex = 12;
            BtnPrevPage.Text = "←";
            BtnPrevPage.TextColor = Color.Black;
            BtnPrevPage.UseVisualStyleBackColor = false;
            BtnPrevPage.Click += BtnPrevPageClick;
            // 
            // LbPageInfo
            // 
            LbPageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbPageInfo.AutoSize = true;
            LbPageInfo.Font = new Font("Segoe UI", 11F);
            LbPageInfo.ForeColor = Color.Black;
            LbPageInfo.Location = new Point(73, 10);
            LbPageInfo.Margin = new Padding(2, 0, 2, 0);
            LbPageInfo.Name = "LbPageInfo";
            LbPageInfo.Size = new Size(101, 25);
            LbPageInfo.TabIndex = 13;
            LbPageInfo.Text = "Trang 1 / 1";
            LbPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnNextPage
            // 
            BtnNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnNextPage.BackColor = Color.FromArgb(196, 238, 181);
            BtnNextPage.BackgroundColor = Color.FromArgb(196, 238, 181);
            BtnNextPage.BoderSize = 1;
            BtnNextPage.BorderColor = Color.Black;
            BtnNextPage.BorderRadius = 25;
            BtnNextPage.FlatAppearance.BorderSize = 0;
            BtnNextPage.FlatStyle = FlatStyle.Flat;
            BtnNextPage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnNextPage.ForeColor = Color.Black;
            BtnNextPage.Location = new Point(175, 11);
            BtnNextPage.Margin = new Padding(2);
            BtnNextPage.Name = "BtnNextPage";
            BtnNextPage.Size = new Size(68, 25);
            BtnNextPage.TabIndex = 14;
            BtnNextPage.Text = "→";
            BtnNextPage.TextColor = Color.Black;
            BtnNextPage.UseVisualStyleBackColor = false;
            BtnNextPage.Click += BtnNextPageClick;
            // 
            // PanelHeaderPackageList
            // 
            PanelHeaderPackageList.BackColor = Color.FromArgb(196, 238, 181);
            PanelHeaderPackageList.Controls.Add(LbPackageList);
            PanelHeaderPackageList.Dock = DockStyle.Top;
            PanelHeaderPackageList.Location = new Point(0, 52);
            PanelHeaderPackageList.Margin = new Padding(2);
            PanelHeaderPackageList.Name = "PanelHeaderPackageList";
            PanelHeaderPackageList.Size = new Size(1184, 44);
            PanelHeaderPackageList.TabIndex = 2;
            // 
            // LbPackageList
            // 
            LbPackageList.Anchor = AnchorStyles.Top;
            LbPackageList.AutoSize = true;
            LbPackageList.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPackageList.Location = new Point(507, 8);
            LbPackageList.Margin = new Padding(2, 0, 2, 0);
            LbPackageList.Name = "LbPackageList";
            LbPackageList.Size = new Size(147, 23);
            LbPackageList.TabIndex = 0;
            LbPackageList.Text = "Danh sách bao bì";
            // 
            // PanelPackageList
            // 
            PanelPackageList.Controls.Add(DgvPackageList);
            PanelPackageList.Dock = DockStyle.Fill;
            PanelPackageList.Location = new Point(0, 96);
            PanelPackageList.Margin = new Padding(2);
            PanelPackageList.Name = "PanelPackageList";
            PanelPackageList.Size = new Size(1184, 514);
            PanelPackageList.TabIndex = 3;
            // 
            // DgvPackageList
            // 
            DgvPackageList.AllowUserToResizeRows = false;
            DgvPackageList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPackageList.BackgroundColor = Color.FromArgb(248, 255, 245);
            DgvPackageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPackageList.Dock = DockStyle.Fill;
            DgvPackageList.Location = new Point(0, 0);
            DgvPackageList.Margin = new Padding(2);
            DgvPackageList.Name = "DgvPackageList";
            DgvPackageList.RowHeadersVisible = false;
            DgvPackageList.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 255, 207);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPackageList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvPackageList.RowTemplate.Height = 50;
            DgvPackageList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPackageList.Size = new Size(1184, 514);
            DgvPackageList.TabIndex = 0;
            // 
            // PackageListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 255, 245);
            ClientSize = new Size(1184, 659);
            Controls.Add(PanelPackageList);
            Controls.Add(PanelHeaderPackageList);
            Controls.Add(PanelButton);
            Controls.Add(PanelTop);
            Margin = new Padding(2);
            Name = "PackageListForm";
            Text = "PackageListForm";
            PanelTop.ResumeLayout(false);
            PanelButton.ResumeLayout(false);
            PanelButton.PerformLayout();
            PanelHeaderPackageList.ResumeLayout(false);
            PanelHeaderPackageList.PerformLayout();
            PanelPackageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPackageList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Panel PanelButton;
        private Panel PanelHeaderPackageList;
        private Panel PanelPackageList;
        private Label LbPackageList;
        private DataGridView DgvPackageList;
        private Components.RJButton BtnDelete;
        private Components.RJButton BtnPrevPage;
        private Label LbPageInfo;
        private Components.RJButton BtnNextPage;
        private ComboBox CbbFilterPackage;
        private Components.RJButton BtnAdd;
        private Components.RJButton BtnEdit;
    }
}