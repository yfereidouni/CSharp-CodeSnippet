using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iImplicit_Explicit_TypeCasting
{
    public class Dollar
    {
        public int DollarCount { get; set; }
        public int CentCount { get; set; }

        public static implicit operator Dollar(double input)
        {
            var dollar = new Dollar();

            dollar.DollarCount = (int)input;
            dollar.CentCount = (int)((input - dollar.DollarCount) * 100);
            return dollar;
        }

        public static explicit operator double(Dollar dollar)
        {
            double result  = dollar.DollarCount + ((double)dollar.CentCount / 100);
            return result;
        }

    }
}
