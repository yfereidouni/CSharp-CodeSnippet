using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iWPF_S12_Stimulsoft_Reports
{
    public class ReportPerson
    {
        public int Row { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ReportPerson(string firstName, string lastName, int age, string mobile, string description, decimal price)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Mobile = mobile;
            this.Description = description;
            this.Price = price;

        }
    }
}
