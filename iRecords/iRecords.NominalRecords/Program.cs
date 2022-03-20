// See https://aka.ms/new-console-template for more information
using iRecords.NominalRecords;

PersonRecord personRecord01 = new PersonRecord()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni"
};
PersonRecord personRecord02 = new PersonRecord()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni"
};

PersonClass personClass01 = new PersonClass()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni"
};
PersonClass personClass02 = new PersonClass()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni"
};

//ToString : --------------------------------------------------
Console.WriteLine("ToString :");
Console.WriteLine($"Person Record ToString : {personRecord01}");
Console.WriteLine($"Person Class ToString : {personRecord01}");
Console.WriteLine("".PadRight(100, '-'));
//Reference Equals : --------------------------------------------------
Console.WriteLine("Reference Equals :");
Console.WriteLine($"Person Record Reference Equals : {object.ReferenceEquals(personRecord01, personRecord02)}");
Console.WriteLine($"Person Class Reference Equals : {object.ReferenceEquals(personRecord01, personRecord02)}");
Console.WriteLine("".PadRight(100, '-'));
//Equals : --------------------------------------------------
Console.WriteLine("Equals :");
Console.WriteLine($"Person Record Equals : {personRecord01 == personRecord02}");
Console.WriteLine($"Person Class Equals : {personRecord01 == personRecord02}");
Console.WriteLine("".PadRight(100, '-'));
