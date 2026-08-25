using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;
using System.Data.SQLite;


public class WorkShiftDAL
{
    private DatabaseHelper Db = new DatabaseHelper();

    public List<WorkShiftDTO> GetAllWorkShift()
    {
        string query = "SELECT ShiftID, ShiftName, StartTime, EndTime FROM WorkShift";
        DataTable dt = Db.ExecuteQuery(query);
        List<WorkShiftDTO> list = new List<WorkShiftDTO>();
        foreach (DataRow row in dt.Rows)
        {
            WorkShiftDTO workShiftDTO = new WorkShiftDTO();
            workShiftDTO.SetID(Convert.ToInt32(row["ShiftID"]));
            workShiftDTO.SetShiftName(row["ShiftName"].ToString());
            workShiftDTO.SetStartTime(row["StartTime"].ToString());
            workShiftDTO.SetEndTime(row["EndTime"].ToString());
            list.Add(workShiftDTO);
        }
        return list;
    }
    public WorkShiftDTO GetWorkShiftByID(int id)
    {
        string query = "SELECT ShiftID, ShiftName, StartTime, EndTime FROM WorkShift WHERE ShiftID = @ShiftID";
        SQLiteParameter[] parameters = {
            new SQLiteParameter("@ShiftID", id)
        };
        DataTable dt = Db.ExecuteQuery(query, parameters);
        if (dt.Rows.Count == 0) return null;

        DataRow row = dt.Rows[0];
        WorkShiftDTO workShiftDTO = new WorkShiftDTO();
        workShiftDTO.SetID(Convert.ToInt32(row["ShiftID"]));
        workShiftDTO.SetShiftName(row["ShiftName"].ToString());
        workShiftDTO.SetStartTime(row["StartTime"].ToString());
        workShiftDTO.SetEndTime(row["EndTime"].ToString());
        return workShiftDTO;
    }
}
