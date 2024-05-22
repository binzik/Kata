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
            //distinct letters from string and sort them 
            var a = s1.Distinct().OrderBy(x => x).ToArray();
            //distinct letters from string and sort them 
            var b = s2.Distinct().OrderBy(x => x).ToArray();

            //Debugg
            Console.WriteLine("A: " + string.Concat(a));
            Console.WriteLine("B: " + string.Concat(b));

            //return string a or b depend which one count is higher
            return a.Count() >= b.Count() ? GetArrayToString(a) : GetArrayToString(b);
        }

        private static string GetArrayToString(char[] arrayOfLetters)
        {
            var sb = new StringBuilder();
            foreach (var letter in arrayOfLetters)
            {
                if (letter == 'c')
                {
                    Console.WriteLine("This is c!!!!!!");
                }
                sb.Append(letter);
            }
            return sb.ToString();
        }
    }
}
