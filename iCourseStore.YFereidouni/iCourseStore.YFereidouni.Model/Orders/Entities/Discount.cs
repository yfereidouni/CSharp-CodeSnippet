using iCourseStore.YFereidouni.Model.Courses.Entities;
using iCourseStore.YFereidouni.Model.Framework;

namespace iCourseStore.YFereidouni.Model.Orders.Entities;

public class Discount : BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string Name { get; set; }
    public int NewPrice { get; set; }
}
