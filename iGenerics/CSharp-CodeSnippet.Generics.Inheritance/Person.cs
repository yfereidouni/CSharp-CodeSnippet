using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Generics.Inheritance
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"Person: {Id} | {FirstName} | {LastName}";
    }

    public class Student : Person
    {
        public string StudentCode { get; set; }
        public override string ToString() => $"Student: {Id} | {FirstName} | {LastName} | {StudentCode}";

    }

    public class Teacher : Person
    {
        public Teacher()
        {
            Id = 1;
            FirstName = "Soroush";
            LastName = "Sarabi";
            TeacherCode = "T-1020";
        }
        public string TeacherCode { get; set; }
        public override string ToString() => $"Teacher: {Id} | {FirstName} | {LastName} | {TeacherCode}";
    }

    public class Printer<T> where T : Person
    {
        public string PrintPersonnel(T person) => person.ToString();
    }
    
    /// <summary>
    /// Inheritance in Generics : Child is non-Generic and parent is Generic
    /// </summary>
    public class PrintNonGeneric : Printer<Person> 
    {
        public string PrintNonGenericPersonnel(Person person) => person.ToString();
    }

   

}
