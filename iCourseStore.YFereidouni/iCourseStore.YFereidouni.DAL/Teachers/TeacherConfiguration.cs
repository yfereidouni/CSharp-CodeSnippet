using iCourseStore.YFereidouni.Model.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iCourseStore.YFereidouni.DAL.Teachers;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        throw new NotImplementedException();
    }
}
