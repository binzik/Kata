using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    public class BouncingBall
    {
        public static string GetTestDescription()
        {
            return "A child is playing with a ball on the nth floor of a tall building. The height of this floor above ground level, h, is known.\r\n\r\nHe drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).\r\n\r\nHis mother looks out of a window 1.5 meters from the ground.\r\n\r\nHow many times will the mother see the ball pass in front of her window (including when it's falling and bouncing)?\r\n\r\nThree conditions must be met for a valid experiment:\r\nFloat parameter \"h\" in meters must be greater than 0\r\nFloat parameter \"bounce\" must be greater than 0 and less than 1\r\nFloat parameter \"window\" must be less than h.\r\nIf all three conditions above are fulfilled, return a positive integer, otherwise return -1.\r\n\r\nNote:\r\nThe ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.";
        }
        public static int bouncingBall(double h, double bounce, double window)
        {
            // your code
            int seen = 0;
            double ballLocation = h;
            if (h > 0 && bounce > 0 && bounce < 1 && window < h)
            {
                while (h > window)
                {
                    //Falling
                    if (ballLocation > window)
                    {
                        seen++;
                        ballLocation = 0;
                        h=h*bounce;
                    }
                    //Bounce
                    if (h > window)
                    {
                        seen++;
                        ballLocation = h;
                    }
                }

            }
            else return -1;
            return seen;
        }
    }
}
