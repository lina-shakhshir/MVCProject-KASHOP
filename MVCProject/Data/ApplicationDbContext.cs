using Microsoft.EntityFrameworkCore;

namespace MVCProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            base.OnConfiguring(optionsBuilder);
            //DB for production (publish)
            optionsBuilder.UseSqlServer("Server=db43627.public.databaseasp.net; Database=db43627; User Id=db43627; Password=d@9J!Cg52+Yj; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True; ");

            //DB for dev
           // optionsBuilder.UseSqlServer("Server=.;Database=MVCProject;TrustServerCertificate=True;Trusted_Connection=True");
        }


    }
}
