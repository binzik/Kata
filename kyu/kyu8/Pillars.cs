using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course https://www.codewars.com/kata/5bb0c58f484fcd170700063d/train/csharp
    //Status: Not Ended
    internal class Pillars
    {
        public static string GetTestDescription()
        {
            return "There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three arguments:\r\n\r\nnumber of pillars (≥ 1);\r\ndistance between pillars (10 - 30 meters);\r\nwidth of the pillar (10 - 50 centimeters).\r\nCalculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).";
        }
        public static int PillarsMath(int numPill, int dist, int width)
        {
            if (numPill == 1)
            {
                return 0;
            }
            else if (numPill >= 1 && dist >= 10 && dist <= 30 && width >= 10 && width <= 50)
            {
                return ((numPill - 1) * dist) + ((numPill * width) - (width * 2));
            }
            else
                return 0;
        }
    }
}
