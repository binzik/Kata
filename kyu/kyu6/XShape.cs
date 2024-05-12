using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //From course https://www.codewars.com/kata/5906436806d25f846400009b/train/csharp
    //Status: In Progress
    internal class XShape
    {
        public static string X(int n)
        {
            string x = string.Empty;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j==0) x += "■";
                    if(j==n-1) x += "■";


                }
            }

            return x;
        }

        public static string GetTestDescription()
        {
            return "You will get an odd integer n (n >= 3) and your task is to draw an X. The lines are separated by newlines (\\n).\r\n\r\nUse the following characters: '■' and '□' (Ruby, Crystal and PHP: 'o' and ' ').\r\n\r\nExamples\r\n                                     ■□□□■\r\n            ■□■                      □■□■□\r\n  x(3) =>   □■□             x(5) =>  □□■□□\r\n            ■□■                      □■□■□\r\n                                     ■□□□■";
        }
    }
}
