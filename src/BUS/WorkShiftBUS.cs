using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    public class WorkShiftBUS
    {
        private WorkShiftDAL WorkShiftDAL = new WorkShiftDAL();

        public List<WorkShiftDTO> GetAllWorkShift()
        {
            return WorkShiftDAL.GetAllWorkShift();
        }
        public WorkShiftDTO GetWorkShiftByID(int id)
        {
            return WorkShiftDAL.GetWorkShiftByID(id);
        }
    }

}
