using iCourseStore.Core.Entities;
using iCourseStore.DAL.CourseStoreDB;

namespace iCourseStore.BLL;

public class CourseServices
{
    private readonly CourseStoreDbContext dbContext;

    public CourseServices(CourseStoreDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public List<Course> GetAllCourse()
    {
       return dbContext.Courses.ToList();
    }
}
