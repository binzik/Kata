using System.Linq;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp
    //Status: Completed
    public class Persist
    {
        public static int Persistence(long n)
        {
            if (n < 10) return 0;
            int multiplications = 0;
            while (n >= 10)
            {
                long r = 1;
                char[] data = n.ToString().ToArray();
                for (int i = 0; i < n.ToString().Length; i++)
                {
                    r *= data[i] - 48;
                }

                n = r;
                multiplications++;
            }

            return multiplications;
        }
    }
}
