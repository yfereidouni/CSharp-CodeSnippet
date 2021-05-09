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
using System.Windows.Shapes;

namespace iWPF_S06_LINQ_To_SQL.Definitions
{
    /// <summary>
    /// Interaction logic for winCustomer.xaml
    /// </summary>
    public partial class winCustomer : Window
    {
        public int CustomerID = 0;
        public winCustomer(int _customerId)
        {
            InitializeComponent();
            CustomerID = _customerId;

            var customer = Database.ClassStatic.dbContext.Customers.Where(q => q.Id == CustomerID).FirstOrDefault();

            txtAddress.Text = customer.Address;
            txtDescription.Text = customer.Description;
            txtEmail.Text = customer.Email;
            txtName.Text = customer.Name;
            txtNCode.Text = customer.NationalCode;
            txtTel.Text = customer.Tel;
            dpBirthDate.SelectedDate = customer.BirthDate;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            new Database.Edition().EditCustomer(CustomerID, txtName.Text, txtTel.Text, txtEmail.Text, txtAddress.Text, txtNCode.Text, dpBirthDate.SelectedDate, txtDescription.Text);
            MessageBox.Show("ویرایش انجام شد");
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
