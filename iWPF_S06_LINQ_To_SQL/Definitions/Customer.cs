using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iWPF_S06_LINQ_To_SQL.Definitions
{
    public class Customer
    {
        public int Row { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string NationalCode { get; set; }
        public string Description { get; set; }

    }
}
