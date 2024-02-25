using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp
    //Status: Complete
    internal class YouOnlyNeedOne
    {
        static public string GetTestDescription()
        {
            return "You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.\r\n\r\nArray can contain numbers or strings. X can be either.\r\n\r\nReturn true if the array contains the value, false if not.";
        }
        public static bool Check(object[] a, object x)
        {
            foreach(object o in a)
            {
                if (o.ToString() == x.ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
