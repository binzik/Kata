using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
    //Status: In Progress
    internal class Rot13Coder
    {
        public static string GetTestDescription()
        {
            return "";
        }
        public static string Rot13(string message)
        {
            //loop for every character in the message
            string codedMessqge = string.Empty;
            foreach (var item in message)
            {
                //if lower letter
                if(item>64 && item < 91)
                {

                }
                //if upper letter
                else if(item>96 && item < 123)
                {

                }
                else
                {
                    codedMessqge+= item;
                }

            }
            return "";
        }
    }
}
