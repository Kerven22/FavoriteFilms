using FavoriteFilims.Storage.Configurations;
using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace FavoriteFilms.Storage
{
    public class FilimDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Filim> Filims { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public FilimDbContext(DbContextOptions<FilimDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FilimConfiguration());
            modelBuilder.ApplyConfiguration(new LikeConfigurtion());
            modelBuilder.ApplyConfiguration(new StarConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
