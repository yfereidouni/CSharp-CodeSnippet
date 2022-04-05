using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class ForegroundBackgroundThread
    {
        public void Start()
        {
            Thread worker = new Thread(PrintAndRead);
            worker.Start();
            worker.IsBackground = true;
            Console.WriteLine("Main Thread Finished");
            worker.Join(TimeSpan.FromSeconds(10));
        
        }

        public void PrintAndRead()
        {
            Console.Write("Enter a word: ");
            Console.ReadLine();

        }
    }
}
