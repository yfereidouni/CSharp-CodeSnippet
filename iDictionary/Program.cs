using System;
using System.Collections.Generic;

namespace iDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> dictionary = new Dictionary<string, DateTime>();

            dictionary["1st"] = DateTime.Now;

            dictionary["2nd"] = DateTime.Now;

            if (!dictionary.ContainsKey("2nd"))
            {
                dictionary["2nd"] = DateTime.Now;
            }
            else
            {
                dictionary["3rd"] = DateTime.Now;
            }

            //write Key and Value
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            //write value based on key
            Console.WriteLine(dictionary["1st"]);
            Console.WriteLine(dictionary["2nd"]);
            Console.WriteLine(dictionary["3rd"]);
        }
    }
}
