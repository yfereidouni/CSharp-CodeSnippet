// See https://aka.ms/new-console-template for more information

using iTypes.Structs;


PersonStruct_Old personStruct_Old = new PersonStruct_Old()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni",
    Age = 36
};

PersonStruct_V7 personStruct_V7 = new PersonStruct_V7();

PersonStruct_V8 PersonStruct_V8 = new PersonStruct_V8()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni",
    Age = 36
};

PersonStruct_V10 PersonStruct_V10 = new PersonStruct_V10(1, "Yasser", "Fereidouni", 36);

//---------------------------------------------------------------
Console.WriteLine("\r\nPersonStruct_Old:");
Console.WriteLine($"{personStruct_Old.Id} | " +
                  $"{personStruct_Old.FirstName} | " +
                  $"{personStruct_Old.LastName} | " +
                  $"{personStruct_Old.Age}");
//---------------------------------------------------------------
Console.WriteLine("\r\nPersonStruct_7:");
Console.WriteLine($"{personStruct_V7.Id} | " +
                  $"{personStruct_V7.FirstName} | " +
                  $"{personStruct_V7.LastName} | " +
                  $"{personStruct_V7.Age}");
//---------------------------------------------------------------
Console.WriteLine("\r\nPersonStruct_8:");
Console.WriteLine($"{PersonStruct_V8.Id} | " +
                  $"{PersonStruct_V8.FirstName} | " +
                  $"{PersonStruct_V8.LastName} | " +
                  $"{PersonStruct_V8.Age} | " +
                  $"{PersonStruct_V8.GetFullName()}");
