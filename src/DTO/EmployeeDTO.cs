using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class EmployeeDTO
    {
        private string ID;
        private string FullName;
        private string Position;
        private string DateOfBirth;
        private string PhoneNumber;
        private string Email;
        private StationDTO Station;

 
        //constructor
        public EmployeeDTO() { }

        public EmployeeDTO(string id, string fullName, string dateOfBirth, string position, string phoneNumber, string email, StationDTO station)
        {
            ID = id;
            FullName = fullName;
            Position = position;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Station = station;
        }

        public EmployeeDTO(string fullName, String dateOfBirth, string phoneNumber, string position, string email, StationDTO station)
        {
            FullName = fullName;
            Position = position;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Station = station;
        }

        //getters 
        public string GetID() { return ID; }
        public string GetFullName() { return FullName; }
        public string GetPosition() { return Position; }
        public string GetDateOfBirth() { return DateOfBirth; }
        public string GetPhoneNumber() { return PhoneNumber; }
        public string GetEmail() { return Email; }
        public StationDTO GetStation() { return Station; }

        //setters
        public void SetID(string id) { ID = id; }
        public void SetFullName(string fullName) { FullName = fullName; }
        public void SetPosition(string position) { Position = position; }
        public void SetDateOfBirth(string dateOfBirth) { DateOfBirth = dateOfBirth; }
        public void SetPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; }
        public void SetEmail(string email) { Email = email; }
        public void SetStation(StationDTO station) { Station = station; }
    }
}
