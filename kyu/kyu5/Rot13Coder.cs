namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
    //Status: Complete
    public class Rot13Coder
    {
        public static string GetTestDescription()
        {
            return "ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.\r\n\r\nCreate a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 \"implementation\".";
        }
        public static string Rot13(string message)
        {
            //loop for every character in the message
            string codedMessqge = string.Empty;
            foreach (char item in message)
            {
                char letter = '#';
                //if upper letter
                if (item > 64 && item < 91)
                {
                    letter = (char)(((int)item + 13) % 256);
                    if (letter > 90)
                    {
                        letter = (char)((64 + (int)letter - 90) % 256);
                    }
                }
                //if lower letter
                else if (item > 96 && item < 123)
                {
                    letter = (char)(((int)item + 13) % 256);
                    if (letter > 122)
                    {
                        letter = (char)((96 + (int)letter - 122) % 256);
                    }
                }
                else letter = item;

                codedMessqge += letter;

            }
            return codedMessqge;
        }
    }
}
