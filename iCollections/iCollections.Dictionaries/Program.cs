// See https://aka.ms/new-console-template for more information


using iCollections.Dictionaries;

Console.WriteLine("------------------------------------");
Console.WriteLine("Dictionary:\r\n");
DictionarySample dictionarySample = new DictionarySample();

dictionarySample.Add("1st", "Yasser");
dictionarySample.Add("2nd", "Shervin");
dictionarySample.Add("3rd", "Soroush");

dictionarySample.PrintAll();

dictionarySample.Remove("2nd");
Console.WriteLine("\r\nItem in Index 2nd removed from Dictionary\r\n");

dictionarySample.PrintAll();
Console.WriteLine();

//---------------------------------------------
Console.WriteLine("------------------------------------");
Console.WriteLine("SortedDictionary:\r\n");
SortedDictionarySample sortedDictionarySample = new SortedDictionarySample();

sortedDictionarySample.Add("1st", "Yasser");
sortedDictionarySample.Add("2nd", "Shervin");
sortedDictionarySample.Add("3rd", "Soroush");

sortedDictionarySample.PrintAll();

sortedDictionarySample.Remove("2nd");
Console.WriteLine("\r\nItem in Index 2nd removed from Dictionary\r\n");

sortedDictionarySample.PrintAll();

