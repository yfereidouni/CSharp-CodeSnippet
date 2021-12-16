// See https://aka.ms/new-console-template for more information

using CSharp_CodeSnippet.Generics.Inheritance;

Person p01 = new Person { Id = 1, FirstName = "Yasser", LastName = "Fereidouni" };
Student s01 = new Student { Id = 1, FirstName = "Aman", LastName = "Toumaj", StudentCode = "ST-1010" };
Teacher t01 = new Teacher { Id = 1, FirstName = "Soroush", LastName = "Sarabi", TeacherCode = "T-1020" };

///------------------------------------------------------------------------------------
Console.WriteLine("".PadRight(50,'-'));
Console.WriteLine("Genricts with 2 parameters:".ToUpper());
Printer<Person> printer = new Printer<Person>();
Console.WriteLine(printer.Print(p01));
Console.WriteLine(printer.Print(s01));
Console.WriteLine(printer.Print(t01));

///------------------------------------------------------------------------------------
Console.WriteLine("".PadRight(50,'-'));
Console.WriteLine("Genricts with 2 parameters:".ToUpper());
Printer<Student, Teacher> printer1 = new Printer<Student, Teacher>();
Console.WriteLine(printer1.Print(s01, t01));
