// See https://aka.ms/new-console-template for more information


using iAttributes.DiscoveringMetadata;
using iAttributes.Domain;

var intPrinter = new MetadataPrinter(typeof(int));

var personPrinter = new MetadataPrinter(typeof(Person));

intPrinter.Print();
Console.WriteLine("Press any key to print Person metadata");
Console.ReadLine();
Console.Clear();

personPrinter.Print();
Console.WriteLine("Press any key to exit");
Console.ReadLine();
