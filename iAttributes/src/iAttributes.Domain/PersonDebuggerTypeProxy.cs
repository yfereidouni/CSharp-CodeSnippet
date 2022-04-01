namespace iAttributes.Domain;

public class PersonDebuggerTypeProxy
{
    private readonly Person person;

    public PersonDebuggerTypeProxy(Person person)
    {
        this.person = person;
    }
    public string FullName => $"{person.FirstName}, {person.LastName}";
    public int Age => person.Age;
}
