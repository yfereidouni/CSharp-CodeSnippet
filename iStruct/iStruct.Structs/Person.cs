using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStruct.Structs
{
    public struct PersonStruct_Old
    {
        public PersonStruct_Old() //Default Constructor was added in C# 10
        {
            Id = 0;
            FirstName = "Yasser";
            LastName = "Fereidouni";
            Age = 36;
        }
        public int Id = 0; // Field and property initializing was added in C# 10
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public readonly struct PersonStruct_V7
    {
        public PersonStruct_V7()
        {
            Id = 1;
            FirstName = "Yasser";
            LastName = "Fereidouni";
            Age = 36;
        }
        public readonly int Id;
        public string FirstName { get; init; }
        public string LastName { get; }
        public int Age { get; }
    }
    public struct PersonStruct_V8
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public readonly string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public record struct PersonStruct_V10(int Id, string FirstName, string LastName, int Age);
}
