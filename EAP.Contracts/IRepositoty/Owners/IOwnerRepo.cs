using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.BaseRepo;
using EAP.Entity.Models.Owners;

namespace EAP.Contracts.IRepositoty.Owners
{
    public interface IOwnerRepo : IRepositoryBase<Owner>
    {
        Task<IEnumerable<Owner>> GetAllOwners();
        Task<Owner> GetOwnerById(Guid ownerId);
        Task<Owner> GetOwnerWithDetails(Guid ownerId);
        void CreateOwner(Owner owner);
        void UpdateOwner(Owner owner);
        void DeleteOwner(Owner owner);
    }
}