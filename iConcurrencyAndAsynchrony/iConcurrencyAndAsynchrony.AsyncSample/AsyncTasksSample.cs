using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.AsyncSample
{
    public class AsyncTasksSample
    {
        public async Task Start()
        {
            await FinalResultCaller();
        }

        public async Task FinalResultCaller()
        {
            var result = await FinalResult(2);
            Console.WriteLine($"Result is: {result}");
        }

        public Task<int> FinalResult(int sleepFor)
        {
            return Task.Run(async () =>
            {
                await Task.Delay(sleepFor * 1000);
                return 10;
            });
        }

        public async Task PrintMessage(string message)
        {
            await Task.Delay(2000);
            Console.WriteLine(message);
        }

        public async Task PrintAfter3Seconds()
        {
            await Task.Delay(5010);
            Console.WriteLine("Print after 3 second Finished.");
        }
        public async Task PrintAfter4Seconds()
        {
            await Task.Delay(4990);
            Console.WriteLine("Print after 4 second Finished.");
        }
        public async Task PrintAfter5Seconds()
        {
            await Task.Delay(5000);
            Console.WriteLine("Print after 5 second Finished.");
        }
    }
}
