using AutoMapper;
using EAP.Entity.Models.Country;
using EAP.Shared.Dtos.CountryDto;

namespace EAP.API.Maping
{
    public class CountryMaping : Profile
    {
        public CountryMaping()
        {
            CreateMap<Countries, CountriesDto>();
            CreateMap<Countries, CountryDtoForLimitiedList>();
        }
    }
}