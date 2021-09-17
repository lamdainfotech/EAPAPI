using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.OrganizationsRepo;
using EAP.Entity.Data;
using EAP.Entity.Models.Organizations;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.Organizations
{
    public class OrganizationTypesRepo : IOrganizationTypesRepo
    {
        private readonly EAPDbContext _context;

        public OrganizationTypesRepo(EAPDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrganizationType>> GetAllOrganizationTypes()
        {
            return await _context.OrganizationTypes
                .OrderBy(ot => ot.OrgType)
                .ToListAsync();
        }
    }
}