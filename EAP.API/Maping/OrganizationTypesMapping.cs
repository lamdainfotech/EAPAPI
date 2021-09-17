using AutoMapper;
using EAP.Entity.Models.Organizations;
using EAP.Shared.Dtos.OrganizationsDto.OrganizationTypesDto;

namespace EAP.API.Maping
{
    public class OrganizationTypesMapping : Profile
    {
        public OrganizationTypesMapping()
        {
            CreateMap<OrganizationType, OrganizationTypesForListDto>();
        }

    }
}