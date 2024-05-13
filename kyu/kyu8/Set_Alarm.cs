using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/568dcc3c7f12767a62000038/train/csharp
    //Status: Complete
    internal class Set_Alarm
    {
        public static string GetTestDescription()
        {
            return "Write a function named setAlarm/set_alarm/set-alarm/setalarm (depending on language) which receives two parameters. The first parameter, employed, is true whenever you are employed and the second parameter, vacation is true whenever you are on vacation.\r\n\r\nThe function should return true if you are employed and not on vacation (because these are the circumstances under which you need to set an alarm). It should return false otherwise. Examples:\r\n\r\nemployed | vacation \r\ntrue     | true     => false\r\ntrue     | false    => true\r\nfalse    | true     => false\r\nfalse    | false    => false";
        }
        public static bool SetAlarm(bool employed, bool vacation)
        {
            if(employed && !vacation) return true;
            else return false;
        }
    }
}
