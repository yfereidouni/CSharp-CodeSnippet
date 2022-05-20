using iCourseStore.YFereidouni.Model.Framework;

namespace iCourseStore.YFereidouni.Model.Courses.Entities;

public class Comment : BaseEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string CommentBy { get; set; }
    public DateTime CommentDate { get; set; }
    public string CommentText { get; set; }
    public int StarCount { get; set; }
    public bool IsApproved { get; set; }
}
