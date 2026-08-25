using QuestPDF.Infrastructure;
using System.Data;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
namespace EcosystemApp.Utils
{
    /// <summary>
    /// QuestPDF document xuất 1 DataTable thành bảng PDF
    /// </summary>
    public class SingleDataTablePdf : IDocument
    {
        private readonly DataTable Table;

        public SingleDataTablePdf(DataTable table)
        {
            Table = table ?? throw new ArgumentNullException(nameof(table));
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        // ✅ Phương thức Compose chuẩn interface IDocument
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.A4);
                page.DefaultTextStyle(x => x.FontSize(10));

                // HEADER
                page.Header().Column(column =>
                {
                    column.Item().AlignCenter()
                        .Text(Table.TableName ?? "Bảng dữ liệu")
                        .FontSize(16).Bold().Underline();
                    column.Item().PaddingTop(5)
                        .Text($"Số dòng: {Table.Rows.Count} | Số cột: {Table.Columns.Count}")
                        .FontSize(10).AlignCenter();
                });

                // CONTENT
                page.Content().PaddingTop(16).Column(col =>
                {
                    col.Item().Table(t =>
                    {
                        // Định nghĩa cột: tất cả cột RelativeColumn
                        t.ColumnsDefinition(columns =>
                        {
                            foreach (DataColumn _ in Table.Columns)
                                columns.RelativeColumn();
                        });

                        // HEADER bảng
                        t.Header(header =>
                        {
                            foreach (DataColumn colHeader in Table.Columns)
                            {
                                header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium)
                                    .Padding(4)
                                    .Background(Colors.Grey.Lighten3)
                                    .Text(colHeader.ColumnName)
                                    .Bold()
                                    .FontSize(10)
                                    .AlignCenter();
                            }
                        });

                        // Dữ liệu
                        foreach (DataRow row in Table.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                t.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten2)
                                    .Padding(4)
                                    .Text(cell?.ToString() ?? "")
                                    .FontSize(9);
                            }
                        }
                    });
                });

                // FOOTER - số trang
                page.Footer().AlignCenter().Text(text =>
                {
                    text.CurrentPageNumber();
                    text.Span(" / ");
                    text.TotalPages();
                });
            });
        }
    }
}
