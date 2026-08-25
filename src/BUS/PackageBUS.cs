using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến Bao bì (Package)
    /// </summary>
    public class PackageBUS
    {
        // DAL xử lý dữ liệu bao bì
        private PackageDAL PackageDAL = new PackageDAL();

        // BUS xử lý dữ liệu loại bao bì
        private PackagingTypeBUS PackagingTypeBUS = new PackagingTypeBUS();

        public PackageBUS() { }

        /// <summary>
        /// Lấy thông tin bao bì theo ID
        /// </summary>
        /// <param name="id">ID của bao bì</param>
        /// <returns>PackageDTO tương ứng</returns>
        public DTO.PackageDTO GetByID(string id)
        {
            return PackageDAL.GetByID(id);
        }

        /// <summary>
        /// Lấy danh sách tất cả các bao bì
        /// </summary>
        /// <returns>Danh sách PackageDTO</returns>
        public List<PackageDTO> GetAll()
        {
            return PackageDAL.GetAll();
        }

        /// <summary>
        /// Lấy danh sách bao bì theo loại
        /// </summary>
        /// <param name="packageTypeID">ID loại bao bì</param>
        /// <returns>Danh sách PackageDTO</returns>
        public List<PackageDTO> GetByPackageTypeID(string packageTypeID)
        {
            return PackageDAL.GetByPackageTypeID(packageTypeID);
        }

        /// <summary>
        /// Tạo mới bao bì và thêm vào danh sách hiện có
        /// </summary>
        /// <param name="packages">Danh sách bao bì hiện có</param>
        /// <param name="packageTypeName">Tên loại bao bì</param>
        /// <param name="material">Chất liệu bao bì</param>
        /// <param name="reuseLimit">Giới hạn tái sử dụng</param>
        /// <param name="sellingPrice">Giá bán (deposit)</param>
        /// <param name="serialCode">Mã serial của bao bì</param>
        /// <returns>Danh sách bao bì sau khi thêm</returns>
        public List<PackageDTO> CreateNew(List<PackageDTO> packages, string packageTypeName, string material, string reuseLimit, string sellingPrice, string serialCode)
        {
            if (packages == null || packages.Count == 0)
            {
                packages = new List<PackageDTO>();
            }

            // Kiểm tra bao bì đã có trong danh sách thêm chưa
            bool isExisted = packages.Where(p => p.GetSerialCode() == serialCode).Any();
            if (isExisted)
            {
                throw new Exception("Bao bì đã có trong danh sách thêm bao bì!");
            }

            // Kiểm tra bao bì đã có trong CSDL chưa
            if (isExist(serialCode))
            {
                throw new Exception("Bao bì đã có sẵn trong dữ liệu!");
            }

            // Lấy hoặc tạo mới loại bao bì
            var packageType = PackagingTypeBUS.GetByPackagingTypeName(packageTypeName);
            if (packageType == null)
            {
                packageType = new PackagingTypeDTO(null, packageTypeName, material, int.Parse(reuseLimit), int.Parse(sellingPrice));
            }

            // Tạo đối tượng bao bì mới
            var package = new PackageDTO(null, packageType, "Available", "0", serialCode);
            packages.Add(package);

            return packages;
        }

        /// <summary>
        /// Lưu danh sách bao bì mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="packages">Danh sách bao bì cần lưu</param>
        public void SaveNewPackages(List<PackageDTO> packages)
        {
            PackageDAL.SaveNewPackages(packages);
        }

        /// <summary>
        /// Copy đối tượng bao bì, tạo bản sao độc lập
        /// </summary>
        /// <param name="package">Bao bì cần copy</param>
        /// <returns>Bản sao của PackageDTO</returns>
        public PackageDTO Copy(PackageDTO package)
        {
            var packageType = new PackagingTypeDTO(package.GetPackagingType().GetID(), package.GetPackagingType().GetTypeName(), package.GetPackagingType().GetMaterial(),
                package.GetPackagingType().GetReuseLimit(), package.GetPackagingType().GetDeposit());
            return new PackageDTO(package.GetID(), packageType, package.GetStatus(), package.GetReuseCount().ToString(), package.GetSerialCode());
        }

        /// <summary>
        /// Cập nhật thông tin bao bì
        /// </summary>
        /// <param name="oldPackage">Bao bì cũ</param>
        /// <param name="newPackage">Bao bì mới</param>
        public void UpdatePackage(PackageDTO oldPackage, PackageDTO newPackage)
        {
            // Nếu đổi tên loại bao bì, kiểm tra loại mới đã có trong CSDL chưa
            if (oldPackage.GetPackagingType().GetTypeName() != newPackage.GetPackagingType().GetTypeName())
            {
                var packageType = PackagingTypeBUS.GetByPackagingTypeName(newPackage.GetPackagingType().GetTypeName());
                if (packageType == null)
                {
                    newPackage.GetPackagingType().SetID(null);
                    PackagingTypeBUS.Insert(newPackage.GetPackagingType());
                }
            }
            PackageDAL.Update(newPackage, oldPackage.GetSerialCode());
        }

        /// <summary>
        /// Cập nhật tất cả bao bì cùng loại
        /// </summary>
        /// <param name="oldPackage">Bao bì cũ</param>
        /// <param name="newPackage">Bao bì mới</param>
        public void UpdatePackagesSameType(PackageDTO oldPackage, PackageDTO newPackage)
        {
            PackageDAL.UpdatePackagesSameType(oldPackage, newPackage);
        }

        /// <summary>
        /// Kiểm tra bao bì đã tồn tại trong cơ sở dữ liệu chưa
        /// </summary>
        /// <param name="serialCode">Mã serial của bao bì</param>
        /// <returns>True nếu đã tồn tại, False nếu chưa tồn tại</returns>
        public bool isExist(string serialCode)
        {
            return PackageDAL.GetBySerialCode(serialCode) != null;
        }

        /// <summary>
        /// Cập nhật trạng thái bao bì
        /// </summary>
        /// <param name="package">Bao bì cần cập nhật</param>
        public void UpdateStatus(PackageDTO package)
        {
            PackageDAL.Update(package);
        }
    }
}
