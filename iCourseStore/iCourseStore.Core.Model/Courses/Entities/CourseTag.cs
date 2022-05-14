using iCourseStore.Model.Framework;
using iCourseStore.Model.Tags.Entities;

namespace iCourseStore.Model.Courses.Entities;

public class CourseTag : BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }
}
