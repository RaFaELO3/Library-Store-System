using System;
using System.Collections.Generic;
using System.Text;
using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(I => I.BookID);
            builder.Property(I => I.BookID).UseIdentityColumn();
            builder.Property(I => I.BookName).HasMaxLength(100).IsRequired();
            builder.Property(I => I.BookCount).IsRequired();
            builder.Property(I => I.BookPrice).IsRequired();

            builder.HasOne(I => I.genre).WithMany(I => I.books).HasForeignKey(I => I.genreID);  
        }
    }
}
