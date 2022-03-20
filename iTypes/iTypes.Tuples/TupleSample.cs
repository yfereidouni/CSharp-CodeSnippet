using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Tuples
{
    public class TupleSample
    {
        public void Tupe_01()
        {
            (int Id, string FirstName, string LastName) Person = new(1, "Yasser", "Fereidouni");

            Console.WriteLine($"{Person.Id}");
            Console.WriteLine($"{Person.FirstName}");
            Console.WriteLine($"{Person.LastName}");
        }

        public (int Id, string FirstName, string LastName) ReturnTuple()
        {
            return (1, "Yasser", "Fereidouni");
        }

        public void CallReturnTuple()
        {
            var result = ReturnTuple();
            Console.WriteLine($"{result.Id}");
            Console.WriteLine($"{result.FirstName}");
            Console.WriteLine($"{result.LastName}");
        }

        public void CallReturnTupleDeconstruction()
        {
            (int Id, string FirstName, string LastName) = ReturnTuple();
            Console.WriteLine($"{Id}");
            Console.WriteLine($"{FirstName}");
            Console.WriteLine($"{LastName}");
        }

    }
}
