using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Queues;

public class QueueSample
{
    Queue<string> queue = new Queue<string>();

    public void Enqueue(string input)
    {
        queue.Enqueue(input);
        Console.WriteLine($"Message => \"{input}\" was added to queue.");
    }

    public string Dequeue() =>
        $"Message => \"{queue.Dequeue()}\" was removed from queue.";


    public void CountAndCapacity()
    {
        Console.WriteLine($"\r\nCount: {queue.Count} \r\n");
    }

    public string Peek() => $"Message => \"{queue.Peek()}\" is on the queue's Top";
    
}
