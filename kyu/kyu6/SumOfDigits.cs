using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp
    //Status: In Progress
    internal class SumOfDigits
    {
        public static string GetTestDescription()
        {
            return "Digital root is the recursive sum of all the digits in a number.\r\n\r\nGiven n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. The input will be a non-negative integer.\r\n\r\nExamples\r\n    16  -->  1 + 6 = 7\r\n   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6\r\n132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6\r\n493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2";
        }
        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            while (n > 9)
            {
                string digitToString = n.ToString();
                int[] digits = new int[digitToString.Length];
                foreach (char d in digitToString)
                {

                }
            }

            return 0;
        }
    }
}
