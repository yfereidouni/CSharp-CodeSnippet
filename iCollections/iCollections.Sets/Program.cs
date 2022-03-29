// See https://aka.ms/new-console-template for more information

using iCollections.Sets;


SetSample setSample = new SetSample();

setSample.Add("01");
setSample.Add("02");
setSample.Add("03");

setSample.PrintAll();
Console.WriteLine("--------------------");
setSample.Add("02");
setSample.Add("03");

setSample.PrintAll();
 