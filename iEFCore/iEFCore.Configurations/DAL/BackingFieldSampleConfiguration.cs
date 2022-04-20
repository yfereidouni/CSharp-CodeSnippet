using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Configurations.DAL;

public class BackingFieldSampleConfiguration : IEntityTypeConfiguration<BackingFieldSample>
{
    public void Configure(EntityTypeBuilder<BackingFieldSample> builder)
    {
        builder.Property(c => c.FatherName).HasField("fathernameFluent");
        builder.Property<DateTime>("_birthDateField").HasColumnName("DateOfBirth");
    }
}
