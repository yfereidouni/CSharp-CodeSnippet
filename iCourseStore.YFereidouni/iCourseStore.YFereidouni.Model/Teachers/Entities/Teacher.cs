using iCourseStore.YFereidouni.Model.Courses.Entities;
using iCourseStore.YFereidouni.Model.Framework;

namespace iCourseStore.YFereidouni.Model.Teachers.Entities;

public class Teacher : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<CourseTeacher> CourseTeachers { get; set; }

}
