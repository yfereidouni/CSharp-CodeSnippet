using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class PassDataSample
    {
        public void Start()
        {
            Thread worker = new Thread(() => PrintFullName("Yasser", "Fereidouni"));
            worker.Start();
        }

        public void ObjectSampleInStart()
        {
            Thread worker = new Thread(PrintObject);
            string parameter = "Hello World!";
            worker.Start(parameter);
        }

        public void PrintObject(Object input)
        {
            Console.WriteLine(input.ToString());
        }

        public void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName}, {lastName}");
        }

        public void CapturedVariableproblem()
        {
            string fullName = "Hassan Mohammadi";
            Thread firstThread = new Thread(() => Console.WriteLine(fullName));
            fullName = "Yasser Fereidouni";
            Thread secondThread = new Thread(() => Console.WriteLine(fullName));
            
            firstThread.Start();
            secondThread.Start();
        }

        public void PrintNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = i; // Local variable
                new Thread(() => Console.WriteLine(temp)).Start();
            }
        }
    
    }
}
