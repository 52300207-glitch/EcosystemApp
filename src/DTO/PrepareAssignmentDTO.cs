using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class PrepareAssignmentDTO
    {
        private int PrepareID;
        private EmployeeDTO Employee;
        private OrderDTO Order;
        private string Note;

        //constructor
        public PrepareAssignmentDTO() { }
        public PrepareAssignmentDTO(int prepareID, EmployeeDTO employee, OrderDTO order, string note)
        {
            PrepareID = prepareID;
            Employee = employee;
            Order = order;
            Note = note;
        }
        //getters
        public int GetPrepareID() { return PrepareID; }
        public EmployeeDTO GetEmployee() { return Employee; }
        public OrderDTO GetOrder() { return Order; }
        public string GetNote() { return Note; }
        // setters
        public void SetPrepareID(int prepareID) { PrepareID = prepareID; }
        public void SetEmployee(EmployeeDTO employee) { Employee = employee; }
        public void SetOrder(OrderDTO order) { Order = order; }
        public void SetNote(string note) { Note = note; }
    }
}
