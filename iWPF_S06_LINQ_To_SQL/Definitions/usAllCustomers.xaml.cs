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
    /// Interaction logic for usAllCustomers.xaml
    /// </summary>
    public partial class usAllCustomers : UserControl
    {
        //Creating Generic List from "Customer Table" in LinqToSQL
        List<Database.Customer> InnerList = new List<Database.Customer>();

        DockPanel dkp = new DockPanel();
        public usAllCustomers(DockPanel _dkp)
        {
            InitializeComponent();
            dkp = _dkp;
            LoadCustomer();
            Search();
        }

        public void LoadCustomer()
        {
            //Optimized
            InnerList = Database.ClassStatic.dbContext.Customers.ToList();

            #region Linq Syntax
            //int rows = 0;
            //var InnerList = from c in Database.ClassStatic.dbContext.Customers.ToList()
            //                select new Customer()
            //                {
            //                    Id = c.Id,
            //                    Name = c.Name,
            //                    Tel = c.Tel,
            //                    BirthDate = (DateTime)c.BirthDate,
            //                    Email = c.Email,
            //                    Address = c.Address,
            //                    Description = c.Description,
            //                    Row = rows += 1
            //                };
            //lsvCustomer.ItemsSource = InnerList;
            #endregion

            #region Linq with Lambda Expression
            //var lstCustomer2 = Database.ClassStatic.dbContext.Customers.Where(c => c.Name.Contains(""));
            //lsvCustomer.ItemsSource = lstCustomer2;
            #endregion
        }

        public void Search()
        {
            int rows = 0;

            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                var lstCustomer = from c in InnerList
                                  where c.Name.Contains(txtSearch.Text) || c.NationalCode.Contains(txtSearch.Text) ||
                                         c.Tel.Contains(txtSearch.Text) || c.Address.Contains(txtSearch.Text) ||
                                         c.Email.Contains(txtSearch.Text)
                                  select new Customer()
                                  {
                                      Id = c.Id,
                                      Name = c.Name,
                                      Tel = c.Tel,
                                      BirthDate = (DateTime)c.BirthDate,
                                      Email = c.Email,
                                      Address = c.Address,
                                      Description = c.Description,
                                      Row = rows += 1
                                  };
                lsvCustomer.ItemsSource = lstCustomer;
            }
            else
            {
                var lstCustomer = from c in InnerList
                                  select new Customer()
                                {
                                    Id = c.Id,
                                    Name = c.Name,
                                    Tel = c.Tel,
                                    BirthDate = (DateTime)c.BirthDate,
                                    Email = c.Email,
                                    Address = c.Address,
                                    Description = c.Description,
                                    Row = rows += 1
                                };
                lsvCustomer.ItemsSource = lstCustomer;
            }
            
        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }

        private void lsvCustomer_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lsvCustomer.SelectedItem!=null)
            {
                int customerId = (lsvCustomer.SelectedItem as Customer).Id;
                winCustomer winCustomer = new winCustomer(customerId);
                winCustomer.ShowDialog();
                Search();
            }
        }


    }
}
