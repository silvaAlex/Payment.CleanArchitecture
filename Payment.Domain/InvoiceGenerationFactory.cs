using Payment.Domain.Strategy;
using Payment.Exceptions;

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
            if (type.Equals("accrual", StringComparison.InvariantCultureIgnoreCase))
            {
                return new AccrualBasisStrategy();
            }

            throw new PaymentException($"tipo inválido {type}");
        }
    }
}
