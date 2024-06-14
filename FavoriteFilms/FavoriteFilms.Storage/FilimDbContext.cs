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

    }
}
