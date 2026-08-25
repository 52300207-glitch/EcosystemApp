
using System;

namespace EcosystemApp.DTO
{
    public class UserDTO
    {
        private int Id;
        private string EmpPhone;
        private string Username;
        private string Password;
        private EmployeeDTO Employee;

        // Constructor mặc định
        public UserDTO() { }

        // Constructor đăng nhập
        public UserDTO(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Constructor đầy đủ
        public UserDTO(int id, string username, string password, string empPhone, EmployeeDTO employee)
        {
            Id = id;
            Username = username;
            Password = password;
            EmpPhone = empPhone;
            Employee = employee;
        }

        // Getters
        public int GetID() { return Id; }
        public string GetUsername() { return Username; }
        public string GetPassword() { return Password; }
        public string GetEmpPhone() { return EmpPhone; }
        public EmployeeDTO GetEmployee() { return Employee; }

        // Setters
        public void SetID(int id) { Id = id; }
        public void SetUsername(string username) { Username = username; }
        public void SetPassword(string password) { Password = password; }
        public void SetEmpPhone(string empPhone) { EmpPhone = empPhone; }
        public void SetEmployee(EmployeeDTO employee) { Employee = employee; }
    }
}
