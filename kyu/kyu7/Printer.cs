using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    public static class Printer
    {
        public static string GetTestDescription()
        {
            return "In a factory a printer prints labels for boxes. For one kind of boxes the printer has to use colors which, for the sake of simplicity, are named with letters from a to m.\r\n\r\nThe colors used by the printer are recorded in a control string. For example a \"good\" control string would be aaabbbbhaijjjm meaning that the printer used three times color a, four times color b, one time color h then one time color a...\r\n\r\nSometimes there are problems: lack of colors, technical malfunction and a \"bad\" control string is produced e.g. aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.\r\n\r\nYou have to write a function printer_error which given a string will return the error rate of the printer as a string representing a rational whose numerator is the number of errors and the denominator the length of the control string. Don't reduce this fraction to a simpler expression.\r\n\r\nThe string has a length greater or equal to one and contains only letters from ato z.\r\n\r\nExamples:\r\ns=\"aaabbbbhaijjjm\"\r\nprinter_error(s) => \"0/14\"\r\n\r\ns=\"aaaxbbbbyyhwawiwjjjwwm\"\r\nprinter_error(s) => \"8/22\"";
        }
        public static string PrinterError(String s)
        {
            int badletters = 0;

            char start='a',end='m';

            foreach (char letter in s)
            {
                if(letter<start || letter > end)
                {
                    badletters++;
                }
            }

            return badletters + "/" + s.Length;
            //// your codes
            //Dictionary<char, int> duplicates = new Dictionary<char, int>();

            //string testData = "";
            //foreach (char c in s)
            //{
            //    testData += c;
            //    if (duplicates.ContainsKey(c) && (int)c >= 97 && (int)c <= 109)
            //    {
            //        duplicates[c] += 1;
            //    }
            //    else if ((int)c >= 97 && (int)c <= 109)
            //        duplicates[c] = 1;
            //}
            //Console.WriteLine(testData);



        }
    }
}
