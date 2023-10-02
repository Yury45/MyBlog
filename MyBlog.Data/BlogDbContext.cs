using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Models.Articles;
using MyBlog.Data.Models.Comments;
using MyBlog.Data.Models.Roles;
using MyBlog.Data.Models.Tags;
using MyBlog.Data.Models.Users;

namespace MyBlog.Data
{
    public class BlogDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Article>().ToTable("articles");
            builder.Entity<Comment>().ToTable("comments");
            builder.Entity<Role>().ToTable("roles");
            builder.Entity<Tag>().ToTable("tags");
            builder.Entity<User>().ToTable("users");

            builder.Entity<Comment>()
            .HasOne(a => a.User)
            .WithMany(b => b.Comments)
            .HasForeignKey(c => c.UserId)
            .HasPrincipalKey(d => d.Id)
            .IsRequired(false);
        }
    }
}