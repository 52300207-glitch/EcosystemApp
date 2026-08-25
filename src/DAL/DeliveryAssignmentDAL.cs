using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using EcosystemApp.Utils;
using EcosystemApp.DTO;

namespace EcosystemApp.DAL
{
    public class DeliveryAssignmentDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();

        // Thêm phân công giao hàng
        public void AssignDelivery(DeliveryAssignmentDTO deliveryAssignmentDTO)
        {
            string query = @"INSERT INTO DeliveryAssignment(EmployeeID, OrderID, Status, Note)
                             VALUES(@EmployeeID, @OrderID, @Status, @Note)";

            int affected = Db.ExecuteNonQuery(query,
                new SQLiteParameter("@EmployeeID", deliveryAssignmentDTO.GetEmployeeID()),
                new SQLiteParameter("@OrderID", deliveryAssignmentDTO.GetOrder().GetID()),
                new SQLiteParameter("@Status", deliveryAssignmentDTO.GetStatus()),
                new SQLiteParameter("@Note", deliveryAssignmentDTO.GetNote())
            );

            if (affected == 0)
                throw new InvalidOperationException("INSERT affected 0 rows. Check constraints / duplicate key.");
        }


        // Lấy tất cả phân công giao hàng (JOIN Order)
        public List<DeliveryAssignmentDTO> GetAllAssign()
        {
            string query = @"SELECT 
                                da.ID AS AssignmentID,
                                da.EmployeeID,
                                da.OrderID,
                                da.Status,
                                da.Note,
                                o.OrderAddress,
                                o.DeliveryAddress
                             FROM DeliveryAssignment da
                             JOIN Orders o ON da.OrderID = o.OrderID";
            DataTable dt = Db.ExecuteQuery(query);
            List<DeliveryAssignmentDTO> list = new List<DeliveryAssignmentDTO>();
            foreach (DataRow row in dt.Rows)
            {
                // Tạo OrderDTO
                var order = new OrderDTO();
                order.SetID(row["OrderID"].ToString());
                order.SetOrderAddress(row["OrderAddress"].ToString());
                order.SetDeliveryAddress(row["DeliveryAddress"].ToString());
                // Tạo DeliveryAssignmentDTO
                var dto = new DeliveryAssignmentDTO();
                dto.SetID(Convert.ToInt32(row["AssignmentID"]));
                dto.SetEmployeeID(row["EmployeeID"].ToString());
                dto.SetOrder(order);
                dto.SetStatus(row["Status"].ToString());
                dto.SetNote(row["Note"].ToString());
                list.Add(dto);
            }
            return list;
        }
        public bool DeleteAssignmentByOrder(string orderID)
        {
            string query = "DELETE FROM DeliveryAssignment WHERE OrderID=@OrderID";
            int affected = Db.ExecuteNonQuery(query,
                new SQLiteParameter("@OrderID", orderID)
            );
            return affected > 0;
        }
        public DataTable GetPendingDeliveryAssignments()
        {
            string query = @"SELECT da.OrderID, da.EmployeeID, o.OrderAddress, o.DeliveryAddress, da.Status
                             FROM DeliveryAssignment da
                             JOIN Orders o ON da.OrderID = o.OrderID
                             WHERE da.Status != 'Complete'";

            return Db.ExecuteQuery(query); 
        }



        // Cập nhật trạng thái
        public void UpdateAssignmentStatus(DeliveryAssignmentDTO deliveryAssignmentDTO)
        {
            string query = "UPDATE DeliveryAssignment SET Status=@Status WHERE ID=@AssignmentID";

            Db.ExecuteNonQuery(query,
                new SQLiteParameter("@Status", deliveryAssignmentDTO.GetStatus()),
                new SQLiteParameter("@AssignmentID", deliveryAssignmentDTO.GetID()));
        }


        // Lấy phân công theo OrderID (trả về object đầy đủ)
        public DeliveryAssignmentDTO GetAssignmentByOrder(string orderID)
        {
            string query = @"SELECT 
                                da.ID,
                                da.EmployeeID,
                                da.OrderID,
                                da.Status,
                                da.Note,
                                o.OrderAddress,
                                o.DeliveryAddress
                             FROM DeliveryAssignment da
                             JOIN Orders o ON da.OrderID = o.OrderID
                             WHERE da.OrderID = @OrderID";

            DataTable dt = Db.ExecuteQuery(query, new SQLiteParameter("@OrderID", orderID));

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            // Tạo OrderDTO
            var order = new OrderDTO();
            order.SetID(row["OrderID"].ToString());
            order.SetOrderAddress(row["OrderAddress"].ToString());
            order.SetDeliveryAddress(row["DeliveryAddress"].ToString());


            // Tạo DeliveryAssignmentDTO
            var dto = new DeliveryAssignmentDTO();
            dto.SetID(Convert.ToInt32(row["ID"]));
            dto.SetEmployeeID(row["EmployeeID"].ToString());
            dto.SetOrder(order);
            dto.SetStatus(row["Status"].ToString());
            dto.SetNote(row["Note"].ToString());
            return dto;
        }
    }
}
