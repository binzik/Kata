using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    internal class SquareNSum
    {
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
