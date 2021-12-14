using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class BoxingAndUnboxing
    {
        public void Boxing()
        {
            int i = 123;
            // The following line boxes i.
            object obj1 = i;          // Boxing
            object obj2 = (object)i;  // explicit boxing
        }

        public void Unboxing()
        {
            object obj = 123;
            int i = (int)obj;         // Unboxing
        }
    }
}
