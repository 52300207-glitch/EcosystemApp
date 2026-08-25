using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System.Data;

namespace EcosystemApp.BUS
{
    public class ShiftAssignmentBUS
    {
        private readonly ShiftAssignmentDAL shiftAssignmentDAL = new ShiftAssignmentDAL();
        public ShiftAssignmentBUS() { }

        public List<ShiftAssignmentDTO> GetAllShiftAssignments()
        {
            return shiftAssignmentDAL.GetAllShift();
        }
        public bool AddShiftAssignment(ShiftAssignmentDTO shiftAssignmentDTO)
        {
            try
            {
                shiftAssignmentDAL.InsertShiftAssignment(shiftAssignmentDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateShiftAssignment(ShiftAssignmentDTO shiftAssignmentDTO)
        {
            try
            {
                shiftAssignmentDAL.UpdateShiftAssignment(shiftAssignmentDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteShiftAssignment(int AssignmentID)
        {
            try
            {
                shiftAssignmentDAL.DeleteShift(AssignmentID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetByID(int assignmentId)
        {
            return shiftAssignmentDAL.GetByID(assignmentId);
        }
    }
}
