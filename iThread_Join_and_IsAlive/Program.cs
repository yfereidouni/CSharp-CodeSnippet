using System;
using System.Threading;

namespace iThread_Join_and_IsAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started.");
            Thread thread1 = new Thread(Thread1function);
            Thread thread2 = new Thread(Thread2function);
            thread1.Start();
            thread2.Start();

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function was done in 1 second");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn't done in 1 second");

            }
            thread2.Join();
            Console.WriteLine("Thread2function Done.");

            for (int i = 0; i <= 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still doing stuff");
                    Thread.Sleep(400);
                }
                else
                {
                    Console.WriteLine("Thread1 completed.");
                }
            }

            Console.WriteLine("Main Thread Ended.");
        }

        public static void Thread1function()
        {
            Console.WriteLine("Thread1function started");
            Thread.Sleep(4000);
            Console.WriteLine("Thread1function comming back to caller");

        }
        public static void Thread2function()
        {
            Console.WriteLine("Thread2function started");
        }
    }
}
