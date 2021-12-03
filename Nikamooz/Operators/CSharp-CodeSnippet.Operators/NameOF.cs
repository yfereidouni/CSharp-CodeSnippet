using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class NameOF
    {
        public void Nameof()
        {
            var name = nameof(Car);
            Console.WriteLine(name);
        }
    }
}
