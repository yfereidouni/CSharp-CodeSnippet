using System;

namespace iOperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector { X = 10, Y = 11, Z = 12 };
            
            Vector v2 = new Vector { X = 5, Y = 14, Z = 13 };

            Vector v3 = new Vector { X = 5, Y = 14, Z = 13 };

            Console.WriteLine(v1 == v2); //False
            
            Console.WriteLine(v2 == v3); //True
        }
    }
}
