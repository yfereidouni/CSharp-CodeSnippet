using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace iWPF_S06_LINQ_To_SQL.Database
{
    public class Edition
    {
        public void SaveCustomer(string name, string tel, string email, string address, string ncode, DateTime? birthdate, string description)
        {
            try
            {
                Customer customer = new Customer();
                customer.Name = name;
                customer.Tel = tel;
                customer.Email = email;
                customer.Address = address;
                customer.BirthDate = birthdate;
                customer.Description = description;
                customer.NationalCode = ncode;

                ClassStatic.dbContext.Customers.InsertOnSubmit(customer);
                ClassStatic.dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}