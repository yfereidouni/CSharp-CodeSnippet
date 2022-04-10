
using iEFCore.EFQuerySample;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=CourseStore_DB;Integrated Security=true;Encrypt=false;");
//optionBuilder.LogTo(Console.WriteLine);
CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);

// Display : ---------------------------------------
//var result = ctx.Courses.ToList();
//foreach (var course in result)
//    Console.WriteLine($"{course.CourseId} {course.Name} {course.Description} {course.Price} {course.StartDate}");

// Eager Loading : ---------------------------------
CourseStoreRepository repository = new CourseStoreRepository(ctx);
//repository.PrintCourseAndTeachers();
//repository.PrintCourseAndTeachersAndTags_EagerLoading();
//repository.PrintCourseAndTeachers_ExplicitLoading();
//repository.CourseShortDTO_SelectLoading();
//repository.Course_ClientVsServer();
//repository.PrintOrderedTags_OrderBy();
//repository.PrintTags_Like();
//repository.PrintTags_Paging();

// Entity State : ----------------------------------
EntityStatePrinter entityStatePrinter = new EntityStatePrinter(ctx);
entityStatePrinter.Print_DetachedState();
entityStatePrinter.Print_AddedState();
entityStatePrinter.Print_DeletedState();
entityStatePrinter.Print_UpdatedState();
entityStatePrinter.Print_UnchangedState();