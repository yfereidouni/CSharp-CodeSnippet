using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace iEFCore.Configurations.DAL
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tbl_People", "dbo");
            builder.Property(c => c.Name).HasColumnName("FirstName").HasMaxLength(50).IsRequired().IsUnicode(true);
            builder.Property(c => c.Family).HasColumnName("LastName").HasMaxLength(100).IsRequired().IsUnicode(true);
        }
    }
}
