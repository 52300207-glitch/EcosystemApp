using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcosystemApp.DTO;

namespace EcosystemApp.DAL
{
    public class PrepareAssignmentDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();
        public void AssignPrepare(PrepareAssignmentDTO prepareAssignmentDTO)
        {
            string query = @"INSERT INTO PrepareAssignment(EmployeeID, OrderID, Notes)
                             VALUES(@EmployeeID, @OrderID, @Notes)";
            int affected = Db.ExecuteNonQuery(query,
                new System.Data.SQLite.SQLiteParameter("@EmployeeID", prepareAssignmentDTO.GetEmployee().GetID()),
                new System.Data.SQLite.SQLiteParameter("@OrderID", prepareAssignmentDTO.GetOrder().GetID()),
                new System.Data.SQLite.SQLiteParameter("@Notes", prepareAssignmentDTO.GetNote())
                );
            if (affected == 0)
                throw new InvalidOperationException("INSERT affected 0 rows. Check constraints / duplicate key.");
        }
        public void UpdatePrepare(PrepareAssignmentDTO prepareAssignmentDTO)
        {
            string query = @"UPDATE PrepareAssignment
                             SET EmployeeID=@EmployeeID,
                                 Notes=@Notes
                             WHERE OrderID=@OrderID";
            Db.ExecuteNonQuery(query,
                new System.Data.SQLite.SQLiteParameter("@EmployeeID", prepareAssignmentDTO.GetEmployee().GetID()),
                new System.Data.SQLite.SQLiteParameter("@Notes", prepareAssignmentDTO.GetNote()),
                new System.Data.SQLite.SQLiteParameter("@OrderID", prepareAssignmentDTO.GetOrder().GetID())
                );
        }
        public bool DeletePrepare(string orderID)
        {
            string query = "DELETE FROM PrepareAssignment WHERE OrderID = @OrderID";

            int affected = Db.ExecuteNonQuery(
                query,
                new SQLiteParameter("@OrderID", orderID)
            );

            return affected > 0;
        }

        public List<PrepareAssignmentDTO> GetAllPrepare()
        {
            string query = @"SELECT pa.EmployeeID AS EmployeeID,
                                    e.FullName    AS EmployeeName,
                                    pa.OrderID    AS OrderID,
                                    pa.Notes   AS Notes
                             FROM PrepareAssignment pa
                             JOIN Employee e ON pa.EmployeeID = e.EmployeeID";
            DataTable dt = Db.ExecuteQuery(query);
            List<PrepareAssignmentDTO> List = new List<PrepareAssignmentDTO>();
            foreach (DataRow row in dt.Rows)
            {
                PrepareAssignmentDTO dto = new PrepareAssignmentDTO();
                EmployeeDTO emp = new EmployeeDTO();
                OrderDTO order = new OrderDTO();
                emp.SetID(row["EmployeeID"].ToString());
                emp.SetFullName(row["EmployeeName"].ToString());
                order.SetID(row["OrderID"].ToString());
                dto.SetEmployee(emp);
                dto.SetOrder(order);
                dto.SetNote(row["Notes"].ToString());
                List.Add(dto);
            }
            return List;
        }
        public DataTable GetByID(int prepareID)
        {
            string query = "SELECT * FROM PrepareAssignment WHERE PrepareID = @PrepareID";

            return Db.ExecuteQuery(query,
                new SQLiteParameter("@PrepareID", prepareID)
            );
        }
    }
}
