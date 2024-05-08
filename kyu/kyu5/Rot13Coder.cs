namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
    //Status: Complete
    public class Rot13Coder
    {
        public static string GetTestDescription()
        {
            return "";
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
