using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FavoriteFilims.Storage.Configurations
{
    public class FilimConfiguration : IEntityTypeConfiguration<Filim>
    {
        public void Configure(EntityTypeBuilder<Filim> builder)
        {
            builder.HasKey(f => f.FilimId);
            builder
                .HasOne(f => f.Review)
                .WithOne(f => f.Filim);
            builder
                .HasMany(f => f.Stars)
                .WithMany(f => f.Filims);
            builder
                .HasMany(f => f.Comments)
                .WithOne(f => f.Filim);
            builder
                .HasMany(f => f.Likes)
                .WithOne(f => f.Filim);
        }
    }
}
