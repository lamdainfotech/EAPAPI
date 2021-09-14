using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EAP.Shared.Dtos.StatesDto;

namespace EAP.Shared.Dtos.DistrictsDto
{
    public class DistrictsByStateDto
    {

        public int DistrictId { get; set; }
        [StringLength(100)]
        [Required]
        public string DistrictName { get; set; }
        [StringLength(3)]
        public string StateName { get; set; }
    }
}