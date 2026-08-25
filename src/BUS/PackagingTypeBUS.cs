using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcosystemApp.DTO;
using EcosystemApp.DAL;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến loại bao bì (Packaging Type)
    /// </summary>
    public class PackagingTypeBUS
    {
        // DAL xử lý dữ liệu loại bao bì
        private PackagingTypeDAL PackagingTypeDAL = new PackagingTypeDAL();

        /// <summary>
        /// Lấy danh sách tất cả các loại bao bì
        /// </summary>
        /// <returns>Danh sách PackagingTypeDTO</returns>
        public List<PackagingTypeDTO> GetAllPackagingType()
        {
            return PackagingTypeDAL.GetAllPackagingType();
        }

        /// <summary>
        /// Lấy thông tin loại bao bì theo tên
        /// </summary>
        /// <param name="packagingTypeName">Tên loại bao bì</param>
        /// <returns>Đối tượng PackagingTypeDTO nếu tìm thấy, ngược lại trả về null</returns>
        public PackagingTypeDTO GetByPackagingTypeName(string packagingTypeName)
        {
            return PackagingTypeDAL.GetByPackagingTypeName(packagingTypeName);
        }

        /// <summary>
        /// Thêm mới một loại bao bì
        /// </summary>
        /// <param name="packagingTypeDTO">Đối tượng PackagingTypeDTO cần thêm</param>
        public void Insert(PackagingTypeDTO packagingTypeDTO)
        {
            PackagingTypeDAL.Insert(packagingTypeDTO);
        }
    }
}

