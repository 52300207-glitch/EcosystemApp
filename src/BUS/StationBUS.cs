using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.BUS
{
    /// <summary>
    /// BUS xử lý các thao tác liên quan đến trạm (Station)
    /// </summary>
    public class StationBUS
    {
        // DAL xử lý dữ liệu trạm
        private readonly StationDAL StationDAL = new StationDAL();

        /// <summary>
        /// Lấy thông tin trạm theo ID
        /// </summary>
        /// <param name="stationID">ID của trạm</param>
        /// <returns>StationDTO nếu tìm thấy, ngược lại trả về null</returns>
        public StationDTO GetStation(string stationID)
        {
            return StationDAL.GetByID(stationID);
        }
    }
}
