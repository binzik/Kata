using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //Course: https://www.codewars.com/kata/65c0161a2380ae78052e5731/train/csharp
    //Status: In Progress
    internal class StonePickAxe
    {
        public static string GetTestDescription()
        {
            return "Note: Based off Minecraft, hopefully you at least know the game!\r\n\r\nStory: You want to create a giant mine shaft, but you're a little stingy with your iron and diamonds and would not mine out all of the stone with iron or diamond pickaxes. Instead, you rely on less durable but cheaper stone pickaxes! You will need a lot of stone pickaxes though as they break faster than diamond or iron ones, so you need to find out how many stone pickaxes you can craft before you run out of sticks and cobblestones. Unfortunately, you're not an organized person, and you leave all of your materials in a single chest with random junk that you need to filter.\r\n\r\nTask: Given an array, return the maximum amount of stone pickaxes you can craft before you run out of sticks and cobblestones. Within the array would be a series of strings with the exact names of the materials listed below. A single stone pickaxe is made of 3 \"Cobblestone\" and 2 \"Sticks\", check if your given array contains enough \"Sticks\" and \"Cobblestone\" to craft a single stone pickaxe or even more. Do not count any materials apart from \"Cobblestones\", \"Sticks\" and \"Wood\". Wood can be converted into 4 sticks!\r\n\r\nHere are the materials you would expect in an array:\r\n\r\nSticks\r\nCobblestone\r\nStone (These are different from cobblestone and cannot be used to make a stone pickaxe.)\r\nWool\r\nDirt\r\nWood (Can be treated as sticks, typically 4 sticks for 1 wood)\r\nDiamond\r\nArray sizes are randomized and range from 1 - 200 with randomized contents.\r\n\r\nExamples:\r\n\r\nArray: [\"Sticks\", \"Sticks\", \"Cobblestone\", \"Cobblestone\", \"Cobblestone\"]\r\nReturned: 1\r\n\r\nArray: [\"Wood\", \"Cobblestone\", \"Cobblestone\", \"Cobblestone\"]\r\nReturned: 1\r\n\r\nArray: []\r\nReturned: 0\r\n\r\nArray: [\"Sticks\", \"Wool\", \"Cobblestone\"]\r\nReturned: 0\r\n\r\nArray: [\"Cobblestone\", \"Cobblestone\", \"Cobblestone\", \"Cobblestone\", \"Cobblestone\", \"Cobblestone\", \"Wood\"]\r\nReturned: 2\r\nGood Luck :D\r\n\r\nMade by miggycoder, this is my first kata I ever created.";
        }
        public static int StonePick(string[] arr)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            //Inventory filter
            foreach (string item in arr)
            {
                if(item == "Wood")
                {
                    if (inventory.ContainsKey("Sticks"))
                    {
                        inventory["Sticks"] += 4;
                    }

                    else
                    {
                        inventory.Add("Sticks", 4);
                    }
                }
                else if (inventory.ContainsKey(item))
                {
                    inventory[item] += 1;
                }

                else
                {
                    inventory.Add(item, 1);
                }
            }
            if(inventory.ContainsKey("Sticks") && inventory.ContainsKey("Cobblestone") && inventory["Sticks"]>=2 && inventory["Cobblestone"]>=3)
            {
                int sticks = inventory["Sticks"]; 
                int cobble = inventory["Cobblestone"];


                while (sticks != 0)
                {
                    int t = sticks;
                    sticks = cobble % sticks;
                    cobble = t;
                }

                return cobble;
            }
            else { return 0; }

        }
    }
}
