using System;

namespace iLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        public static void DoWork(Action<string> callback)
        {
            callback("Hello world");
        }

        public static void Test()
        {
            DoWork((result) => Console.WriteLine(result));
        }
    }
}
