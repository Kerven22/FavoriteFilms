using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FavoriteFilims.Storage.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(f => f.CommentId);

            builder
                .HasOne(f => f.User)
                .WithMany(f => f.Comments);
            builder
                .HasOne(f => f.Filim)
                .WithMany(f => f.Comments);    
        }
    }
}
