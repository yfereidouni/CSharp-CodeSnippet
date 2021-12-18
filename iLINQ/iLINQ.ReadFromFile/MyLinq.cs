using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLINQ.ReadFromFile
{
    public static class MyLinq
    {
        public static List<Tinput> Where2<Tinput>(this IEnumerable<Tinput> inputList, Func<Tinput, bool> func)
        {
            List<Tinput> result = new List<Tinput>();
            foreach (var item in inputList)
            {
                if (func.Invoke(item))
                {
                    result.Add(item); 
                }
            }
            return result;
        }

        public static IEnumerable<Tinput> Where3<Tinput>(this IEnumerable<Tinput> inputList, Func<Tinput, bool> func)
        {
            foreach (var item in inputList)
            {
                if (func.Invoke(item))
                {
                    yield return item;
                }
            }
        }
    }
}
