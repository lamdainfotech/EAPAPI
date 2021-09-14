using AutoMapper;
using EAP.Entity.Models.Address;
using EAP.Shared.Dtos.DistrictsDto;

namespace EAP.API.Maping
{
    public class DistrictMapping : Profile
    {
        public DistrictMapping()
        {
            CreateMap<Districts, DistrictsByStateDto>();
            // .ForMember(dst => dst.DistrictId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Districts, DistrictListDto>()
                .ForMember(dst => dst.DistrictId, opt => opt.MapFrom(src => src.Id));
        }
    }
}