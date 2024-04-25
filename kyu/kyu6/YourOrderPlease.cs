using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    internal class YourOrderPlease
    {
        public static string GetTestDescription()
        {
            return "";
        }
        public static string Order(string words)
        {
            string result = string.Empty;
            if (words == string.Empty) return string.Empty;

            List<string> wordList = words.Split(' ').ToList();



            //var resultList = wordList.OrderBy(x => int.Parse(x.Substring(x.Length -1)));

            ////List<string> resultList = new List<string>();

            ////for(int i = 0; i<wordList.Count; i++)
            ////{
            ////    var word = wordList.Where(w => w.Contains(i.ToString()));
            ////    resultList.Add("");
            ////}

            ////return String.Join(" ", resultList);
            return words;

        }
    }
}
