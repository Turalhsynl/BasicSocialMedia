using BasicSocialMedia.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicSocialMedia.Project.DAL.Configurations;

public class UserDetailsConfigurations : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(x => x.Surname)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(x => x.Birthday)
               .IsRequired();

        builder.Property(x => x.Role)
               .IsRequired();

        builder.HasOne(x => x.User)
              .WithOne(y => y.UserDetails)
              .HasForeignKey<User>(y => y.UserDetailsId);
    }
}
