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

namespace iWPF_S04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int PersonId { get; set; }
        List<Entities.Person> PersonList = new List<Entities.Person>();

        public MainWindow()
        {
            InitializeComponent();
            PersonId = 0;
        }

        private void ButtonLoadData_Click(object sender, RoutedEventArgs e)
        {
            //Method 1 : Add data record by record in DataGrid
            //Entities.Person person1 = new Entities.Person() { Id = GetId(), FirstName = "Yasser", LastName = "Fereidouni", Age = 36, BirthDate = DateTime.Now, Address = "Karaj" };
            //dgvStudents.Items.Add(person1);

            //Method 2 : ItemsSource
            PersonInstances();
            dgvStudents.ItemsSource = PersonList;
        }

        private void PersonInstances()
        {
            Entities.Person person1 = new Entities.Person() { Id = GetId(), FirstName = "Yasser", LastName = "Fereidouni", Age = 36, BirthDate = new DateTime(1985, 03, 30), Address = "Karaj" };
            Entities.Person person2 = new Entities.Person() { Id = GetId(), FirstName = "Navid", LastName = "Bahrami", Age = 36, BirthDate = new DateTime(1985, 03, 30), Address = "Karaj" };
            Entities.Person person3 = new Entities.Person() { Id = GetId(), FirstName = "Kamran", LastName = "Zarifi", Age = 36, BirthDate = new DateTime(1985, 03, 30), Address = "Karaj" };
            PersonList.Add(person1);
            PersonList.Add(person2);
            PersonList.Add(person3);
        }

        private int GetId()
        {
            PersonId += 1;
            return PersonId;
        }

        private void ButtonStep2_Click(object sender, RoutedEventArgs e)
        {
            tcStages.SelectedIndex = tcStages.SelectedIndex + 1;
            lvPersons.ItemsSource = PersonList;
        }

        private void ButtonStep3_Click(object sender, RoutedEventArgs e)
        {
            tcStages.SelectedIndex = tcStages.SelectedIndex + 1;
        }

        private void ButtonStep4_Click(object sender, RoutedEventArgs e)
        {
            tcStages.SelectedIndex = tcStages.SelectedIndex + 1;
        }
        private void ButtonStep5_Click(object sender, RoutedEventArgs e)
        {
            tcStages.SelectedIndex = tcStages.SelectedIndex + 1;
        }

        private void ButtonEnd_Click(object sender, RoutedEventArgs e)
        {
            TabItem tbItem = new TabItem();
            tbItem.Header = "پایان";
            tbItem.Content = "اتمام مراحل ثبت پرسنل";
            tcStages.SelectedIndex = tcStages.SelectedIndex + 1;
            tcStages.Items.Add(tbItem);
        }

    }
}
