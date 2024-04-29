using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
    //Status: In Progress
    internal class CamelBreak
    {
        public static string GetTestDescription()
        {
            return "Complete the solution so that the function will break up camel casing, using a space between words.\r\n\r\nExample\r\n\"camelCasing\"  =>  \"camel Casing\"\r\n\"identifier\"   =>  \"identifier\"\r\n\"\"             =>  \"\"";
        }

        public static string BreakCamelCase(string str)
        {
            if (String.IsNullOrEmpty(str)) return str;

            for (int i = 0; i < str.Length; i++)
            {

            }

            return String.Join(" ", new List<string> {"","" });
        }
    }
}
