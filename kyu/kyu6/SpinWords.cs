using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    public class SpinWords
    {
        public static string GetTestDescription()
        {
            return "Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.\r\n\r\nExamples:\r\n\r\n\"Hey fellow warriors\"  --> \"Hey wollef sroirraw\" \r\n\"This is a test        --> \"This is a test\" \r\n\"This is another test\" --> \"This is rehtona test\"";
        }
        public static string SpinWordss(string sentence)
        {
            string[] sentences = sentence.Split();
            List<string> words = new List<string>();
            foreach (string s in sentences)
            {
                
                if (s.Length >= 5)
                {
                    string word="";
                    for (int j = s.Length-1; j>=0; j--)
                    {
                        word += s[j];
                    }
                    words.Add(word);
                }
                else { words.Add(s); }

            }
            
            return string.Join(" ", words);
        }
    }
}
