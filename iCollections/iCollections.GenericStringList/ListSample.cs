using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.GenericStringList
{
    public class ListSample
    {
        List<string> list = new List<string>();

        public void PrintCapacity()
        {
            Console.WriteLine($"Capacity: {list.Capacity} | Count: {list.Count} \r\n");
        }

        public void AddMember(string input)
        {
            list.Add(input);
            Console.WriteLine($"\tMessage => {input} was added.\r\n");
        }

        public void Ensure()
        {
            list.EnsureCapacity(20);
            Console.WriteLine("\tMessage => List was EnsureCapacity(20)!\r\n");

        }

        public void Trim()
        {
            list.TrimExcess();
            Console.WriteLine("\tMessage => List was TrimExcess!\r\n");
        }
    }
}
