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
    /// Interaction logic for ucCustomer.xaml
    /// </summary>
    public partial class ucCustomer : UserControl
    {
        DockPanel dkp = new DockPanel();

        List<Database.Phone> lstPhones = new List<Database.Phone>();

        public ucCustomer(DockPanel _dkp)
        {
            InitializeComponent();
            dkp = _dkp;
        }

        private void btnSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            new Database.Edition().SaveCustomer(txtName.Text, txtTel.Text, txtEmail.Text, txtAddress.Text, txtNCode.Text, dpBirthDate.SelectedDate, txtDescription.Text, lstPhones);
            MessageBox.Show("ثبت شد");
            txtName.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtNCode.Text = "";
            dpBirthDate.Text = "";
            txtDescription.Text = "";
            
            txtTitle.Text = "";
            txtphoneNumber.Text = "";
            lsvPhones.ItemsSource = null;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            dkp.Children.Remove(this);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lstPhones.Add(new Database.Phone() { Title = txtTitle.Text, PhoneNumber = txtphoneNumber.Text });
            lsvPhones.ItemsSource = null;
            lsvPhones.ItemsSource = lstPhones;
        }
    }
}
