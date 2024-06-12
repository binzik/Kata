using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu4
{
    //Copurse: https://www.codewars.com/kata/537e18b6147aa838f600001b/train/csharp
    //Status: In Progress
    public class TextAlignJustify
    {
        public static string Justify(string str, int len)
        {
            string result = string.Empty;
            //PLAN
            //Split to words
            List<string> list = str.Split(' ').ToList();

            //Check if one word
             if(list.Count == 1)
             {
                return str + "\n"; ;
             }
            else if(list.Count==0)
            {
                return "\n";
            }

            //Split words to lane
            List<string> lines = new List<string>();
            List<string> line = new List<string>();
            int lineLength = 0;

            foreach (string s in list)
            {
                //PLAN
                //Check if added word to line can extend limit
                //If yes add to list of words to new line and clear list
                //if no add to list of words
                //
                if (lineLength+s.Length+line.Count < len)
                {
                    line.Add(s);
                    lineLength += s.Length;
                }


                
                
            }
            //calculate spaces
            //stick to one output
            //




            return result+"\n";
        }

        public static string JustifyLine(List<string> words, int currentLineLength, int width)
        {

            return "";
        }
    }
}
