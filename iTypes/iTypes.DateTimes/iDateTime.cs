using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.DateTimes
{
    public class iDateTime
    {
        public DateTime MyBirthDate { get; set; } = new DateTime(1985, 03, 30);

        public DateTime Now { get; set; } = DateTime.Now;
        public DateTime Today { get; set; } = DateTime.Today;
        public DayOfWeek DayOfWeek { get; set; } = DateTime.Today.DayOfWeek;
        public DateTime Tomorrow { get; set; } = DateTime.Today.AddDays(1);

        public void DateTimeDetails()
        {
            DateTime dateTiem;
            if (DateTime.TryParse(this.Today.ToString(), out dateTiem))
            {
                Console.WriteLine(dateTiem);
                TimeSpan daysPassed = DateTime.Now.Subtract(dateTiem);
                Console.WriteLine("Day passed: {0}", daysPassed);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second);
            Console.WriteLine("----------------------------------------------");
        }
    }
}
