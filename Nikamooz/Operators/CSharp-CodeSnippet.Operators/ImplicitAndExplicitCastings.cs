using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(int age)
        {
            this.Age = age;
        }

        public static implicit operator int(Person person)
            => person.Age;

        public static implicit operator Person(int age)
            => new Person(age);

        public static explicit operator byte(Person person)
            => (byte)person.Age;

        public static explicit operator Person(double age)
            => new Person((int)age);
    }

}
