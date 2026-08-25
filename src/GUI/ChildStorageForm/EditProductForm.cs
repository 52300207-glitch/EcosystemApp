using EcosystemApp.BUS;
using EcosystemApp.DTO;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class EditProductForm : Form
    {
        private ProductDTO Product;
        private ProductDTO ChangedProduct;
        private ProductBUS ProductBUS = new ProductBUS();
        private readonly InventoryBUS InventoryBUS = new InventoryBUS();

        public EditProductForm(ProductDTO product)
        {
            InitializeComponent();
            Product = product;
            ChangedProduct = new ProductDTO(Product.GetID(), Product.GetName(), Product.GetUnit(), Product.GetSellingPrice());
            InitializeDefaultValues();
        }

        private void ProductEditFormLoad(object sender, EventArgs e)
        {

        }

        private void InitializeDefaultValues()
        {
            TbProductID.Text = Product.GetID();
            TbProductName.Text = Product.GetName();
            TbUnit.Text = Product.GetUnit();
            TbSellingPrice.Text = Product.GetSellingPrice().ToString();
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            string id = TbProductID.Text.Trim();
            string name = TbProductName.Text.Trim();
            string unit = TbUnit.Text.Trim();
            string sellingPrice = TbSellingPrice.Text.Trim();

            // --- Kiểm tra nhập thiếu ---
            if (string.IsNullOrEmpty(id) ||
                string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(unit) ||
                string.IsNullOrEmpty(sellingPrice))
            {
                RJMessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thiếu thông tin",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Kiểm tra giá hợp lệ ---
            if (!decimal.TryParse(sellingPrice, out decimal price))
            {
                RJMessageBox.Show("Giá bán phải là số hợp lệ!", "Lỗi dữ liệu",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Kiểm tra trùng mã (ngoại trừ bản thân sản phẩm đang sửa) ---
            var p = ProductBUS.GetByID(id);
            // Nếu p khác null và không phải sản phẩm đang sửa → báo lỗi
            if (p != null && p.GetID() != ChangedProduct.GetID())
            {
                RJMessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi trùng mã",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Kiểm tra trùng tên (ngoại trừ bản thân sản phẩm đang sửa) ---
            var pByName = ProductBUS.GetByName(name);
            if (pByName != null && pByName.GetName() != ChangedProduct.GetName())  // Loại trừ sản phẩm đang sửa
            {
                RJMessageBox.Show("Tên sản phẩm đã tồn tại!", "Lỗi trùng tên",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Cập nhật thông tin sản phẩm ---
            if (ChangedProduct != null)
            {
                ChangedProduct.SetID(id);
                ChangedProduct.SetName(name);
                ChangedProduct.SetUnit(unit);
                ChangedProduct.SetPrice(price);

                
                ProductBUS.UpdateProduct(Product,  ChangedProduct);
                InventoryBUS.UpdateProductIdInStock(Product.GetID(), ChangedProduct.GetID());

                RJMessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
