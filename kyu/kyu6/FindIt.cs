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
            int oddIndex = 0;
            //This part is wrong
            foreach(var i in keyValuePairs)
            {
                if (i.Value%2 != 0)
                {
                    oddIndex = i.Key;
                }
            }
            return oddIndex;
        }
    }
}
