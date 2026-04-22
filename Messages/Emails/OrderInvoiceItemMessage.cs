namespace Platform.Contracts.Messages.Emails;

public class OrderInvoiceItemMessage
{
    public string ProductName { get; set; } = default!;
    public int Quantity { get; set; }
    public long Price { get; set; }
}
