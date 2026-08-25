using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class AccountManagementDTO
    {
        private string EmployeePhone;
        private string Username;
        private string Password;
        private string EmployeeName;

        public AccountManagementDTO() { }

        public AccountManagementDTO(string employeePhone, string username, string password, string employeeName)
        {
            this.EmployeePhone = employeePhone;
            this.Username = username;
            this.Password = password;
            this.EmployeeName = employeeName;
        }

        public string GetEmployeePhone() { return EmployeePhone; }
        public string GetUserName() { return Username; }
        public string GetPassword() { return Password; }
        public string GetEmployeeName() { return EmployeeName; }

        public void SetEmployeePhone(string employeePhone) { this.EmployeePhone = employeePhone; }
        public void SetUserName(string userName) { this.Username = userName; }
        public void SetPassword(string password) { this.Password = password; }
        public void SetEmployeeName(string employeeName) { this.EmployeeName =employeeName; }
    }
}
