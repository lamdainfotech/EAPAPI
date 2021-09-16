using EAP.Entity.Models.Occupation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EAP.Entity.Configurations
{
    public class OccupationsConfiguration : IEntityTypeConfiguration<Occupations>
    {
        public void Configure(EntityTypeBuilder<Occupations> builder)
        {
            builder.HasData(
                new Occupations { Id = 1, OccupationName = "Farmer" },
                new Occupations { Id = 2, OccupationName = "Government Job" },
                new Occupations { Id = 3, OccupationName = "Business" },
                new Occupations { Id = 4, OccupationName = "Others" }
                );
        }
    }
}