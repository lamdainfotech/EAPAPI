using System;
using System.ComponentModel.DataAnnotations;

namespace EAP.Shared.Dtos.OrganizationsDto.OrganizationTypesDto
{
    public class OrganizationTypesForListDto
    {
        public Guid OrganizationTypeID { get; set; }
        public string OrgType { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}