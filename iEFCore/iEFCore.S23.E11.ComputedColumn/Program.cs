using iEFCore.S23.E11.ComputedColumn;

var ctx = new ComputedColumnDbContext();

var person = new Person
{
    FirstName = "Alireza",
    LastName = "Oroumand"
};
ctx.People.Add(person);
ctx.SaveChanges();

