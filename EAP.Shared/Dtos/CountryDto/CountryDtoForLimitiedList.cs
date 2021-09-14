using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.CountryDto
{
    public class CountryDtoForLimitiedList
    {
        public int Id { get; set; }
        [StringLength(200, ErrorMessage = "Country Name not more than 200 character")]
        public string CountryName { get; set; }
    }
}