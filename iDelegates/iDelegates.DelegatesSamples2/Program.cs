using System;

namespace iDelegate
{
    class Program
    {
        public delegate void iDelegate(string value);
        public delegate string GetTextDelegate(string name);
        static void Main(string[] args)
        {
            //----------------------------------------------------------
            //Simple Delegate
            //----------------------------------------------------------
            iDelegate sayHelloDelegate = SayHello;
            sayHelloDelegate("Yasser");
            
            //----------------------------------------------------------
            //Creating anonymous method
            //----------------------------------------------------------
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return string.Format("Hello, {0}",name);
            };
            Console.WriteLine(getTextDelegate("Yasser"));
            Display(getTextDelegate);
            //----------------------------------------------------------


        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World"));
        }
        static void SayHello(string name)
        {
            Console.WriteLine($"Hi, {name}");
        }

    }
}
