using DocumentFormat.OpenXml.Bibliography;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu WarehouseCleaning, bao gồm CRUD liên quan đến lịch dọn dẹp kho.
    /// </summary>
    public class WarehouseCleaningDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();
        private readonly CleaningScheduleDAL CleaningScheduleDAL = new CleaningScheduleDAL();

        /// <summary>
        /// Lấy danh sách WarehouseCleaning theo WarehouseID.
        /// </summary>
        /// <param name="warehouseID">ID của kho.</param>
        /// <returns>Danh sách WarehouseCleaningDTO.</returns>
        public List<WarehouseCleaningDTO> GetByWarehouseID(string warehouseID)
        {
            var list = new List<WarehouseCleaningDTO>();
            string sqlQuery = @"SELECT wc.WarehouseCleaningID, wc.WarehouseID, cs.CleaningID, cs.CleaningDate, cs.Status, cs.StartTime, cs.EndTime
                  FROM WarehouseCleaning wc
                  INNER JOIN CleaningSchedule cs ON wc.CleaningID = cs.CleaningID
                  WHERE wc.WarehouseID = @WarehouseID";
            var result = Db.ExecuteQuery(sqlQuery,
                        new System.Data.SQLite.SQLiteParameter("@WarehouseID", warehouseID)
                   );

            foreach (System.Data.DataRow row in result.Rows)
            {
                var cleaningSchedule = new CleaningScheduleDTO(
                    row["CleaningID"].ToString(),
                    DateTime.Parse(row["CleaningDate"].ToString()),
                    row["Status"].ToString(),
                    DateTime.Parse(row["StartTime"].ToString()),
                    DateTime.Parse(row["EndTime"].ToString())
                );

                var warehouseCleaning = new WarehouseCleaningDTO(
                    row["WarehouseCleaningID"].ToString(),
                    row["WarehouseID"].ToString(),
                    cleaningSchedule
                );

                list.Add(warehouseCleaning);
            }

            return list;
        }

        /// <summary>
        /// Lưu một WarehouseCleaning mới vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="warehouseCleaning">Đối tượng WarehouseCleaningDTO cần lưu.</param>
        public void Save(WarehouseCleaningDTO warehouseCleaning)
        {
            string sqlQuery = @"
                INSERT INTO WarehouseCleaning 
                (WarehouseCleaningID, WarehouseID, CleaningID) 
                VALUES 
                (@WarehouseCleaningID, @WarehouseID, @CleaningID)";

            var parameters = new System.Data.SQLite.SQLiteParameter[]
            {
                new System.Data.SQLite.SQLiteParameter("@WarehouseCleaningID", warehouseCleaning.GetID()),
                new System.Data.SQLite.SQLiteParameter("@WarehouseID", warehouseCleaning.GetWarehouseID()),
                new System.Data.SQLite.SQLiteParameter("@CleaningID", warehouseCleaning.GetCleaningSchedule().GetID())
            };

            Db.ExecuteNonQuery(sqlQuery, parameters);
            CleaningScheduleDAL.Save(warehouseCleaning.GetCleaningSchedule());
        }

        /// <summary>
        /// Cập nhật trạng thái CleaningSchedule liên quan đến WarehouseCleaning.
        /// </summary>
        /// <param name="job">Đối tượng WarehouseCleaningDTO cần cập nhật.</param>
        public void Update(WarehouseCleaningDTO job)
        {
            CleaningScheduleDAL.UpdateStatus(job.GetCleaningSchedule());
        }

        /// <summary>
        /// Xóa WarehouseCleaning và CleaningSchedule liên quan.
        /// </summary>
        /// <param name="job">Đối tượng WarehouseCleaningDTO cần xóa.</param>
        public void Delete(WarehouseCleaningDTO job)
        {
            string sqlQuery = "DELETE FROM WarehouseCleaning WHERE WarehouseCleaningID = @WarehouseCleaningID AND CleaningID = @CleaningID";

            var parameters = new System.Data.SQLite.SQLiteParameter[]
            {
                new System.Data.SQLite.SQLiteParameter("@WarehouseCleaningID", job.GetID()),
                new System.Data.SQLite.SQLiteParameter("@CleaningID", job.GetCleaningSchedule().GetID())
            };
            Db.ExecuteNonQuery(sqlQuery, parameters);
            CleaningScheduleDAL.Delete(job.GetCleaningSchedule());
        }
    }
}
