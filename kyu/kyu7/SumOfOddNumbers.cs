using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/55fd2d567d94ac3bc9000064/train/csharp
    //Status: In Progress
    public class SumOfOddNumbers
    {
        public static long RowSumOddNumbers(long n)
        {
            if(n==0 || n == 1)
            {
                return n;
            }
            long startingNumber = 1 + ((n-1) * 2);
            long endingNumber = startingNumber + (n * 2);
            long result = startingNumber;

            for(long i = 1; i < n; i++)
            {
                result += startingNumber+(i*2);
            }

            return result;
        }
    }
}
