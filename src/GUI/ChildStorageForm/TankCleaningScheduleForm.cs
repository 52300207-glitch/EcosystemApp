using EcosystemApp.BUS;
using EcosystemApp.DTO;
using System.Data;

namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class TankCleaningScheduleForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private WarehouseBUS WarehouseBUS = new WarehouseBUS();
        private WarehouseCleaningBUS WarehouseCleaningBUS = new WarehouseCleaningBUS();
        private List<WarehouseCleaningDTO> CleaningJobs = new List<WarehouseCleaningDTO>();
        private List<WarehouseCleaningDTO> FilteredCleaningJob = new List<WarehouseCleaningDTO>();
        private List<WarehouseCleaningDTO> ChangedJobs = new List<WarehouseCleaningDTO>();

        public TankCleaningScheduleForm()
        {
            InitializeComponent();
        }

        public TankCleaningScheduleForm(EmployeeDTO employeeDTO) : this()
        {
            CurrentEmployee = employeeDTO;
            InitializeDefaultComponent();

        }


        private void InitializeDefaultComponent()
        {
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = true;
            // Giờ bắt đầu
            DtpTimeStart.Format = DateTimePickerFormat.Custom;
            DtpTimeStart.CustomFormat = "HH:mm";   // Chỉ hiển thị giờ và phút
            DtpTimeStart.ShowUpDown = true;         // Hiển thị spinbox, không hiện calendar

            // Giờ kết thúc
            DtpTimeEnd.Format = DateTimePickerFormat.Custom;
            DtpTimeEnd.CustomFormat = "HH:mm";
            DtpTimeEnd.ShowUpDown = true;

            var list = WarehouseBUS.GetAllWarehouse().Where(item => item.GetID() == CurrentEmployee.GetStation().GetWarehouseID())
                .Select(w => new { ID = w.GetID(), Name = w.GetName() })
                .ToList();

            // ComboBox 1
            CbbStorageName.DataSource = new List<object>(list);
            CbbStorageName.DisplayMember = "Name";
            CbbStorageName.ValueMember = "ID";
            CbbStorageName.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbStorageName.SelectedIndex = 0;
            CbbStorageName.Enabled = false;

            list = WarehouseBUS.GetAllWarehouse()
                .Select(w => new { ID = w.GetID(), Name = w.GetName() })
                .ToList();
            // ComboBox 2
            CbbWarehouseNames.DataSource = new List<object>(list);
            CbbWarehouseNames.DisplayMember = "Name";
            CbbWarehouseNames.ValueMember = "ID";
            CbbWarehouseNames.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbWarehouseNames.SelectedIndex = 0;

            DtpDateStart.Format = DateTimePickerFormat.Custom;
            DtpDateStart.CustomFormat = "dd/MM/yyyy";

            DtpDateEnd.Format = DateTimePickerFormat.Custom;
            DtpDateEnd.CustomFormat = "dd/MM/yyyy";
            //test

            SetupDgvTankCleaningSchedule();
            //ShowDataGridView();


        }

        // =======================
        // 🔹 Danh sách tạm chứa các job đã đổi trạng thái
        // =======================

        // =======================
        // 🔹 1. Setup DataGridView
        // =======================
        private void SetupDgvTankCleaningSchedule()
        {
            DgvTankCleaningSchedule.AutoGenerateColumns = false;
            DgvTankCleaningSchedule.AllowUserToAddRows = false;
            DgvTankCleaningSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvTankCleaningSchedule.MultiSelect = false;
            DgvTankCleaningSchedule.AllowUserToResizeRows = false;

            DgvTankCleaningSchedule.Columns.Clear();

            // --- 1. Cột Tên kho ---
            var colWarehouseName = new DataGridViewTextBoxColumn
            {
                Name = "TenKho",
                HeaderText = "Tên kho",
                DataPropertyName = "TenKho",
                Width = 150,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            // --- 2. Cột Lịch vệ sinh ---
            var colCleaningDate = new DataGridViewTextBoxColumn
            {
                Name = "LichVeSinh",
                HeaderText = "Lịch vệ sinh",
                DataPropertyName = "LichVeSinh",
                Width = 120,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            // --- 3. Cột Bắt đầu ---
            var colStart = new DataGridViewTextBoxColumn
            {
                Name = "BatDau",
                HeaderText = "Bắt đầu",
                DataPropertyName = "BatDau",
                Width = 100,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            // --- 4. Cột Kết thúc ---
            var colEnd = new DataGridViewTextBoxColumn
            {
                Name = "KetThuc",
                HeaderText = "Kết thúc",
                DataPropertyName = "KetThuc",
                Width = 100,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            // --- 5. Cột Trạng thái ---
            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                HeaderText = "Trạng thái",
                DataPropertyName = "TrangThai",
                Width = 120,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };

            DgvTankCleaningSchedule.Columns.AddRange(colWarehouseName, colCleaningDate, colStart, colEnd, colStatus);

            // Event click đổi trạng thái và lưu tạm



            BtnFilterClick(null, null);
            DgvTankCleaningSchedule.CellClick += DgvTankCleaningScheduleCellClick;
            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + 0;
        }

        // =======================
        // 🔹 2. Load dữ liệu hiển thị
        // =======================
        private void ShowDataGridView()
        {
            if (FilteredCleaningJob == null) return;

            // Lưu vị trí scroll và dòng đang chọn
            int firstDisplayed = DgvTankCleaningSchedule.FirstDisplayedScrollingRowIndex;
            int selectedRow = DgvTankCleaningSchedule.CurrentCell?.RowIndex ?? -1;


            string warehouseName = ((dynamic)CbbWarehouseNames.SelectedItem)?.Name ?? "";

            var dt = new DataTable();
            dt.Columns.Add("TenKho", typeof(string));
            dt.Columns.Add("LichVeSinh", typeof(DateTime));
            dt.Columns.Add("BatDau", typeof(TimeSpan));
            dt.Columns.Add("KetThuc", typeof(TimeSpan));
            dt.Columns.Add("TrangThai", typeof(string));

            foreach (var job in FilteredCleaningJob)
            {
                string status = job.GetCleaningSchedule().GetStatus().ToUpper() == "NEW" ? "Mới" : "Hoàn thành";
                DateTime start = job.GetCleaningSchedule().GetStartTime();
                DateTime end = job.GetCleaningSchedule().GetEndTime();

                dt.Rows.Add(
                    warehouseName,
                    job.GetCleaningSchedule().GetDate(),
                    start.TimeOfDay, // TimeSpan
                    end.TimeOfDay,   // TimeSpan
                    status
                );
            }

            DgvTankCleaningSchedule.DataSource = dt;

            // Format hiển thị
            DgvTankCleaningSchedule.Columns["LichVeSinh"].DefaultCellStyle.Format = "yyyy-MM-dd";
            DgvTankCleaningSchedule.Columns["BatDau"].DefaultCellStyle.Format = @"hh\:mm";
            DgvTankCleaningSchedule.Columns["KetThuc"].DefaultCellStyle.Format = @"hh\:mm";
            foreach (DataGridViewColumn col in DgvTankCleaningSchedule.Columns)
                col.ReadOnly = true;

        }

        private void DgvTankCleaningScheduleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BtnEdit.Enabled && !BtnDelete.Enabled)
            {
                if (e.RowIndex < 0) return;

                var row = DgvTankCleaningSchedule.Rows[e.RowIndex];
                string currentStatus = row.Cells["TrangThai"].Value?.ToString();
                string newStatus = (currentStatus == "Mới") ? "Hoàn thành" : "Mới";

                // Cập nhật trạng thái trong DataGridView
                row.Cells["TrangThai"].Value = newStatus;

                // Cập nhật danh sách tạm ChangedJobs
                if (e.RowIndex < FilteredCleaningJob.Count)
                {
                    var job = FilteredCleaningJob[e.RowIndex];
                    job.GetCleaningSchedule().SetStatus(newStatus == "Mới" ? "NEW" : "COMPLETE");

                    if (!ChangedJobs.Contains(job))
                        ChangedJobs.Add(job);
                }

                LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + ChangedJobs.Count;

                // Lưu vị trí scroll và ô đang chọn
                int firstDisplayedRow = DgvTankCleaningSchedule.FirstDisplayedScrollingRowIndex;
                int selectedRow = e.RowIndex;
                int selectedColumn = e.ColumnIndex;

                // Reload DataGridView
                ShowDataGridView();

                // Khôi phục scroll
                if (firstDisplayedRow >= 0 && firstDisplayedRow < DgvTankCleaningSchedule.Rows.Count)
                    DgvTankCleaningSchedule.FirstDisplayedScrollingRowIndex = firstDisplayedRow;

                // Khôi phục ô đang chọn
                if (selectedRow >= 0 && selectedRow < DgvTankCleaningSchedule.Rows.Count &&
                    selectedColumn >= 0 && selectedColumn < DgvTankCleaningSchedule.Columns.Count)
                {
                    DgvTankCleaningSchedule.CurrentCell = DgvTankCleaningSchedule.Rows[selectedRow].Cells[selectedColumn];
                }
            }



        }

        private void BtnCreateClick(object sender, EventArgs e)
        {
            if (BtnSave.Enabled == true)
            {
                RJMessageBox.Show("Bạn chưa lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime cleaningDate = DtpCleaningScheduleDate.Value.Date;
            DateTime startTime = DtpTimeStart.Value;
            DateTime endTime = DtpTimeEnd.Value;
            string warehouseId = CbbStorageName.SelectedValue.ToString();

            var schedule = WarehouseCleaningBUS.CreateNew(warehouseId, cleaningDate, startTime, endTime);
            WarehouseCleaningBUS.Save(schedule);
            BtnFilterClick(null, null);
        }

        private void BtnFilterClick(object sender, EventArgs e)
        {
            if(BtnSave.Enabled == true)
            {
                RJMessageBox.Show("Bạn chưa lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string warehouseId = CbbWarehouseNames.SelectedValue.ToString();
            CleaningJobs = WarehouseCleaningBUS.GetByWarehouseID(warehouseId);
            FilteredCleaningJob = WarehouseCleaningBUS.Filter(CleaningJobs, DtpDateStart.Value, DtpDateEnd.Value);
            ShowDataGridView();
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            if(CbbWarehouseNames.SelectedValue.ToString() != CurrentEmployee.GetStation().GetWarehouseID())
            {
                RJMessageBox.Show("Bạn không được thay đổi trạng thái ở kho này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCreate.Enabled = false;
            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + 0;
            LbEditedColumnNumber.Visible = true;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (DgvTankCleaningSchedule.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = RJMessageBox.Show("Bạn có chắc chắn muốn xóa hàng đã chọn?",
                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            var row = DgvTankCleaningSchedule.SelectedRows[0];
            int rowIndex = row.Index;

            if (rowIndex < FilteredCleaningJob.Count)
            {
                var jobToDelete = FilteredCleaningJob[rowIndex];
                WarehouseCleaningBUS.Delete(jobToDelete);
            }

            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + 0;
            LbEditedColumnNumber.Visible = false;
            BtnFilterClick(null, null);
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = true;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            WarehouseCleaningBUS.Update(ChangedJobs);

            RJMessageBox.Show($"Đã thay đổi trạng thái thành công!",
                "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ChangedJobs.Clear();
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = true;
            BtnCreate.Enabled = true;
            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + 0;
            LbEditedColumnNumber.Visible = false;
            ShowDataGridView();
        }

        private void CbbWarehouseNamesSelectedIndexChanged(object sender, EventArgs e)
        {
            BtnFilterClick(null, null);
        }
    }
}
