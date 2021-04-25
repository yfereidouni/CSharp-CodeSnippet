using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.DAL
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tbl_Persons", "dbo");
            //builder.Property(c => c.Name).HasColumnName("fname").HasMaxLength(50).IsRequired().IsUnicode(true);
            //builder.Property(c => c.Family).HasColumnName("lname").HasMaxLength(100).IsRequired().IsUnicode(true);
        }
    }
}
