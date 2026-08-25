using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EcosystemApp.BUS
{
    public class OrderBUS
    {
        private readonly ProductBUS ProductBUS = new ProductBUS();
        private readonly OrderDAL OrderDAL = new OrderDAL();
        private readonly PackageBUS PackageBUS = new PackageBUS();
        private readonly CustomerBUS CusBUS = new CustomerBUS();
        private readonly ImportExportInvoiceBUS IEInvoiceBUS = new ImportExportInvoiceBUS();
        private readonly InventoryBUS InventoryBUS = new InventoryBUS();
        private List<string> DetailError = new List<string>();

        public OrderBUS() { }

        /// <summary>
        /// Xử lý đơn hàng: tạo mới hoặc cập nhật OrderDTO.
        /// Bao gồm thông tin khách hàng, sản phẩm, bao bì, loại giao dịch, số lượng, địa chỉ giao hàng.
        /// </summary>
        /// <param name="cus">Khách hàng thực hiện đơn hàng.</param>
        /// <param name="emp">Nhân viên tạo đơn hàng.</param>
        /// <param name="order">Đơn hàng hiện tại, có thể là null nếu tạo mới.</param>
        /// <param name="transactionType">Loại giao dịch (Tiền mặt hoặc Ngân hàng).</param>
        /// <param name="productName">Tên sản phẩm (null nếu đơn hàng chỉ có bao bì).</param>
        /// <param name="quantity">Số lượng sản phẩm (chuỗi).</param>
        /// <param name="packageSerialCode">Mã bao bì (null nếu đơn hàng chỉ có sản phẩm).</param>
        /// <param name="deliveryAddress">Địa chỉ giao hàng.</param>
        /// <returns>Đơn hàng đã xử lý (cập nhật hoặc mới).</returns>
        public OrderDTO ProcessOrder(CustomerDTO cus, EmployeeDTO emp, OrderDTO order, string transactionType, string productName, string quantity, string packageSerialCode, string deliveryAddress)
        {
            // Lấy tồn kho theo kho của nhân viên
            var inventories = InventoryBUS.GetByWarehouseID(emp.GetStation().GetWarehouseID());

            // Chuyển đổi loại giao dịch
            string changedTransactionType = transactionType == "Tiền mặt" ? "CASH" : "BANKING";

            // ==============================
            // TẠO ORDER MỚI (NẾU CHƯA TỒN TẠI)
            // ==============================
            if (order == null)
            {
                // Lấy khách hàng từ CSDL nếu đã tồn tại // có nên sửa lại tên không
                var existingCus = CusBUS.GetByPhoneNumber(cus.GetPhoneNumber());
                cus = existingCus ?? cus;

                // Tạo ID khách hàng nếu chưa có
                if (cus.GetID() == null)
                    cus.SetID("CUS" + Guid.NewGuid());

                order = new OrderDTO( "Order" + Guid.NewGuid(), DateTime.Now, changedTransactionType, cus, emp, null,                         // deliveryEmployeeID (tạm null)
                    "New", new List<OrderDetailDTO>(), new List<OrderPackagingDTO>(), deliveryAddress, emp.GetStation().GetAddress()
                );
            }

            // ==============================
            // UPDATE LẠI THÔNG TIN KHÁCH HÀNG + LOẠI GIAO DỊCH
            // ==============================
            var existingCus2 = CusBUS.GetByPhoneNumber(cus.GetPhoneNumber());
            cus = existingCus2 ?? cus;

            if (cus.GetID() == null)
                cus.SetID("CUS" + Guid.NewGuid());

            order.SetCustomer(cus);
            order.SetTransactionType(changedTransactionType);

            // ==============================
            // VALIDATE SỐ LƯỢNG (nếu <= 0 thì bỏ qua)
            // ==============================
            if (!int.TryParse(quantity, out int qty) || qty < 1)
                return order;

            // ==============================
            // XỬ LÝ SẢN PHẨM (NẾU CÓ)
            // ==============================
            if (productName != null)
            {
                //var product = ProductBUS.GetProductByName(productName);
                //if (product == null)
                //    throw new Exception("Tên sản phẩm không tồn tại!");

                // Kiểm tra tồn kho
                var stockItem = inventories.FirstOrDefault(i => i.GetProduct() != null && i.GetProduct().GetName() == productName);

                if (stockItem == null)
                    throw new Exception("Sản phẩm không tồn tại trong kho!");

                // Tìm sản phẩm đã có trong order chưa
                var existingDetail = order.GetOrderDetails()
                                          .FirstOrDefault(d => d.GetProduct().GetName() == productName);

                if (existingDetail == null)
                {
                    // Kiểm tra tồn kho đủ không
                    if (stockItem.GetStockQuantity() < qty)
                        throw new Exception("Sản phẩm không đủ trong kho!");

                    order.GetOrderDetails().Add(
                        new OrderDetailDTO(Guid.NewGuid().ToString(), stockItem.GetProduct(), qty)
                    );
                }
                else
                {
                    int newQuantity = existingDetail.GetQuantity() + qty;

                    if (stockItem.GetStockQuantity() < newQuantity)
                        throw new Exception("Sản phẩm không đủ trong kho!");

                    existingDetail.SetQuantity(newQuantity);
                    existingDetail.SetTotalPrice(newQuantity * existingDetail.GetProduct().GetSellingPrice());
                }
            }
            // ==============================
            // XỬ LÝ BAO BÌ (NẾU KHÔNG PHẢI SẢN PHẨM)
            // ==============================
            else
            {
                // Kiểm tra bao bì đã có trong đơn chưa
                if (!IsPackageExistInOrder(order, packageSerialCode))
                {

                    // Kiểm tra bao bì có trong kho không
                    var stockPackage = inventories.FirstOrDefault(i => i.GetPackage() != null && i.GetPackage().GetSerialCode() == packageSerialCode);

                    if (stockPackage == null)
                        throw new Exception("Sản phẩm không tồn tại trong kho!");

                    string newID = Guid.NewGuid().ToString();

                    // Xử lý trạng thái bao bì
                    string status = stockPackage.GetPackage().GetStatus().ToLower();

                    if (status == "inuse")
                    {
                        stockPackage.GetPackage().SetReuseCount(stockPackage.GetPackage().GetReuseCount() + 1);
                        order.GetOrderPackagings().Add(
                            new OrderPackagingDTO(newID, stockPackage.GetPackage(), "ISSUE", DateTime.Now, 0)
                        );
                    }
                    else if (status == "available" && stockPackage.GetStockQuantity() == 1)
                    {
                        stockPackage.GetPackage().SetStatus("InUse");
                        order.GetOrderPackagings().Add(new OrderPackagingDTO(newID, stockPackage.GetPackage(), "ISSUE",
                            DateTime.Now, stockPackage.GetPackage().GetPackagingType().GetDeposit()));
                    }
                    else
                    {
                        throw new Exception("Bao bì chưa sẵn sàng để sử dụng hoặc không tồn tại ở trong kho!");
                    }
                }
            }

            // ==============================
            // CẬP NHẬT TỔNG TIỀN
            // ==============================
            UpdateTotalAmount(order);

            return order;
        }

        /// <summary>
        /// Chuyển đổi OrderDTO thành DataTable để hiển thị trên giao diện hoặc báo cáo.
        /// </summary>
        /// <param name="order">Đơn hàng cần chuyển đổi.</param>
        /// <returns>DataTable chứa chi tiết sản phẩm và bao bì trong đơn hàng.</returns>
        public DataTable GetOrdersTable(OrderDTO order)
        {
            DataTable dt = new DataTable();

            // Khai báo các cột đúng như trong mẫu
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");

            if (order != null)
            {
                int stt = 1;
                foreach (var o in order.GetOrderDetails())
                {
                    string productID = o.GetProduct().GetID();
                    string productName = o.GetProduct().GetName();
                    string quantity = o.GetQuantity().ToString() + $" {o.GetProduct().GetUnit()}";
                    string totalPrice = o.GetToTalPrice().ToString("N0"); // format tiền tệ


                    dt.Rows.Add(stt, productID, productName, quantity, totalPrice);
                    stt++;
                }

                foreach (var o in order.GetOrderPackagings())
                {
                    string packageID = o.GetPackage().GetSerialCode();
                    string packageName = o.GetPackage().GetPackagingType().GetTypeName().ToString();
                    string totalPrice = o.GetTotalBill().ToString("N0");
                    dt.Rows.Add(stt, packageID, packageName, 1, totalPrice);
                    stt++;
                }
            }

            return dt;
        }

        /// <summary>
        /// Xóa sản phẩm hoặc bao bì khỏi đơn hàng theo ID và cập nhật lại tổng tiền.
        /// </summary>
        /// <param name="order">Đơn hàng cần chỉnh sửa.</param>
        /// <param name="id">ID của sản phẩm hoặc bao bì cần xóa.</param>
        /// <returns>Đơn hàng đã được cập nhật.</returns>
        public OrderDTO DeleteItemOrder(OrderDTO order, string id)
        {
            foreach (var o in order.GetOrderDetails())
            {
                if (o.GetProduct().GetID() == id)
                {
                    order.GetOrderDetails().Remove(o);
                    break;
                }
            }

            foreach (var o in order.GetOrderPackagings())
            {
                if (o.GetPackage().GetID() == id)
                {
                    order.GetOrderPackagings().Remove(o);
                    break;
                }
            }
            UpdateTotalAmount(order);
            return order;

        }

        /// <summary>
        /// Lưu đơn hàng vào cơ sở dữ liệu và tạo hóa đơn xuất kho.
        /// </summary>
        /// <param name="order">Đơn hàng cần lưu.</param>
        public void SaveOrder(OrderDTO order)
        {
            if (order != null)
            {
                OrderDAL.SaveOrder(order);
                IEInvoiceBUS.Save(order, "export".ToUpper(), "Xuất kho hóa đơn");
            }

        }

        /// <summary>
        /// Lấy danh sách đơn hàng theo bộ lọc ngày và trạng thái.
        /// </summary>
        /// <param name="startDate">Ngày bắt đầu lọc.</param>
        /// <param name="endDate">Ngày kết thúc lọc.</param>
        /// <param name="status">Trạng thái đơn hàng.</param>
        /// <returns>Danh sách OrderDTO thỏa mãn điều kiện.</returns>
        public List<OrderDTO> GetFilteredOrders(DateTime startDate, DateTime endDate, string status)
        {
            return OrderDAL.GetFilteredOrders(startDate, endDate, status);
        }

        /// <summary>
        /// Chuyển danh sách OrderDTO thành DataTable cho mục đích báo cáo.
        /// </summary>
        /// <param name="orders">Danh sách đơn hàng.</param>
        /// <returns>DataTable bao gồm STT, khách hàng, địa chỉ giao hàng, trạng thái và tổng tiền.</returns>
        public DataTable ConvertToDataTable(List<OrderDTO> orders)
        {
            DataTable dt = new DataTable();
            // Create a new DataTable.
            DataTable table = new DataTable();
            // set columns STT, Mã đơn, Khách hàng, Ngày tạo, trạng thái, tông tiền
            table.Columns.Add("STT");
            table.Columns.Add("Mã đơn hàng");
            table.Columns.Add("Khách hàng");
            table.Columns.Add("Địa chỉ giao");
            table.Columns.Add("Ngày đặt");
            table.Columns.Add("Trạng thái");
            table.Columns.Add("Tổng tiền");
            // add rows
            int count = 1;
            foreach (var order in orders)
            {
                table.Rows.Add(count++.ToString(), order.GetID(), order.GetCustomer()?.GetFullName(),
                    order.GetDeliveryAddress(), order.GetOrderDate(), order.GetStatus(), order.GetTotalAmount().ToString("N0"));
            }

            return table;
        }

        /// <summary>
        /// Đọc dữ liệu đơn hàng từ file Excel và xử lý.
        /// </summary>
        /// <param name="filePath">Đường dẫn file Excel.</param>
        /// <param name="sheetName">Tên sheet trong Excel.</param>
        /// <param name="emp">Nhân viên xử lý đơn hàng.</param>
        /// <returns>Mảng [số dòng lỗi, số dòng thành công].</returns>
        public int[] ProcessOrdersFromExcel(string filePath, string sheetName, EmployeeDTO emp)
        {
            try
            {
                ExcelHelper ExcelHelper = new ExcelHelper(filePath, sheetName);
                List<string> lines = ExcelHelper.ReadExcelLines();
                return ProcessOrders(lines, emp);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        /// <summary>
        /// Xử lý danh sách dòng dữ liệu đơn hàng.
        /// </summary>
        /// <param name="lines">Danh sách dòng dữ liệu từ Excel.</param>
        /// <param name="emp">Nhân viên xử lý đơn hàng.</param>
        /// <returns>Mảng [số dòng lỗi, số dòng thành công].</returns>
        public int[] ProcessOrders(List<string> lines, EmployeeDTO emp)
        {
            int wrongLines = 0;
            int successLines = 0;
            DetailError.Clear();
            foreach (var line in lines)
            {
                try
                {
                    // tao excel moi roi lam tiep
                    string[] parts = line.Split(',');
                    string customerName = parts[0].Trim();
                    string customerPhone = parts[1].Trim();
                    string deliveryAddress = parts[2].Trim();
                    string[] productNames = parts[3].Trim().Split(";");
                    string[] quantityStr = parts[4].Trim().Split(";");
                    string[] packageIDs = parts[5].Trim().Split(";");
                    string transactionType = parts[6].Trim();

                    if (productNames.Length == quantityStr.Length)
                    {
                        try
                        {
                            // create customer
                            CustomerDTO cus = new CustomerDTO();
                            cus.SetFullName(customerName);
                            cus.SetPhoneNumber(customerPhone);

                            OrderDTO order = null;
                            for (int i = 0; i < productNames.Length; i++)
                            {
                                // create order
                                order = ProcessOrder(cus, emp, order, transactionType,
                                    productNames[i].Trim(), quantityStr[i].Trim(), null, deliveryAddress);


                            }

                            for (int i = 0; i < packageIDs.Length; i++)
                            {
                                order = ProcessOrder(cus, emp, order, transactionType,
                                    null, "1", packageIDs[i], deliveryAddress);
                            }
                            // save order
                            SaveOrder(order);
                            successLines++;
                            DetailError.Add("Thành công!");
                        }
                        catch (Exception ex)
                        {
                            wrongLines++;
                            DetailError.Add(ex.Message);
                        }
                    }
                    else
                    {
                        wrongLines++;
                        DetailError.Add("Lỗi sản phẩm và số lượng không khớp");
                    }
                }
                catch (Exception ex)
                {
                    wrongLines++;
                    DetailError.Add(ex.Message);

                }

            }
            return new int[] { wrongLines, successLines };
        }

        /// <summary>
        /// Cập nhật tổng tiền của đơn hàng dựa trên chi tiết sản phẩm và bao bì.
        /// </summary>
        /// <param name="order">Đơn hàng cần cập nhật tổng tiền.</param>
        private void UpdateTotalAmount(OrderDTO order)
        {
            decimal totalAmount = order.GetOrderDetails().Sum(o => o.GetToTalPrice()) +
                order.GetOrderPackagings().Sum(o => o.GetTotalBill());
            order.SetTotalAmount(totalAmount);
        }

        /// <summary>
        /// Kiểm tra bao bì đã tồn tại trong đơn hàng chưa theo ID.
        /// </summary>
        /// <param name="order">Đơn hàng cần kiểm tra.</param>
        /// <param name="packageID">ID bao bì.</param>
        /// <returns>True nếu đã tồn tại, false nếu chưa.</returns>
        private bool IsPackageExistInOrder(OrderDTO order, string packageID)
        {
            bool isExisted = false;
            foreach (var orderPackaging in order.GetOrderPackagings())
            {
                if (orderPackaging.GetPackage() != null)
                {
                    isExisted = orderPackaging.GetPackage().GetSerialCode().Equals(packageID);

                }
            }
            return isExisted;
        }

        /// <summary>
        /// Xóa đơn hàng khỏi cơ sở dữ liệu theo OrderID.
        /// </summary>
        /// <param name="orderID">ID của đơn hàng cần xóa.</param>
        public void DeleteOrder(string orderID)
        {
            OrderDAL.DeleteOrder(orderID);
        }

        /// <summary>
        /// Nhóm khách hàng theo số lần refill và chuyển sang dictionary.
        /// </summary>
        /// <param name="dt">DataTable chứa thông tin khách hàng và số lần refill.</param>
        /// <returns>Dictionary với key là nhóm refill, value là số lượng khách hàng.</returns>
        public Dictionary<string, decimal> GroupCustomerRefillToDict(DataTable dt)
        {
            Dictionary<string, decimal> groups = new Dictionary<string, decimal>()
            {
                { "1", 0 },
                { "2 - 5", 0 },
                { "6 - 10", 0 },
                { "11 - 20", 0 },
                { "20+", 0 },
            };

            foreach (DataRow row in dt.Rows)
            {
                int refill = Convert.ToInt32(row["RefillCount"]);
                string groupName = "1";

                if (refill >= 2 && refill <= 5)
                    groupName = "2 - 5";
                else if (refill >= 6 && refill <= 10)
                    groupName = "6 - 10";
                else if (refill > 10 && refill <= 20)
                    groupName = "11 - 20";
                else if (refill > 20)
                    groupName = "20+";

                groups[groupName]++;
            }

            return groups;
        }

        /// <summary>
        /// Lấy tần suất refill của khách hàng theo ngày và loại đơn hàng.
        /// </summary>
        /// <param name="date">Ngày thống kê.</param>
        /// <param name="type">Loại đơn hàng (sản phẩm/bao bì).</param>
        /// <returns>DataTable chứa số lần refill theo khách hàng.</returns>
        public DataTable GetCustomerRefillFrequency(DateTime date, string type)
        {
            return OrderDAL.GetCustomerRefillFrequency(date, type);
        }

        /// <summary>
        /// Tổng hợp thông tin tần suất đặt hàng của khách hàng.
        /// </summary>
        /// <param name="dtCustomer">DataTable chứa số lần refill theo khách hàng.</param>
        /// <returns>DataTable tổng hợp với tổng khách hàng, khách quay lại, trung bình và tỷ lệ %.</returns>
        public DataTable GetCustomerRefillSummary(DataTable dtCustomer)
        {
            // Lấy dữ liệu từng khách hàng

            // Tổng số khách hàng (tất cả khách duy nhất)
            int totalCustomers = dtCustomer.Rows.Count;

            // Tần suất đặt hàng trung bình (AvgOrdersPerCustomer)
            // Công thức: Tổng số đơn / tổng số khách
            double sumRefill = dtCustomer.AsEnumerable()
                    .Where(r => r["RefillCount"] != DBNull.Value)
                    .Sum(r => Convert.ToDouble(r["RefillCount"]) + 1);

            double avgOrders = totalCustomers > 0 ? sumRefill / totalCustomers : 0;


            // Tạo DataTable kết quả, gồm 1 dòng duy nhất với các chỉ số tổng hợp
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("TotalCustomers", typeof(int));       // Tổng khách hàng
            dtResult.Columns.Add("RefillCount", typeof(int));      // Tổng khách quay lại
            dtResult.Columns.Add("AvgRefillPerCustomer", typeof(double)); // Tần suất đặt hàng trung bình

            // Thêm dữ liệu vào DataTable
            DataRow row = dtResult.NewRow();
            row["TotalCustomers"] = totalCustomers;
            row["RefillCount"] = sumRefill;
            row["AvgRefillPerCustomer"] = Math.Round(avgOrders, 2); // làm tròn 2 chữ số

            dtResult.Rows.Add(row);

            return dtResult;
        }

        /// <summary>
        /// Lấy doanh thu theo loại và ngày.
        /// </summary>
        /// <param name="type">Loại doanh thu.</param>
        /// <param name="date">Ngày thống kê.</param>
        /// <returns>DataTable chứa doanh thu, số đơn và tăng trưởng.</returns>
        public DataTable GetRevenue(string type, DateTime date)
        {
            // 1. Lấy dữ liệu từ DAL (cột: Ngay, SoDon, DoanhThu)
            DataTable table = OrderDAL.GetRevenue(type, date);

            // 2. Chuẩn bị DataTable kết quả với cột tăng trưởng
            DataTable result = new DataTable();
            result.Columns.Add("Ngay", typeof(string));
            result.Columns.Add("SoDon", typeof(int));
            result.Columns.Add("DoanhThu", typeof(decimal));
            result.Columns.Add("TangTruong", typeof(string)); // giữ dạng % dễ đọc

            if (table == null || table.Rows.Count == 0)
                return result;

            decimal previousRevenue = 0m;

            foreach (DataRow row in table.Rows)
            {
                string ngay = row["Ngay"].ToString();
                int soDon = row["SoDon"] != DBNull.Value ? Convert.ToInt32(row["SoDon"]) : 0;
                decimal doanhThu = row["DoanhThu"] != DBNull.Value ? Convert.ToDecimal(row["DoanhThu"]) : 0m;

                string tangTruong;

                if (previousRevenue == 0)
                {
                    tangTruong = "0"; // ngày đầu tiên
                }
                else
                {
                    // % tăng trưởng = (DoanhThuHienTai - DoanhThuTruoc) / DoanhThuTruoc * 100
                    decimal growth = (doanhThu - previousRevenue) / previousRevenue * 100m;
                    tangTruong = growth.ToString("F4") + "%"; // 4 chữ số thập phân
                }

                previousRevenue = doanhThu;

                result.Rows.Add(ngay, soDon, doanhThu, tangTruong);
            }

            return result;
        }

        /// <summary>
        /// Tổng hợp lượng rác thải giảm được từ việc tái sử dụng bao bì.
        /// </summary>
        /// <param name="type">Loại thống kê.</param>
        /// <param name="date">Ngày thống kê.</param>
        /// <param name="averageWastePerPackage">Trung bình rác thải mỗi bao bì.</param>
        /// <returns>DataTable chứa thông tin lượng rác thải giảm được.</returns>
        public DataTable SummarizeWatseReduction(string type, DateTime date, double averageWastePerPackage = 0.2)
        {
            // Lấy dữ liệu đã nhóm từ DAL
            DataTable data = OrderDAL.GetWasteReduction(type, date);

            if (data == null)
                return null;

            // Nếu chưa có cột "AmountOfReducingWaste" thì thêm vào
            if (!data.Columns.Contains("AmountOfReducingWaste"))
                data.Columns.Add("AmountOfReducingWaste", typeof(double));

            // Duyệt từng dòng để tính toán
            foreach (DataRow row in data.Rows)
            {
                // Lấy ReuseCount (số lần tái sử dụng)
                int reuseCount = 0;

                if (row["ReuseCount"] != DBNull.Value)
                    reuseCount = Convert.ToInt32(row["ReuseCount"]);

                // Tính lượng rác thải giảm được
                double reducedWaste = reuseCount * averageWastePerPackage;

                // Gán vào cột mới
                row["AmountOfReducingWaste"] = reducedWaste;
            }

            return data;
        }

        /// <summary>
        /// Lấy danh sách lỗi chi tiết trong quá trình xử lý đơn hàng.
        /// </summary>
        /// <returns>List<string> chứa chi tiết lỗi.</returns>
        public List<string> GetDetailError()
        {
            return DetailError;
        }

        /// <summary>
        /// Lấy đơn hàng theo ID.
        /// </summary>
        /// <param name="orderID">ID đơn hàng cần lấy.</param>
        /// <returns>OrderDTO tương ứng.</returns
        public OrderDTO GetOrderByID(string orderID)
        {
            return OrderDAL.GetOrderByID(orderID);
        }

        /// <summary>
        /// Lấy danh sách các đơn hàng mới.
        /// </summary>
        /// <returns>Danh sách OrderDTO.</returns
        public List<OrderDTO> GetNewOrders()
        {
            DataTable dt = OrderDAL.GetNewOrders();
            List<OrderDTO> list = new List<OrderDTO>();

            foreach (DataRow row in dt.Rows)
            {
                OrderDTO order = new OrderDTO();
                order.SetID(row["OrderID"].ToString());
                list.Add(order);
            }

            return list;
        }

        /// <summary>
        /// Lấy danh sách đơn hàng mới theo trạm cụ thể.
        /// </summary>
        /// <param name="stationID">ID trạm.</param>
        /// <returns>Danh sách OrderDTO.</returns>
        public List<OrderDTO> GetNewOrdersByStation(string stationID)
        {
            DataTable dt = OrderDAL.GetNewOrdersByStation(stationID);
            List<OrderDTO> list = new List<OrderDTO>();

            foreach (DataRow row in dt.Rows)
            {
                OrderDTO order = new OrderDTO();

                order.SetID(row["OrderID"].ToString());

                if (row["OrderDate"] != DBNull.Value)
                    order.SetOrderDate(Convert.ToDateTime(row["OrderDate"]));

                if (row["TotalAmount"] != DBNull.Value)
                    order.SetTotalAmount(Convert.ToDecimal(row["TotalAmount"]));

                if (row.Table.Columns.Contains("Status"))
                    order.SetStatus(row["Status"].ToString());

                if (row.Table.Columns.Contains("DeliveryAddress"))
                    order.SetDeliveryAddress(row["DeliveryAddress"].ToString());

                list.Add(order);
            }

            return list;
        }

        /// <summary>
        /// Lấy danh sách đơn hàng đang chuẩn bị theo trạm.
        /// </summary>
        /// <param name="stationID">ID trạm.</param>
        /// <returns>Danh sách OrderDTO.</returns>
        public List<OrderDTO> GetPrepareOrdersByStation(string stationID)
        {
            DataTable dt = OrderDAL.GetPrepareOrdersByStation(stationID);
            List<OrderDTO> list = new List<OrderDTO>();

            foreach (DataRow row in dt.Rows)
            {
                OrderDTO order = new OrderDTO();

                order.SetID(row["OrderID"].ToString());

                if (row["OrderDate"] != DBNull.Value)
                    order.SetOrderDate(Convert.ToDateTime(row["OrderDate"]));

                if (row["TotalAmount"] != DBNull.Value)
                    order.SetTotalAmount(Convert.ToDecimal(row["TotalAmount"]));
                if (row.Table.Columns.Contains("OrderAddress"))
                    order.SetDeliveryAddress(row["OrderAddress"].ToString());
                if (row.Table.Columns.Contains("DeliveryAddress"))
                    order.SetDeliveryAddress(row["DeliveryAddress"].ToString());
                if (row.Table.Columns.Contains("Status"))
                    order.SetStatus(row["Status"].ToString());
                list.Add(order);
            }

            return list;
        }

    }
}
