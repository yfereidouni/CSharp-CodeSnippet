using iCourseStore.YFereidouni.Model.Courses.Entities;
using iCourseStore.YFereidouni.Model.Framework;

namespace iCourseStore.YFereidouni.Model.Tags.Entities;

public class Tag : BaseEntity
{
    public string TagName { get; set; }
    public List<CourseTag> CourseTags { get; set; }
}