using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace iCourseStore.DAL.CourseStoreDB;

public class CourseStoreContextFactory : IDesignTimeDbContextFactory<CourseStoreDbContext>
{
    public CourseStoreDbContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
        optionBuilder.UseSqlServer("Server=.;Initial Catalog=S27E02.iCourseStore_DB;User Id=dbuser;Password=1qaz!QAZ;");
        CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);
        return ctx;
    }
}
