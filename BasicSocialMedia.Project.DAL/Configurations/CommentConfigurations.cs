using BasicSocialMedia.Concratel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicSocialMedia.Project.DAL.Configurations;

public class CommentConfigurations : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(x => x.Text)
               .IsRequired()
               .HasMaxLength(300);

        builder.Property(x => x.LikeCount)
               .HasDefaultValue(0);
    }
}
