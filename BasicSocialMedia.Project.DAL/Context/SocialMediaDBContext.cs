using BasicSocialMedia.Concrate;
using BasicSocialMedia.Concratel;
using BasicSocialMedia.Project.DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BasicSocialMedia.Project.DAL.Context;

public class SocialMediaDBContext : DbContext
{
    public DbSet<UserDetails> UserDetails { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-NPULDG2;Initial Catalog = Fakebook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserDetailsConfigurations());
        modelBuilder.ApplyConfiguration(new UserConfigurations());
        modelBuilder.ApplyConfiguration(new PostConfigurations());
        modelBuilder.ApplyConfiguration(new CommentConfigurations());
        base.OnModelCreating(modelBuilder);
    }
}
