using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E15.Interceptors;

public class PersonRepository
{
    private readonly InterceptorsDbContext ctx;

    public PersonRepository(InterceptorsDbContext ctx)
    {
        this.ctx = ctx;
    }

    public void ExecuteTagedQuery()
    {
        var people = ctx.People.TagWith("Tag01").ToList();
        foreach (var person in people)
        {
            Console.WriteLine($"{person.Id} {person.FirstName} {person.LastName}");
        }
    }

    public void AddStudent(string name)
    {
        var student = new Student
        {
            Name = name,
        };

        ctx.Students.Add(student);
        ctx.SaveChanges();
    }

}

