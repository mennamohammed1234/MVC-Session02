using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Entites;

namespace WebApplication2.Configuration
{
    public class GymUserConfiguration<gymuser> : BaseConfiguration<gymuser> where gymuser : GymUser
    {
        public override  void Configure(EntityTypeBuilder<gymuser> builder)
        {

            builder.Property(e => e.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.ComplexProperty(e => e.Adress);

            builder.Property(e => e.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.HasIndex(e => e.Email).IsUnique();
            builder.ToTable(e =>
            e.HasCheckConstraint("formEmail", "Email like '_%@_._%' ")
            );

            builder.Property(e => e.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.HasIndex(e=>e.Phone).IsUnique();
            builder.ToTable(e =>
            e.HasCheckConstraint("format_phone", "LEN(phone)=11 and (phone  like '010%' or phone like '011%' or phone like '012%'  ) ")
            );



                
          base.Configure(builder);
        }
    }
}
