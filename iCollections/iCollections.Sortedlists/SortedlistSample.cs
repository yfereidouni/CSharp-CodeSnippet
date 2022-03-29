using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Sortedlists;

public class SortedlistSample
{
    public SortedList<int, string> list = new SortedList<int, string>();

    public void Add(int key, string value)
    {        
        list.Add(key, value); 
    }

    public void Remove(int key)
    {
        list.Remove(key);
    }

}
