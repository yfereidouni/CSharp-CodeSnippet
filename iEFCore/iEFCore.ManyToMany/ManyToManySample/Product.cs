using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.ManyToMany.ManyToManySample;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Tag> Tags { get; set; }
}