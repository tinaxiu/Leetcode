using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class linked_list_cycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { int val = x; }
        }

        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                ListNode node = head;
                List<ListNode> ls = new List<ListNode>();
                bool res = false;
                while (node != null)
                {
                    if (!ls.Contains(node))
                        ls.Add(node);
                    else
                        return res = true;
                    node = node.next;
                }

                return res;
            }
        }
    }
}
