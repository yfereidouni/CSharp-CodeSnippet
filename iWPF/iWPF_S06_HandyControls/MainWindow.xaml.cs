using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace iWPF_S06_LINQ_To_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            Definitions.ucCustomer customer = new Definitions.ucCustomer(dkpMain);
            dkpMain.Children.Clear();
            dkpMain.Children.Add(customer);
        }

        private void MenuItemReportAllCustomers_Click(object sender, RoutedEventArgs e)
        {
            Definitions.usAllCustomers allcustomers = new Definitions.usAllCustomers(dkpMain);
            dkpMain.Children.Clear();
            dkpMain.Children.Add(allcustomers);
        }
    }
}
