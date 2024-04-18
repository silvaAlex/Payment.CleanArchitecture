using Payment.Domain.Models;

namespace Payment.Domain.Repository
{
    public interface IContractRepository
    {
        Task<Contract> GetAll();
        Task<Contract> GetById(Guid id);
        Task AddContract(Contract contract);
        Task DeleteContract(Contract contract);
        Task UpdateContract(object[] data);
    }
}
