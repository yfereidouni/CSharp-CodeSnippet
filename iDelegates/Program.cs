using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace iDelegates
{
    class Program
    {
        #region delegate
        public delegate bool SortDirection(int input01, int input02);
        public delegate void MyDelegate();
        public delegate void MyDelegate<T1>(T1 t1);
        public delegate void MyDelegate<T1, T2>(T1 t1, T2 t2);
        public delegate void MyDelegate<T1, T2, T3>(T1 t1, T2 t2, T3 t3);
        public delegate Tout MyDelegate2<Tout>();
        public delegate Tout MyDelegate2<T1, Tout>(T1 t1);
        public delegate Tout MyDelegate2<T1, T2, Tout>(T1 t1, T2 t2);
        public delegate Tout MyDelegate2<T1, T2, T3, Tout>(T1 t1, T2 t2, T3 t3);
        #endregion

        
        static void Main(string[] args)
        {
            Delegates();
            Console.ReadKey();
        }

        private static void Delegates()
        {
            int[] UnSortedArray = new int[] { 9, 1, 8, 3, 6, 2, 4, 7 };

            int[] SortedResult = Sort(UnSortedArray, Asc);

            for (int i = 0; i < UnSortedArray.Length; i++)
            {
                Console.WriteLine(UnSortedArray[i]);
            }

            MyDelegate2<int, int, bool> myDirection = Asc;

            MyDelegate2<int, int, bool> myDirection2 = delegate (int a, int b)
            {
                return true;
            };

            Func<int, int, bool> myAnonymous = delegate (int a, int b)
            {
                return true;
            };



            myDirection += Des;
            myDirection += NewSortDirection;

            var result = myDirection.Invoke(1, 3);
            Console.WriteLine(result);

            var list = myDirection.GetInvocationList().ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.DynamicInvoke(1, 3));
            }
        }
        public static bool Asc(int a, int b)
        {
            return a > b;
        }
        public static bool Des(int a, int b)
        {
            return a < b;
        }
        public static bool NewSortDirection(int a, int b)
        {
            return a > b && DateTime.Now.Hour > 12;
        }
        //public static int[] Sort(int[] arr, SortDirection sortdirection)
        //{
        //    int n = arr.Length;
        //    for (int i = 0; i < n - 1; i++)
        //        for (int j = 0; j < n - i - 1; j++)
        //            if (sortdirection.Invoke(arr[j], arr[j + 1]))
        //            {
        //                // swap temp and arr[i] 
        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //    return arr;
        //}
        public static int[] Sort(int[] arr, MyDelegate2<int, int, bool> sortdirection)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (sortdirection.Invoke(arr[j], arr[j + 1]))
                    {
                        // swap temp and arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            return arr;
        }
    }
}

