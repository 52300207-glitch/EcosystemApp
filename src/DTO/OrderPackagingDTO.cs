using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
     public class OrderPackagingDTO
     {
        private string ID;
        private PackageDTO Package;
        private string ActionType;
        private DateTime ActionDate;
        private decimal TotalBill;

        //constructor
        public OrderPackagingDTO() { }
        public OrderPackagingDTO(string id, PackageDTO package, string actionType, DateTime actionDate, decimal totalBill)
        {
            ID = id;
            Package = package;
            ActionType = actionType;
            ActionDate = actionDate;
            TotalBill = totalBill;  
        }

        //getters

        public string GetID() { return ID; }
        public PackageDTO GetPackage() { return Package; }
        public string GetActionType() { return ActionType; }
        public DateTime GetActionDate() { return ActionDate; }
        //setters
        public void SetID(string id) { ID = id; }
        public void SetPackage(PackageDTO package) { Package = package; }
        public void SetActionType(string actionType) { ActionType = actionType; }
        public void SetActionTime(DateTime actionDate) { ActionDate = actionDate; }
        public decimal GetTotalBill() { return TotalBill; }
        public void SetTotalBill(decimal totalBill) { TotalBill = totalBill; }

    }
}
