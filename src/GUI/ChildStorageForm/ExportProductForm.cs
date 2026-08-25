using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class ExportProductForm : Form
    {
        private WarehouseBUS WarehouseBUS = new WarehouseBUS();
        private SearchHelper SearchHelper = new SearchHelper();
        private ImportExportInvoiceBUS ExportInvoiceBUS = new ImportExportInvoiceBUS();
        private EmployeeDTO CurrentEmployee;
        private List<ProductDTO> AllProducts;
        private List<PackageDTO> AllPackages;
        private List<PackagingTypeDTO> AllPackagingTypes;
        private ImportExportInvoiceDTO ExportInvoice = null;
        private List<ImportExportInvoiceDTO> AllExportInvoice;

        public ExportProductForm()
        {
            InitializeComponent();

        }

        public ExportProductForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
            InitializeDefaultValues();
            AllProducts = new List<ProductDTO>();
            AllPackages = new List<PackageDTO>();

            foreach (var item in new InventoryBUS().GetByWarehouseID(CurrentEmployee.GetStation().GetWarehouseID()))
            {
                if (item.GetProduct() != null)
                    AllProducts.Add(item.GetProduct());
                else
                    AllPackages.Add(item.GetPackage());
            }
            AllPackagingTypes = new PackagingTypeBUS().GetAllPackagingType();
        }

        private void ExportProductFormLoad(object sender, EventArgs e)
        {
            ShowProductExportUI();
        }



        private void ShowProductExportUI()
        {
            ToggleButtonStyle(BtnExportProduct, BtnExportPackage);
            ToggleProductFields(true);
            ClearInputFields();
        }

        private void ShowPackageExportUI()
        {
            ToggleButtonStyle(BtnExportPackage, BtnExportProduct);
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
            LbQuantityProduct.Visible = isProduct;

            TbSerialCode.Visible = !isProduct;

            LbProductInformation.Text = isProduct ? "Tên sản phẩm" : "Mã Serial bao bì";
        }

        private void ClearInputFields()
        {
            foreach (var tb in new[] { TbSerialCode, TbProductName, TbQuantityProduct })
                tb.Text = "";
            LbSuggestions.Visible = false;
        }

        private void BtnExportProductClick(object sender, EventArgs e) => ShowProductExportUI();
        private void BtnExportPackageClick(object sender, EventArgs e) => ShowPackageExportUI();


        //
        private void InitializeDefaultValues()
        {
            CbbStorage.DataSource = WarehouseBUS.GetAllWarehouse()
                .Select(w => new { ID = w.GetID(), Name = w.GetName() }).ToList();
            CbbStorage.DisplayMember = "Name";
            CbbStorage.ValueMember = "ID";
            CbbStorage.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbStorage.SelectedIndex = 0;
            LbTotalCost.Text = "Tổng tiền: 0";
            SetupDgvProductList();
            SetupDgvExportHistory();
            ShowDgvExportHistory();
        }


        //

        private void TbProductNameTextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(TbProductName.Text.ToLower(), AllProducts, LbSuggestions);
        }

        private void ShowSuggestions<T>(string keyword, List<T> source, ListBox listBox)
        {
            listBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(keyword) || source == null)
            {
                listBox.Visible = false;
                return;
            }

            List<T> filtered = new List<T>();
            if (typeof(T) == typeof(ProductDTO))
            {
                filtered = SearchHelper.SearchProductsByKeyword(source.Cast<ProductDTO>().ToList(), keyword).Cast<T>().ToList();
            }
            else if (typeof(T) == typeof(PackagingTypeDTO))
            {
                filtered = SearchHelper.SearchPackagingTypeByKeyword(source.Cast<PackagingTypeDTO>().ToList(), keyword).Cast<T>().ToList();
            }

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (LbSuggestions.Visible && LbSuggestions.SelectedItem != null)
                    ListBoxClick(LbSuggestions, TbProductName);
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
            AddColumn(DgvProductList, "Giá xuất", "ExportPrice", 150);
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
            if (!TbSerialCode.Visible) // sản phẩm
            {
                string productName = TbProductName.Text;
                string productQuantity = TbQuantityProduct.Text;

                if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productQuantity))
                {
                    RJMessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(productQuantity, out int quantity))
                {
                    RJMessageBox.Show("Số lượng phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                try
                {
                    ExportInvoice = ExportInvoiceBUS.ProcessProductExportInvoice(CurrentEmployee, productName, quantity, ExportInvoice);
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RefreshProductGrid();
            }
            else // bao bì
            {
                string serialCode = TbSerialCode.Text;

                if (string.IsNullOrEmpty(serialCode))
                {
                    RJMessageBox.Show("Bạn cần nhập mã bao bì!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ExportInvoice = ExportInvoiceBUS.ProcessPackageExportInvoice(CurrentEmployee, TbSerialCode.Text, ExportInvoice);
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RefreshProductGrid();
            }

            ClearInputFields();
        }


        private void RefreshProductGrid()
        {
            DgvProductList.Rows.Clear();
            if (ExportInvoice == null) return;

            int stt = 1;
            foreach (var item in ExportInvoice.GetInvoiceDetails())
            {
                if (item.GetProduct() != null)
                    DgvProductList.Rows.Add(stt, item.GetProduct().GetName(), item.GetQuantity(), item.GetTotalAmount());
                else
                    DgvProductList.Rows.Add(stt, item.GetPackage().GetPackagingType().GetTypeName(), 1, item.GetTotalAmount());
                stt++;
            }
            LbTotalCost.Text = "Tổng tiền: " + ExportInvoice.GetTotalBill();
        }

        private void BtnCancelClick(object sender, EventArgs e) => ClearAll();

        private void ClearAll()
        {
            ClearInputFields();
            ExportInvoice = null;
            CbbStorage.SelectedIndex = 0;
            RefreshProductGrid();
        }

        private void BtnConfirmClick(object sender, EventArgs e)
        {
            if(DgvProductList.Rows.Count == 0)
            {
                RJMessageBox.Show("Danh sách xuất trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExportInvoice != null)
            {
                string warehouseID = CbbStorage.SelectedValue.ToString();

                ExportInvoiceBUS.SaveExportInvoice(ExportInvoice, $" Xuất đến kho: {WarehouseBUS.GetWarehouseByID(warehouseID).GetName()} ", CurrentEmployee.GetStation().GetWarehouseID());
            }

            ClearAll();
            InitializeDefaultValues();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (DgvProductList.SelectedRows.Count > 0 && ExportInvoice != null)
            {
                int rowIndex = DgvProductList.SelectedRows[0].Index;
                var details = ExportInvoice.GetInvoiceDetails();
                if (rowIndex >= 0 && rowIndex < details.Count)
                {
                    details.RemoveAt(rowIndex);
                    RefreshProductGrid();
                }
                LbTotalCost.Text = "Tổng tiền: " + ExportInvoice.GetTotalBill();
            }
            else RJMessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //

        private void SetupDgvExportHistory()
        {
            DgvExportHistory.Columns.Clear();
            DgvExportHistory.AutoGenerateColumns = false;
            DgvExportHistory.AllowUserToAddRows = false;
            DgvExportHistory.ReadOnly = true;
            DgvExportHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AddColumn(DgvExportHistory, "Mã phiếu", "InvoiceID", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn(DgvExportHistory, "Tên kho xuất", "WarehouseName", DataGridViewAutoSizeColumnMode.Fill);
            AddColumn(DgvExportHistory, "Ngày tạo", "CreatedDate", 150);
            AddColumn(DgvExportHistory, "Tổng sản phẩm", "TotalProducts", 150);
        }

        private void ShowDgvExportHistory()
        {
            AllExportInvoice = ExportInvoiceBUS.GetAll().Where(i => i.GetInvoiceType() == "EXPORT").ToList();
            DgvExportHistory.Rows.Clear();

            foreach (var invoice in AllExportInvoice)
            {
                string warehouseName = WarehouseBUS.GetAllWarehouse()
                    .FirstOrDefault(w => w.GetID() == invoice.GetWarehouseID())?.GetName() ?? "Không xác định";
                string createdDate = invoice.GetDate().ToString("dd/MM/yyyy HH:mm");
                int totalProducts = invoice.GetInvoiceDetails()?.Count ?? 0;

                DgvExportHistory.Rows.Add(invoice.GetID(), warehouseName, createdDate, totalProducts);
            }
        }

        private void BtnViewDetailClick(object sender, EventArgs e)
        {
            if (DgvExportHistory.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn phiếu nhập để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedRowIndex = DgvExportHistory.SelectedRows[0].Index;
            if (selectedRowIndex >= 0 && selectedRowIndex < AllExportInvoice.Count)
            {
                var ExportInvoice = AllExportInvoice[selectedRowIndex];
                ImportExportDetailForm detailForm = new ImportExportDetailForm(ExportInvoice, "Export");
                detailForm.ShowDialog();
            }
        }
    }
}


