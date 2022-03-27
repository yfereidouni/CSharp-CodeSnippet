using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class ArrayPools
{
    public static void ArrayPoolSample()
    {
        ArrayPool<int> arrayPool = ArrayPool<int>.Create(); // Default length size : 1024 * 1024

        var array = arrayPool.Rent(5); // Minimum length is 5 and maybe the actual length is grater than 5

        for (int i = 0; i < 5; i++)
        {
            array[i] = i * 2;
        }

        Console.WriteLine("\r\n----------------------------------");
        Console.WriteLine("Array Pool:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        arrayPool.Return(array,true); // Return rented array to the Array pool and reset the values
    }
}



