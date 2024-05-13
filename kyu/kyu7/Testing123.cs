using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp
    //Status: In Progress
    internal class Testing123
    {
        public static string GetTestDescription()
        {
            return "Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.\r\n\r\nWrite a function which takes a list of strings and returns each line prepended by the correct number.\r\n\r\nThe numbering starts at 1. The format is n: string. Notice the colon and space in between.\r\n\r\nExamples: (Input --> Output)\r\n\r\n[] --> []\r\n[\"a\", \"b\", \"c\"] --> [\"1: a\", \"2: b\", \"3: c\"]";
        }
        public static List<string> Number(List<string> lines)
        {
            //your code goes here
            return lines;
        }
    }
}
