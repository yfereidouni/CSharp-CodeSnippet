using System;


//Nullable int
int? num1 = null;
int? num2 = 1337;
double? num3 = new double?();
double? num4 = 3.14157;
bool? boolval = new bool?();
Console.WriteLine("num1: {0} num2: {1} num3: {2} num4: {3} bool: {4}", num1, num2, num3, num4, boolval);
Console.WriteLine("----------------------------------------------------");
bool? isMale = null;
if (isMale == true)
{
    Console.WriteLine("Male");
}
else if (isMale == false)
{
    Console.WriteLine("Female");
}
else
{
    Console.WriteLine("No gender chosen");
}
Console.WriteLine("----------------------------------------------------");

// THE NULL COALESCING OPERATOR ??

int? a = 28;
int b = a ?? -1;
Console.WriteLine($"b is {b}");  // output: b is 28

int? c = null;
int d = c ?? -1;
Console.WriteLine($"d is {d}");  // output: d is -1
