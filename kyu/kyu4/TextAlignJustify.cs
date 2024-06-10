using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu4
{
    //Copurse: https://www.codewars.com/kata/537e18b6147aa838f600001b/train/csharp
    //Status: In Progress
    internal class TextAlignJustify
    {
        public static string Justify(string str, int len)
        {
            //PLAN
            //Split to words
            List<string> list = str.Split(' ').ToList();
            //Split words to lane
            List<List<string>> linesOfWords = new List<List<string>>();
            List<string> line = new List<string>();

            foreach (string s in list)
            {
                if (list.Sum(x => x.Length) < len-(list.Count-1))
                {
                    line.Add(s);
                }
                else
                {
                    linesOfWords.Add(line);
                    line = null;
                }
            }
            //calculate spaces

            //stick to one output
            //




            return "";
        }
    }
}
