using iCourseStore.DAL.CourseStoreDB;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("------ iCourseStore ------");

var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=iCourseStore_DB;User Id=dbuser;Password=1qaz!QAZ;");
CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);

var result = ctx.Courses.ToList();

foreach (var course in result)
{
    Console.WriteLine($"{course.Id} {course.Name} {course.Description} {course.Price} {course.StartDate}");

}