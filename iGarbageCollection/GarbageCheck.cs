using System;

namespace iGarbageCollection;

public class GarbageCheck
{
    public GarbageCheck()
    {
        Console.WriteLine("Reserve memory");
    }
    ~GarbageCheck()
    {
        Console.WriteLine("Free memory");
    }
}