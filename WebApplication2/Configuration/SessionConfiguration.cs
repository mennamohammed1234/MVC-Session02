using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Entites;

namespace WebApplication2.Configuration
{
    public class SessionConfiguration:BaseConfiguration<Session>
    {

        public override void Configure(EntityTypeBuilder<Session> builder)
        {

            builder.ToTable(e =>
            e.HasCheckConstraint("capacityconstrain", "Capacity  between 1 and 25")
            );

            builder.ToTable(e =>
            e.HasCheckConstraint("endDateConstraint", "EndDate > StartDate"));
            base.Configure(builder);

            builder.HasOne(e => e.Trainer).WithMany(w => w.Sessions).HasForeignKey(e => e.TrainerId);
        }


    }
}

