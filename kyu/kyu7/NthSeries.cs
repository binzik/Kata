using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/555eded1ad94b00403000071/train/csharp
    //Status: Completed
    public class NthSeries
    {
        public static string seriesSum(int n)
        {
            if (n == 0) 
                return "0.00";

            double result = 1;
            for (int i = 1;i<n;i++)
            {
                result += (i != 0) ? 1 / ((i*3.0)+1) : 1;
            }
            return result.ToString("0.00");
        }
    }
}
