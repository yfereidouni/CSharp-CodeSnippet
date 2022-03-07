using System;

namespace iGarbageCollection;

class Program
{
    static void Main(string[] args)
    {
        // Using a class in memory
        Details();

        // Free-up memory and run deconstructor of class
        GC.Collect();

        //Console.ReadLine();
        
        // It ensure that program "must wait" and should not contine untill memory completely clean-up
        GC.WaitForPendingFinalizers();

        Console.WriteLine("----------------------------------------------------");

        MyGCCollectClass myGCCol = new MyGCCollectClass();

        // Determine the maximum number of generations the system
        // garbage collector currently supports.
        Console.WriteLine("The highest generation is : {0}\r\n", GC.MaxGeneration);

        myGCCol.MakeSomeGarbage();

        // Determine which generation myGCCol object is stored in.
        Console.WriteLine("Generation: {0}\r\n", GC.GetGeneration(myGCCol));

        // Determine the best available approximation of the number
        // of bytes currently allocated in managed memory.
        Console.WriteLine("Total Memory: {0}\r\n", GC.GetTotalMemory(false));

        // Perform a collection of generation 0 only.
        GC.Collect(0);

        // Determine which generation myGCCol object is stored in.
        Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
        Console.WriteLine("Total Memory: {0}\r\n", GC.GetTotalMemory(false));

        // Perform a collection of all generations up to and including 2.
        GC.Collect(2);

        // Determine which generation myGCCol object is stored in.
        Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));
        Console.WriteLine("Total Memory: {0}\r\n", GC.GetTotalMemory(false));
        Console.Read();
    }

    public static void Details()
    {
        // Created instance of the class
        GarbageCheck gc = new GarbageCheck();
    }
}