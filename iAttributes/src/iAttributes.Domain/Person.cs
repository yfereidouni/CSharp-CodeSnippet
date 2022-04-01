using iAttributes.CustomAttributes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace iAttributes.Domain;

[DebuggerDisplay("Person Name is: {FirstName} {LastName} and Age is: {Age}")]
[DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
[Serializable]
[CodeChangeHistory("Yasser Fereidouni", isBug: false, Description = "Add New Property with name...")]
[CodeChangeHistory("Yasser Fereidouni", isBug: true, Description = "Please Fix the Bug")]

public class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
    public string FirstName { get; set; } = "Yasser";
    [Required]
    [CodeChangeHistory("Yasser Fereidouni", isBug: false, Description = "Use Attribute for your properties")]
    public string LastName { get; set; } = "Fereidouni";
    public int Age { get; set; }

    public void Print()
    {
        Console.WriteLine($"{this.FirstName} {this.LastName}");
    }

    public void InputPrint(string message)
    {
        Console.WriteLine($"{this.FirstName} {this.LastName} --- {message}");
    }
}
