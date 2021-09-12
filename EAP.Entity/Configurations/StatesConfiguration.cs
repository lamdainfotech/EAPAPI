using EAP.Entity.Models.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EAP.Entity.Configurations
{
    public class StatesConfiguration : IEntityTypeConfiguration<States>
    {
        public void Configure(EntityTypeBuilder<States> builder)
        {
            builder.HasData(
                new States { Id = 1, CountryId = 152, StateName = "Province No. 1" },
                new States { Id = 2, CountryId = 152, StateName = "Province No. 2" },
                new States { Id = 3, CountryId = 152, StateName = "Province No. 3" },
                new States { Id = 4, CountryId = 152, StateName = "Gandaki" },
                new States { Id = 5, CountryId = 152, StateName = "Province No. 5" },
                new States { Id = 6, CountryId = 152, StateName = "Karnali" },
                new States { Id = 7, CountryId = 152, StateName = "PSudurpashchim" }
                );
        }
    }
}