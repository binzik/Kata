using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    internal class FindTheParityOutlier
    {
        public static string GetTestDescription()
        {
            return "You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes the array as an argument and returns this \"outlier\" N.\r\n\r\nExamples\r\n[2, 4, 0, 100, 4, 11, 2602, 36] -->  11 (the only odd number)\r\n\r\n[160, 3, 1719, 19, 11, 13, -21] --> 160 (the only even number)";
        }
        public static int Find(int[] integers)
        {
            int oddCount = 0, evenCount = 0;
            int oddRepresentative = 0, evenRepresentative = 0;
            foreach (int number in integers)
            {
                if (number % 2 == 0)
                {
                    evenRepresentative = number;
                    evenCount++;
                }
                else
                {
                    oddRepresentative = number;
                    oddCount++;
                }
            }
            return (oddCount > evenCount) ? evenRepresentative : oddRepresentative;
        }
    }
}
