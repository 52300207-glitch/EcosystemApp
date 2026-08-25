using EcosystemApp.BUS;
using EcosystemApp.DAL;
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



namespace EcosystemApp.GUI.ChildForm
{
    public partial class FormLoginEmp : Form
    {
        private FormLogin ParentForm;
        public FormLoginEmp(FormLogin parent)
        {
            InitializeComponent();
            this.ParentForm = parent;
            TxtUsername.Enter += TxtUsernameEnter;
            TxtUsername.Leave += TxtUsernameLeave;
            TxtPassword.Enter += TxtPasswordEnter;
            TxtPassword.Leave += TxtPasswordLeave;

            TxtUsername.Text = "Tên đăng nhập";
            TxtPassword.Text = "Mật khẩu";
            TxtPassword.UseSystemPasswordChar = false;
        }
        private void FormLoginEmpLoad(object sender, EventArgs e)
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

            UserBUS userBUS = new UserBUS();
            UserDTO user = userBUS.Login(username, password);

            if (user != null)
            {
                RJMessageBox.Show($"Đăng nhập thành công! Xin chào {user.GetEmployee().GetFullName()}");
                Program.CurrentUser = user;
                var form = new HomePageForm(user.GetEmployee(), new Main(user.GetEmployee()));
                form.Show();
                this.Hide();
                this.DialogResult = DialogResult.OK;
                ParentForm.Hide();
            }
            else
            {
                RJMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
