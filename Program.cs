﻿using Kata.kyu.kyu5;
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
        #region Menu

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
                Console.WriteLine("2. YouOnlyNeedOne");
                Console.WriteLine("3. ZeroFuel");
                Console.WriteLine("4. Pillars");
                Console.WriteLine("5. Square(n)Sum");//TOCHECK
                Console.WriteLine("6. Dna Conversion");
                Console.WriteLine("7. Set Alarm");
                Console.WriteLine("8. Volume of Cuboid");


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
                    case 2:
                        YouOnlyNeedOneTest();
                        break;
                    case 3:
                        ZeroFuelTest();
                        break;
                    case 4:
                        PillarsTest();
                        break;
                    case 5:
                        SquareNSumTest();
                        break;
                    case 6:
                        DnaConversionTest();
                        break;
                    case 7:
                        Set_AlarmTest();
                        break;
                    case 8:
                        VolumeOfaCuboidTest();
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
                Console.WriteLine("2. Binary Addition");
                Console.WriteLine("3. The Nail");
                Console.WriteLine("4. Linked Lists - Push&BuildOneTwoThree");
                Console.WriteLine("5. Minectaft StonePick making");
                Console.WriteLine("6. LeapYears");
                Console.WriteLine("7. Vowel Count");
                Console.WriteLine("8. ReverseWords");
                Console.WriteLine("9. Square Every Digit");
                Console.WriteLine("10. Find Duplicated Number");
                Console.WriteLine("11. ListFiltering");
                Console.WriteLine("12. Testing123");
                Console.WriteLine("13. Friend or Foe");
                Console.WriteLine("14. Two to One");


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
                    case 2:
                        BinaryAdditionTest();
                        break;
                    case 3:
                        TheNailTest();
                        break;
                    case 4:
                        NodeTest();
                        break;
                    case 5:
                        StonePickAxeTest();
                        break;
                    case 6:
                        LeapYearsTest();
                        break;
                    case 7:
                        VowelCountTest();
                        break;
                    case 8:
                        ReverseWordsTest();
                        break;
                    case 9:
                        SquareEveryDigitTest();
                        break;
                    case 10:
                        FindTheDuplicatedNumberTest();
                        break;
                    case 11:
                        ListFilteringTest();
                        break;
                    case 12:
                        Testing123Test();
                        break;
                    case 13:
                        FriendOrFoeTest();
                        break;
                    case 14:
                        TwoToOneTest();
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
                Console.WriteLine("1. Bouncing Ball");
                Console.WriteLine("2. Morse Code Decoder");
                Console.WriteLine("3. Spin Words");
                Console.WriteLine("4. Highest Scoring Word");
                Console.WriteLine("5. Count a Spiral");
                Console.WriteLine("6. Who likes it?");
                Console.WriteLine("7. Sum of Digits/Digital Root");
                Console.WriteLine("8. Create your number");
                Console.WriteLine("9. Good vs Evil");
                Console.WriteLine("10. Enough is enough");
                Console.WriteLine("11. Your order, please");
                Console.WriteLine("12. Break Camel Case");
                Console.WriteLine("13. ASCII Fun #1:X-Shape");
                Console.WriteLine("14. Take a Ten Miinutes Walk");
                Console.WriteLine("15. Count characters in your string");


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
                    case 4:
                        HighestScoringWordTest();
                        break;
                    case 5:
                        CountASpiralTest();
                        break;
                    case 6:
                        WhoLikesItTest();
                        break;
                    case 7:
                        SumOfDigitsTest();
                        break;
                    case 8:
                        CreatePhoneNumberTest();
                        break;
                    case 9:
                        GoodVsEvilTest();
                        break;
                    case 10:
                        EnoughIsEnoungTest();
                        break;
                    case 11:
                        YourOrderPleaseTest();
                        break;
                    case 12:
                        CamelBreakTest();
                        break;
                    case 13:
                        XShapeTest();
                        break;
                    case 14:
                        TakeATenMinutesWalkTest();
                        break;
                    case 15:
                        CountCharactersInStringTest();
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
                Console.WriteLine("2. Rot13 Coder");
                Console.WriteLine("3. Moving Zeros To The End");


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
                    case 2:
                        Rot13CoderTest();
                        break;
                    case 3:
                        MovingZerosToTheEndTest(); 
                        break;

                }
            }
        }

        #endregion

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
        static void HighestScoringWordTest()
        {
            Console.WriteLine(HighestScoringWord.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Spin words: " + HighestScoringWord.High("man i need a taxi up to ubud"));
            Console.WriteLine("---------------");
        }
        static void CountASpiralTest()
        {
            Console.WriteLine(CountASpiral.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Spin words: " + CountASpiral.Sum(7));
            Console.WriteLine("---------------");
        }
        static void BinaryAdditionTest()
        {
            Console.WriteLine(BinaryAddition.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Spin words: " + BinaryAddition.AddBinary(5, 9));
            Console.WriteLine("---------------");
        }
        static void ZeroFuelTest()
        {
            Console.WriteLine(ZeroFuel.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Will we arrive: " + ZeroFuel.IsZeroFuel(50, 25, 2));
            Console.WriteLine("---------------");
        }
        static void PillarsTest()
        {
            Console.WriteLine(Pillars.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Will we arrive: " + Pillars.PillarsMath(2, 10, 10));
            Console.WriteLine("---------------");
        }
        static void TheNailTest()
        {
            Console.WriteLine(TheNail.GetTestDescription());
            Console.WriteLine("---------------");



            int l = 77;
            int playerHit, systemHit = 3;
            while (l > 0)
            {
                playerHit = TheNail.Hit(l);
                if (playerHit < 1 || playerHit > 3)
                {
                    Console.WriteLine("Your strength of strike can be only 1, 2 or 3 units");
                    break;
                }
                l -= playerHit;
                if (l <= 0)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                l -= systemHit;
                if (l <= 0)
                {
                    Console.WriteLine($"Player {l + systemHit + playerHit} -> {l + systemHit} \nAnother guy {l + systemHit} -> {l}");
                    break;
                }
            }
            Console.WriteLine("---------------");
        }
        static void WhoLikesItTest()
        {
            Console.WriteLine(WhoLikesIt.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Who likes it?: " + WhoLikesIt.Likes(new string[] { }));
            Console.WriteLine("Who likes it?: " + WhoLikesIt.Likes(new string[] { "Peter"}));
            Console.WriteLine("Who likes it?: " + WhoLikesIt.Likes(new string[] {"Jacob","Alex"}));
            Console.WriteLine("Who likes it?: " + WhoLikesIt.Likes(new string[] {"Max","John", "Mark"}));
            Console.WriteLine("Who likes it?: " + WhoLikesIt.Likes(new string[] {"Alex","Jacob", "Mark", "Max"}));
            Console.WriteLine("---------------");
        }
        static void NodeTest()
        {
            Console.WriteLine(Node.GetTestDescription());
            Console.WriteLine("---------------");
            
            //Create Node test
            //Null exception
            if(1 == Node.Push(null, 1).Data)
            {
                Console.WriteLine("Result : Success");
            }
            if (null == Node.Push(null, 1).Next)
            {
                Console.WriteLine("Result : Success");
            }
            if (2 == Node.Push(new Node(1), 2).Data)
            {
                Console.WriteLine("Result : Success");
            }
            if (1 == Node.Push(new Node(1), 2).Next.Data)
            {
                Console.WriteLine("Result : Success");
            }

            Node chained = null;
            chained = Node.Push(chained, 3);
            chained = Node.Push(chained, 2);
            chained = Node.Push(chained, 1);


            Console.WriteLine("---------------");
        }
        static void SumOfDigitsTest()
        {
            Console.WriteLine(SumOfDigits.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result?: " + (SumOfDigits.DigitalRoot(493193) == 2 ? "Success!" : "Failure!"));
            Console.WriteLine("Result?: " + (SumOfDigits.DigitalRoot(132189) == 6 ? "Success!" : "Failure!"));
            Console.WriteLine("Result?: " + (SumOfDigits.DigitalRoot(16) == 7 ? "Success!" : "Failure!"));
            Console.WriteLine("Result?: " + (SumOfDigits.DigitalRoot(942) == 6 ? "Success!" : "Failure!"));
            Console.WriteLine("---------------");
        }
        static void CreatePhoneNumberTest()
        {
            Console.WriteLine(CreatePhoneNumber.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Your number: " + CreatePhoneNumber.Create(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Console.WriteLine("---------------");
        }
        static void StonePickAxeTest()
        {
            Console.WriteLine(StonePickAxe.GetTestDescription());
            Console.WriteLine("---------------");
            //Console.WriteLine("How many i can make: " + StonePickAxe.StonePick(new string[] { "Cobblestone", "Cobblestone", "Cobblestone", "Cobblestone", "Cobblestone", "Cobblestone", "Wood" }));
            //Console.WriteLine("How many i can make: " + StonePickAxe.StonePick(new string[] { "Sticks", "Sticks", "Cobblestone" }));
            //Console.WriteLine("How many i can make: " + StonePickAxe.StonePick(StonePickAxe.TransformStringToArray("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC")));
            Console.WriteLine("How many i can make: " + StonePickAxe.StonePick(StonePickAxe.TransformStringToArray("CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCSSSSSSSSWWWW")));
            Console.WriteLine("---------------");
        }
        static void PaginationHelperTest()
        {
            //var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
            var helper = new PaginationHelper<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, 10);

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

            Console.WriteLine(".");
            Console.WriteLine("Page Item Count: " + helper.PageIndex(0));
            Console.WriteLine("---------------");
        }
        static void SquareNSumTest()
        {
            Console.WriteLine(SquareNSum.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Your result: " + SquareNSum.SquareSum(new int[] {1,2,2 }));
            Console.WriteLine("---------------");
        }
        static void LeapYearsTest()
        {
            Console.WriteLine(LeapYears.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Your result: " + LeapYears.IsLeapYear(2000));
            Console.WriteLine("---------------");
        }
        static void VowelCountTest()
        {
            Console.WriteLine(VowelCount.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Your result: " + VowelCount.GetVowelCount("abracadabra"));
            Console.WriteLine("---------------");
        }
        static void ReverseWordsTest()
        {
            Console.WriteLine(ReverseWords.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Your result: " + ReverseWords.ReverseWord("This is an example!"));
            Console.WriteLine("---------------");
        }
        static void SquareEveryDigitTest()
        {
            Console.WriteLine(SquareEveryDigit.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + SquareEveryDigit.SquareDigits(123));
            Console.WriteLine("---------------");
        }
        static void FindTheDuplicatedNumberTest()
        {
            Console.WriteLine(FindTheDuplicatedNumber.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + FindTheDuplicatedNumber.FindDup(new int[] { 1, 1, 2, 3 }));
            Console.WriteLine("---------------");
        }
        static void GoodVsEvilTest()
        {
            Console.WriteLine(MiddleEarthGoodVsEvil.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + MiddleEarthGoodVsEvil.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
            Console.WriteLine("---------------");
        }
        static void EnoughIsEnoungTest()
        {
            Console.WriteLine(EnoughIsEnough.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + EnoughIsEnough.DeleteNth(new int[] {20,37,20,21}, 1));
            Console.WriteLine("Result: " + EnoughIsEnough.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3));
            Console.WriteLine("---------------");
        }
        static void DnaConversionTest()
        {
            Console.WriteLine(DnaConversion.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + DnaConversion.dnaToRna("GCAT"));
            Console.WriteLine("---------------");
        }
        static void YouOnlyNeedOneTest()
        {
            Console.WriteLine(YouOnlyNeedOne.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + YouOnlyNeedOne.Check(new object[] {1,2,3,4,5,6,7}, 7));
            Console.WriteLine("---------------");
        }
        static void YourOrderPleaseTest()
        {
            Console.WriteLine(YourOrderPlease.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + YourOrderPlease.Order("is2 Thi1s T4est 3a"));
            Console.WriteLine("---------------");
        }
        static void ListFilteringTest()
        {
            Console.WriteLine(ListFiltering.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + ListFiltering.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }));
            Console.WriteLine("---------------");
        }
        static void CamelBreakTest()
        {
            Console.WriteLine(CamelBreak.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + CamelBreak.BreakCamelCase("camelBreak"));
            Console.WriteLine("---------------");
        }
        static void Rot13CoderTest()
        {
            Console.WriteLine(Rot13Coder.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + Rot13Coder.Rot13("NsWvcHZibuiSol+^iOxH}grJXgsCU"));
            Console.WriteLine("---------------");
        }
        static void XShapeTest()
        {
            Console.WriteLine(XShape.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: \n" + XShape.X(5));
            Console.WriteLine("---------------");
        }
        static void Testing123Test()
        {
            Console.WriteLine(Testing123.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + Testing123.Number(new List<string> { "a","b","c"}));
            Console.WriteLine("---------------");
        }
        static void Set_AlarmTest()
        {
            Console.WriteLine(Set_Alarm.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + Set_Alarm.SetAlarm(true, false));
            Console.WriteLine("---------------");
        }
        static void VolumeOfaCuboidTest()
        {
            Console.WriteLine(VolumeOfaCuboid.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + VolumeOfaCuboid.GetVolumeOfCuboid(2,5,6));
            Console.WriteLine("---------------");
        }
        static void TakeATenMinutesWalkTest()
        {
            Console.WriteLine(TakeATenMinutesWalk.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + TakeATenMinutesWalk.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
            Console.WriteLine("---------------");
        }
        static void CountCharactersInStringTest()
        {
            Console.WriteLine(CountCharactersInString.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + CountCharactersInString.Count("aba"));
            Console.WriteLine("---------------");
        }

        static void FriendOrFoeTest()
        {
            Console.WriteLine(FriendOrFoe.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + FriendOrFoe.FriendOrFoeMethod(new string[] {"Ryan","Kieran", "Marik" }));
            Console.WriteLine("---------------");
        }

        static void TwoToOneTest()
        {
            Console.WriteLine(TwoToOne.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Console.WriteLine("---------------");
        }
        static void MovingZerosToTheEndTest()
        {
            //kyu5
            Console.WriteLine(MovingZerosToTheEnd.GetTestDescription());
            Console.WriteLine("---------------");
            Console.WriteLine("Result: " + MovingZerosToTheEnd.MoveZeroes(new int[] {1,2,3,4,0,5,6,7,}));
            Console.WriteLine("---------------");
        }
    }
}
