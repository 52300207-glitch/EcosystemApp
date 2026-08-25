using DocumentFormat.OpenXml.Bibliography;
using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class ImportProductForm : Form
    {
        private WarehouseBUS WarehouseBUS = new WarehouseBUS();
        private SearchHelper SearchHelper = new SearchHelper();
        private ImportExportInvoiceBUS ImportInvoiceBUS = new ImportExportInvoiceBUS();
        private EmployeeDTO CurrentEmployee;
        private List<ProductDTO> AllProducts;
        private List<PackageDTO> AllPackages;
        private List<PackagingTypeDTO> AllPackagingTypes;
        private ImportExportInvoiceDTO ImportInvoice = null;
        private List<ImportExportInvoiceDTO> AllImportInvoice;
        public ImportProductForm()
        {
            InitializeComponent();

        }

        public ImportProductForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
            InitializeDefaultValues();
            AllProducts = new ProductBUS().GetAll();
            AllPackages = new PackageBUS().GetAll();
            AllPackagingTypes = new PackagingTypeBUS().GetAllPackagingType();
        }

        private void ImportProductFormLoad(object sender, EventArgs e)
        {
            ShowProductImportUI();
        }

        //
        private void ShowProductImportUI()
        {
            ToggleButtonStyle(BtnImportProduct, BtnImportPackage);
            ToggleProductFields(true);

            ClearInputFields();
            SetupProductUnitComboBox(new List<string> { "kg", "g", "tấn", "L", "ml", "m³" });
        }

        private void ShowPackageImportUI()
        {
            ToggleButtonStyle(BtnImportPackage, BtnImportProduct);
            ToggleProductFields(false);

            ClearInputFields();
        }

        private void ToggleButtonStyle(Button active, Button inactive)
        {
            active.BackColor = Color.FromArgb(196, 238, 181);
            active.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);

            inactive.BackColor = Color.FromArgb(228, 255, 207);
            inactive.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Regular);
        }

        private void ToggleProductFields(bool isProduct)
        {
            TbProductName.Visible = isProduct;
            TbQuantityProduct.Visible = isProduct;
            CbbProductUnit.Visible = isProduct;
            TbPurchasePrice.Enabled = true;

            TbSerialCode.Visible = !isProduct;
            TbPackageType.Visible = !isProduct;

            LbProductInformation.Text = isProduct ? "Tên sản phẩm" : "Tên bao bì";
            LbProductInformation.Location = isProduct ? new Point(52, 69) : new Point(90, 69);

            LbQuantityProduct.Text = isProduct ? "Số lượng" : "Mã Serial";
            if (isProduct)
            {
                LbProductUnit.Visible = true;
            }
            else
            {
                LbProductUnit.Visible = false;
            }
        }
        private void BtnImportProductClick(object sender, EventArgs e) => ShowProductImportUI();
        private void BtnImportPackageClick(object sender, EventArgs e) => ShowPackageImportUI();


        private void ClearInputFields()
        {
            foreach (var tb in new[] { TbSerialCode, TbPackageType, TbProductName, TbQuantityProduct, TbPurchasePrice })
                tb.Text = "";

            if (CbbProductUnit.Items.Count > 0)
                CbbProductUnit.SelectedIndex = 0;

            LbSuggestions.Visible = false;
            LbSuggestions2.Visible = false;
        }

        private void SetupProductUnitComboBox(List<string> units)
        {
            CbbProductUnit.Items.Clear();
            CbbProductUnit.Items.AddRange(units.ToArray());
            CbbProductUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            if (CbbProductUnit.Items.Count > 0)
                CbbProductUnit.SelectedIndex = 0;
        }



        //
        private void InitializeDefaultValues()
        {
            CbbStorageOther.DataSource = WarehouseBUS.GetAllWarehouse().Select(w => new { ID = w.GetID(), Name = w.GetName() }).ToList(); ;
            CbbStorageOther.DisplayMember = "Name";
            CbbStorageOther.ValueMember = "ID";
            CbbStorageOther.DropDownStyle = ComboBoxStyle.DropDownList;

            CbbStorage.DataSource = WarehouseBUS.GetAllWarehouse().Where(w => w.GetID() == CurrentEmployee.GetStation().GetWarehouseID())
                .Select(w => new { ID = w.GetID(), Name = w.GetName() }).ToList();
            CbbStorage.DisplayMember = "Name";
            CbbStorage.ValueMember = "ID";
            CbbStorage.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbStorage.SelectedIndex = 0;
            CbbStorage.Enabled = false;

            LbSuggestions.Width = TbProductName.Width;
            LbSuggestions.Visible = false;
            LbSuggestions2.Width = TbPackageType.Width;
            LbSuggestions2.Visible = false;
            LbTotalCost.Text = "Tổng tiền: 0";
            SetupDgvProductList();
            RbtnSelf.Checked = true;
            SetupDgvImportHistory();
            ShowDgvImportHistory();
        }

        private void RbtnSelfCheckedChanged(object sender, EventArgs e) => ToggleSupplierUI("Self");

        private void RbtnSupplierCheckedChanged(object sender, EventArgs e) => ToggleSupplierUI("Supplier");

        private void RbtnStorageOtherCheckedChanged(object sender, EventArgs e) => ToggleSupplierUI("StorageOther");

        private void ToggleSupplierUI(string type)
        {
            switch (type)
            {
                case "Self":
                    LbNamePlaceSupply.Visible = false;
                    TbNamePlaceSupply.Visible = false;
                    CbbStorageOther.Visible = false;
                    break;
                case "Supplier":
                    LbNamePlaceSupply.Text = "Tên nơi cung cấp";
                    LbNamePlaceSupply.Visible = true;
                    TbNamePlaceSupply.Visible = true;
                    CbbStorageOther.Visible = false;
                    break;
                case "StorageOther":
                    LbNamePlaceSupply.Text = "Tên kho cung cấp";
                    LbNamePlaceSupply.Visible = true;
                    TbNamePlaceSupply.Visible = false;
                    CbbStorageOther.Visible = true;
                    break;
            }
        }


        //
        private void TbProductNameTextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(TbProductName.Text.ToLower(), AllProducts, LbSuggestions);
            var tempProduct = AllProducts.Where(p => p.GetName() == TbProductName.Text).ToList();
            if (tempProduct.Any())
            {
                CbbProductUnit.Text = tempProduct[0].GetUnit();
                CbbProductUnit.Enabled = false;
            }
            else
            {

                CbbProductUnit.Enabled = true;
            }
        }
        private void TbPackageTypeTextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(TbPackageType.Text.ToLower(), AllPackagingTypes, LbSuggestions2);
        }

        private void ShowSuggestions<T>(string keyword, List<T> source, ListBox listBox)
        {
            listBox.Items.Clear();

            if (string.IsNullOrWhiteSpace(keyword) || source == null)
            {
                listBox.Visible = false;
                return;
            }

            SearchHelper helper = new SearchHelper();
            List<T> filtered = new List<T>();

            // --- Gọi đúng hàm search hiện có trong SearchHelper ---
            if (typeof(T) == typeof(ProductDTO))
            {
                var result = helper.SearchProductsByKeyword(source.Cast<ProductDTO>().ToList(), keyword);
                filtered = result.Cast<T>().ToList();
            }
            else if (typeof(T) == typeof(PackagingTypeDTO))
            {
                var result = helper.SearchPackagingTypeByKeyword(source.Cast<PackagingTypeDTO>().ToList(), keyword);
                filtered = result.Cast<T>().ToList();
            }

            // --------------------------------------------------------

            if (filtered.Any())
            {
                foreach (var item in filtered)
                {
                    if (typeof(T) == typeof(ProductDTO))
                        listBox.Items.Add(((ProductDTO)(object)item).GetName());
                    else if (typeof(T) == typeof(PackagingTypeDTO))
                        listBox.Items.Add(((PackagingTypeDTO)(object)item).GetTypeName());

                }

                listBox.Height = Math.Min(filtered.Count * 24, 120);
                listBox.Visible = true;
                listBox.BringToFront();
            }
            else
            {
                listBox.Visible = false;
            }
        }

        private void ListBoxClick(ListBox listBox, TextBox target)
        {
            if (listBox.SelectedItem != null)
            {
                target.Text = listBox.SelectedItem.ToString();
                target.SelectionStart = target.Text.Length;
                listBox.Visible = false;
            }
        }

        private void LbSuggestionsClick(object sender, EventArgs e) => ListBoxClick(LbSuggestions, TbProductName);
        private void LbSuggestions2Click(object sender, EventArgs e) => ListBoxClick(LbSuggestions2, TbPackageType);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (LbSuggestions.Visible && LbSuggestions.SelectedItem != null)
                    ListBoxClick(LbSuggestions, TbProductName);
                if (LbSuggestions2.Visible && LbSuggestions2.SelectedItem != null)
                    ListBoxClick(LbSuggestions2, TbPackageType);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        //
        private void SetupDgvProductList()
        {
            DgvProductList.Columns.Clear();
            DgvProductList.AutoGenerateColumns = false;
            DgvProductList.AllowUserToAddRows = false;
            DgvProductList.ReadOnly = true;

            AddColumn(DgvProductList, "STT", "NumberCount", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn(DgvProductList, "Tên sản phẩm", "ProductName", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn(DgvProductList, "Số lượng", "Quantity", 120);
            AddColumn(DgvProductList, "Giá mua", "PurchasePrice", 150);
            foreach (DataGridViewColumn col in DgvProductList.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void AddColumn(DataGridView dgv, string header, string propName, int width)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = header,
                Name = propName,
                DataPropertyName = propName,
                Width = width
            });
        }

        private void AddColumn(DataGridView dgv, string header, string propName, DataGridViewAutoSizeColumnMode mode)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = header,
                Name = propName,
                DataPropertyName = propName,
                AutoSizeMode = mode
            });
        }

        //

        private void BtnAddProductClick(object sender, EventArgs e)
        {
            if (CbbProductUnit.Visible)
            {
                string productName = TbProductName.Text;
                string productQuantity = TbQuantityProduct.Text;
                string purchasePrice = TbPurchasePrice.Text;
                string productUnit = CbbProductUnit.SelectedItem?.ToString() ?? "";

                if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productQuantity) ||
                string.IsNullOrEmpty(purchasePrice) || string.IsNullOrEmpty(productUnit))
                {
                    RJMessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(productQuantity, out int quantity) || !decimal.TryParse(purchasePrice, out decimal price))
                {
                    RJMessageBox.Show("Số lượng, giá mua và giá bán là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();

                    return;
                }

                var existingProduct = AllProducts.FirstOrDefault(p => p.GetName() == productName);

                try
                {
                    ImportInvoice = ImportInvoiceBUS.ProcessProductImportInvoice(existingProduct, productName, quantity, price, ImportInvoice);
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();

                    return;
                }
                RefreshProductGrid();
                LbTotalCost.Text = "Tổng tiền: " + ImportInvoice.GetTotalBill().ToString();
            }
            else
            {
                string serialCode = TbSerialCode.Text;
                string packageTypeName = TbPackageType.Text;
                string purchasePrice = TbPurchasePrice.Text;
                string warehouseID = CbbStorage.SelectedValue.ToString();
                if (string.IsNullOrEmpty(serialCode) || string.IsNullOrEmpty(packageTypeName) || string.IsNullOrEmpty(purchasePrice))
                {
                    RJMessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                    return;
                }

                if (!decimal.TryParse(purchasePrice, out decimal purchasePriceDecimal))
                {
                    RJMessageBox.Show("Số lượng, giá mua và giá bán là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                    return;

                }
                try
                {
                    var packagingType = AllPackages.FirstOrDefault(p => p.GetSerialCode() == serialCode && p.GetPackagingType().GetTypeName() == packageTypeName);

                    ImportInvoice = ImportInvoiceBUS.ProcessPackageImportInvoice(CurrentEmployee, packagingType, purchasePriceDecimal, ImportInvoice);
                    RefreshProductGrid();
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                    return;
                }
            }

            ClearInputFields();


        }

        private void RefreshProductGrid()
        {
            DgvProductList.Rows.Clear();
            if (ImportInvoice == null) return;
            int stt = 1;
            foreach (var item in ImportInvoice.GetInvoiceDetails())
            {
                if (item.GetProduct() != null)
                {
                    DgvProductList.Rows.Add(stt, item.GetProduct().GetName(), item.GetQuantity(), item.GetTotalAmount());
                }
                else
                {
                    DgvProductList.Rows.Add(stt, item.GetPackage().GetPackagingType().GetTypeName(), "1", item.GetTotalAmount());
                }
                stt++;
            }
        }

        private void BtnCancelClick(object sender, EventArgs e) => ClearAll();

        private void ClearAll()
        {
            ClearInputFields();
            ImportInvoice = null;
            CbbProductUnit.SelectedIndex = 0;
            CbbStorage.SelectedIndex = 0;
            RefreshProductGrid();
        }

        private void BtnConfirmClick(object sender, EventArgs e)
        {

            if (DgvProductList.Rows.Count == 0)
            {
                RJMessageBox.Show("Danh sách xuất trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string note = RbtnSelf.Checked ? "Tự sản xuất" :
                          RbtnStorageOther.Checked ? "Kho khác: " + CbbStorageOther.SelectedValue : "Nhà cung cấp: " + TbNamePlaceSupply.Text;

            string warehouseID = CbbStorage.SelectedValue?.ToString();
            ImportInvoiceBUS.SaveImportInvoice(ImportInvoice, note, warehouseID);

            InitializeDefaultValues();
            ClearAll();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn không
            if (DgvProductList.SelectedRows.Count > 0)
            {
                int rowIndex = DgvProductList.SelectedRows[0].Index;

                if (ImportInvoice != null)
                {
                    var details = ImportInvoice.GetInvoiceDetails();

                    // Kiểm tra index hợp lệ
                    if (rowIndex >= 0 && rowIndex < details.Count)
                    {
                        details.RemoveAt(rowIndex); // xóa chi tiết tại vị trí

                        // Cập nhật lại DataGridView
                        RefreshProductGrid();
                        LbTotalCost.Text = "Tổng tiền: " + ImportInvoice.GetTotalBill().ToString();

                    }
                }
            }
            else
            {
                RJMessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void SetupDgvImportHistory()
        {
            DgvImportHistory.Columns.Clear();
            DgvImportHistory.AutoGenerateColumns = false;
            DgvImportHistory.AllowUserToAddRows = false;
            DgvImportHistory.ReadOnly = true;
            DgvImportHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddColumn(DgvImportHistory, "Mã phiếu", "InvoiceID", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn(DgvImportHistory, "Tên kho nhập", "WarehouseName", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn(DgvImportHistory, "Ngày tạo", "CreatedDate", 150);
            AddColumn(DgvImportHistory, "Tổng sản phẩm", "TotalProducts", 150);

            foreach (DataGridViewColumn col in DgvImportHistory.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ShowDgvImportHistory()
        {
            var ImportHistoryBUS = new ImportExportInvoiceBUS();

            AllImportInvoice = ImportHistoryBUS.GetAll().Where(i => i.GetInvoiceType() == "IMPORT").ToList();

            foreach (var invoice in AllImportInvoice)
            {
                string warehouseName = WarehouseBUS.GetAllWarehouse().FirstOrDefault(w => w.GetID() == invoice.GetWarehouseID())?.GetName() ?? "Không xác định";
                string createdDate = invoice.GetDate().ToString("dd/MM/yyyy HH:mm");
                int totalProducts = invoice.GetInvoiceDetails()?.Count ?? 0;

                DgvImportHistory.Rows.Add(invoice.GetID(), warehouseName, createdDate, totalProducts);
            }

            // Format cột ngày
            if (DgvImportHistory.Columns["CreatedDate"] != null)
                DgvImportHistory.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void BtnViewDetailClick(object sender, EventArgs e)
        {
            if (DgvImportHistory.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn phiếu nhập để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedRowIndex = DgvImportHistory.SelectedRows[0].Index;
            if (selectedRowIndex >= 0 && selectedRowIndex < AllImportInvoice.Count)
            {
                var ImportInvoice = AllImportInvoice[selectedRowIndex];
                ImportExportDetailForm detailForm = new ImportExportDetailForm(ImportInvoice, "Import");
                detailForm.ShowDialog();
            }
        }
    }
}
