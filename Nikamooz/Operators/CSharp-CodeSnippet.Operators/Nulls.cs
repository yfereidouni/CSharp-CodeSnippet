using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class Nulls
    {
        public void NullOperators01()
        {
            int? a = null;

            int b = a == null ? 0 : a.Value;

            /// it is simple form of above command
            /// if a == null then 0 will assigned to c else 0 assigned to c
            int c = a ?? 0;
        }

        public void NullOperators02(Person person)
        {
            //if person is null then skip from access to it due to prevent "System.NullReferenceException" error
            Console.WriteLine(person?.FirstName);
        }
    }
}
