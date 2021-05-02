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

namespace iWPF_RadioButtons_and_Images
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

        private void Yes_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please say Yes");
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No Checked");

        }

        private void Maybe_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Maybe Checked");

        }
    }
}
