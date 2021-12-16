using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSorts.BubbleSort
{
    //public delegate bool SortDirection(int input01, int input02);

    /// Delegates without Output
    public delegate void Delegate01();
    public delegate void Delegate01<T1>(T1 t1);
    public delegate void Delegate01<T1, T2>(T1 t1, T2 t2);
    public delegate void Delegate01<T1, T2, T3>(T1 t1, T2 t2, T3 t3k);

    /// Delegates with output 
    public delegate Tout Delegate02<Tout>();
    public delegate Tout Delegate02<T1, Tout>(T1 t1);
    public delegate Tout Delegate02<T1, T2, Tout>(T1 t1, T2 t2);
    public delegate Tout Delegate02<T1, T2, T3, Tout>(T1 t1, T2 t2, T3 t3k);

    public class BubbleSort
    {
        public Func<int, int, bool> SortOption;

        public int[] bubblesort(int[] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = i; j < inputs.Length; j++)
                {
                    int temp = 0;
                    if (inputs[i] < inputs[j])
                    {
                        temp = inputs[i];
                        inputs[i] = inputs[j];
                        inputs[j] = temp;
                    }
                }
            }
            return inputs;
        }

        public int[] bubblesort(int[] inputs, bool IsAsc)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = i; j < inputs.Length; j++)
                {
                    int temp = 0;
                    if ((IsAsc && inputs[i] < inputs[j]) || (!IsAsc && inputs[i] > inputs[j]))
                    {
                        temp = inputs[i];
                        inputs[i] = inputs[j];
                        inputs[j] = temp;
                    }
                }
            }
            return inputs;
        }

        #region public int[] bubblesort(int[] inputs, SortDirection sortDirection)
        //public int[] bubblesort(int[] inputs, SortDirection sortDirection)
        //{
        //    for (int i = 0; i < inputs.Length; i++)
        //    {
        //        for (int j = i; j < inputs.Length; j++)
        //        {
        //            int temp = 0;
        //            if (sortDirection.Invoke(inputs[i], inputs[j]))
        //            {
        //                temp = inputs[i];
        //                inputs[i] = inputs[j];
        //                inputs[j] = temp;
        //            }
        //        }
        //    }
        //    return inputs;
        //}
        #endregion

        #region public int[] bubblesort(int[] inputs, Delegate02<int, int, bool> delegate02)
        //public int[] bubblesort(int[] inputs, Delegate02<int, int, bool> delegate02)
        //{
        //    for (int i = 0; i < inputs.Length; i++)
        //    {
        //        for (int j = i; j < inputs.Length; j++)
        //        {
        //            int temp = 0;
        //            if (delegate02.Invoke(inputs[i], inputs[j]))
        //            {
        //                temp = inputs[i];
        //                inputs[i] = inputs[j];
        //                inputs[j] = temp;
        //            }
        //        }
        //    }
        //    return inputs;
        //}
        #endregion

        public int[] bubblesort(int[] inputs, Func<int, int, bool> delegate02)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                for (int j = i; j < inputs.Length; j++)
                {
                    int temp = 0;
                    if (delegate02.Invoke(inputs[i], inputs[j]))
                    {
                        temp = inputs[i];
                        inputs[i] = inputs[j];
                        inputs[j] = temp;
                    }
                }
            }
            return inputs;
        }

        public bool Asc(int input01, int input02)
            => input01 > input02;

        public bool Desc(int input01, int input02)
            => input01 < input02;

        public bool newSort(int input01, int input02)
            => input01 > input02 && DateTime.Now.Hour > 12;

        public void PrintResult(int[] inputs)
        {
            foreach (var item in inputs)
            {
                Console.Write(item + "".PadRight(2, ' '));
            }
            Console.WriteLine("\r\n".PadRight(50, '-'));
        }

    }


}
