using System.Data;
using EcosystemApp.DTO;
using EcosystemApp.BUS;


namespace EcosystemApp.GUI.ChildPackageForm
{
    public partial class PackageRecallForm : Form
    {
        private List<PackageDTO> AllPackage;
        private List<OrderPackagingDTO> OrderPackagings = new List<OrderPackagingDTO>();
        private OrderPackagingBUS OrderPackagingBUS = new OrderPackagingBUS();
        private string WarehouseID;
        private List<InventoryDTO> Inventories = new List<InventoryDTO>();
        private InventoryBUS InventoryBUS = new InventoryBUS();
        public PackageRecallForm(List<PackageDTO> allPackage, string warehouseID)
        {
            InitializeComponent();
            AllPackage = allPackage;
            WarehouseID = warehouseID;
            Inventories = InventoryBUS.GetByWarehouseID(WarehouseID);
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // khởi tạo trạng thái thu hồi bao bì
            CbbStatus.Items.Add("Cần vệ sinh");
            CbbStatus.Items.Add("Hỏng");
            CbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            if (CbbStatus.Items.Count > 0)
            {
                CbbStatus.SelectedIndex = 0;
            }

            // Khởi tạo DataGridView
            DgvPackingRecallList.Columns.Clear();
            DgvPackingRecallList.Columns.Add("STT", "STT");
            DgvPackingRecallList.Columns.Add("PackageID", "Mã bao bì");
            DgvPackingRecallList.Columns.Add("PackageName", "Tên bao bì");
            DgvPackingRecallList.Columns.Add("RecallDate", "Ngày thu hồi");

            // Chỉ hiển thị, không chỉnh sửa
            DgvPackingRecallList.ReadOnly = true;                 // không sửa dữ liệu
            DgvPackingRecallList.AllowUserToAddRows = false;      // không cho thêm dòng
            DgvPackingRecallList.AllowUserToDeleteRows = false;   // không xóa dòng
            DgvPackingRecallList.AllowUserToOrderColumns = false; // không cho di chuyển cột

            // Không cho sắp xếp khi click header
            foreach (DataGridViewColumn column in DgvPackingRecallList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Tự động chỉnh cỡ cột vừa với DataGridView
            DgvPackingRecallList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load dữ liệu trang đầu
        }

        // Khi nhập text vào TbPackageID, hiện gợi ý
        
        private void BtnAddClick(object sender, EventArgs e)
        {
            string serialCode = TbPackageID.Text.Trim();


            // Tìm PackageDTO trong tồn kho nếu có trong tồn kho thì phải xét = 0
            // không thì chèn bình thường
            // trường hợp đem từ chai này qua chổ khác, trường hợp bao bì có sẵn trong kho, trường hợp không có sẵn trong kho

            PackageDTO package = AllPackage.FirstOrDefault(p => p.GetSerialCode() == serialCode && p.GetStatus().ToLower() == "inuse");
            foreach(var item in Inventories)
            {
                if(item.GetPackage() != null && item.GetPackage().GetSerialCode() == serialCode) {
                    if(item.GetStockQuantity() != 0)
                    {
                        RJMessageBox.Show("Bao bì đang có sẵn trong kho",
                                  "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else
                    {
                        package = item.GetPackage();
                        package.SetStatus(CbbStatus.Text == "Cần vệ sinh" ? "Cleaning" : "Broken");
                        break;
                    }
                        
                }
            }

            if (package == null)
            {
                RJMessageBox.Show("Bao bì không tồn tại hoặc chưa được sử dụng, không thể thu hồi!",
                                  "Lỗi mã bao bì", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            


            // Tạo OrderPackagingsDTO và thêm vào danh sách
            var orderPackaging = new OrderPackagingDTO("", package, "RETURN", DateTime.Now, package.GetPackagingType().GetDeposit());
            OrderPackagings.Add(orderPackaging);

            // Hiển thị lại DataGridView
            ShowPackingRecallList(OrderPackagings);

            // Reset TextBox và gợi ý
            TbPackageID.Clear();

        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn không
            if (DgvPackingRecallList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy index dòng được chọn
            int selectedIndex = DgvPackingRecallList.SelectedRows[0].Index;

            if (selectedIndex >= OrderPackagings.Count)
                return;

            // Xóa khỏi danh sách OrderPackagings
            OrderPackagings.RemoveAt(selectedIndex);

            // Hiển thị lại DataGridView, STT tự động cập nhật
            ShowPackingRecallList(OrderPackagings);
        }

        private void ShowPackingRecallList(List<OrderPackagingDTO> OrderPackagings)
        {
            DgvPackingRecallList.Rows.Clear();

            int stt = 1;
            foreach (var item in OrderPackagings)
            {
                string packageID = item.GetPackage().GetSerialCode();
                string packageName = item.GetPackage().GetPackagingType().GetTypeName();
                string recallDate = item.GetActionDate().ToString("dd/MM/yyyy");

                DgvPackingRecallList.Rows.Add(stt, packageID, packageName, recallDate);
                stt++;
            }
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if(OrderPackagings.Count <= 0)
            {
                RJMessageBox.Show("Không có bao bì nào cần thu hồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OrderPackagingBUS.SaveReturnOrderPackagings(OrderPackagings);
            InventoryBUS.UpdatePackageStockQuantity(OrderPackagings, WarehouseID);

            Close();
        }
    }
}
