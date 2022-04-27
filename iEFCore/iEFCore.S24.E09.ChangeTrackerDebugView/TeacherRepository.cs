namespace iEFCore.S24.E09.ChangeTrackerDebugView;

public class TeacherRepository
{
    private readonly ChangeTrackerDebugViewDbContext ctx;

    public TeacherRepository(ChangeTrackerDebugViewDbContext ctx)
    {
        this.ctx = ctx;
    }

    public void UpdateTeacher(int id, string firstName, string lastName)
    {
        this.ctx.ChangeTracker.AutoDetectChangesEnabled = false;

        var teacher = ctx.Teachers.FirstOrDefault(t => t.Id == id);
        if (teacher != null)
        {
            teacher.FirstName = firstName;
            teacher.LastName = lastName;
            ctx.ChangeTracker.DetectChanges();
            ctx.SaveChanges();
        }
    }

    public void ShowChangeTrackerDebugView()
    {
        Console.WriteLine("---------------------------- Short View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.ShortView);
        Console.WriteLine("---------------------------- Long View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.LongView);

        var reachers = ctx.Teachers.ToList();

        Console.WriteLine("---------------------------- Short View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.ShortView);
        Console.WriteLine("---------------------------- Long View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.LongView);

        var teacher = new Teacher { FirstName = "Meysam", LastName = "Eslami" };
        ctx.Teachers.Add(teacher);

        Console.WriteLine("---------------------------- Short View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.ShortView);
        Console.WriteLine("---------------------------- Long View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.LongView);
    }
}

