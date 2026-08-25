using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using EcosystemApp.DTO;

namespace EcosystemApp.Utils
{
    public class OrderReportPDF : IDocument
    {
        private readonly List<OrderDTO> Orders;
        private readonly string FromDate;
        private readonly string ToDate;
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;


        public OrderReportPDF(List<OrderDTO> orders, string fromDate, string toDate)
        {
            Orders = orders ?? new List<OrderDTO>();
            FromDate = fromDate;
            ToDate = toDate;
        }


        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.A4);
                page.DefaultTextStyle(x => x.FontSize(10));

                // ===== HEADER =====
                page.Header().Column(column =>
                {
                    column.Item().AlignCenter().Text("BÁO CÁO ĐƠN HÀNG")
                        .FontSize(16).Bold().Underline();

                    column.Item().AlignCenter()
                        .Text($"Từ ngày: {FromDate}  Đến ngày: {ToDate}")
                        .FontSize(10);
                });

                // ===== CONTENT =====
                page.Content().PaddingTop(16).Column(col =>
                {
                    col.Item().Table(table =>
                    {
                        // Cấu trúc cột
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(30);  // STT
                            columns.RelativeColumn(2);   // Mã đơn
                            columns.RelativeColumn(3);   // Khách hàng
                            columns.RelativeColumn(3);   // Ngày đặt
                            columns.RelativeColumn(2);   // Trạng thái
                            columns.RelativeColumn(2);   // Tổng tiền
                        });

                        // ----- HEADER -----
                        table.Header(header =>
                        {
                            header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium).Padding(4).Text("STT").Bold();
                            header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium).Padding(4).Text("Mã đơn").Bold();
                            header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium).Padding(4).Text("Khách hàng").Bold();
                            header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium).Padding(4).Text("Ngày đặt").Bold();
                            header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium).Padding(4).Text("Trạng thái").Bold();
                            header.Cell().Border(0.5f).BorderColor(Colors.Grey.Medium).Padding(4).Text("Tổng tiền").Bold();
                        });

                        // ----- DỮ LIỆU -----
                        int index = 1;
                        foreach (var order in Orders)
                        {
                            table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten1).Padding(4).Text(index++);
                            table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten1).Padding(4).Text(order.GetID());
                            table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten1).Padding(4)
                                .Text(order.GetCustomer()?.GetFullName() ?? "Không có");
                            table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten1).Padding(4)
                                .Text(order.GetOrderDate().ToString("dd/MM/yyyy HH:mm"));
                            table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten1).Padding(4)
                                .Text(ConvertStatusToVietnamese(order.GetStatus()));
                            table.Cell().Border(0.5f).BorderColor(Colors.Grey.Lighten1).Padding(4)
                                .AlignRight().Text($"{order.GetTotalAmount():N0} VND");
                        }
                    });

                    // Tổng đơn & tổng tiền
                    col.Item().PaddingTop(8)
                        .AlignRight()
                        .Text($"Tổng đơn: {Orders.Count} | Tổng tiền: {Orders.Sum(o => o.GetTotalAmount()):N0} VND")
                        .FontSize(10).Bold();
                });

                // ===== FOOTER =====
                page.Footer().AlignCenter().Text(text =>
                {
                    text.CurrentPageNumber();
                    text.Span(" / ");
                    text.TotalPages();
                });
            });
        }

        // Hàm chuyển trạng thái sang English
        private static string ConvertStatusToVietnamese(string status)
        {
            return status.ToLower() switch
            {
                "new" => "Mới",
                "prepare" => "Chuẩn bị",
                "shipping" => "Đang Giao",
                "complete" => "Hoàn thành",
                "recall package" => "Thu hồi bao bì",
                _ => status, // giữ nguyên nếu không khớp
            };
        }
    }
}

