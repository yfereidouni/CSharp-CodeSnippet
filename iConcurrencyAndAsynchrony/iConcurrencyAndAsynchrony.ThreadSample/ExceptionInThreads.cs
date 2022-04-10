using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class ExceptionInThreads
    {
        public void Start()
        {
            Thread worker = new Thread(ThreadStartPoint);
            worker.Start();
        }

        public void ThreadStartPoint()
        {
            try
            {
                BadMethod();
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Exception !\r\n{Ex.Message}");
            }
        }

        private void BadMethod()
        {
            throw new NotImplementedException();
        }
    }
}
