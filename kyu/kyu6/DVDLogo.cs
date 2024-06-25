using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/65e8b02a9e79a010e5210b6c/train/csharp
    //Status: In Progress
    public class DVDLogo
    {
        //w and h: The size of the screen(positive integers)
        //x and y: The position of the logo(non negative integers), bottom left is (0, 0)
        //d: The direction the logo will initially go in ("NE", "SE", "SW", or "NW")
        //All inputs are valid
        public static bool WillHitCorner(long w, long h, long x, long y, string d)
        {
            
            long startPositionX = x, startPositionY = y;
            long actualPositionX = x, actualPositionY = y;

            //isCorner || (actualPositionX==startPositionX && actualPositionY == startPositionY)
            while (true)
            {
                //checkif logo touch any corner
                if((actualPositionX==0 && actualPositionY==0) || (actualPositionX==w && actualPositionY==h) || (actualPositionX==0 && actualPositionY==h) || (actualPositionX==y && actualPositionX==0))
                {
                    return true;
                }
                //Move logo
                (actualPositionX, actualPositionY, d) = Move(actualPositionX, actualPositionY, d, w, h);
                //check if logo back to his start position
                if (actualPositionX==startPositionX && actualPositionY == startPositionY)
                {
                    return false;
                }

                
            }
        }

        public static (long, long , string) Move(long x, long y, string direction, long w, long h)
        {

            if (w == x || x==0)
            {
                string r = string.Empty;
                if (direction[1] == 'E')
                    r = direction[0] + "W";
                else
                    r = direction[0] + "E";

                direction = r;
            }
            if (y == h || y == 0)
            {
                string r = string.Empty;
                if (direction[0] == 'N')
                    r = "S" + direction[1];
                else
                    r = "N" + direction[1];

                direction = r;
            }
                


            switch (direction)
            {
                case "NE":
                    x++;
                    y++;
                    break;
                case "SE":
                    x++; 
                    y--;
                    break;
                case "SW":
                    x--;
                    y--;
                    break;
                case "NW":
                    x--;
                    y++;
                    break;
            }
            return (x,y,direction);
        }
    }
}
