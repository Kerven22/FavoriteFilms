using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace FavoriteFilms.Storage
{
    public class FilimDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Filim> Filims { get; set; }

        public FilimDbContext(DbContextOptions<FilimDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }

    }
}
