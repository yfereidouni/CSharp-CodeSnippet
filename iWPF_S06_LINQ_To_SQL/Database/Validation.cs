using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace iWPF_S06_LINQ_To_SQL.Database
{
    public class Validation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (string.IsNullOrEmpty(str))
            {
                return new ValidationResult(false, "وارد کردن این فیلد الزامی است");
            }
            return new ValidationResult(true,null);
        }

    }

    public class Person
    {
        public string Name { get; set; }
    }
}
