using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.Configurations.Entities;

public class PrimaryKeyAttribute
{
    [Key]
    public int MyPrimaryKey { get; set; }
    public string Name { get; set; }
}
