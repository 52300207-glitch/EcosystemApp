using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class WarehouseDTO
    {
        private string ID;
        private string Location;
        private string Name;
        private bool IsCentral;

        //constructor
        public WarehouseDTO() { }
        public WarehouseDTO(string id, string location, string name, bool isCentral)
        {
            ID = id;
            Location = location;
            Name = name;
            IsCentral = isCentral;
        }
        public WarehouseDTO(string location, string name, bool isCentral)
        {
            Location = location;
            Name = name;
            IsCentral = isCentral;

        }

        //getters
        public string GetID() { return ID; }
        public string GetLocation() { return Location; }
        public string GetName() { return Name; }
        public bool GetIsCentral() { return IsCentral; }

        //setters
        public void SetID(string id) { ID = id; }
        public void SetLocation(string location) { Location = location; }
        public void SetName(string name) { Name = name; }
    }
}
