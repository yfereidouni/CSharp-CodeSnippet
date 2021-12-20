using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Fundamentals.DAL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDb personDb= new PersonDb ();

        public void Create(Person person)
        {
            personDb.People.Add(person);
            personDb.SaveChanges();
        }
        
        public void Update(Person person)
        {
            personDb.People.Update(person);
            personDb.SaveChanges();
        }

        public void UpdateById(int id)
        {
            var person = personDb.People.Find(id);
            personDb.People.Update(person);
            personDb.SaveChanges();
        }

        public void Delete(Person person)
        {
            personDb.People.Remove(person);
            personDb.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var person = personDb.People.Find(id);
            if (person != null)
            {
                personDb.People.Remove(person);
                personDb.SaveChanges();
            }
        }

        public Person Get(Person person)
        {
            var result = personDb.People.Find(person);
            return result;
        }
        
        public Person GetById(int id)
        {
            var person = personDb.People.Find(id);
            return person;
        }
        
        public List<Person> GetAll()
        {
            return personDb.People.ToList();
        }

    }
}
