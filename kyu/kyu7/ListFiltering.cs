using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/train/csharp
    //Status: Complete
    internal class ListFiltering
    {
        public static string GetTestDescription()
        {
            return "In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.\r\n\r\nExample\r\nListFilterer.GetIntegersFromList(new List<object>(){1, 2, \"a\", \"b\"}) => {1, 2}\r\nListFilterer.GetIntegersFromList(new List<object>(){1, \"a\", \"b\", 0, 15}) => {1, 0, 15}\r\nListFilterer.GetIntegersFromList(new List<object>(){1, 2, \"a\", \"b\", \"aasf\", \"1\", \"123\", 123}) => {1, 2, 231}";
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //My First own made linq 😭
            return listOfItems.Where(x => x.GetType() == typeof(int)).OfType<int>();
        }
    }
}
