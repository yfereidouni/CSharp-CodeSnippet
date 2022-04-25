using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.ComputedColumn;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    //Computed Column
    public string FullName { get; set; }

    //Default Value
    public DateTime RegisterDate { get; set; }
    public int Age { get; set; }
}


