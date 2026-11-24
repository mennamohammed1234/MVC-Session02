using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Entites;

namespace WebApplication2.Configuration
{
    public class MemberConfiguration:GymUserConfiguration<Member>
    {
        public override void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()").HasColumnName("JoinDate");
            base.Configure(builder);
        }
    }
}
