// See https://aka.ms/new-console-template for more information

using static iTypes.Enums.PublicEnums;

Day friday = Day.Friday;
Day sunday = Day.Sunday;
Day a = Day.Friday;

Console.WriteLine(friday == a);          //Output: True
Console.WriteLine(Day.Monday);           //Output: Mo
Console.WriteLine((int)Day.Monday);      //Output: 0
Console.WriteLine((int)Month.January);   //Output: 1
Console.WriteLine((int)Month.Augest);    //Output: 13 - Because we set 12 for "Jul" before Aug
Console.WriteLine(sunday.GetHashCode()); //Output: 6

Enum.TryParse<Day>("Sunday".ToString(), out Day dayResult);
Console.WriteLine(dayResult);
