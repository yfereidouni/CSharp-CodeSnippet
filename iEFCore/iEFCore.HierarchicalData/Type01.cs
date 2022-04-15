using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.HierarchicalData;

public class Type01
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Type02> Type02s { get; set; }
}
