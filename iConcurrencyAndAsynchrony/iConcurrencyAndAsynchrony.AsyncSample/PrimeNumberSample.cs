using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.AsyncSample
{
    public class PrimeNumberSample
    {
        private int GetPrimeNumberCount(int startFrom, int count)
        {
            return Enumerable.Range(startFrom, count).Count(c =>

                Enumerable.Range(2, (int)Math.Sqrt(c) - 1).All(d => c % d != 0));
        }

        private Task<int> GetPrimeNumberCountAsync(int startFrom, int count)
        {
            return Task.Run(() => Enumerable.Range(startFrom, count).Count(c =>

                 Enumerable.Range(2, (int)Math.Sqrt(c) - 1).All(d => c % d != 0)));
        }

        public void DisplayPrimeNumberV1()
        {
            int count = 1_000_000;
            for (int i = 0; i < 10; i++)
            {
                int start = i * count + 2;
                int itemCount = count - 3;

                Console.WriteLine($"There are {GetPrimeNumberCount(start, count)} between {start} and {start + itemCount}");
            }
            Console.WriteLine("Done!");
        }

        public void DisplayPrimeNumberV2()
        {
            int count = 1_000_000;
            for (int i = 0; i < 10; i++)
            {
                int start = i * count + 2;
                int itemCount = count - 3;

                Console.WriteLine($"There are {GetPrimeNumberCountAsync(start, count)} between {start} and {start + itemCount}");
            }
            Console.WriteLine("Done!");
        }
        public void DisplayPrimeNumberV3()
        {
            int count = 1_000_000;
            for (int i = 0; i < 10; i++)
            {
                int start = i * count + 2;
                int itemCount = count - 3;
                var awaiter = GetPrimeNumberCountAsync(start, count).GetAwaiter();
                awaiter.OnCompleted(() => Console.WriteLine($"There are {awaiter.GetResult()} between {start} and {start + itemCount}"));
            }
            Console.WriteLine("Done!");
        }

        public void DisplayPrimeNumberV4()
        {
            DisplayPrimeInner(0, 1_000_000);
        }

        private void DisplayPrimeInner(int i, int count)
        {
            int start = i * count + 2;
            int itemCount = count - 3;
            var awaiter = GetPrimeNumberCountAsync(start, count).GetAwaiter();

            awaiter.OnCompleted(() =>
            {
                Console.WriteLine($"There are {awaiter.GetResult()} between {start} and {start + itemCount}");
                i++;
                if (i < 10)
                {
                    DisplayPrimeInner(i, count);
                }
                else
                {
                    Console.WriteLine("Done");
                }
            });
        }

        public async void DisplayPrimeNumberV5()
        {
            int count = 1_000_000;
            for (int i = 0; i < 10; i++)
            {
                int start = i * count + 2;
                int itemCount = count - 3;

                Console.WriteLine($"There are { await GetPrimeNumberCountAsync(start, count)} between {start} and {start + itemCount}");
            }
            Console.WriteLine("Done!");
        }

        public async Task DisplayPrimeNumberV6()
        {
            int count = 1_000_000;
            for (int i = 0; i < 10; i++)
            {
                int start = i * count + 2;
                int itemCount = count - 3;

                Console.WriteLine($"There are { await GetPrimeNumberCountAsync(start, count)} between {start} and {start + itemCount}");
            }
            Console.WriteLine("Done!");
        }

    }
}
