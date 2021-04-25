using EFCore.DAL;
using EFCore.Entities;
using System;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ApplicationDatabase())
            {
                Person person = new Person
                {
                    Name = "Yasser",
                    Family = "Fereidouni",
                    BirthDate = DateTime.Now
                };
                person.Contacts.Add(new Contact { 
                    PhoneNumber="09124643426"
                });;

                ctx.Persons.Add(person);
                ctx.SaveChanges();
            }
        }
    }
}

