﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Arrays
{
    public static class ArrayClass
    {
        public static void ArrayClassSample()
        {
            var myArray = Array.CreateInstance(typeof(int), 10);

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray.SetValue(((byte)DateTime.Now.Ticks), i);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray.GetValue(i) + " ");
            }

            Console.WriteLine("\r\n-------------------------------");
        }

        public static void CloneArray()
        {
            var myArray = Array.CreateInstance(typeof(int), 10);

            myArray.SetValue(99, 0);

            var myCloneArray = (Array)myArray.Clone();

            Console.WriteLine(myArray.GetValue(0));

            Console.WriteLine(myCloneArray.GetValue(0));
        }

        public static void SortedArray()
        {
            int[] myArray = new int[] { 10, 9, 3, 8, 5, 7, 4, 1, 6, 2 };

            Array.Sort(myArray);

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\r\n--------------------------------------");
        }

        public class Person : IComparable<Person>
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = "";

            public int CompareTo(Person? other)
            {
                if (this.Id == other.Id)
                {
                    return 0;
                }
                else if (this.Id > other.Id)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            public override string ToString()
            {
                return $"Person : {Id} | {FirstName}";
            }
        }
        public class FirstNameSortAsc : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
                if (string.Compare(x?.FirstName, y?.FirstName) == 0)
                    return 0;
                else if (string.Compare(x?.FirstName, y?.FirstName) < 0)
                    return -1;
                else
                    return 1;
            }
        }
        public class FirstNameSortDesc : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
                if (string.Compare(x?.FirstName, y?.FirstName) == 0)
                    return 0;
                else if (string.Compare(x?.FirstName, y?.FirstName) < 0)
                    return 1;
                else
                    return -1;
            }
        }

        public static void SortedArrayWithIComparable()
        {
            Person[] myPersonArray = new Person[] {
                new Person{ Id=9,FirstName="Yasser"},
                new Person{ Id=2,FirstName="Reza"},
                new Person{ Id=7,FirstName="Ahmad"},
            };
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Unsorted:");
            foreach (var item in myPersonArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Array.Sort(myPersonArray); // Sorting array
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sorted by ID:");
            foreach (var item in myPersonArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Array.Sort(myPersonArray, new FirstNameSortAsc());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sorted by FirstName Asc:");
            foreach (var item in myPersonArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Array.Sort(myPersonArray, new FirstNameSortDesc());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sorted by FirstName Desc:");

            foreach (var item in myPersonArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
