using System.ComponentModel;

namespace iEFCore.S25.E05.EFMigrations;

public class Person
{
    public int Id { get; set; }
    //public string FirstName { get; set; }
    //public string LastName { get; set; }
    public string FullName { get; set; }
}
