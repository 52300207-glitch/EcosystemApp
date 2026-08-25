using EcosystemApp.BUS;
using EcosystemApp.DTO;
namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class NewProductForm : Form
    {
        private List<ProductDTO> AllProducts;
        private ProductBUS ProductBUS = new ProductBUS();
        private List<ProductDTO> ExtraProducts = new List<ProductDTO>();

        public NewProductForm()
        {
            InitializeComponent();
            AllProducts = ProductBUS.GetAll();
            InitializeDefautValues();
        }

        private void InitializeDefautValues()
        {
            TbNewProductID.Text = "";
            TbNewProductName.Text = "";
            TbSellingPrice.Text = "";
            TbUnit.Text = "";

            BtnDeleteProduct.Enabled = false;
            BtnSave.Enabled = false;
            BtnRefesh.Enabled = true;
            BtnAddNewProduct.Enabled = true;
            BtnCancel.Enabled = true;
            SetupDgvNewProductList();
        }

        private void SetupDgvNewProductList()
        {
            var dgv = DgvNewProductList;

            // Không cho user tự thêm/xóa hàng, cột
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;

            // Không cho AutoFill toàn bảng
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgv.Columns.Clear();

            // Tạo cột
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "STT", HeaderText = "STT", SortMode = DataGridViewColumnSortMode.NotSortable });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ProductID", HeaderText = "Mã sản phẩm", DataPropertyName = "ID", SortMode = DataGridViewColumnSortMode.NotSortable });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ProductName", HeaderText = "Tên sản phẩm", DataPropertyName = "Name", SortMode = DataGridViewColumnSortMode.NotSortable });
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Giá bán",
                DataPropertyName = "Price",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0"
                }
            });
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Unit",
                HeaderText = "Đơn vị",
                DataPropertyName = "Unit",
                SortMode = DataGridViewColumnSortMode.NotSortable,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Tính và set lại độ rộng theo DataGridView
            ResizeColumnsToFit();

            // Xử lý STT
            dgv.RowPostPaint += (s, e) =>
            {
                dgv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            };

            // Khi resize form → column tự fit lại
            dgv.SizeChanged += (s, e) => ResizeColumnsToFit();
        }

        private void ResizeColumnsToFit()
        {
            var dgv = DgvNewProductList;

            // Trừ border + scrollbar
            int totalWidth = dgv.Width - 3;

            // Tỷ lệ: STT (8%), Mã (18%), Tên (42%), Giá (18%), Đơn vị (14%)
            dgv.Columns["STT"].Width = (int)(totalWidth * 0.08);
            dgv.Columns["ProductID"].Width = (int)(totalWidth * 0.18);
            dgv.Columns["ProductName"].Width = (int)(totalWidth * 0.42);
            dgv.Columns["Price"].Width = (int)(totalWidth * 0.18);
            dgv.Columns["Unit"].Width = (int)(totalWidth * 0.14);
        }

        private void BtnAddNewProductClick(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ TextBox, trim để tránh khoảng trắng
                string productID = TbNewProductID.Text.Trim();
                string productName = TbNewProductName.Text.Trim();
                string sellingPrice = TbSellingPrice.Text.Trim();
                string unit = TbUnit.Text.Trim();

                // Kiểm tra dữ liệu và tạo ProductDTO (nếu lỗi sẽ ném exception)
                var newProduct = ProductBUS.ValidateNewProductInput(productID, productName, sellingPrice, unit, AllProducts);

                // Kiểm tra xem sản phẩm đã có trong ExtraProducts chưa
                bool exists = ExtraProducts.Any(p => p.GetID() == newProduct.GetID());
                if (exists)
                {
                    RJMessageBox.Show("Sản phẩm này đã được thêm vào danh sách.",
                                      "Trùng sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm sản phẩm mới vào danh sách
                ExtraProducts.Add(newProduct);

                // Cập nhật DataGridView hiển thị danh sách sản phẩm mới
                RefreshDgvNewProductList();

                // Nếu cần, reset các TextBox hoặc form
                BtnRefeshClick(null, null);
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefeshClick(object sender, EventArgs e)
        {
            TbNewProductID.Text = "";
            TbNewProductName.Text = "";
            TbSellingPrice.Text = "";
            TbUnit.Text = "";
        }

        private void RefreshDgvNewProductList()
        {
            // Xóa tất cả dòng cũ
            DgvNewProductList.Rows.Clear();

            int stt = 1; // Số thứ tự

            foreach (var p in ExtraProducts)
            {
                DgvNewProductList.Rows.Add(
                    stt,        // STT
                    p.GetID(),  // Mã sản phẩm
                    p.GetName(),// Tên sản phẩm
                    p.GetSellingPrice(),// Giá bán
                    p.GetUnit() // Đơn vị
                );
                stt++;
            }

            if(ExtraProducts.Count > 0)
            {
                BtnDeleteProduct.Enabled = true;
                BtnSave.Enabled = true;
            }else
            {
                BtnDeleteProduct.Enabled = false;
                BtnSave.Enabled = false;
            }

        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnDeleteProductClick(object sender, EventArgs e)
        {
            if (DgvNewProductList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy hàng được chọn
            var selectedRow = DgvNewProductList.SelectedRows[0];

            // Lấy ID sản phẩm từ cột "ProductID"
            string idToDelete = selectedRow.Cells["ProductID"].Value.ToString();

            // Tìm sản phẩm trong ExtraProducts
            var productToRemove = ExtraProducts.FirstOrDefault(p =>
                p.GetID().Equals(idToDelete, StringComparison.OrdinalIgnoreCase));

            if (productToRemove != null)
            {
                // Xóa khỏi danh sách
                ExtraProducts.Remove(productToRemove);

                // Refresh DataGridView
                RefreshDgvNewProductList();
            }
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if(ExtraProducts.Count <= 0)
            {
                RJMessageBox.Show("Không có sản phẩm nào để lưu!", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            var result = RJMessageBox.Show("Bạn muốn lưu thông tin ở trên?", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ProductBUS.SaveProducts(ExtraProducts);
                BtnDeleteProduct.Enabled = false;
                BtnSave.Enabled = false;
            }
        }
    }
}
