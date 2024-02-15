using System;
using System.Collections.Generic;

namespace Kata.kyu.kyu6
{
    //From course: https://www.codewars.com/kata/54b724efac3d5402db00065e/solutions/csharp
    //Status: Complete
    public class MorseCodeDecoder
    {
        public static string GetTestDescription()
        {
            return "In this kata you have to write a simple Morse code decoder. While the Morse code is now mostly superseded by voice and digital data communication channels, it still has its use in some applications around the world.\r\nThe Morse code encodes every character as a sequence of \"dots\" and \"dashes\". For example, the letter A is coded as ·−, letter Q is coded as −−·−, and digit 1 is coded as ·−−−−. The Morse code is case-insensitive, traditionally capital letters are used. When the message is written in Morse code, a single space is used to separate the character codes and 3 spaces are used to separate words. For example, the message HEY JUDE in Morse code is ···· · −·−−   ·−−− ··− −·· ·.\r\n\r\nNOTE: Extra spaces before or after the code have no meaning and should be ignored.\r\n\r\nIn addition to letters, digits and some punctuation, there are some special service codes, the most notorious of those is the international distress signal SOS (that was first issued by Titanic), that is coded as ···−−−···. These special codes are treated as single special characters, and usually are transmitted as separate words.\r\n\r\nYour task is to implement a function that would take the morse code as input and return a decoded human-readable string. \r\n\r\nFor example:\r\n\r\nMorseCodeDecoder.Decode(\".... . -.--   .--- ..- -.. .\")\r\n//should return \"HEY JUDE\"";
        }
        public static string Decode(string morseCode)
        {
            int spaceOnBegining = 0;
            foreach (char c in morseCode)
            {
                if (c.ToString() == " ")
                {
                    spaceOnBegining++;
                }
                else break;
            }
            if(spaceOnBegining != 0) 
            {
                morseCode = morseCode.Substring(spaceOnBegining);
            }
            //Add space to validate properly
            morseCode += " ";


            //Alphabet of morse code
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
            MorseDecode.Add(" ", " ");

            //Specjal signs
            MorseDecode.Add("...---...", "SOS");
            MorseDecode.Add("-.-.--", "!");
            MorseDecode.Add(".-.-.-", ".");
            MorseDecode.Add("--..--", ",");
            MorseDecode.Add("..--..", "?");
            MorseDecode.Add(".----.", "'");

            List<string> MorseCoded = new List<string>();

            int space = 0;
            string signInCode = string.Empty;
            foreach (char code in morseCode)
            {
                if(code == ' ')
                {
                    space++;
                    if (signInCode != string.Empty)
                    {
                        MorseCoded.Add(signInCode);
                        signInCode = string.Empty;
                    }
                }
                else
                {
                    if(space == 0)
                    {
                        signInCode += code;
                    }
                    else
                    {
                        if(space == 3)
                        {
                            MorseCoded.Add(" ");
                            space = 0;
                            signInCode += code;
                        }
                        else
                        {
                            space = 0;
                            signInCode += code;
                        }
                    }
                }
            }
            string result = string.Empty;
            foreach(string code in MorseCoded)
            {
                result+= MorseDecode[code];
            }

            return result;
        }
    }
}
