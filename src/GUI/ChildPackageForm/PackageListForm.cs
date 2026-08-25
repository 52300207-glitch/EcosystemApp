using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.GUI.Components;
using System.Data;


namespace EcosystemApp.GUI.ChildPackageForm
{
    public partial class PackageListForm : Form
    {
        private RJButton? BtnCurrent;
        private new Form? ActiveForm;
        private EmployeeDTO? CurrentEmployee;
        private PackageBUS PackageBUS = new PackageBUS();
        private List<PackagingTypeDTO> AllPackagingType ;
        private List<PackageDTO> FilteredPackages = new List<PackageDTO>();

        // Pagination
        private int CurrentPage = 1;
        private int PageSize = 20;     // sẽ tính lại dựa theo kích thước màn hình
        private int TotalPage = 1;

        public PackageListForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        public PackageListForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
        }

        private void InitializeDefaultValues()
        {
            AllPackagingType = new PackagingTypeBUS().GetAllPackagingType();
            var items = AllPackagingType
                .Select(item => new
                {
                    Name = item.GetTypeName(),
                    ID = item.GetID()
                })
                .ToList();

            // Bind to ComboBox
            CbbFilterPackage.DataSource = items;       // assign the list
            CbbFilterPackage.DisplayMember = "Name";   // what is shown
            CbbFilterPackage.ValueMember = "ID";       // underlying value
            CbbFilterPackage.DropDownStyle = ComboBoxStyle.DropDownList;

            CbbFilterPackage.SelectedIndexChanged += CbbFilterPackageSelectedIndexChanged;
            SetupDgvPackageList();
            CbbFilterPackageSelectedIndexChanged(null, null);

        }

        private void SetupDgvPackageList()
        {
            DgvPackageList.ReadOnly = true;               // Không sửa
            DgvPackageList.AllowUserToAddRows = false;    // Không thêm hàng
            DgvPackageList.AllowUserToDeleteRows = false; // Không xóa hàng
            DgvPackageList.AllowUserToOrderColumns = false; // Không thay đổi thứ tự cột
            DgvPackageList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPackageList.MultiSelect = false;

            DgvPackageList.Columns.Clear();

            // --- Cột STT ---
            DataGridViewTextBoxColumn colIndex = new DataGridViewTextBoxColumn();
            colIndex.HeaderText = "STT";
            colIndex.Name = "STT";
            colIndex.Width = 50;
            colIndex.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Cột Mã bao bì ---
            DataGridViewTextBoxColumn colPackageID = new DataGridViewTextBoxColumn();
            colPackageID.HeaderText = "Mã serial bao bì";
            colPackageID.Name = "PackageID";
            colPackageID.DataPropertyName = "PackageID";
            colPackageID.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Cột Tên bao bì ---
            DataGridViewTextBoxColumn colPackageName = new DataGridViewTextBoxColumn();
            colPackageName.HeaderText = "Tên bao bì";
            colPackageName.Name = "PackageName";
            colPackageName.DataPropertyName = "PackageName";
            colPackageName.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Cột Tình trạng ---
            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.HeaderText = "Tình trạng";
            colStatus.Name = "Status";
            colStatus.DataPropertyName = "Status";
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Cột Số lần tái sử dụng ---
            DataGridViewTextBoxColumn colReuseCount = new DataGridViewTextBoxColumn();
            colReuseCount.HeaderText = "Số lần tái sử dụng";
            colReuseCount.Name = "ReuseCount";
            colReuseCount.DataPropertyName = "ReuseCount";
            colReuseCount.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Cột Số lần tái sử dụng ---
            DataGridViewTextBoxColumn colNote = new DataGridViewTextBoxColumn();
            colNote.HeaderText = "Ghi chú";
            colNote.Name = "Note";
            colNote.DataPropertyName = "Note";
            colNote.SortMode = DataGridViewColumnSortMode.NotSortable;

            DgvPackageList.Columns.AddRange(colIndex, colPackageID, colPackageName, colStatus, colReuseCount, colNote);

        }

        private void LoadPackageList()
        {
            if (FilteredPackages == null || FilteredPackages.Count == 0)
            {
                DgvPackageList.Rows.Clear();
                LbPageInfo.Text = "Trang 0 / 0";
                return;
            }

            // --- Tính tổng số trang ---
            TotalPage = (int)Math.Ceiling((double)FilteredPackages.Count / PageSize);
            if (TotalPage == 0) TotalPage = 1;
            if (CurrentPage > TotalPage) CurrentPage = TotalPage;

            LoadPackagePage();
        }

        private void LoadPackagePage()
        {

            DgvPackageList.Rows.Clear();

            int start = (CurrentPage - 1) * PageSize;
            var pageData = FilteredPackages.Skip(start).Take(PageSize).ToList();

            int stt = start + 1;

            foreach (var pkg in pageData)
            {
                DgvPackageList.Rows.Add(
                    stt,
                    pkg.GetSerialCode() ?? "",
                    pkg.GetPackagingType().GetTypeName() ?? "",
                    ConvertStatusToVietnamese(pkg.GetStatus()),
                    pkg.GetReuseCount(),
                    pkg.GetReuseCount() >= pkg.GetPackagingType().GetReuseLimit() ? "Đã quá số lần tái sử dụng" : ""
                );
                stt++;
            }

            // Cập nhật label
            LbPageInfo.Text = $"Trang {CurrentPage} / {TotalPage}";
        }

        private void CbbFilterPackageSelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chưa chọn hoặc không có value → reset danh sách
            if (CbbFilterPackage.SelectedIndex == -1 || CbbFilterPackage.SelectedValue == null)
            {
                FilteredPackages = new List<PackageDTO>();
                CurrentPage = 1;
                LoadPackageList();
                return;
            }

            // Lấy SelectedValue an toàn
            string packageTypeID = CbbFilterPackage.SelectedValue?.ToString();

            // Nếu vẫn null → reset
            if (string.IsNullOrEmpty(packageTypeID))
            {
                FilteredPackages = new List<PackageDTO>();
                CurrentPage = 1;
                LoadPackageList();
                return;
            }

            // Lấy danh sách theo loại gói
            FilteredPackages = PackageBUS.GetByPackageTypeID(packageTypeID);

            if (FilteredPackages == null)
                FilteredPackages = new List<PackageDTO>();

            CurrentPage = 1;
            LoadPackageList();
        }

        private string ConvertStatusToVietnamese(string status)
        {
            return status switch
            {
                "Available" => "Có sẵn",
                "InUse" => "Đang sử dụng",
                "Returned" => "Đã trả",
                "Broken" => "Hỏng",
                "Cleaning" => "Cần vệ sinh",
                _ => status
            };
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            var form = new AddPackageForm();
            form.ShowDialog();
            InitializeDefaultValues();
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn không
            if (DgvPackageList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy index của dòng được chọn
            //int selectedIndex = DgvPackageList.SelectedRows[0].Index;
            int selectedIndexOnPage = DgvPackageList.SelectedRows[0].Index;
            int selectedIndex = (CurrentPage - 1) * PageSize + selectedIndexOnPage;
            if (selectedIndex >= FilteredPackages.Count)
                return;

            // Lấy PackageDTO từ danh sách FilteredPackages theo index
            PackageDTO selectedPackage = FilteredPackages[selectedIndex];

            // Tạo form EditPackageForm và truyền dữ liệu
            var form = new EditPackageForm(selectedPackage);
            form.ShowDialog();

            // Nếu cần, sau khi đóng form Edit, refresh lại DataGridView
            CbbFilterPackageSelectedIndexChanged(null, null);
        }

        private void BtnPrevPageClick(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                LoadPackagePage();
            }
        }

        private void BtnNextPageClick(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPage)
            {
                CurrentPage++;
                LoadPackagePage();
            }
        }
    }
}
