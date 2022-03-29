using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCollections.Queues
{
    public class PriorityQueues
    {
        PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

        public void AddWithSamePriority()
        {
            priorityQueue.Enqueue("1", 1);
            priorityQueue.Enqueue("2", 1);
            priorityQueue.Enqueue("3", 1);

            Console.WriteLine("\r\n");
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
        }


        public void AddWithDifferentPriority()
        {
            priorityQueue.Enqueue("1", 1);
            priorityQueue.Enqueue("2", 1);
            priorityQueue.Enqueue("3", 1);
            

            Console.WriteLine("\r\n");
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
        }
    }
}
