// See https://aka.ms/new-console-template for more information

using iTypes.DateTimes;

iDateTime dateTime = new iDateTime();

Console.WriteLine($"My birthday is: {dateTime.MyBirthDate}");
Console.WriteLine($"Now: {dateTime.Now}");
Console.WriteLine($"Today: {dateTime.Today}");
Console.WriteLine($"Tomorrow: {dateTime.Tomorrow}");
Console.WriteLine($"First Day of Week: {dateTime.DayOfWeek}");

Console.WriteLine("----------------------------------------------");

dateTime.DateTimeDetails();