using iCourseStore.Model.Courses.Entities;
using iCourseStore.Model.Framework;

namespace iCourseStore.Model.Tags.Entities;

public class Tag : BaseEntity
{
    public string TagName { get; set; }
    public List<CourseTag> CourseTags { get; set; }
}
