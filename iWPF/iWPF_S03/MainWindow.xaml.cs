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

namespace iWPF_S03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Id { get; set; }
        List<Category> categories = new List<Category>();
        public MainWindow()
        {
            InitializeComponent();
            Id = 0;
            categories.Add(new Category { Id = 1, Title = "C#" });
            categories.Add(new Category { Id = 2, Title = "ASP.NET" });
            categories.Add(new Category { Id = 3, Title = "EF Core" });
            categories.Add(new Category { Id = 4, Title = "WPF" });
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(rtbDescription.Document.ContentStart, rtbDescription.Document.ContentEnd);
            MessageBox.Show(tr.Text);
        }

        private void btnComboItemDisplay_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbitem = cmbCategories.SelectedItem as ComboBoxItem;
            if (cmbCategories.SelectedItem != null)
            {
                MessageBox.Show(cbitem.Tag + " - " + cbitem.Content.ToString());
            }
        }

        private void btnComboItemGet_Click(object sender, RoutedEventArgs e)
        {
            if (cmbCategories.Items.Count <= 0)
            {
                foreach (var item in categories)
                {
                    ComboBoxItem cbitem = new ComboBoxItem();
                    cbitem.Tag = item.Id;
                    cbitem.Content = item.Title;
                    cmbCategories.Items.Add(cbitem);
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            lstMyList.Items.Add(new Button() { Content = GetID() });
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstMyList.SelectedIndex >= 0)
                lstMyList.Items.Remove(lstMyList.Items[lstMyList.SelectedIndex]);
        }

        public int GetID()
        {
            Id = ++Id;
            return Id;
        }

    }
}
