using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace iWPF_S01
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

        private void txtAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int age;
            if (int.TryParse(e.Text, out age) == false)
            {
                e.Handled = true;
            }
        }

        public string PersianDate(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime thisDate = dt;
            string date = string.Format("{0}/{1}/{2}",
                          pc.GetYear(thisDate),
                          pc.GetMonth(thisDate),
                          pc.GetDayOfMonth(thisDate));
            return date;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dpDate.Text = PersianDate((DateTime)dpDate.SelectedDate);
        }
    }
}
