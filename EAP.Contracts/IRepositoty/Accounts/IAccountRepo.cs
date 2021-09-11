using EAP.Contracts.IRepositoty.BaseRepo;
using EAP.Entity.Models.Accounts;

namespace EAP.Contracts.IRepositoty.Accounts
{
    public interface IAccountRepo : IRepositoryBase<Account>
    {
        void CreateAccount(Account account);
    }
}