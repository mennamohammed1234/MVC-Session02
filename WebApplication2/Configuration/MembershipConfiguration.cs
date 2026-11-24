using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Entites;

namespace WebApplication2.Configuration
{
    public class MembershipConfiguration:BaseConfiguration<Membership>
    {

        public override void Configure(EntityTypeBuilder<Membership> builder)
        {

            builder.Property(e => e.StartDate).HasDefaultValueSql("GETDATE()");


            builder.HasOne(e => e.Member).WithMany(b => b.MemberSubscriptions).HasForeignKey(e=>e.MemberId);
            builder.HasOne(e => e.Plane).WithMany(w => w.MemberSubscriptions).HasForeignKey(e => e.PlaneId);

            base.Configure(builder);
        }


    }
}
