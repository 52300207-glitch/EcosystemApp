using EcosystemApp.DAL;
using EcosystemApp.DTO;
using EcosystemApp.Utils;

namespace EcosystemApp.BUS
{
    public class AdminBUS
    {
        private readonly AdminDAL AdminDAL = new AdminDAL();

        public AdminDTO Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            return AdminDAL.CheckLogin(username.Trim(), password.Trim());
        }
        public string GetPassword(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Tên đăng nhập không được để trống.");

            string password = AdminDAL.GetPasswordByUsername(username.Trim());

            if (password == null)
                throw new Exception("Không tìm thấy tên đăng nhập trong hệ thống.");

            return password;
        }
        public bool SendPasswordToFixedEmail(string username)
        {
            string password = GetPassword(username);
            if (string.IsNullOrEmpty(password))
                return false;

            // Gửi mail đến email cố định của admin
            string fixedEmail = "yourcompany.admin@gmail.com";
            string subject = "Khôi phục mật khẩu hệ thống EcosystemApp";
            string body = $"Tài khoản: {username}\nMật khẩu: {password}";

            try
            {
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi email: {ex.Message}");
                return false;
            }
        }
        public bool UpdatePassword(string newPassword)
        {
            try
            {
                AdminDAL.UpdatePassword(newPassword);
                return true;
            }
            catch { return false; }
        }
    }
}
