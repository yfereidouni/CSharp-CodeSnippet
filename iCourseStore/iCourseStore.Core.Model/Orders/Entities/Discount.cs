using iCourseStore.Model.Courses.Entities;
using iCourseStore.Model.Framework;

namespace iCourseStore.Model.Orders.Entities;

public class Discount : BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string Name { get; set; }
    public int NewPrice { get; set; }
}
