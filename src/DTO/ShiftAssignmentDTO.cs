using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class ShiftAssignmentDTO
    {
        private int AssignmentID;
        private WorkShiftDTO Shift;
        private EmployeeDTO Employee;
        private string WorkDate;
        private string Status;
        private string Notes;
        
        public ShiftAssignmentDTO() { }
        public ShiftAssignmentDTO(int assignmentID, WorkShiftDTO shift, EmployeeDTO employee, string workDate, string status, string notes)
        {
            AssignmentID = assignmentID;
            Shift = shift;
            Employee = employee;
            WorkDate = workDate;
            Status = status;
            Notes = notes;
        }

        public int GetAssignmentID() { return  AssignmentID; }
        public WorkShiftDTO GetShift() { return Shift; }
        public EmployeeDTO GetEmployee() { return Employee; }
        public string GetWorkDate() { return WorkDate; }
        public string GetStatus() { return Status; }
        public string GetNote() { return Notes; }

        public void SetAssignmentID(int assignmentID) { AssignmentID = assignmentID; }
        public void SetShift(WorkShiftDTO shiftID) { Shift = shiftID; }  
        public void SetEmployee(EmployeeDTO employee) { Employee = employee; }
        public void SetWorkDate(string workDate) { WorkDate = workDate; }
        public void SetStatus(string status) { Status = status; }
        public void SetNote(string note) { Notes = note; }
    }
}
