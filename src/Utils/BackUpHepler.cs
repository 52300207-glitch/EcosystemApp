using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;

namespace EcosystemApp.Helpers
{
    public static class BackupHelper
    {
        /// <summary>
        /// Sinh tên file backup với timestamp
        /// </summary>
        public static string GenerateBackupFileName(string prefix, string extension)
        {
            string time = DateTime.Now.ToString("yyyy_MM_dd_HH_mm");
            return $"{prefix}_{time}.{extension}";
        }

        /// <summary>
        /// Xuất danh sách DataTable ra Excel hoặc ZIP nếu nhiều file
        /// </summary>
        /// <param name="tables">Danh sách DataTable</param>
        /// <param name="prefix">Tiền tố tên file</param>
        /// <returns>Tên file kết quả (Excel hoặc ZIP)</returns>
        public static string ExportTablesToExcel(List<DataTable> tables, string prefix = "backup")
        {
            if (tables == null || tables.Count == 0)
                throw new ArgumentException("Không có bảng dữ liệu để xuất.");

            // Nếu chỉ 1 bảng, lưu trực tiếp
            if (tables.Count == 1)
            {
                string fileName = GenerateBackupFileName(prefix, "xlsx");
                ExportToExcel(tables[0], fileName);
                return fileName;
            }
            else
            {
                // Nhiều bảng → tạo nhiều file Excel rồi gộp vào ZIP
                var tempFiles = new List<string>();
                foreach (var table in tables)
                {
                    string f = GenerateBackupFileName(table.TableName, "xlsx");
                    ExportToExcel(table, f);
                    tempFiles.Add(f);
                }

                string zipFile = GenerateBackupFileName(prefix + "_full", "zip");
                ZipFiles(tempFiles, zipFile);

                // Xóa file tạm
                foreach (var f in tempFiles)
                {
                    if (File.Exists(f))
                        File.Delete(f);
                }

                return zipFile;
            }
        }

        /// <summary>
        /// Xuất 1 DataTable ra Excel
        /// </summary>
        public static void ExportToExcel(DataTable table, string filePath)
        {
            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add(table.TableName ?? "Sheet");
            ws.Cell(1, 1).InsertTable(table);
            workbook.SaveAs(filePath);
        }

        /// <summary>
        /// Tạo ZIP từ danh sách file
        /// </summary>
        public static void ZipFiles(List<string> filePaths, string zipFilePath)
        {
            if (File.Exists(zipFilePath))
                File.Delete(zipFilePath);

            using var zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Create);
            foreach (var file in filePaths)
                zip.CreateEntryFromFile(file, Path.GetFileName(file));
        }
    }
}
