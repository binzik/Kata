using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/52f787eb172a8b4ae1000a34/train/csharp
    //Status: Complete
    public class NumberOfTraillingZerosOfN
    {
        public static string GetTestDescription()
        {
            return "Write a program that will calculate the number of trailing zeros in a factorial of a given number.\r\n\r\nN! = 1 * 2 * 3 *  ... * N\r\n\r\nBe careful 1000! has 2568 digits...\r\n\r\nFor more info, see: http://mathworld.wolfram.com/Factorial.html";
        }
        public static int TrailingZeros(int n)
        {
            int zeros = 0;
            for (int i = 5; n / i >= 1; i *= 5)
            {
                zeros += n / i;
            }
            return zeros;
        }
    }
}
