using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class PackagingTypeDTO
    {
        private string ID;
        private string TypeName;
        private string Material;
        private string Capacity;
        private int ReuseLimit;
        private decimal Deposit;

        //constructor 
        public PackagingTypeDTO(string id, string typeName, string material, int reuseLimit, decimal deposit)
        {
            ID = id;
            TypeName = typeName;
            Material = material;
            ReuseLimit = reuseLimit;
            Deposit = deposit;
        }

        // geters and setters
        public string GetID() { return ID; }

        public string GetTypeName() { return TypeName; }

        public string GetMaterial() { return Material; }

        public string GetCapacity() { return Capacity; }

        public int GetReuseLimit() { return ReuseLimit; }

        public decimal GetDeposit() { return Deposit; }
        public void SetDeposit(decimal deposit) { Deposit = deposit; }

        public void SetID(string id) { ID = id; }
        public void SetReuseLimit(int reuseLimit) { ReuseLimit = reuseLimit; }
        public void SetMaterial(string material) { Material = material; }

        public void SetTypeName(string typeName) { TypeName = typeName; }
    }
}
