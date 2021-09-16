using AutoMapper;
using EAP.Entity.Models.Occupation;
using EAP.Shared.Dtos.OccupationsDto;

namespace EAP.API.Maping
{
    public class OccupationsMapping : Profile
    {
        public OccupationsMapping()
        {
            CreateMap<Occupations, OccupationsListDto>()
                .ForMember(dst => dst.OccupationId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.OccupationName, opt => opt.MapFrom(src => src.OccupationName));
        }
    }
}