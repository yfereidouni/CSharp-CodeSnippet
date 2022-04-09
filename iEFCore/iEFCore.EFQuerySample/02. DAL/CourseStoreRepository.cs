using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.EFQuerySample;

public class CourseStoreRepository
{
    private readonly CourseStoreDbContext courseStoreDbContext;

    public CourseStoreRepository(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }

    public void PrintCourseAndTeachers_EagerLoading()
    {
        // Eager Loading : Load a table and all subsequent tables
        Console.WriteLine("\r\nEager Loading ".PadRight(100, '-') + "\r\n");
        var result = courseStoreDbContext.Courses.Include(c => c.CourseTeachers).ThenInclude(c => c.Teacher).ToList();

        foreach (var course in result)
        {
            Console.WriteLine($"Course: {course.Name}");
            foreach (var teacher in course.CourseTeachers)
            {
                Console.WriteLine($"\t\t{teacher.Teacher.FirstName}, {teacher.Teacher.LastName}");
            }
        }
        Console.WriteLine("\r\n".PadRight(100, '-') + "\r\n");
    }
    public void PrintCourseAndTeachersAndTags_EagerLoading()
    {
        // Eager Loading and filtering data : Load a table and all subsequent tables
        Console.WriteLine("\r\nEager Loading ".PadRight(100, '-') + "\r\n");
        var result = courseStoreDbContext.Courses
            .Include(c => c.CourseTeachers.OrderBy(x=>x.SortOrder)).ThenInclude(c => c.Teacher)
            .Include(c=>c.Tags.Take(2))
            .ToList();

        foreach (var course in result)
        {
            Console.WriteLine($"Course: {course.Name}");
            foreach (var teacher in course.CourseTeachers)
            {
                Console.WriteLine($"\t\tTeacher: {teacher.Teacher.FirstName}, {teacher.Teacher.LastName}");
            }
            Console.WriteLine();
            foreach (var tag in course.Tags)
            {
                Console.WriteLine($"\t\tTag: {tag.Name}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\r\n".PadRight(100, '-') + "\r\n");
    }
    public void PrintCourseAndTeachers_ExplicitLoading()
    {
        // Explicit Loading : 
        Console.WriteLine("\r\nExplicit Loading ".PadRight(100, '-') + "\r\n");
        var result = courseStoreDbContext.Courses.ToList();

        foreach (var course in result)
        {
            Console.WriteLine($"Course: {course.Name}");
            courseStoreDbContext.Entry(course).Collection(c => c.CourseTeachers).Load();
            foreach (var courseteacher in course.CourseTeachers)
            {
                courseStoreDbContext.Entry(courseteacher).Reference(c => c.Teacher).Load();
                Console.WriteLine($"\t\t{courseteacher.Teacher.FirstName}, {courseteacher.Teacher.LastName}");
            }
        }
        Console.WriteLine("\r\n".PadRight(100, '-') + "\r\n");
    }
    public void CourseShortDTO_SelectLoading()
    {
        // Select Loading : 
        Console.WriteLine("\r\nSelect Loading ".PadRight(100, '-') + "\r\n");
        var result = courseStoreDbContext.Courses
            .Select(c => new CourseShortDTO 
            {
                Id = c.CourseId,
                Name = c.Name,
            });

        foreach (var course in result)
        {
            Console.WriteLine($"Course: {course.Name}");
        }
        Console.WriteLine("\r\n".PadRight(100, '-') + "\r\n");
    }
}
