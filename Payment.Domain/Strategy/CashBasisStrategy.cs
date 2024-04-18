using Payment.Domain.Models;

namespace Payment.Domain.Strategy
{
    public class CashBasisStrategy : IInvoiceGenerationStrategy
    {
        public IList<Invoice> Generate(Contract contract, int month, int year)
        {
            IList<Invoice> invoices = new List<Invoice>();

            foreach (Models.Payment payment in contract.Payments)
            {
                if (payment.Date.Month != month || payment.Date.Year != year)
                {
                    continue;
                }
                invoices.Add(new Invoice(payment.Date, payment.Amount));
            }
            return invoices;
        }
    }
}
