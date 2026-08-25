using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace EcosystemApp.DAL
{
    public class AccountManagementDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();
       


        public void SaveAccount(AccountManagementDTO accDAL) 
        {
            string query = @"INSERT INTO User(EmpPhone,Username,Password)" + 
                            "VALUES(@EmpPhone,@Username,@Password)";

            Db.ExecuteNonQuery(query,
                new System.Data.SQLite.SQLiteParameter("@EmpPhone",accDAL.GetEmployeePhone()),
                new System.Data.SQLite.SQLiteParameter("@Username", accDAL.GetUserName()),
                new System.Data.SQLite.SQLiteParameter("@Password", accDAL.GetPassword())
                );
        }
        public bool IsUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM User WHERE Username = @Username";
            DataTable result = Db.ExecuteQuery(query, new SQLiteParameter("@Username", username));

            int count = Convert.ToInt32(result.Rows[0][0]);
            return count > 0;
        }

        public bool IsEmployeePhoneExists(string employeePhone)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE Phone = @employeePhone";
            DataTable result = Db.ExecuteQuery(query, new SQLiteParameter("@employeePhone", employeePhone));

            int count = Convert.ToInt32(result.Rows[0][0]);
            return count > 0;
        }

        public DataTable GetAllAccounts()
        {
            string query = @"SELECT u.EmpPhone AS 'Số điện thoại nhân viên',
                                    e.FullName AS 'Tên nhân viên',
                                    u.Username AS 'Tên tài khoản',
                                    u.Password AS 'Mật khẩu' 
                              FROM User u 
                              JOIN Employee e ON u.EmpPhone = e.Phone ";
            DataTable result = Db.ExecuteQuery(query);
            return result;
        }
        public void UpdateAccount(AccountManagementDTO acc)
        {
            string query = @"UPDATE User
                         SET Password = @Password
                         WHERE Username = @Username;";
            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@Password", acc.GetPassword()),
                new SQLiteParameter("@Username", acc.GetUserName())
            );
        }
        public bool DeleteAccount(string username)
        {
            string query = "DELETE FROM User WHERE Username = @Username";

            try
            {
                int rowsAffected = Db.ExecuteNonQuery(query, new SQLiteParameter("@Username", username));
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa tài khoản: " + ex.Message);
                return false;
            }
        }
    }
}
