using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class SharedAndLocalState
    {
        int counter = 10;
        bool allowWrite = true;

        private readonly static object locker = new object();
        public void Start()
        {
            Thread first = new Thread(SafeCheckSharedState);
            Thread second = new Thread(SafeCheckSharedState);
            first.Name = "First";
            second.Name = "Second";
            first.Start();
            second.Start();
        }

        public void PrintStar()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write($"[{i}] = * ");
            }
        }

        public void CheckSharedState()
        {
            if (allowWrite)
            {
                Console.WriteLine("This is my message");
                allowWrite = false;
            }
        }

        public void SafeCheckSharedState()
        {
            /// This is an Exclusive Lock
            /// it means that this block only assign to one Thread
            lock (locker)
            {
                if (allowWrite)
                {

                    Console.WriteLine($"Locker Thread name is: {Thread.CurrentThread.Name}");
                    Console.WriteLine("This is my message");

                    allowWrite = false;
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name);
        }

    }
}
