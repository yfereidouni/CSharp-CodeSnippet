
using iEFCore.RelationConfigurationExtera.OwnedTypeSample;

OwnedTypeDbContext ctx = new OwnedTypeDbContext(); 

var person = ctx.People.FirstOrDefault(); // Without Include you can have all related data to Person

Console.ReadKey();