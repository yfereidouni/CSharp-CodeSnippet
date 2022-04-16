using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iEFCore.Configurations.Entities
{
    //[Table("tbl_People", Schema = "dbo")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
