using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.CountryDto
{
    public class CountriesDto
    {
        public int Id { get; set; }
        [StringLength(200, ErrorMessage = "Country Name not more than 200 character")]
        public string CountryName { get; set; }
        [StringLength(2, ErrorMessage = "Country code not more than 2 character")]
        public string Code { get; set; }
    }
}