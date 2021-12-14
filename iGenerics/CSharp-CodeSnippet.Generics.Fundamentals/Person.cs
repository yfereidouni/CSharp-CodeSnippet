using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Generics.Fundamentals
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            //return $"FirstName: {FirstName}\tLastName: {LastName}\t";
            return $"FirstName: {FirstName}".PadRight(40, ' ') + $"LastName: {LastName}".PadRight(40, ' ');
        }
    }

    public class Teacher : Person
    {
        public string TeacherCode { get; set; }
        public override string ToString()
        {
            //return base.ToString() + " TeacherId: " + $"{TeacherCode}";
            return base.ToString() + $"TeacherId: {TeacherCode}".PadRight(40, ' ');
        }
    }

    public class Student : Person
    {
        public string StudentCode { get; set; }
        public override string ToString()
        {
            //return base.ToString() + " StudentId: " + $"{StudentCode}";
            return base.ToString() + $"StudentId: {StudentCode}".PadRight(40, ' ');
        }
    }

    public class PersonPrinter<TInput> where TInput : Person, new()
    {
        public string Printer(TInput input)
        {
            //var person = input as Person; // /* When we use constraint we dont need to type cast */
            return input.ToString();
        }
    }
}
