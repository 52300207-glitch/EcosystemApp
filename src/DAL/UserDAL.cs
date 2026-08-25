using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Data;
using System.Data.SQLite;

namespace EcosystemApp.DAL
{
    public class UserDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();
        public UserDTO GetUserWithEmployee(string username, string password)
        {
            string query = @"
        SELECT 
            u.Id,
            u.Username,
            u.Password,
            u.EmpPhone,

            e.EmployeeID,
            e.FullName,
            e.Position,
            e.BirthDate,
            e.Phone,
            e.Email,
            e.StationID,

            s.StationID AS S_StationID,
            s.StationName AS S_StationName,
            s.WarehouseID AS S_WarehouseID
        FROM ""User"" AS u
        JOIN Employee AS e ON u.EmpPhone = e.Phone
        LEFT JOIN Station AS s ON e.StationID = s.StationID
        WHERE u.Username = @username AND u.Password = @password;
    ";

            var parameters = new SQLiteParameter[]
            {
        new SQLiteParameter("@username", username),
        new SQLiteParameter("@password", password)
            };

            try
            {
                DataTable dt = Db.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    // 🔹 Tạo EmployeeDTO
                    var emp = new EmployeeDTO();
                    emp.SetID(row["EmployeeID"].ToString());
                    emp.SetFullName(row["FullName"].ToString());
                    emp.SetPosition(row["Position"].ToString());
                    emp.SetDateOfBirth(row["BirthDate"].ToString());
                    emp.SetPhoneNumber(row["Phone"].ToString());
                    emp.SetEmail(row["Email"].ToString());
                    var station = new StationDTO();
                    station.SetID(row["S_StationID"].ToString());
                    station.SetName(row["S_StationName"].ToString());
                    station.SetWarehouseID(row["S_WarehouseID"].ToString());
                    emp.SetStation(station);


                    // 🔹 Tạo UserDTO
                    var user = new UserDTO();
                    user.SetID(Convert.ToInt32(row["Id"]));
                    user.SetUsername(row["Username"].ToString());
                    user.SetPassword(row["Password"].ToString());
                    user.SetEmpPhone(row["EmpPhone"].ToString());
                    user.SetEmployee(emp);

                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi SQLite: " + ex.Message, "Lỗi truy vấn",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
