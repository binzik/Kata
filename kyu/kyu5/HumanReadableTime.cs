using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
    //Status: In Progress
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            int hourInSecounds, minuteInSeconds;
            //Count hours
            hourInSecounds = (seconds-(seconds % (60 * 60)));
            seconds -= hourInSecounds;
            //Count minutes
            minuteInSeconds = seconds - (seconds % 60);
            seconds-= minuteInSeconds;
            

            return $"{hourInSecounds}:{minuteInSeconds}:{seconds}";
        }
    }
}
