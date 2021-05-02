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

namespace iWPF_CheckBox
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

        private void cbAllTopings_Changed(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllTopings.IsChecked == true);
            cbSalami.IsChecked = newVal;
            cbMashrooms.IsChecked = newVal;
            cbMozzarella.IsChecked = newVal;
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if ((cbSalami.IsChecked == true) && (cbMashrooms.IsChecked == true) && (cbMozzarella.IsChecked == true))
            {
                cbAllTopings.IsChecked = true;
            }
            if ((cbSalami.IsChecked == false) && (cbMashrooms.IsChecked == false) && (cbMozzarella.IsChecked == false))
            {
                cbAllTopings.IsChecked = false;
            }
        }
    }
}
