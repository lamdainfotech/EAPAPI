using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Entity.Models.Country
{
    [Table("Countries", Schema = "Countries")]
    public class Countries
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string CountryName { get; set; }
        [StringLength(2)]
        public string Code { get; set; }
    }
}