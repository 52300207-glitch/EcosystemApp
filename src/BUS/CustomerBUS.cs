using EcosystemApp.DAL;
using EcosystemApp.DTO;

namespace EcosystemApp.BUS
{
    public class CustomerBUS
    {
        // Data Access Layer: xử lý truy vấn dữ liệu khách hàng
        private readonly CustomerDAL CustomerDAL = new DAL.CustomerDAL();

        // Constructor mặc định
        public CustomerBUS() { }

        /// <summary>
        /// Lấy thông tin khách hàng bằng số điện thoại.
        /// </summary>
        /// <param name="phoneNumber">Số điện thoại cần tìm.</param>
        /// <returns>Đối tượng CustomerDTO nếu tìm thấy, ngược lại null.</returns>
        public CustomerDTO GetByPhoneNumber(string phoneNumber)
        {
            // Gọi tới DAL để lấy dữ liệu từ database
            return CustomerDAL.GetByPhoneNumber(phoneNumber);
        }

        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng.
        /// </summary>
        /// <returns>Danh sách List<CustomerDTO>.</returns>
        public List<CustomerDTO> GetAll()
        {
            // Trả về toàn bộ dữ liệu khách hàng từ DAL
            return CustomerDAL.GetAll();
        }
    }
}
