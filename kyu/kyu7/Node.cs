using System;
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
        public static string GetTestDescription()
        {
            return "Linked Lists - Push & BuildOneTwoThree\r\n\r\nWrite push() and buildOneTwoThree() functions to easily update and initialize linked lists. Try to use the push() function within your buildOneTwoThree() function.\r\n\r\nHere's an example of push() usage:\r\n\r\nNode chained = null;\r\nchained = Node.Push(chained, 3);\r\nchained = Node.Push(chained, 2);\r\nchained = Node.Push(chained, 1);\r\nNode.Push(chained, 8) => 8 -> 1 -> 2 -> 3 -> null\r\nThe push function accepts head and data parameters, where head is either a node object or null/None/nil. Your push implementation should be able to create a new linked list/node when head is null/None/nil.";
        }

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
            Node nod = new Node(data);
            nod.Next = head;
            return head;
        }

        public static Node BuildOneTwoThree()
        {
            throw new NotImplementedException();
        }
    }
}
