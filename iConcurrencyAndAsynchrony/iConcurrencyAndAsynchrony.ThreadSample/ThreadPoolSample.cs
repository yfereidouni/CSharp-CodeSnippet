using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class ThreadPoolSample
    {
        public void Start()
        {
            Thread thread1 = new Thread(DisplayThreadDetails);
            thread1.Name = "Simple Thread by YFereidouni";
            thread1.Start();

            Task.Run(() => DisplayThreadDetails());
            
        }

        public void DisplayThreadDetails()
        {
            var IsPool = Thread.CurrentThread.IsThreadPoolThread;
            var IsBackground = Thread.CurrentThread.IsBackground;

            Console.WriteLine($"Thread-Name: {Thread.CurrentThread.Name}\r\nThread-Id: {Thread.CurrentThread.ManagedThreadId}\r\nIs Thread from Pool? {IsPool}\r\nIs Background Thread? {IsBackground}\r\n");

        }
    }
}
