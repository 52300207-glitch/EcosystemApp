using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu Package, bao gồm thao tác CRUD và truy xuất theo loại hoặc mã SerialCode.
    /// </summary>
    public class PackageDAL
    {
        /// <summary>
        /// Đối tượng DatabaseHelper để thao tác với cơ sở dữ liệu.
        /// </summary>
        private readonly DatabaseHelper Db = new DatabaseHelper();

        /// <summary>
        /// Đối tượng PackagingTypeDAL để thao tác dữ liệu PackagingType.
        /// </summary>
        private readonly PackagingTypeDAL PackageTypeDAL = new PackagingTypeDAL();

        /// <summary>
        /// Constructor mặc định.
        /// </summary>
        public PackageDAL() { }

        /// <summary>
        /// Lấy thông tin Package theo PackageID.
        /// </summary>
        /// <param name="packageID">ID của Package.</param>
        /// <returns>Đối tượng PackageDTO nếu tồn tại, ngược lại trả về null.</returns>
        public PackageDTO GetByID(string packageID)
        {
            string sqlQuery = "SELECT * FROM Package WHERE PackageID = @PackageID";
            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@PackageID", packageID)
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                var temp = new PackageDTO(
                    row["PackageID"].ToString(),
                    PackageTypeDAL.GetByID(row["PackagingTypeID"].ToString()),
                    row["Status"].ToString(),
                    row["ReuseCount"].ToString(),
                    row["SerialCode"].ToString()
                );
                return temp;
            }
            return null;
        }

        /// <summary>
        /// Cập nhật thông tin Package.
        /// </summary>
        /// <param name="package">Đối tượng PackageDTO cần cập nhật.</param>
        public void Update(PackageDTO package)
        {
            string sqlQuery = "UPDATE Package SET Status = @Status, " +
                "ReuseCount = @ReuseCount WHERE PackageID = @PackageID";
            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@Status", package.GetStatus()),
                new SQLiteParameter("@ReuseCount", package.GetReuseCount()),
                new SQLiteParameter("@PackageID", package.GetID())
            );
        }

        /// <summary>
        /// Thêm mới Package nếu chưa tồn tại, hoặc trả về PackageID nếu SerialCode đã tồn tại.
        /// </summary>
        /// <param name="package">Đối tượng PackageDTO cần thêm.</param>
        /// <returns>PackageID mới hoặc PackageID đã tồn tại.</returns>
        public string Insert(PackageDTO package)
        {
            string sqlQuery = "SELECT * FROM Package WHERE SerialCode = @SerialCode";
            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@SerialCode", package.GetSerialCode())
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return row["PackageID"].ToString();
            }
            else
            {
                sqlQuery = "SELECT COUNT(*) AS Total FROM Package";
                var countResult = Db.ExecuteQuery(sqlQuery);
                int id = Convert.ToInt32(countResult.Rows[0]["Total"]) + 1;

                if (package.GetPackagingType().GetID() == null)
                {
                    PackageTypeDAL.Insert(package.GetPackagingType());
                }

                sqlQuery = "INSERT INTO Package (PackageID, PackagingTypeID, SerialCode, Status, ReuseCount) " +
                      "VALUES (@PackageID, @PackagingTypeID, @SerialCode, @Status, @ReuseCount)";

                Db.ExecuteNonQuery(sqlQuery,
                    new SQLiteParameter("@PackageID", package.GetID()),
                    new SQLiteParameter("@PackagingTypeID", package.GetPackagingType().GetID()),
                    new SQLiteParameter("@SerialCode", package.GetSerialCode()),
                    new SQLiteParameter("@Status", package.GetStatus()),
                    new SQLiteParameter("@ReuseCount", package.GetReuseCount())
                );

                return id.ToString();
            }
        }

        /// <summary>
        /// Cập nhật thông tin Package dựa theo SerialCode cũ.
        /// </summary>
        /// <param name="newPackage">Đối tượng PackageDTO mới.</param>
        /// <param name="oldSerialCode">SerialCode cũ của Package cần cập nhật.</param>
        public void Update(PackageDTO newPackage, string oldSerialCode)
        {
            string sqlQuery = "SELECT * FROM Package WHERE SerialCode = @OldSerialCode";
            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@OldSerialCode", oldSerialCode)
            );

            if (result.Rows.Count > 0)
            {
                PackagingTypeDTO packageType = PackageTypeDAL.GetByPackagingTypeName(newPackage.GetPackagingType().GetTypeName());
                sqlQuery = @"UPDATE Package SET PackagingTypeID = @PackagingTypeID, SerialCode = @SerialCode, Status = @Status,
                             ReuseCount = @ReuseCount WHERE SerialCode = @OldSerialCode";

                Db.ExecuteNonQuery(sqlQuery,
                    new SQLiteParameter("@PackagingTypeID", packageType.GetID()),
                    new SQLiteParameter("@SerialCode", newPackage.GetSerialCode()),
                    new SQLiteParameter("@Status", newPackage.GetStatus()),
                    new SQLiteParameter("@ReuseCount", newPackage.GetReuseCount()),
                    new SQLiteParameter("@OldSerialCode", oldSerialCode)
                );
            }
        }

        /// <summary>
        /// Lấy danh sách Package theo PackagingTypeID.
        /// </summary>
        /// <param name="packageTypeID">ID của PackagingType.</param>
        /// <returns>Danh sách PackageDTO.</returns>
        public List<PackageDTO> GetByPackageTypeID(string packageTypeID)
        {
            string sqlQuery = "SELECT * FROM Package WHERE PackagingTypeID = @PackagingTypeID";
            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@PackagingTypeID", packageTypeID)
            );

            List<PackageDTO> packages = new List<PackageDTO>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var temp = new PackageDTO(
                    row["PackageID"].ToString(),
                    PackageTypeDAL.GetByID(row["PackagingTypeID"].ToString()),
                    row["Status"].ToString(),
                    row["ReuseCount"].ToString(),
                    row["SerialCode"].ToString()
                );
                packages.Add(temp);
            }

            return packages;
        }

        /// <summary>
        /// Lấy tất cả Package.
        /// </summary>
        /// <returns>Danh sách tất cả PackageDTO.</returns>
        public List<PackageDTO> GetAll()
        {
            string sqlQuery = "SELECT * FROM Package";
            var result = Db.ExecuteQuery(sqlQuery);

            List<PackageDTO> packages = new List<PackageDTO>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                var packageType = PackageTypeDAL.GetByID(row["PackagingTypeID"].ToString());

                var package = new PackageDTO(
                    row["PackageID"].ToString(),
                    packageType,
                    row["Status"].ToString(),
                    row["ReuseCount"].ToString(),
                    row["SerialCode"].ToString()
                );

                packages.Add(package);
            }

            return packages;
        }

        /// <summary>
        /// Lấy Package theo SerialCode.
        /// </summary>
        /// <param name="serialCode">SerialCode của Package.</param>
        /// <returns>PackageDTO nếu tồn tại, ngược lại null.</returns>
        public PackageDTO GetBySerialCode(string serialCode)
        {
            string sqlQuery = "SELECT * FROM Package WHERE SerialCode = @SerialCode";
            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@SerialCode", serialCode)
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                var temp = new PackageDTO(
                    row["PackageID"].ToString(),
                    PackageTypeDAL.GetByID(row["PackagingTypeID"].ToString()),
                    row["Status"].ToString(),
                    row["ReuseCount"].ToString(),
                    row["SerialCode"].ToString()
                );
                return temp;
            }
            return null;
        }

        /// <summary>
        /// Lưu danh sách Package mới.
        /// </summary>
        /// <param name="packages">Danh sách PackageDTO cần lưu.</param>
        public void SaveNewPackages(List<PackageDTO> packages)
        {
            foreach (var package in packages)
            {
                if (package.GetPackagingType().GetID() == null)
                {
                    PackageTypeDAL.CreateNew(package.GetPackagingType());
                }

                Insert(package);
            }
        }

        /// <summary>
        /// Cập nhật nhiều Package cùng loại.
        /// </summary>
        /// <param name="oldPackage">Package cũ.</param>
        /// <param name="newPackage">Package mới.</param>
        public void UpdatePackagesSameType(PackageDTO oldPackage, PackageDTO newPackage)
        {
            PackageTypeDAL.Update(newPackage.GetPackagingType(), oldPackage.GetPackagingType());
            string sqlQuery = "UPDATE Package SET Status = @Status," +
                              "SerialCode = @SerialCode, ReuseCount = @ReuseCount WHERE PackageID = @PackageID";
            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@Status", newPackage.GetStatus()),
                new SQLiteParameter("@SerialCode", newPackage.GetSerialCode()),
                new SQLiteParameter("@ReuseCount", newPackage.GetReuseCount()),
                new SQLiteParameter("@PackageID", oldPackage.GetID())
            );
        }
    }
}
