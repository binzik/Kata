using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp
    //Status: Complete
    internal class TakeATenMinutesWalk
    {
        public static string GetTestDescription()
        {
            return "You live in the city of Cartesia where all roads are laid out in a perfect grid. You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk. The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.\r\n\r\nNote: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). It will never give you an empty array (that's not a walk, that's standing still!).";
        }
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length == 10)
            {
                //Location of a person
                int locationH=0, locationV=0;
                foreach (string str in walk)
                {
                    switch (str)
                    {
                        case "s":
                            locationV--;
                            break;
                        case "n":
                            locationV++;
                            break;
                        case "e":
                            locationH++;
                            break;
                        case "w":
                            locationH--;
                            break;
                    }
                }

                return (locationH == 0 && locationV == 0) ? true : false;

            }
            else
            {
                return false;
            }
        }
    }
}
