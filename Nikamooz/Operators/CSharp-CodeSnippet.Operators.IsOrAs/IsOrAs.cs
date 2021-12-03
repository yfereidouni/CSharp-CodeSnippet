using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators.IsOrAs
{
    public class IsOrAs
    {
        public void CheckIsPerson(object input)
        {
            Console.WriteLine(input is Person); 
        }

        public void CheckAsPerson(object input)
        {
            var person = input as Person;
            if (person!=null)
            {
                Console.WriteLine("IS Person");
            }
            else
            {
                Console.WriteLine("IS NOT a Person");
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Student : Person
    {
        public string StudentNumber { get; set; }
    }

    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeacherNumber { get; set; }
    }
}
