// See https://aka.ms/new-console-template for more information


using CSharp_CodeSnippet.Generics.NormalClassWithGenericMethod;

NomalClassWithGenericMethod nomalClassWithGenericMethod = new NomalClassWithGenericMethod();

var intResult = nomalClassWithGenericMethod.Printer<int>(2);
Console.WriteLine(intResult);

var stringResult = nomalClassWithGenericMethod.Printer<string>("Yasser");
Console.WriteLine(stringResult);
