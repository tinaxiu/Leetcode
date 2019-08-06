using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    class _2
    {
        public void runCode()
        {
            ListNode n1 = new ListNode(1);
            //n1.next = new ListNode(4);
            //n1.next.next = new ListNode(3);

            ListNode n2 = new ListNode(9);
            n2.next = new ListNode(9);
            //n2.next.next = new ListNode(4);

            AddTwoNumbers(n1,n2);
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int p = 0, c = 0;
            ListNode root = new ListNode(0);
            ListNode node = root;
            while (l1 != null || l2 != null)
            {
                if(l1 != null && l2 != null)
                {                   
                    if (l1.val + l2.val + c >= 10)
                    {
                        node.next = new ListNode(l1.val + l2.val + c -10);
                        c = 1;
                    }
                    else
                    {
                        node.next = new ListNode(l1.val + l2.val +c );
                        c = 0;
                    }
                    l1 = l1.next;
                    l2 = l2.next;

                }
                else if( l1 != null)
                {
                                      
                    if (l1.val + c >= 10)
                    {
                        node.next = new ListNode(l1.val + c -10);
                        c = 1;
                    }
                        
                    else
                    {
                        node.next = new ListNode(l1.val + c);
                        c = 0;
                    }
                    l1 = l1.next;
                }
                else if (l2 != null)
                {
                    
                    
                    if (l2.val +c >= 10)
                    {
                        node.next = new ListNode(l2.val + c -10);
                        c = 1;
                    }
                        
                    else
                    {
                        node.next = new ListNode(l2.val + c);
                        c = 0;
                    }
                        
                    l2 = l2.next;
                }

                node = node.next;
            }
            if(c ==1)
            {
                node.next = new ListNode(1);
            }
            return root.next;

        }
    }
}
