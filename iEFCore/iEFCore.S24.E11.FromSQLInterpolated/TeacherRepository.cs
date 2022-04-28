using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E11.FromSQLInterpolated;

public class TeacherRepository
{
    private readonly FromSQLInterpolatedDbContext ctx;

    public TeacherRepository(FromSQLInterpolatedDbContext ctx)
    {
        this.ctx = ctx;
    }

    public void FromSqlSample()
    {
        var teachers1 = ctx.Teachers.ToList();
        var teachers2 = ctx.Teachers.FromSqlRaw("SELECT * FROM Teachers WHERE FirstName Like {0}", "Y%").OrderBy(c => c.LastName);
        var teachers3 = ctx.Teachers.FromSqlRaw("SELECT * FROM Teachers").OrderBy(c=>c.LastName);

        foreach (var teacher in teachers3)
        {
            Console.WriteLine($"{teacher.Id} {teacher.FirstName} {teacher.LastName}");
        }
    }

    public void InsertPersonRaw()
    {
        //Equal with ExecutedNonQuery
        this.ctx.Database.ExecuteSqlRaw("INSERT INTO Teachers (FirstName, LastName) VALUES ('Meysam', 'Saberi')");
    }

    public void FromSqlQueryNews()
    {
        var newsSummary = ctx.Summaries.ToList();
        foreach (var item in newsSummary)
        {
            Console.WriteLine($"{item.Id} | {item.Title}");
        }

    }
}

