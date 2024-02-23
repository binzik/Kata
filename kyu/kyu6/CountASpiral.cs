using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Kata.kyu.kyu6
{
    public class CountASpiral
    {
        public static string GetTestDescription()
        {
            return "Your task is to return the amount of white rectangles in a NxN spiral. Your font may differ, if we talk of white rectangles, we talk about the symboles in the top row.\r\n\r\nNotes:\r\nAs a general rule, the white snake cannot touch itself.\r\nThe size will be at least 5.\r\nThe test cases get very large, it is not feasible to calculate the solution with a loop.\r\nExamples\r\nFor example, a spiral with size 5 should look like this:\r\n\r\n⬜⬜⬜⬜⬜\r\n⬛⬛⬛⬛⬜\r\n⬜⬜⬜⬛⬜\r\n⬜⬛⬛⬛⬜\r\n⬜⬜⬜⬜⬜\r\n\r\nAnd return the value 17 because the total amount of white rectangles is 17.\r\n\r\n";
        }
        public static int Sum(int size)
        {
            
            if(size%2 == 0)
            {

            }
            else
            {

            }



            return size;
        }
    }
}
