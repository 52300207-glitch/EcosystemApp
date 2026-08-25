using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcosystemApp.DAL;
using EcosystemApp.DTO;

namespace EcosystemApp.BUS
{
    public class PrepareAssignmentBUS
    {
        // Add business logic methods here in the future
        private readonly PrepareAssignmentDAL PrepareAssignmentDAL = new PrepareAssignmentDAL();
        public bool AddPrepareAssignment(PrepareAssignmentDTO prepareAssignmentDTO)
        {
            // Placeholder for adding a prepare assignment
            try
            {
                PrepareAssignmentDAL.AssignPrepare(prepareAssignmentDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdatePrepareAssignment(PrepareAssignmentDTO prepareAssignmentDTO)
        {
            // Placeholder for updating a prepare assignment
            try
            {
                PrepareAssignmentDAL.UpdatePrepare(prepareAssignmentDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletePrepareAssignment(string orderID)
        {
            try
            {
                return PrepareAssignmentDAL.DeletePrepare(orderID);
            }
            catch
            {
                return false;
            }
        }

        public List<PrepareAssignmentDTO> GetAllPrepareAssignments()
        {
            // Placeholder for retrieving all prepare assignments
            return PrepareAssignmentDAL.GetAllPrepare();
        }
        public DataTable GetByID(int id) 
        {
            return PrepareAssignmentDAL.GetByID(id);
        }
    }
}
