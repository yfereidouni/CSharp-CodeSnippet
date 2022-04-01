using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAttributes.DiscoveringMetadata
{
    public class MetadataPrinter
    {
        private readonly Type type;

        public MetadataPrinter(Type type)
        {
            this.type = type;
        }

        public void Print()
        {
            PrintMainInfo();
            PrintMethodInfo();
            PrintPropertyInfo();
            PrintFieldInfo();
        }

        private void PrintFieldInfo()
        {
            Console.WriteLine($"\r\n***** Fields Information of ({type.Name}) *****\r\n");
            var fieldInfos = type.GetProperties();
            foreach (var fieldInfo in fieldInfos = type.GetProperties())
            {
                Console.Write($"{fieldInfo.PropertyType} {fieldInfo.Name} (");
            Console.WriteLine(")");
            }
        }

        private void PrintPropertyInfo()
        {
            Console.WriteLine($"\r\n***** Properties Information of ({type.Name}) *****\r\n");
            var propertyInfos = type.GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                Console.Write($"{propertyInfo.PropertyType} {propertyInfo.Name} (");
            Console.WriteLine(")");
            }
        }

        private void PrintMethodInfo()
        {
            Console.WriteLine($"\r\n***** Method Information of ({type.Name}) *****\r\n");
            var methodInfo = type.GetMethods();

            foreach (var method in methodInfo)
            {
                Console.Write($"{method.Name} (");

                var parameters = method.GetParameters();
                foreach (var item in parameters)
                {
                    Console.Write($"{item.ParameterType} {item.Name}");
                }
                Console.WriteLine(")");
            }
        }

        private void PrintMainInfo()
        {
            Console.WriteLine($"\r\n***** Information of ({type.Name}) *****\r\n");
            Console.WriteLine($"FullName: {type.FullName}");
            Console.WriteLine($"AssemblyQualifiedName: {type.AssemblyQualifiedName}");
            Console.WriteLine($"BaseType: {type.BaseType}");
            Console.WriteLine($"Namespace: {type.Namespace}");
            Console.WriteLine($"IsAbstract: {type.IsAbstract}");
            Console.WriteLine($"IsEnum: {type.IsEnum}");
            Console.WriteLine($"IsPublic: {type.IsPublic}");

        }
    }
}
