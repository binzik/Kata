using System.Linq;


namespace Kata.kyu.kyu7
{
    public class TwoToOne
    {
        //Course: https://www.codewars.com/kata/5656b6906de340bd1b0000ac/solutions/csharp
        //Status: Complete
        public static string GetTestDescription()
        {
            return "Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.\r\n\r\nExamples:\r\na = \"xyaabbbccccdefww\"\r\nb = \"xxxxyyyyabklmopq\"\r\nlongest(a, b) -> \"abcdefklmopqwxy\"\r\n\r\na = \"abcdefghijklmnopqrstuvwxyz\"\r\nlongest(a, a) -> \"abcdefghijklmnopqrstuvwxyz\"";
        }
        public static string Longest(string s1, string s2)
        {
            //connect both string and return distinct data sorted by the value like in alphabet
            return string.Concat((s1 + s2).Distinct().OrderBy(x => x));
        }
    }
}
