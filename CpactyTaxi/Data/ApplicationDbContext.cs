using CpactyTaxi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CpactyTaxi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-CpactyTaxi-E20ACFF1-7A20-4C6D-8C70-9C33A0465009;Trusted_Connection=True;MultipleActiveResultSets=true";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionsBuilder)
            : base(optionsBuilder)
        { optionsBuilder.UseSqlServer(ConnectionString); }
                    public DbSet<Adress> adress { get; set; }

    }
}
