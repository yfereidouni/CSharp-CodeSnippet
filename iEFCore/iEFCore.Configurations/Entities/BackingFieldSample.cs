using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Configurations.Entities
{
    public class BackingFieldSample
    {
        public int Id { get; set; }

        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastnameFeild;

        [BackingField("lastnameFeild")]
        public string Lastname
        {
            get { return lastnameFeild; }
            set { lastnameFeild = value; }
        }

        private string fathernameFluent;
        public string FatherName
        {
            get { return fathernameFluent; }
            set { fathernameFluent = value; }
        }

        private DateTime _birthDateField;
    }
}
