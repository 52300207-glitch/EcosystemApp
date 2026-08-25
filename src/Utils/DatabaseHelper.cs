using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EcosystemApp.Program;

namespace EcosystemApp.Utils
{
    class DatabaseHelper
    {
        private string dbPath;
        private string connectionString;

        public DatabaseHelper()
        {
            // Lấy thư mục chạy thực tế của file .exe
            string exeDir = Application.StartupPath;

            string dbPath = @"MyData.db";

            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ExecuteQuery(string query, params SQLiteParameter[] parameters)
        {
            try
            {
                DataTable dt = new DataTable();

                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;

            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
