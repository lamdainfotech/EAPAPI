using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.AddressRepo;
using EAP.Entity.Data;
using EAP.Entity.Models.Address;
using EAP.Shared.Dtos.MunicipalityDto;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.AddressRepo
{
    public class MunicipalitiesRepo : IMunicipalitiesRepo
    {
        private readonly EAPDbContext _context;

        public MunicipalitiesRepo(EAPDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Municipality>> GetAllMunicipalities()
        {
            return await _context.Municipalities
                .OrderBy(m => m.DistrictId)
                .ToListAsync();
        }

        public async Task<IEnumerable<MunicipalityByDistrictDto>> GetMunicipalityByDistrict(int Id)
        {
            var result = (from m in _context.Set<Municipality>()
                          join d in _context.Set<Districts>()
                          on m.DistrictId equals d.Id
                          where (m.DistrictId.Equals(Id))
                          select new MunicipalityByDistrictDto
                          {
                              MunicipalityId = m.Id,
                              DistrictName = d.DistrictName,
                              GPNPName = m.GPNPName
                          })
                          .OrderBy(d => d.MunicipalityId)
                          .ToListAsync(); return await result;
        }
    }
}