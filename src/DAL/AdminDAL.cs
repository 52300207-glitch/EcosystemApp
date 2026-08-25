using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;
using System.Data.SQLite;

namespace EcosystemApp.DAL
{
    public class AdminDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();

        public AdminDTO CheckLogin(string username, string password)
        {
            string query = "SELECT Id, Username, Password FROM Admin WHERE Username = @username AND Password = @password";
            DataTable dt = Db.ExecuteQuery(query,
                    new SQLiteParameter("@username", username),
                    new SQLiteParameter("@password", password)
                    );
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                var admin = new AdminDTO();
                admin.SetID(Convert.ToInt32(row["Id"]));
                admin.SetUsername(row["Username"].ToString());
                admin.SetPassword(row["Password"].ToString());
                return admin;
            }
            return null;
        }
        public string GetPasswordByUsername(string username)
        {
            string query = "SELECT Password FROM Admin WHERE username = @UserName";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@UserName", username)
            };

            DataTable dt = Db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return null; // Không tìm thấy username

            return dt.Rows[0]["Password"].ToString();
        }
        public AdminDTO GetAdminAccount()
        {
            string query = "SELECT * FROM Admin LIMIT 1";
            DataTable dt = Db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new AdminDTO(
                    row["UserName"].ToString(),
                    row["Password"].ToString()
                );
            }

            return null;
        }
        public void UpdatePassword(string newPass)
        {
            string query = @"UPDATE Admin
                         SET Password = @Password
                         WHERE Id = 1";
            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@Password", newPass),
                new SQLiteParameter("@Id", 1)
            );
        }

    }
}