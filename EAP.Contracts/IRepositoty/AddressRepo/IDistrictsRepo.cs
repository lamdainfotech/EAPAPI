using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Entity.Models.Address;
using EAP.Shared.Dtos.DistrictsDto;

namespace EAP.Contracts.IRepositoty.AddressRepo
{
    public interface IDistrictsRepo
    {
        Task<IEnumerable<Districts>> GetDistrictList();
        Task<IEnumerable<DistrictsByStateDto>> GetDistrictsByState(int stateId);
    }
}