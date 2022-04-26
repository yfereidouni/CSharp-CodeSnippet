using iEFCore.S23.E12.DefaultValue;

var ctx = new DefaultValueDbContext();

var person = new Person
{
    FirstName = "Yasser",
    LastName = "Fereidouni"
};
ctx.People.Add(person);
ctx.SaveChanges();

