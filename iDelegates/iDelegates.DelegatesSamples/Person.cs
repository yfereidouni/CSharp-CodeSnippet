using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iDelegates.DelegatesSamples;

public delegate string PersonToString(Person person);

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

public static class PersonFullName
{
    public static string GetPersonFullName(Person person) =>
        $"{person.FirstName} {person.LastName}";
}

public static class PersonFullNameReverse
{
    public static string GetPersonFullName(Person person) =>
        $"{person.LastName} {person.FirstName}";
}