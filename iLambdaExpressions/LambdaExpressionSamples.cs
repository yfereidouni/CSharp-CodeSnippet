using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLambdaExpressions
{
    public class LambdaExpressionSamples
    {
        public static void MyLambdaExpressions()
        {
            Func<string> func0 = () => $"0-Input: No-Input ";
            Func<string, string> func1 = (FirstName) => $"1-Input: {FirstName}";
            Func<string, string, string> func2 = (FirstName, LastName) => $"2-Input: {FirstName}, {LastName}";
            Func<string, string, string, string> func3 = (FirstName, LastName, Age) => $"3-Input: {FirstName}, {LastName}, {Age}";


            var result0 = func0();
            var result1 = func1("Yasser");
            var result2 = func2("Yasser", "Fereidouni");
            var result3 = func3("Yasser", "Fereidouni", "36");

            Console.WriteLine(result0);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
