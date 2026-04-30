using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            base.OnConfiguring(optionsBuilder);
            //DB for production (publish)
            optionsBuilder.UseSqlServer("REPLACE_WITH_YOUR_CONNECTION_STRING");

            //DB for dev
            // optionsBuilder.UseSqlServer("Server=.;Database=MVCProject;TrustServerCertificate=True;Trusted_Connection=True");
        }


    }
    
}
