using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Entity.Models.Organizations
{
    [Table("OrganizationType", Schema = "Organization")]
    public class OrganizationType
    {
        public Guid OrganizationTypeID { get; set; }
        [StringLength(50)]
        public string OrgType { get; set; }
        [StringLength(300)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}