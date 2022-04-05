using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.TaskSample
{
    public class ExceptionSample
    {
        public void Start()
        {
            Task<int> badMethod = Task.Run(() => BadMethod(null, 10));
            try
            {
                badMethod.Wait();
                Console.WriteLine("BadMethod Finished!");
            }
            catch (AggregateException ex)
            {
                Console.WriteLine($"IsCanceled: { badMethod.IsCanceled}");
                Console.WriteLine($"IsFaulted: {badMethod.IsFaulted}");
                Console.WriteLine(ex.Message);
            }
        }

        public int BadMethod(int? num01, int? num02)
        {
            if (num01 == null)
            {
                throw new ArgumentNullException(nameof(num01));
            }
            if (num02 == null)
            {
                throw new ArgumentNullException(nameof(num02));
            }

            return num01.Value + num02.Value;
        }
    }
}
