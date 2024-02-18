using Kata.kyu.kyu5;
using Kata.kyu.kyu6;
using Kata.kyu.kyu7;
using Kata.kyu.kyu8;
using System;
using System.Collections.Generic;
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
                Console.WriteLine("4. Kyu 5");

                Console.WriteLine("");
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
                        ShowMenuKyu8();
                        break;
                    case 2:
                        Console.WriteLine("Chosen kyu 7");
                        ShowMenuKyu7();
                        break;
                    case 3:
                        Console.WriteLine("Chosen kyu 6");
                        ShowMenuKyu6();
                        break;
                    case 4:
                        Console.WriteLine("Chosen kyu 6");
                        ShowMenuKyu5();
                        break;
                    default:
                        Console.WriteLine("Chosen incorrectly");
                        break;
                }
            }
        }

        static void ShowMenuKyu8()
        {
            bool isExit = true;
            while (isExit)
            {
                Console.WriteLine("*** Kyu 8 ***");
                Console.WriteLine("1. Digitizer");


                Console.WriteLine("");
                Console.WriteLine("0. Exit");

                int menuSelect = Int32.Parse(Console.ReadLine());

                switch (menuSelect)
                {
                    case 0:
                        isExit = false;
                        break;
                    case 1:
                        DigitizerTest();
                        break;

                }
            }
        }

        static void ShowMenuKyu7()
        {
            bool isExit = true;
            while (isExit)
            {
                Console.WriteLine("*** Kyu 7 ***");
                Console.WriteLine("1. Printer");


                Console.WriteLine("");
                Console.WriteLine("0. Exit");

                int menuSelect = Int32.Parse(Console.ReadLine());

                switch (menuSelect)
                {
                    case 0:
                        isExit = false;
                        break;
                    case 1:
                        PrinterTest();
                        break;

                }
            }
        }

        static void ShowMenuKyu6()
        {
            bool isExit = true;
            while (isExit)
            {
                Console.WriteLine("*** Kyu 6 ***");
                Console.WriteLine("1. BouncingBall");
                Console.WriteLine("2. MorseCodeDecoder");
                Console.WriteLine("3. SpinWords");


                Console.WriteLine("");
                Console.WriteLine("0. Exit");

                int menuSelect = Int32.Parse(Console.ReadLine());
                
                switch (menuSelect)
                {
                    case 0:
                        isExit = false;
                        break;
                    case 1:
                        BouncingBallTest();
                        break;
                    case 2:
                        MorseCodeDecoderTest();
                        break;
                    case 3:
                        SpinWordsTest();
                        break;
                }
            }
        }

        static void ShowMenuKyu5()
        {
            bool isExit = true;
            while (isExit)
            {
                Console.WriteLine("*** Kyu 8 ***");
                Console.WriteLine("1. PaginationHelper");


                Console.WriteLine("");
                Console.WriteLine("0. Exit");

                int menuSelect = Int32.Parse(Console.ReadLine());

                switch (menuSelect)
                {
                    case 0:
                        isExit = false;
                        break;
                    case 1:
                        PaginationHelperTest();
                        break;

                }
            }
        }

        //Completed
        static void BouncingBallTest()
        {
            Console.WriteLine(BouncingBall.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Seen: "+BouncingBall.bouncingBall(3.0, 0.66, 1.5));
            Console.WriteLine("---------------");
        }
        static void MorseCodeDecoderTest()
        {
            Console.WriteLine(MorseCodeDecoder.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Decoded: " + MorseCodeDecoder.Decode("   .... . -.--   .--- ..- -.. ."));
            Console.WriteLine("---------------");
        }
        static void DigitizerTest()
        {
            Console.WriteLine(Digitizer.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Decoded: " + Digitizer.Digitize(35231));
            Console.WriteLine("---------------");
        }
        static void PrinterTest()
        {
            Console.WriteLine(Printer.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Printer Error: " + Printer.PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
            Console.WriteLine("---------------");
        }
        static void SpinWordsTest()
        {
            Console.WriteLine(SpinWords.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Spin words: " + SpinWords.SpinWordss("Hey fellow warriors"));
            Console.WriteLine("---------------");
        }

        //Aborded
        static void PaginationHelperTest()
        {
            var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f'}, 4);

            Console.WriteLine(helper.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Page Count: " + helper.PageCount);
            Console.WriteLine("Item Count: " + helper.ItemCount);
            Console.WriteLine("Page Item Count: " + helper.PageItemCount(0));
            Console.WriteLine("Page Item Count: " + helper.PageItemCount(1));
            Console.WriteLine("Page Item Count: " + helper.PageItemCount(2));
            Console.WriteLine();
            Console.WriteLine("Page Item Count: " + helper.PageIndex(5));
            Console.WriteLine("Page Item Count: " + helper.PageIndex(2));
            Console.WriteLine("Page Item Count: " + helper.PageIndex(20));
            Console.WriteLine("Page Item Count: " + helper.PageIndex(-10));
            Console.WriteLine("---------------");
        }
    }
}
