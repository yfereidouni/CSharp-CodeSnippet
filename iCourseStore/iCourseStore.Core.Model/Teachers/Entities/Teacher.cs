using iCourseStore.Model.Courses.Entities;
using iCourseStore.Model.Framework;

namespace iCourseStore.Model.Teachers.Entities;

public class Teacher : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<CourseTeacher> CourseTeachers { get; set; }

}
