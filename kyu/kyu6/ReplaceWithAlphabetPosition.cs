using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
    //Status: Completed
    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            text = text.Replace(" ","");
            List<string> list = new List<string>();
            foreach (char c in text) { if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) list.Add(ChangeToIndex(c)); }

            return string.Join(" ",list);
            //Codewars solution
            //return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
        }

        private static string ChangeToIndex(char symbol)
        {
            //if((symbol >= 'A' && symbol <= 'Z') || (symbol >= 'a' && symbol <= 'z')) 
            return (char.ToUpper(symbol)-64).ToString();
        }
    }
}
