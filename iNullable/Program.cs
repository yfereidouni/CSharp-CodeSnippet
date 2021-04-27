using System;

namespace iNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable int
            int? num1 = null;
            int? num2 = 1337;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            Console.WriteLine("num1: {0} num2: {1} num3: {2} num4: {3} bool: {4}", num1, num2, num3, num4, boolval);
            Console.WriteLine("----------------------------------------------------");
            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("Male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }
            Console.WriteLine("----------------------------------------------------");
            // THE NULL COALESCING OPERATOR ??

            double? num5 = 13.1;
            double? num6 = null;
            double num7;
            num7 = num5 ?? 8.4;
            Console.WriteLine($"Num7: {0}", num7);
            num7 = num6 ?? 8.4;
            Console.WriteLine($"Num7: {0}", num7);
        }
    }
}
