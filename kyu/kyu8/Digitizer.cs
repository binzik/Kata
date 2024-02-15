using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //From course https://www.codewars.com/kata/5583090cbe83f4fd8c000051/train/csharp
    //Status: Complete
    static class Digitizer
    {

        public static string GetTestDescription()
        {
            return "Given a random non-negative number, you have to return the digits of this number within an array in reverse order.\r\n\r\nExample(Input => Output):\r\n35231 => [1,3,2,5,3]\r\n0 => [0]";
        }

        public static long[] Digitize(long n)
        {
            string numberString = n.ToString();
            long[] digits = new long[numberString.Length];

            for(int i = 0; i< numberString.Length; i++)
            {
                digits[numberString.Length-(i+1)] = long.Parse(numberString[i].ToString());
            }

            return digits;
        }
    }
}
