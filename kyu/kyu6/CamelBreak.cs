using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
    //Status: Complete
    internal class CamelBreak
    {
        public static string GetTestDescription()
        {
            return "Complete the solution so that the function will break up camel casing, using a space between words.\r\n\r\nExample\r\n\"camelCasing\"  =>  \"camel Casing\"\r\n\"identifier\"   =>  \"identifier\"\r\n\"\"             =>  \"\"";
        }

        public static string BreakCamelCase(string str)
        {
            //If empty or null return str
            if (String.IsNullOrEmpty(str)) return str;

            //List of words
            List<string> list = new List<string>();

            //word
            string word = string.Empty;

            //loop every letter int the string and check if there is Big letter or End of string
            for (int i = 0; i < str.Length; i++)
            {
                //Add to word
                word += str[i];
                //If end of string add to the words list
                if (i+1 == str.Length)
                {
                    list.Add(word);
                    break;
                }
                //If next letter is upper add word to the list and clear
                if (str[i+1]> 64 && str[i + 1] < 91)
                {
                    list.Add(word);
                    word = string.Empty;
                }
            }

            //return words from list 
            return String.Join(" ", list);
        }
    }
}
