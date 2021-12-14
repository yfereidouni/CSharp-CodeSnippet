using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Human() { }
        public Human(int age)
        {
            this.Age = age;
        }

        public static implicit operator int(Human human)
            => human.Age;

        public static implicit operator Human(int age)
            => new Human(age);

        public static explicit operator byte(Human human)
            => (byte)human.Age;

        public static explicit operator Human(double age)
            => new Human((int)age);
    }

}
