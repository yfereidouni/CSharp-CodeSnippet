using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Immutables;

public class ImmutableSample
{
    public void Test()
    {
        ImmutableList<string> immutableList = ImmutableList.Create<string>();

        Console.WriteLine(immutableList.Count);

        var result = immutableList.Add("hi").Add("hi").Add("hi");

        Console.WriteLine(immutableList.Count);
        Console.WriteLine(result.Count);
    }
}
