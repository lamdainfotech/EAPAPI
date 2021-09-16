using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Entity.Models.Occupation
{
    [Table("Occupations", Schema = "Occupation")]
    public class Occupations
    {
        [Key]
        [Column("OccupationId")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string OccupationName { get; set; }
    }
}