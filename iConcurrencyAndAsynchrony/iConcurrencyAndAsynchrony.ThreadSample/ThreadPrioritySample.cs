using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class ThreadPrioritySample
    {
        public void Start()
        {
            Thread T1 = new Thread(() => ThreadPrinter("*"));
            Thread T2 = new Thread(() => ThreadPrinter("-"));
            Thread T3 = new Thread(() => ThreadPrinter("+"));
            T1.Priority = ThreadPriority.Highest;
            T3.Priority = ThreadPriority.Lowest;
            T1.Start();
            T2.Start();
            T3.Start();
        }

        public void ThreadPrinter(string input)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(input);
            }
        }
    }
}
