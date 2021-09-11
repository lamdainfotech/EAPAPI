using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.Owners;
using EAP.Entity.Data;
using EAP.Entity.Models.Owners;
using EAP.Repository.Repo.BaseRepo;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.Owners
{
    public class OwnerRepo : RepositoryBase<Owner>, IOwnerRepo
    {
        public OwnerRepo(EAPDbContext context) : base(context)
        {
        }

        public void CreateOwner(Owner owner) => Create(owner);

        public void DeleteOwner(Owner owner) => Delete(owner);

        public async Task<IEnumerable<Owner>> GetAllOwners()
        {
            return await FindAll()
                .OrderBy(ow => ow.Name)
                .ToListAsync();
        }

        public async Task<Owner> GetOwnerById(Guid ownerId)
        {
            return await FindByCondition(owner => owner.Id.Equals(ownerId))
                .FirstOrDefaultAsync();
        }

        public async Task<Owner> GetOwnerWithDetails(Guid ownerId)
        {
            return await FindByCondition(owner => owner.Id.Equals(ownerId))
                .Include(owner => owner.Acounts)
                .FirstOrDefaultAsync();
        }

        public void UpdateOwner(Owner owner) => Update(owner);
    }
}