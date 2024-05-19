using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp
    //Status: Complete
    internal class CountCharactersInString
    {
        public static string GetTestDescription()
        {
            return "The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.\r\n\r\nWhat if the string is empty? Then the result should be empty object literal, {}.\r\n\r\n";
        }
        public static Dictionary<char, int> Count(string str)
        {

            Dictionary<char, int> letterSort = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(str))
            {
                return letterSort;
            }
            else
            {
                foreach (char c in str)
                {
                    if (letterSort.ContainsKey(c))
                    {
                        letterSort[c]++;
                    }
                    else
                    {
                        letterSort.Add(c, 1);
                    }
                }
                return letterSort;
            }
        }
    }
}
