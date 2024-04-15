using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //From course https://www.codewars.com/kata/52761ee4cffbc69732000738/train/csharp
    // Status: Complete
    internal class MiddleEarthGoodVsEvil
    {
        public static string GetTestDescription()
        {
            return "";
        }
        public static string GoodVsEvil(string good, string evil)
        {

            #region Good
            int goodPower = 0;
            //Change to array
            string[] goodArmy = (good.Split(' '));
            //Change type to int
            
            goodPower += Int32.Parse(goodArmy[0]) * 1;
            goodPower += Int32.Parse(goodArmy[1]) * 2;
            goodPower += Int32.Parse(goodArmy[2]) * 3;
            goodPower += Int32.Parse(goodArmy[3]) * 3;
            goodPower += Int32.Parse(goodArmy[4]) * 4;
            goodPower += Int32.Parse(goodArmy[5]) * 10;


            //Count power


            #endregion

            #region Evil
            int evilPower = 0;

            string[] evilArmy = (evil.Split(' '));

            evilPower += Int32.Parse(evilArmy[0]) * 1;
            evilPower += Int32.Parse(evilArmy[1]) * 2;
            evilPower += Int32.Parse(evilArmy[2]) * 2;
            evilPower += Int32.Parse(evilArmy[3]) * 2;
            evilPower += Int32.Parse(evilArmy[4]) * 3;
            evilPower += Int32.Parse(evilArmy[5]) * 5;
            evilPower += Int32.Parse(evilArmy[6]) * 10;

            #endregion

            #region Battle

            return (evilPower == goodPower) ? "Battle Result: No victor on this battle field" : ((evilPower>goodPower) ? "Battle Result: Evil eradicates all trace of Good" : "Battle Result: Good triumphs over Evil") ;

            #endregion
        }
    }
}
