using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosystemApp.GUI
{
    public partial class HomePageForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private Main? MainForm;
        private bool IsLogout = true;

        public HomePageForm()
        {
            InitializeComponent();
        }

        public HomePageForm(EmployeeDTO employee, Main mainForm) : this()
        {
            CurrentEmployee = employee;
            MainForm = mainForm;
            LabelEmployee.Text = $"Nhân viên: {CurrentEmployee.GetFullName()}";
            LabelEmployeeID.Text = $"Mã nhân viên: {CurrentEmployee.GetID()}";
            mainForm.SetHomePageInstance(this);
        }

        private void HomePageFormLoad(object sender, EventArgs e)
        {
            AutoSizeScreen();
            
        }

        private void AutoSizeScreen()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Width = (int)(screenWidth * 0.9);
            this.Height = (int)(screenHeight * 0.9);
        }

        private void DisableButton(object sender)
        {
            GUI.Components.RJButton? btn = sender as GUI.Components.RJButton;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(228, 255, 207);
                btn.BackgroundColor = Color.FromArgb(228, 255, 207);
                btn.BoderSize = 2;
                btn.BorderColor = Color.FromArgb(86, 142, 89);
                btn.BorderRadius = 40;
                BtnOrder.Image = EcosystemApp.src.assets.Image.Resource.order3;
            }
        }

        private void BtnOrderClick(object sender, EventArgs e)
        {
            DisableButton(sender);
            this.Hide();              // Ẩn HomePage
            MainForm.Show();          // Hiện Main
            MainForm.OpenModule("ORDER");
        }

        private void BtnStorageClick(object sender, EventArgs e)
        {
            DisableButton(sender);
            this.Hide();
            MainForm.Show();
            MainForm.OpenModule("STORAGE");
        }

        private void BtnPackageClick(object sender, EventArgs e)
        {
            DisableButton(sender);
            this.Hide();
            MainForm.Show();
            MainForm.OpenModule("PACKAGE");
        }

        private void BtnEmployeeClick(object sender, EventArgs e)
        {
            DisableButton(sender);
            this.Hide();
            MainForm.Show();
            MainForm.OpenModule("EMPLOYEE");
        }

        private void BtnReportClick(object sender, EventArgs e)
        {
            DisableButton(sender);
            this.Hide();
            MainForm.Show();
            MainForm.OpenModule("REPORT");
        }

        private void HomePageFormFormClosed(object sender, FormClosedEventArgs e)
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

        private void BtnSettingClick(object sender, EventArgs e)
        {
            BtnLogout.Visible = !BtnLogout.Visible;
        }
    }
}
