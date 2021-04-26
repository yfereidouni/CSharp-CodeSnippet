using System;

namespace iStructures
{
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstname,string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }
        public void Display()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person yasser = new Person("Yasser", "Fereidouni", 36);
            yasser.Display();
        }
    }
}
