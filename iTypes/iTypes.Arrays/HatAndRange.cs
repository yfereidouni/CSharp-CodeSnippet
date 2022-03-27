using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class HatAndRange
{
    public static void HatAndRangeSample()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("\r\n----------------------------------");
        Console.WriteLine("Hat and Range:");
        
        Console.WriteLine(a[0]);  // Output : 1
        Console.WriteLine(a[1]);  // Output : 2

        Console.WriteLine(a[^1]); // Output : 9  (1st item from End of array)
        Console.WriteLine(a[^2]); // Output : 8  (2nd item from End of array)
    }
}

