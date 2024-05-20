using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/55b42574ff091733d900002f/train/csharp
    //Status: Complete
    internal class FriendOrFoe
    {
        public static string GetTestDescription()
        {
            return "Make a program that filters a list of strings and returns a list with only your friends name in it.\r\n\r\nIf a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...\r\n\r\nEx: Input = [\"Ryan\", \"Kieran\", \"Jason\", \"Yous\"], Output = [\"Ryan\", \"Yous\"]\r\n\r\ni.e.\r\n\r\nfriend [\"Ryan\", \"Kieran\", \"Mark\"] `shouldBe` [\"Ryan\", \"Mark\"]\r\nNote: keep the original order of the names in the output.";
        }
        public static IEnumerable<string> FriendOrFoeMethod(string[] names)
        {
            //Find select every element where length is exactly 4 end return it 
            return names.Where(x => x.Length == 4);
        }
    }
}
