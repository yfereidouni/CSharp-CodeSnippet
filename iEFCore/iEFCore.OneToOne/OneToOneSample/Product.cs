using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.OneToOne.OneToOneSample;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Discount Discount { get; set; }
}
