using EcosystemApp.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.Utils
{
    
    public class RevenueReport : IDocument
    {
        private readonly MemoryStream ChartStream;
        private readonly DataTable Data;

        public RevenueReport(MemoryStream chartStream, DataTable data)
        {
            ChartStream = chartStream;
            Data = data;
        }

        public DocumentMetadata GetMetadata() => new DocumentMetadata
        {
            Title = "Báo Cáo Doanh Thu"
        };


        public void Compose(IDocumentContainer container)
        {

            container.Page(page =>
                {
                    page.Size(PageSizes.A4);

                    page.MarginHorizontal(60);
                    page.MarginVertical(100);

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
                    col.Item().Text("BÁO CÁO DOANH THU")
                        .FontSize(20)
                        .SemiBold()
                        .FontColor(Colors.Blue.Darken2);

                    col.Item().Text($"Ngày lập: {DateTime.Now:dd/MM/yyyy}")
                        .FontSize(10);
                });

                row.ConstantItem(70)                 // rộng hơn
                   .Height(70)                       // cao hơn
                   .AlignRight()
                   .AlignTop()                       // đẩy logo lên
                   .PaddingBottom(10)                   // tinh chỉnh vị trí lên 1 chút
                   .Image(logoBytes)
                   .FitHeight();                     // để logo giữ tỉ lệ đẹp
            });
        }


        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(10).Column(col =>
            {
                // --- Biểu đồ ---
                col.Item().Text("Biểu Đồ Doanh Thu").FontSize(14).SemiBold();
                col.Item().PaddingBottom(15)
                    .Image(ChartStream.ToArray())
                    .FitWidth();

                // --- Bảng dữ liệu ---
                col.Item().Text("Chi Tiết Doanh Thu").FontSize(14).SemiBold();

                col.Item().Table(table =>
                {
                    // --- Định nghĩa cột: CHỈ 1 LẦN DUY NHẤT ---
                    table.ColumnsDefinition(c =>
                    {
                        foreach (DataColumn dc in Data.Columns)
                            c.RelativeColumn();
                    });

                    // --- Header ---
                    List<string> colNames = ["Ngày", "Số đơn", "Doanh Thu", "Tăng trưởng"];
                    table.Header(header =>
                    {
                        foreach (var colName in colNames)
                        {
                            header.Cell().Element(CellStyle)
                                .Text(colName)
                                .SemiBold();
                        }
                    });

                    // --- Dữ liệu ---
                    foreach (DataRow row in Data.Rows)
                    {
                        foreach (var cell in row.ItemArray)
                        {
                            table.Cell().Element(CellStyle)
                                .Text(cell?.ToString() ?? "");
                        }
                    }
                });
            });
        }


        private IContainer CellStyle(IContainer container)
        {
            return container.BorderBottom(1)
                            .BorderColor(Colors.Black)
                            .Padding(5);
        }

        private void ComposeFooter(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem()
                    .Text(text =>
                    {
                        text.Span("EcosystemApp - Báo cáo tự động").FontSize(10);
                    });

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
    }
}
