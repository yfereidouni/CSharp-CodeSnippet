using iCourseStore.NLayer.Core.Entities;
using iCourseStore.NLayer.DAL.EF;

namespace iCourseStore.NLayer.BLL;

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
