using System;
using EAP.Entity.Models.Organizations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EAP.Entity.Configurations
{
    public class OrganizationTypesConfiguration : IEntityTypeConfiguration<OrganizationType>
    {
        public void Configure(EntityTypeBuilder<OrganizationType> builder)
        {
            builder.HasData(
                new OrganizationType { OrganizationTypeID = Guid.NewGuid(), OrgType = "Academic" },
                new OrganizationType { OrganizationTypeID = Guid.NewGuid(), OrgType = "Information & Technology" }
            );
        }
    }
}