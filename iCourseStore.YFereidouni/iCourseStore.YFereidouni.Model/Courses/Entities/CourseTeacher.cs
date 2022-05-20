using iCourseStore.YFereidouni.Model.Framework;
using iCourseStore.YFereidouni.Model.Teachers.Entities;

namespace iCourseStore.YFereidouni.Model.Courses.Entities;

public class CourseTeacher : BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int SortOrder { get; set; }
}
