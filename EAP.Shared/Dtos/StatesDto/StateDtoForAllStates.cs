using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.StatesDto
{
    public class StateDtoForAllStates
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        [StringLength(100)]
        public string StateName { get; set; }
        [StringLength(2)]
        public string Code { get; set; }
    }
}