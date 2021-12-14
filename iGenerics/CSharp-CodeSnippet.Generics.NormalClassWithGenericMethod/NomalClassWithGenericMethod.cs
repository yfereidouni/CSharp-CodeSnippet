using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Generics.NormalClassWithGenericMethod
{
    public class NomalClassWithGenericMethod
    {
        public string Printer<TInput>(TInput input)
        {
            return input.ToString();
        }
    }
}
