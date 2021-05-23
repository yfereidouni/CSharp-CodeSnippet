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
            InsertStudents();

        }

        public void InsertUniversityies()
        {
            dataContext.ExecuteCommand("Delete from university");

            University yale = new University { Id = 1, Name = "Yale" };
            dataContext.Universities.InsertOnSubmit(yale);

            University beijingTech = new University { Id = 2, Name = "Beijing Tech" };
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
    }
}
