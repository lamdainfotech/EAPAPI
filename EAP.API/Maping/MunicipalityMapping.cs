using AutoMapper;
using EAP.Entity.Models.Address;
using EAP.Shared.Dtos.MunicipalityDto;

namespace EAP.API.Maping
{
    public class MunicipalityMapping : Profile
    {
        public MunicipalityMapping()
        {
            CreateMap<Municipality, MunicipalityListDto>();
            CreateMap<Municipality, MunicipalityByDistrictDto>();
        }
    }
}