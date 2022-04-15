
using iEFCore.EFQuerySample;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=CourseStore_DB;Integrated Security=true;Encrypt=false;");
//optionBuilder.LogTo(Console.WriteLine);
CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);

// Display : --------------------------------------------------------------------------
//var result = ctx.Courses.ToList();
//foreach (var course in result)
//    Console.WriteLine($"{course.CourseId} {course.Name} {course.Description} {course.Price} {course.StartDate}");

// Queries : --------------------------------------------------------------------------
CourseStoreQueryRepository queryRepository = new CourseStoreQueryRepository(ctx);
//queryRepository.PrintCourseAndTeachers();
//queryRepository.PrintCourseAndTeachersAndTags_EagerLoading();
//queryRepository.PrintCourseAndTeachers_ExplicitLoading();
//queryRepository.CourseShortDTO_SelectLoading();
//queryRepository.Course_ClientVsServer();
//queryRepository.PrintOrderedTags_OrderBy();
//queryRepository.PrintTags_Like();
//queryRepository.PrintTags_Paging();

// Entity State : ----------------------------------------------------------------------
EntityStatePrinter entityStatePrinter = new EntityStatePrinter(ctx);
//entityStatePrinter.Print_DetachedState();
//entityStatePrinter.Print_AddedState();
//entityStatePrinter.Print_DeletedState();
//entityStatePrinter.Print_UpdatedState();
//entityStatePrinter.Print_UnchangedState();

// Commands : --------------------------------------------------------------------------
CourseStoreCommandRepository commandRepository = new CourseStoreCommandRepository(ctx);
//commandRepository.AddTag($"NewTag-{DateTime.Now.Ticks}");
//commandRepository.AddCourseWithComment();
//commandRepository.AddCourseWithFullDependencies();
//commandRepository.UpdateTag_ConectedScenario(1, "ASP.NET Core MVC");

/// Update using Discounected Scenario -------------------------------------------------
/// Way-1:
//var courseDTO = commandRepository.GetCourse(1);
/// Show Web Page
//Console.WriteLine($"{courseDTO.Id} | {courseDTO.Name} | {courseDTO.Description}");
/// Update some fields
//courseDTO.Description = "Updated description for ASP.NET Course (Disconected)";
//commandRepository.UpdateCourse_DisconnectedScenario_Way1(courseDTO);
///-------------------------------------------------------------------------------------
/// Way-2:
//var tagDTO = commandRepository.GetTag(1);
//tagDTO.Name = tagDTO.Name + " By YFereidouni";
//commandRepository.UpdateTag_DisconnectedScenario_Way2(tagDTO);

// Remove : ----------------------------------------------------------------------------
// Way-1 (Soft Delete):
//commandRepository.DisplayAllCourse();
//Console.WriteLine("------------------------------");
//commandRepository.DeleteCourse_SoftDelete(1);
//commandRepository.DisplayAllCourse();

// Way-2 (Phisycal Delete):
//commandRepository.DisplayAllTags();
//Console.WriteLine("------------------------------");
//commandRepository.DeleteTag_PhysicalDelete(7);
//commandRepository.DisplayAllTags();

//Way-3 (Remove with good performance):
//commandRepository.DeleteTag_PhysicalDelete_OptimizePerformance(8);

// Change Teachers: ---------------------------------------------------------------------
//var teacher = commandRepository.GetTeacher(7);
//Console.WriteLine("Your Teacher information is: ");
//Console.WriteLine($"{teacher.Id} | {teacher.FirstName} | {teacher.LastName}");
//Console.WriteLine("".PadLeft(100, '-'));
//Console.Write("Enter New Teacher's FirstName: ");
//teacher.FirstName = Console.ReadLine() ?? "John";
//Console.Write("Enter New Teacher's LastName: ");
//teacher.LastName = Console.ReadLine() ?? "Doe";
//commandRepository.UpdateTeacher_DisconnectedScenario(teacher);
//commandRepository.DisplayAllTeachers();
//commandRepository.UpdateDisount_DisconnectedScenario(10);

// Tips and Tricks: ---------------------------------------------------------------------
TipsAndTricks tipsAndTricks = new TipsAndTricks(ctx);
//tipsAndTricks.AsNoTrackingSample();
//tipsAndTricks.AsNoTrackingSampleWithIdentityResolution();
tipsAndTricks.AddNewCourse("Sample","Sample Description");
