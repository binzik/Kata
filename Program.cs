using Kata.kyu.kyu6;
using System;

namespace Kata
{
    public static class Kata
    {
        public static void Main()
        {
            //Console.WriteLine(PrinterError("kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
            //Console.ReadKey();
            Console.WriteLine(TitleCase.GetCase("aBC deF Ghi", null));
            Console.ReadKey();
        }

        //public static string PrinterError(String s)
        //{
        //    // your codes
        //    Dictionary<char, int> duplicates = new Dictionary<char, int>();

        //    foreach (char c in s)
        //    {
        //        if (duplicates.ContainsKey(c) && (int)c>=97 && (int)c<=109)
        //        {
        //            duplicates[c] += 1;
        //        }
        //        else if((int)c >= 97 && (int)c <= 109)
        //            duplicates[c] = 1;
        //    }

        //    return duplicates.Count + "/" + s.Length;
        //}
    }
}
