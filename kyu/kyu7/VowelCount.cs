using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
    //Status: Complete
    internal class VowelCount
    {
        public static string GetTestDescription()
        {
            return "Return the number (count) of vowels in the given string.\r\n\r\nWe will consider a, e, i, o, u as vowels for this Kata (but not y).\r\n\r\nThe input string will only consist of lower case letters and/or spaces.";
        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            foreach (char s in str)
            {
                string r = s.ToString();
                switch (r)
                {
                    case "a":
                        vowelCount++;
                        break;
                    case "e":
                        vowelCount++;
                        break;
                    case "i":
                        vowelCount++;
                        break;
                    case "o":
                        vowelCount++;
                        break;
                    case "u":
                        vowelCount++;
                        break;
                }
            }

            //Best Kata Code 
            //return str.Count(i => "aeiou".Contains(i));
            return vowelCount;
        }
    }
}
