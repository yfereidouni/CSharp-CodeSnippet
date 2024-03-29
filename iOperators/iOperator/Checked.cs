﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class Checked
    {
        public void CheckedTypesOverflow()
        {
            //checked
            //{
            //    byte b = byte.MaxValue;
            //    b += 2;
            //    Console.WriteLine(b);
            //}

            //-------------------------------------

            //byte b = byte.MaxValue;
            //b = checked(b++);          //Checked : can be used in some part of your code.
            //Console.WriteLine(b);

            //-------------------------------------

            byte b = byte.MaxValue;
            b = unchecked(b++);          //Unchecked : can be used in some part of your code that you dont want to checked.
            Console.WriteLine(b);

            /// 1. You can also use checking overflow in the project config tags with this tag :
            /// <CheckForOverflowUnderflow>true</CheckForOverflowUnderflow>
            /// 2. Last but not leaset : you can activate this in all your project in project propertise it means that 
            /// you need to Checked the "Check for arethmetic overflow" option
        }
    }
}
