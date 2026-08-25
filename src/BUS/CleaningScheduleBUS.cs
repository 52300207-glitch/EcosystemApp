using EcosystemApp.DAL;
using EcosystemApp.DTO;

namespace EcosystemApp.BUS
{
    public class CleaningScheduleBUS
    {
        // Data Access Layer: dùng để thao tác với database (theo kiến trúc 3 lớp)
        private CleaningScheduleDAL CleaningScheduleDAL = new CleaningScheduleDAL();

        /// <summary>
        /// Tạo một lịch vệ sinh mới.
        /// </summary>
        /// <param name="id">Mã định danh lịch vệ sinh.</param>
        /// <param name="date">Ngày vệ sinh.</param>
        /// <param name="startTime">Thời gian bắt đầu.</param>
        /// <param name="endTime">Thời gian kết thúc.</param>
        /// <returns>Đối tượng CleaningScheduleDTO mới tạo.</returns>
        public CleaningScheduleDTO CreateNewSchedule(string id, DateTime date, DateTime startTime, DateTime endTime)
        {
            // Tạo DTO mới với trạng thái mặc định là “NEW”
            return new CleaningScheduleDTO(id, date, "new".ToUpper(), startTime, endTime);
        }

    }
}