using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Numerics;
using WebApplication2.Entites;
namespace WebApplication2.Configuration
{
    public class PlaneConfiguration:BaseConfiguration<Entites.Plane>
    {
        public override void Configure(EntityTypeBuilder<Entites.Plane> builder)
        {
            builder.ToTable(e =>

            e.HasCheckConstraint("numofdays", "DurationDays  between 1 and 365 ")

            );
            base.Configure(builder);
        }

    }
}
