using System;

namespace iImplicit_Explicit_TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Casting
            Dollar dollar = 4.5;
            Console.WriteLine($"{dollar.DollarCount} {dollar.CentCount}"); //4 50

            //Explicit Type Casting
            double value = (double)dollar;
            Console.WriteLine(value);                                      //4.5
        }
    }
}
