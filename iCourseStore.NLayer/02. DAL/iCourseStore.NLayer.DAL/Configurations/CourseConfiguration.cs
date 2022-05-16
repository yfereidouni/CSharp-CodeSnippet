using iCourseStore.NLayer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iCourseStore.DAL.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.ImageUrl).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);
            builder.Property(c => c.Description).IsRequired();
        }
    }
}
