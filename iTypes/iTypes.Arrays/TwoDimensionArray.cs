using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class TwoDimensionArray
{
    // 3-way of defining simple 2D array:
    public static int[,] array01 = new int[3, 5];                    //Length = 3x5

    public static int[,] array02 = new int[,] {
                                                { 0, 1, 2, 3, 4 },
                                                { 0, 1, 2, 3, 4 },
                                                { 0, 1, 2, 3, 4 },
                                              };                     //Length = 3x5

    public static int[,] array03 = {
                                     { 0, 1, 2, 3, 4 },
                                     { 0, 1, 2, 3, 4 },
                                     { 0, 1, 2, 3, 4 },
                                   };                                //Length = 3x5

    public static void AccessToArrayViaIndex()
    {
        Console.WriteLine("2-D Arrays: \r\n");
        // Access to array via index :
        array01[1, 4] = 7;      //{
                                //   { 0, 0, 0, 0, 0 },
                                //   { 0, 0, 0, 0,(7)},
                                //   { 0, 0, 0, 0, 0 },
                                //};

        array02[1, 4] = 7;      //{
                                //   { 0, 1, 2, 3, 4 },
                                //   { 0, 1, 2, 3,(7)},
                                //   { 0, 1, 2, 3, 4 },
                                //};

        array03[2, 0] = 7;      //{
                                //   { 0, 1 , 2, 3, 4 },
                                //   { 0, 1 , 2, 3, 4 },
                                //   { 0,(7), 2, 3, 4 },
                                //};

        Console.WriteLine($"Array01 Dimension is : {array01.Rank}");
        for (int i = 0; i <= array01.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array01.GetUpperBound(1); j++)
            {
                Console.Write($"{array01[i,j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\r\n----------------------------");

        Console.WriteLine($"Array02 Dimension is : {array02.Rank}");
        for (int i = 0; i <= array02.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array02.GetUpperBound(1); j++)
            {
                Console.Write($"{array02[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\r\n----------------------------");

        Console.WriteLine($"Array03 Dimension is : {array03.Rank}");
        for (int i = 0; i <= array03.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array03.GetUpperBound(1); j++)
            {
                Console.Write($"{array03[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\r\n----------------------------");
    }
}
