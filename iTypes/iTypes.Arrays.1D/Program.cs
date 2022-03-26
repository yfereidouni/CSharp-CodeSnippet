// See https://aka.ms/new-console-template for more information


// 3-way of defining simple 1D array:
int[] array01 = new int[5];                  //Length = 5
int[] array02 = new int[] { 0, 1, 2, 3, 4 }; //Length = 5
int[] array03 = { 0, 1, 2, 3, 4 };           //Length = 5

// Access to array via index :
array01[0] = 7;      //{ 7, 0, 0, 0, 0 };
array02[4] = 7;      //{ 0, 1, 2, 3, 7 };
array03[2] = 7;      //{ 0, 1, 7, 3, 7 };

for (int i = 0; i < array01.Length; i++)
{
    Console.Write($"{array01[i]} ");
}

Console.WriteLine("\r\n----------------------------");

foreach (var item in array02)
{
    Console.Write($"{item} ");
}
Console.WriteLine("\r\n----------------------------");

