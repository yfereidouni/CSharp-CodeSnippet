using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class MultiDimensionArray
{
    // 3-way of defining simple 1-D array: ---------------------------------------------------
    public static int[] _1D_Array01 = new int[5];                        //1-Dimension     (5)
    public static int[] _1D_Array02 = new int[] { 0, 1, 2, 3, 4 };       //1-Dimension     (5)
    public static int[] _1D_Array03 = { 0, 1, 2, 3, 4 };                 //1-Dimension     (5)
    // 3-way of defining simple 2-D array: ---------------------------------------------------
    public static int[,] _2D_Array01 = new int[2, 5];                    //2-Dimension   (2x5)
    public static int[,] _2D_Array02 = new int[,] {
                                                        { 0, 1, 2, 3, 4 },
                                                        { 0, 1, 2, 3, 4 },
                                                        { 0, 1, 2, 3, 4 },
                                                  };                     //2-Dimension   (2x5)
    public static int[,] _2D_Array03 = {
                                            { 0, 1, 2, 3, 4 },
                                            { 0, 1, 2, 3, 4 },
                                            { 0, 1, 2, 3, 4 },
                                       };                                //2-Dimension   (2x5)
    // 3-way of defining simple 3-D array: ---------------------------------------------------
    public static int[,,] _3D_Array01 = new int[2, 3, 5];                //3-Dimension (2x3x5)
    public static int[,,] _3D_Array02 = new int[,,] {
                                                        {
                                                            { 0, 1, 2, 3, 4 },
                                                            { 0, 1, 2, 3, 4 },
                                                            { 0, 1, 2, 3, 4 },
                                                        },
                                                        {
                                                            { 0, 1, 2, 3, 4 },
                                                            { 0, 1, 2, 3, 4 },
                                                            { 0, 1, 2, 3, 4 },
                                                        },
                                                   };                    //3-Dimension (2x3x5)
    public static int[,,] _3D_Array03 = {
                                            {
                                                { 0, 1, 2, 3, 4 },
                                                { 0, 1, 2, 3, 4 },
                                                { 0, 1, 2, 3, 4 },
                                            },
                                            {
                                                { 0, 1, 2, 3, 4 },
                                                { 0, 1, 2, 3, 4 },
                                                { 0, 1, 2, 3, 4 },
                                            },
                                        };                               //3-Dimension 2x3x5
    public static void AccessToArrayViaIndex()
    {
        Console.WriteLine("2-D Arrays: \r\n");
        // Access to array via index :

        Console.WriteLine($"1-D Array01 Dimension is : {_1D_Array01.Rank}");
        Console.WriteLine($"2-D Array01 Dimension is : {_2D_Array01.Rank}");
        Console.WriteLine($"3-d Array01 Dimension is : {_3D_Array01.Rank}");
        
        Console.WriteLine("\r\n----------------------------");
    }
}
