﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Configuration
{
    /// <summary>
    /// Конфигурация таблицы Posts.
    /// </summary>
    internal class PostConfiguration : IEntityTypeConfiguration<Domain.Posts.Post>
    {
        public void Configure(EntityTypeBuilder<Domain.Posts.Post> builder)
        {
            builder.ToTable(nameof(Domain.Posts.Post));

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
