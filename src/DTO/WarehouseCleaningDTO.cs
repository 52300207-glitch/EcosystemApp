using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class WarehouseCleaningDTO
    {
        private string ID;
        private string WarehouseID;
        private CleaningScheduleDTO CleaningSchedule;

        public WarehouseCleaningDTO(string id, string warehouseID, CleaningScheduleDTO cleaningSchedule)
        {
            this.ID = id;
            this.WarehouseID = warehouseID;
            this.CleaningSchedule = cleaningSchedule;
        }

        //getter and setter

        public string GetID() { return ID; }
        public string GetWarehouseID() { return WarehouseID; }
        public CleaningScheduleDTO GetCleaningSchedule() { return CleaningSchedule; }

        public void SetID(string id) { this.ID = id; }
        public void SetWarehouseID(string warehouseID) { WarehouseID = warehouseID; }
    }
}
