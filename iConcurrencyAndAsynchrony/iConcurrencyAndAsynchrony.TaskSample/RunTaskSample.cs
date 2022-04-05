using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.TaskSample
{
    public class RunTaskSample
    {
        public void Start()
        {
            // Hot Task
            Task result = Task.Run(() => PrintName());
            Console.WriteLine("---- Task Complete! ----");
            Console.WriteLine($"Task Status: {result.Status}");
            result.Wait();
            Console.WriteLine($"Task Status after wait: {result.Status}");
        }

        public void StartLongRunning()
        {
            // Hot Task
            Task result = Task.Factory.StartNew(() => PrintName(),TaskCreationOptions.LongRunning);
            Console.WriteLine("---- Task Complete! ----");
            Console.WriteLine($"Task Status: {result.Status}");
            result.Wait();
            Console.WriteLine($"Task Status after wait: {result.Status}");
        }

        public void StartColdTask()
        {
            // Cold Task
            Task result = new Task(PrintName);        
            Console.WriteLine($"Task Status before start: {result.Status}");
            result.Start();
            Console.WriteLine("---- Task Complete! ----");
            Console.WriteLine($"Task Status: {result.Status}");
            result.Wait();
            Console.WriteLine($"Task Status after wait: {result.Status}");
        }

        public void PrintName()
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine(Thread.CurrentThread.IsBackground);
            Thread.Sleep(3000);
            Console.WriteLine("Yasser Fereidouni");

        }
    }
}
