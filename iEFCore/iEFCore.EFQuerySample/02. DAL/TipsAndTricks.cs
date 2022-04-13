using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.EFQuerySample;

public class TipsAndTricks
{
    private readonly CourseStoreDbContext courseStoreDbContext;

    public TipsAndTricks(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }
    public void AsNoTrackingSample()
    {
        var courses = courseStoreDbContext.Courses.AsNoTracking().Include(c => c.CourseTeachers).ThenInclude(c => c.Teacher).ToList();

        var t1c1 = courses.Where(c => c.CourseId == 1).FirstOrDefault().CourseTeachers.FirstOrDefault().Teacher;
        var t1c2 = courses.Where(c => c.CourseId == 2).FirstOrDefault().CourseTeachers.FirstOrDefault().Teacher;
        var t1c3 = courses.Where(c => c.CourseId == 3).FirstOrDefault().CourseTeachers.FirstOrDefault().Teacher;

        Console.WriteLine("\r\nAsNoTracking: ".PadRight(100,'-'));
        Console.WriteLine(Object.ReferenceEquals(t1c1, t1c2));
        Console.WriteLine(Object.ReferenceEquals(t1c1, t1c3));
        Console.WriteLine(Object.ReferenceEquals(t1c2, t1c3));
    }

    public void AsNoTrackingSampleWithIdentityResolution()
    {

        var courses = courseStoreDbContext.Courses.AsNoTrackingWithIdentityResolution().Include(c => c.CourseTeachers).ThenInclude(c => c.Teacher).ToList();

        var t1c1 = courses.Where(c => c.CourseId == 1).FirstOrDefault().CourseTeachers.FirstOrDefault().Teacher;
        var t1c2 = courses.Where(c => c.CourseId == 2).FirstOrDefault().CourseTeachers.FirstOrDefault().Teacher;
        var t1c3 = courses.Where(c => c.CourseId == 3).FirstOrDefault().CourseTeachers.FirstOrDefault().Teacher;

        Console.WriteLine("\r\nAsNoTrackingWithIdentityResolution: ".PadRight(100, '-'));
        Console.WriteLine(Object.ReferenceEquals(t1c1, t1c2));
        Console.WriteLine(Object.ReferenceEquals(t1c1, t1c3));
        Console.WriteLine(Object.ReferenceEquals(t1c2, t1c3));
    }
}
