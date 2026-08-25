using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class PackageDTO
    {
        private string ID;
        private PackagingTypeDTO PackagingType;
        private string Status;
        private int ReuseCount;
        private string SerialCode;
        
        public PackageDTO() { }
        public PackageDTO(string id, PackagingTypeDTO packagingType, string status, string reuseCount, string serialCode)
        {
            ID = id;
            PackagingType = packagingType;
            Status = status;
            ReuseCount = int.Parse(reuseCount);
            SerialCode = serialCode;
        }

        public string GetID() { return ID; }

        public string GetStatus() { return Status; }

        public int GetReuseCount() { return ReuseCount; }

        public PackagingTypeDTO GetPackagingType() { return PackagingType; }


        //setter
        public void SetStatus(string status) { Status = status; }

        public void SetReuseCount(int reuseCount) { ReuseCount = reuseCount; }

        public void SetSerialCode(string serialCode) { SerialCode = serialCode; }
        public string GetSerialCode() { return SerialCode; }
    }
}
