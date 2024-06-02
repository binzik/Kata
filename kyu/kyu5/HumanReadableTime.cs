using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
    //Status: Complete
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            int hourInSecounds, minuteInSeconds;
            //Count hours
            hourInSecounds = seconds-(seconds % (60 * 60));
            seconds -= hourInSecounds;
            //Count minutes
            minuteInSeconds = seconds - (seconds % 60);
            seconds-= minuteInSeconds;

            string hoursInString, minutesInString, secondsInString;
            hoursInString = ((hourInSecounds / (60 * 60)).ToString().Length == 1) ? "0" + hourInSecounds / (60 * 60) : (hourInSecounds / (60 * 60)).ToString();
            minutesInString = ((minuteInSeconds / 60).ToString().Length == 1) ? "0" + minuteInSeconds / 60 : (minuteInSeconds / 60).ToString();
            secondsInString = (seconds.ToString().Length == 1) ? "0" + seconds : seconds.ToString();



            return $"{hoursInString}:{minutesInString}:{secondsInString}";
        }
    }
}
