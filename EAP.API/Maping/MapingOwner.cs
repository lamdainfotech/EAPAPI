using AutoMapper;
using EAP.Entity.Models.Accounts;
using EAP.Entity.Models.Owners;
using EAP.Shared.Dtos.Accounts;
using EAP.Shared.Dtos.Owners;

namespace EAP.API.Maping
{
    public class MapingOwner : Profile
    {
        public MapingOwner()
        {
            CreateMap<Owner, OwnerDto>();
            CreateMap<Account, AccountDto>();
            CreateMap<OwnerCreateDto, Owner>().ReverseMap();
            CreateMap<AccountDto, Account>().ReverseMap();
            CreateMap<OwnerForUpdateDto, Owner>();
        }
    }
}