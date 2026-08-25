using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class InventoryListForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private WarehouseBUS WarehouseBUS = new WarehouseBUS();
        private InventoryBUS InventoryBUS = new InventoryBUS();
        private SearchHelper SearchHelper = new SearchHelper();
        private List<InventoryDTO> Inventories = new List<InventoryDTO>();
        private List<InventoryDTO> FilteredInvetories = new List<InventoryDTO>();

        private int CurrentPage = 1;
        private int TotalPages = 1;
        private int PageSize = 20; 

        public InventoryListForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        public InventoryListForm(EmployeeDTO emp) : this()
        {

            CurrentEmployee = emp;
        }

        private void InitializeDefaultValues()
        {
            //
            var list = WarehouseBUS.GetAllWarehouse()
            .Select(w => new { ID = w.GetID(), Name = w.GetName() })
            .ToList();

            CbbWarehouseNames.DataSource = list;
            CbbWarehouseNames.DisplayMember = "Name";
            CbbWarehouseNames.ValueMember = "ID";
            CbbWarehouseNames.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbWarehouseNames.SelectedIndex = 0;
            //

            // khởi tạo cột datagridview
            DgvInventoryList.Columns.Clear();
            DgvInventoryList.Columns.Add("ProductID", "Mã sản phẩm");
            DgvInventoryList.Columns.Add("ProductName", "Tên sản phẩm");
            DgvInventoryList.Columns.Add("Quantity", "Số lượng");
            DgvInventoryList.Columns.Add("Unit", "Đơn vị");
            DgvInventoryList.Columns.Add("Note", "Ghi chú");
            DgvInventoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvInventoryList.AllowUserToAddRows = false; // không cho user thêm dòng
            DgvInventoryList.ReadOnly = true; // nếu chỉ xem, không sửa

            CbbWarehouseNamesSelectedIndexChanged(null, null);

        }

        private void CbbWarehouseNamesSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWarehouseID = CbbWarehouseNames.SelectedValue?.ToString();
            Inventories = InventoryBUS.GetByWarehouseID(selectedWarehouseID);
            FilteredInvetories = Inventories;
            LoadInventoryToGrid(FilteredInvetories);
            CurrentPage = 1;
            LoadPage();
        }

        private void LoadInventoryToGrid(List<InventoryDTO> inventories)
        {
            DgvInventoryList.Rows.Clear();

            foreach (var inv in inventories.Where(i => i.GetProduct() != null))
            {
                var product = inv.GetProduct();
                string name = product.GetName();
                int stockQuantity = inv.GetStockQuantity();
                string unit = product.GetUnit();

                string note = stockQuantity < 200 ? "Sản phẩm sắp hết!" : "";

                DgvInventoryList.Rows.Add(inv.GetProduct().GetID(),name, stockQuantity, unit, note);
            }

            /////////////////////////////////////////////
            // 2️⃣ VÒNG 2: Xử lý PACKAGE sau
            /////////////////////////////////////////////
            foreach (var inv in inventories.Where(i => i.GetProduct() == null && i.GetPackage() != null))
            {
                var package = inv.GetPackage();
                var type = package.GetPackagingType();

                string name = type.GetTypeName();
                int stockQuantity = inv.GetStockQuantity();
                string unit = type.GetMaterial();

                // Note cho bao bì: reuse vượt giới hạn
                string note = package.GetReuseCount() > type.GetReuseLimit()
                              ? "Cần vệ sinh!"
                              : "";

                DgvInventoryList.Rows.Add(inv.GetPackage().GetSerialCode(), name, stockQuantity, unit, note);
            }
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {
            string keyword = TbSearch.Text;
            FilteredInvetories = SearchHelper.SearchInventoriesByKeyword(Inventories, keyword);
            LoadInventoryToGrid(FilteredInvetories);
            CurrentPage = 1;
            LoadPage();

        }

        private void TbSearchTextChanged(object sender, EventArgs e)
        {
            string keyword = TbSearch.Text;
            FilteredInvetories = SearchHelper.SearchInventoriesByKeyword(Inventories, keyword);
            LoadInventoryToGrid(FilteredInvetories);
            CurrentPage = 1;
            LoadPage();
        }

        private void DgvProductListCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvInventoryList.Columns[e.ColumnIndex].Name == "Note")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void BtnAddNewProductClick(object sender, EventArgs e)
        {
            var newForm = new NewProductForm();
            newForm.ShowDialog();
        }

        private void LoadPage()
        {
            if (FilteredInvetories == null || FilteredInvetories.Count == 0)
            {
                DgvInventoryList.Rows.Clear();
                LbPageInfo.Text = "Trang 0 / 0";
                return;
            }

            TotalPages = (int)Math.Ceiling((double)FilteredInvetories.Count / PageSize);

            if (CurrentPage > TotalPages)
                CurrentPage = TotalPages;

            int start = (CurrentPage - 1) * PageSize;

            var pageData = FilteredInvetories
                .Skip(start)
                .Take(PageSize)
                .ToList();

            LoadInventoryToGrid(pageData);

            LbPageInfo.Text = $"Trang {CurrentPage} / {TotalPages}";
        }

        private void BtnPrevPageClick(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                LoadPage();
            }
        }

        private void BtnNextPageClick(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                LoadPage();
            }
        }
    }
}
