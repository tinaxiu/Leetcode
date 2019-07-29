using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    **/
    class merge_two_sorted_lists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            ListNode node = new ListNode(0);
            ListNode start = node;

            while (l1 != null || l2 != null)
            {
                if (l2 == null)
                {
                    node.next = l1;
                    l1 = l1.next;
                }
                else if (l1 == null)
                {
                    node.next = l2;
                    l2 = l2.next;
                }

                else if (l1.val <= l2.val)
                {
                    node.val = l1.val;
                    l1 = l1.next;
                }
                    
                else if(l1.val > l2.val)
                {
                    node.val = l2.val;
                    l2 = l2.next;
                }

                node = node.next;
            }

           
           
               

            return start.next;


        }

    }


}
