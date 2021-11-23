using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(I => I.GenreId);
            builder.Property(I => I.GenreId).UseIdentityColumn();
            builder.Property(I => I.GenreName).HasMaxLength(100).IsRequired();

            builder.HasMany(I => I.books).WithOne(I => I.genre).HasForeignKey(I => I.genreID);

        }
    }
}
    