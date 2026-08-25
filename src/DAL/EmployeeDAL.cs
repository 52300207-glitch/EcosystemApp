using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace EcosystemApp.DAL
{
    public class EmployeeDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper(); // Đối tượng làm việc với database

        public EmployeeDAL() { } // Constructor mặc định

        // Thêm nhân viên
        public void InsertEmployee(EmployeeDTO employee)
        {
            // Câu lệnh INSERT thêm nhân viên mới
            string query = @"INSERT INTO Employee(EmployeeID, FullName, BirthDate, Position, Phone, Email, StationID)
                             VALUES(@EmployeeID, @FullName, @BirthDate, @Position, @Phone, @Email, @StationID)";
            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@EmployeeID", employee.GetID()),
                new SQLiteParameter("@FullName", employee.GetFullName()),
                new SQLiteParameter("@BirthDate", employee.GetDateOfBirth()), // BirthDate lưu dạng string
                new SQLiteParameter("@Position", employee.GetPosition()),
                new SQLiteParameter("@Phone", employee.GetPhoneNumber()),
                new SQLiteParameter("@Email", employee.GetEmail()),
                new SQLiteParameter("@StationID", employee.GetStation() != null ? employee.GetStation().GetID() : null) // StationID có thể null
            );
        }

        // Cập nhật nhân viên
        public void UpdateEmployee(EmployeeDTO employee)
        {
            // Câu lệnh UPDATE cập nhật thông tin nhân viên
            string query = @"UPDATE Employee
                             SET FullName=@FullName,
                                 BirthDate=@BirthDate,
                                 Position=@Position,
                                 Phone=@Phone,
                                 Email=@Email,
                                 StationID=@StationID
                             WHERE EmployeeID=@EmployeeID";
            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@FullName", employee.GetFullName()),
                new SQLiteParameter("@BirthDate", employee.GetDateOfBirth()),
                new SQLiteParameter("@Position", employee.GetPosition()),
                new SQLiteParameter("@Phone", employee.GetPhoneNumber()),
                new SQLiteParameter("@Email", employee.GetEmail()),
                new SQLiteParameter("@StationID", employee.GetStation() != null ? employee.GetStation().GetID() : null),
                new SQLiteParameter("@EmployeeID", employee.GetID())
            );
        }

        // Xóa nhân viên
        public void DeleteEmployee(string employeeID)
        {
            // Câu lệnh DELETE theo EmployeeID
            string query = "DELETE FROM Employee WHERE EmployeeID=@EmployeeID";
            Db.ExecuteNonQuery(query, new SQLiteParameter("@EmployeeID", employeeID));
        }

        // Kiểm tra trùng số điện thoại
        public bool IsExisted(EmployeeDTO employee)
        {
            // Lấy nhân viên theo số điện thoại
            string query = "SELECT * FROM Employee WHERE Phone=@Phone";
            List<SQLiteParameter> parameters = new List<SQLiteParameter>
            {
                new SQLiteParameter("@Phone", employee.GetPhoneNumber())
            };

            // Loại bỏ nhân viên hiện tại khi kiểm tra trùng (dành cho update)
            if (!string.IsNullOrEmpty(employee.GetID()))
            {
                query += " AND EmployeeID<>@EmployeeID";
                parameters.Add(new SQLiteParameter("@EmployeeID", employee.GetID()));
            }

            DataTable dt = Db.ExecuteQuery(query, parameters.ToArray());
            return dt.Rows.Count > 0; // Có dữ liệu → trùng
        }

        // Lấy nhân viên theo ID
        public EmployeeDTO GetById(string id)
        {
            // Lấy chi tiết nhân viên + thông tin trạm làm việc
            string query = @"SELECT e.EmployeeID, e.FullName, e.BirthDate, e.Position, e.Phone, e.Email, 
                        e.StationID, s.StationName, s.WarehouseID, s.Address
                 FROM Employee e
                 LEFT JOIN Station s ON e.StationID = s.StationID
                 WHERE e.EmployeeID = @EmployeeID";

            DataTable dt = Db.ExecuteQuery(query, new SQLiteParameter("@EmployeeID", id));
            if (dt.Rows.Count == 0) return null; // Không có dữ liệu

            DataRow row = dt.Rows[0];
            EmployeeDTO emp = new EmployeeDTO();

            // Gán dữ liệu cho EmployeeDTO
            emp.SetID(row["EmployeeID"].ToString());
            emp.SetFullName(row["FullName"].ToString());
            emp.SetDateOfBirth(row["BirthDate"].ToString());
            emp.SetPosition(row["Position"].ToString());
            emp.SetPhoneNumber(row["Phone"].ToString());
            emp.SetEmail(row["Email"].ToString());

            // Nếu có StationID thì tạo StationDTO
            if (row["StationID"] != DBNull.Value)
            {
                StationDTO station = new StationDTO();
                station.SetID(row["StationID"].ToString());
                station.SetName(row["StationName"].ToString());
                station.SetWarehouseID(row["WarehouseID"].ToString());
                station.SetAddress(row["Address"].ToString()); // Thông tin địa chỉ trạm

                emp.SetStation(station);
            }

            return emp;
        }

        // Lấy toàn bộ nhân viên
        public List<EmployeeDTO> GetAllEmployees()
        {
            // Lấy toàn bộ nhân viên + thông tin trạm bằng JOIN
            string query = @"SELECT e.EmployeeID, e.FullName, e.BirthDate, e.Position, e.Phone, e.Email,
                        e.StationID, s.StationName, s.WarehouseID, s.Address
                 FROM Employee e
                 LEFT JOIN Station s ON e.StationID = s.StationID";

            DataTable dt = Db.ExecuteQuery(query);
            List<EmployeeDTO> list = new List<EmployeeDTO>();

            // Chuyển từng dòng trong DataTable sang EmployeeDTO
            foreach (DataRow row in dt.Rows)
            {
                EmployeeDTO emp = new EmployeeDTO();
                emp.SetID(row["EmployeeID"].ToString());
                emp.SetFullName(row["FullName"].ToString());
                emp.SetDateOfBirth(row["BirthDate"].ToString());
                emp.SetPosition(row["Position"].ToString());
                emp.SetPhoneNumber(row["Phone"].ToString());
                emp.SetEmail(row["Email"].ToString());

                // Nếu có thông tin trạm
                if (row["StationID"] != DBNull.Value)
                {
                    StationDTO station = new StationDTO();
                    station.SetID(row["StationID"].ToString());
                    station.SetName(row["StationName"].ToString());
                    station.SetWarehouseID(row["WarehouseID"].ToString());
                    station.SetAddress(row["Address"].ToString());

                    emp.SetStation(station);
                }

                list.Add(emp);
            }

            return list; // Trả về danh sách nhân viên
        }
        public DataTable GetEmployeesByStation(string stationID)
        {
            // Lấy nhân viên theo StationID
            string query = @"SELECT e.EmployeeID, e.FullName, e.BirthDate, e.Position, e.Phone, e.Email,
                            e.StationID, s.StationName, s.WarehouseID, s.Address
                     FROM Employee e
                     LEFT JOIN Station s ON e.StationID = s.StationID
                     WHERE e.StationID = @StationID"; // filter theo trạm

            // Thêm parameter để tránh SQL injection
            SQLiteParameter param = new SQLiteParameter("@StationID", stationID);


            return Db.ExecuteQuery(query,param);
        }


        // Lấy EmployeeID lớn nhất để tạo ID mới
        public string GetLastEmployeeID()
        {
            // Lấy tất cả EmployeeID trong bảng
            string query = "SELECT EmployeeID FROM Employee";
            DataTable dt = Db.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null; // Chưa có nhân viên nào

            int maxNumber = 0;

            // Duyệt qua tất cả EmployeeID để tìm số lớn nhất
            foreach (DataRow row in dt.Rows)
            {
                string empID = row["EmployeeID"].ToString();
                Match match = Regex.Match(empID, @"EMP(\d+)"); // Tìm số phía sau EMP
                if (match.Success && int.TryParse(match.Groups[1].Value, out int num))
                {
                    if (num > maxNumber)
                        maxNumber = num; // Cập nhật số lớn nhất
                }
            }

            // Trả về theo format EMP###
            return "EMP" + maxNumber.ToString("D3");
        }
    }
}
