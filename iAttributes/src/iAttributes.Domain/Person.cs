using System.Diagnostics;

namespace iAttributes.Domain;

[DebuggerDisplay("Person Name is: {FirstName} {LastName} and Age is: {Age}")]
[DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
public class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
