using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Numerics;
using System.Reflection;

namespace WebApplication2.Dbcontext
{
    public class Gymcontxt:DbContext
    {

       public Gymcontxt(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

       public DbSet<Entites.Plane> planes {  get; set; }
       public DbSet<Entites.Membership> Membership { get; set; }
       public DbSet<Entites.Session> sessions { get; set; }

    }
}
