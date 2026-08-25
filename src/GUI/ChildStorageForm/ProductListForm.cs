using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class ProductListForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private SearchHelper SearchHelper = new SearchHelper();

        private ProductBUS ProductBUS = new ProductBUS();
        private List<ProductDTO> AllProducts;
        private List<ProductDTO> FilteredProducts;

        private int currentPage = 1;
        private int totalPages = 1;
        private int pageSize = 10;

        public ProductListForm()
        {
            InitializeComponent();
            AllProducts = ProductBUS.GetAll();
            InitializeDefaultValues();
        }

        public ProductListForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            // Load dữ liệu lần đầu
            LoadPage();
        }

        private void InitializeDefaultValues()
        {
            // Khởi tạo cột datagridview
            DgvProductList.Columns.Clear();
            DgvProductList.Columns.Add("ProductID", "Mã sản phẩm");
            DgvProductList.Columns.Add("ProductName", "Tên sản phẩm");
            DgvProductList.Columns.Add("Unit", "Đơn vị");
            DgvProductList.Columns.Add("SellingPrice", "Giá bán");
            DgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvProductList.AllowUserToAddRows = false; // không cho user thêm dòng
            DgvProductList.ReadOnly = true; // chỉ xem, không sửa
            // Không cho sắp xếp
            foreach (DataGridViewColumn col in DgvProductList.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            // Load dữ liệu kho mặc định
            CbbWarehouseNamesSelectedIndexChanged(null, null);
        }

        // Khi chọn kho
        private void CbbWarehouseNamesSelectedIndexChanged(object sender, EventArgs e)
        {
            TbSearch.Text = "";
            FilteredProducts = new List<ProductDTO>(AllProducts); // copy danh sách
            currentPage = 1;
            LoadPage();
        }

        // Load dữ liệu lên grid
        private void LoadProductsToGrid(List<ProductDTO> products)
        {
            DgvProductList.Rows.Clear();

            foreach (var product in products)
            {
                string id = product.GetID();
                string name = product.GetName();
                string unit = "1 " + product.GetUnit();
                string sellingPrice = product.GetSellingPrice().ToString("N0"); // format tiền
                DgvProductList.Rows.Add(id, name, unit, sellingPrice);
            }
        }

        // Tìm kiếm sản phẩm
        private void BtnSearchClick(object sender, EventArgs e)
        {
            SearchAndLoad();
        }

        private void TbSearchTextChanged(object sender, EventArgs e)
        {
            SearchAndLoad();
        }

        private void SearchAndLoad()
        {
            string keyword = TbSearch.Text.Trim();
            FilteredProducts = SearchHelper.SearchProductsByKeyword(AllProducts, keyword);
            currentPage = 1;
            LoadPage();
        }

        // Phân trang
        private void LoadPage()
        {
            if (FilteredProducts == null || FilteredProducts.Count == 0)
            {
                DgvProductList.Rows.Clear();
                LbPageInfo.Text = "Trang 0 / 0";
                return;
            }

            totalPages = (int)Math.Ceiling((double)FilteredProducts.Count / pageSize);
            if (currentPage > totalPages) currentPage = totalPages;

            int start = (currentPage - 1) * pageSize;
            var pageData = FilteredProducts.Skip(start).Take(pageSize).ToList();

            LoadProductsToGrid(pageData);
            LbPageInfo.Text = $"Trang {currentPage} / {totalPages}";
        }

        // Nút phân trang
        private void BtnPrevPageClick(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void BtnNextPageClick(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        // Chỉnh sửa sản phẩm
        private void BtnEditClick(object sender, EventArgs e)
        {
            if (DgvProductList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một sản phẩm để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndexOnPage = DgvProductList.SelectedRows[0].Index;
            int selectedIndex = (currentPage - 1) * pageSize + selectedIndexOnPage;
            if (selectedIndex >= FilteredProducts.Count) return;

            ProductDTO selectedProduct = FilteredProducts[selectedIndex];
            var editForm = new EditProductForm(selectedProduct);
            editForm.ShowDialog();

            // Reload dữ liệu sau khi chỉnh sửa
            LoadPage();
        }

        // Thêm sản phẩm mới
        private void BtnAddNewProductClick(object sender, EventArgs e)
        {
            var newForm = new NewProductForm();
            newForm.ShowDialog();
            // reload dữ liệu
            AllProducts = ProductBUS.GetAll();
            SearchAndLoad();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (DgvProductList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một sản phẩm để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndexOnPage = DgvProductList.SelectedRows[0].Index;
            int selectedIndex = (currentPage - 1) * pageSize + selectedIndexOnPage;
            if (selectedIndex >= FilteredProducts.Count) return;

            ProductBUS.Delete(FilteredProducts[selectedIndex]);
            AllProducts = ProductBUS.GetAll();
            FilteredProducts = new List<ProductDTO>(AllProducts);
            LoadProductsToGrid(FilteredProducts);
        }
    }
}
