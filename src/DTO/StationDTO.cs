using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class StationDTO
    {
        private string ID;
        // điểu chinh thành thành WarehouseDTO nếu cần thiết
        private string Name;
        private string WarehouseID;
        private string Address;
        //constructor
        public StationDTO() { }
        public StationDTO(string id, string name, string warehouseID, string address)
        {
            ID = id;
            Address = address;
            Name = name;
            WarehouseID = warehouseID;
        }
        public StationDTO(string name, string warehouseID, string address)
        {
            Name = name;
            WarehouseID = warehouseID;
            Address = address;
        }
        //getters
        public string GetID() { return ID; }
        public string GetAddress() { return Address; }
        public string GetName() { return Name; }
        public string GetWarehouseID() { return WarehouseID; }
        //setters
        public void SetID(string id) { ID = id; }
        public void SetAddress(string address) { Address = address; }
        public void SetName(string name) { Name = name; }
        public void SetWarehouseID(string warehouseID) { WarehouseID = warehouseID; }
    }
}
