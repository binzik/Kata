using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    internal class TwoToOne
    {
        //Course: https://www.codewars.com/kata/5656b6906de340bd1b0000ac/train/csharp
        //Status: In Progress
        public static string GetTestDescription()
        {
            return "Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.\r\n\r\nExamples:\r\na = \"xyaabbbccccdefww\"\r\nb = \"xxxxyyyyabklmopq\"\r\nlongest(a, b) -> \"abcdefklmopqwxy\"\r\n\r\na = \"abcdefghijklmnopqrstuvwxyz\"\r\nlongest(a, a) -> \"abcdefghijklmnopqrstuvwxyz\"";
        }
        public static string Longest(string s1, string s2)
        {
            if (s1.OrderBy(x => (int)x) == s2.OrderBy(x => (int)x))
            {

            }

            return s1 + s2;
        }
    }
}
