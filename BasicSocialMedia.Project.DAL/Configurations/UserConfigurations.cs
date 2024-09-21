using BasicSocialMedia.Concrate;
using Microsoft.EntityFrameworkCore;

namespace BasicSocialMedia.Project.DAL.Configurations;

public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        builder.HasMany(x => x.Posts)
               .WithOne(y => y.User)
               .HasForeignKey(y => y.UserId);
    }
}
