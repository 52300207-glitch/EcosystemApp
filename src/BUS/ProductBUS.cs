using EcosystemApp.DAL;
using EcosystemApp.DTO;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến sản phẩm (Product)
    /// </summary>
    public class ProductBUS
    {
        // DAL xử lý dữ liệu sản phẩm
        private ProductDAL ProductDAL = new ProductDAL();

        public ProductBUS() { }

        /// <summary>
        /// Lấy tất cả sản phẩm
        /// </summary>
        /// <returns>Danh sách ProductDTO</returns>
        public List<ProductDTO> GetAll()
        {
            return ProductDAL.GetAll();
        }

        /// <summary>
        /// Lấy sản phẩm theo tên
        /// </summary>
        /// <param name="name">Tên sản phẩm</param>
        /// <returns>ProductDTO nếu tìm thấy, ngược lại trả về null</returns>
        public ProductDTO GetProductByName(string name)
        {
            return ProductDAL.GetByName(name);
        }

        /// <summary>
        /// Lấy sản phẩm theo ID
        /// </summary>
        /// <param name="productID">ID sản phẩm</param>
        /// <returns>ProductDTO nếu tìm thấy, ngược lại trả về null</returns>
        public ProductDTO GetByID(string productID)
        {
            return ProductDAL.GetByID(productID);
        }

        /// <summary>
        /// Lấy sản phẩm theo tên
        /// </summary>
        /// <param name="productName">Tên sản phẩm</param>
        /// <returns>ProductDTO nếu tìm thấy, ngược lại trả về null</returns>
        public ProductDTO GetByName(string productName)
        {
            return ProductDAL.GetByName(productName);
        }

        /// <summary>
        /// Cập nhật thông tin sản phẩm
        /// </summary>
        /// <param name="oldProduct">Sản phẩm cũ</param>
        /// <param name="newProduct">Sản phẩm mới</param>
        public void UpdateProduct(ProductDTO oldProduct, ProductDTO newProduct)
        {
            ProductDAL.UpdateProduct(oldProduct, newProduct);
        }

        /// <summary>
        /// Kiểm tra và tạo đối tượng sản phẩm mới từ dữ liệu nhập
        /// </summary>
        /// <param name="id">Mã sản phẩm</param>
        /// <param name="name">Tên sản phẩm</param>
        /// <param name="priceText">Giá sản phẩm dạng chuỗi</param>
        /// <param name="unit">Đơn vị tính</param>
        /// <param name="allProducts">Danh sách tất cả sản phẩm hiện có</param>
        /// <returns>ProductDTO mới nếu hợp lệ</returns>
        /// <exception cref="Exception">Ném lỗi nếu dữ liệu không hợp lệ hoặc trùng lặp</exception>
        public ProductDTO ValidateNewProductInput(string id, string name, string priceText, string unit, List<ProductDTO> allProducts)
        {
            var deletedProducts = ProductDAL.GetAllDeletedProduct();

            // Kiểm tra bỏ trống
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(unit))
            {
                throw new Exception("Bạn chưa nhập đầy đủ thông tin!");
            }

            // Kiểm tra giá có phải số hợp lệ
            if (!decimal.TryParse(priceText, out decimal price))
            {
                throw new Exception("Giá bán phải là số hợp lệ!");
            }

            // Kiểm tra trùng mã sản phẩm
            if (allProducts.Any(p => p.GetID().Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Mã sản phẩm đã tồn tại!");
            }

            // Kiểm tra trùng tên sản phẩm
            if (allProducts.Any(p => p.GetName().Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Tên sản phẩm đã tồn tại!");
            }

            // Kiểm tra sản phẩm đã bị xóa trước đó
            var selectedDeletedProducs = deletedProducts.FirstOrDefault(item => item.GetID() == id);

            if (selectedDeletedProducs != null)
            {
                throw new Exception("Tên sản phẩm đã tồn tại!");
            }

            // ---- Tạo sản phẩm mới ----
            return new ProductDTO(id, name, unit, price);
        }

        /// <summary>
        /// Lưu danh sách sản phẩm mới hoặc cập nhật
        /// </summary>
        /// <param name="products">Danh sách ProductDTO cần lưu</param>
        public void SaveProducts(List<ProductDTO> products)
        {
            ProductDAL.SaveProducts(products);
        }

        /// <summary>
        /// Xóa mềm sản phẩm
        /// </summary>
        /// <param name="product">Sản phẩm cần xóa</param>
        public void Delete(ProductDTO product)
        {
            ProductDAL.SoftDeleteProduct(product);
        }
    }
}
