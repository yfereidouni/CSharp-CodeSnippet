// See https://aka.ms/new-console-template for more information

/// Anonymous Functions:

Func<bool> Anonymous00 = () => true;

var result00 = Anonymous00.Invoke();

Console.WriteLine($"Anonymous result : {result00}");
Console.WriteLine("".PadRight(50, '-'));
///----------------------------------------------------------------------
Func<int, int, int> Anonymous01 = (a, b) => a + b;

var result01 = Anonymous01.Invoke(10, 20);

Console.WriteLine($"Sum : {result01}");
Console.WriteLine("".PadRight(50, '-'));
///----------------------------------------------------------------------
int testVariable = 1;
Func<int, int, bool> Anonymous02 = (a, b) =>
{
    if (a + b >= testVariable)
        return true;
    return false;
};

testVariable = 100;

var result02 = Anonymous02.Invoke(10, 20); // output: False

Console.WriteLine(result02);
Console.WriteLine("".PadRight(50, '-'));
