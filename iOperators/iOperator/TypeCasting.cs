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
            ///Despite of sum up two byte variable the result varuable will be expected as byte 
            ///but we can see due to preventing of "OverfloweException" it change to Int32
            Console.WriteLine(c.GetType().Name);
        }

        public void ImplicitTypeCast()
        {
            byte a = 1;
            byte b = 2;

            /// We can implicitly assign a small value to bigger size varible without any error or warnings
            /// We can also implicitly assign a not nullable value to nullable because target variable is bigger than source
            int c = a;
            int? d = b;
        }

        public void ExplicitTypeCast()
        {
            double a = 10.3;

            ///this assignments has error because we miss some part of data
            //int b = a;
            int b = (int)a;

            Console.WriteLine(b);
        }

    }
}
