using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Copurse: https://www.codewars.com/kata/576757b1df89ecf5bd00073b/train/csharp
    //Status: Complete
    public class BuildTower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] floors = new string[nFloors];
            
            for(int i = 0;i<nFloors;i++)
            {
                string empty = string.Empty;
                string filled = string.Empty;
                //Empty space
                for(int j = i;j < nFloors-1; j++)
                {
                    empty += " ";
                }
                //Filled space
                for (int j = 0; j < i; j++)
                {
                    filled += "*";
                }

                floors[i] = empty+filled+"*"+filled+empty;
            }
            return floors;
        }
    }
}
