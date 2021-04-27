using System;

namespace iGarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Put some objects in memory.
            MakeSomeGarbage();
            Console.WriteLine("Memory used before collection:       {0:N0}",
                              GC.GetTotalMemory(false));

            // Collect all generations of memory.
            GC.Collect();
            Console.WriteLine("Memory used after full collection:   {0:N0}",
                              GC.GetTotalMemory(true));
        }

        static void MakeSomeGarbage()
        {
            int maxGarbage = 1000;

            Version vt;

            // Create objects and release them to fill up memory with unused objects.
            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Version();
            }
        }
        // The output from the example resembles the following:
        //       Memory used before collection:       79,392
        //       Memory used after full collection:   52,640
    }
}
