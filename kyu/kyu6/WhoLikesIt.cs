using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp
    //Status: Completed
    internal class WhoLikesIt
    {
        public static string GetTestDescription()
        {
            return "You probably know the \"like\" system from Facebook and other pages. People can \"like\" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.\r\n\r\nImplement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:\r\n\r\n[]                                -->  \"no one likes this\"\r\n[\"Peter\"]                         -->  \"Peter likes this\"\r\n[\"Jacob\", \"Alex\"]                 -->  \"Jacob and Alex like this\"\r\n[\"Max\", \"John\", \"Mark\"]           -->  \"Max, John and Mark like this\"\r\n[\"Alex\", \"Jacob\", \"Mark\", \"Max\"]  -->  \"Alex, Jacob and 2 others like this\"";
        }
        public static string Likes(string[] name)
        {
            int countOfPeople = name.Length;

            if (countOfPeople == 0)
            {
                return "no one likes this";
            }
            else if (countOfPeople == 1)
            {
                return name[0] + " likes this";
            }
            else if (countOfPeople == 2)
            {
                return name[0] + " and " + name[1] + " like this";
            }
            else if (countOfPeople == 3)
            {

                return ($"{name[0]}, {name[1]} and {name[2]} like this");
            }
            else
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }
    }
}
