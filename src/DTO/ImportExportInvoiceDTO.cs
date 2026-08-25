using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class ImportExportInvoiceDTO
    {
        private string ID;
        private DateTime Date;
        private string InvoiceType;
        private string WarehouseID;
        private string Notes;
        private List<InvoiceDetailDTO> Details;
        private decimal TotalBill;

        public ImportExportInvoiceDTO() { }
        public ImportExportInvoiceDTO(string id, DateTime date, List<InvoiceDetailDTO> details, string invoiceType, string warehouseID, string notes, decimal totalBill)
        {
            this.ID = id;
            this.Date = date;
            this.InvoiceType = invoiceType;
            this.WarehouseID = warehouseID;
            this.Notes = notes;
            this.Details = details;
            this.TotalBill = totalBill;

        }

        // getter và setter
        public string GetID() { return ID; }
        public DateTime GetDate() { return Date; }

        public string GetInvoiceType() { return InvoiceType; }

        public string GetWarehouseID() { return WarehouseID; }
        public string GetNotes() { return Notes; }
        public List<InvoiceDetailDTO> GetInvoiceDetails() { return Details; }


        public decimal GetTotalBill() { return TotalBill; }
        public void SetNotes(string notes) { Notes = notes; }
        public void SetTotalBill(decimal totalBill) { TotalBill = totalBill; }

        public void SetWarhouseID(string warehouseID) { WarehouseID = warehouseID; }
    }
}
