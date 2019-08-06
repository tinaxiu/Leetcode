using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _25
    {
        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
        public void runCode()
        {
            ListNode head = new ListNode(1);

            ListNode node = head.next = new ListNode(2);
            node = node.next = new ListNode(3);
            node = node.next = new ListNode(4);
            node = node.next = new ListNode(5);
            node = node.next = new ListNode(6);
            node = node.next = new ListNode(7);
            node = node.next = new ListNode(8);
            node = node.next = new ListNode(9);

            ReverseKGroup(head, 3);
        }
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode begin;
            if (head == null || head.next == null || k == 1)
                return head;
            ListNode pre = new ListNode(-1);
            pre.next = head;
            begin = pre;
            int i = 0;
            while(head != null)
            {
                i++;
                if(i%k == 0)
                {
                    begin = reverse(begin, head.next);
                    head = begin.next;
                }
                else
                {
                    head = head.next;
                }
            }
            return pre.next;
        }

        ListNode reverse(ListNode begin, ListNode end)
        {
            ListNode cur = begin.next;
            ListNode next, first;
            ListNode pre = begin;
            first = cur;
            while(cur != end)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
            begin.next = pre;
            first.next = cur;
            return first;
        }
    }
}
