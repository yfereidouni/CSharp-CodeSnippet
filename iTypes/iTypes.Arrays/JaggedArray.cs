using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays;

public static class JaggedArray
{
    // 3-way of defining Jagged Array 1-D: ---------------------------------------------------
    public static int[][] _Jagged_1D_Array01 = new int[2][];      //Jagged Array 1-D [2]x[]
    
    public static int[][] _Jagged_1D_Array02 = 
        new int[][] {
            new int[] { 0, 1, 2, 3, 4 }, //[5]
            new int[] { 5, 6, 7 },       //[3]
            new int[] { 5, 9 },          //[2]
        };                                                       //Jagged Array 1-D [3]x[]

    public static int[][] _Jagged_1D_Array03 = 
        {
            new int[] { 0, 1 },          //[2]
            new int[] { 0, 1, 2, 3 },    //[4]
        };                                                       //Jagged Array 1-D [2]x[]

    // 3-way of defining Jagged Array 2-D: ---------------------------------------------------
    public static int[][,] _Jagged_2D_Array01 = new int[2][,];   //Jagged Array 2-D [2]x[,]

    public static int[][,] _Jagged_2D_Array02 =
        new int[][,] {
                        new int[,] {
                                        { 0, 1, 2, 3, 4 },
                                        { 5, 6, 7, 8, 9 },
                        }, //[2x5]
                        new int[,] {
                                        { 0, 1, 2 },
                        }, //[1x3]
                        new int[,] {
                                        { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                                        { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                                        { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                                        { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                        } //[4x9]
        };                                                       //Jagged Array 2-D [3]x[,]

    public static int[][,] _Jagged_2D_Array03 =
        {
            new int[,] {
                            { 0, 1, 2, 3, 4 },
                            { 5, 6, 7, 8, 9 },
            }, //[2,5]
            new int[,] {
                            { 0, 1, 2 },
                            { 3, 4, 5 },
                            { 1, 5, 9 },
            }, //[3,3]
    };                                                           //Jagged Array 2-D [2]x[,]

    // 3-way of defining Jagged Array 3-D: ---------------------------------------------------
    public static int[][,,] _Jagged_3D_Array01 = new int[2][,,]; //Jagged Array 3-D [2][2x3x5]
    public static int[][,,] _Jagged_3D_Array02 =
        new int[][,,] {
                        new int[,,] {
                                        {
                                            {0, 1, 2, 3, 4 },
                                            {5, 6, 7, 8, 9 }
                                        },
                                        {
                                            { 5, 6, 7, 8, 9 },
                                            { 5, 6, 7, 8, 9 },
                                        },
                                        {
                                            { 2, 4, 6, 8, 9 },
                                            { 1, 3, 5, 7, 9 },
                                        }
                        }, //[3, 2, 5]
                        new int[,,] {
                                        {
                                            { 0, 1, 2 },
                                            { 3, 4, 5 },
                                            { 6, 7, 8 },
                                            { 3, 6, 9 },
                                        },
                                        {
                                            { 6, 7, 8 },
                                            { 6, 7, 8 },
                                            { 1, 2, 3 },
                                            { 1, 2, 3 },
                                        }
                        }, //[2, 4, 3]
        };                                                       //Jagged Array 3-D [2][,,]
    public static int[][,,] _Jagged_3D_Array03 =
        {
            new int[,,] {
                            {
                                {0, 1, 2, 3, 4 },
                                {5, 6, 7, 8, 9 }
                            },
                            {
                                { 5, 6, 7, 8, 9 },
                                { 5, 6, 7, 8, 9 },
                            },
                            {
                                { 2, 4, 6, 8, 9 },
                                { 1, 3, 5, 7, 9 },
                            }
            }, //[3, 2, 5]
            new int[,,] {
                            {
                                { 0, 1, 2 },
                                { 3, 4, 5 },
                                { 6, 7, 8 },
                                { 3, 6, 9 },
                            },
                            {
                                { 6, 7, 8 },
                                { 6, 7, 8 },
                                { 1, 2, 3 },
                                { 1, 2, 3 },
                            }
            }, //[2, 4, 3]
        };                                                       //Jagged Array 3-D [2][,,]
    
    public static void AccessToArrayViaIndex()
    {
        _Jagged_1D_Array01[0] = new int[] { 1, 2, 3, 4 };
        _Jagged_1D_Array01[1] = new int[] { 11, 34 };

        Console.WriteLine("Jagged 1-D Arrays: \r\n");
        for (int n = 0; n < _Jagged_1D_Array01.Length; n++)
        {

            // Print the row number
            System.Console.Write("Row({0}): ", n);

            for (int k = 0; k < _Jagged_1D_Array01[n].Length; k++)
            {

                // Print the elements in the row
                System.Console.Write("{0} ", _Jagged_1D_Array01[n][k]);
            }
            System.Console.WriteLine();
        }
        Console.WriteLine("\r\n----------------------------"); 

        Console.WriteLine("Jagged 2-D Arrays: \r\n");
        Console.WriteLine($"Jagged 2-D Array03 Dimension is : {_Jagged_2D_Array01.Length}");
        Console.WriteLine($"Jagged 2-D Array03 Dimension is : {_Jagged_2D_Array02.Length}");
        Console.WriteLine($"Jagged 2-d Array03 Dimension is : {_Jagged_2D_Array03.Length}");
        Console.WriteLine("\r\n----------------------------");
        Console.WriteLine("Jagged 3-D Arrays: \r\n");
        Console.WriteLine($"Jagged 3-D Array03 Dimension is : {_Jagged_3D_Array01.Length}");
        Console.WriteLine($"Jagged 3-D Array03 Dimension is : {_Jagged_3D_Array02.Length}");
        Console.WriteLine($"Jagged 3-d Array03 Dimension is : {_Jagged_3D_Array03.Length}");
        Console.WriteLine("\r\n----------------------------");

        for (int i = 0; i < _Jagged_3D_Array02.Length; i++)
        {
            for (int j = 0; j < _Jagged_3D_Array02[i].GetUpperBound(0); j++)
            {
                
            }
        }
    }
}
