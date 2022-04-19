using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Configurations.DAL;

public class PrimaryKeyFluentConfiguration : IEntityTypeConfiguration<PrimaryKeyFluent>
{
    public void Configure(EntityTypeBuilder<PrimaryKeyFluent> builder)
    {
        builder.HasKey(c => new { c.Pk01, c.Pk02 });
    }
}
