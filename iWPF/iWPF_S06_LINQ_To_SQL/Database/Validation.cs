using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace iWPF_S06_LINQ_To_SQL.Database
{
    public class RequiredStrings : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = value as string;
            if (string.IsNullOrEmpty(str))
            {
                return new ValidationResult(false, "وارد کردن این فیلد الزامی است");
            }
            return new ValidationResult(true, null);
        }

    }

    public class MobileValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string strMobile = value as string;
            //if (strMobile.Length==0)
            //{
            //    return new ValidationResult(true, null);
            //}

            if (Regex.IsMatch(strMobile, @"^((091)|(093))\d{8}$"))
                return new ValidationResult(true, null);
            else
                return new ValidationResult(false, "تلفن همراه را صحیح وارد کنید");
        }

    }

    public class EmailValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string strMobile = value as string;
            //if (strMobile.Length==0)
            //{
            //    return new ValidationResult(true, null);
            //}

            if (Regex.IsMatch(strMobile, @"^[A-Za-z0-9_\-\.]+@(([A-Za-z\-]+\.)+([A-Za-z\-]))$"))
                return new ValidationResult(true, null);
            else
                return new ValidationResult(false, "ایمیل را صحیح وارد کنید");
        }

    }

    public class NCodeValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string strNCode = value as string;

            try
            {
                char[] chArray = strNCode.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];
                if (strNCode == "0000000000" || strNCode == "1111111111" ||
                    strNCode == "2222222222" || strNCode == "3333333333" ||
                    strNCode == "4444444444" || strNCode == "5555555555" ||
                    strNCode == "6666666666" || strNCode == "7777777777" ||
                    strNCode == "8888888888" || strNCode == "9999999999")
                    return new ValidationResult(false, "کد ملی وارد شده صحیح نمی باشد");

                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                int num4 = num3 - ((num3 / 11) * 11);
                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {
                    return new ValidationResult(true, "کد ملی وارد شده صحیح می باشد");
                }
                else
                {
                    return new ValidationResult(false, "کد ملی وارد شده صحیح نمی باشد");
                }
            }
            catch (Exception)
            {
                return new ValidationResult(false, "کد ملی وارد شده 10 رقمی نمی باشد");
            }


        }

    }

    public class ValidationClassProperties
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string NCode { get; set; }
    }
}
