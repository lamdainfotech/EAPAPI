using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Entity.Models.Organizations;

namespace EAP.Contracts.IRepositoty.OrganizationsRepo
{
    public interface IOrganizationTypesRepo
    {
        Task<IEnumerable<OrganizationType>> GetAllOrganizationTypes();
    }
}