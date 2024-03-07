using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/65e2df8302b29a005831eace/train/csharp
    //Status: Completed
    public static class TheNail
    {
        public static string GetTestDescription()
        {
            return "You're in a competition with another guy. You take turns hammering the nail. Whoever hits the last blow wins. The last blow means that the nail will be completely hammered.\r\n\r\nYour input is the length of the nail (0 < l < 100). You can hit with different strengths: 1, 2 or 3 units of nail length at a time. Your opponent is stronger than you, and his hitting strength can be 2, 3 or 4 units, but you have a friend in judging who has excluded all hopeless initial l values for you. You make the first strike.\r\n\r\nReturn the strength of your current strike (1, 2 or 3), depending on the remaining length of the nail.\r\n\r\nThe tests will invoke your and your opponent's solutions with the remaining length of the nail, as long as l > 0. Then, if l <= 0 after your hit, you win the contest and pass the kata.";
        }
        public static int Hit(int l) 
        {
            return ((l % 5) < 0 || (l % 5) >= 3) ? 3 : l % 5;
        }
    }
}
