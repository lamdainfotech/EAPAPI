using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Entity.Models.Address
{
    [Table("Municipalities", Schema = "Address")]
    public class Municipality
    {
        [Key]
        [Column("MunicipalityId")]
        public int Id { get; set; }
        public int DistrictId { get; set; }
        [StringLength(100)]
        public string GPNPName { get; set; }
        [StringLength(2)]
        public string Code { get; set; }
    }
}