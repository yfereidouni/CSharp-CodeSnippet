using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLINQ.LinqSample;

public class LinqOperators
{
    public void PrintNameWithoutLinq()
    {
        List<string> names = new List<string>
        {
            "Yasser Fereidouni",
            "Shervin Souri",
            "Hamid Saberi",
            "Mohammad Lotfi",
            "Farid Taheri",
            "Abbas Masoumi",
            "Alireza Oroumand",
            "Arash Azhdari",
            "Hashem Yeganeh"
        };

        List<string> result = new List<string>();

        foreach (var name in names)
        {
            if (name.StartsWith("A"))
            {
                result.Add(name);
            }
        }
        result.Sort();

        Console.WriteLine("Print Name Without Linq: ");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------\r\n");
    }

    public void PrintNameWithLinqQuery()
    {
        List<string> names = new List<string>
        {
            "Yasser Fereidouni",
            "Shervin Souri",
            "Hamid Saberi",
            "Mohammad Lotfi",
            "Farid Taheri",
            "Abbas Masoumi",
            "Alireza Oroumand",
            "Arash Azhdari",
            "Hashem Yeganeh"
        };

        var result = from name in names
                     where name.StartsWith("A")
                     orderby name
                     select name;

        Console.WriteLine("Print Name With Linq Query: ");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------\r\n");
    }

    public void PrintNameWithLinqMethod()
    {
        List<string> names = new List<string>
        {
            "Yasser Fereidouni",
            "Shervin Souri",
            "Hamid Saberi",
            "Mohammad Lotfi",
            "Farid Taheri",
            "Abbas Masoumi",
            "Alireza Oroumand",
            "Arash Azhdari",
            "Hashem Yeganeh"
        };

        var result = names.Where(c => c.StartsWith("A"))
            .OrderBy(c => c)
            .Select(c => c)
            .ToList();

        Console.WriteLine("Print Name With Linq Mathod: ");
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------\r\n");
    }

    public void PrintNumbersDiferred()
    {
        List<int> Numbers = new List<int> { 1, 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        
        //The query is not exexute here
        var lessThan10 = from num in Numbers
                         where num < 10
                         orderby num
                         select num;


        Console.Write("Less Than 10: ");
        foreach (var item in lessThan10) //The query execute here
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("");

        Numbers.Add(3);
        Numbers.Add(5);

        Console.Write("Less Than 10: ");
        foreach (var item in lessThan10) //The query execute here
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\r\n--------------------------\r\n");


    }

    public void PrintNumbersImmediate()
    {
        List<int> Numbers = new List<int> { 1, 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        //Because of .ToList() The query is exexute here
        var lessThan10 = (from num in Numbers
                         where num < 10
                         orderby num
                         select num).ToList();


        Console.Write("Less Than 10: ");
        foreach (var item in lessThan10) 
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("");

        Numbers.Add(3);
        Numbers.Add(5);

        Console.Write("Less Than 10: ");
        foreach (var item in lessThan10) 
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\r\n--------------------------\r\n");


    }

    public void FilterStudentsQuery()
    {
        var students = Student.GetStudents();

        var result = (from s in students where s.Grade > 15 select s).ToList();

        Student.PrintStudents(result);
    }
    
    public void FilterStudentsMethod()
    {
        var students = Student.GetStudents();

        var result = students.Where((s,index) => s.Grade > 15 || s.Grade >index).ToList();    

        Student.PrintStudents(result);
    }

    public void FilterByType()
    {
        List<Object> list = new List<Object> { 1, 2, "Alireza", "Hossein", false, 123 };

        // We want only numeric values
        var numbers = list.OfType<int>().ToList();

        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\r\n-----------------------");
    }

    public void SortStudents()
    {
        var students = Student.GetStudents().ToList();
        var sortedStudent = students.OrderBy(c => c.FirstName).ToList();
        Student.PrintStudents(sortedStudent);
    }

    public void SortDescStudents()
    {
        var students = Student.GetStudents().ToList();
        var sortedStudent = students.OrderByDescending(c => c.FirstName).ToList();
        Student.PrintStudents(sortedStudent);
    }

    public void SortGradeAndNameStudents()
    {
        var students = Student.GetStudents().ToList();
        var sortedStudent = students.OrderBy(c => c.Grade).ThenBy(c=>c.FirstName).ToList();
        Student.PrintStudents(sortedStudent);
    }
}
