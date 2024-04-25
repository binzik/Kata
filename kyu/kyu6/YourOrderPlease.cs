using Kata.kyu.kyu7;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/55c45be3b2079eccff00010f/train/csharp
    //Progres: Complete
    internal class YourOrderPlease
    {
        public static string GetTestDescription()
        {
            return "Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.\r\n\r\nNote: Numbers can be from 1 to 9. So 1 will be the first word (not 0).\r\n\r\nIf the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.\r\n\r\nExamples\r\n\"is2 Thi1s T4est 3a\"  -->  \"Thi1s is2 3a T4est\"\r\n\"4of Fo1r pe6ople g3ood th5e the2\"  -->  \"Fo1r the2 g3ood 4of th5e pe6ople\"\r\n\"\"  -->  \"\"";
        }
        public static string Order(string words)
        {
            if (words == string.Empty) return string.Empty;
            string[] wordList = words.Split(' ');
            string[] wordsArray = new string[9];
            for(int i = 0;i<wordList.Length;i++)
            {
                int index = FindNumber(wordList[i]);
                wordsArray[index-1] = wordList[i];
            }
            return String.Join(" ", wordsArray.Where(w => !string.IsNullOrEmpty(w)));
        }
        private static int FindNumber(string word)
        {
            int searchedNumber = 0;
            foreach(char l in word)
            {
                if (l>=48 && 57>=l)
                {
                    searchedNumber = l-48;
                }
            }
            return searchedNumber;
        }
    }
}
