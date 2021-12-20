namespace iEFCore.Fundamentals
{
    public interface IPersonRepository
    {
        void Create(Person person);
        void Update(Person person);
        void UpdateById(int id);
        void Delete(Person person);
        void DeleteById(int id);
        Person Get(Person person);
        Person GetById(int id);
        List<Person> GetAll();
    }
}
