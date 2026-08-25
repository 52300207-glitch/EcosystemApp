using EcosystemApp.DTO;
using EcosystemApp.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu PackagingCleaning, bao gồm CRUD các lịch trình vệ sinh gói hàng.
    /// </summary>
    public class PackagingCleaningDAL
    {
        
        private DatabaseHelper Db = new DatabaseHelper();
        private CleaningScheduleDAL CleaningScheduleDAL = new CleaningScheduleDAL();
        private PackageDAL PackageDAL = new PackageDAL();

        /// <summary>
        /// Lấy tất cả dữ liệu PackagingCleaning từ cơ sở dữ liệu.
        /// </summary>
        /// <returns>Danh sách PackagingCleaningDTO.</returns>
        public List<PackagingCleaningDTO> GetAll()
        {
            var packageCleanings = new List<PackagingCleaningDTO>();
            string sqlQuery = "SELECT * FROM PackagingCleaning";
            var result = Db.ExecuteQuery(sqlQuery);
            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    var package = PackageDAL.GetByID(row["PackagingID"].ToString());
                    var cleaningSchedule = CleaningScheduleDAL.GetById(row["CleaningID"].ToString());
                    var packagingCleaning = new PackagingCleaningDTO(row["PackagingCleaningID"].ToString(), package, cleaningSchedule);
                    packageCleanings.Add(packagingCleaning);
                }
            }
            return packageCleanings;
        }

        /// <summary>
        /// Lưu danh sách PackagingCleaning và lịch trình vệ sinh liên quan vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="packageCleanings">Danh sách PackagingCleaningDTO cần lưu.</param>
        public void SavePackageSchedules(List<PackagingCleaningDTO> packageCleanings)
        {
            foreach (var job in packageCleanings)
            {
                CleaningScheduleDAL.Save(job.GetCleaningSchedule());
                string insertQuery = @"INSERT INTO PackagingCleaning 
                                       (PackagingCleaningID, PackagingID, CleaningID)
                                       VALUES (@PackagingCleaningID, @PackagingID, @CleaningID)";

                Db.ExecuteNonQuery(insertQuery,
                    new System.Data.SQLite.SQLiteParameter("@PackagingCleaningID", job.GetID()),
                    new System.Data.SQLite.SQLiteParameter("@PackagingID", int.Parse(job.GetPackage().GetID())),
                    new System.Data.SQLite.SQLiteParameter("@CleaningID", job.GetCleaningSchedule().GetID())
                );
            }
        }

        /// <summary>
        /// Xóa một PackagingCleaning và lịch trình vệ sinh liên quan.
        /// </summary>
        /// <param name="job">PackagingCleaningDTO cần xóa.</param>
        public void Delete(PackagingCleaningDTO job)
        {
            // Xóa luôn CleaningSchedule
            CleaningScheduleDAL.Delete(job.GetCleaningSchedule());

            // Xóa dữ liệu trong bảng PackagingCleaning
            string deletePackagingCleaningQuery = @"DELETE FROM PackagingCleaning WHERE PackagingCleaningID = @PackagingCleaningID";

            Db.ExecuteNonQuery(deletePackagingCleaningQuery,
                new System.Data.SQLite.SQLiteParameter("@PackagingCleaningID", job.GetID())
            );
        }
    }
}
