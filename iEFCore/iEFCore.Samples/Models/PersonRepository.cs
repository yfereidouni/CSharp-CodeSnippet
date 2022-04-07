using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Samples.Models
{
    public class PersonRepository
    {
        public void AddPerson(string firstName, string lastName)
        {
            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName
            };
            EFSamplesDbContext dbContext = new EFSamplesDbContext();
            dbContext.Add(person);
            dbContext.SaveChanges();
            Console.WriteLine("Person was saved!");
        }
        public void UpdatePerson(int id, string firstName, string lastName)
        {
            EFSamplesDbContext dbContext = new EFSamplesDbContext();
            Person person = dbContext.People.Find(id);
            if (person != null)
            {
                person.FirstName = firstName;
                person.LastName = lastName;
                dbContext.SaveChanges();
                Console.WriteLine("Person was updated!");
            }
        }

        public void PrintPeople()
        {
            EFSamplesDbContext dbContext = new EFSamplesDbContext();
            var people = dbContext.People.AsNoTracking().ToList();
            foreach (Person person in people)
            {
                Console.WriteLine($"Id: {person.Id}\t{person.FirstName}\t{person.LastName}");
            }
        }

        public void DeletePerson(int id)
        {
            EFSamplesDbContext dbContext = new EFSamplesDbContext();
            Person person = dbContext.People.Find(id);
            if (person != null)
            {
                dbContext.People.Remove(person);
                dbContext.SaveChanges();
                Console.WriteLine("Person was deleted!");
            }
            else { Console.WriteLine("Person was not found!"); }
        }
    }
}
