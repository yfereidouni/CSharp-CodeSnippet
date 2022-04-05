using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class ThreadMethodSamples
    {
        public void CreatThreadSample()
        {
            CharPrinter charPrinter = new CharPrinter();

            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);

            dashPrinterWorker.Name = "DashPrinterWorker";

            Console.WriteLine($"DashPrinterWorker isAlive befor start : {dashPrinterWorker.IsAlive}");

            dashPrinterWorker.Start();

            Console.WriteLine($"DashPrinterWorker isAlive after start : {dashPrinterWorker.IsAlive}");

            charPrinter.PrintStar();

            Console.ReadKey();

            // "DashPrinterWorker" IsAlive absolutely is "FALSE" here
            Console.WriteLine($"DashPrinterWorker isAlive after start : {dashPrinterWorker.IsAlive}");

        }

        public void JoinSample()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Start();

            //Join Wait for a process to finishing its work
            dashPrinterWorker.Join(TimeSpan.FromMilliseconds(1));

            charPrinter.PrintStar();
        }

        public void SleepSample()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Start();
            charPrinter.PrintStar();
        }

        public void ThreadStateCheck()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Start();
            
            Console.WriteLine(dashPrinterWorker.ThreadState);
            var isBlock = (dashPrinterWorker.ThreadState & ThreadState.WaitSleepJoin) != 0;
            Console.WriteLine($"\r\ndashPrinterWorker is block ? {isBlock}");

        }

    }
}
