using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    internal class FindIt
    {
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach(int i in seq)
            {
                if (keyValuePairs.ContainsKey(i))
                {
                    keyValuePairs[i] += 1;
                }
                else keyValuePairs.Add(i, i);
            }
            int maxIndex = 0;
            int maxValue = int.MinValue;

            //This part is wrong
            foreach(int i in keyValuePairs.Values)
            {
                if (keyValuePairs[i] > maxValue)
                {
                    maxValue = keyValuePairs[i];
                    maxIndex = i;
                }
            }
            return -1;
        }
    }
}
