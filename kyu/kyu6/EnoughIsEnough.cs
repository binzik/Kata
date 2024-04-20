using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp
    //Status: In Progress
    internal class EnoughIsEnough
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            Dictionary<int, int> duplicatesCount = new Dictionary<int, int>();
            List<int> result = new List<int>();

            //




            for (int i = 0; i<arr.Length;i++)
            {
                if (duplicatesCount.ContainsKey(i))
                {
                    if (duplicatesCount[i] > 2)
                    {

                    }
                    else

                }
            }

            return new int[2] { 1, 2 };
        }
    }
}
