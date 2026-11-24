using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebApplication2.Dbcontext
{
    public class Gymcontxt:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; DataBase=GymManagment; Trusted_Connection=True; TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
