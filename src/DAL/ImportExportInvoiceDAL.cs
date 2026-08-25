using System;
using System.Collections.Generic;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data.SQLite;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// DAL xử lý các thao tác liên quan đến hóa đơn nhập/xuất kho
    /// </summary>
    public class ImportExportInvoiceDAL
    {
        // Hỗ trợ thao tác với database
        private readonly DatabaseHelper Db = new DatabaseHelper();

        // DAL xử lý chi tiết hóa đơn
        private readonly InvoiceDetailDAL InvoiceDetailDAL = new InvoiceDetailDAL();

        /// <summary>
        /// Lưu hóa đơn nhập/xuất kho cùng chi tiết hóa đơn
        /// </summary>
        /// <param name="iEInvoice">Đối tượng ImportExportInvoiceDTO cần lưu</param>
        public void Save(ImportExportInvoiceDTO iEInvoice)
        {
            // Câu lệnh INSERT để thêm mới hóa đơn
            string sqlQuery = @"INSERT INTO ImportExportInvoice 
                                (InvoiceID, InvoiceDate, InvoiceType, WarehouseID, Notes, TotalBill) 
                                VALUES 
                                (@InvoiceID, @InvoiceDate, @InvoiceType, @WarehouseID, @Notes, @TotalBill)";

            // Thực thi INSERT hóa đơn
            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@InvoiceID", iEInvoice.GetID()),
                new SQLiteParameter("@InvoiceDate", iEInvoice.GetDate().ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@InvoiceType", iEInvoice.GetInvoiceType()),
                new SQLiteParameter("@WarehouseID", iEInvoice.GetWarehouseID()),
                new SQLiteParameter("@Notes", iEInvoice.GetNotes()),
                new SQLiteParameter("@TotalBill", iEInvoice.GetTotalBill())
            );

            // Lưu danh sách chi tiết hóa đơn
            InvoiceDetailDAL.SaveDetails(
                iEInvoice.GetInvoiceDetails(),
                iEInvoice.GetID(),
                iEInvoice.GetInvoiceType(),
                iEInvoice.GetWarehouseID()
            );
        }

        /// <summary>
        /// Lưu hóa đơn nhập kho (tách riêng nếu cần)
        /// </summary>
        /// <param name="iEInvoice">Đối tượng ImportExportInvoiceDTO</param>
        public void SaveImportInvoice(ImportExportInvoiceDTO iEInvoice)
        {
            // Thực chất giống Save(), lưu hóa đơn nhập
            string sqlQuery = @"INSERT INTO ImportExportInvoice 
                                (InvoiceID, InvoiceDate, InvoiceType, WarehouseID, Notes, TotalBill) 
                                VALUES 
                                (@InvoiceID, @InvoiceDate, @InvoiceType, @WarehouseID, @Notes, @TotalBill)";

            Db.ExecuteNonQuery(sqlQuery,
                new SQLiteParameter("@InvoiceID", iEInvoice.GetID()),
                new SQLiteParameter("@InvoiceDate", iEInvoice.GetDate().ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@InvoiceType", iEInvoice.GetInvoiceType()),
                new SQLiteParameter("@WarehouseID", iEInvoice.GetWarehouseID()),
                new SQLiteParameter("@Notes", iEInvoice.GetNotes()),
                new SQLiteParameter("@TotalBill", iEInvoice.GetTotalBill())
            );

            // Lưu chi tiết hóa đơn
            InvoiceDetailDAL.SaveDetails(
                iEInvoice.GetInvoiceDetails(),
                iEInvoice.GetID(),
                iEInvoice.GetInvoiceType(),
                iEInvoice.GetWarehouseID()
            );
        }

        /// <summary>
        /// Lấy toàn bộ hóa đơn nhập/xuất kho kèm chi tiết
        /// </summary>
        /// <returns>Danh sách ImportExportInvoiceDTO</returns>
        public List<ImportExportInvoiceDTO> GetAll()
        {
            List<ImportExportInvoiceDTO> invoices = new List<ImportExportInvoiceDTO>();

            // Lấy tất cả hóa đơn từ bảng ImportExportInvoice
            string sqlQuery = "SELECT * FROM ImportExportInvoice";
            var invoiceTable = Db.ExecuteQuery(sqlQuery);

            foreach (System.Data.DataRow row in invoiceTable.Rows)
            {
                string invoiceID = row["InvoiceID"].ToString();
                DateTime invoiceDate = DateTime.Parse(row["InvoiceDate"].ToString());
                string invoiceType = row["InvoiceType"].ToString();
                string warehouseID = row["WarehouseID"].ToString();
                string notes = row["Notes"].ToString();
                decimal totalBill = Convert.ToDecimal(row["TotalBill"]);

                // Lấy danh sách chi tiết hóa đơn
                List<InvoiceDetailDTO> details = InvoiceDetailDAL.GetByInvoiceID(invoiceID);

                // Tạo DTO hóa đơn
                ImportExportInvoiceDTO invoice = new ImportExportInvoiceDTO(
                    invoiceID,
                    invoiceDate,
                    details,
                    invoiceType,
                    warehouseID,
                    notes,
                    totalBill
                );

                invoices.Add(invoice);
            }

            return invoices;
        }
    }
}
