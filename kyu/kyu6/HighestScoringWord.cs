using System;
using System.Collections.Generic;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/solutions/csharp
    //Status: Complete
    internal class HighestScoringWord
    {
        public static string GetTestDescription()
        {
            return "Given a string of words, you need to find the highest scoring word.\r\n\r\nEach letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.\r\n\r\nFor example, the score of abad is 8 (1 + 2 + 1 + 4).\r\n\r\nYou need to return the highest scoring word as a string.\r\n\r\nIf two words score the same, return the word that appears earliest in the original string.\r\n\r\nAll letters will be lowercase and all inputs will be valid.";
        }
        public static string High(string s)
        {
            Dictionary<string, int> wordsPoints = new Dictionary<string, int>();
            string[] words = s.Split(' ');
            string bestWord = null;
            int bestScore = 0;

            foreach (string word in words)
            {
                int wordScore=0;
                foreach(char letter in word)
                {
                    //Console.WriteLine((int)letter);
                    wordScore += ((int)letter) - 96;
                }
                
                wordsPoints[word] = wordScore;
                if (bestScore < wordsPoints[word])
                {
                    bestWord = word;
                    bestScore = wordScore;
                }
            }
            return bestWord;
        }
    }
}
