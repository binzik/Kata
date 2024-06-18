using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp
    //Status: In Progress
    public class Persist
    {
        public static int Persistence(long n)
        {
            //if(n < 10) return 0;
            //int multiplications = 0;
            //while (n > 9)
            //{
            //    long worker = 1;
            //    for(int i = 0; i< n.ToString().Length; i++)
            //    {
            //        if((long)n.ToString()[i] - 48==0) continue;
            //        //long c = (long)n.ToString()[i] - 48;
            //        worker = worker * ((long)n.ToString()[i] - 48);
            //    }
            //    multiplications++;
            //    n = worker;
            //}
            //return multiplications;

            if(n<10) return 0;
            int multiplications = 1;
            while (n>=10)
            {
                
            }

            return multiplications;
        }
    }
}
