using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EcosystemApp.DTO;

namespace EcosystemApp.DAL
{
    public class ShiftAssignmentDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();

        public ShiftAssignmentDAL() { }

        public void InsertShiftAssignment(ShiftAssignmentDTO shiftAssignmentDTO)
        {
            string query = @"INSERT INTO ShiftAssignment(EmployeeID, ShiftID, WorkDate, Status, Notes)
                                    VALUES(@EmployeeID, @ShiftID, @WorkDate, @Status, @Notes)";
            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@EmployeeID", shiftAssignmentDTO.GetEmployee() != null ? shiftAssignmentDTO.GetEmployee().GetID() : null),
                new SQLiteParameter("@ShiftID", shiftAssignmentDTO.GetShift() != null ? shiftAssignmentDTO.GetShift().GetID(): null),
                new SQLiteParameter("@WorkDate", shiftAssignmentDTO.GetWorkDate()),
                new SQLiteParameter("@Status", shiftAssignmentDTO.GetStatus()),
                new SQLiteParameter("@Notes", shiftAssignmentDTO.GetNote())
                );
        }
        public bool UpdateShiftAssignment(ShiftAssignmentDTO dto)
        {
            string query = @"UPDATE ShiftAssignment
                             SET 
                                    EmployeeID = @EmployeeID,
                                    Status = @Status,
                                    Notes = @Notes
                             WHERE AssignmentID = @AssignmentID ";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@EmployeeID", dto.GetEmployee()?.GetID()),
                new SQLiteParameter("@Status", dto.GetStatus()),
                new SQLiteParameter("@Notes", dto.GetNote()),
                new SQLiteParameter("@AssignmentID", dto.GetAssignmentID())
            };

            int result = Db.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public void DeleteShift(int AssignmentID)
        {
            string query = "DELETE FROM ShiftAssignment WHERE AssignmentID=@AssignmentID";
            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@AssignmentID", AssignmentID)
                );
        }
        public List<ShiftAssignmentDTO> GetAllShift()
        {
            string query = @"SELECT sa.AssignmentID, sa.EmployeeID, sa.ShiftID, sa.WorkDate, sa.Status, sa.Notes,
                                    e.FullName, e.BirthDate, e.Position, e.Phone, e.Email, e.StationID,
                                    ws.ShiftName, ws.StartTime, ws.EndTime
                            FROM ShiftAssignment sa
                            JOIN Employee e ON sa.EmployeeID = e.EmployeeID
                            JOIN WorkShift ws ON sa.ShiftID = ws.ShiftID; ";

            DataTable dt = Db.ExecuteQuery(query);
            List<ShiftAssignmentDTO> list = new List<ShiftAssignmentDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                ShiftAssignmentDTO shift = new ShiftAssignmentDTO();
                shift.SetAssignmentID(Convert.ToInt32(dr["AssignmentID"]));

                // Employee
                var emp = new EmployeeDTO();
                emp.SetID(dr["EmployeeID"].ToString());
                emp.SetFullName(dr["FullName"].ToString());
                emp.SetDateOfBirth(dr["BirthDate"].ToString());
                emp.SetPosition(dr["Position"].ToString());
                emp.SetPhoneNumber(dr["Phone"].ToString());
                emp.SetEmail(dr["Email"].ToString());
                shift.SetEmployee(emp);

                // Shift
                var ws = new WorkShiftDTO();
                ws.SetID(Convert.ToInt32(dr["ShiftID"]));
                ws.SetShiftName(dr["ShiftName"].ToString());
                ws.SetStartTime(dr["StartTime"].ToString());
                ws.SetEndTime(dr["EndTime"].ToString());
                shift.SetShift(ws);

                shift.SetWorkDate(dr["WorkDate"].ToString());
                shift.SetStatus(dr["Status"].ToString());
                shift.SetNote(dr["Notes"].ToString());

                list.Add(shift);
            }
            return list;
        }

        public DataTable GetByID(int assignmentId)
        {
            string query = "SELECT * FROM ShiftAssignment WHERE AssignmentID = @AssignmentID";

            return Db.ExecuteQuery(query,
                new SQLiteParameter("@AssignmentID", assignmentId)
            );
        }

    }
}
