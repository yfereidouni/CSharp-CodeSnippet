using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iWPF_S06_LINQ_To_SQL.Database
{
    public class ClassStatic
    {
        //Local Connection String:
        public static LinqToSQLDataContext dbContext = new LinqToSQLDataContext("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LinqToSQL;Data Source=.");

        //LAN Connection String:
        //public static LinqToSQLDataContext dbContext = new LinqToSQLDataContext("Password=Develop2011~;Persist Security Info=True;User ID=sa;Initial Catalog=LinqToSQL;Data Source=192.168.1.106");

    }
}
