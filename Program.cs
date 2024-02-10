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
                Console.WriteLine("Chose: ");
                int chose = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (chose)
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
                        ShowMenuKyu6();
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
                Console.WriteLine("*** Kyu 8 ***");
                Console.WriteLine("1. Kyu 8");

                Int32.Parse(Console.ReadLine());
            }
        }

        static void ShowMenuKyu7()
        {
            while (true)
            {
                Console.WriteLine("*** Kyu 7 ***");
                Console.WriteLine("1. Kyu 8");

                Int32.Parse(Console.ReadLine());
            }
        }

        static void ShowMenuKyu6()
        {
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("*** Kyu 6 ***");
                Console.WriteLine("1. BouncingBall");

                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        BouncingBallTest();
                        break;
                }
            }
        }

        static void BouncingBallTest()
        {


            Console.WriteLine(0 == BouncingBall.bouncingBall(3.0, 0.66, 1.5));
        }
    }
}
