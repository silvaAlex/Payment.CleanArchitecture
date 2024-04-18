namespace Payment.Domain.Models
{
    public class Contract
    {
        public Guid ContractId { get; }
        public string Description { get; } = string.Empty;
        public int Amount { get; } = 0;
        public int Periods { get; } = 0;
        public DateTime Date { get; }
        public DateTime CreatedAt { get; }

        public IList<Payment> Payments { get; }

        public Contract(string description, int amount, int periods, DateTime date)
        {
            ContractId = Guid.NewGuid();
            Description = description;
            Amount = amount;
            Periods = periods;
            Date = date;
            Payments = new List<Payment>();
        }

        public void AddPayments(Payment payment)
        {
            Payments.Add(payment);
        }

        public int GetBalace()
        {
            int balace = Amount;

            foreach (Payment payment in Payments)
            {
                balace -= payment.Amount;
            }

            return balace;
        }
    }
}
