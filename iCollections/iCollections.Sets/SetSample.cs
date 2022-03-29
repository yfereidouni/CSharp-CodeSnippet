using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Sets
{
    public class SetSample
    {
        HashSet<string> set = new HashSet<string>();

        public void Add(string input)
        {
            set.Add(input);
        }

        public void PrintAll()
        {
            foreach (var item in set)
                Console.WriteLine(item);
        }
        
        public void Operators()
        {
            HashSet<string> newSet = new HashSet<string>();
            newSet.Add("01");
            newSet.ExceptWith(set);
            newSet.UnionWith(set);
            newSet.IntersectWith(set);
            newSet.IsProperSubsetOf(set);
            newSet.IsSupersetOf(set);
        }
    }
}
