
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

// Queries : ---------------------------------
CourseStoreQueryRepository queryRepository = new CourseStoreQueryRepository(ctx);
//queryRepository.PrintCourseAndTeachers();
//queryRepository.PrintCourseAndTeachersAndTags_EagerLoading();
//queryRepository.PrintCourseAndTeachers_ExplicitLoading();
//queryRepository.CourseShortDTO_SelectLoading();
//queryRepository.Course_ClientVsServer();
//queryRepository.PrintOrderedTags_OrderBy();
//queryRepository.PrintTags_Like();
//queryRepository.PrintTags_Paging();

// Entity State : ----------------------------------
EntityStatePrinter entityStatePrinter = new EntityStatePrinter(ctx);
//entityStatePrinter.Print_DetachedState();
//entityStatePrinter.Print_AddedState();
//entityStatePrinter.Print_DeletedState();
//entityStatePrinter.Print_UpdatedState();
//entityStatePrinter.Print_UnchangedState();

// Commands : ---------------------------------
CourseStoreCommandRepository commandRepository = new CourseStoreCommandRepository (ctx);
//commandRepository.AddTag($"NewTag-{DateTime.Now.Ticks}");
//commandRepository.AddCourseWithComment();
commandRepository.AddCourseWithFullDependencies();