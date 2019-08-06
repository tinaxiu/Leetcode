using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _206
    {

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

            ReverseList(head);
        }
        public ListNode ReverseList(ListNode head)
        {

            ListNode pre = null;
            ListNode cur = head, next;
            while(cur!=null)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
                
            }

            return pre;
        }
    }
}
