using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    public class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            Dictionary<string, string> MorseDecode = new Dictionary<string, string>();
            MorseDecode.Add(".-", "A");
            MorseDecode.Add("-...", "B");
            MorseDecode.Add("-.-.", "C");
            MorseDecode.Add("-..", "D");
            MorseDecode.Add(".", "E");
            MorseDecode.Add("..-.", "F");
            MorseDecode.Add("--.", "G");
            MorseDecode.Add("....", "H");
            MorseDecode.Add("..", "I");
            MorseDecode.Add(".---", "J");
            MorseDecode.Add("-.-", "K");
            MorseDecode.Add(".-..", "L");
            MorseDecode.Add("--", "M");
            MorseDecode.Add("-.", "N");
            MorseDecode.Add("---", "O");
            MorseDecode.Add(".--.", "P");
            MorseDecode.Add("--.-", "Q");
            MorseDecode.Add(".-.", "R");
            MorseDecode.Add("...", "S");
            MorseDecode.Add("-", "T");
            MorseDecode.Add("..-", "U");
            MorseDecode.Add("...-", "V");
            MorseDecode.Add(".--", "W");
            MorseDecode.Add("-..-", "X");
            MorseDecode.Add("-.--", "Y");
            MorseDecode.Add("--..", "Z");

            MorseDecode.Add(".----", "1");
            MorseDecode.Add("..---", "2");
            MorseDecode.Add("...--", "3");
            MorseDecode.Add("....-", "4");
            MorseDecode.Add(".....", "5");
            MorseDecode.Add("-....", "6");
            MorseDecode.Add("--...", "7");
            MorseDecode.Add("---..", "8");
            MorseDecode.Add("----.", "9");
            MorseDecode.Add("-----", "0");



            throw new System.NotImplementedException("Please provide some code.");
        }
        //public static string Decode(string morseCode)
        //{
        //    morseCode += " ";
        //    string result = string.Empty;
        //    List<string> morseCutter = new List<string>();

        //    string codeC = string.Empty;
        //    string space = string.Empty;
        //    foreach (char morseSign in morseCode)
        //    {
        //        if (morseSign.ToString() != " " && space == string.Empty)
        //            codeC += morseSign;
        //        else if (morseSign.ToString() != " " && space == " ")
        //        {
        //            space = " ";
        //        }
        //        else
        //        {
        //            morseCutter.Add(codeC);
        //            codeC = string.Empty;
        //            space = " ";
        //        }

        //    }


        //    foreach (string m in morseCutter)
        //    {
        //        if (m != " ")
        //            result += MorseCode.Get(m);
        //        else
        //            result += " ";

        //    }

        //    return result;
        //}
    }
}
