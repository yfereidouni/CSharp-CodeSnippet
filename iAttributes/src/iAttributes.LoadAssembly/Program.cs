// See https://aka.ms/new-console-template for more information

using System.Reflection;

var assembly = Assembly.LoadFrom(@"C:\Users\Fereidouni\source\repos\CSharp-CodeSnippet\iAttributes\src\iAttributes.Domain\bin\Debug\net6.0\iAttributes.Domain.dll");

var types = assembly.GetTypes();

Console.WriteLine($"-------- {assembly.FullName} --------");

foreach (var type in types)
{
    Console.WriteLine(type.Name);
}

Console.ReadKey();