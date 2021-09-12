using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Entity.Models.Address;

namespace EAP.Contracts.IRepositoty.AddressRepo
{
    public interface IStatesRepo
    {
        Task<IEnumerable<States>> GetAllStates();
        Task<IEnumerable<States>> GetOnlyStates();
    }
}