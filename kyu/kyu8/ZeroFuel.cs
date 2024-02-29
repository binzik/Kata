using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    internal class ZeroFuel
    {
        //Course: https://www.codewars.com/kata/5861d28f124b35723e00005e/train/csharp
        //Status: Complete
        public static string GetTestDescription()
        {
            return "You were camping with your friends far away from home, but when it's time to go back, you realize that your fuel is running out and the nearest pump is 50 miles away! You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left.\r\n\r\nConsidering these factors, write a function that tells you if it is possible to get to the pump or not.\r\n\r\nFunction should return true if it is possible and false if not.\r\n\r\n";
        }

        public static bool IsZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) 
        {
            //Consumption in gallon
            return distanceToPump<=mpg*fuelLeft; 
        }
    }
}
