using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iEFCore.Configurations.DAL;

public class ReadOnlyFluentConfiguration : IEntityTypeConfiguration<ReadOnlyFluent>
{
    public void Configure(EntityTypeBuilder<ReadOnlyFluent> builder)
    {
        builder.HasNoKey();
    }
}
