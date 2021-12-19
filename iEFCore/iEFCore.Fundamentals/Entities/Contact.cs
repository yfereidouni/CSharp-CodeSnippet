using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iEFCore.Fundamentals
{
    [Table("tbl_Contacts",Schema ="YFO")]
    public class Contact
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        public Person Person { get; set; }
    }
}
