using DocumentFormat.OpenXml.Wordprocessing;
using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EcosystemApp.GUI.ChildEmployeeForm
{
    public partial class EmployeeListForm : Form
    {
        private EmployeeBUS EmployeeBUS = new EmployeeBUS();
        private ShiftAssignmentBUS ShiftAssignmentBUS = new ShiftAssignmentBUS();
        private List<EmployeeDTO> CurrentEmployeeList = new List<EmployeeDTO>(); // Dùng cho tìm kiếm/lọc
        private List<ShiftAssignmentDTO> CurrentShiftList = new List<ShiftAssignmentDTO>();
        private SearchHelper SearchHelper = new SearchHelper();

        private string CurrentAction = ""; // "add" hoặc "edit"
        private string CurrentEmployeeID = ""; // Lưu ID của nhân viên đang sửa
        private int CurrentAssignmentID = 0;


        public EmployeeListForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadWorkShiftsToComboBox(); // load ca làm trước
            InitializeSortComboBox();
            LoadShiftList();            // sau khi WorkShift đã load
            InitializeShiftSortComboBox();
            LoadEmployeeToComboBox();
            TbEmployeeStation.Enabled = false;

            if (Program.CurrentUser.GetEmployee().GetPosition() == "Quản lý")
            {
                SetControlEnable(true);
                SetControlEnableShift(true);
                LoadEmployeeList();
                DateTimePicker1.Format = DateTimePickerFormat.Custom;
                DateTimePicker1.CustomFormat = "dd-MM-yyyy";

            }
            else
            {
                SetControlEnable(false);
                SetControlEnableShift(false);
                DateTimePicker1.Format = DateTimePickerFormat.Custom;
                DateTimePicker1.CustomFormat = "dd-MM-yyyy";

            }

        }
        private void SetControlEnable(bool enable)
        {   
            BtnAddEmployeeList.Enabled = enable;
            BtnUpdateEmployeeList.Enabled = enable;
            BtnDeleteEmployeeList.Enabled = enable;
            BtnSaveEmployeeInformations.Enabled = enable;
            BtnCancelEmployeeInformations.Enabled = enable;
        }
        private void SetControlEnableShift(bool enable)
        {
            BtnAddShift.Enabled = enable;
            BtnUpdateShift.Enabled = enable;
            BtnDeleteShift.Enabled = enable;
            BtnSave.Enabled = enable;
            BtnCancel.Enabled = enable;
        }
        private void InitializeSortComboBox()
        {
            CbSortBy.Items.Clear();
            CbSortBy.Items.Add("Tên (A-Z)");
            CbSortBy.Items.Add("Tên (Z-A)");
            CbSortBy.Items.Add("Mã NV");
            CbSortBy.Items.Add("Vị trí");
            CbSortBy.SelectedIndex = 0; // Mặc định chọn mục đầu
        }

        private void InitializeDataGridView()
        {
            //
            // Cấu hình DgvEmployeeList - Danh sách nhân viên
            //
            DgvEmployeeList.AutoGenerateColumns = false;
            DgvEmployeeList.Columns.Clear();

            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "STT" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã NV", Name = "EmployeeID" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày sinh", Name = "BirthDate" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", Name = "FullName" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SĐT", Name = "PhoneNum" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vị trí", Name = "Position" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", Name = "Email" });
            DgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạm", Name = "Station" });

            DgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEmployeeList.AllowUserToAddRows = false;
            DgvEmployeeList.ReadOnly = true;
            DgvEmployeeList.RowHeadersVisible = false;
            DgvEmployeeList.MultiSelect = false;

            DgvEmployeeList.SelectionChanged += DgvEmployeeListSelectionChanged;

            SetEmployeeInfoEnabled(false);



            //
            // Cấu hình DgvShiftList - Danh sách nhân viên
            //
            DgvShiftList.AutoGenerateColumns = false;
            DgvShiftList.Columns.Clear();

            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", Name = "STT" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã NV", Name = "EmployeeID" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ và tên", Name = "FullName" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ca làm", Name = "Shift" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày làm", Name = "WorkDate" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", Name = "Status" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ghi chú", Name = "Notes" });
            DgvShiftList.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "AssignmentID", Name = "AssignmentID", Visible = false });

            DgvShiftList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvShiftList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvShiftList.AllowUserToAddRows = false;
            DgvShiftList.ReadOnly = true;
            DgvShiftList.RowHeadersVisible = false;
            DgvShiftList.MultiSelect = false;
            DgvShiftList.SelectionChanged += DgvShiftListSelectionChanged;
            CbEmployeeID.SelectedIndexChanged += CbEmployeeIDSelectedIndexChanged;

            SetShiftInfoEnabled(false);
        }

        private void LoadEmployeeList()
        {
            CurrentEmployeeList = EmployeeBUS.GetEmployeeList();
            DisplayDgvEmployeeList(CurrentEmployeeList);
        }

        private void DisplayDgvEmployeeList(List<EmployeeDTO> list)
        {
            DgvEmployeeList.Rows.Clear();
            int stt = 1;
            foreach (var emp in list)
            {
                DgvEmployeeList.Rows.Add(
                    stt++,
                    emp.GetID(),
                    emp.GetDateOfBirth(),
                    emp.GetFullName(),
                    emp.GetPhoneNumber(),
                    emp.GetPosition(),
                    emp.GetEmail() ?? "",
                    emp.GetStation() != null ? emp.GetStation().GetID() : ""
                );
            }
        }

        private void DgvEmployeeListSelectionChanged(object sender, EventArgs e)
        {
            if (DgvEmployeeList.SelectedRows.Count == 0) return;

            var row = DgvEmployeeList.SelectedRows[0];
            CurrentEmployeeID = row.Cells["EmployeeID"].Value?.ToString();
            TbEmpFullName.Text = row.Cells["FullName"].Value?.ToString();
            TbBirthDate.Text = row.Cells["BirthDate"].Value?.ToString();
            TbEmployeePhone.Text = row.Cells["PhoneNum"].Value?.ToString();
            TbEmployeePosition.Text = row.Cells["Position"].Value?.ToString();
            TbEmployeeEmail.Text = row.Cells["Email"].Value?.ToString();
            TbEmployeeStation.Text = row.Cells["Station"].Value?.ToString();
        }
        private void CbEmployeeIDSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbEmployeeID.SelectedIndex < 0) return;

            string employeeID = CbEmployeeID.SelectedValue.ToString();   // Lấy ID đúng

            EmployeeBUS bus = new EmployeeBUS();
            var emp = bus.GetEmployeeByID(employeeID);  // Lấy nhân viên từ DB

            if (emp != null)
            {
                TbNameEmployeeShift.Text = emp.GetFullName();   // Hiển thị tên
            }
        }


        //======== Hàm bổ trợ ========
        //
        // DgvEmployeeList
        //
        private void SetEmployeeInfoEnabled(bool enabled)
        {
            TbEmpFullName.Enabled = enabled;
            TbBirthDate.Enabled = enabled;
            TbEmployeePhone.Enabled = enabled;
            TbEmployeePosition.Enabled = enabled;
            TbEmployeeEmail.Enabled = enabled;
            
        }

        private void ClearEmployeeInfo()
        {
            TbEmpFullName.Clear();
            TbBirthDate.Clear();
            TbEmployeePhone.Clear();
            TbEmployeePosition.Clear();
            TbEmployeeEmail.Clear();
            TbEmployeeStation.Clear();
        }

        //
        //DgvShiftList
        //
        private void SetShiftInfoEnabled(bool enabled)
        {
            TbNameEmployeeShift.Enabled = enabled;
            CbEmployeeID.Enabled = enabled;
            TbNote.Enabled = enabled;
            TbStatus.Enabled = enabled;
            CbShift.Enabled = enabled;
            DateTimePicker1.Enabled = enabled;
        }

        private void ClearShiftInfo()
        {
            TbNameEmployeeShift.Clear();
            CbEmployeeID.SelectedIndex = -1;
            TbNote.Clear();
            TbStatus.Clear();
            CbShift.SelectedIndex = -1;
        }
        //============================

        private void BtnAddEmployeeListClick(object sender, EventArgs e)
        {
            CurrentAction = "add";
            CurrentEmployeeID = "";
            ClearEmployeeInfo();
            SetEmployeeInfoEnabled(true);
        }

        private void BtnUpdateEmployeeListClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentEmployeeID))
            {
                RJMessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CurrentAction = "edit";
            SetEmployeeInfoEnabled(true);
        }


        private void BtnDeleteEmployeeListClick(object sender, EventArgs e)
        {
            if (DgvEmployeeList.CurrentRow == null || DgvEmployeeList.CurrentRow.Index < 0)
            {
                RJMessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string employeeID = DgvEmployeeList.CurrentRow.Cells["EmployeeID"].Value?.ToString();

            var confirm = RJMessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (EmployeeBUS.DeleteEmployee(employeeID))
            {
                LoadEmployeeList();
                ClearEmployeeInfo();
                RJMessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RJMessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelEmployeeInformationsClick(object sender, EventArgs e)
        {
            CurrentAction = "";
            CurrentEmployeeID = "";
            ClearEmployeeInfo();
            SetEmployeeInfoEnabled(false);
        }

        private void BtnSaveEmployeeInformationsClick(object sender, EventArgs e)
        {
            string phone = TbEmployeePhone.Text.Trim();
            string birthday = TbBirthDate.Text.Trim();

            // Regex kiểm tra định dạng ngày
            string pattern = @"^(0?[1-9]|[12][0-9]|3[01])[-\/](0?[1-9]|1[0-2])[-\/](\d{4})$";

            if (!Regex.IsMatch(birthday, pattern))
            {
                RJMessageBox.Show("Ngày sinh phải đúng định dạng dd-MM-yyyy hoặc dd/MM/yyyy!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] formats = { "dd-MM-yyyy", "dd/MM/yyyy" };
            if (!Regex.IsMatch(phone, @"^\d{10,12}$"))
            {
                RJMessageBox.Show("Số điện thoại phải gồm 10 đến 12 chữ số và không chứa ký tự khác!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(TbEmpFullName.Text))
            {
                RJMessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StationBUS stationBUS = new StationBUS();
            string stationID = Program.CurrentUser.GetEmployee().GetStation().GetID();
            StationDTO station = stationBUS.GetStation(stationID);

            if (station == null)
            {
                RJMessageBox.Show("Mã trạm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeDTO emp = new EmployeeDTO();
            emp.SetFullName(TbEmpFullName.Text.Trim());
            emp.SetDateOfBirth(TbBirthDate.Text.Trim());
            emp.SetPhoneNumber(TbEmployeePhone.Text.Trim());
            emp.SetPosition(TbEmployeePosition.Text.Trim());
            emp.SetEmail(TbEmployeeEmail.Text.Trim());
            emp.SetStation(station);

            if (CurrentAction == "edit")
                emp.SetID(CurrentEmployeeID);

            bool success = false;
            if (CurrentAction == "add") success = EmployeeBUS.AddEmployee(emp);
            else if (CurrentAction == "edit") success = EmployeeBUS.UpdateEmployee(emp);

            if (success)
            {
                LoadEmployeeList();
                ClearEmployeeInfo();
                SetEmployeeInfoEnabled(false);
                CurrentAction = "";
                CurrentEmployeeID = "";
                RJMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RJMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====== BỔ SUNG: Tìm kiếm & Sắp xếp ======
        private List<EmployeeDTO> FilterEmployees(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return CurrentEmployeeList;

            // Sử dụng SearchHelper để lọc
            return SearchHelper.SearchEmployeesByKeyword(CurrentEmployeeList, keyword);
        }
        private List<EmployeeDTO> SortEmployees(List<EmployeeDTO> employees)
        {
            if (CbSortBy.SelectedItem == null) return employees;

            switch (CbSortBy.SelectedItem.ToString())
            {
                case "Tên (A-Z)":
                    return employees.OrderBy(e => e.GetFullName()).ToList();
                case "Tên (Z-A)":
                    return employees.OrderByDescending(e => e.GetFullName()).ToList();
                case "Mã NV":
                    return employees.OrderBy(e => e.GetID()).ToList();
                case "Vị trí":
                    return employees.OrderBy(e => e.GetPosition()).ToList();
                default:
                    return employees;
            }
        }
        private void TxtSearchTextChanged(object sender, EventArgs e)
        {
            string keyword = TbSearchEmployee.Text.Trim();
            var filtered = FilterEmployees(keyword);  // Search
            var sorted = SortEmployees(filtered);     // Sort
            DisplayDgvEmployeeList(sorted);
        }

        private void CboSortBySelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = TbSearchEmployee.Text.Trim();
            var filtered = FilterEmployees(keyword);  // Giữ keyword hiện tại
            var sorted = SortEmployees(filtered);     // Sort
            DisplayDgvEmployeeList(sorted);
        }

        private void BtnApplyEmployeeListFiltersClick(object sender, EventArgs e)
        {
            string keyword = TbSearchEmployee.Text.Trim();

            // Lọc và sắp xếp
            var filtered = FilterEmployees(keyword);
            var sorted = SortEmployees(filtered);

            // Hiển thị kết quả
            DisplayDgvEmployeeList(sorted);
        }

        private void BtnSearchEmployeeListClick(object sender, EventArgs e)
        {
            string keyword = TbSearchEmployee.Text.Trim();
            var filtered = FilterEmployees(keyword);
            var sorted = SortEmployees(filtered); // Nếu muốn sắp xếp theo lựa chọn combo

            DisplayDgvEmployeeList(sorted);
        }


        //======================================
        //======================================
        //======================================
        private void InitializeShiftSortComboBox()
        {
            CbShiftListFilters.Items.Clear();
            CbShiftListFilters.Items.Add("Tên (A-Z)");
            CbShiftListFilters.Items.Add("Tên (Z-A)");
            CbShiftListFilters.Items.Add("Mã NV");
            CbShiftListFilters.Items.Add("Ca làm");
            CbShiftListFilters.Items.Add("Ngày làm");
            CbShiftListFilters.Items.Add("Trạng thái");
            CbShiftListFilters.SelectedIndex = 0;
        }
        private List<ShiftAssignmentDTO> FilterShifts(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return CurrentShiftList;

            keyword = keyword.Trim().ToLower();

            return CurrentShiftList.Where(sa =>
                (sa.GetEmployee().GetFullName()?.ToLower().Contains(keyword) ?? false) ||
                (sa.GetEmployee().GetID()?.ToLower().Contains(keyword) ?? false) ||
                (sa.GetShift().GetShiftName()?.ToLower().Contains(keyword) ?? false) ||
                (sa.GetWorkDate()?.ToLower().Contains(keyword) ?? false) ||
                (sa.GetStatus()?.ToLower().Contains(keyword) ?? false)
            ).ToList();
        }
        private List<ShiftAssignmentDTO> SortShifts(List<ShiftAssignmentDTO> shifts)
        {
            if (CbShiftListFilters.SelectedItem == null) return shifts;

            switch (CbShiftListFilters.SelectedItem.ToString())
            {
                case "Tên (A-Z)":
                    return shifts.OrderBy(sa => sa.GetEmployee().GetFullName()).ToList();
                case "Tên (Z-A)":
                    return shifts.OrderByDescending(sa => sa.GetEmployee().GetFullName()).ToList();
                case "Mã NV":
                    return shifts.OrderBy(sa => sa.GetEmployee().GetID()).ToList();
                case "Ca làm":
                    return shifts.OrderBy(sa => sa.GetShift().GetShiftName()).ToList();
                case "Ngày làm":
                    return shifts.OrderBy(sa => sa.GetWorkDate()).ToList();
                case "Trạng thái":
                    return shifts.OrderBy(sa => sa.GetStatus()).ToList();
                default:
                    return shifts;
            }
        }


        private void BtnApplySortShiftClick(object sender, EventArgs e)
        {
            string keyword = TbSearchShift.Text.Trim();
            var filtered = FilterShifts(keyword);
            var sorted = SortShifts(filtered); // bây giờ dùng đúng ComboBox
            DisplayDgvShiftList(sorted);
        }

        private void BtnSearchShiftListClick(object sender, EventArgs e)
        {
            string keyword = TbSearchShift.Text.Trim();
            var filtered = FilterShifts(keyword);
            var sorted = SortShifts(filtered);
            DisplayDgvShiftList(sorted);
        }

        private void BtnPrintShiftClick(object sender, EventArgs e)
        {
            // Nút in - Tab Phân Công
        }

        private void BtnAddShiftClick(object sender, EventArgs e)
        {
            // Nút thêm - Tab Phân Công
            CurrentAction = "add";
            CurrentEmployeeID = "";
            ClearShiftInfo();
            SetShiftInfoEnabled(true);
            BtnUpdateShift.Enabled = false;
            BtnDeleteShift.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            TbNameEmployeeShift.Enabled = false;
        }

        private void BtnUpdateShiftClick(object sender, EventArgs e)
        {
            // Nút sửa - Tab Phân Công
            if (CurrentAssignmentID == 0)
            {
                RJMessageBox.Show("Vui lòng chọn dòng phân công để sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CurrentAction = "edit";
            SetShiftInfoEnabled(true);
            DateTimePicker1.Enabled = false; // không cho sửa ngày làm
            BtnAddShift.Enabled = false;
            BtnDeleteShift.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            TbNameEmployeeShift.Enabled = false;
            CbShift.Enabled = false;
        }


        private void BtnSaveClick(object sender, EventArgs e)
        {
            // Validate căn bản
            if (string.IsNullOrWhiteSpace(CbEmployeeID.SelectedValue?.ToString()))
            {
                RJMessageBox.Show("Mã nhân viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EmployeeBUS employeeBUS = new EmployeeBUS();
            WorkShiftBUS workShiftBUS = new WorkShiftBUS();
            ShiftAssignmentBUS shiftAssignmentBUS = new ShiftAssignmentBUS();

            EmployeeDTO emp = employeeBUS.GetEmployeeByID(CbEmployeeID.SelectedValue?.ToString());
            if (emp == null)
            {
                RJMessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CbShift.SelectedValue == null)
            {
                RJMessageBox.Show("Vui lòng chọn ca làm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int shiftID = Convert.ToInt32(CbShift.SelectedValue);
            WorkShiftDTO ws = workShiftBUS.GetWorkShiftByID(shiftID);
            if (ws == null)
            {
                RJMessageBox.Show("Ca làm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo DTO
            ShiftAssignmentDTO sa = new ShiftAssignmentDTO();
            sa.SetEmployee(emp);
            sa.SetShift(ws);
            sa.SetWorkDate(DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")); // Lưu chuẩn format
            sa.SetNote(TbNote.Text.Trim());
            sa.SetStatus(TbStatus.Text.Trim());

            bool success = false;
            if (CurrentAction == "add")
            {
                success = shiftAssignmentBUS.AddShiftAssignment(sa);
            }
            else if (CurrentAction == "edit")
            {
                // PHẢI SET AssignmentID vào DTO
                sa.SetAssignmentID(CurrentAssignmentID);

                success = shiftAssignmentBUS.UpdateShiftAssignment(sa);
            }
            if (success)
            {
                LoadShiftList();
                ClearShiftInfo();
                SetShiftInfoEnabled(false);

                CurrentAction = "";
                CurrentAssignmentID = 0;

                RJMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RJMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BtnAddShift.Enabled = true;
            BtnUpdateShift.Enabled = true;
            BtnDeleteShift.Enabled = true;
        }

        private void LoadShiftList()
        {
            // Load danh sách ca làm việc
            CurrentShiftList = ShiftAssignmentBUS.GetAllShiftAssignments();
            DisplayDgvShiftList(CurrentShiftList);
        }
        private void DisplayDgvShiftList(List<ShiftAssignmentDTO> list)
        {
            DgvShiftList.Rows.Clear();
            int stt = 1;
            foreach (var sa in list)
            {
                DgvShiftList.Rows.Add(
                    stt++,                     // STT
                    sa.GetEmployee().GetID(),   // EmployeeID
                    sa.GetEmployee().GetFullName(), // FullName
                    sa.GetShift().GetShiftName(),   // Shift
                    sa.GetWorkDate(),              // WorkDate
                    sa.GetStatus(),                // Status
                    sa.GetNote(),                   // Notes
                    sa.GetAssignmentID()
                );
            }
        }

        private void DgvShiftListSelectionChanged(object sender, EventArgs e)
        {
            if (DgvShiftList.SelectedRows.Count == 0) return;

            var row = DgvShiftList.SelectedRows[0];

            CurrentAssignmentID = Convert.ToInt32(row.Cells["AssignmentID"].Value);

            CbEmployeeID.Text = row.Cells["EmployeeID"].Value?.ToString();
            TbNameEmployeeShift.Text = row.Cells["FullName"].Value?.ToString();
            TbStatus.Text = row.Cells["Status"].Value?.ToString();
            TbNote.Text = row.Cells["Notes"].Value?.ToString();

            string shiftName = row.Cells["Shift"].Value?.ToString();

            // ComboBox đã bind sẵn với List<WorkShiftDTO>
            for (int i = 0; i < CbShift.Items.Count; i++)
            {
                var ws = CbShift.Items[i] as WorkShiftDTO;
                if (ws != null && ws.GetShiftName() == shiftName)
                {
                    CbShift.SelectedIndex = i; // Chọn ca tương ứng
                    break;
                }
            }

            CbShift.Enabled = false; 
        }

        private void LoadWorkShiftsToComboBox()
        {
            WorkShiftBUS workShiftBUS = new WorkShiftBUS();
            var shifts = workShiftBUS.GetAllWorkShift();
            var comboSource = shifts.Select(w => new {
                ID = w.GetID(),
                DisplayText = $"{w.GetShiftName()}"}
            ).ToList();

            CbShift.DataSource = comboSource;
            CbShift.DisplayMember = "DisplayText";   // Thuộc tính trong DTO
            CbShift.ValueMember = "ID";            // Thuộc tính ID trong DTO
            CbShift.SelectedIndex = -1;
            CbShift.DropDownStyle = ComboBoxStyle.DropDownList;
            CbShift.DropDownHeight = CbShift.Items.Count * CbShift.ItemHeight;
            CbShift.IntegralHeight = false;
        }

        private void LoadEmployeeToComboBox()
        {
            string stationID = Program.CurrentUser.GetEmployee().GetStation().GetID();
            EmployeeBUS employeeBUS = new EmployeeBUS();
            var employees = employeeBUS.GetEmployeeListByStation(stationID);
            //Giả sử bạn có một ComboBox tên là CbEmployee
            var comboSource = employees.Select(e => new
                                        {
                                            ID = e.GetID(),
                                            DisplayText = $"{e.GetID()} - {e.GetFullName()} - {e.GetPosition()}"}
                                        )
                                        .ToList();
            CbEmployeeID.DataSource = comboSource;
            CbEmployeeID.DisplayMember = "DisplayText";   // Thuộc tính trong DTO
            CbEmployeeID.ValueMember = "ID";            // Thuộc tính ID trong DTO
            CbEmployeeID.SelectedIndex = -1;
            CbEmployeeID.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEmployeeID.DropDownHeight = CbEmployeeID.Items.Count * CbEmployeeID.ItemHeight;
            CbEmployeeID.IntegralHeight = false;
        }
        private void BtnCancelClick(object sender, EventArgs e)
        {
            SetShiftInfoEnabled(false);
            ClearShiftInfo();
            BtnDeleteShift.Enabled = true;
            BtnAddShift.Enabled = true;
            BtnUpdateShift.Enabled = true;
        }

        private void BtnDeleteShiftClick(object sender, EventArgs e)
        {
            if (DgvShiftList.CurrentRow == null || DgvShiftList.CurrentRow.Index < 0)
            {
                RJMessageBox.Show("Vui lòng chọn một phân công để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy AssignmentID từ hàng được chọn
            int assignmentID = Convert.ToInt32(DgvShiftList.CurrentRow.Cells["AssignmentID"].Value);

            var confirm = RJMessageBox.Show("Bạn có chắc chắn muốn xóa phân công này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            // Gọi BUS để xóa
            bool success = ShiftAssignmentBUS.DeleteShiftAssignment(assignmentID);

            if (success)
            {
                LoadShiftList();          // Load lại danh sách sau khi xóa
                ClearShiftInfo();         // Xóa thông tin hiển thị
                SetShiftInfoEnabled(false);

                CurrentAssignmentID = 0;  // Reset biến theo dõi
                RJMessageBox.Show("Xóa phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RJMessageBox.Show("Xóa phân công thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
