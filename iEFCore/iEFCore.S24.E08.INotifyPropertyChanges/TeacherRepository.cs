namespace iEFCore.S24.E08.INotifyPropertyChanges;

public class TeacherRepository
{
    private readonly INotifyPropertyChangesDbContext ctx;

    public TeacherRepository(INotifyPropertyChangesDbContext ctx)
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

        var teacher = new Teacher { Id = 2, FirstName = "Meysam", LastName = "Eslami" };
        ctx.Teachers.Add(teacher);

        Console.WriteLine("---------------------------- Short View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.ShortView);
        Console.WriteLine("---------------------------- Long View --------------------------------");
        Console.WriteLine(this.ctx.ChangeTracker.DebugView.LongView);
    }

}

