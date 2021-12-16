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

    public class Printer<T1> where T1 : Person
    {
        public virtual string Print(T1 person) => person.ToString();
    }

    public class Printer<T1, T2> where T1 : Person where T2 : Person
    {
        public virtual string Print(T1 p1, T2 p2) => $"{p1.ToString()}\r\n{p2.ToString()}";
    }

    public class Printer<T1, T2, T3> 
        where T1 : Person 
        where T2 : Person 
        where T3 : Person
    {
        public virtual string Print(T1 p1, T2 p2) => $"{p1.ToString()}\r\n{p2.ToString()}";
    }

    /// Inheritanc in Generics :

    /// 1. Child is non-Generic and parent is Generic (Type of Generic must be specified)
    public class PersonPrinter : Printer<Person>
    {
    }

    /// 2. Child is Generic and parent is Generic (child and parent are Generic both)
    public class PersonPrinter<T> : Printer<T> 
        where T : Person
    {
    }

    /// 3. Child is Generic and parent has one define type and one Generic
    public class PersonPrinter<T1,T2> : Printer<Teacher,T1,T2> 
        where T1 : Person
        where T2: Person
    {
    }

    ///Example of Input and output Generics
    public class TestClass<TInput, TOutput>
    {
        public TOutput Test(TInput input)
        {
            return default;
        }
    }
}
