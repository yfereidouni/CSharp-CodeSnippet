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
            //InsertStudentLectureAssociations();
            //GetUniversityOfToni();
            //GetLecturesOfToni();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransGenders();
            //GetAllLecturesFromBeijingTech();
            //UpdateToni();
            DeleteJame();

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
                dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "JavaScript" });
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
            dataContext.ExecuteCommand("Delete from StudentLecture");

            Student carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            Student leyla = dataContext.Students.First(st => st.Name.Equals("Leyla"));
            Student jame = dataContext.Students.First(st => st.Name.Equals("Jame"));

            Lecture csharp = dataContext.Lectures.First(lc => lc.Name.Equals("C#"));
            Lecture javascript = dataContext.Lectures.First(lc => lc.Name.Equals("JavaScript"));
            Lecture html = dataContext.Lectures.First(lc => lc.Name.Equals("HTML"));
            Lecture css = dataContext.Lectures.First(lc => lc.Name.Equals("CSS"));


            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = carla, Lecture = csharp });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = carla, Lecture = javascript });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = toni, Lecture = css });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = jame, Lecture = html });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = leyla, Lecture = javascript });

            //------- OR ---------------------------------------------------------------------------
            //List<StudentLecture> studentsLectures = new List<StudentLecture>();
            //studentsLectures.Add(new StudentLecture { Student = carla, Lecture = csharp });
            //studentsLectures.Add(new StudentLecture { Student = carla, Lecture = javascript });
            //studentsLectures.Add(new StudentLecture { Student = toni, Lecture = css });
            //studentsLectures.Add(new StudentLecture { Student = jame, Lecture = html });
            //studentsLectures.Add(new StudentLecture { Student = leyla, Lecture = javascript });
            //dataContext.StudentLectures.InsertAllOnSubmit(studentsLectures);
            //-------------------------------------------------------------------------------------


            dataContext.SubmitChanges();
            
            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Contains("Toni"));
            University toniUniversity = Toni.University;

            List<University> universities = new List<University>();
            universities.Add(toniUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesOfToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Contains("Toni"));

            //var studentLectures = dataContext.StudentLectures.Where(lc => lc.Student == Toni);
            //Or-----------------------------------------------------------------------------------
            var studentLectures = from sl in Toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = studentLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from students in dataContext.Students
                                   where students.University.Name == "Yale"
                                   select students;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransGenders()
        {
            var transGenderUniversities = from students in dataContext.Students
                                          join university in dataContext.Universities
                                          on students.University equals university
                                          where students.Gender == "trans-gender"
                                          select university;

            MainDataGrid.ItemsSource = transGenderUniversities;

        }

        public void GetAllLecturesFromBeijingTech()
        {
            var lecturesFromBeijingTech = from sl in dataContext.StudentLectures
                                          join students in dataContext.Students
                                          on sl.StudentId equals students.Srl
                                          where students.University.Name == "Beijing Tech"
                                          select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromBeijingTech;

        }

        public void UpdateToni()
        {
            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name == "Toni");
            Toni.Name = "Toni";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteJame()
        {
            Student jame = dataContext.Students.FirstOrDefault(st => st.Name == "Jame");
            dataContext.Students.DeleteOnSubmit(jame);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
