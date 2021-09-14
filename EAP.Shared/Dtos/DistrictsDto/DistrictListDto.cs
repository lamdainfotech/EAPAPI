using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.DistrictsDto
{
    public class DistrictListDto
    {
        public int DistrictId { get; set; }
        public int StateId { get; set; }
        [StringLength(100)]
        [Required]
        public string DistrictName { get; set; }
        [StringLength(3)]
        public string DistrictCode { get; set; }
    }
}