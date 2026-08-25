using DocumentFormat.OpenXml.Office2010.Excel;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu PackagingType, bao gồm CRUD và tạo ID tự động.
    /// </summary>
    public class PackagingTypeDAL
    {
        private DatabaseHelper Db = new DatabaseHelper();

        public PackagingTypeDAL() { }

        /// <summary>
        /// Lấy PackagingType theo ID.
        /// </summary>
        /// <param name="id">ID của PackagingType.</param>
        /// <returns>Đối tượng PackagingTypeDTO nếu tồn tại, ngược lại null.</returns>
        public PackagingTypeDTO GetByID(string id)
        {
            string sqlQuery = "SELECT * FROM PackagingType WHERE PackagingTypeID = @PackagingTypeID ";

            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@PackagingTypeID", id)
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                var temp = new PackagingTypeDTO(
                    row["PackagingTypeID"].ToString(),
                    row["TypeName"].ToString(),
                    row["Material"].ToString(),
                    Convert.ToInt32(row["ReuseLimit"]),
                    Convert.ToDecimal(row["Deposit"])
                );
                return temp;
            }
            return null;
        }

        /// <summary>
        /// Lấy tất cả PackagingType.
        /// </summary>
        /// <returns>Danh sách tất cả PackagingTypeDTO.</returns>
        public List<PackagingTypeDTO> GetAllPackagingType()
        {
            List<PackagingTypeDTO> list = new List<PackagingTypeDTO>();

            string sqlQuery = "SELECT * FROM PackagingType";

            var dt = Db.ExecuteQuery(sqlQuery);

            foreach (DataRow row in dt.Rows)
            {
                var temp = new PackagingTypeDTO(
                    row["PackagingTypeID"].ToString(),
                    row["TypeName"].ToString(),
                    row["Material"].ToString(),
                    Convert.ToInt32(row["ReuseLimit"]),
                    Convert.ToDecimal(row["Deposit"])
                );
                list.Add(temp);
            }

            return list;
        }

        /// <summary>
        /// Thêm mới PackagingType vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="dto">Đối tượng PackagingTypeDTO cần thêm.</param>
        public void Insert(PackagingTypeDTO dto)
        {
            if (string.IsNullOrEmpty(dto.GetID()))
                dto.SetID(GenerateNextPackagingTypeID());

            string sqlQuery = "INSERT INTO PackagingType (PackagingTypeID, TypeName, Material, ReuseLimit, Deposit) " +
                              "VALUES (@PackagingTypeID, @TypeName, @Material, @ReuseLimit, @Deposit)";

            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@PackagingTypeID", dto.GetID()),
                new SQLiteParameter("@TypeName", dto.GetTypeName()),
                new SQLiteParameter("@Material", dto.GetMaterial()),
                new SQLiteParameter("@ReuseLimit", dto.GetReuseLimit()),
                new SQLiteParameter("@Deposit", dto.GetDeposit())
            );
        }

        /// <summary>
        /// Tạo ID mới cho PackagingType theo định dạng PKT001, PKT002,...
        /// </summary>
        /// <returns>ID mới.</returns>
        public string GenerateNextPackagingTypeID()
        {
            string sqlQuery = "SELECT COUNT(*) AS Total FROM PackagingType";
            var dt = Db.ExecuteQuery(sqlQuery);

            int count = 0;
            if (dt.Rows.Count > 0)
            {
                count = Convert.ToInt32(dt.Rows[0]["Total"]);
            }

            int nextNumber = count + 1;

            return "PKT" + nextNumber.ToString("D3");
        }

        /// <summary>
        /// Lấy PackagingType theo tên.
        /// </summary>
        /// <param name="packagingTypeName">Tên của PackagingType.</param>
        /// <returns>Đối tượng PackagingTypeDTO nếu tồn tại, ngược lại null.</returns>
        public PackagingTypeDTO GetByPackagingTypeName(string packagingTypeName)
        {
            string sqlQuery = "SELECT * FROM PackagingType WHERE TypeName = @TypeName ";

            var result = Db.ExecuteQuery(sqlQuery,
                new SQLiteParameter("@TypeName", packagingTypeName)
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                var temp = new PackagingTypeDTO(
                    row["PackagingTypeID"].ToString(),
                    row["TypeName"].ToString(),
                    row["Material"].ToString(),
                    Convert.ToInt32(row["ReuseLimit"]),
                    Convert.ToDecimal(row["Deposit"])
                );
                return temp;
            }
            return null;
        }

        /// <summary>
        /// Thêm mới PackagingType.
        /// </summary>
        /// <param name="packagingType">Đối tượng PackagingTypeDTO.</param>
        public void CreateNew(PackagingTypeDTO packagingType)
        {
            Insert(packagingType);
        }

        /// <summary>
        /// Cập nhật PackagingType cũ bằng thông tin PackagingType mới.
        /// </summary>
        /// <param name="newPackageType">Thông tin mới.</param>
        /// <param name="oldPackageType">PackageType cũ.</param>
        public void Update(PackagingTypeDTO newPackageType, PackagingTypeDTO oldPackageType)
        {
            string sqlQuery = "UPDATE PackagingType SET TypeName = @TypeName, Material = @Material," +
                " ReuseLimit = @ReuseLimit, Deposit = @Deposit WHERE PackagingTypeID = @OldID";

            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@TypeName", newPackageType.GetTypeName()),
                new SQLiteParameter("@Material", newPackageType.GetMaterial()),
                new SQLiteParameter("@ReuseLimit", newPackageType.GetReuseLimit()),
                new SQLiteParameter("@Deposit", newPackageType.GetDeposit()),
                new SQLiteParameter("@OldID", oldPackageType.GetID())
            );
        }
    }
}
