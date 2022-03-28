using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iAnonymousFunctions.FuncAndAction
{
    public static class ClosureSample
    {
        public static void MyClosure()
        {
            Console.WriteLine("Closure:");

            int localVariable = 1;

            // It is just a definition, NOT execution.
            Func<int, int> func = (x) =>
             {
                 return localVariable + x;
             };

            // Before execution of closure localVariable will be changed
            localVariable = 100;

            // This line is execution of closure
            var result = func(1);

            Console.WriteLine(result);
        }
    }
}
