using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/551f37452ff852b7bd000139/train/csharp
    //Status: Complete
    internal class BinaryAddition
    {
        public static string GetTestDescription()
        {
            return "Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.\r\n\r\nThe binary number returned should be a string.\r\n\r\nExamples:(Input1, Input2 --> Output (explanation)))\r\n\r\n1, 1 --> \"10\" (1 + 1 = 2 in decimal or 10 in binary)\r\n5, 9 --> \"1110\" (5 + 9 = 14 in decimal or 1110 in binary)";
        }
        public static string AddBinary(int a, int b)
        {
            // your code ...
            int sum = a + b;
            string result = "";
            while (sum > 0) 
            {
                int r = sum % 2;
                result = r + result;
                sum = sum/2;
            }
            
            return result;
        }
    }
}
