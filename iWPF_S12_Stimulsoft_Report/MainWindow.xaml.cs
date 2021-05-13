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

namespace iWPF_S12_Stimulsoft_Report
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadPerson();
        }

        public void LoadPerson()
        {
            List<ReportPerson> reportPeople = new List<ReportPerson>();
            reportPeople.Add(new ReportPerson("یاسر", "فریدونی", 36, "09123546352", "No Comment", 2000000));
            reportPeople.Add(new ReportPerson("کریم", "باقری", 62, "09123546352", "No Comment", 1840000));
            reportPeople.Add(new ReportPerson("ایمان", "محمدی", 21, "09123546352", "No Comment", 4320000));
            reportPeople.Add(new ReportPerson("رحمان", "فضلی", 75, "09123546352", "No Comment", 9801000));
            reportPeople.Add(new ReportPerson("مجید", "درویشی", 15, "09123546352", "No Comment", 2100000));
            grdPerson.ItemsSource = reportPeople;
        }

        private void grdPerson_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            (e.Row.Item as ReportPerson).Row = e.Row.GetIndex() + 1;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var lstperson = grdPerson.ItemsSource as List<ReportPerson>;
            Stimulsoft.Report.StiReport sti = new Stimulsoft.Report.StiReport();
            sti.Load(Environment.CurrentDirectory + "\\Report.mrt");
            sti.RegBusinessObject("Person", lstperson);
            sti.Show();
        }
    }
}
