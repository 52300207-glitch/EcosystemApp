using EcosystemApp.Utils;
using EcosystemApp.DTO;
using System;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// DAL xử lý các thao tác CRUD liên quan đến lịch vệ sinh (Cleaning Schedule)
    /// </summary>
    public class CleaningScheduleDAL
    {
        // Đối tượng DatabaseHelper để thao tác với database
        private readonly DatabaseHelper Db = new DatabaseHelper();

        /// <summary>
        /// Lấy thông tin lịch vệ sinh theo ID
        /// </summary>
        /// <param name="id">ID của lịch vệ sinh</param>
        /// <returns>Đối tượng CleaningScheduleDTO hoặc null nếu không tìm thấy</returns>
        public CleaningScheduleDTO GetById(string id)
        {
            // Câu truy vấn SELECT theo ID
            string sqlQuery = "SELECT * FROM CleaningSchedule WHERE CleaningID = @CleaningID";

            // Thực thi truy vấn và truyền tham số
            var result = Db.ExecuteQuery(sqlQuery,
                new System.Data.SQLite.SQLiteParameter("@CleaningID", id)
            );

            // Nếu có dữ liệu trả về thì chuyển sang DTO
            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];

                // Tạo và trả về đối tượng DTO chứa dữ liệu lịch vệ sinh
                return new CleaningScheduleDTO(
                    row["CleaningID"].ToString(),
                    DateTime.Parse(row["CleaningDate"].ToString()),
                    row["Status"].ToString(),
                    DateTime.Parse(row["StartTime"].ToString()),
                    DateTime.Parse(row["EndTime"].ToString())
                );
            }

            // Không có dữ liệu thì trả về null
            return null;
        }

        /// <summary>
        /// Lưu lịch vệ sinh mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="schedule">Đối tượng lịch vệ sinh cần lưu</param>
        /// <returns>Số dòng bị ảnh hưởng trong DB</returns>
        public int Save(CleaningScheduleDTO schedule)
        {
            // Câu lệnh INSERT để thêm mới lịch vệ sinh
            string sqlQuery = @"INSERT INTO CleaningSchedule 
                    (CleaningID, CleaningDate, Status, StartTime, EndTime) 
                    VALUES 
                    (@CleaningID, @CleaningDate, @Status, @StartTime, @EndTime)";

            // Tạo danh sách tham số truyền vào truy vấn
            var parameters = new System.Data.SQLite.SQLiteParameter[]
            {
                new System.Data.SQLite.SQLiteParameter("@CleaningID", schedule.GetID()),
                new System.Data.SQLite.SQLiteParameter("@CleaningDate", schedule.GetDate().ToString("yyyy-MM-dd")),
                new System.Data.SQLite.SQLiteParameter("@Status", schedule.GetStatus()),
                new System.Data.SQLite.SQLiteParameter("@StartTime", schedule.GetStartTime().ToString("HH:mm")),
                new System.Data.SQLite.SQLiteParameter("@EndTime", schedule.GetEndTime().ToString("HH:mm"))
            };

            // Thực thi câu lệnh INSERT và trả về số dòng bị ảnh hưởng
            return Db.ExecuteNonQuery(sqlQuery, parameters);
        }

        /// <summary>
        /// Cập nhật trạng thái của một lịch vệ sinh
        /// </summary>
        /// <param name="schedule">Đối tượng lịch vệ sinh cần cập nhật trạng thái</param>
        public void UpdateStatus(CleaningScheduleDTO schedule)
        {
            // Câu lệnh UPDATE chỉ cập nhật trường Status
            string sql = @"UPDATE CleaningSchedule
                   SET Status = @Status
                   WHERE CleaningID = @CleaningID";

            // Thực thi cập nhật với tham số
            Db.ExecuteNonQuery(sql,
                new System.Data.SQLite.SQLiteParameter("@Status", schedule.GetStatus()),
                new System.Data.SQLite.SQLiteParameter("@CleaningID", schedule.GetID())
            );
        }

        /// <summary>
        /// Xóa một lịch vệ sinh khỏi cơ sở dữ liệu
        /// </summary>
        /// <param name="schedule">Đối tượng lịch vệ sinh cần xóa</param>
        public void Delete(CleaningScheduleDTO schedule)
        {
            // Câu lệnh DELETE theo CleaningID
            string sqlQuery = "DELETE FROM CleaningSchedule WHERE CleaningID = @CleaningID";

            // Tạo tham số truyền vào truy vấn
            var parameters = new System.Data.SQLite.SQLiteParameter[]
            {
                new System.Data.SQLite.SQLiteParameter("@CleaningID", schedule.GetID()),
            };

            // Thực thi câu lệnh DELETE
            Db.ExecuteNonQuery(sqlQuery, parameters);
        }
    }
}
