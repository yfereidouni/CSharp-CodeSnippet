using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace iCourseStore.Core.DAL;

public class CourseStoreContextFactory : IDesignTimeDbContextFactory<CourseStoreDbContext>
{
    public CourseStoreDbContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
        optionBuilder.UseSqlServer("Server=.;Initial Catalog=CourseStore_DB;Integrated Security=true;Encrypt=false;");
        CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);
        return ctx;
    }
}
