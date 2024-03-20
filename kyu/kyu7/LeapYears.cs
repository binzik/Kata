using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    internal class LeapYears
    {
        //Course: https://www.codewars.com/kata/526c7363236867513f0005ca/train/csharp
        //Status: Complete
        public static string GetTestDescription()
        {
            return "In this kata you should simply determine, whether a given year is a leap year or not. In case you don't know the rules, here they are:\r\n\r\nYears divisible by 4 are leap years,\r\nbut years divisible by 100 are not leap years,\r\nbut years divisible by 400 are leap years.\r\nTested years are in range 1600 ≤ year ≤ 4000.";
        }
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else if (year % 100 == 0)
                {
                    return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
