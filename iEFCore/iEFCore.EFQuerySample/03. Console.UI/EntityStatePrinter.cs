using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.EFQuerySample;

public class EntityStatePrinter
{
    private readonly CourseStoreDbContext courseStoreDbContext;

    public EntityStatePrinter(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }

    public void Print_DetachedState()
    {
        Tag tag = new Tag();
        var tagState = courseStoreDbContext.Entry(tag).State;
        Console.WriteLine($"Entity State is: {tagState}");
    }

    public void Print_AddedState()
    {
        Tag tag = new Tag();
        courseStoreDbContext.Add(tag);
        var tagState = courseStoreDbContext.Entry(tag).State;
        Console.WriteLine($"Entity State is: {tagState}");
    }
    
    public void Print_DeletedState()
    {
        Tag tag = new Tag() { TagId = 1 };
        courseStoreDbContext.Remove(tag);
        var tagState = courseStoreDbContext.Entry(tag).State;
        Console.WriteLine($"Entity State is: {tagState}");
    }

    public void Print_UpdatedState()
    {
        Tag tag = new Tag() { TagId = 1 };
        courseStoreDbContext.Update(tag);
        var tagState = courseStoreDbContext.Entry(tag).State;
        Console.WriteLine($"Entity State is: {tagState}");
    }

    public void Print_UnchangedState()
    {
        Tag tag = courseStoreDbContext.Tags.FirstOrDefault(c=>c.TagId==2);
        var tagState = courseStoreDbContext.Entry(tag).State;
        Console.WriteLine($"Entity State is: {tagState}");
    }
}
