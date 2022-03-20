using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.RefInOut
{
    public class CallByRefInOut
    {
        public void CallByRef()
        {
            int myValue = 1;
            Console.WriteLine("Call By Ref:");
            Console.WriteLine(myValue);
            CalleeByRef(ref myValue);
            Console.WriteLine(myValue);
            Console.WriteLine("".PadRight(50,'-'));
        }
        public void CalleeByRef(ref int input)
        {
            input = 3; // we can change the value but it is not required
        }

        public void CallByOut()
        {
            Console.WriteLine("Call By Out:");
            CalleeByOut(out int myValue);
            Console.WriteLine(myValue);
            Console.WriteLine("".PadRight(50, '-'));

        }
        public void CalleeByOut(out int input)
        {
            input = 3;
        }

        public void CallByIn()
        {
            int myValue = 1;
            Console.WriteLine("Call By In:");
            Console.WriteLine(myValue);
            CalleeByIn(in myValue);
            Console.WriteLine(myValue);
            Console.WriteLine("".PadRight(50, '-'));

        }
        public void CalleeByIn(in int input)
        {
            //input = 3; //Error: we cannot change it because it is read-only
        }

    }
}
