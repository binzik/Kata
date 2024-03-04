using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    internal class Pillars
    {
        public static string GetTestDescription()
        {
            return "";
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
