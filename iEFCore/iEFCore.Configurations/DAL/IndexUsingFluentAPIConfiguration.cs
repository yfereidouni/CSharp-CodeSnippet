using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iEFCore.Configurations.DAL;

public class IndexUsingFluentAPIConfiguration : IEntityTypeConfiguration<IndexUsingFluentAPI>
{
    public void Configure(EntityTypeBuilder<IndexUsingFluentAPI> builder)
    {
        builder.HasIndex(c => new { c.Name }).HasDatabaseName("IX_Name_USING_FLUENT").IsUnique().HasFilter("[Filtered] IS NOT NULL");
    }
}
