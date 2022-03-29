using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Dictionaries;

public class SortedDictionarySample
{
    SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();

    public void Add(string key, string value)
    {
        if (!dictionary.ContainsKey(key))
            dictionary[key] = value;
    }

    public void Remove(string key)
    {
        dictionary.Remove(key);
    }

    public void PrintAll()
    {
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} | {item.Value}");
        }
    }
}
