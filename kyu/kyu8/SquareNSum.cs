using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/515e271a311df0350d00000f/train/csharp
    //Status: Complete
    internal class SquareNSum
    {
        public static string GetTestDescription()
        {
            return "Complete the square sum function so that it squares each number passed into it and then sums the results together.\r\n\r\nFor example, for [1, 2, 2] it should return 9 because \r\n1\r\n2\r\n+\r\n2\r\n2\r\n+\r\n2\r\n2\r\n=\r\n9\r\n1 \r\n2\r\n +2 \r\n2\r\n +2 \r\n2\r\n =9.";
        }
        public static int SquareSum(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number*number;
            }
            return result;
        }
    }
}
