using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //From course https://www.codewars.com/kata/5202ef17a402dd033c000009/train/csharp
    public static class TitleCase
    {
        // return Sentece with filtered upperletters
        // Input: ("ab cd ef","cd")
        // Output: "Ab Cd ef"
        public static string GetCase(string title, string minorWords = "")
        {
            if (title.Length > 1)
            {
                if (minorWords == null) minorWords = string.Empty;

                string[] words = new string[title.Split().Length];
                string result = string.Empty;
                bool first_word = true;
                int index = 0;
                foreach (string sent in (title.ToLower()).Split())
                {
                    bool found = false;
                    foreach (string word in (minorWords.ToLower()).Split())
                    {
                        if (first_word)
                        {
                            first_word = false;
                            found = false;
                            break;
                        }
                        else if (sent == word)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        words[index] += char.ToUpper(sent[0]) + sent.Substring(1);
                    }
                    else
                    {
                        words[index] += sent;
                    }
                    index++;
                }
                Console.WriteLine(String.Join(" ", words));
                return String.Join(" ", words);
            }
            else return "";
        }
    }
}
