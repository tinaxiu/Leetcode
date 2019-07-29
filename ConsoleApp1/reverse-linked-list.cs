using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { int val = x; }
    }

    class reverse_linked_list
    {
        public ListNode reverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;

        }
    }
}

