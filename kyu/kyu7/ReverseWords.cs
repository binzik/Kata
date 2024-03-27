using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/5259b20d6021e9e14c0010d4/train/csharp
    //Status: In Progress
    internal class ReverseWords
    {
        public static string GetTestDescription()
        {
            return "Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.\r\n\r\nExamples\r\n\"This is an example!\" ==> \"sihT si na !elpmaxe\"\r\n\"double  spaces\"      ==> \"elbuod  secaps\"";
        }
        public static string ReverseWord(string str)
        {
            string result = str;
            //Divide into elementss
            string[] words = result.Split(' ');

            //Execute loop for every element in the array of words

            //Every element do reverse 

            //Split to one string: result

            return result;
        }
    }
}
