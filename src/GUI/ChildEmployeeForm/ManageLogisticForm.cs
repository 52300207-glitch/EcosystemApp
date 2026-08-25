using EcosystemApp.BUS;
using EcosystemApp.DTO;
using System.Data;
using ClosedXML.Excel;


namespace EcosystemApp.GUI.ChildEmployeeForm
{
    public partial class ManageLogisticForm : Form
    {
        //==========================
        //===== Thuộc tính lớp ===== 
        //==========================
        private EmployeeDTO CurrentUser;
        private EmployeeBUS EmployeeB = new EmployeeBUS();
        private PrepareAssignmentBUS PrepareAssignmentBUS = new PrepareAssignmentBUS();
        private DeliveryAssignmentBUS DeliveryAssignmentBUS = new DeliveryAssignmentBUS();
        private List<PrepareAssignmentDTO> PrepareAssignmentList = new List<PrepareAssignmentDTO>();
        private List<DeliveryAssignmentDTO> DeliveryAssignmentList = new List<DeliveryAssignmentDTO>();
        private List<DeliveryAssignmentDTO> FilteredDeliveryList = new List<DeliveryAssignmentDTO>();
        private List<PrepareAssignmentDTO> FilteredPrepareList = new List<PrepareAssignmentDTO>();


        private bool IsAdd = false;
        private bool IsEdit = false;

        //====================
        //===== Khởi tạo =====
        //====================
        public ManageLogisticForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadAssignData();
            LoadDeliveryRouteData();
            DisplayComboBoxFilters();
            if (Program.CurrentUser.GetEmployee().GetPosition() == "Quản lý")
            {
                SetEnableControls(true);

            }
            else
            {
                SetEnableControls(false);
            }
        }
        private void SetEnableControls(bool isEnabled)
        {
            BtnAddDeliveryEmp.Enabled = isEnabled;
            BtnUpdateDeliveryEmp.Enabled = isEnabled;
            BtnDeleteDeliveryEmp.Enabled = isEnabled;
            BtnAddDeliveryRoute.Enabled = isEnabled;
            BtnUpdateDeliveryRoute.Enabled = isEnabled;
            BtnDeleteDeliveryRoute.Enabled = isEnabled;
            BtnImportExcel.Enabled = isEnabled;
            ButExport.Enabled = isEnabled;
        }

        //======================================
        //===== Cấu hình mặc định cho form =====
        //======================================
        private void LoadAssignData()
        {
            PrepareAssignmentList = PrepareAssignmentBUS.GetAllPrepareAssignments();
            DisplayDgvLogisticEmployeeList(PrepareAssignmentList);
        }
        private void DisplayDgvLogisticEmployeeList(List<PrepareAssignmentDTO> list)
        {
            DgvLogisticEmployeeList.Rows.Clear();
            int stt = 1;
            foreach (var item in list)
            {
                DgvLogisticEmployeeList.Rows.Add(stt++,
                    item.GetEmployee().GetID(),
                    item.GetEmployee().GetFullName(),
                    item.GetOrder().GetID(),
                    item.GetNote()
                );
            }
        }
        private void LoadDeliveryRouteData()
        {
            DeliveryAssignmentList = DeliveryAssignmentBUS.GetAllAssignments();
            DisplayDgvDeliveryRoute(DeliveryAssignmentList);
        }
        private void DisplayDgvDeliveryRoute(List<DeliveryAssignmentDTO> list)
        {
            DgvDeliveryRoute.Rows.Clear();
            int stt = 1;

            foreach (var item in list)
            {
                // CHUYỂN STATUS TỪ DB → GUI
                string guiStatus = DeliveryAssignmentBUS.ConvertStatusForGUI(item.GetStatus());

                DgvDeliveryRoute.Rows.Add(
                    stt++,
                    item.GetOrder().GetID(),
                    item.GetEmployeeID(),
                    item.GetOrder().GetOrderAddress(),
                    item.GetOrder().GetDeliveryAddress(),
                    guiStatus
                );
            }
        }

        private void InitializeDataGridView()
        {
            DgvLogisticEmployeeList.AutoGenerateColumns = false;
            DgvLogisticEmployeeList.Columns.Clear();

            // Tạo cột STT
            DgvLogisticEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "STT" });
            DgvLogisticEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã nhân viên", Name = "EmployeeID" });
            DgvLogisticEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên nhân viên", Name = "EmployeeName" });
            DgvLogisticEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã đơn hàng", Name = "OrderID" });
            DgvLogisticEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ghi chú", Name = "Notes" });

            DgvLogisticEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLogisticEmployeeList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvLogisticEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvLogisticEmployeeList.AllowUserToAddRows = false;
            DgvLogisticEmployeeList.ReadOnly = true;
            DgvLogisticEmployeeList.RowHeadersVisible = false;
            DgvLogisticEmployeeList.MultiSelect = false;

            //============================== Cấu hình cho DgvDeliveryRoute ==============================
            DgvDeliveryRoute.AutoGenerateColumns = false;
            DgvDeliveryRoute.Columns.Clear();

            // Tạo cột STT
            DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "STT" });
            DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã đơn hàng", Name = "OrderID" });
            DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã nhân viên", Name = "EmployeeID" });
            DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Địa chỉ nhận", Name = "ReceivingAddress" });
            DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Địa chỉ giao", Name = "DeliveryAddress" });
            //DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quãng đường", Name = "Distance" });
            //DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thời gian", Name = "Time" });
            DgvDeliveryRoute.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", Name = "Status" });
            DgvDeliveryRoute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDeliveryRoute.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvDeliveryRoute.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDeliveryRoute.AllowUserToAddRows = false;
            DgvDeliveryRoute.ReadOnly = true;
            DgvDeliveryRoute.RowHeadersVisible = false;
            DgvDeliveryRoute.MultiSelect = false;

        }
        // ===== Nhấn nút Áp dụng =====
        private void ApplyManageLogisticClick(object sender, EventArgs e)
        {
            string filter = CbManageLogisticFilters.SelectedItem?.ToString();

            // --- PrepareAssignment ---
            if (FilteredPrepareList == null || FilteredPrepareList.Count == 0)
                FilteredPrepareList = PrepareAssignmentList;

            switch (filter)
            {
                case "OrderID (A-Z)":
                    FilteredPrepareList = FilteredPrepareList.OrderBy(x => x.GetOrder().GetID()).ToList();
                    break;
                case "OrderID (Z-A)":
                    FilteredPrepareList = FilteredPrepareList.OrderByDescending(x => x.GetOrder().GetID()).ToList();
                    break;
                case "EmployeeID":
                    FilteredPrepareList = FilteredPrepareList.OrderBy(x => x.GetEmployee().GetID()).ToList();
                    break;
            }

            DisplayDgvLogisticEmployeeList(FilteredPrepareList);

            // --- DeliveryAssignment ---
            if (FilteredDeliveryList == null || FilteredDeliveryList.Count == 0)
                FilteredDeliveryList = DeliveryAssignmentList;

            switch (filter)
            {
                case "OrderID (A-Z)":
                    FilteredDeliveryList = FilteredDeliveryList.OrderBy(x => x.GetOrder().GetID()).ToList();
                    break;
                case "OrderID (Z-A)":
                    FilteredDeliveryList = FilteredDeliveryList.OrderByDescending(x => x.GetOrder().GetID()).ToList();
                    break;
                case "EmployeeID":
                    FilteredDeliveryList = FilteredDeliveryList.OrderBy(x => x.GetEmployeeID()).ToList();
                    break;
                case "Status":
                    FilteredDeliveryList = FilteredDeliveryList.OrderBy(x => x.GetStatus()).ToList();
                    break;
                case "Address":
                    FilteredDeliveryList = FilteredDeliveryList.OrderBy(x => x.GetOrder().GetDeliveryAddress()).ToList();
                    break;
            }

            DisplayDgvDeliveryRoute(FilteredDeliveryList);
        }
        private void DisplayComboBoxFilters()
        {
            CbManageLogisticFilters.Items.Clear();
            CbManageLogisticFilters.Items.Add("OrderID (A-Z)");
            CbManageLogisticFilters.Items.Add("OrderID (Z-A)");
            CbManageLogisticFilters.Items.Add("EmployeeID");
            CbManageLogisticFilters.Items.Add("Status");
            CbManageLogisticFilters.Items.Add("Address");
            CbManageLogisticFilters.SelectedIndex = 0;
        }


        // ===== Nhấn nút Thêm - danh sách nhân viên giao hàng =====
        private void AddDeliveryEmpClick(object sender, EventArgs e)
        {
            UpdateDeliveryEmpForm collectForm = new UpdateDeliveryEmpForm();
            if (collectForm.ShowDialog() == DialogResult.OK)
            {
                LoadAssignData();   // Reload danh sách
            }
        }
        // ===== Nhấn nút sửa - danh sách nhân viên giao hàng =====
        private void UpdateDeliveryEmpClick(object sender, EventArgs e)
        {
            if (DgvLogisticEmployeeList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = DgvLogisticEmployeeList.SelectedRows[0].Index;
            var selectedPrepareAssignment = PrepareAssignmentList[selectedIndex];

            UpdateDeliveryEmpForm collectForm = new UpdateDeliveryEmpForm(selectedPrepareAssignment);
            collectForm.ShowDialog();
            LoadAssignData();
        }
        // ===== Nhấn nút Xóa - danh sách nhân viên giao hàng =====
        private void DeleteDeliveryEmpClick(object sender, EventArgs e)
        {
            if (DgvLogisticEmployeeList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo");
                return;
            }

            int index = DgvLogisticEmployeeList.SelectedRows[0].Index;
            string orderID = PrepareAssignmentList[index].GetOrder().GetID();

            var confirm = RJMessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phân công chuẩn bị của đơn {orderID}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool result = PrepareAssignmentBUS.DeletePrepareAssignment(orderID);

                if (result)
                {
                    RJMessageBox.Show("Xóa thành công!");
                    LoadAssignData();
                }
                else
                    RJMessageBox.Show("Xóa thất bại!", "Lỗi");
            }
        }
        // ===== Nhấn nút Thêm  - danh sách lọ trình giao hàng =====
        private void AddDeliveryRouteClick(object sender, EventArgs e)
        {
            UpdateDeliveryRouteForm collectForm = new UpdateDeliveryRouteForm();
            if (collectForm.ShowDialog() == DialogResult.OK)
            {
                LoadDeliveryRouteData();   // Reload danh sách
            }
        }
        // ===== Nhấn nút Sửa - danh sách lọ trình giao hàng =====
        private void UpdateDeliveryRouteClick(object sender, EventArgs e)
        {
            if (DgvLogisticEmployeeList.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = DgvDeliveryRoute.SelectedRows[0].Index;
            var selectedPrepareAssignment = DeliveryAssignmentList[selectedIndex];

            UpdateDeliveryRouteForm collectForm = new UpdateDeliveryRouteForm(selectedPrepareAssignment);
            collectForm.ShowDialog();
            LoadDeliveryRouteData();
        }
        // ===== Nhấn nút Xóa - danh sách lọ trình giao hàng =====
        private void DeleteDeliveryRouteClick(object sender, EventArgs e)
        {
            if (DgvDeliveryRoute.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo");
                return;
            }

            int index = DgvDeliveryRoute.SelectedRows[0].Index;
            string orderID = DeliveryAssignmentList[index].GetOrder().GetID();

            var confirm = RJMessageBox.Show(
                $"Bạn có chắc chắn muốn xóa lộ trình giao hàng của đơn {orderID}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool result = DeliveryAssignmentBUS.DeleteDeliveryAssignment(orderID);

                if (result)
                {
                    RJMessageBox.Show("Xóa thành công!");
                    LoadDeliveryRouteData();
                }
                else
                    RJMessageBox.Show("Xóa thất bại!", "Lỗi");
            }
        }

        private void BtnImportExcelClick(object sender, EventArgs e)
        {
            GetDeliveryRouteByExcel getDeliveryRouteByExcel = new GetDeliveryRouteByExcel();
            getDeliveryRouteByExcel.Show();
        }
        private void ExportDgvDeliveryRouteToExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File|*.xlsx";
            saveFileDialog.FileName = "PendingAssignments.xlsx";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // Lấy dữ liệu từ BUS
            DataTable dt = DeliveryAssignmentBUS.GetPendingAssignments();

            using (XLWorkbook wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("PendingAssignments");

                // ======== HEADER ========
                ws.Cell(1, 1).Value = "OrderID";
                ws.Cell(1, 2).Value = "EmployeeID";
                ws.Cell(1, 3).Value = "OrderAddress";
                ws.Cell(1, 4).Value = "DeliveryAddress";
                ws.Cell(1, 5).Value = "Status";

                for (int i = 1; i <= 5; i++)
                {
                    ws.Cell(1, i).Style.Font.Bold = true;
                    ws.Cell(1, i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }

                // ======== GHI DỮ LIỆU ========
                int rowIndex = 2;
                foreach (DataRow row in dt.Rows)
                {
                    ws.Cell(rowIndex, 1).Value = row["OrderID"].ToString();
                    ws.Cell(rowIndex, 2).Value = row["EmployeeID"].ToString();
                    ws.Cell(rowIndex, 3).Value = row["OrderAddress"].ToString();
                    ws.Cell(rowIndex, 4).Value = row["DeliveryAddress"].ToString();

                    // Sử dụng hàm map BUS để hiển thị trạng thái GUI
                    string dbStatus = row["Status"].ToString();
                    ws.Cell(rowIndex, 5).Value = DeliveryAssignmentBUS.ConvertStatusForGUI(dbStatus);

                    rowIndex++;
                }

                // Auto-fit cột cho đẹp
                ws.Columns().AdjustToContents();

                // Lưu file
                wb.SaveAs(saveFileDialog.FileName);
            }

            RJMessageBox.Show("Xuất Excel thành công!", "Thông báo");
        }


        private void ButExportClick(object sender, EventArgs e)
        {
            ExportDgvDeliveryRouteToExcel();
        }

        private void BtnSearchManageLogisticClick(object sender, EventArgs e)
        {
            string keyword = TbManageLogisticSearch.Text.Trim().ToLower();

            // --- PrepareAssignment ---
            FilteredPrepareList = string.IsNullOrWhiteSpace(keyword)
                ? PrepareAssignmentList
                : PrepareAssignmentList.Where(x =>
                    x.GetEmployee().GetID().ToLower().Contains(keyword) ||
                    x.GetEmployee().GetFullName().ToLower().Contains(keyword) ||
                    x.GetOrder().GetID().ToLower().Contains(keyword) ||
                    (!string.IsNullOrEmpty(x.GetNote()) && x.GetNote().ToLower().Contains(keyword))
                ).ToList();

            DisplayDgvLogisticEmployeeList(FilteredPrepareList);

            // --- DeliveryAssignment ---
            FilteredDeliveryList = string.IsNullOrWhiteSpace(keyword)
                ? DeliveryAssignmentList
                : DeliveryAssignmentList.Where(x =>
                    x.GetOrder().GetID().ToLower().Contains(keyword) ||
                    x.GetEmployeeID().ToLower().Contains(keyword) ||
                    x.GetOrder().GetOrderAddress().ToLower().Contains(keyword) ||
                    x.GetOrder().GetDeliveryAddress().ToLower().Contains(keyword) ||
                    DeliveryAssignmentBUS.ConvertStatusForGUI(x.GetStatus()).ToLower().Contains(keyword)
                ).ToList();

            DisplayDgvDeliveryRoute(FilteredDeliveryList);
        }

        private void BtnRefeshClick(object sender, EventArgs e)
        {
            LoadAssignData();
            LoadDeliveryRouteData();
        }
    }
}
