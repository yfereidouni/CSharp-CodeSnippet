using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Fundamentals.DAL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonDb personDb;

        public PersonRepository(PersonDb personDb)
        {
            this.personDb = personDb;
        }
        public void Add(Person person)
        {
            personDb.People.Add(person);
            personDb.SaveChanges();
        }

        public void Delete(int id)
        {
            var person = personDb.People.FirstOrDefault(p => p.Id == id);
            personDb.People.Remove(person);
            personDb.SaveChanges();
        }

        public Person Get(int id)
        {
            return personDb.People.FirstOrDefault(c => c.Id == id);
        }

        public List<Person> GetAll()
        {
            return personDb.People.ToList();
        }

        public Person GetById(int id)
        {
            return (personDb.People.FirstOrDefault(c => c.Id == id));
        }

        public void Update(Person person)
        {
            personDb.People.Update(person);
            personDb.SaveChanges(true);

        }
    }
}
