using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class palindrome_linked_list
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { int val = x; }
        }

        public class DoubleListNode
        {
            public int val;
            public ListNode next;
            public ListNode pre;
            public DoubleListNode(int x) { int val = x; }
        }


        public bool IsPalindrome(ListNode head)
        {
            DoubleListNode dl = null;

            ListNode node = new ListNode(-1);
            node.next = head;
            while (node != null)
            {
                dl.pre = node;
                dl.val = node.val;
                dl.next = node.next;

                node = node.next;
            }
            return false;

        }   
        
    }
}
