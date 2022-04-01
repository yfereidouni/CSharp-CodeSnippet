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
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public string FirstName { get; set; }
    [Required]
    [CodeChangeHistory("Yasser Fereidouni", isBug: false, Description = "Use Attribute for your properties")]
    public string LastName { get; set; }
    public int Age { get; set; }
}
