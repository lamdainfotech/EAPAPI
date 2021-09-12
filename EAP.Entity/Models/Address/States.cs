using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Entity.Models.Address
{
    [Table("States", Schema = "Address")]
    public class States
    {
        [Key]
        [Column("StateId")]
        public int Id { get; set; }
        public int CountryId { get; set; }
        [StringLength(100)]
        public string StateName { get; set; }
        [StringLength(2)]
        public string Code { get; set; }
    }
}