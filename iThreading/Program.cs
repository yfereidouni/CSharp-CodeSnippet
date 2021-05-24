using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace iThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World!");

            /*
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start(); new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start(); new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start(); new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
            */

            /*
            var taskCompletationSource = new TaskCompletionSource<bool>();
            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} Started.");
                Thread.Sleep(3000);
                taskCompletationSource.TrySetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} Ended.");

            });
            thread.Start();
            var test = taskCompletationSource.Task.Result;
            Console.WriteLine("Task was done: {0}", test);
            */

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            })
            { IsBackground = true }.Start();

            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                //new Thread(() =>
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} Started.");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} Ended.");
                });
            });

            Console.ReadLine();
        }
    }
}
