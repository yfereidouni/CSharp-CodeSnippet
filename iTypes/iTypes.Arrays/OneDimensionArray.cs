using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class OneDimensionArray
{
    // 3-way of defining simple 1D array:
    public static int[] array01 = new int[5];                  //Length = 5
    public static int[] array02 = new int[] { 0, 1, 2, 3, 4 }; //Length = 5
    public static int[] array03 = { 0, 1, 2, 3, 4 };           //Length = 5

    public static void AccessToArrayViaIndex()
    {
        Console.WriteLine("1-D Arrays: \r\n");
        
        // Access to array via index :
        array01[0] = 7;      //{ 7, 0, 0, 0, 0 };
        array02[4] = 7;      //{ 0, 1, 2, 3, 7 };
        array03[2] = 7;      //{ 0, 1, 7, 3, 7 };

        for (int i = 0; i < array01.Length; i++)
        {
            Console.Write($"{array01[i]} ");
        }

        Console.WriteLine("\r\n----------------------------");

        foreach (var item in array02)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\r\n----------------------------");

        foreach (var item in array03)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\r\n----------------------------");
    }

}
