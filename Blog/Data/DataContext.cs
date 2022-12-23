using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Post>? Posts { get; set; }
        //public DbSet<PostTag>? PostTags { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Tag>? Tags { get; set; }
        public DbSet<User>? Users { get; set; }
        //public DbSet<UserRole>? UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=Ericsouza.123;TrustServerCertificate=True");
    }
}