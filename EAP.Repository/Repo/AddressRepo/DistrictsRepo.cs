using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Entity.Data;
using EAP.Entity.Models.Address;
using EAP.Repository.Repo.BaseRepo;
using EAP.Shared.Dtos.DistrictsDto;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.AddressRepo
{
    public class DistrictsRepo : IDistrictsRepo
    {
        private readonly EAPDbContext _context;
        public DistrictsRepo(EAPDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Districts>> GetDistrictList()
        {
            return await _context.Districts.ToListAsync();
        }

        public async Task<IEnumerable<DistrictsByStateDto>> GetDistrictsByState(int stateId)
        {
            var query = await (from district in _context.Set<Districts>()
                               join state in _context.Set<States>()
                               on district.StateId equals state.Id
                               where (district.StateId.Equals(stateId))
                               select new DistrictsByStateDto
                               {
                                   DistrictId = district.Id,
                                   DistrictName = district.DistrictName,
                                   StateName = state.StateName
                               })
                              .ToListAsync();
            return query;
        }
    }
}