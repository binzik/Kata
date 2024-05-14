using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/58261acb22be6e2ed800003a/train/csharp
    //Status: Complete
    internal class VolumeOfaCuboid
    {
        public static string GetTestDescription()
        {
            return "Bob needs a fast way to calculate the volume of a cuboid with three values: the length, width and height of the cuboid. Write a function to help Bob with this calculation.";
        }
        public static double GetVolumeOfCuboid(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
