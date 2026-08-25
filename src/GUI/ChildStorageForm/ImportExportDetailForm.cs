using EcosystemApp.BUS;
using EcosystemApp.DTO;


namespace EcosystemApp.GUI.ChildStorageForm
{
    public partial class ImportExportDetailForm : Form
    {
        private ImportExportInvoiceDTO IEInvoiceDTO;
        private string Type;
        public ImportExportDetailForm(ImportExportInvoiceDTO iEInvoiceDTO, string type)
        {
            InitializeComponent();
            IEInvoiceDTO = iEInvoiceDTO;
            Type = type;
            string name = new WarehouseBUS().GetWarehouseByID(IEInvoiceDTO.GetWarehouseID()).GetName();

            //
            if (Type == "Import")
            {
                LbHeaderDetailView.Text = "Chi tiết phiếu nhập hàng";
                LbInvoiceID.Text = "Mã phiếu nhập";
                LbAddress.Text = "Kho nhập";
                LbInvoiceDate.Text = "Ngày nhập";
                TbInvoiceID.Text = IEInvoiceDTO.GetID();
                TbAddress.Text = name;
                TbDate.Text = IEInvoiceDTO.GetDate().ToString("dd/MM/yyyy");
                TbNote.Text = IEInvoiceDTO.GetNotes();
            }
            else
            {
                LbHeaderDetailView.Text = "Chi tiết phiếu xuất hàng";
                LbInvoiceID.Text = "Mã phiếu xuất";
                LbAddress.Text = "Kho Xuất";
                LbInvoiceDate.Text = "Ngày xuất";
                TbInvoiceID.Text = IEInvoiceDTO.GetID();
                TbAddress.Text = name;
                TbDate.Text = IEInvoiceDTO.GetDate().ToString("dd/MM/yyyy");
                TbNote.Text = IEInvoiceDTO.GetNotes();


            }
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


            ShowOrderDataGridView();

        }

        private void ShowOrderDataGridView()
        {

            List<InvoiceDetailDTO> invoiceDetails = IEInvoiceDTO.GetInvoiceDetails();
            DgvProductListDetail.Rows.Clear();
            int stt = 1;
            foreach (var detail in invoiceDetails)
            {
                int rowIndex = DgvProductListDetail.Rows.Add();
                DataGridViewRow row = DgvProductListDetail.Rows[rowIndex];
                row.Cells["NumberColumn"].Value = stt++;
                row.Cells["IDColumn"].Value = detail.GetProduct() != null ? detail.GetProduct().GetID() : detail.GetPackage().GetSerialCode();
                row.Cells["ProductNameColumn"].Value = detail.GetProduct() != null ? detail.GetProduct().GetName() : detail.GetPackage().GetPackagingType().GetTypeName();
                row.Cells["QuantityColumn"].Value = detail.GetQuantity();
                row.Cells["TotalPriceColumn"].Value = detail.GetTotalAmount().ToString("N0") + " đ";
            }

            LbTotalPrice.Text = "Tổng tiền: " + IEInvoiceDTO.GetTotalBill().ToString("N0") + " đ";
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
