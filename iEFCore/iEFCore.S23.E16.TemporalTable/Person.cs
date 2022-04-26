using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.S23.E16.TemporalTable;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class PersonTemporalRepository
{
    private readonly TemporalTableDbContext temporalTableDbContext;

    public PersonTemporalRepository(TemporalTableDbContext temporalTableDbContext)
    {
        this.temporalTableDbContext = temporalTableDbContext;
    }

    public void AddPerson(string firstName, string lastName)
    {
        Person person = new Person
        {
            FirstName = firstName,
            LastName = lastName
        };
        this.temporalTableDbContext.People.Add(person);
        this.temporalTableDbContext.SaveChanges();
    }

    public void EditPerson(int id, string firstName, string lastName)
    {
        var p = temporalTableDbContext.People.Find(id);
        p.FirstName = firstName;
        p.LastName = lastName;
        this.temporalTableDbContext.SaveChanges();
    }

    public void DeletePerson(int id)
    {
        var person = temporalTableDbContext.People.Find(id);
        temporalTableDbContext.People.Remove(person);
        this.temporalTableDbContext.SaveChanges();
    }

    public void PrintAllHistory()
    {
        //var people1 = temporalTableDbContext.People.TemporalAll();
        //var people2 = temporalTableDbContext.People.TemporalAsOf(DateTime.Now);
        //var people3 = temporalTableDbContext.People.TemporalBetween(DateTime.Now.AddDays(-30), DateTime.Now);
        //var people4 = temporalTableDbContext.People.TemporalContainedIn(DateTime.Now.AddDays(-30), DateTime.Now);
        //var people5 = temporalTableDbContext.People.TemporalFromTo(DateTime.Now.AddDays(-30), DateTime.Now);

        var people1 = temporalTableDbContext.People.TemporalAll().Select(c=> new 
        { 
            c.FirstName,
            c.LastName,
            c.Id,
            //Reading Shadow Properties
            Start = EF.Property<DateTime>(c, "PeriodStart"),
            End = EF.Property<DateTime>(c, "PeriodEnd"),

        });

        foreach (var person in people1)
        {
            Console.WriteLine($"{person.Id}\t{person.FirstName}\t{person.LastName}\t{person.Start}\t{person.End}");
        }

    }


}

