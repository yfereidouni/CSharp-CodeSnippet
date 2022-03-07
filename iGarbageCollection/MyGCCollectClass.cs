using System;

namespace iGarbageCollection;

public class MyGCCollectClass
{
    private const long maxGarbage = 1000;
    public void MakeSomeGarbage()
    {
        Version vt;

        // Create objects and release them to fill up memory with unused objects.
        for (int i = 0; i < maxGarbage; i++)
        {
            vt = new Version();
        }
    }
}