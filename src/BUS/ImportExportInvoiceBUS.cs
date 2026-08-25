using DocumentFormat.OpenXml.Bibliography;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// Xử lý nghiệp vụ liên quan đến hóa đơn nhập/xuất kho.
    /// </summary>
    public class ImportExportInvoiceBUS
    {
        // Data Access Layer để thao tác với dữ liệu hóa đơn
        private readonly ImportExportInvoiceDAL IEInvoiceDAL = new ImportExportInvoiceDAL();

        // Constructor mặc định
        public ImportExportInvoiceBUS() { }

        /// <summary>
        /// Lưu hóa đơn nhập hoặc xuất kho dựa trên đơn hàng.
        /// </summary>
        /// <param name="order">Đơn hàng nguồn.</param>
        /// <param name="invoiceType">Loại hóa đơn (IMPORT/EXPORT).</param>
        /// <param name="note">Ghi chú hóa đơn.</param>
        public void Save(OrderDTO order, string invoiceType, string note)
        {
            // Sinh mã hóa đơn ngẫu nhiên
            string id = "Invoice" + Guid.NewGuid().ToString();
            DateTime date = DateTime.Now;

            // Lấy mã kho từ nhân viên xử lý đơn hàng
            string warehouseId = order.GetEmployee().GetStation().GetWarehouseID();

            List<InvoiceDetailDTO> invoiceDetails = new List<InvoiceDetailDTO>();

            // Thêm các sản phẩm vào chi tiết hóa đơn
            foreach (var o in order.GetOrderDetails())
            {
                InvoiceDetailDTO procduct = new InvoiceDetailDTO(Guid.NewGuid().ToString(), o.GetProduct(), o.GetQuantity(), o.GetToTalPrice());
                invoiceDetails.Add(procduct);
            }

            // Thêm bao bì (nếu có phí đặt cọc)
            foreach (var o in order.GetOrderPackagings())
            {
                if (o.GetTotalBill() != 0)
                {
                    InvoiceDetailDTO procduct = new InvoiceDetailDTO(Guid.NewGuid().ToString(), o.GetPackage(), o.GetPackage().GetPackagingType().GetDeposit());
                    invoiceDetails.Add(procduct);
                }
            }

            // Tạo hóa đơn nhập/xuất kho
            ImportExportInvoiceDTO iEInvoice = new ImportExportInvoiceDTO(id, date, invoiceDetails, invoiceType, warehouseId, note, order.GetTotalAmount());

            // Lưu vào database
            IEInvoiceDAL.Save(iEInvoice);
        }

        /// <summary>
        /// Xử lý thêm sản phẩm cho hóa đơn nhập kho.
        /// </summary>
        public ImportExportInvoiceDTO ProcessProductImportInvoice(ProductDTO filteredProduct, string productName,
            int productQuantity, decimal purchasePrice, ImportExportInvoiceDTO importInvoice)
        {
            // Nếu hóa đơn chưa được khởi tạo → tạo mới
            if (importInvoice == null)
            {
                string id = Guid.NewGuid().ToString();
                importInvoice = new ImportExportInvoiceDTO(id, DateTime.Now, new List<InvoiceDetailDTO>(), "IMPORT", null, "", 0);
            }

            // Tạo ID chi tiết
            string idDetail = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

            if (filteredProduct != null)
            {
                // Tạo chi tiết hóa đơn
                InvoiceDetailDTO detail = new InvoiceDetailDTO(idDetail, filteredProduct, productQuantity, purchasePrice);

                // Thêm vào hóa đơn
                importInvoice.GetInvoiceDetails().Add(detail);

                // Cập nhật tổng tiền
                UpdateTotalBill(importInvoice);

                return importInvoice;
            }

            throw new Exception("Sản phẩm không hợp lệ!");
        }

        /// <summary>
        /// Lưu hóa đơn nhập kho.
        /// </summary>
        public void SaveImportInvoice(ImportExportInvoiceDTO importInvoice, string note, string warehouseID)
        {
            importInvoice.SetNotes(note);
            importInvoice.SetWarhouseID(warehouseID);

            IEInvoiceDAL.SaveImportInvoice(importInvoice);
        }

        /// <summary>
        /// Cập nhật tổng tiền hóa đơn dựa trên chi tiết.
        /// </summary>
        private void UpdateTotalBill(ImportExportInvoiceDTO importInvoice)
        {
            decimal totalBill = 0;

            // Cộng tổng tiền của tất cả chi tiết
            totalBill = importInvoice.GetInvoiceDetails().Sum(p => p.GetTotalAmount());

            importInvoice.SetTotalBill(totalBill);
        }

        /// <summary>
        /// Lấy tất cả hóa đơn nhập/xuất từ database.
        /// </summary>
        public List<ImportExportInvoiceDTO> GetAll()
        {
            return IEInvoiceDAL.GetAll();
        }

        /// <summary>
        /// Xử lý nhập kho đối với bao bì.
        /// </summary>
        public ImportExportInvoiceDTO ProcessPackageImportInvoice(EmployeeDTO emp, PackageDTO package, decimal purchasePrice, ImportExportInvoiceDTO importInvoice)
        {
            // Lấy tồn kho hiện tại
            var inventories = new InventoryBUS().GetByWarehouseID(emp.GetStation().GetWarehouseID());

            // Nếu chưa có hóa đơn → tạo mới
            if (importInvoice == null)
            {
                string id = Guid.NewGuid().ToString();
                importInvoice = new ImportExportInvoiceDTO(id, DateTime.Now, new List<InvoiceDetailDTO>(), "IMPORT", null, "", 0);
            }

            // Kiểm tra trùng SerialCode trong chi tiết
            bool existed = importInvoice.GetInvoiceDetails()
                .Any(p => p.GetPackage() != null && p.GetPackage().GetSerialCode() == package.GetSerialCode());

            if (existed)
                throw new Exception("Bao bì đã tồn tại trong hóa đơn nhập kho!");

            // Bao bì không hợp lệ
            if (package == null)
                throw new Exception("Mã Serial và loại bao bì không trùng khớp");

            // Kiểm tra bao bì có đang tồn kho không
            var item = inventories.FirstOrDefault(item => item.GetPackage() != null ? item.GetPackage().GetSerialCode() == package.GetSerialCode() : false);

            if (item != null)
            {
                if (item.GetPackage() != null && item.GetStockQuantity() == 1)
                    throw new Exception("Sản phẩm đã có sẵn trong kho");
            }

            // Tạo chi tiết hóa đơn bao bì
            string idDetail = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss:fff");
            InvoiceDetailDTO detail = new InvoiceDetailDTO(idDetail, package, purchasePrice);

            // Thêm vào chi tiết hóa đơn
            importInvoice.GetInvoiceDetails().Add(detail);

            // Cập nhật tổng tiền
            UpdateTotalBill(importInvoice);

            return importInvoice;
        }

        /// <summary>
        /// Xử lý xuất kho đối với sản phẩm.
        /// </summary>
        public ImportExportInvoiceDTO ProcessProductExportInvoice(EmployeeDTO emp, string productName,
            int quantity, ImportExportInvoiceDTO exportInvoice)
        {
            // Nếu chưa có hóa đơn → tạo mới
            if (exportInvoice == null)
                exportInvoice = new ImportExportInvoiceDTO(Guid.NewGuid().ToString(), DateTime.Now, new List<InvoiceDetailDTO>(), "EXPORT", null, "", 0);

            // Lấy danh sách tồn kho
            var inventories = new InventoryBUS().GetByWarehouseID(emp.GetStation().GetWarehouseID());

            // Kiểm tra sản phẩm tồn kho
            var stockItem = inventories.FirstOrDefault(i => i.GetProduct() != null && i.GetProduct().GetName() == productName);

            if (stockItem == null)
                throw new Exception("Sản phẩm không tồn tại trong kho!");

            if (stockItem.GetStockQuantity() < quantity)
                throw new Exception("Sản phẩm không đủ trong kho!");

            // Tạo ID chi tiết và thêm vào hóa đơn
            string idDetail = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss:fff");
            exportInvoice.GetInvoiceDetails().Add(new InvoiceDetailDTO(idDetail, stockItem.GetProduct(), quantity, stockItem.GetProduct().GetSellingPrice() * quantity));

            // Cập nhật tổng tiền
            UpdateTotalBill(exportInvoice);

            return exportInvoice;
        }

        /// <summary>
        /// Xử lý xuất kho cho bao bì theo SerialCode.
        /// </summary>
        public ImportExportInvoiceDTO ProcessPackageExportInvoice(EmployeeDTO emp, string packageSerialCode, ImportExportInvoiceDTO exportInvoice)
        {
            var inventories = new InventoryBUS().GetByWarehouseID(emp.GetStation().GetWarehouseID());

            // Lấy bao bì từ kho
            var stockPackage = inventories.FirstOrDefault(i => i.GetPackage() != null && i.GetPackage().GetSerialCode() == packageSerialCode);

            if (exportInvoice == null)
                exportInvoice = new ImportExportInvoiceDTO(Guid.NewGuid().ToString(), DateTime.Now, new List<InvoiceDetailDTO>(), "EXPORT", null, "", 0);

            // Kiểm tra trùng dữ liệu trong chi tiết hóa đơn
            if (exportInvoice.GetInvoiceDetails().Any(d => d.GetPackage() != null && d.GetPackage().GetSerialCode() == stockPackage.GetPackage().GetSerialCode()))
                throw new Exception("Bao bì đã tồn tại trong hóa đơn xuất kho!");

            if (stockPackage == null)
                throw new Exception("Sản phẩm không tồn tại trong kho!");

            if (stockPackage.GetStockQuantity() == 0)
                throw new Exception("Sản phẩm không tồn tại trong kho!");

            // Tạo chi tiết hóa đơn
            string newID = Guid.NewGuid().ToString();
            string idDetail = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss:fff");
            exportInvoice.GetInvoiceDetails().Add(new InvoiceDetailDTO(idDetail, stockPackage.GetPackage(), stockPackage.GetPackage().GetPackagingType().GetDeposit()));

            // Cập nhật tổng tiền
            UpdateTotalBill(exportInvoice);

            return exportInvoice;
        }

        /// <summary>
        /// Lưu hóa đơn xuất kho.
        /// </summary>
        public void SaveExportInvoice(ImportExportInvoiceDTO importInvoice, string note, string warehouseID)
        {
            importInvoice.SetNotes(note);
            importInvoice.SetWarhouseID(warehouseID);

            IEInvoiceDAL.SaveImportInvoice(importInvoice);
        }
    }
}
