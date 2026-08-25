using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class PackagingCleaningDTO
    {
        private string ID;
        private PackageDTO Package;
        private CleaningScheduleDTO CleaningSchedule;

        public PackagingCleaningDTO(string id, PackageDTO package, CleaningScheduleDTO cleaningSchedule)
        {
            ID = id;
            Package = package;
            CleaningSchedule = cleaningSchedule;
        }

        //getter setter
        public string GetID() { return ID; }
        public PackageDTO GetPackage() { return Package; }
        public CleaningScheduleDTO GetCleaningSchedule() { return CleaningSchedule; }

        public void SetID(string id) { ID = id; }
        public void SetPackage(PackageDTO package) { Package = package; }
        public void SetCleaningSchedule(CleaningScheduleDTO cleaningSchedule) { CleaningSchedule = cleaningSchedule; }
    }
}
