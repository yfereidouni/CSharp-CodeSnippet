using System;
using System.Collections.Generic;

namespace iADO.NETSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository pr = new PersonRepository();

            //int result = pr.CreatePerson("Majid", "Akhshabi", new DateTime(1980, 07, 12), "26");

            //Console.WriteLine($"Record affected : {result}");

            List<Person> prs = pr.ReadAllPersons();

            foreach (Person item in prs)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
