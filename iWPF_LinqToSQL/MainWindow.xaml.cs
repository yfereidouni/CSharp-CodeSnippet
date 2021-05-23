using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace iWPF_LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["iWPF_LinqToSQL.Properties.Settings.WWDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversityies();
            //InsertStudents();
            //InsertLectures();
            InsertStudentLectureAssociations();

        }

        public void InsertUniversityies()
        {
            dataContext.ExecuteCommand("Delete from university");

            University yale = new University { Name = "Yale" };
            dataContext.Universities.InsertOnSubmit(yale);

            University beijingTech = new University { Name = "Beijing Tech" };
            dataContext.Universities.InsertOnSubmit(beijingTech);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            //dataContext.ExecuteCommand("Delete from student");
            try
            {
                University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
                University beijingTech = dataContext.Universities.First(un => un.Name.Equals("Beijing Tech"));

                List<Student> students = new List<Student>();

                students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
                students.Add(new Student { Name = "Toni", Gender = "Male", University = yale });
                students.Add(new Student { Name = "Leyla", Gender = "Female", University = beijingTech });
                students.Add(new Student { Name = "Jame", Gender = "trans-gender", UniversityId = beijingTech.Id });

                dataContext.Students.InsertAllOnSubmit(students);
                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Students;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        public void InsertLectures()
        {
            try
            {
               dataContext.ExecuteCommand("Delete from lecture");

                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "C#" });
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "JavaScrip" });
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "HTML" });
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "CSS" });

                dataContext.SubmitChanges();

                MainDataGrid.ItemsSource = dataContext.Lectures;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertStudentLectureAssociations()
        {
            //dataContext.ExecuteCommand("Delete from StudentLecture");

            Student carla = dataContext.Students.First(st1 => st1.Name.Equals("Carla"));
            //Student toni = dataContext.Students.First(st2 => st2.Name.Equals("Toni"));
            //Student leyla = dataContext.Students.First(st3 => st3.Name.Equals("Leyla"));
            //Student jame = dataContext.Students.First(st4 => st4.Name.Equals("Jame"));

            Lecture csharp = dataContext.Lectures.First(l => l.Name.Equals("C#"));
            //Lecture javascript = dataContext.Lectures.First(l => l.Name.Equals("JavaScript"));
            //Lecture html = dataContext.Lectures.First(l => l.Name.Equals("HTML"));
            //Lecture css = dataContext.Lectures.First(l => l.Name.Equals("CSS"));


            List<StudentLecture> studentsLectures = new List<StudentLecture>();

            studentsLectures.Add(new StudentLecture { Student = carla, Lecture = csharp });
            //studentsLectures.Add(new StudentLecture { Student = carla, Lecture = javascript });
            //studentsLectures.Add(new StudentLecture { Student = toni, Lecture = css });
            //studentsLectures.Add(new StudentLecture { Student = jame, Lecture = html });
            //studentsLectures.Add(new StudentLecture { Student = leyla, Lecture = javascript });

            dataContext.StudentLectures.InsertAllOnSubmit(studentsLectures);
            dataContext.SubmitChanges();
            
            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }
    }
}
