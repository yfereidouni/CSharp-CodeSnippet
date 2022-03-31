using System;
using System.Collections.Generic;
using System.Linq;

namespace iLINQ.LinqToObjectsAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager universityManager = new UniversityManager();
            universityManager.MaleStudents();
            universityManager.FemaleStudents();
            universityManager.SortStudentsByAge();
            universityManager.AllStudentsFromBeijingTech();


            Console.Write("Enter code (1 : Beijing Tech or 2 : ");
            if (int.TryParse(Console.ReadLine(), out int res))
                universityManager.AllStudentsFromBeijingTech(res);


            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reveresedInts = sortedInts.Reverse();
            foreach (int i in reveresedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            universityManager.StudentAndUniversityNameCollection();

        }
    }


    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Jack", Gender = "male", Age = 27, UniversityId = 1 });

        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "male"
                                                select student;
            Console.WriteLine("Male Students:");
            foreach (var item in maleStudents)
            {
                item.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students
                                                  where student.Gender == "female"
                                                  select student;
            Console.WriteLine("Female Students:");
            foreach (var item in femaleStudents)
            {
                item.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var SortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Sorted Student by Age:");
            foreach (var item in SortedStudents)
            {
                item.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from Beijing Tech:");
            foreach (var item in bjtStudents)
            {
                item.Print();
            }
        }

        public void AllStudentsFromBeijingTech(int universityId)
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == universityId
                                               select student;
            string universityName = string.Empty;
            universityName = universityId == 1 ? "Yale" : "Beijing Tech";
            Console.WriteLine("Students from {0}:", universityName);
            foreach (var item in bjtStudents)
            {
                item.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection:");
            foreach (var item in newCollection)
            {
                Console.WriteLine("Student {0} From University {1}", item.StudentName, item.UniversityName);
            }
        }
    }

    class STUNI
    {
        public string StudentName { get; set; }
        public string UniversityName { get; set; }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with Id {1}", this.Name, this.Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foregin Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} " +
                "and Age {3} from University with Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
