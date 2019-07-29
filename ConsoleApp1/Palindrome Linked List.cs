using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */

    class Palindrome_Linked_List
    {
        public class ListNode
        {
          public int val;
          public ListNode next;
          public ListNode(int x) { val = x; }
        }

        public static void runCode()
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(0);
           node.next.next = new ListNode(1);

            IsPalindrome(node);
        }
        public static bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }


            ListNode r = reverse(slow);
            while (r != null)
            {
                if (r.val != head.val)
                    return false;
                else
                {
                    r = r.next;
                    head = head.next;
                }
                    
            }
            

            return true;

        }

        public static  ListNode reverse( ListNode node)
        {
            ListNode pre = null;
            while(node != null)
            {
                ListNode next = node.next;
                node.next = pre;
                pre = node;
                node = next;
            }
            return pre;
        }

    }
}
