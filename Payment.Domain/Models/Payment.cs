namespace Payment.Domain.Models
{
    public class Payment
    {
        public Guid PaymentId { get; }
        public Guid ContractId { get; }
        public DateTime Date { get; }
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
        public int Amount { get; }

        public Payment(int amount, DateTime date, Guid contractId)
        {
            ContractId = contractId;
            Amount = amount;
            Date = date;
            PaymentId = Guid.NewGuid();
        }
    }
}
