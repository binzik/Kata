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
            return "Welcome. In this kata, you are asked to square every digit of a number and concatenate them.\r\n\r\nFor example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)\r\n\r\nExample #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)\r\n\r\nNote: The function accepts an integer and returns an integer.\r\n\r\nHappy Coding!";
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
