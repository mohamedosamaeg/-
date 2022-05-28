using CpactyTaxi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CpactyTaxi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      //  public const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=CpactyTaxiDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionsBuilder)
           : base(optionsBuilder)
        {
            
        }
        public DbSet<Adress> adress { get; set; }

    }
}
