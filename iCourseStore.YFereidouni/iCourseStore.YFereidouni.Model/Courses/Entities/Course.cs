using iCourseStore.YFereidouni.Model.Framework;
using iCourseStore.YFereidouni.Model.Orders.Entities;

namespace iCourseStore.YFereidouni.Model.Courses.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ImageUrl { get; set; }
    public List<CourseTeacher> CourseTeachers { get; set; }
    public List<CourseTag> CourseTags { get; set; }
    public List<Comment> Comments { get; set; }
    public Discount Discount { get; set; }
}
