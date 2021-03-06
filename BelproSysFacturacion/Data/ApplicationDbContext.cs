using BelproSysFacturacion.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BelproSysFacturacion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        //Usuar Modelos

        public DbSet<CountyModels> CountyModels { get; set; }
        public DbSet<CountryModels> CountryModels { get; set; }
        public DbSet<StateModel> StateModels { get; set; }

    }
}