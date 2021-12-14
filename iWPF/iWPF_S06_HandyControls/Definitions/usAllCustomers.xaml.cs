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

namespace iWPF_S06_LINQ_To_SQL.Definitions
{
    /// <summary>
    /// Interaction logic for usAllCustomers.xaml
    /// </summary>
    public partial class usAllCustomers : UserControl
    {
        List<Customer> _customers = new List<Customer>();

        DockPanel dkp = new DockPanel();
        public usAllCustomers(DockPanel _dkp)
        {
            InitializeComponent();
            dkp = _dkp;

            Customer c1 = new Customer() { Id = 1, Name = "Yasser", Email = "Yasser@gmail.com", Tel = "09124643426", Address = "Karaj", BirthDate = DateTime.Now };
            Customer c2 = new Customer() { Id = 2, Name = "Majid", Email = "majid@gmail.com", Tel = "09121234566", Address = "Karaj", BirthDate = DateTime.Now };
            _customers.Add(c1);
            _customers.Add(c1);

        }

        public void LoadCustomer()
        {
            lvPersons.ItemsSource = _customers;
        }
    }
}
