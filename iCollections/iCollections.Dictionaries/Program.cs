// See https://aka.ms/new-console-template for more information


using iCollections.Dictionaries;

DictionarySample dictionarySample = new DictionarySample();

dictionarySample.Add("1st", "Yasser");
dictionarySample.Add("2nd", "Shervin");
dictionarySample.Add("3rd", "Soroush");

dictionarySample.PrintAll();

dictionarySample.Remove("2nd");
Console.WriteLine("\r\nItem in Index 2nd removed from Dictionary\r\n");

dictionarySample.PrintAll();
