using EcosystemApp.BUS;
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

namespace EcosystemApp.GUI.ChildEmployeeForm
{
    public partial class UpdateDeliveryEmpForm : Form
    {
        private PrepareAssignmentDTO CurrentAssignment;
        private bool IsAdd = false;
        private bool IsEdit = false; 
        public UpdateDeliveryEmpForm()
        {
            InitializeComponent();
            IsAdd = true;
            LoadNewOrders();
            TextDeliveryEmpName.Enabled = false;
        }
        public UpdateDeliveryEmpForm(PrepareAssignmentDTO prepareAssignmentDTO)
        {
            InitializeComponent();
            CurrentAssignment = prepareAssignmentDTO;
            IsEdit = true;

            TextDeliveyEmpId.Text = prepareAssignmentDTO.GetEmployee().GetID();
            TextDeliveryEmpName.Text = prepareAssignmentDTO.GetEmployee().GetFullName();
            ComboOrderID.Text = prepareAssignmentDTO.GetOrder().GetID();
            TextManageOrderStatus.Text = prepareAssignmentDTO.GetNote();
            ComboOrderID.Enabled = false;
            TextDeliveryEmpName.Enabled = false;
        }
        private void CancelDeliveryEmpInforClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveDeliveryEmpInforClick(object sender, EventArgs e)
        {
            PrepareAssignmentBUS prepareBUS = new PrepareAssignmentBUS();

            // Validate cơ bản
            if (string.IsNullOrWhiteSpace(TextDeliveyEmpId.Text))
            {
                RJMessageBox.Show("Mã nhân viên không được để trống!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsAdd)
            {
                // Tạo mới DTO
                PrepareAssignmentDTO newAssignment = new PrepareAssignmentDTO();
                EmployeeBUS empBUS = new EmployeeBUS();
                var emp = empBUS.GetEmployeeByID(TextDeliveyEmpId.Text.Trim());
                if (emp == null)
                {
                    RJMessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedOrderId = ComboOrderID.SelectedValue?.ToString(); // nếu comboOrderId được Bind với ValueMember = "OrderID"
                if (string.IsNullOrEmpty(selectedOrderId))
                {
                    RJMessageBox.Show("Vui lòng chọn đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                OrderBUS orderBUS = new OrderBUS();
                OrderDTO orderDTO = orderBUS.GetOrderByID(selectedOrderId);

                if (orderDTO == null)
                {
                    RJMessageBox.Show("Mã đơn hàng không hợp lệ hoặc chưa tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newAssignment.SetOrder(orderDTO);
                newAssignment.SetEmployee(emp);
                newAssignment.SetNote(TextManageOrderStatus.Text.Trim());

                bool success = prepareBUS.AddPrepareAssignment(newAssignment);

                if (success)
                {
                    RJMessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    RJMessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (IsEdit)
            {
                // Cập nhật DTO hiện tại
                CurrentAssignment.SetNote(TextManageOrderStatus.Text.Trim());

                bool success = prepareBUS.UpdatePrepareAssignment(CurrentAssignment);

                if (success)
                {
                    RJMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    RJMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadNewOrders()
        {
            if (Program.CurrentUser == null)
            {
                RJMessageBox.Show("Chưa có người dùng đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string stationID = Program.CurrentUser.GetEmployee().GetStation().GetID();

            OrderBUS orderBUS = new OrderBUS();
            var listOrdersDTO = orderBUS.GetNewOrdersByStation(stationID);

            // Chuyển thành anonymous object để ComboBox có thể bind
            var comboSource = listOrdersDTO
                .Select(o => new
                {
                    OrderID = o.GetID(),
                    DisplayText = $"{o.GetID()} - {o.GetOrderDate():yyyy/MM/dd} - {o.GetTotalAmount():C}"
                })
                .ToList();

            ComboOrderID.DataSource = comboSource;
            ComboOrderID.DisplayMember = "DisplayText"; // hiển thị thông tin
            ComboOrderID.ValueMember = "OrderID";       // giá trị thực khi chọn
            ComboOrderID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
