using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp
    //Status: In Progress
    internal class CountCharactersInString
    {
        public static string GetTestDescription()
        {
            return "The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.\r\n\r\nWhat if the string is empty? Then the result should be empty object literal, {}.\r\n\r\n";
        }
        public static Dictionary<char, int> Count(string str)
        {

            return new Dictionary<char, int>();
        }
    }
}
