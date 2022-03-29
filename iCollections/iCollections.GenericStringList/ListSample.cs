using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.GenericStringList;

public class ListSample
{
    List<string> list = new List<string>();

    public void CountAndCapacity()
    {
        Console.WriteLine($"Capacity: {list.Capacity} | Count: {list.Count} \r\n");
    }

    public void AddMember(string input)
    {
        list.Add(input);
        list.AddRange(new string[] { "Kamran, Hamid, Mohsen" });
        Console.WriteLine($"\tMessage => {input} was added.\r\n");
    }

    public void Ensure()
    {
        list.EnsureCapacity(20);
        Console.WriteLine("\tMessage => List was EnsureCapacity(20)!\r\n");

    }

    public void Trim()
    {
        list.TrimExcess();
        Console.WriteLine("\tMessage => List was TrimExcess!\r\n");
    }

    public void Remove()
    {
        list.Remove("Yasser");
        list.RemoveAll(c => c.StartsWith("s"));
        list.RemoveAt(2);
        list.RemoveRange(2, 2); // remove from index 2 with 2 lot size
        list.Clear(); //Clear all items in list
    }

    public void Insert()
    {
        list.Insert(4, "Reza");
    }

    public void Find()
    {
        var result1 = list.Find(c => c.StartsWith("s"));
        var result2 = list.FindAll(c => c.StartsWith("s"));
    }

    public IReadOnlyList<string> GetReadOnly()
    {
        return list.AsReadOnly();
    }
}
