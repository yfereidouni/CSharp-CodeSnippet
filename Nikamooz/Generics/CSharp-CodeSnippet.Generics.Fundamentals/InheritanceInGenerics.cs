using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Generics.Fundamentals
{
    public class InheritanceInGeneric
    {
        public class Parent<TInput01, TInput02>
        {
        }

        public class Child01 : Parent<int, int>
        {
        }

        public class Child02<TInput01> : Parent<int, TInput01>
        {
        }

        public class Child03<TInput01, TInput02> : Parent<TInput01, TInput02>
        {
        }
    }
}
