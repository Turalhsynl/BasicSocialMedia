using BasicSocialMedia.Concrate;
using BasicSocialMedia.Concratel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicSocialMedia.Project.DAL.Configurations;

public class PostConfigurations : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.Property(x => x.Text)
               .IsRequired()
               .HasMaxLength(300);

        builder.Property(x => x.LikeCount)
               .HasDefaultValue(0);

        builder.HasMany(x => x.Comments)
               .WithMany(y => y.Posts)
               .UsingEntity<Dictionary<string, object>>("PostComment"
               , z => z.HasOne<Comment>().WithMany().HasForeignKey("CommentId")
               , z => z.HasOne<Post>().WithMany().HasForeignKey("PostId"));
    }
}
