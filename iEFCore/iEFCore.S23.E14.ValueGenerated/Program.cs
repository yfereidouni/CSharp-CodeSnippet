using iEFCore.S23.E14.ValueGenerated;

var ctx = new ValueGeneratedDbContext();

var person = new Person
{
    FirstName = "Yasser",
    LastName = "Fereidouni"
};

ctx.People.Add(person);
ctx.SaveChanges();

Console.ReadLine();