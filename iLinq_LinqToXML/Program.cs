using System;
using System.Linq;
using System.Xml.Linq;


namespace iLinq_LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                @"<Students>
                        <Student>
                            <Name>Toni</Name>
                            <Age>21</Age>
                            <University>Yale</University>
                            <Semester>6</Semester>
                        </Student>
                        <Student>
                            <Name>Carla</Name>
                            <Age>17</Age>
                            <University>Yale</University>
                            <Semester>1</Semester>
                        </Student>
                        <Student>
                            <Name>Toni</Name>
                            <Age>19</Age>
                            <University>Beijing Tech</University>
                            <Semester>3</Semester>
                        </Student>                        
                        <Student>
                            <Name>Frank</Name>
                            <Age>25</Age>
                            <University>Beijing Tech</University>
                            <Semester>10</Semester>
                        </Student>
                </Students>";

            XDocument studentXdoc = new XDocument();
            studentXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentXdoc.Descendants("Student")
                               //orderby student.Element("Age").Value
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach (var item in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} Semester {3}", item.Name, item.Age, item.University, item.Semester);
            }

            //----------------------------------------------------------------------------------------------------------

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;
            Console.WriteLine("\n\nSort Students by Age:");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} Semester {3}", item.Name, item.Age, item.University, item.Semester);
            }

        }
    }
}
