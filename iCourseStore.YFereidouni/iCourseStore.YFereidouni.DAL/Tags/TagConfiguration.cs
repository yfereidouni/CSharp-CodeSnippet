using iCourseStore.YFereidouni.Model.Tags.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iCourseStore.YFereidouni.DAL.Tags;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        throw new NotImplementedException();
    }
}
