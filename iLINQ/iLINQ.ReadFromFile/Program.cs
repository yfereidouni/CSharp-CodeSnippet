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
    Console.WriteLine(item.ToString());

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
    Console.WriteLine(item.ToString());

// Another LINQ Query 1 ------------------------------------------------------------------------
Console.WriteLine("\r\nAnother LINQ Query 1 : ");

var resultDateTime1 = Students.Select(c => c.Birthdate);//.ToList();
// Equal with : 
//var resultDateTime2 = Students.Select(c => { return c.Birthdate; });//.ToList();

foreach (var item in resultDateTime1)
    Console.WriteLine(item);


// Another LINQ Query 2 ------------------------------------------------------------------------
Console.WriteLine("\r\nAnother LINQ Query 2 : ");

var result2 = Students.Where(c => c.Birthdate < new DateTime(1973, 01, 01));
// Equal with:
// var result3 = Students.Where(c => { return c.Birthdate < new DateTime(1973, 01, 01); });

foreach (var item in result2)
    Console.WriteLine(item);