// See https://aka.ms/new-console-template for more information

using System.Reflection;

// Dynamic load (assembly)
var assembly = Assembly.LoadFrom(@"C:\Users\Fereidouni\source\repos\CSharp-CodeSnippet\iAttributes\src\iAttributes.Domain\bin\Debug\net6.0\iAttributes.Domain.dll");
var personType = assembly.GetType("iAttributes.Domain.Person");

// Late Binding
var person = Activator.CreateInstance(personType);
Console.WriteLine($"My Object Type is : {person}");

var printMethod = personType.GetMethod("Print");

printMethod.Invoke(person, new object[] { });

var inputPrintMethod = personType.GetMethod("InputPrint");

inputPrintMethod.Invoke(person, new object[] { "This is YFereidouni Input parameter" });
