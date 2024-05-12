using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //From course https://www.codewars.com/kata/5906436806d25f846400009b/train/csharp
    //Status: Complete
    internal class XShape
    {
        public static string X(int n)
        {
            //Using String Builder increases code efficiency than string
            //Creating an object for X
            StringBuilder x = new StringBuilder();
            //Vertial loop for every row
            for (int i = 0; i < n; i++)
            {
                //Horizontal loop for every character in line
                for (int j = 0; j < n; j++)
                {
                    //Checking if meets the conditions for \ or / line in X
                    if (j == i || j == (n - 1 - i))
                        x.Append("■");
                    //If no put empty
                    else
                        x.Append("□");
                }
                //Go to the new line if the is antoher line 
                if (i < n - 1)
                    x.AppendLine();
            }
            //Return StringBuilder = x as string
            return x.ToString();

            //

            //string x = string.Empty;
            //int a=0, b=n-1;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == a) x += "■";
            //        else if (j == b) x += "■";
            //        else x += "□";
            //    }
            //    a = a + 1;
            //    b = b - 1;
            //    if(i<n-1) x += "\n";
            //}
            //return x;
        }

        public static string GetTestDescription()
        {
            return "You will get an odd integer n (n >= 3) and your task is to draw an X. The lines are separated by newlines (\\n).\r\n\r\nUse the following characters: '■' and '□' (Ruby, Crystal and PHP: 'o' and ' ').\r\n\r\nExamples\r\n                                     ■□□□■\r\n            ■□■                      □■□■□\r\n  x(3) =>   □■□             x(5) =>  □□■□□\r\n            ■□■                      □■□■□\r\n                                     ■□□□■";
        }
    }
}
