using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu8
{
    //Course: https://www.codewars.com/kata/5556282156230d0e5e000089/train/csharp
    //Status: Complete
    internal class DnaConversion
    {
        public static string GetTestDescription()
        {
            return "Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').\r\n\r\nRibonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').\r\n\r\nCreate a function which translates a given DNA string into RNA.\r\n\r\nFor example:\r\n\r\n\"GCAT\"  =>  \"GCAU\"\r\nThe input string can be of arbitrary length - in particular, it may be empty. All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.";
        }
        public static string dnaToRna(string dna)
        {
            return dna.Replace("T", "U");
        }
    }
}
