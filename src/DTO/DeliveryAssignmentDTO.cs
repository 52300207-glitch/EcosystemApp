using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class DeliveryAssignmentDTO
    {   
        private int ID;
        private string EmployeeID;
        private OrderDTO Order;
        private string Status;
        private string Note;

        public DeliveryAssignmentDTO() { }
        public DeliveryAssignmentDTO(int id, string employeeID, OrderDTO order, string status, string note)
        {
            ID = id;
            EmployeeID = employeeID;
            Order = order;
            Status = status;
            Note = note;
        }
        public int GetID() { return ID; }
        public string GetEmployeeID() { return EmployeeID; }
        public OrderDTO GetOrder() { return Order; }
        public string GetStatus() { return Status; }
        public string GetNote() { return Note; }
        public void SetID(int id) { ID = id; }
        public void SetEmployeeID(string employeeID) { EmployeeID = employeeID; }
        public void SetOrder(OrderDTO order) { Order = order; }
        public void SetStatus(string status) { Status = status; }
        public void SetNote(string note) { Note = note; }
    }
}
