using EcosystemApp.BUS;
using EcosystemApp.GUI;
using EcosystemApp.GUI.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EcosystemApp.GUI.ChildForm
{
    public partial class FormLoginAdmin : Form
    {
        private FormLogin ParentForm;

        public FormLoginAdmin(FormLogin parent)
        {
            InitializeComponent();
            ParentForm = parent;
            TxtUsername.Enter += TxtUsernameEnter;
            TxtUsername.Leave += TxtUsernameLeave;
            TxtPassword.Enter += TxtPasswordEnter;
            TxtPassword.Leave += TxtPasswordLeave;

            TxtUsername.Text = "Tên đăng nhập";
            TxtPassword.Text = "Mật khẩu";
            TxtPassword.UseSystemPasswordChar = false;
        }
        private void FormLoginAdminLoad(object sender, EventArgs e)
        {
            TxtUsername.Text = "Tên đăng nhập";
            TxtUsername.ForeColor = Color.Gray;

            TxtPassword.Text = "Mật khẩu";
            TxtPassword.ForeColor = Color.Gray;
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void TxtUsernameEnter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Tên đăng nhập")
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = Color.Black; // màu chữ thật khi gõ
            }
        }

        private void TxtUsernameLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsername.Text))
            {
                TxtUsername.Text = "Tên đăng nhập";
                TxtUsername.ForeColor = Color.Gray; // màu placeholder
            }
        }

        private void TxtPasswordEnter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Mật khẩu")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.UseSystemPasswordChar = true; // ẩn ký tự khi nhập
            }
        }

        private void TxtPasswordLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.Text = "Mật khẩu";
                TxtPassword.ForeColor = Color.Gray;
            }
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string password = TxtPassword.Text.Trim();

            // Hash trực tiếp mật khẩu
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                password = builder.ToString(); // password bây giờ là hash
            }

            var adminBUS = new AdminBUS();
            var admin = adminBUS.Login(username, password);

            if (admin != null)
            {
                RJMessageBox.Show("Đăng nhập thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.CurrentAdmin = admin;
                ParentForm.Hide();
                AccountManagement frm = new AccountManagement(admin);
                frm.ShowDialog();
                ParentForm.Show();
            }
            else
            {
                RJMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelForgotPasswordClick(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog();
        }

    }
}
