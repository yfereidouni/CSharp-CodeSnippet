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
        public void SaveCustomer(string name, string tel, string email,
                                 string address, string ncode, DateTime? birthdate,
                                 string description, List<Database.Phone> lstPhones)
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

                foreach (var item in lstPhones)
                {
                    Phone phone = new Phone();
                    phone.Title = item.Title;
                    phone.PhoneNumber = item.PhoneNumber;
                    phone.Customer = customer;
                    ClassStatic.dbContext.Phones.InsertOnSubmit(phone);
                }

                ClassStatic.dbContext.Customers.InsertOnSubmit(customer);
                ClassStatic.dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditCustomer(int customerId, string name, string tel, string email, string address, string ncode, DateTime? birthdate, string description)
        {
            try
            {
                var customer = Database.ClassStatic.dbContext.Customers.Where(q => q.Id == customerId).FirstOrDefault();
                if (customer != null)
                {
                    customer.Name = name;
                    customer.Tel = tel;
                    customer.Email = email;
                    customer.Address = address;
                    customer.BirthDate = birthdate;
                    customer.Description = description;
                    customer.NationalCode = ncode;

                    ClassStatic.dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                var customer = Database.ClassStatic.dbContext.Customers.Where(q => q.Id == customerId).FirstOrDefault();
                if (customer != null)
                {
                    Database.ClassStatic.dbContext.Customers.DeleteOnSubmit(customer);
                    Database.ClassStatic.dbContext.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}