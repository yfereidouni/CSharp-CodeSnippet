using System;
using System.Collections.Generic;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository pr = new PersonRepository();

            //int result = pr.CreatePerson("Reza", "Asadi", new DateTime(1985, 03, 30), "52");

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
