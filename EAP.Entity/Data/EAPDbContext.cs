using EAP.Entity.Configurations;
using EAP.Entity.Models.Accounts;
using EAP.Entity.Models.Address;
using EAP.Entity.Models.Country;
using EAP.Entity.Models.Owners;
using Microsoft.EntityFrameworkCore;

namespace EAP.Entity.Data
{
    public class EAPDbContext : DbContext
    {
        public EAPDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<States> States { get; set; }
        public DbSet<Countries> Countries { get; set; }
        // public DbSet<Owner> Owners { get; set; }
        // public DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.ApplyConfiguration(new AdmissionFormStatusConfiguration());
            // modelBuilder.ApplyConfiguration(new StudentClassesConfiguration());
            // modelBuilder.ApplyConfiguration(new StudentCastsConfiguration());
            // modelBuilder.ApplyConfiguration(new ReligionsConfiguration());
            // modelBuilder.ApplyConfiguration(new OccupationsConfiguration());
            // modelBuilder.ApplyConfiguration(new DistrictsConfiguration());
            modelBuilder.ApplyConfiguration(new StatesConfiguration());
            modelBuilder.ApplyConfiguration(new CountriesConfiguration());
            // modelBuilder.ApplyConfiguration(new OrganizationTypesConfiguration());
            // modelBuilder.ApplyConfiguration(new GendersConfiguration());
        }
    }
}