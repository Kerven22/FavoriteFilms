using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FavoriteFilims.Storage.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(f => f.ReviewId);
            builder
                .HasOne(f => f.Filim)
                .WithOne(f => f.Review);
        }
    }
}
