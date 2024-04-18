using Payment.Domain.Strategy;

namespace Payment.Domain
{
    public static class InvoiceGenerationFactory
    {
        public static IInvoiceGenerationStrategy Create(string type)
        {
            if (type.Equals("cash", StringComparison.InvariantCultureIgnoreCase))
            {
                return new CashBasisStrategy();
            }
            if (type.Equals("accrual"))
            {
                return new AccrualBasisStrategy();
            }

            throw new Exception($"tipo inválido {type}");
        }
    }
}
