using System;

namespace iMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celing of 15.3 is: {0}", Math.Ceiling(15.3));
            Console.WriteLine("Floor of 15.3 is: {0}", Math.Floor(15.3));
            Console.WriteLine("---------------------------------------------------");
            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is: {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is: {2}", num1, num2, Math.Max(num1, num2));
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("PI: {0}", Math.PI);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Cos of 1: {0}", Math.Cos(1));
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("SQRT of 25 is: {0}", Math.Sqrt(25));
        }
    }
}
