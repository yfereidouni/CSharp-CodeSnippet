using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class TypeCasting
    {
        public void TypeSafe()
        {
            byte a = 1;
            byte b = 2;
            var c = a + b;
            Console.WriteLine(c.GetType().Name);
        }

    }
}
