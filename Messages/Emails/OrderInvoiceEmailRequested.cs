namespace Platform.Contracts.Messages.Emails;

public class OrderInvoiceEmailRequested
{
    public Guid UserId { get; set; }
    public long OrderCode { get; set; }
    public long TotalAmount { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<OrderInvoiceItemMessage> Items { get; set; } = [];
}
