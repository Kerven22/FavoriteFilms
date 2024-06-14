using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FavoriteFilims.Storage.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(f => f.UserId);
            builder
                .HasMany(f => f.Likes)
                .WithOne(f => f.Author);
            builder
                .HasMany(f => f.Comments)
                .WithOne(f => f.User);
        }
    }
}
