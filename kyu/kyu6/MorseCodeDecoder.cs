using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    public class MorseCodeDecoder
    {
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
