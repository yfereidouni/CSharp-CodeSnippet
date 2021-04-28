using System;

namespace iDelegate
{
    class Program
    {
        public delegate void iDelegate(string value);
        public delegate string GetTextDelegate(string name);
        public delegate double GetResultMultiply(double a, double b);
        static void Main(string[] args)
        {
            iDelegate myTask = SayHello;

            myTask("Hi, Yasser");

            //----------------------------------------------------------
            //Creating anonymous method
            //----------------------------------------------------------
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return string.Format("Hello, {0}",name);
            };
            Console.WriteLine(getTextDelegate("Yasser"));
            //----------------------------------------------------------

            GetResultMultiply getResultMultiply = (a, b) => a * b;
            GetResultMultiply getResultSum = (a, b) => a + b;
            GetResultMultiply getResultSub = (a, b) => a - b;
            DisplayMultiply(getResultMultiply);
            DisplayMultiply(getResultSum);
            DisplayMultiply(getResultSub);
        }

        public static void DisplayMultiply(GetResultMultiply getResultMultiply)
        {
            Console.WriteLine("Lambda Expression: {0}",getResultMultiply(3, 4)); 
        }
        public static void SayHello(string value)
        {
            Console.WriteLine(value);
        }

    }
}
