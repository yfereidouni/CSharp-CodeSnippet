using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.S24.E05.SettingTheEntityState;

public class PersonRepository
{
    private readonly SettingTheEntityStateDbContext ctx;

    public PersonRepository(SettingTheEntityStateDbContext ctx)
    {
        this.ctx = ctx;
    }

    public void SetEntityState(int id, string firstName, string LastName)
    {
        //ctx.ChangeTracker.AutoDetectChangesEnabled = false;
        
        Person person = new Person
        {
            Id = id,
            FirstName = firstName,
            LastName = LastName
        };

        Console.WriteLine($"Person state is: {ctx.Entry(person).State}");
        
        ctx.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.Entry(person).Property(c => c.FirstName).IsModified = false;
        Console.WriteLine($"Person state is: {ctx.Entry(person).State}");

        ctx.SaveChanges();
        Console.WriteLine($"Person state is: {ctx.Entry(person).State}");

    }
}
