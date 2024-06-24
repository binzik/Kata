﻿using System;
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

            //Check if one or no word
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
            if (words.Count < 2)
            {
                return words[0];
            }
            //Count of whitespaces left
            int leftSpace = width - currentLineLength;
            //List for words and whitespaces
            string[] whiteSpaces = new string[words.Count-1];

            //
            string[] wordsElementes = words.ToArray();

            //Count and calculate spaces
            int index = 0;
            while (leftSpace > 0)
            {
                if(index> words.Count - 2)
                {
                    index = 0;
                }
                whiteSpaces[index] += " ";
                leftSpace--;
                index++;
            }
            //Connect whitespaces to words
            for (int i = 0; i<wordsElementes.Length; i++)
            {
                if (whiteSpaces.Length > i)
                {
                    wordsElementes[i] = wordsElementes[i] + whiteSpaces[i];
                }
                
            }

            
            return string.Join("",wordsElementes);
        }
    }
}
