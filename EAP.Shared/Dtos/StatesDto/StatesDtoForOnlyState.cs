using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.StatesDto
{
    public class StatesDtoForOnlyState
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string StateName { get; set; }
    }
}