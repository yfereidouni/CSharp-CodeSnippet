using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.LazyLoading;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual List<Address> Addresses { get; set; }
}
