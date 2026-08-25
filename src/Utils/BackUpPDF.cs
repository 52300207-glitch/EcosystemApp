using QuestPDF.Fluent;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace EcosystemApp.Utils
{
    public static class BackupPDF
    {
        /// <summary>
        /// Sinh tên file backup với timestamp
        /// </summary>
        public static string GenerateBackupFileName(string prefix, string extension)
        {
            string time = System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm");
            return $"{prefix}_{time}.{extension}";
        }

        /// <summary>
        /// Xuất nhiều DataTable ra PDF và ZIP nếu nhiều bảng
        /// </summary>
        public static string ExportTablesToPdf(List<DataTable> tables, string prefix = "backup")
        {
            if (tables == null || tables.Count == 0)
                throw new System.ArgumentException("Không có bảng dữ liệu để xuất.");

            var tempFiles = new List<string>();

            // Xuất từng bảng ra PDF riêng
            foreach (var table in tables)
            {
                string pdfFile = GenerateBackupFileName(table.TableName ?? "Sheet", "pdf");
                ExportSingleTableToPdf(table, pdfFile);
                tempFiles.Add(pdfFile);
            }

            // Nén tất cả PDF vào ZIP
            string zipFile = GenerateBackupFileName(prefix + "_PDF", "zip");
            ZipFiles(tempFiles, zipFile);

            // Xóa file PDF tạm
            foreach (var f in tempFiles)
                if (File.Exists(f))
                    File.Delete(f);

            return zipFile;
        }

        /// <summary>
        /// Xuất 1 DataTable ra PDF
        /// </summary>
        public static void ExportSingleTableToPdf(DataTable table, string filePath)
        {
            var doc = new SingleDataTablePdf(table);
            doc.GeneratePdf(filePath);
        }

        /// <summary>
        /// Nén danh sách file vào ZIP
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
