namespace Payment.Application.Communication.Request
{
    public class RequestInvoice
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string Type { get; set; } = string.Empty;
        public string? Format { get; set; }
    }
}
