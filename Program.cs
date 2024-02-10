using Kata.kyu.kyu6;
using Kata.kyu.kyu7;
using System;
using System.Runtime.CompilerServices;

namespace Kata
{
    public static class Kata
    {
        public static void Main()
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("*** Menu ***");
                Console.WriteLine("1. Kyu 8");
                Console.WriteLine("2. Kyu 7");
                Console.WriteLine("3. Kyu 6");

                Console.WriteLine("0. Exit");
                Console.WriteLine("Chose Lvl: ");


                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 0:
                        exit = false;
                        break;
                    case 1:
                        Console.WriteLine("Chosen kyu 8");
                        break;
                    case 2:
                        Console.WriteLine("Chosen kyu 7");
                        break;
                    case 3:
                        Console.WriteLine("Chosen kyu 6");
                        break;
                    default:
                        Console.WriteLine("Chosen incorrectly");
                        break;
                }
            }
        }

        static void ShowMenuKyu8()
        {
            while (true)
            {
                Console.WriteLine("*** Menu ***");
                Console.WriteLine("1. Kyu 8");
            }
        }

        static void TestExamples()
        {
            void BouncingBallTest()
            {
                BouncingBall.bouncingBall(3.0, 0.66, 1.5);
            }
        }
    }
}
