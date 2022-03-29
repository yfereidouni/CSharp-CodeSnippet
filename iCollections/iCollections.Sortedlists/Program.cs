// See https://aka.ms/new-console-template for more information


using iCollections.Sortedlists;

SortedlistSample sortedlistSample = new SortedlistSample();

sortedlistSample.Add(1, "Yasser");
sortedlistSample.Add(2, "Shervin");
sortedlistSample.Add(3, "Soroush");

foreach (var item in sortedlistSample.list)
{
    Console.WriteLine(item);
}

sortedlistSample.Remove(2);
Console.WriteLine("Item in Index 2 removed from Sorted List");


foreach (var item in sortedlistSample.list)
{
    Console.WriteLine(item);
}