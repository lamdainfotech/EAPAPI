using System.Collections.Generic;
using System.Threading.Tasks;
using EAP.Entity.Models.Country;

namespace EAP.Contracts.IRepositoty.CountryRepo
{
    public interface ICountryRepo
    {
        Task<IEnumerable<Countries>> GetAllCountries();
        Task<IEnumerable<Countries>> GetLimitedCountries();
    }
}