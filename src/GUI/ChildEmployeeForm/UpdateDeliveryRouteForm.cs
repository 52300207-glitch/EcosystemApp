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
    public partial class UpdateDeliveryRouteForm : Form
    {
        private DeliveryAssignmentDTO CurrentDelivery;
        private bool IsAdd = false;
        private bool IsEdit = false;
        public UpdateDeliveryRouteForm()
        {
            InitializeComponent();
            IsAdd = true;
            LoadRouteOrders();
            TextDeliveryAddress.Enabled = false;
            TextReceivingAddress.Enabled = false;
            TextStatus.Enabled = false;
            TextRouteDistance.Enabled = false;
            TextRouteTime.Enabled = false;

        }
        //Receiving = order address, Delivery = delivery address
        public UpdateDeliveryRouteForm(DeliveryAssignmentDTO deliveryAssignmentDTO)
        {
            InitializeComponent();
            CurrentDelivery = deliveryAssignmentDTO;
            IsEdit = true;
            ComboBoxOrderID.Text = deliveryAssignmentDTO.GetOrder().GetID();
            TextDeliveryAddress.Text = deliveryAssignmentDTO.GetOrder().GetDeliveryAddress(); // Giả sử note lưu địa chỉ giao
            TextReceivingAddress.Text = deliveryAssignmentDTO.GetOrder().GetOrderAddress(); // Cần lấy từ Order nếu có
            TextRouteEmpId.Text = deliveryAssignmentDTO.GetEmployeeID();
            TextRouteEmpId.Enabled = false;
            ComboBoxOrderID.Enabled = false;
            TextDeliveryAddress.Enabled = false;
            TextReceivingAddress.Enabled = false;
            TextRouteDistance.Enabled = false;
            TextRouteTime.Enabled = false;
        }

        private void SaveRouteInforClick(object sender, EventArgs e)
        {
            DeliveryAssignmentBUS deliveryBUS = new DeliveryAssignmentBUS();

            // Validate cơ bản
            if (string.IsNullOrWhiteSpace(TextRouteEmpId.Text))
            {
                RJMessageBox.Show("Mã nhân viên không được để trống!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsAdd)
            {
                // Tạo mới DTO
                DeliveryAssignmentDTO newAssignment = new DeliveryAssignmentDTO();
                EmployeeBUS empBUS = new EmployeeBUS();
                var emp = empBUS.GetEmployeeByID(TextRouteEmpId.Text.Trim());
                if (emp == null)
                {
                    RJMessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedOrderId = ComboBoxOrderID.SelectedValue?.ToString(); // nếu comboOrderId được Bind với ValueMember = "OrderID"
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
                newAssignment.SetEmployeeID(TextRouteEmpId.Text.Trim());
                newAssignment.SetStatus("Pending");
                //newAssignment.SetNote(textManageOrderStatus.Text.Trim());

                bool success = deliveryBUS.AssignDelivery(newAssignment);

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
                CurrentDelivery.SetStatus(deliveryBUS.ConvertStatusForDB(TextStatus.Text.Trim()));
                bool success = deliveryBUS.UpdateAssignmentStatus(CurrentDelivery);

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

        private void CancelRouteInforClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadRouteOrders()
        {
            if (Program.CurrentUser == null)
            {
                RJMessageBox.Show("Chưa có người dùng đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string stationID = Program.CurrentUser.GetEmployee().GetStation().GetID();

            OrderBUS orderBUS = new OrderBUS();
            var listOrdersDTO = orderBUS.GetPrepareOrdersByStation(stationID);

            // Chuyển thành anonymous object để ComboBox có thể bind
            var comboSource = listOrdersDTO
                .Select(o => new
                {
                    OrderID = o.GetID(),
                    DisplayText = $"{o.GetID()} - {o.GetOrderDate():yyyy/MM/dd} - {o.GetTotalAmount():C}"
                })
                .ToList();

            ComboBoxOrderID.DataSource = comboSource;
            ComboBoxOrderID.DisplayMember = "DisplayText"; // hiển thị thông tin
            ComboBoxOrderID.ValueMember = "OrderID";       // giá trị thực khi chọn
            ComboBoxOrderID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
