
using System.Collections;

namespace iTypes.Arrays;

public static class BitArrays
{
    public static void BitArraySample()
    {
        BitArray bitArray01 = new BitArray(4);

        bitArray01.SetAll(true);
        bitArray01[2] = false;

        BitArray bitArray02 = new BitArray(4);
        bitArray02.SetAll(true);

        bitArray01.And(bitArray02);
        bitArray01.Or(bitArray02);
        bitArray01.Xor(bitArray02);
        bitArray01.Not();

        Console.WriteLine("\r\n----------------------------------");
        Console.WriteLine("BIT Array:");
        foreach (var item in bitArray01)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
}



