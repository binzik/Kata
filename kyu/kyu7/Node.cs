﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu7
{
    //From course https://www.codewars.com/kata/55be95786abade3c71000079/train/csharp
    // Status: TODO
    // Input: 
    //
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        // Input:   Node, int 
        // Output:  Node
        public static Node Push(Node head, int data)
        {
            head.Next = head;
            head.Data = data;
            return head;
        }

        public static Node BuildOneTwoThree()
        {
            throw new NotImplementedException();
        }
    }
}
