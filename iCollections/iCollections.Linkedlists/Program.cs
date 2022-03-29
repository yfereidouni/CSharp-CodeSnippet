// See https://aka.ms/new-console-template for more information

using iCollections.Linklists;

LinkedlistSample linkedlistSample = new LinkedlistSample();

linkedlistSample.Add("Yasser");
linkedlistSample.Add("Shervin");
linkedlistSample.Add("Soroush");

foreach (var item in linkedlistSample.list)
{
    Console.WriteLine(item);
}