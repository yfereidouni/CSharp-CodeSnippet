using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iWPF_S06_LINQ_To_SQL.Database
{
    public class ClassStatic
    {
        public static LinqToSQLDataContext dbContext = new LinqToSQLDataContext("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LinqToSQL;Data Source=.");

    }
}
