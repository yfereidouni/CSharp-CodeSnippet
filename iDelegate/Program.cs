using System;

namespace iDelegate
{
    class Program
    {
        public delegate void iDelegate(string value);
        static void Main(string[] args)
        {
            iDelegate myTask = SayHello;

            myTask("Salam Yasser");

        }
        public static void SayHello(string value)
        {
            Console.WriteLine(value);
        }

    }
}
