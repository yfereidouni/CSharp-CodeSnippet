using iCourseStore.Core.DAL;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=CourseStore_DB;Integrated Security=true;Encrypt=false;");
CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);

var result = ctx.Courses.ToList();

foreach (var course in result)
{
    Console.WriteLine($"{course.CourseId} {course.Name} {course.Description} {course.Price} {course.StartDate}");

}