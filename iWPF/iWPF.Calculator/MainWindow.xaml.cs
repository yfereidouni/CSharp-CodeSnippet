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

namespace iWPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.Topmost = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Show(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking me.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct Event");
        }

        private void Button_Mouseup(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bubbling Event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tunneling Event");
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Stackpanel clicked";
        }
    }
}
