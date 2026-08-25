using EcosystemApp.DTO;
using EcosystemApp.DAL;


namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến vệ sinh bao bì (Packaging Cleaning)
    /// </summary>
    public class PackagingCleaningBUS
    {
        // DAL xử lý dữ liệu vệ sinh bao bì
        private PackagingCleaningDAL PackagingCleaningDAL = new PackagingCleaningDAL();

        // BUS xử lý dữ liệu bao bì
        private PackageBUS PackageBUS = new PackageBUS();

        // DAL xử lý dữ liệu lịch vệ sinh
        private CleaningScheduleDAL CleaningScheduleDAL = new CleaningScheduleDAL();

        /// <summary>
        /// Lấy danh sách tất cả công việc vệ sinh bao bì
        /// </summary>
        /// <returns>Danh sách PackagingCleaningDTO</returns>
        public List<PackagingCleaningDTO> GetAll()
        {
            return PackagingCleaningDAL.GetAll();
        }

        /// <summary>
        /// Lưu lịch vệ sinh cho các bao bì trong kho theo loại bao bì
        /// </summary>
        /// <param name="packageTypeID">ID loại bao bì</param>
        /// <param name="inventories">Danh sách tồn kho</param>
        /// <param name="date">Ngày vệ sinh</param>
        /// <param name="timeStart">Giờ bắt đầu</param>
        /// <param name="timeEnd">Giờ kết thúc</param>
        public void SavePackageSchedules(string packageTypeID, List<InventoryDTO> inventories, DateTime date, DateTime timeStart, DateTime timeEnd)
        {
            // Lấy danh sách bao bì thuộc loại packageTypeID trong tồn kho
            var items = inventories.Where(item => item.GetPackage() == null ? false :
                item.GetPackage().GetPackagingType().GetID() == packageTypeID).Select(item => item.GetPackage()).ToList();

            var newCleanJobs = new List<PackagingCleaningDTO>();

            // Tạo mới các công việc vệ sinh cho từng bao bì
            foreach (var item in items)
            {
                if(item.GetStatus() == "Cleaning")
                {
                    var job = new CleaningScheduleDTO(Guid.NewGuid().ToString(), date, "NEW", timeStart, timeEnd);
                    newCleanJobs.Add(new PackagingCleaningDTO(Guid.NewGuid().ToString(), item, job));
                }
            }

            // Lưu danh sách công việc vào cơ sở dữ liệu
            PackagingCleaningDAL.SavePackageSchedules(newCleanJobs);
        }

        /// <summary>
        /// Lọc danh sách công việc vệ sinh theo loại bao bì và khoảng thời gian
        /// </summary>
        /// <param name="allJobs">Danh sách tất cả công việc</param>
        /// <param name="packageNameTypeID">ID loại bao bì cần lọc</param>
        /// <param name="inventories">Danh sách tồn kho</param>
        /// <param name="dateStart">Ngày bắt đầu</param>
        /// <param name="dateEnd">Ngày kết thúc</param>
        /// <returns>Danh sách PackagingCleaningDTO thỏa điều kiện</returns>
        public List<PackagingCleaningDTO> GetByPackageNameTypeInInventory(List<PackagingCleaningDTO> allJobs, string packageNameTypeID, List<InventoryDTO> inventories,
            DateTime dateStart, DateTime dateEnd)
        {
            var filtered = new List<PackagingCleaningDTO>();

            // Duyệt từng công việc
            foreach (var job in allJobs)
            {
                var pkg = job.GetPackage();

                // Kiểm tra bao bì có trong tồn kho hay không
                if (!inventories.Any(item => item.GetPackage() == null ? false : item.GetPackage().GetID() == pkg.GetID()))
                    continue;

                var schedule = job.GetCleaningSchedule();

                if (pkg == null || schedule == null) continue;

                // Lấy ID loại bao bì
                string typeName = pkg.GetPackagingType()?.GetID() ?? "";

                // Kiểm tra loại bao bì khớp
                if (!typeName.Equals(packageNameTypeID))
                    continue;

                // Lấy ngày vệ sinh (bỏ giờ)
                DateTime jobDate = schedule.GetDate().Date;

                // Kiểm tra ngày trong khoảng lọc
                if (jobDate >= dateStart.Date && jobDate <= dateEnd.Date)
                {
                    filtered.Add(job);
                }
            }

            return filtered;
        }

        /// <summary>
        /// Xóa một công việc vệ sinh bao bì
        /// </summary>
        /// <param name="job">Công việc cần xóa</param>
        public void Delete(PackagingCleaningDTO job)
        {
            PackagingCleaningDAL.Delete(job);
        }

        /// <summary>
        /// Cập nhật trạng thái công việc vệ sinh và trạng thái bao bì tương ứng
        /// </summary>
        /// <param name="jobs">Danh sách công việc cần cập nhật</param>
        public void Update(List<PackagingCleaningDTO> jobs)
        {
            foreach (var job in jobs)
            {
                // Cập nhật trạng thái công việc trong lịch vệ sinh
                CleaningScheduleDAL.UpdateStatus(job.GetCleaningSchedule());

                // Cập nhật trạng thái bao bì là Available sau khi vệ sinh xong
                var package = job.GetPackage();
                package.SetStatus("Available");
                PackageBUS.UpdateStatus(package);
            }
        }
    }
}
