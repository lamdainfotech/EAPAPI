using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.MunicipalityDto
{
    public class MunicipalityListDto
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public string GPNPName { get; set; }
        public string Code { get; set; }
    }
}