using DocumentFormat.OpenXml.Wordprocessing;
using EcosystemApp.BUS;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EcosystemApp.GUI.ChildPackageForm
{
    public partial class PackageCleaningForm : Form
    {
        private EmployeeDTO? CurrentEmployee;
        private List<PackagingCleaningDTO> AllPackagingCleaning;
        private List<PackagingCleaningDTO> FilteredPackagingCleaning = new List<PackagingCleaningDTO>();
        private List<PackagingCleaningDTO> ChosenPackaginCleanings = new List<PackagingCleaningDTO>();
        private List<PackagingTypeDTO> PackagingTypes = new List<PackagingTypeDTO>();
        private PackagingCleaningBUS PackagingCleaningBUS = new PackagingCleaningBUS();

        private InventoryBUS InventoryBUS = new InventoryBUS();
        private List<InventoryDTO> InventoriesByWarehouse = new List<InventoryDTO>();
        public PackageCleaningForm()
        {
            InitializeComponent();
        }

        public PackageCleaningForm(EmployeeDTO emp) : this()
        {
            CurrentEmployee = emp;
            InventoriesByWarehouse = InventoryBUS.GetByWarehouseID(emp.GetStation().GetWarehouseID());
            PackagingTypes = new PackagingTypeBUS().GetAllPackagingType();


            AllPackagingCleaning = PackagingCleaningBUS.GetAll();
            InitializeDefaultValue();
        }

        private void BtnFilterClick(object sender, EventArgs e)
        {
            if(BtnSave.Enabled == true)
            {
                RJMessageBox.Show("Bạn chưa lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string packageTypeNameID = CbbTypePackageName.SelectedValue?.ToString();
            DateTime dateStart = DtpDateStart.Value;
            DateTime dateEnd = DtpDateEnd.Value;
            AllPackagingCleaning = PackagingCleaningBUS.GetAll();
            FilteredPackagingCleaning = PackagingCleaningBUS.GetByPackageNameTypeInInventory(AllPackagingCleaning, packageTypeNameID, InventoriesByWarehouse, dateStart, dateEnd);
            RefeshPackageCleaningScheduleGrid();
        }


        private void BtnCreateClick(object sender, EventArgs e)
        {
            string packageTypeID = CbbPackageTypeName.SelectedValue.ToString();
            DateTime date = DtpCleaningScheduleDate.Value;
            DateTime timeStart = DtpTimeStart.Value;
            DateTime timeEnd = DtpTimeEnd.Value;

            PackagingCleaningBUS.SavePackageSchedules(packageTypeID, InventoriesByWarehouse, date, timeStart, timeEnd);
            BtnFilterClick(null, null);


        }

        private void SetupPackageCleaningScheduleGrid()
        {
            DgvPackageCleaningSchedule.ReadOnly = true;
            DgvPackageCleaningSchedule.AllowUserToAddRows = false;
            DgvPackageCleaningSchedule.AllowUserToDeleteRows = false;
            DgvPackageCleaningSchedule.AllowUserToOrderColumns = false;

            DataGridViewTextBoxColumn colPackagingName = new DataGridViewTextBoxColumn();
            colPackagingName.HeaderText = "Tên bao bì";
            colPackagingName.DataPropertyName = "PackageName";
            colPackagingName.Name = "PackageName";
            colPackagingName.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn colTypeID = new DataGridViewTextBoxColumn();
            colTypeID.HeaderText = "Mã serial bao bì";
            colTypeID.DataPropertyName = "PackageTypeID";
            colTypeID.Name = "PackageTypeID";
            colTypeID.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn colSchedule = new DataGridViewTextBoxColumn();
            colSchedule.HeaderText = "Lịch vệ sinh";
            colSchedule.DataPropertyName = "CleaningDate";
            colSchedule.Name = "CleaningDate";
            colSchedule.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn colStart = new DataGridViewTextBoxColumn();
            colStart.HeaderText = "Giờ bắt đầu";
            colStart.DataPropertyName = "StartTime";
            colStart.Name = "StartTime";
            colStart.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn colEnd = new DataGridViewTextBoxColumn();
            colEnd.HeaderText = "Giờ kết thúc";
            colEnd.DataPropertyName = "EndTime";
            colEnd.Name = "EndTime";
            colEnd.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.HeaderText = "Trạng thái";
            colStatus.DataPropertyName = "Status";
            colStatus.Name = "Status";   // QUAN TRỌNG
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;

            DgvPackageCleaningSchedule.Columns.AddRange(
                colPackagingName, colTypeID, colSchedule, colStart, colEnd, colStatus
            );

        }

        private void RefeshPackageCleaningScheduleGrid()
        {
            DgvPackageCleaningSchedule.Rows.Clear();

            foreach (var job in FilteredPackagingCleaning)
            {
                var pkg = job.GetPackage();
                var schedule = job.GetCleaningSchedule();

                if (pkg == null || schedule == null) continue;

                string packageName = pkg.GetPackagingType()?.GetTypeName() ?? "";
                string packageTypeID = pkg.GetSerialCode() ?? "";
                string cleanDate = schedule.GetDate().ToString("dd/MM/yyyy");
                string startTime = schedule.GetStartTime().ToString("HH:mm");
                string endTime = schedule.GetEndTime().ToString("HH:mm");
                string status = schedule.GetStatus() == "NEW" ? "Mới" : "Hoàn thành";

                DgvPackageCleaningSchedule.Rows.Add(
                    packageName,
                    packageTypeID,
                    cleanDate,
                    startTime,
                    endTime,
                    status
                );
            }
        }

        private void InitializeDefaultValue()
        {
            BtnCreate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            var items = PackagingTypes
                .Select(item => new
                {
                    Name = item.GetTypeName(),
                    ID = item.GetID()
                })
                .ToList();

            // Bind to ComboBox
            CbbTypePackageName.DataSource = items;       // assign the list
            CbbTypePackageName.DisplayMember = "Name";   // what is shown
            CbbTypePackageName.ValueMember = "ID";       // underlying value

            items = PackagingTypes
                .Select(item => new
                {
                    Name = item.GetTypeName(),
                    ID = item.GetID()
                })
                .ToList();

            // Bind to ComboBox
            CbbPackageTypeName.DataSource = items;       // assign the list
            CbbPackageTypeName.DisplayMember = "Name";   // what is shown
            CbbPackageTypeName.ValueMember = "ID";       // underlying value

            CbbPackageTypeName.DropDownStyle = ComboBoxStyle.DropDownList;
            CbbTypePackageName.DropDownStyle = ComboBoxStyle.DropDownList;

            // Chỉ chọn ngày
            DtpCleaningScheduleDate.Format = DateTimePickerFormat.Custom;
            DtpCleaningScheduleDate.CustomFormat = "dd/MM/yyyy";

            // Chỉ chọn giờ và phút
            DtpTimeStart.Format = DateTimePickerFormat.Custom;
            DtpTimeStart.CustomFormat = "HH:mm";
            DtpTimeStart.ShowUpDown = true; // dùng spin control thay vì dropdown calendar

            DtpTimeEnd.Format = DateTimePickerFormat.Custom;
            DtpTimeEnd.CustomFormat = "HH:mm";
            DtpTimeEnd.ShowUpDown = true;

            SetupPackageCleaningScheduleGrid();
            BtnFilterClick(null, null);


        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (DgvPackageCleaningSchedule.SelectedRows.Count == 0)
            {
                RJMessageBox.Show("Vui lòng chọn hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = RJMessageBox.Show("Bạn có chắc chắn muốn xóa hàng đã chọn?",
                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            var row = DgvPackageCleaningSchedule.SelectedRows[0];
            int rowIndex = row.Index;

            if (rowIndex < FilteredPackagingCleaning.Count)
            {
                var jobToDelete = FilteredPackagingCleaning[rowIndex];
                PackagingCleaningBUS.Delete(jobToDelete);
            }

            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + 0;
            LbEditedColumnNumber.Visible = false;
            BtnFilterClick(null, null);
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = true;
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnEdit.Enabled = false;

            LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: 0";
            LbEditedColumnNumber.Visible = true;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (ChosenPackaginCleanings == null)
            {
                RJMessageBox.Show("Bạn chưa chọn dòng nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PackagingCleaningBUS.Update(ChosenPackaginCleanings);
            ChosenPackaginCleanings.Clear();

            RJMessageBox.Show("Đã lưu thay đổi!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnEdit.Enabled = true;
            LbEditedColumnNumber.Visible= false;
            BtnFilterClick(null, null); // Load lại bảng
            
        }

        private void DgvPackageCleaningScheduleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!BtnEdit.Enabled && !BtnDelete.Enabled)
            {
                if (e.RowIndex < 0) return;

                var row = DgvPackageCleaningSchedule.Rows[e.RowIndex];
                string currentStatus = row.Cells["Status"].Value?.ToString();
                if(currentStatus == "Hoàn thành")
                {
                   RJMessageBox.Show("Công việc đã hoàn thành, không thể thay đổi trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string newStatus = "Hoàn thành";

                // Cập nhật trạng thái trong DataGridView
                row.Cells["Status"].Value = newStatus;

                // Cập nhật danh sách tạm ChangedJobs
                if (e.RowIndex < FilteredPackagingCleaning.Count)
                {
                    var job = FilteredPackagingCleaning[e.RowIndex];
                    job.GetCleaningSchedule().SetStatus(
                        newStatus == "Mới" ? "NEW" : "COMPLETE"
                    );

                    if (!ChosenPackaginCleanings.Contains(job))
                        ChosenPackaginCleanings.Add(job);
                }

                LbEditedColumnNumber.Text = "Số hàng đã chỉnh sửa: " + ChosenPackaginCleanings.Count;

                // ===== Lưu vị trí scroll và ô đang chọn =====
                int firstDisplayedRow = DgvPackageCleaningSchedule.FirstDisplayedScrollingRowIndex;
                int selectedRow = e.RowIndex;
                int selectedColumn = e.ColumnIndex;

                // ===== Reload lại DataGridView =====
                RefeshPackageCleaningScheduleGrid();

                // ===== Khôi phục scroll =====
                if (firstDisplayedRow >= 0 &&
                    firstDisplayedRow < DgvPackageCleaningSchedule.Rows.Count)
                {
                    DgvPackageCleaningSchedule.FirstDisplayedScrollingRowIndex = firstDisplayedRow;
                }

                // ===== Khôi phục ô đang chọn =====
                if (selectedRow >= 0 &&
                    selectedRow < DgvPackageCleaningSchedule.Rows.Count &&
                    selectedColumn >= 0 &&
                    selectedColumn < DgvPackageCleaningSchedule.Columns.Count)
                {
                    DgvPackageCleaningSchedule.CurrentCell =
                        DgvPackageCleaningSchedule.Rows[selectedRow].Cells[selectedColumn];
                }
            }
        }


    }
}
