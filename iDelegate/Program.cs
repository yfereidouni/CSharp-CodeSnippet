using System;

namespace iDelegate
{
    class Program
    {
        public delegate void iDelegate(string value);
        public delegate string GetTextDelegate(string name);
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
        }
        public static void SayHello(string value)
        {
            Console.WriteLine(value);
        }

    }
}
