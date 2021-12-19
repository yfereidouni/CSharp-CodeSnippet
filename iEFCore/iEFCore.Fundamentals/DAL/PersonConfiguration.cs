using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Fundamentals.DAL
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("tbl_People", "YFO").HasIndex(p => new { p.FirstName, p.LastName }).IsUnique();
            builder.Property(c => c.FirstName).HasMaxLength(50).IsRequired().IsUnicode();
            builder.Property(c => c.LastName).HasMaxLength(50).IsRequired().IsUnicode();
        }
    }
}
