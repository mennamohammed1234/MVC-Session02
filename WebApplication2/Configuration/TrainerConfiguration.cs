using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Entites;

namespace WebApplication2.Configuration
{
    public class TrainerConfiguration:GymUserConfiguration<Trainer>
    {

        public override void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(e => e.CreatedAt).HasDefaultValueSql("GETDATE()").HasColumnName("HireDate");

            base.Configure(builder);
        }
    }
}
