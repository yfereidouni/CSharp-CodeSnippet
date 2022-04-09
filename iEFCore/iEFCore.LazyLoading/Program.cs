using iEFCore.LazyLoading;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<LazyDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=LazyLoading_DB;Integrated Security=true;Encrypt=false;MultipleActiveResultsets=true;");
optionBuilder.UseLazyLoadingProxies();
//optionBuilder.LogTo(Console.WriteLine);
using LazyDbContext ctx = new LazyDbContext(optionBuilder.Options);
//ctx.Database.EnsureCreated(); // Create Database without migration
var people = ctx.People;

foreach (var person in people)
{
    Console.WriteLine("".PadLeft(100, '-'));
    Console.WriteLine($"{person.Id} {person.Name}");
    foreach (var address in person.Addresses)
    {
        Console.WriteLine($"\t\t{address.City}");
    }
    Console.WriteLine("".PadLeft(100, '-'));
}