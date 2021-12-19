namespace iEFCore.Fundamentals
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        void Add(Person person);
        Person Get(int id);
        Person GetById(int id);
        void Update(Person person);
        void Delete(int id);
    }
}
