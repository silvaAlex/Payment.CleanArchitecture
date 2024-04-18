using Payment.Domain.Models;

namespace Payment.Domain.Strategy
{
    public class AccrualBasisStrategy : IInvoiceGenerationStrategy
    {
        public IList<Invoice> Generate(Contract contract, int month, int year)
        {
            IList<Invoice> invoices = new List<Invoice>();
            int period = 0;
            while (period <= contract.Periods)
            {
                DateTime date = contract.Date.AddMonths(period++).Date;

                if (date.Month != month || date.Year != year)
                {
                    continue;
                }

                int amount = contract.Amount / contract.Periods;
                invoices.Add(new Invoice(date, amount));
            }

            return invoices;
        }
    }
}
