using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/576bb71bbbcf0951d5000044/train/csharp
    //Status: Complete
    public class CountPositivesSumNegatives
    {
        public static int[] CountPositivesAndSumNegatives(int[] input)
        {
            if(input == null || input.Length == 0)
            {
                return new int[] {};
            }
            return new int[] { CountPositives(input), SumNegatives(input) };
        }

        public static int CountPositives(int[] input) => input.Where(x => x > 0).Count();

        public static int SumNegatives(int[] input) => input.Where(x => x < 0).Sum();
    }
}
