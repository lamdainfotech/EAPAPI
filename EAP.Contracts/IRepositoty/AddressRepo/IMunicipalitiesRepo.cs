using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Entity.Models.Address;
using EAP.Shared.Dtos.MunicipalityDto;

namespace EAP.Contracts.IRepositoty.AddressRepo
{
    public interface IMunicipalitiesRepo
    {
        Task<IEnumerable<Municipality>> GetAllMunicipalities();
        Task<IEnumerable<MunicipalityByDistrictDto>> GetMunicipalityByDistrict(int Id);
    }
}