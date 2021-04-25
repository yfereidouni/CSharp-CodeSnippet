using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace iExtensionMethod
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
            ExtensionMethod();

            Console.ReadKey();
        }

        private static void ExtensionMethod()
        {
            bool NationalNumber = "0322705053".IsNationalNumberExtension();
            Console.WriteLine($"Result of Extension Method : {NationalNumber}");
        }
        
    }
}

