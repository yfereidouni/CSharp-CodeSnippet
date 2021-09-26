using System;
using System.Collections.Generic;

namespace iSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            sortedDictionary[1] = "1";
            sortedDictionary[3] = "3";
            sortedDictionary[4] = "4";

            sortedDictionary.Add(2, "Yasser");

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
