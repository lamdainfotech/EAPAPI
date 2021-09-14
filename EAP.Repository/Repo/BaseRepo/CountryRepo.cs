using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.CountryRepo;
using EAP.Entity.Data;
using EAP.Entity.Models.Country;
using EAP.Shared.Dtos.CountryDto;
using Microsoft.EntityFrameworkCore;

namespace EAP.Repository.Repo.BaseRepo
{
    public class CountryRepo : RepositoryBase<Countries>, ICountryRepo
    {
        public CountryRepo(EAPDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Countries>> GetAllCountries()
        {
            return await FindAll()
                .OrderBy(c => c.CountryName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Countries>> GetLimitedCountries()
        {
            return await FindAll()
                .Where(c => c.Code.Contains("NP") ||
                            c.Code.Contains("US"))
                .ToListAsync();
        }
    }
}