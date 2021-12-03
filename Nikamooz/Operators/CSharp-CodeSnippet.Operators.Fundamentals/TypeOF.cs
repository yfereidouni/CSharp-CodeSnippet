using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    ///With "Typeof" we can get meta-data of any types
    public class TypeOF
    {
        public void Typeof()
        {
            var type = typeof(Car);
            Console.WriteLine(type.AssemblyQualifiedName);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.FullName);
            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item.Name);
            }
        }

    }

    public class Car
    {
        public string Name { get; set; }
    }
}
