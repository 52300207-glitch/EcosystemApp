using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using EcosystemApp.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến việc vệ sinh kho (Warehouse Cleaning)
    /// </summary>
    public class WarehouseCleaningBUS
    {
        // DAL xử lý dữ liệu vệ sinh kho
        private WarehouseCleaningDAL WarehouseCleaningDAL = new WarehouseCleaningDAL();

        // BUS xử lý lịch vệ sinh
        private CleaningScheduleBUS CleaningSheduleBUS = new CleaningScheduleBUS();

        /// <summary>
        /// Lấy danh sách lịch vệ sinh theo ID kho
        /// </summary>
        /// <param name="id">ID kho</param>
        /// <returns>Danh sách WarehouseCleaningDTO</returns>
        public List<WarehouseCleaningDTO> GetByWarehouseID(string id)
        {
            return WarehouseCleaningDAL.GetByWarehouseID(id);
        }

        /// <summary>
        /// Tạo mới một lịch vệ sinh cho kho
        /// </summary>
        /// <param name="warehouseID">ID kho</param>
        /// <param name="date">Ngày vệ sinh</param>
        /// <param name="startTime">Thời gian bắt đầu</param>
        /// <param name="endTime">Thời gian kết thúc</param>
        /// <returns>WarehouseCleaningDTO mới</returns>
        public WarehouseCleaningDTO CreateNew(string warehouseID, DateTime date, DateTime startTime, DateTime endTime)
        {
            string idCleaningSchedule = Guid.NewGuid().ToString();
            string idWarehouseCleaning = Guid.NewGuid().ToString();
            return new WarehouseCleaningDTO(idWarehouseCleaning, warehouseID, CleaningSheduleBUS.CreateNewSchedule(idCleaningSchedule, date, startTime, endTime));
        }

        /// <summary>
        /// Lưu thông tin lịch vệ sinh kho vào cơ sở dữ liệu
        /// </summary>
        /// <param name="warehouseCleaning">Thông tin lịch vệ sinh kho</param>
        public void Save(WarehouseCleaningDTO warehouseCleaning)
        {
            WarehouseCleaningDAL.Save(warehouseCleaning);
        }

        /// <summary>
        /// Lọc danh sách lịch vệ sinh theo khoảng thời gian
        /// </summary>
        /// <param name="CleaningJobs">Danh sách lịch vệ sinh</param>
        /// <param name="startDate">Ngày bắt đầu</param>
        /// <param name="endDate">Ngày kết thúc</param>
        /// <returns>Danh sách WarehouseCleaningDTO đã lọc</returns>
        public List<WarehouseCleaningDTO> Filter(List<WarehouseCleaningDTO> CleaningJobs, DateTime startDate, DateTime endDate)
        {
            var FilteredCleaningJobs = new List<WarehouseCleaningDTO>();

            foreach (var job in CleaningJobs)
            {
                // So sánh ngày để thêm vào danh sách lọc
                if (job.GetCleaningSchedule().GetDate().Date >= startDate.Date && job.GetCleaningSchedule().GetDate().Date <= endDate.Date)
                {
                    FilteredCleaningJobs.Add(job);
                }
            }
            return FilteredCleaningJobs;
        }

        /// <summary>
        /// Cập nhật thông tin các lịch vệ sinh đã thay đổi
        /// </summary>
        /// <param name="ChangedJobs">Danh sách lịch vệ sinh thay đổi</param>
        public void Update(List<WarehouseCleaningDTO> ChangedJobs)
        {
            foreach (var job in ChangedJobs)
            {
                WarehouseCleaningDAL.Update(job);
            }
        }

        /// <summary>
        /// Xóa một lịch vệ sinh kho
        /// </summary>
        /// <param name="job">Lịch vệ sinh cần xóa</param>
        public void Delete(WarehouseCleaningDTO job)
        {
            WarehouseCleaningDAL.Delete(job);
        }
    }
}
