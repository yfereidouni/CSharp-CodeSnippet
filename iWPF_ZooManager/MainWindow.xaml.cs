using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace iWPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["iWPF_ZooManager.Properties.Settings.WWDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            //sqlConnection = new SqlConnection("Data Source=192.168.1.106;Initial Catalog=WWDB;Persist Security Info=True;User ID=sa;Password=Develop2011~");

            ShowZoos();
        }

        private void ShowZoos()
        {
            try
            {
                string query = "SELECT * FROM Zoo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    listZoos.DisplayMemberPath = "Location";
                    listZoos.SelectedValuePath = "Id";
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal a inner join ZooAnimal za " +
                               "on a.Id = za.AnimalId where za.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
        }


    }
}
