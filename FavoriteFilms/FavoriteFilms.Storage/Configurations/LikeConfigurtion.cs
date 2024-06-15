﻿using FavoriteFilms.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FavoriteFilims.Storage.Configurations
{
    public class LikeConfigurtion : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(f => f.LikeId);

            builder
                .HasOne(f => f.Filim)
                .WithMany(f => f.Likes)
                .HasForeignKey(f => f.FilimId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder
                .HasOne(f => f.Author)
                .WithMany(f => f.Likes)
                .HasForeignKey(f=>f.UserId)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
