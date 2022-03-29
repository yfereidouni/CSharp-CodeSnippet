using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Linklists;

public class LinkedlistSample
{
    public LinkedList<string> list = new LinkedList<string>();

    public void Add(string input)
    {
        LinkedListNode<string> node = new LinkedListNode<string>(input);
        
        list.AddLast(input); 
    }

    public void AddAfter(string input)
    {
        LinkedListNode<string> newNode = new LinkedListNode<string>(input);
        var first = list.First;
        list.AddAfter(first, newNode);
    }

}
