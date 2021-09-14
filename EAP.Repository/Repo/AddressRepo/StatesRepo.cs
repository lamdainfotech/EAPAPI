using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Entity.Data;
using EAP.Entity.Models.Address;
using EAP.Repository.Repo.BaseRepo;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.AddressRepo
{
    public class StatesRepo : RepositoryBase<States>, IStatesRepo
    {
        public StatesRepo(EAPDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<States>> GetAllStates()
        {
            return await FindAll()
                .ToListAsync();
        }

        public async Task<IEnumerable<States>> GetOnlyStates()
        {
            return await FindAll()
                .ToListAsync();
        }
    }
}