using System;
using System.Collections.Generic;
using System.Data;
using EcosystemApp.DTO;
using EcosystemApp.Utils;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// DAL xử lý các thao tác CRUD liên quan đến khách hàng (Customer)
    /// </summary>
    public class CustomerDAL
    {
        // Đối tượng DatabaseHelper hỗ trợ thao tác với database
        private readonly DatabaseHelper Db = new DatabaseHelper();

        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public CustomerDAL() { }

        /// <summary>
        /// Lưu khách hàng mới vào cơ sở dữ liệu
        /// </summary>
        /// <param name="cus">Đối tượng CustomerDTO cần lưu</param>
        public void SaveCustomer(CustomerDTO cus)
        {
            // Thực thi câu lệnh INSERT
            Db.ExecuteNonQuery(
                "INSERT INTO Customer (CustomerID, FullName, Address, Phone, Email) VALUES (@CustomerID, @FullName, @Address, @Phone, @Email)",
                new System.Data.SQLite.SQLiteParameter("@CustomerID", cus.GetID()),
                new System.Data.SQLite.SQLiteParameter("@FullName", cus.GetFullName()),
                new System.Data.SQLite.SQLiteParameter("@Address", cus.GetAddress()),
                new System.Data.SQLite.SQLiteParameter("@Phone", cus.GetPhoneNumber()),
                new System.Data.SQLite.SQLiteParameter("@Email", cus.GetEmail())
            );
        }

        /// <summary>
        /// Kiểm tra khách hàng đã tồn tại dựa trên số điện thoại
        /// </summary>
        /// <param name="cus">Đối tượng CustomerDTO cần kiểm tra</param>
        /// <returns>True nếu khách hàng đã tồn tại, false nếu chưa</returns>
        public bool IsExsisted(CustomerDTO cus)
        {
            var isExisted = Db.ExecuteQuery(
                "SELECT * FROM Customer WHERE Phone = @Phone",
                new System.Data.SQLite.SQLiteParameter("@Phone", cus.GetPhoneNumber())
            );

            return isExisted.Rows.Count > 0;
        }

        /// <summary>
        /// Lấy khách hàng theo số điện thoại
        /// </summary>
        /// <param name="phoneNumber">Số điện thoại của khách hàng</param>
        /// <returns>CustomerDTO nếu tìm thấy, null nếu không tìm thấy</returns>
        public CustomerDTO GetByPhoneNumber(string phoneNumber)
        {
            var result = Db.ExecuteQuery(
                "SELECT * FROM Customer WHERE Phone = @PhoneNumber",
                new System.Data.SQLite.SQLiteParameter("@PhoneNumber", phoneNumber)
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new CustomerDTO(
                    row["CustomerID"].ToString(),
                    row["FullName"].ToString(),
                    row["Address"].ToString(),
                    row["Phone"].ToString(),
                    row["Email"].ToString()
                );
            }

            return null;
        }

        /// <summary>
        /// Lấy toàn bộ khách hàng trong cơ sở dữ liệu
        /// </summary>
        /// <returns>Danh sách CustomerDTO</returns>
        public List<CustomerDTO> GetAll()
        {
            var result = Db.ExecuteQuery("SELECT * FROM Customer");
            var customers = new List<CustomerDTO>();

            foreach (DataRow row in result.Rows)
            {
                customers.Add(new CustomerDTO(
                    row["CustomerID"].ToString(),
                    row["FullName"].ToString(),
                    row["Address"].ToString(),
                    row["Phone"].ToString(),
                    row["Email"].ToString()
                ));
            }

            return customers;
        }

        /// <summary>
        /// Lấy khách hàng theo CustomerID
        /// </summary>
        /// <param name="id">ID của khách hàng</param>
        /// <returns>CustomerDTO nếu tìm thấy</returns>
        /// <exception cref="Exception">Ném ra nếu không tìm thấy khách hàng</exception>
        public CustomerDTO GetById(string id)
        {
            var result = Db.ExecuteQuery(
                "SELECT * FROM Customer WHERE CustomerID = @CustomerID",
                new System.Data.SQLite.SQLiteParameter("@CustomerID", id)
            );

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new CustomerDTO(
                    row["CustomerID"].ToString(),
                    row["FullName"].ToString(),
                    row["Address"].ToString(),
                    row["Phone"].ToString(),
                    row["Email"].ToString()
                );
            }

            throw new Exception("Customer not found");
        }
    }
}
