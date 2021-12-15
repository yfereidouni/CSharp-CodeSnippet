// See https://aka.ms/new-console-template for more information

using CSharp_CodeSnippet.Generics.Inheritance;

Person p01 = new Person { Id = 1, FirstName = "Yasser", LastName = "Fereidouni" };
Student p02 = new Student { Id = 1, FirstName = "Aman", LastName = "Toumaj", StudentCode = "ST-1010" };
Teacher p03 = new Teacher { Id = 1, FirstName = "Soroush", LastName = "Sarabi", TeacherCode = "T-1020" };


Printer<Person> printer = new Printer<Person>();

Console.WriteLine(printer.PrintPersonnel(p01));
Console.WriteLine(printer.PrintPersonnel(p02));
Console.WriteLine(printer.PrintPersonnel(p03));
