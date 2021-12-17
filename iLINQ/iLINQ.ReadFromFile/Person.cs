using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLINQ.ReadFromFile
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public override string ToString()
        {
            //return $"{Id} |\t{FirstName} |\t{LastName} |\t{Birthdate}";
            return $"{Id}".PadRight(8, ' ')+
                   $" | {FirstName}".PadRight(15, ' ')+
                   $" | {LastName}".PadRight(15, ' ')+
                   $" | {Birthdate}".PadRight(20, ' ');
        }
    }

}
