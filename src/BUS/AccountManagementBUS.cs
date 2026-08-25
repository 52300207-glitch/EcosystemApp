using DocumentFormat.OpenXml.Spreadsheet;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using EcosystemApp.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EcosystemApp.BUS
{
    public class AccountManagementBUS
    {
        private readonly AccountManagementDAL AccDAL = new AccountManagementDAL();
        
        public bool CreateAccount(AccountManagementDTO acc)
        {
            if(string.IsNullOrWhiteSpace(acc.GetUserName()) || 
               string.IsNullOrWhiteSpace(acc.GetPassword()) || 
               string.IsNullOrWhiteSpace(acc.GetEmployeeName()) || 
               string.IsNullOrWhiteSpace(acc.GetEmployeePhone()))
            {
                RJMessageBox.Show("Dữ liệu không thể để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (AccDAL.IsUsernameExists(acc.GetUserName()))
            {
                RJMessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!AccDAL.IsEmployeePhoneExists(acc.GetEmployeePhone()))
            {
                RJMessageBox.Show("SĐT chưa tồn tại trong bảng nhân viên hoặc chưa có nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                AccDAL.SaveAccount(acc);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tạo tài khoản: " + ex.Message);
                return false;
            }
        }

        public DataTable GetAllAccounts()
        {
            return AccDAL.GetAllAccounts();
        }

        public bool UpdateAccount(AccountManagementDTO acc)
        {
            if (string.IsNullOrWhiteSpace(acc.GetUserName()) || string.IsNullOrWhiteSpace(acc.GetPassword()))
            {
                RJMessageBox.Show("Tên tài khoản và mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!AccDAL.IsUsernameExists(acc.GetUserName()))
            {
                RJMessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            AccDAL.UpdateAccount(acc);
            return true;
        }
        public bool DeleteAccount(string username)
        {
            return AccDAL.DeleteAccount(username);
        }


    }
}
