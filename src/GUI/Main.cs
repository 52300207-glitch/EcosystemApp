using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.GUI;
using EcosystemApp.Helpers;
using EcosystemApp.Utils;

namespace EcosystemApp.GUI
{
    public partial class Main : Form
    {
        private Components.RJButton? BtnCurrent;
        private new Form? ActiveForm;
        private EmployeeDTO? CurrentEmployee;
        private HomePageForm? HomeForm;
        private OrderForm OrderFormInstance = new OrderForm();
        private bool IsLogout = true;
        private BackUpBUS BackUp = new BackUpBUS();

        public Main()
        {
            InitializeComponent();
        }

        public Main(EmployeeDTO emp)
        {
            InitializeComponent();
            CurrentEmployee = emp;
            OrderFormInstance.Close();
            OrderFormInstance = new OrderForm(emp);
        }

        public void SetHomePageInstance(HomePageForm home)
        {
            HomeForm = home;
        }

        public void OpenModule(string moduleName)
        {
            switch (moduleName)
            {
                case "ORDER":
                    BtnOrderClick(BtnOrder, EventArgs.Empty);
                    break;

                case "STORAGE":
                    BtnStorageClick(BtnStorage, EventArgs.Empty);
                    break;

                case "PACKAGE":
                    BtnPackageClick(BtnPackage, EventArgs.Empty);
                    break;

                case "EMPLOYEE":
                    BtnEmployeeClick(BtnEmployee, EventArgs.Empty);
                    break;

                case "REPORT":
                    BtnReportClick(BtnReport, EventArgs.Empty);
                    break;

                default:
                    break;
            }
        }

        private void MainLoad(object sender, EventArgs e)
        {
            HoverEvents();
            AutoSizeScreen();
        }

        private void AutoSizeScreen()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Width = (int)(screenWidth * 0.9);
            this.Height = (int)(screenHeight * 0.9);
        }

        private static (Image? normal, Image? active) GetImages(GUI.Components.RJButton btn)
        {
            // Ánh xạ các nút với tên tài nguyên. Điều chỉnh tên tại đây nếu tên tài nguyên khác nhau.
            return btn.Name switch
            {
                "BtnOrder" => (EcosystemApp.src.assets.Image.Resource.order1, EcosystemApp.src.assets.Image.Resource.order2),
                "BtnStorage" => (EcosystemApp.src.assets.Image.Resource.storage1, EcosystemApp.src.assets.Image.Resource.storage2),
                "BtnPackage" => (EcosystemApp.src.assets.Image.Resource.packaging1, EcosystemApp.src.assets.Image.Resource.packaging2),
                "BtnEmployee" => (EcosystemApp.src.assets.Image.Resource.employee1, EcosystemApp.src.assets.Image.Resource.employee2),
                "BtnTransport" => (EcosystemApp.src.assets.Image.Resource.transport1, EcosystemApp.src.assets.Image.Resource.transport2),
                "BtnReport" => (EcosystemApp.src.assets.Image.Resource.report1, EcosystemApp.src.assets.Image.Resource.report2),
                "BtnSetting" => (EcosystemApp.src.assets.Image.Resource.setting1, EcosystemApp.src.assets.Image.Resource.setting2),
                _ => (btn.Image, btn.Image)
            };
        }

        private void HoverEvents()
        {
            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is GUI.Components.RJButton btn)
                {
                    btn.MouseEnter -= ButtonMouseEnter;
                    btn.MouseLeave -= ButtonMouseLeave;
                    btn.MouseEnter += ButtonMouseEnter;
                    btn.MouseLeave += ButtonMouseLeave;
                }
            }
        }

        private void ButtonMouseEnter(object? sender, EventArgs e)
        {
            if (sender is not GUI.Components.RJButton btn) return;
            if (btn != BtnCurrent)
            {
                var imgs = GetImages(btn);
                if (imgs.active != null) btn.Image = imgs.active;
                btn.BackColor = Color.FromArgb(248, 255, 245);
                btn.ForeColor = Color.Black;
            }
        }

        private void ButtonMouseLeave(object? sender, EventArgs e)
        {
            if (sender is not GUI.Components.RJButton btn) return;
            if (btn != BtnCurrent)
            {
                var imgs = GetImages(btn);
                if (imgs.normal != null) btn.Image = imgs.normal;
                btn.BackColor = Color.FromArgb(86, 142, 89);
                btn.ForeColor = Color.White;
            }
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                BtnCurrent = (GUI.Components.RJButton)btnSender;
                BtnCurrent.ForeColor = Color.Black;
                BtnCurrent.BackColor = Color.FromArgb(248, 255, 245);
                var imgs = GetImages(BtnCurrent);
                if (imgs.active != null) BtnCurrent.Image = imgs.active;
                BtnCurrent.Font = new Font(BtnCurrent.Font.FontFamily, BtnCurrent.Font.Size, FontStyle.Bold);
            }
        }

        private void DisableButton()
        {
            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is GUI.Components.RJButton btn)
                {
                    btn.BackColor = Color.FromArgb(86, 142, 89);
                    btn.BackColor = Color.FromArgb(86, 142, 89);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
                    var imgs = GetImages(btn);
                    if (imgs.normal != null) btn.Image = imgs.normal;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (ActiveForm != null)
            {
                ActiveForm.Hide();
            }

            ActiveButton(btnSender);
            ActiveForm = childForm;

            // Nếu form chưa được add vào panel, add vào
            if (!this.PanelChildForm.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.PanelChildForm.Controls.Add(childForm);
                this.PanelChildForm.Tag = childForm;
            }

            // Hiện form mới hoặc đã tồn tại
            childForm.BringToFront();
            childForm.Show();
            SetHeaderTitle(childForm.Text);
        }

        private void SetHeaderTitle(string text)
        {
            string header = (text ?? string.Empty).ToUpperInvariant();

            lbHeaderFrom.AutoSize = false;
            lbHeaderFrom.Dock = DockStyle.Fill;
            lbHeaderFrom.TextAlign = ContentAlignment.MiddleCenter;

            lbHeaderFrom.Font = new Font(lbHeaderFrom.Font.FontFamily, lbHeaderFrom.Font.Size, FontStyle.Bold);

            lbHeaderFrom.Text = header;
        }

        public void BtnOrderClick(object sender, EventArgs e)
        {
            HideAllSettingPanels();
            OpenChildForm(OrderFormInstance, sender);
            OrderFormInstance.ShowDefaultCollectData();
        }

        public void BtnStorageClick(object sender, EventArgs e)
        {
            HideAllSettingPanels();
            StorageForm storage = new StorageForm(CurrentEmployee);
            OpenChildForm(storage, sender);
            storage.ShowDefaultInventoryList();
        }

        public void BtnPackageClick(object sender, EventArgs e)
        {
            HideAllSettingPanels();
            PackageForm package = new PackageForm(CurrentEmployee);
            OpenChildForm(package, sender);
            package.ShowDefaultPackageList();
        }

        public void BtnEmployeeClick(object sender, EventArgs e)
        {
            HideAllSettingPanels();
            EmployeeForm employee = new EmployeeForm(CurrentEmployee);
            OpenChildForm(employee, sender);
            employee.ShowDefaultEmployeeList();
        }

        public void BtnReportClick(object sender, EventArgs e)
        {
            HideAllSettingPanels();
            OpenChildForm(new ReportForm(CurrentEmployee), sender);
            ReportForm report = new ReportForm(CurrentEmployee);
            OpenChildForm(report, sender);
            report.ShowDefaultRevenueReport();
        }

        private void BtnHomePageClick(object sender, EventArgs e)
        {
            if (HomeForm == null) return;
            this.Hide();
            HomeForm.Show();
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {

            if (IsLogout)
                Application.Exit();
        }

        private void BtnLogoutClick(object sender, EventArgs e)
        {
            var confirmResult = RJMessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhật đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                IsLogout = false;
                this.Hide();
                var formLogin = new FormLogin();
                var loginResult = formLogin.ShowDialog();
            }
        }

        private void HideAllSettingPanels()
        {
            PanelSetting.Visible = false;
            PanelBackup.Visible = false;
        }

        private void BtnSettingClick(object sender, EventArgs e)
        {
            PanelSetting.Visible = !PanelSetting.Visible;
            PanelBackup.Visible = false;

            if (PanelSetting.Visible)
                PanelSetting.BringToFront();

            ActiveButton(BtnSetting);
        }

        private void BtnBackupClick(object sender, EventArgs e)
        {
            PanelBackup.Visible = !PanelBackup.Visible;

            if (PanelBackup.Visible)
                PanelBackup.BringToFront();
        }


        private void BtnPDFClick(object sender, EventArgs e)
        {
            try
            {
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                var tables = BackUp.GetTablesForBackUp(); // always > 2

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Zip Files (*.zip)|*.zip";
                    sfd.FileName = "EcoStation_Backup_PDF.zip"; // default name
                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    string selectedPath = sfd.FileName;

                    // Export all tables to PDF ZIP
                    string tempFile = BackupPDF.ExportTablesToPdf(tables, "EcoStation_Backup");

                    // Copy ZIP to chosen location
                    File.Copy(tempFile, selectedPath, true);
                    File.Delete(tempFile);

                    MessageBox.Show($"Export PDF thành công:\n{selectedPath}", "Backup PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Backup PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcelClick(object sender, EventArgs e)
        {
            try
            {
                var tables = BackUp.GetTablesForBackUp();

                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Zip Files (*.zip)|*.zip";
                    sfd.FileName = "EcoStation_Backup.zip"; // default name
                    if (sfd.ShowDialog() != DialogResult.OK)
                        return;

                    string selectedPath = sfd.FileName;

                    // Export all tables to Excel ZIP
                    string tempFile = BackupHelper.ExportTablesToExcel(tables, "EcoStation_Backup");

                    // Copy ZIP to chosen location
                    File.Copy(tempFile, selectedPath, true);
                    File.Delete(tempFile);

                    MessageBox.Show($"Export Excel thành công:\n{selectedPath}", "Backup Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Backup Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
