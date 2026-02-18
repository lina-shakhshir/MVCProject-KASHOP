using Microsoft.EntityFrameworkCore;

namespace MVCProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=MVCProject;TrustServerCertificate=True;Trusted_Connection=True");
        }


    }
}
