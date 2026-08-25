using System.Data;
using System.Data.SQLite;
using EcosystemApp.Utils;

namespace EcosystemApp.DAL
{
    /// <summary>
    /// DAL hỗ trợ truy vấn dữ liệu thô dạng DataTable,
    /// phục vụ backup, báo cáo hoặc module không cần map sang DTO.
    /// </summary>
    public class TablesDAL
    {
        // Dùng chung DatabaseHelper
        private readonly DatabaseHelper Db = new DatabaseHelper();

        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public TablesDAL() { }

        /// <summary>
        /// Lấy tất cả dữ liệu từ 1 bảng
        /// </summary>
        /// <param name="tableName">Tên bảng SQL</param>
        /// <returns>DataTable</returns>
        public DataTable GetAll(string tableName)
        {
            string sql = $"SELECT * FROM {tableName}";
            return Db.ExecuteQuery(sql);
        }

        /// <summary>
        /// Lấy dữ liệu từ 1 câu SQL tùy chỉnh
        /// </summary>
        public DataTable GetByQuery(string sql)
        {
            return Db.ExecuteQuery(sql);
        }

        /// <summary>
        /// Lấy dữ liệu từ câu SQL có tham số
        /// </summary>
        public DataTable GetByQuery(string sql, params SQLiteParameter[] parameters)
        {
            return Db.ExecuteQuery(sql, parameters);
        }

        /// <summary>
        /// Lấy nhiều bảng cùng lúc → phục vụ Backup
        /// </summary>
        public List<DataTable> GetTables(List<string> tableNames)
        {
            var list = new List<DataTable>();

            foreach (var table in tableNames)
            {
                var dt = GetAll(table);
                dt.TableName = table;   // đặt tên sheet khi export Excel
                list.Add(dt);
            }

            return list;
        }
    }
}
