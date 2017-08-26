using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PortfolioDeux.Models
{
    public class PortfolioDeuxDbContext : IdentityDbContext<ApplicationUser>
    {
        public PortfolioDeuxDbContext()
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=portfolio_scripts;integrated security=True");
        }

        public PortfolioDeuxDbContext(DbContextOptions<PortfolioDeuxDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}