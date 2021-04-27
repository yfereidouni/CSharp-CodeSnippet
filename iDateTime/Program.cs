using System;

namespace iDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1985, 03, 30);
            Console.WriteLine($"my birthday is: {dt}");

            Console.WriteLine($"Now: {DateTime.Now}");
            Console.WriteLine($"Today: {DateTime.Today}");
            Console.WriteLine($"Tomorrow: {GetTomorrow()}");
            Console.WriteLine($"First Day of Week: {DateTime.Today.DayOfWeek}");

            
            Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Enter date: ");
            string input = "04/20/2021";//Console.ReadLine();
            DateTime dateTiem;
            if (DateTime.TryParse(input, out dateTiem))
            {
                Console.WriteLine(dateTiem);
                TimeSpan daysPassed = DateTime.Now.Subtract(dateTiem);
                Console.WriteLine("Day passed: {0}",daysPassed);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second);
            Console.WriteLine("----------------------------------------------");

        }

        public static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
