using iLINQ.ReadFromFile;
using System.Linq;

// Without LINQ ------------------------------------------------------------------------------
Console.WriteLine("\r\nWithout LINQ : ");
var lines = System.IO.File.ReadAllLines("People.txt");
List<Person> people = new List<Person>();
foreach (var item in lines)
{
    var result = item.Split(",");
    Person person = new Person
    {
        Id = int.Parse(result[0]),
        FirstName = result[1],
        LastName = result[2],
        Birthdate = DateTime.Parse(result[3])
    };
    people.Add(person);
}

foreach (var item in people)
{
    Console.WriteLine(item.ToString());
}
// With LINQ ----------------------------------------------------------------------------------
Console.WriteLine("\r\nLINQ : ");
List<Person> Students = System.IO.File.ReadAllLines("People.txt").Select(c =>
{
    var data = c.Split(",");
    return new Person
    {
        Id = int.Parse(data[0]),
        FirstName = data[1],
        LastName = data[2],
        Birthdate = DateTime.Parse(data[3])
    };

}).ToList();

foreach (var item in Students)
{
    Console.WriteLine(item.ToString());
}

