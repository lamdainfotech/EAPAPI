using AutoMapper;
using EAP.Entity.Models.Address;
using EAP.Shared.Dtos.StatesDto;

namespace EAP.API.Maping
{
    public class StatesMap : Profile
    {
        public StatesMap()
        {
            CreateMap<States, StateDtoForAllStates>();
            CreateMap<States, StatesDtoForOnlyState>();
        }
    }
}