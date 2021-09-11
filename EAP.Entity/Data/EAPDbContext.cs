using EAP.Entity.Models.Accounts;
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
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}