using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu Product, bao gồm CRUD và kiểm tra tồn tại.
    /// </summary>
    public class ProductDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();

        public ProductDAL() { }

        /// <summary>
        /// Lấy Product theo ID.
        /// </summary>
        /// <param name="id">ID của sản phẩm.</param>
        /// <returns>Đối tượng ProductDTO nếu tồn tại, ngược lại null.</returns>
        public ProductDTO GetByID(string id)
        {
            var result = Db.ExecuteQuery("SELECT * FROM Product WHERE ProductID = @ProductID",
                new SQLiteParameter("@ProductID", id)
            );
            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new ProductDTO(
                    row["ProductID"].ToString(),
                    row["ProductName"].ToString(),
                    row["Category"].ToString(),
                    row["Unit"].ToString(),
                    Convert.ToDecimal(row["SellingPrice"])
                );
            }
            return null;
        }

        /// <summary>
        /// Lấy Product theo tên.
        /// </summary>
        /// <param name="name">Tên sản phẩm.</param>
        /// <returns>Đối tượng ProductDTO nếu tồn tại, ngược lại null.</returns>
        public ProductDTO GetByName(string name)
        {
            var result = Db.ExecuteQuery("SELECT * FROM Product WHERE ProductName = @ProductName",
                new SQLiteParameter("@ProductName", name)
            );
            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new ProductDTO(
                    row["ProductID"].ToString(),
                    row["ProductName"].ToString(),
                    row["Category"].ToString(),
                    row["Unit"].ToString(),
                    Convert.ToDecimal(row["SellingPrice"])
                );
            }
            return null;
        }

        /// <summary>
        /// Kiểm tra xem sản phẩm đã tồn tại trong cơ sở dữ liệu hay chưa.
        /// </summary>
        /// <param name="product">Sản phẩm cần kiểm tra.</param>
        /// <returns>True nếu tồn tại, ngược lại false.</returns>
        public bool IsExsisted(ProductDTO product)
        {
            var isExisted = Db.ExecuteQuery("SELECT * FROM Product WHERE ProductName = @ProductName",
                new SQLiteParameter("@ProductName", product.GetName())
            );
            return isExisted.Rows.Count > 0;
        }

        /// <summary>
        /// Lấy tất cả sản phẩm chưa bị xóa mềm.
        /// </summary>
        /// <returns>Danh sách ProductDTO.</returns>
        public List<ProductDTO> GetAll()
        {
            var result = Db.ExecuteQuery("SELECT * FROM Product WHERE isDelete = 0");
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (System.Data.DataRow row in result.Rows)
            {
                products.Add(new ProductDTO(
                    row["ProductID"].ToString(),
                    row["ProductName"].ToString(),
                    row["Category"].ToString(),
                    row["Unit"].ToString(),
                    Convert.ToDecimal(row["SellingPrice"])
                ));
            }
            return products;
        }

        /// <summary>
        /// Thêm mới sản phẩm vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="product">Đối tượng ProductDTO cần thêm.</param>
        /// <returns>Luôn trả về null.</returns>
        public string Insert(ProductDTO product)
        {
            string query = @"INSERT INTO Product (ProductID, ProductName, Category, Unit, SellingPrice, IsDelete)
                    VALUES (@ProductID, @ProductName, @Category, @Unit, @SellingPrice, 0)";

            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@ProductID", product.GetID()),
                new SQLiteParameter("@ProductName", product.GetName()),
                new SQLiteParameter("@Category", product.GetCategory()),
                new SQLiteParameter("@Unit", product.GetUnit()),
                new SQLiteParameter("@SellingPrice", product.GetSellingPrice())
            );
            return null;
        }

        /// <summary>
        /// Lấy tất cả sản phẩm đã bị xóa mềm.
        /// </summary>
        /// <returns>Danh sách ProductDTO đã xóa mềm.</returns>
        public List<ProductDTO> GetAllDeletedProduct()
        {
            var result = Db.ExecuteQuery("SELECT * FROM Product WHERE isDelete = 1");

            List<ProductDTO> products = new List<ProductDTO>();

            foreach (System.Data.DataRow row in result.Rows)
            {
                products.Add(new ProductDTO(
                    row["ProductID"].ToString(),
                    row["ProductName"].ToString(),
                    row["Category"].ToString(),
                    row["Unit"].ToString(),
                    Convert.ToDecimal(row["SellingPrice"])
                ));
            }

            return products;
        }

        /// <summary>
        /// Xóa mềm sản phẩm (cập nhật cột isDelete = 1).
        /// </summary>
        /// <param name="product">Sản phẩm cần xóa mềm.</param>
        public void SoftDeleteProduct(ProductDTO product)
        {
            string query = @"
                UPDATE Product
                SET isDelete = 1
                WHERE ProductID = @ProductID
            ";

            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@ProductID", product.GetID())
            );
        }

        /// <summary>
        /// Lưu nhiều sản phẩm mới vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="products">Danh sách ProductDTO cần lưu.</param>
        public void SaveProducts(List<ProductDTO> products)
        {
            foreach (ProductDTO product in products)
            {
                Insert(product);
            }
        }

        /// <summary>
        /// Cập nhật thông tin sản phẩm cũ bằng sản phẩm mới.
        /// </summary>
        /// <param name="oldProduct">Sản phẩm cũ.</param>
        /// <param name="newProduct">Sản phẩm mới.</param>
        public void UpdateProduct(ProductDTO oldProduct, ProductDTO newProduct)
        {
            string query = @"UPDATE Product SET ProductID = @NewProductID, ProductName = @ProductName,
                Category = @Category, Unit = @Unit, SellingPrice = @SellingPrice
                WHERE ProductID = @OldProductID";

            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@NewProductID", newProduct.GetID()),
                new SQLiteParameter("@ProductName", newProduct.GetName()),
                new SQLiteParameter("@Category", newProduct.GetCategory()),
                new SQLiteParameter("@Unit", newProduct.GetUnit()),
                new SQLiteParameter("@SellingPrice", newProduct.GetSellingPrice()),
                new SQLiteParameter("@OldProductID", oldProduct.GetID())
            );
        }
    }
}
