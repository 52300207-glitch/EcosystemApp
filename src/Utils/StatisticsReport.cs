using EcosystemApp.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace EcosystemApp.Utils
{
    public class StatisticsReport : IDocument
    {
        private readonly MemoryStream PieChartCustomerRefill;
        private readonly MemoryStream LineChartPlasticReduction;
        private readonly MemoryStream ColumnChartPackaging;

        private readonly Dictionary<string, decimal> GroupCustomerRefill;
        private readonly DataTable DataCustomerRefill;

        private readonly DataTable DataPlasticReduction;
        private readonly DataTable DataPackaging;

        private DataTable DataCustomerRefillSummary;
        private DataTable DataPlasticReductionSummary;
        private DataTable DataPackagingSummary;

        private readonly string TimeCustomerRefill;
        private readonly string TimePlasticReduction;
        private readonly string TimePackingRecall;

        public StatisticsReport( MemoryStream pieChartCustomerRefill, MemoryStream lineChartPlasticReduction, MemoryStream columnChartPackaging, Dictionary<string, decimal> groupCustomerRefill,
            DataTable dataCustomerRefill, DataTable dataPlasticReduction, DataTable dataPackaging,
            string timeCustomerRefill, string timePlasticReduction, string timePackingRecall
            )
        {
            PieChartCustomerRefill = pieChartCustomerRefill;
            LineChartPlasticReduction = lineChartPlasticReduction;
            ColumnChartPackaging = columnChartPackaging;

            GroupCustomerRefill = groupCustomerRefill;
            DataCustomerRefill = dataCustomerRefill;
            DataPlasticReduction = dataPlasticReduction;
            DataPackaging = dataPackaging;

            TimeCustomerRefill = timeCustomerRefill;
            TimePlasticReduction = timePlasticReduction;
            TimePackingRecall = timePackingRecall;
            Summarize();

         }

        private void Summarize()
        {
            // --- 1. Khách hàng refill ---
            if (DataCustomerRefill != null && DataCustomerRefill.Rows.Count > 0)
            {
                DataCustomerRefillSummary = new DataTable();
                DataCustomerRefillSummary.Columns.Add("TotalCustomers", typeof(int));
                DataCustomerRefillSummary.Columns.Add("RefillCount", typeof(int));
                DataCustomerRefillSummary.Columns.Add("AvgRefillPerCustomer", typeof(double));

                int totalCustomers = DataCustomerRefill.Rows.Count;
                int refillCount = 0;
                double avgRefillPerCustomer = 0;

                foreach (DataRow row in DataCustomerRefill.Rows)
                {
                    if (row["RefillCount"] != DBNull.Value)
                        refillCount += Convert.ToInt32(row["RefillCount"]) + 1;
                }
                avgRefillPerCustomer = (double)refillCount / totalCustomers;


                DataCustomerRefillSummary.Rows.Add(totalCustomers, refillCount, avgRefillPerCustomer);
            }

            // --- 2. Giảm nhựa ---
            if (DataPlasticReduction != null && DataPlasticReduction.Rows.Count > 0)
            {
                DataPlasticReductionSummary = new DataTable();
                DataPlasticReductionSummary.Columns.Add("TotalPlasticReduced", typeof(double));

                double totalPlastic = 0;
                foreach (DataRow row in DataPlasticReduction.Rows)
                {
                    if (row["AmountOfReducingWaste"] != DBNull.Value)
                        totalPlastic += Convert.ToDouble(row["AmountOfReducingWaste"]);
                }

                DataPlasticReductionSummary.Rows.Add(totalPlastic);
            }

            // --- 3. Bao bì ---
            if (DataPackaging != null && DataPackaging.Rows.Count > 0)
            {
                DataPackagingSummary = new DataTable();
                DataPackagingSummary.Columns.Add("TotalIssued", typeof(int));
                DataPackagingSummary.Columns.Add("TotalReturned", typeof(int));
                DataPackagingSummary.Columns.Add("RecallRatePercent", typeof(double));

                int totalIssued = 0;
                int totalReturned = 0;

                foreach (DataRow row in DataPackaging.Rows)
                {
                    if (row["Issued"] != DBNull.Value)
                        totalIssued += Convert.ToInt32(row["Issued"]);
                    if (row["Returned"] != DBNull.Value)
                        totalReturned += Convert.ToInt32(row["Returned"]);
                }

                double recallRate = totalIssued > 0 ? (double)totalReturned / totalIssued * 100 : 0;
                DataPackagingSummary.Rows.Add(totalIssued, totalReturned, recallRate);
            }
        }


        public DocumentMetadata GetMetadata() => new DocumentMetadata
        {
            Title = "Báo Cáo Thống Kê Ecosystem"
        };

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.MarginHorizontal(40);
                page.MarginVertical(50);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            // Đọc file logo thành byte[] một lần
            var img = EcosystemApp.src.assets.Image.Resource.logoapp;   // Image
            using var ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] logoBytes = ms.ToArray();

            container.Row(row =>
            {
                row.RelativeItem().Column(col =>
                {
                    col.Item().Text("BÁO CÁO THỐNG KÊ")
                        .FontSize(20)
                        .SemiBold()
                        .FontColor(Colors.Blue.Darken2);
                    col.Item().Text($"Ngày lập: {DateTime.Now:dd/MM/yyyy}").FontSize(10);
                });

                row.ConstantItem(70)
                    .Height(70)
                    .AlignRight()
                    .AlignTop()
                    .PaddingBottom(10)
                    .Image(logoBytes)
                    .FitHeight();
            });
        }

        private void ComposeContent(IContainer container)
        {

            container.PaddingVertical(10).Column(col =>
            {
                // --- 1. Khách hàng refill ---
                col.Item().Text($"1. Thống kê khách hàng refill ({TimeCustomerRefill})").FontSize(14).SemiBold();
                col.Item().Image(PieChartCustomerRefill.ToArray()).FitWidth();

                // Tổng quan
                if (DataCustomerRefillSummary != null && DataCustomerRefillSummary.Rows.Count > 0)
                {
                    var summary = DataCustomerRefillSummary.Rows[0];
                    col.Item().Text($" - Số khách hàng duy nhất: {summary["TotalCustomers"]}").FontSize(12);
                    col.Item().Text($" - Tống số lần refill: {summary["RefillCount"]}").FontSize(12);
                    col.Item().Text($" - Tần suất trung bình refill: {Convert.ToDouble(summary["AvgRefillPerCustomer"]):0.00}").FontSize(12);
                }

                // Bảng chi tiết
                col.Item().PaddingTop(15).Text("Chi tiết khách hàng refill:").FontSize(12).SemiBold();
                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(c =>
                    {
                        c.RelativeColumn();
                        c.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).Text("Số lần refill").SemiBold();
                        header.Cell().Element(CellStyle).Text("Số khách hàng quay trở lại refill").SemiBold();
                    });

                    foreach (var item in GroupCustomerRefill)
                    {
                        table.Cell().Element(CellStyle).Text(item.Key.ToLower());
                        table.Cell().Element(CellStyle).Text(Convert.ToDouble(item.Value.ToString()));
                    }
                });
                col.Item().PageBreak(); // Bắt buộc xuống trang mới

                // --- 2. Giảm nhựa từ refill ---
                col.Item().Text($"2. Giảm nhựa từ refill ({TimePlasticReduction})").FontSize(14).SemiBold();
                col.Item().Image(LineChartPlasticReduction.ToArray()).FitWidth();

                // Tổng quan
                if (DataPlasticReductionSummary != null && DataPlasticReductionSummary.Rows.Count > 0)
                {
                    var summary = DataPlasticReductionSummary.Rows[0];
                    col.Item().Text($" - Tổng lượng nhựa giảm: {Convert.ToDouble(summary["TotalPlasticReduced"]):N2} kg").FontSize(12);
                }

                // Bảng chi tiết
                col.Item().PaddingTop(15).Text("Chi tiết giảm nhựa:").FontSize(12).SemiBold();
                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(c =>
                    {
                        c.RelativeColumn();
                        c.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).Text("Thời gian").SemiBold();
                        header.Cell().Element(CellStyle).Text("Lượng nhựa giảm (kg)").SemiBold();
                    });

                    if (DataPlasticReduction != null)
                    {
                        foreach (DataRow row in DataPlasticReduction.Rows)
                        {
                            table.Cell().Element(CellStyle).Text(row["Day"].ToString());
                            table.Cell().Element(CellStyle).Text(Convert.ToDouble(row["AmountOfReducingWaste"]).ToString("N2"));
                        }
                    }
                });
                col.Item().PageBreak(); // Bắt buộc xuống trang mới

                // --- 3. Bao bì phát ra và thu hồi ---
                col.Item().Text($"3. Bao bì phát ra và thu hồi ({TimePackingRecall})").FontSize(14).SemiBold();
                col.Item().Image(ColumnChartPackaging.ToArray()).FitWidth();

                // Tổng quan
                if (DataPackagingSummary != null && DataPackagingSummary.Rows.Count > 0)
                {
                    var summary = DataPackagingSummary.Rows[0];
                    col.Item().Text($" - Tổng phát ra: {summary["TotalIssued"]}").FontSize(12);
                    col.Item().Text($" - Tổng thu hồi: {summary["TotalReturned"]}").FontSize(12);
                    col.Item().Text($" - Tỉ lệ thu hồi: {Convert.ToDouble(summary["RecallRatePercent"]):0.##}%").FontSize(12);
                }

                // Bảng chi tiết
                col.Item().PaddingTop(15).Text("Chi tiết bao bì phát ra và thu hồi:").FontSize(12).SemiBold();
                col.Item().Table(table =>
                {
                    table.ColumnsDefinition(c =>
                    {
                        c.RelativeColumn();
                        c.RelativeColumn();
                        c.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(CellStyle).Text("Thời gian").SemiBold();
                        header.Cell().Element(CellStyle).Text("Phát ra").SemiBold();
                        header.Cell().Element(CellStyle).Text("Thu hồi").SemiBold();
                    });

                    if (DataPackaging != null)
                    {
                        foreach (DataRow row in DataPackaging.Rows)
                        {
                            table.Cell().Element(CellStyle).Text(row["TimePeriod"].ToString());
                            table.Cell().Element(CellStyle).Text(row["Issued"].ToString());
                            table.Cell().Element(CellStyle).Text(row["Returned"].ToString());
                        }
                    }
                });
            });
        }



        private IContainer CellStyle(IContainer container)
        {
            return container.BorderBottom(1)
                            .BorderColor(Colors.Grey.Lighten2)
                            .Padding(5);
        }

        private void ComposeFooter(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem()
                    .Text(text => text.Span("EcosystemApp - Báo cáo tự động").FontSize(10));
                row.ConstantItem(50)
                    .AlignRight()
                    .Text(txt =>
                    {
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" / ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
            });
        }

        private int CalculateTotalIssued()
        {
            int total = 0;
            if (DataPackaging != null)
            {
                foreach (DataRow row in DataPackaging.Rows)
                    total += row["Issued"] != DBNull.Value ? Convert.ToInt32(row["Issued"]) : 0;
            }
            return total;
        }

        private int CalculateTotalReturned()
        {
            int total = 0;
            if (DataPackaging != null)
            {
                foreach (DataRow row in DataPackaging.Rows)
                    total += row["Returned"] != DBNull.Value ? Convert.ToInt32(row["Returned"]) : 0;
            }
            return total;
        }

    }
}
