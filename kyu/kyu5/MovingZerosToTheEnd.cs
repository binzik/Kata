using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    //Course: https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
    //Status: Complete
    public class MovingZerosToTheEnd
    {
        public static string GetTestDescription()
        {
            return "";
        }
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> ints = new List<int>();
            List<int> listOf0 = new List<int>();
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] != 0) ints.Add(arr[i]);
                else listOf0.Add(arr[i]);
            }
            ints.AddRange(listOf0);
            return ints.ToArray(); ;
        }

        //To test later
        public static int[] MoveZeroesV2(int[] arr)
        {
            int index = 0;
            foreach(int i in arr)
            {

            }
            return new int[index];
        }
    }
}
