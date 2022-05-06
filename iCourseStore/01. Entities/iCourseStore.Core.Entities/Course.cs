namespace iCourseStore.Core.Entities;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime StartDate { get; set; }
    public ICollection<CourseTeachers> CourseTeachers { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public Discount Discount { get; set; }
}
