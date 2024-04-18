using Payment.Domain.Models;

namespace Payment.Domain.Strategy
{
    public interface IInvoiceGenerationStrategy
    {
        IList<Invoice> Generate(Contract contract, int month, int year);
    }
}
