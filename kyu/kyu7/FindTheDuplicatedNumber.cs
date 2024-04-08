using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/558dd9a1b3f79dc88e000001/train/csharp
    //Status: Complete
    internal class FindTheDuplicatedNumber
    {
        public static string GetTestDescription()
        {
            return "You are given an array of n+1 integers 1 through n. In addition there is a single duplicate integer.\r\n\r\nThe array is unsorted.\r\n\r\nAn example valid array would be [3, 2, 5, 1, 3, 4]. It has the integers 1 through 5 and 3 is duplicated. [1, 2, 4, 5, 5] would not be valid as it is missing 3.\r\n\r\nYou should return the duplicate value as a single integer.";
        }
        public static int FindDup(int[] arr)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int duplicateValue = int.MinValue;
            foreach (int i in arr)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i] += 1;
                }
                else
                    keyValuePairs.Add(i, 1);
            }
            foreach (KeyValuePair<int, int> i in keyValuePairs)
            {
                if (i.Value>=2)
                {
                    duplicateValue = i.Key;
                }
            }
            return duplicateValue;
        }
    }
}
