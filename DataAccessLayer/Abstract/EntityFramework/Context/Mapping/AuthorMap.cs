using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(I => I.AuthorId);
            builder.Property(I => I.AuthorId).UseIdentityColumn();
            builder.Property(I => I.AuthorName).IsRequired();
            builder.Property(I => I.AuthorSurname).IsRequired();

            builder.HasMany(I => I.books).WithOne(I => I.author).HasForeignKey(I => I.authorID);
        }
    }
}
