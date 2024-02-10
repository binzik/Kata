using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    public class BouncingBall
    {

        public static int bouncingBall(double h, double bounce, double window)
        {
            // your code
            int seen = 0;
            double ballLocation = h;
            if (h > 0 && bounce > 0 && bounce < 1 && window < h)
            {
                while (h < window)
                {
                    if(true) { seen++; }
                }

            }
            else return -1;
            return 0;
        }
    }
}
