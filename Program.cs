using Kata.kyu.kyu6;
using Kata.kyu.kyu7;
using System;

namespace Kata
{
    public static class Kata
    {
        public static void Main()
        {
            //Console.WriteLine(PrinterError("kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
            //Console.ReadKey();
            //Console.WriteLine(TitleCase.GetCase("aBC deF Ghi", null));

            Node node = null;
            node = Node.Push(node, 3);
            node = Node.Push(node, 2);
            node = Node.Push(node, 1);

            Console.WriteLine(node);
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
