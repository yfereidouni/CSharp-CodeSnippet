using System;

namespace iEnums
{
    public enum Day
    {
        Mo, Tu, We, Th, Fr, Sa, Su
    };
    public enum Month
    {
        Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec
    };

    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day mo = Day.Mo;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);         //Output: True
            Console.WriteLine(Day.Mo);          //Output: Mo
            Console.WriteLine((int)Day.Mo);     //Output: 0
            Console.WriteLine((int)Month.Jan);  //Output: 1
            Console.WriteLine((int)Month.Aug);  //Output: 13 - Because we set 12 for "Jul" before Aug

        }
    }
}
