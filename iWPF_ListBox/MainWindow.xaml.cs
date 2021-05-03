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

namespace iWPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match
            {
                Team1 = "Bayern Munich",
                Team2 = "Real Madrid",
                Score1 = 3,
                Score2 = 2,
                Completion = 85
            });
            matches.Add(new Match
            {
                Team1 = "Barcelona",
                Team2 = "Manchester City",
                Score1 = 5,
                Score2 = 1,
                Completion = 35
            }); matches.Add(new Match
            {
                Team1 = "Liverpool",
                Team2 = "Chelsea",
                Score1 = 2,
                Score2 = 2,
                Completion = 90
            }); matches.Add(new Match
            {
                Team1 = "Esteghlal",
                Team2 = "Perspolis",
                Score1 = 0,
                Score2 = 6,
                Completion = 10
            });
            lbMatches.ItemsSource = matches;
        }

        public class Match
        {
            public int Score1 { get; set; }
            public int Score2 { get; set; }
            public string Team1 { get; set; }
            public string Team2 { get; set; }
            public int Completion { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: \r\n\r\n"
                    + (lbMatches.SelectedItem as Match).Team1 + " " +
                      (lbMatches.SelectedItem as Match).Score1 + " " +
                      (lbMatches.SelectedItem as Match).Score2 + " " +
                      (lbMatches.SelectedItem as Match).Team2, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
