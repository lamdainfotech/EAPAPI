using System;
using System.Collections.Generic;
using System.Linq;
using EAP.Contracts.IRepositoty.Accounts;
using EAP.Entity.Data;
using EAP.Entity.Models.Accounts;
using EAP.Repository.Repo.BaseRepo;

namespace EAP.Repository.Repo.Accounts
{
    public class AccountRepo : RepositoryBase<Account>, IAccountRepo
    {
        public AccountRepo(EAPDbContext context) : base(context)
        {
        }
        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }

        public void CreateAccount(Account account) => Create(account);
    }
}