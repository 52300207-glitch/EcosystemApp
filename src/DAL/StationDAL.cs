using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// Lớp xử lý dữ liệu Station, bao gồm các thao tác truy vấn cơ bản.
    /// </summary>
    public class StationDAL
    {
        private readonly DatabaseHelper Db = new DatabaseHelper();

        /// <summary>
        /// Lấy một Station theo ID.
        /// </summary>
        /// <param name="stationID">ID của Station cần lấy.</param>
        /// <returns>Đối tượng StationDTO nếu tồn tại, ngược lại null.</returns>
        public StationDTO GetByID(string stationID)
        {
            string sqlQuery = "SELECT * FROM Station WHERE StationID = @StationID";
            var dt = Db.ExecuteQuery(sqlQuery,
                new System.Data.SQLite.SQLiteParameter("@StationID", stationID)
            );

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new StationDTO(
                    row["StationID"].ToString(),
                    row["WarehouseID"].ToString(),
                    row["StationName"].ToString(),
                    row["Address"].ToString()
                );
            }

            return null;
        }
    }
}
