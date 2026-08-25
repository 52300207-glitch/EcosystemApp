using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class CustomerDTO
    {
        private string ID;
        private string FullName;
        private string Address;
        private string PhoneNumber;
        private string Email;

        //constructor
        public CustomerDTO() { }

        public CustomerDTO(string id, string fullName, string address,string phoneNumber, string email)
        {
            ID = id;
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public CustomerDTO(string fullName, string address, string phoneNumber, string email)
        {
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        //getters
        public string GetID() { return ID; }
        public string GetFullName() { return FullName; }
        public string GetAddress() { return Address; }
        public string GetPhoneNumber() { return PhoneNumber; }
        public string GetEmail() { return Email; }
        //setters
        public void SetID(string id) { ID = id; }
        public void SetFullName(string fullName) { FullName = fullName; }
        public void SetAddress(string address) { Address = address; }
        public void SetPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; }
        public void SetEmail(string email) { Email = email; }

    }
}
