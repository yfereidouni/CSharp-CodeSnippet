using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class Enumeration
{
    public static void TestEnumeration()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5 };

        //foreach (var item in a)
        //{
        //    Console.Write(item + " ");
        //}

        var e = a.GetEnumerator();
        while (e.MoveNext())
        {
            Console.Write(e.Current + " ");
        }
        Console.WriteLine("\r\n------------------------------------");
    }

}