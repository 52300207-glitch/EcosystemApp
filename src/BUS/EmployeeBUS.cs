using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace EcosystemApp.BUS
{
    public class EmployeeBUS
    {
        private readonly EmployeeDAL EmployeeDAL = new EmployeeDAL();

        public EmployeeBUS() { }

        // Lấy danh sách tất cả nhân viên
        public List<EmployeeDTO> GetEmployeeList()
        {
            return EmployeeDAL.GetAllEmployees();
        }
        public List<EmployeeDTO> GetEmployeeListByStation(string stationID)
        {
            DataTable dt = EmployeeDAL.GetEmployeesByStation(stationID);
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            foreach (DataRow dr in dt.Rows) {EmployeeDTO emp = new EmployeeDTO();
                emp.SetID(dr["EmployeeID"].ToString());
                emp.SetFullName(dr["FullName"].ToString());
                emp.SetDateOfBirth(dr["BirthDate"].ToString());
                emp.SetPosition(dr["Position"].ToString());
                emp.SetPhoneNumber(dr["Phone"].ToString());
                emp.SetEmail(dr["Email"].ToString());
                list.Add(emp);
            }
            return list;
        }

        // Lấy nhân viên theo ID
        public EmployeeDTO GetEmployeeByID(string id)
        {
            return EmployeeDAL.GetById(id);
        }

        // Thêm nhân viên
        public bool AddEmployee(EmployeeDTO employee)
        {
            // Kiểm tra trùng số điện thoại
            if (EmployeeDAL.IsExisted(employee))
                return false;

            // Tạo EmployeeID tự động
            employee.SetID(GenerateNewEmployeeID());

            try
            {
                EmployeeDAL.InsertEmployee(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật nhân viên
        public bool UpdateEmployee(EmployeeDTO employee)
        {
            try
            {
                EmployeeDAL.UpdateEmployee(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa nhân viên
        public bool DeleteEmployee(string employeeID)
        {
            try
            {
                EmployeeDAL.DeleteEmployee(employeeID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Tạo EmployeeID mới dạng EMP001, EMP002,...
        public string GenerateNewEmployeeID()
        {
            string lastID = EmployeeDAL.GetLastEmployeeID();
            if (string.IsNullOrEmpty(lastID))
                return "EMP001";

            // Tách số từ EmployeeID
            Match match = Regex.Match(lastID, @"EMP(\d+)");
            int number = 0;
            if (match.Success)
                number = int.Parse(match.Groups[1].Value);

            number++; // tăng lên
            return "EMP" + number.ToString("D3"); // D3 = 3 chữ số
        }
    }
}
