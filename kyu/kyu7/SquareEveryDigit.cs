using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/546e2562b03326a88e000020/train/csharp
    //Status: Complete
    internal class SquareEveryDigit
    {
        public static string GetTestDescription()
        {
            return "";
        }

        public static int SquareDigits(int n)
        {
            char[] numbers = n.ToString().ToCharArray();
            string result = string.Empty;

            foreach (char c in numbers)
            {
                result +=Int32.Parse(c.ToString()) * Int32.Parse(c.ToString());
            }

            return Int32.Parse(result);
        }
    }
}
