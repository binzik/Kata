using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp
    //Status: Complete
    internal class SimplePigLatin
    {
        public static string GetTestDescriptionm()
        {
            return "Move the first letter of each word to the end of it, then add \"ay\" to the end of the word. Leave punctuation marks untouched.\r\n\r\nExamples\r\nKata.PigIt(\"Pig latin is cool\"); // igPay atinlay siay oolcay\r\nKata.PigIt(\"Hello world !\");     // elloHay orldway !";
        }
        public static string PigIt(string str)
        {
            //return first split input "str" into tab of elements next using linq change elements and at the end join them with " " between elements
            return String.Join(" ", str.Split(' ').Select(x => x.Length > 1 ? x.Substring(1) + x[0]+"ay" : x));
        }
    }
}
