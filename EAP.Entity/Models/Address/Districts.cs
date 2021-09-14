using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Entity.Models.Address
{
    [Table("Districts", Schema = "Address")]
    public class Districts
    {
        [Key]
        [Column("DistrictId")]
        public int Id { get; set; }
        public int StateId { get; set; }
        [StringLength(100)]
        [Required]
        public string DistrictName { get; set; }
        [StringLength(3)]
        public string DistrictCode { get; set; }
    }
}