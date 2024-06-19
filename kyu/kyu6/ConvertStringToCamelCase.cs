using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
    //Status: Complete
    public class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            str = str.Replace("_", " ").Replace("-", " ");

            bool firstWord = true;
            List<string> list = new List<string>();
            foreach (string word in str.Split(' '))
            {
                if (!firstWord && word.Length>1) {
                    list.Add(char.ToUpper(word[0])+word.Substring(1));
                }
                else 
                {
                    list.Add(word);
                    firstWord = false;
                }
            }
            return string.Join("", list);
        }
    }
}
