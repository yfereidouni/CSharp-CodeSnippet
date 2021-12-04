using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class BinaryOperators
    {
        public void And()
        {
            ///binary digits
            int a = 0b011;
            int b = 0b010;

            ///output : 010
            var c = a & b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("AND ".PadLeft(10, '-'));
            Console.WriteLine(c + Environment.NewLine);
        }
        public void Or()
        {
            ///binary digits
            int a = 0b011;
            int b = 0b010;

            ///output : 010
            var c = a | b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("| ".PadLeft(10, '-'));
            Console.WriteLine(c + Environment.NewLine);
        }
        public void XOr()
        {
            ///binary digits
            int a = 0b011;
            int b = 0b010;

            ///output : 010
            var c = a ^ b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("^ ".PadLeft(10, '-'));
            Console.WriteLine(c + Environment.NewLine);
        }
        public void NOT()
        {
            ///binary digits
            int a = 0b011;
            int b = 0b010;

            ///output : 010
            var c = ~b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("~ ".PadLeft(10, '-'));
            Console.WriteLine(c + Environment.NewLine);
        }
        public void ShiftLeft()
        {
            ///binary digits
            int a = 0b1;

            ///output : 010
            var c = a << 1;
            var d = a << 2;
            var e = a << 3;
            var f = a << 4;

            Console.WriteLine("<< ".PadLeft(10, '-'));
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(Environment.NewLine);
        }
        public void ShiftRight()
        {
            ///binary digits
            int a = 0b10000;
            Console.WriteLine(a);

            ///output : 010
            var c = a >> 1;
            var d = a >> 2;
            var e = a >> 3;
            var f = a >> 4;

            Console.WriteLine(">> ".PadLeft(10, '-'));
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
