using System.Data;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using EcosystemApp.Utils;

namespace EcosystemApp.BUS
{
    public class DeliveryAssignmentBUS
    {
        private readonly DeliveryAssignmentDAL DeliveryDAL = new DeliveryAssignmentDAL();

        public bool AssignDelivery(DeliveryAssignmentDTO deliveryAssignmentDTO)
        {
            try
            {
                DeliveryDAL.AssignDelivery(deliveryAssignmentDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable GetPendingAssignments()
        {
            return DeliveryDAL.GetPendingDeliveryAssignments();
        }

        public DeliveryAssignmentDTO GetAssignmentByOrder(string orderID)
        {
            return DeliveryDAL.GetAssignmentByOrder(orderID);
        }

        public bool UpdateAssignmentStatus(DeliveryAssignmentDTO deliveryAssignmentDTO)
        {
            try
            {
                DeliveryDAL.UpdateAssignmentStatus(deliveryAssignmentDTO);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DeliveryAssignmentDTO> GetAllAssignments()
        {
            return DeliveryDAL.GetAllAssign();
        }

        public int[] UpdateCompletedFromExcel(string filePath, string sheetName)
        {
            try
            {
                ExcelHelper excel = new ExcelHelper(filePath, sheetName);
                List<string> lines = excel.ReadExcelLines();

                // Loại header nếu có
                if (lines.Count > 0 && lines[0].StartsWith("OrderID"))
                    lines.RemoveAt(0);

                int success = 0;
                int fail = 0;

                foreach (var line in lines)
                {
                    try
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length < 4)
                        {
                            fail++;
                            continue;
                        }

                        string orderID = parts[0].Trim();
                        string employeeID = parts[1].Trim();
                        string guiStatus = parts[4].Trim();

                        if (string.IsNullOrEmpty(orderID) || string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(guiStatus))
                        {
                            fail++;
                            continue;
                        }

                        // Map trạng thái từ GUI Excel -> DB
                        string dbStatus = ConvertStatusForDB(guiStatus);

                        // Lấy phân công từ DB
                        DeliveryAssignmentDTO assign = DeliveryDAL.GetAssignmentByOrder(orderID);

                        if (assign == null || !assign.GetEmployeeID().Equals(employeeID, StringComparison.OrdinalIgnoreCase))
                        {
                            fail++;
                            continue;
                        }

                        // Nếu trạng thái trong sheet khác null hoặc là "Chưa giao"
                        if (!string.IsNullOrEmpty(guiStatus) &&
                            (guiStatus.Equals("Chưa giao", StringComparison.OrdinalIgnoreCase) ||
                             !assign.GetStatus().Equals(dbStatus, StringComparison.OrdinalIgnoreCase)))
                        {
                            DeliveryAssignmentDTO dtoUpdate = new DeliveryAssignmentDTO();
                            dtoUpdate.SetID(assign.GetID());
                            dtoUpdate.SetEmployeeID(assign.GetEmployeeID());
                            dtoUpdate.SetStatus(dbStatus);

                            bool result = UpdateAssignmentStatus(dtoUpdate);
                            if (result)
                                success++;
                            else
                                fail++;
                        }
                        else
                        {
                            fail++;
                        }
                    }
                    catch
                    {
                        fail++;
                    }
                }

                return new int[] { fail, success };
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đọc file Excel/CSV: " + ex.Message);
            }
        }


        public string ConvertStatusForGUI(string dbStatus)
        {
            switch (dbStatus.ToLower())
            {
                case "complete":
                    return "Đã giao";
                case "shipping":
                    return "Đang giao";
                case "pending":
                case "new":
                    return "Chưa giao";
                default:
                    return "Không xác định";
            }
        }
        public string ConvertStatusForDB(string guiStatus)
        {
            switch (guiStatus.ToLower())
            {
                case "đã giao":
                    return "Complete";
                case "đang giao":
                    return "Shipping";
                case "chưa giao":
                    return "Pending";
                default:
                    return "Pending";
            }
        }
        public bool DeleteDeliveryAssignment(string orderID)
        {
            try
            {
                return DeliveryDAL.DeleteAssignmentByOrder(orderID);
            }
            catch
            {
                return false;
            }
        }

    }
}
