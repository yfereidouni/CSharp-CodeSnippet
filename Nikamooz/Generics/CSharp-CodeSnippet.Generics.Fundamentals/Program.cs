// See https://aka.ms/new-console-template for more information

using CSharp_CodeSnippet.Generics.Fundamentals;

Person person = new Person() { FirstName = "Yasser", LastName = "Fereidouni" };
PersonPrinter<Person> personPrinter = new PersonPrinter<Person>();
var PersonResult = personPrinter.Printer(person);
Console.WriteLine(PersonResult);
Console.WriteLine("".PadLeft(100, '-'));
//---------------------------------------------------------------------------------------

Student student = new Student() { FirstName = "Meysam", LastName = "Ghodsi", StudentCode = "ST-100" };
PersonPrinter<Student> studentPrinter = new PersonPrinter<Student>();
var studentResult = studentPrinter.Printer(student);
Console.WriteLine(studentResult);
Console.WriteLine("".PadLeft(100, '-'));
//---------------------------------------------------------------------------------------

Teacher teacher = new Teacher() { FirstName = "Sorush", LastName = "Sarabi", TeacherCode = "TC-200" };
PersonPrinter<Teacher> teacherPrinter = new PersonPrinter<Teacher>();
var teacherResult = teacherPrinter.Printer(teacher);
Console.WriteLine(teacherResult);
Console.WriteLine("".PadLeft(100, '-'));
//---------------------------------------------------------------------------------------
