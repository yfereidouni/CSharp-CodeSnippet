using iEFCore.ComputedColumn;

var ctx = new ComputedColumnDbContext();

var person = new Person
{
    FirstName = "Alireza",
    LastName = "Oroumand"
};
ctx.People.Add(person);
ctx.SaveChanges();

