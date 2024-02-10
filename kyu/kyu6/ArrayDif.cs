using System.Linq;

namespace Kata.kyu.kyu6
{
    //From course https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
    //Status: Complete
    public class ArrayDif
    {
        // Method checking if there is duplications and delete them 
        // Input: (int[] {1, 2, 2, 2, 3},int[] {2})
        // Output: int[] {1, 3}
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int i = 0;
            var list = a.ToList();


            foreach (int x in a)
            {
                foreach (int y in b)
                {
                    if (x == y)
                    {
                        list.Remove(x);
                    }
                }
                i++;
            }
            a = list.ToArray();
            return list.ToArray();
        }
    }
}
