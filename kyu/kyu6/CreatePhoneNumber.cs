using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    internal class CreatePhoneNumber
    {
        public static string GetTestDescription()
        {
            return "Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.\r\n\r\nExample\r\nKata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns \"(123) 456-7890\"";
        }

        public static string Create(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }
    }
}
