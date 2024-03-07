using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu6
{
    //Course: https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp
    //Status: Created
    internal class WhoLikesIt
    {
        public static string GetTestDescription()
        {
            return "You probably know the \"like\" system from Facebook and other pages. People can \"like\" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.\r\n\r\nImplement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:\r\n\r\n[]                                -->  \"no one likes this\"\r\n[\"Peter\"]                         -->  \"Peter likes this\"\r\n[\"Jacob\", \"Alex\"]                 -->  \"Jacob and Alex like this\"\r\n[\"Max\", \"John\", \"Mark\"]           -->  \"Max, John and Mark like this\"\r\n[\"Alex\", \"Jacob\", \"Mark\", \"Max\"]  -->  \"Alex, Jacob and 2 others like this\"";
        }
        public static string Likes(string[] name)
        {
            return "";
        }
    }
}
