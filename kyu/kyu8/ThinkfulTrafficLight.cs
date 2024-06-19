using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/58649884a1659ed6cb000072/train/csharp
    //Status: Completed
    internal class ThinkfulTrafficLight
    {
        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green":
                    return "yellow";
                case "yellow":
                    return "red";
                case "red":
                    return "green";
                default:
                    return "";
            }
        }
    }
}
