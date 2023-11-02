using SIRENSIRETApplication.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace SIRENSIRETApplication.Server.DataAccess
{
    public class DomainModelSqlContext : DbContext
    {
        public DomainModelSqlContext(DbContextOptions<DomainModelSqlContext> options) : base(options)
        {
        }

        public DbSet<Saisie> saisie { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

    }
}