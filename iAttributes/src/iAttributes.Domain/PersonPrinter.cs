using System.Diagnostics;
using System.Reflection;

namespace iAttributes.Domain;

public class PersonPrinter
{
    private readonly Person person;

    public PersonPrinter(Person person)
    {
        this.person = person;
    }

    public void Print()
    {
        ConditionalForDebugOrReleaseMode();
        ShowDeveloperName();

        PrintFullName();
        PrintAge();
    }

    [Conditional("YFereidouni")]
    private void ShowDeveloperName()
    {
        Console.WriteLine("Conditional => Developer is: YFereidouni");
    }

    [Conditional("DEBUG")]
    private void ConditionalForDebugOrReleaseMode()
    {
        Console.WriteLine("Conditional => The application runs on DEBUG mode.");
    }

    private void PrintFullName()
    {
        Console.WriteLine($"FullName: {this.person.FirstName} {this.person.LastName}");
    }

    [Obsolete(message: "PrintAge() was OBSOLETED. by Yasser", error: false)]
    public void PrintAge()
    {
        Console.WriteLine($"Age: {this.person.Age}");
    }

}
