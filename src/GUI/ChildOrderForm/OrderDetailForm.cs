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

namespace EcosystemApp.GUI.ChildOrderForm
{
    public partial class OrderDetailForm : Form
    {
        private OrderDTO Order;
        private OrderBUS OrderBUS;
        public OrderDetailForm(OrderDTO order, OrderBUS orderBUS)
        {
            InitializeComponent();
            Order = order;
            OrderBUS = orderBUS;
            // Xóa tất cả cột cũ trước (tránh bị nhân đôi khi gọi lại hàm nhiều lần)
            DgvProductListDetail.Columns.Clear();
            DgvProductListDetail.AllowUserToAddRows = false;

            TbCustomerName.Text = order.GetCustomer().GetFullName();
            TbEmail.Text = order.GetCustomer().GetEmail();
            TbAddress.Text = order.GetDeliveryAddress();
            TbPhoneNumber.Text = order.GetCustomer().GetPhoneNumber();
            TbTransactionType.Text = order.GetTransactionType() == "Cash".ToUpper() ? "Tiền mặt" : "Chuyển khoảng";

            TbOrderID.Text = order.GetID();
            TbOrderDay.Text = order.GetOrderDate().ToString("dd/MM/yyyy");
            TbStatus.Text = TranslateOrderStatus(order.GetStatus());

            TbCustomerName.Enabled = false;
            TbEmail.Enabled = false;
            TbAddress.Enabled = false;
            TbPhoneNumber.Enabled = false;
            TbTransactionType.Enabled = false;
            TbOrderDay.Enabled = false;
            TbOrderID.Enabled = false;
            TbStatus.Enabled = false;

            // Tạo cột STT
            var colNumber = new DataGridViewTextBoxColumn();
            colNumber.Name = "NumberColumn";
            colNumber.HeaderText = "STT";
            colNumber.Width = 50;
            colNumber.ReadOnly = true;
            DgvProductListDetail.Columns.Add(colNumber);

            // Tạo cột Mã sản phẩm
            var colID = new DataGridViewTextBoxColumn();
            colID.Name = "IDColumn";
            colID.HeaderText = "Mã sản phẩm";
            colID.Width = 80;
            colID.ReadOnly = true;
            DgvProductListDetail.Columns.Add(colID);

            // Tạo cột Tên sản phẩm
            var colName = new DataGridViewTextBoxColumn();
            colName.Name = "ProductNameColumn";
            colName.HeaderText = "Tên sản phẩm";
            colName.Width = 200;
            colName.ReadOnly = true;
            DgvProductListDetail.Columns.Add(colName);

            // Tạo cột Số lượng
            var colQuantity = new DataGridViewTextBoxColumn();
            colQuantity.Name = "QuantityColumn";
            colQuantity.HeaderText = "Số lượng";
            colQuantity.Width = 80;
            colQuantity.ReadOnly = true;
            DgvProductListDetail.Columns.Add(colQuantity);

            // Tạo cột Thành tiền
            var colTotalPrice = new DataGridViewTextBoxColumn();
            colTotalPrice.Name = "TotalPriceColumn";
            colTotalPrice.HeaderText = "Thành tiền";
            colTotalPrice.Width = 120;
            colTotalPrice.ReadOnly = true;
            DgvProductListDetail.Columns.Add(colTotalPrice);

        }

        private void OrderDetailFormLoad(object sender, EventArgs e)
        {
            ShowOrderDataGridView();
        }

        private void ShowOrderDataGridView()
        {
            if (Order != null)
            {
                DgvProductListDetail.Rows.Clear();
                foreach (DataRow row in OrderBUS.GetOrdersTable(Order).Rows)
                {
                    DgvProductListDetail.Rows.Add(
                        row["STT"],
                        row["Mã sản phẩm"],
                        row["Tên sản phẩm"],
                        row["Số lượng"],
                        row["Thành tiền"]
                    );
                }

                LbTotalPrice.Text = $"Tổng tiền {Order.GetTotalAmount().ToString("N0")}";
            }

        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private string TranslateOrderStatus(string status)
        {
            switch (status.ToLower())
            {
                case "new":
                    return "Mới";
                case "prepare":
                    return "Chuẩn bị";
                case "shipping":
                    return "Đang giao";
                case "complete":
                    return "Hoàn thành";
                case "recall package":
                    return "Thu hồi bao bì";
                default:
                    return "Không xác định";
            }
        }
    }
}
