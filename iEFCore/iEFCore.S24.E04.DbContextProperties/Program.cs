using iEFCore.S24.E04.DbContextProperties;

ContextPropertiesDbContext ctx01 = new();
ContextPropertiesDbContext ctx02 = new();

Console.WriteLine($"Context01's Id is: {ctx01.ContextId}");
Console.WriteLine($"Context01's Id is: {ctx02.ContextId}");