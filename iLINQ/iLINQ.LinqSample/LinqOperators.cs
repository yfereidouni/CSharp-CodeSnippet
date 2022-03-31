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

        var result = students.Where((s, index) => s.Grade > 15 || s.Grade > index).ToList();

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
        var sortedStudent = students.OrderBy(c => c.Grade).ThenBy(c => c.FirstName).ToList();
        Student.PrintStudents(sortedStudent);
    }

    public void GroupStudents()
    {
        var students = Student.GetStudents().ToList();

        var groupByGrade = students.GroupBy(c => c.Grade);

        Console.WriteLine("GroupBy:\r\n");
        foreach (var item in groupByGrade)
        {
            Console.WriteLine($"Grades {item.Key} :");
            foreach (var student in item)
            {
                Console.WriteLine($"{student.Id} | {student.FirstName} | {student.LastName}");
            }
            Console.WriteLine("".PadRight(50, '-'));
        }
    }

    public void InnerJoin()
    {
        var students = Student.GetStudents();
        var courses = StudentCourse.GetStudentCourses().ToList();

        var result = students.Join(courses, s => s.Id, c => c.StudentId, (s, c) =>
        new
        {
            StudentId = s.Id,
            CourseId = c.Id,
            s.Id,
            s.FirstName,
            s.LastName,
            c.Name,
            c.Score
        });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.StudentId}: {item.FirstName},{item.LastName}\t {item.Name} = {item.Score}");
        }

    }

    public void GroupJoin()
    {
        var students = Student.GetStudents();
        var courses = StudentCourse.GetStudentCourses().ToList();

        var groupJoin = students.GroupJoin(courses, s => s.Id, c => c.StudentId, (s, c) =>
        new
        {
            s.Id,
            s.FirstName,
            s.LastName,
            StudentCourse = c,
        }).ToList();

        foreach (var item in groupJoin)
        {
            Console.WriteLine($"{item.Id}, {item.FirstName} {item.LastName} {item.StudentCourse.Count()}");

            //foreach (var course in item.StudentCourse)
            //{
            //    Console.WriteLine($"\t{course.Id} | {course.Name} | {course.Score} ");
            //}
        }
    }

    public void LeftJoin()
    {
        var students = Student.GetStudents();
        var courses = StudentCourse.GetStudentCourses().ToList();

        var groupJoin = students.GroupJoin(courses, s => s.Id, c => c.StudentId, (s, c) =>
        new
        {
            s.Id,
            s.FirstName,
            s.LastName,
            StudentCourse = c,
        }).SelectMany(c => c.StudentCourse.DefaultIfEmpty(), (s, c) =>
        {
            return new
            {
                s.Id,
                s.FirstName,
                s.LastName,
                course = c?.Name ?? "---"
            };
        }).ToList();

        foreach (var item in groupJoin)
        {
            Console.WriteLine($"{item.Id}, {item.FirstName} {item.LastName} {item.course}");
        }
    }

    public void Distinct()
    {
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 4, 5, 1 };

        Console.WriteLine("Initial List:");
        foreach (var item in ints)
        {
            Console.Write(item + " ");
        }

        var distinct = ints.Distinct();

        Console.WriteLine("\r\n\r\nDISTINCT List:");
        foreach (var item in distinct)
        {
            Console.Write(item + " ");
        }
    }

    public void Union()
    {
        List<int> int01 = new List<int>() { 1, 2, 3, 4, 5, 4, 5, 1 };
        List<int> int02 = new List<int>() { 4, 5, 6, 7, 8 };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in int01)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in int02)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nUNION of Set01 and Set02:");
        var union = int01.Union(int02);
        foreach (var item in union)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void Except()
    {
        List<int> int01 = new List<int>() { 1, 2, 3, 4, 5, 4, 5, 1 };
        List<int> int02 = new List<int>() { 4, 5, 6, 7, 8 };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in int01)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in int02)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nEXCEPT of Set01 and Set02:");
        var union = int01.Except(int02);
        foreach (var item in union)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void Intersect()
    {
        List<int> int01 = new List<int>() { 1, 2, 3, 4, 5, 4, 5, 1 };
        List<int> int02 = new List<int>() { 4, 5, 6, 7, 8 };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in int01)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in int02)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nINTERSECT of Set01 and Set02:");
        var union = int01.Intersect(int02);
        foreach (var item in union)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void UnionBy()
    {
        List<StudentCourse> sc01 = new List<StudentCourse>()
        {
            new StudentCourse{Id =1},
            new StudentCourse{Id =2},
            new StudentCourse{Id =3},
            new StudentCourse{Id =3},
        };
        List<StudentCourse> sc02 = new List<StudentCourse>()
        {
            new StudentCourse{Id =2},
            new StudentCourse{Id =4},
            new StudentCourse{Id =5},
            new StudentCourse{Id =6},
        };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in sc01)
        {
            Console.Write(item.Id + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in sc02)
        {
            Console.Write(item.Id + " ");
        }

        var unionBy = sc01.UnionBy(sc02, c => c.Id);

        Console.WriteLine("\r\n\r\nUNION-BY of Set01 and Set02:");
        foreach (var item in unionBy)
        {
            Console.Write(item.Id + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void DistinctBy()
    {
        List<StudentCourse> sc01 = new List<StudentCourse>()
        {
            new StudentCourse{Id =1},
            new StudentCourse{Id =2},
            new StudentCourse{Id =3},
            new StudentCourse{Id =3},
        };

        Console.WriteLine("\r\nInitial Set:");
        foreach (var item in sc01)
        {
            Console.Write(item.Id + " ");
        }

        var unionBy = sc01.DistinctBy(c => c.Id);

        Console.WriteLine("\r\n\r\nDISTINCT-BY of Set01 and Set02:");
        foreach (var item in unionBy)
        {
            Console.Write(item.Id + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void IntersectBy()
    {
        List<StudentCourse> sc01 = new List<StudentCourse>()
        {
            new StudentCourse{Id =1},
            new StudentCourse{Id =2},
            new StudentCourse{Id =3},
            new StudentCourse{Id =3},
        };
        List<StudentCourse> sc02 = new List<StudentCourse>()
        {
            new StudentCourse{Id =2},
            new StudentCourse{Id =4},
            new StudentCourse{Id =5},
            new StudentCourse{Id =6},
        };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in sc01)
        {
            Console.Write(item.Id + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in sc02)
        {
            Console.Write(item.Id + " ");
        }

        var unionBy = sc01.IntersectBy(sc02.Select(d => d.Id).ToList(), c => c.Id);

        Console.WriteLine("\r\n\r\nINTERSECT-BY of Set01 and Set02:");
        foreach (var item in unionBy)
        {
            Console.Write(item.Id + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void ExceptBy()
    {
        List<StudentCourse> sc01 = new List<StudentCourse>()
        {
            new StudentCourse{Id =1},
            new StudentCourse{Id =2},
            new StudentCourse{Id =3},
            new StudentCourse{Id =3},
        };
        List<StudentCourse> sc02 = new List<StudentCourse>()
        {
            new StudentCourse{Id =2},
            new StudentCourse{Id =4},
            new StudentCourse{Id =5},
            new StudentCourse{Id =6},
        };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in sc01)
        {
            Console.Write(item.Id + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in sc02)
        {
            Console.Write(item.Id + " ");
        }

        var unionBy = sc01.ExceptBy(sc02.Select(d => d.Id).ToList(), c => c.Id);

        Console.WriteLine("\r\n\r\nUNION-BY of Set01 and Set02:");
        foreach (var item in unionBy)
        {
            Console.Write(item.Id + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void Zip()
    {
        List<int> int01 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> int02 = new List<int>() { 6, 7, 8, 9, 10 };
        List<int> int03 = new List<int>() { 11, 12, 13 };

        Console.WriteLine("\r\nSet01:");
        foreach (var item in int01)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nSet02:");
        foreach (var item in int02)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nSet03:");
        foreach (var item in int02)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nZIP of Set01, Set02, and Set03 :");
        var zip = int01.Zip(int02, int03);
        foreach (var item in zip)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\r\n");
    }

    public void Pagination(int pageNumber = 0, int pageSize = 3)
    {
        List<int> int01 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        var result = int01.Skip(pageNumber * pageSize).Take(pageSize);

        Console.WriteLine($"Items in page {pageNumber}:");
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\r\n");

    }

    public void Chunk(int chunkSize = 3)
    {
        List<int> int01 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        var result = int01.Chunk(chunkSize);

        int chunk = 1;
        Console.WriteLine($"List of Chunks :");

        foreach (var item in result)
        {
            Console.WriteLine($"\r\nChunk: {chunk}");
            foreach (var innerItem in item)
            {
                Console.Write(innerItem + " ");
            }
            Console.WriteLine("\r\n--------------");
            chunk++;
        }
        Console.WriteLine("\r\n");
    }

    public void AggregateFunctions()
    {
        var students = Student.GetStudents();

        var totalCount = students.Count;
        var minValue = students.Min(c => c.Grade);
        var maxValue = students.Max(c => c.Grade);
        var avg = students.Average(c => c.Grade);
        var sum = students.Sum(c => c.Grade);

        Console.WriteLine($"Total Count: {totalCount} | Min Grade: {minValue} | Max Grade: {maxValue} | Average Grade: {avg} | Sum: {sum}");
    }

    public void Generators()
    {
        var numberRange = Enumerable.Range(0, 10).ToList();
        var emptyNumbers = Enumerable.Empty<int>().ToList();
        var repeatNumbers = Enumerable.Repeat<int>(1,10).ToList();


        Console.WriteLine("\r\nRANGE:");
        foreach (var item in numberRange)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nEMPTY:");
        foreach (var item in emptyNumbers)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\r\n\r\nREPEAT:");
        foreach (var item in repeatNumbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\r\n");
    }
}
