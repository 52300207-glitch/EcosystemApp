using EcosystemApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    public class BackUpBUS
    {
        private TablesDAL Tables = new TablesDAL();
        public BackUpBUS() { }

        public List<String> GetTableNames()
        {
            return new List<string> {
                "CleaningSchedule", "Customer", "DeliveryAssignment",
                "Employee", "EmployeeKPI", "ImportExportInvoice", "Inventory",
                "InvoiceDetail", "OrderDetail", "OrderPackaging", "Orders",
                "Package", "PackagingCleaning", "PackagingType", "PrepareAssignment",
                "Product", "ShiftAssignment", "Station",
                "Warehouse", "WarehouseCleaning", "WorkShift"
            };
        }


        public List<DataTable> GetTablesForBackUp()
        {
            return Tables.GetTables(GetTableNames());
        }
    }
}
