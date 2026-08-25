using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace EcosystemApp.GUI.ChildOrderForm
{
    public partial class CollectDataForm : Form
    {
        private EmployeeDTO CurrentUser;
        private OrderDTO Order;
        private OrderBUS OrderB = new OrderBUS();
        private ProductBUS ProductB = new ProductBUS();
        private GoogleSheetSyncHelper SheetSyncHelper;
        private SearchHelper SearchHelper = new SearchHelper();
        private BackgroundWorker SyncWorker;
        // sản phẩm hiện có trong kho
        private List<ProductDTO> AllProducts;

        public CollectDataForm()
        {
            InitializeComponent();
            
        }

        private void InzializeDefaultVaulues()
        {
            DgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProduct.MultiSelect = false;
            DgvProduct.ReadOnly = true;
            DgvProduct.AllowUserToAddRows = false;
            DgvProduct.Columns["NumberColumn"].Width = 50;
            DgvProduct.Columns["IDColumn"].Width = 80;
            DgvProduct.Columns["ProductNameColumn"].Width = 200;
            DgvProduct.Columns["QuantityColumn"].Width = 80;
            DgvProduct.Columns["TotalPriceColumn"].Width = 120;

            foreach (DataGridViewColumn column in DgvProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //setting radio button
            RadioCash.Checked = true;
            RadioBanking.Checked = false;
            BtnAddOrder.Enabled = false;

            //
            BtnGetDataExcel.Enabled = false;
            LbExcelWarning.Enabled = false;
            LbExcelWarning.Visible = false;
            CbbSheetNameFromExcel.Enabled = false;
            CbbSheetNameFromExcel.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbSynchronizeTime.DropDownStyle = ComboBoxStyle.DropDownList;
            TbOrderExcelSucess.Text = "0";
            TbOrderExcelFault.Text = "0";


            //
            BtnTestConnection.Enabled = true;
            BtnSyncNow.Enabled = false;
            BtnCancelSync.Enabled = false;
            CbbSynchronizeTime.Items.AddRange(new object[] { "1", "5", "10", "15", "30", "60" });
            CbbSynchronizeTime.SelectedIndex = 3; // mặc định 30 phút
            TbOrderSheetSuccess.Text = "0";
            TbOrderSheetFault.Text = "0";
            TbEmailClientInformation.Enabled = false;
            TbEmailClientInformation.Text = GoogleSheetSyncHelper.GetEmailCredential();

            LbSuggestions.Width = TbProductName.Width;
            LbSuggestions.Visible = false;

        }

        public CollectDataForm(EmployeeDTO user) : this()
        {
            CurrentUser = user;
            AllProducts = new List<ProductDTO>();
            foreach(var item in new InventoryBUS().GetByWarehouseID(CurrentUser.GetStation().GetWarehouseID()))
            {
                if (item.GetProduct() != null) 
                    AllProducts.Add(item.GetProduct());
            }

            InzializeDefaultVaulues();
            InitBackgroundWorker();
        }

        private void CollectDataFormLoad(object sender, EventArgs e)
        {
            HidePanel();
            BtnAddProductClick(null, null);
            BtnManualClick(null, null);
        }

        private void HidePanel()
        {
            PanelManual.Visible = false;
            PanelFromExcel.Visible = false;
            PanelGGSheet.Visible = false;
        }

        private void ActiveButton(Button btn, Panel target)
        {
            TogglePanel(target);
            if (btn == null) return;
            foreach (var b in new[] { BtnManual, BtnFromExcel, BtnFromGGSheet })
            {
                if (b != btn) DisableButton(b);
            }
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(196, 238, 181);
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void DisableButton(Button btn)
        {
            if (btn == null) return;

            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(228, 255, 207);
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }

        private void TogglePanel(Panel target)
        {
            foreach (var panel in new[] { PanelManual, PanelFromExcel, PanelGGSheet })
            {
                panel.Visible = panel == target ? !panel.Visible : false;
            }
        }

        private void BtnAddProductMouseEnter(object sender, EventArgs e)
        {
            BtnAdd.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void BtnAddProductMouseHover(object sender, EventArgs e)
        {
            BtnAdd.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void BtnAddProductMouseLeave(object sender, EventArgs e)
        {
            BtnAdd.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void BtnManualClick(object sender, EventArgs e)
        {
            ActiveButton(BtnManual, PanelManual);
        }

        private void BtnFromExcelClick(object sender, EventArgs e)
        {
            ActiveButton(BtnFromExcel, PanelFromExcel);
        }

        private void BtnFromGGSheetClick(object sender, EventArgs e)
        {
            ActiveButton(BtnFromGGSheet, PanelGGSheet);
        }

        // Thêm sản phẩm vào hóa đơn
        private void BtnAddClick(object sender, EventArgs e)
        {
            string nameCustomer = TbNameCustomer.Text;
            string phoneNumber = TbPhoneNumber.Text;
            string email = TbEmail.Text;
            string deliveryAddress = TbDeliveryAddress.Text;
            string transactionType = "";

            if (RadioCash.Checked)
            {
                transactionType = "Tiền mặt";
            }
            else if (RadioBanking.Checked)
            {
                transactionType = "Chuyển khoản";
            }

            string productName = TbProductName.Text;
            string quantity = TbQuantity.Text;
            string packageSerialCode = TbPackageID.Text;
            CustomerDTO customer = new CustomerDTO(nameCustomer, null, phoneNumber, email);
            // khởi tạo
            try
            {
                if (LbProductName.Visible == false) 
                {
                    Order = OrderB.ProcessOrder(customer, CurrentUser, Order, transactionType, null, "1", packageSerialCode, deliveryAddress);
                }else
                {
                    Order = OrderB.ProcessOrder(customer, CurrentUser, Order, transactionType, productName, quantity, null, deliveryAddress);
                }
            }
            catch (Exception ex)
            {
                LbWarning.Text = ex.Message;
                LbWarning.Visible = true;
            }

            ShowOrderDataGridView();

            // clear value
            TbProductName.Text = "";
            TbPackageID.Clear();
            TbQuantity.Clear();
            LbSuggestions.Visible = false;

        }

        // Display order items in DataGridView
        private void ShowOrderDataGridView()
        {
            if (Order != null)
            {
                DgvProduct.Rows.Clear();
                foreach (DataRow row in OrderB.GetOrdersTable(Order).Rows)
                {
                    DgvProduct.Rows.Add(
                        row["STT"],
                        row["Mã sản phẩm"],
                        row["Tên sản phẩm"],
                        row["Số lượng"],
                        row["Thành tiền"]
                    );
                }

                LbTotalPrice.Text = $"Tổng tiền {Order.GetTotalAmount().ToString("N0")}";

                BtnAddOrder.Enabled = DgvProduct.Rows.Count > 0;
            }

        }

        private void DgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnDeleteItem.Enabled = true;
        }

        private void BtnDeleteItemClick(object sender, EventArgs e)
        {
            if (DgvProduct.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = DgvProduct.SelectedRows[0];

                // Lấy giá trị từng cột theo tên cột hoặc index
                string id = selectedRow.Cells["IDColumn"].Value.ToString();

                Order = OrderB.DeleteItemOrder(Order, id);
                ShowOrderDataGridView();
            }
            else
            {
                // báo lỗi
                RJMessageBox.Show("Bạn chưa chọn dòng nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnAddOrder.Enabled = DgvProduct.Rows.Count > 0;
            BtnDeleteItem.Enabled = DgvProduct.Rows.Count > 0;

        }

        private void TbQuantityKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ignore the key
                LbWarning.Text = "Chỉ được nhập số!";
                LbWarning.Visible = true;
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            Order = null;
            DgvProduct.Rows.Clear();
            LbTotalPrice.Text = "Tổng tiền: 0";
            TbNameCustomer.Clear();
            TbPhoneNumber.Clear();
            TbEmail.Clear();
            TbDeliveryAddress.Clear();
            TbProductName.Text = "";
            TbPackageID.Clear();
            TbQuantity.Clear();
            RadioCash.Checked = true;
            RadioBanking.Checked = false;
            LbSuggestions.Visible = false;

            // Tạo lại cột

            BtnAddOrder.Enabled = DgvProduct.Rows.Count > 0;
        }

        private void BtnAddOrderClick(object sender, EventArgs e)
        {
            int number;
            if ((TbPhoneNumber.Text.Length < 10 || TbPhoneNumber.Text.Length > 12) && int.TryParse(TbPhoneNumber.Text, out number))
            {
                RJMessageBox.Show("Số điện thoại chỉ từ 10 đến 12 số!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //check texbox is empty
            if (TbNameCustomer.Text == "" || TbPhoneNumber.Text == "")
            {
                RJMessageBox.Show("Tên khác hàng và số điện thoại không được để trống!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OrderB.SaveOrder(Order);
            Clear();

        }

        private void ChosenFileClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // ✅ Cho phép chọn Excel & CSV
                openFileDialog.Filter = "Excel/CSV Files|*.xlsx;*.xls;*.csv";
                openFileDialog.Title = "Chọn file Excel hoặc CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    TbFile.Text = filePath; // hiển thị đường dẫn file được chọn

                    try
                    {
                        // Kiểm tra file tồn tại
                        if (!File.Exists(filePath))
                        {
                            RJMessageBox.Show("Không tìm thấy file được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string ext = Path.GetExtension(filePath).ToLower();
                        CbbSheetNameFromExcel.Items.Clear();

                        // ✅ Nếu là file Excel: lấy danh sách sheet
                        if (ext == ".xlsx" || ext == ".xls")
                        {
                            List<string> sheetNames = ExcelHelper.GetSheetNames(filePath);

                            foreach (var name in sheetNames)
                            {
                                CbbSheetNameFromExcel.Items.Add(name);
                            }

                            if (sheetNames.Count > 0)
                                CbbSheetNameFromExcel.SelectedIndex = 0;

                            CbbSheetNameFromExcel.Enabled = true;
                            BtnGetDataExcel.Enabled = true;

                        }
                        // ✅ Nếu là file CSV: không có sheet, nhưng vẫn bật nút xử lý
                        else if (ext == ".csv")
                        {
                            CbbSheetNameFromExcel.Enabled = false;
                            CbbSheetNameFromExcel.Text = "";
                            BtnGetDataExcel.Enabled = true;
                        }
                        else
                        {
                            CbbSheetNameFromExcel.Enabled = false;
                            CbbSheetNameFromExcel.Text = "";
                            BtnGetDataExcel.Enabled = false;

                        }
                    }
                    catch (Exception ex)
                    {
                        RJMessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // --- Khi người dùng gõ ---
        private void TbProductNameTextChanged(object sender, EventArgs e)
        {
            string keyword = TbProductName.Text.Trim();

            // 1. Nếu rỗng → ẩn
            if (string.IsNullOrEmpty(keyword))
            {
                LbSuggestions.Visible = false;
                return;
            }

            // 2. Nếu đã gõ đúng tên 1 sản phẩm → ẩn luôn, không bao giờ hiện lại
            bool isExactMatch = AllProducts.Any(p =>
                p.GetName().Equals(keyword, StringComparison.OrdinalIgnoreCase));

            if (isExactMatch)
            {
                LbSuggestions.Visible = false;
                return;
            }

            // 3. Tìm kiếm gợi ý
            var filtered = SearchHelper.SearchProductsByKeyword(AllProducts, keyword.ToLower());

            // 4. Không có kết quả nào → ẨN LUÔN (quan trọng!)
            if (filtered == null || filtered.Count == 0)
            {
                LbSuggestions.Visible = false;
                return;
            }

            // 5. Có kết quả → hiển thị
            LbSuggestions.Items.Clear();
            foreach (var p in filtered)
            {
                LbSuggestions.Items.Add(p.GetName());
            }

            // Tự động điều chỉnh chiều cao
            int itemHeight = LbSuggestions.ItemHeight;
            LbSuggestions.Height = Math.Min(filtered.Count * itemHeight + 4, 150); // +4 để đẹp viền

            LbSuggestions.Visible = true;
            LbSuggestions.BringToFront();
        }


        // --- Khi click vào item ---
        private void LbSuggestionsClick(object sender, EventArgs e)
        {
            if (LbSuggestions.SelectedItem != null)
            {
                TbProductName.Text = LbSuggestions.SelectedItem.ToString();
                LbSuggestions.Visible = false;
                TbProductName.SelectionStart = TbProductName.Text.Length;

                // Tự động chuyển qua ô số lượng → người dùng gõ luôn, rất nhanh!
                TbQuantity.Focus();
                TbQuantity.SelectAll();
            }
        }

        // --- Khi nhấn phím Enter hoặc mũi tên ---
        private void TbProductNameKeyDown(object sender, KeyEventArgs e)
        {
            if (TbProductName.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    LbSuggestions.Focus();
                    if (LbSuggestions.Items.Count > 0)
                        LbSuggestions.SelectedIndex = 0;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                // Người dùng gõ xong text mà không chọn gợi ý
                TbProductName.Visible = false;
            }
        }

        // --- Khi focus ListBox và nhấn Enter ---
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Khi đang focus vào ListBox và nhấn Enter
            if (LbSuggestions.Visible && LbSuggestions.Focused && keyData == Keys.Enter)
            {
                if (LbSuggestions.SelectedItem != null)
                {
                    TbProductName.Text = LbSuggestions.SelectedItem.ToString();
                }

                LbSuggestions.Visible = false;
                TbProductName.Focus();
                TbProductName.SelectionStart = TbProductName.Text.Length;
                return true;
            }

            // Khi focus TextBox và nhấn Enter
            if (TbProductName.Visible && TbProductName.Focused && keyData == Keys.Enter)
            {
                if (LbSuggestions.SelectedItem != null)
                {
                    TbProductName.Text = LbSuggestions.SelectedItem.ToString();
                }

                LbSuggestions.Visible = false;
                TbProductName.SelectionStart = TbProductName.Text.Length;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnGetDataExcelClick(object sender, EventArgs e)
        {
            LbText2.Visible = true;
            LbText1.Visible = true;
            LbText3.Visible = true;
            TbOrderExcelSucess.Visible = true;
            TbOrderExcelFault.Visible = true;
            try
            {
                var details = OrderB.ProcessOrdersFromExcel(TbFile.Text, CbbSheetNameFromExcel.Text, CurrentUser);
                TbOrderExcelFault.Text = details[0].ToString();
                TbOrderExcelSucess.Text = details[1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TbFileTextChanged(object sender, EventArgs e)
        {
            string filePath = TbFile.Text;
            // Kiểm tra file tồn tại
            if (!File.Exists(filePath))
            {
                CbbSheetNameFromExcel.Enabled = false;
                BtnGetDataExcel.Enabled = false;
                LbExcelWarning.Text = "Không tìm thấy file được chọn!";
                LbExcelWarning.Visible = true;
                return;
            }

            string ext = Path.GetExtension(filePath).ToLower();
            CbbSheetNameFromExcel.Items.Clear();

            // ✅ Nếu là file Excel: lấy danh sách sheet
            if (ext == ".xlsx" || ext == ".xls")
            {
                try
                {
                    List<string> sheetNames = ExcelHelper.GetSheetNames(filePath);

                    foreach (var name in sheetNames)
                    {
                        CbbSheetNameFromExcel.Items.Add(name);
                    }

                    if (sheetNames.Count > 0)
                        CbbSheetNameFromExcel.SelectedIndex = 0;

                    CbbSheetNameFromExcel.Enabled = true;
                    BtnGetDataExcel.Enabled = true;
                }
                catch (Exception ex)
                {
                    LbExcelWarning.Text = "Đang sử dụng file Excel!";
                    LbExcelWarning.Visible = true;
                }


            }
            // ✅ Nếu là file CSV: không có sheet, nhưng vẫn bật nút xử lý
            else if (ext == ".csv")
            {
                CbbSheetNameFromExcel.Enabled = false;
                CbbSheetNameFromExcel.Text = "";
                CbbSheetNameFromExcel.Enabled = false;

                // ✅ Bật nút xử lý sau khi kiểm tra OK
                BtnGetDataExcel.Enabled = true;
            }
            else
            {
                CbbSheetNameFromExcel.Enabled = false;
                CbbSheetNameFromExcel.Text = "";
                BtnGetDataExcel.Enabled = false;
            }

            LbExcelWarning.Visible = false;


        }

        private void BtnTestConnectionClick(object sender, EventArgs e)
        {
            try
            {
                SheetSyncHelper = new GoogleSheetSyncHelper(TbLinkGGSheet.Text, TbSheetName.Text);
                BtnSyncNow.Enabled = true;
                RJMessageBox.Show("Kết nối thành công!", "Thành công!");
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Kết nối thất bại: ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== Khởi tạo Worker =====================
        private void InitBackgroundWorker()
        {
            // Nếu đã khởi tạo rồi thì không cần khởi tạo lại
            if (SyncWorker != null) return;

            SyncWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            // Gắn các sự kiện xử lý
            SyncWorker.DoWork += SyncWorkerDoWork;
            SyncWorker.ProgressChanged += SyncWorkerProgressChanged;
            SyncWorker.RunWorkerCompleted += SyncWorkerRunWorkerCompleted;
        }

        // ===================== Helper functions =====================
        private void SetControlsEnabled(bool enabled)
        {
            BtnSyncNow.Enabled = enabled;
            BtnCancelSync.Enabled = !enabled;

            CbbSynchronizeTime.Enabled = enabled;
            TbLinkGGSheet.Enabled = enabled;
            TbSheetName.Enabled = enabled;
        }

        private void ResetCounters()
        {
            TbOrderSheetSuccess.Text = "0";
            TbOrderSheetFault.Text = "0";
        }

        // ===================== BtnSyncNowClick =====================
        private void BtnSyncNowClick(object sender, EventArgs e)
        {

            if (!SyncWorker.IsBusy)
            {
                SetControlsEnabled(false);
                ResetCounters();
                var syncConfig = new
                {
                    Minutes = int.Parse(CbbSynchronizeTime.Text),
                };
                SyncWorker.RunWorkerAsync(syncConfig);
            }
            else
            {
                RJMessageBox.Show("Đồng bộ đang chạy, vui lòng đợi hoàn tất hoặc hủy trước khi chạy lại.",
                                  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelSyncClick(object sender, EventArgs e)
        {
            if (SyncWorker != null && SyncWorker.IsBusy)
            {
                SyncWorker.CancelAsync();
            }
        }

        private void SyncWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var cfg = (dynamic)e.Argument;

            while (!worker.CancellationPending)
            {
                try
                {
                    // Lấy đơn hàng từ Google Sheets
                    var orders = SheetSyncHelper.GetOrderLines();

                    if (worker.CancellationPending) { e.Cancel = true; return; }

                    // Xử lý đơn hàng
                    var details = OrderB.ProcessOrders(orders, CurrentUser);
                    SheetSyncHelper.UpdateStatus(OrderB.GetDetailError());

                    if (worker.CancellationPending) { e.Cancel = true; return; }


                    // Báo kết quả về UI
                    worker.ReportProgress(0, details);
                }
                catch (Exception ex)
                {
                    // Báo lỗi về UI
                    worker.ReportProgress(0, ex);
                }

                int intervalMs = cfg.Minutes * 60 * 1000; // đổi phút → mili giây

                // Sleep có kiểm tra hủy mỗi 100ms
                for (int i = 0; i < intervalMs / 100; i++)
                {
                    if (worker.CancellationPending) { e.Cancel = true; return; }
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void SyncWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == null) return;

            if (e.UserState is Exception ex)
            {
                RJMessageBox.Show(ex.Message, "Đồng bộ thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.UserState is int[] details)
            {
                // Cộng dồn kết quả thay vì ghi đè
                int oldFault = int.TryParse(TbOrderSheetFault.Text, out int f) ? f : 0;
                int oldSuccess = int.TryParse(TbOrderSheetSuccess.Text, out int s) ? s : 0;

                TbOrderSheetFault.Text = (oldFault + details[0]).ToString();
                TbOrderSheetSuccess.Text = (oldSuccess + details[1]).ToString();
                TbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void SyncWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                RJMessageBox.Show("Đồng bộ đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetControlsEnabled(true);
                // Dừng BackgroundWorker nếu phát sinh lỗi
                if (SyncWorker != null && SyncWorker.IsBusy)
                {
                    SyncWorker.CancelAsync();
                }
            }

            SetControlsEnabled(true);
        }

        private void CollectDataFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (SyncWorker != null && SyncWorker.IsBusy)
            {
                SyncWorker.CancelAsync();
            }
        }

        private void BtnCopyClick(object sender, EventArgs e)
        {
            Clipboard.SetText(TbEmailClientInformation.Text);
        }

        private void TbLinkGGSheetTextChanged(object sender, EventArgs e)
        {
            BtnTestConnection.Enabled = true;
            BtnSyncNow.Enabled = false;
            BtnCancelSync.Enabled = false;
        }

        private void BtnAddProductClick(object sender, EventArgs e)
        {
            BtnAddProduct.BackColor = Color.FromArgb(196, 238, 181);
            BtnAddProduct.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
            BtnAddPackage.BackColor = Color.White;
            BtnAddPackage.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Regular);

            LbProductName.Visible = true;
            TbProductName.Visible = true;
            LbQuantity.Visible = true;
            TbQuantity.Visible = true;

            LbPackageID.Visible = false;
            TbPackageID.Visible = false;
        }

        private void BtnAddPackageClick(object sender, EventArgs e)
        {
            BtnAddProduct.BackColor = Color.White;
            BtnAddProduct.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Regular);
            BtnAddPackage.BackColor = Color.FromArgb(196, 238, 181); ;
            BtnAddPackage.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);

            LbProductName.Visible = false;
            TbProductName.Visible = false;
            LbQuantity.Visible = false;
            TbQuantity.Visible = false;

            LbPackageID.Visible = true;
            TbPackageID.Visible = true;
        }

        private void TbProductNameLeave(object sender, EventArgs e)
        {
            // Nếu focus không chuyển sang ListBox (tức là click chỗ khác)
            if (!LbSuggestions.Focused)
            {
                LbSuggestions.Visible = false;
            }
        }

        private void TbProductNameEnter(object sender, EventArgs e)
        {
            TbProductNameTextChanged(sender, e); 
        }
    }
}