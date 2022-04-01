// See https://aka.ms/new-console-template for more information

using iAttributes.Domain;


//Way-01 : ----------------------------------------
Person person = new Person();
Type personType01 = person.GetType();
Console.WriteLine(personType01.FullName);
Console.WriteLine(personType01.AssemblyQualifiedName);

//Way-02 : ----------------------------------------
Type personType02 = typeof(Person);
Console.WriteLine(personType02.FullName);

//Way-03 : ----------------------------------------
Type personType03 = Type.GetType("iAttributes.ReflectionUI.Teacher", false, true);
Console.WriteLine(personType03.FullName);

//Way-04 : ----------------------------------------
Type personType04 = Type.GetType("IAttributes.Domain.Person, iAttributes.Domain", true, true);
Console.WriteLine(personType04.FullName);
