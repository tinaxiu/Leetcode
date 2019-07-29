using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class design_linked_list
    {
        public class MyLinkedList
        {

            public class Node
            {
                public int val;
                public Node next;
                public Node(int v, Node n = null)
                {
                    this.val = v;
                    this.next = n;
                }

            }
            /** Initialize your data structure here. */

            Node head;
            int count;
            public MyLinkedList()
            {
                head = new Node(-1);
                count = 0;

             
            }

            /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
            public int Get(int index)
            {
                if (index < 0) return -1;
                Node node = head;

                try
                {
                    for(int i =0; i<index; i++)
                    {
                        node = node.next;
                    }
                    return node.val;
                }
                catch
                {
                    return -1;
                }
            }

            /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
            public void AddAtHead(int val)
            {
                Node node = new Node(val);
                if(head == null)
                {
                    head.val = val;
                }
                else
                {
                    Node next = head.next;
                    head.next = node;
                    node.next = next;
                }
                
                 
            }

            /** Append a node of value val to the last element of the linked list. */
            public void AddAtTail(int val)
            {

                Node node = head;
                while (node.next != null)
                    node = node.next;
                node.next = new Node(val);

            }

            /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
            public void AddAtIndex(int index, int val)
            {
                Node node = head;
                if (index == 0)
                    AddAtHead(val);

                try
                {
                    for (int i = 1; i < index; i++)
                        node = node.next;

                    Node newNode = new Node(val);
                    newNode.next = node.next;
                    node.next = newNode;
                }
                catch
                {

                }
                    

            }

            /** Delete the index-th node in the linked list, if the index is valid. */
            public void DeleteAtIndex(int index)
            {
                Node node = head;
                Node pre = node;


                try
                {
                    if(index ==0)
                    {
                        head.next = null;
                    }
                    else
                    {
                        for (int i = 1; i < index; i++)
                            node = node.next;
                        if (node.next == null)
                        {

                        }
                        else
                        {
                            node.next = node.next.next;
                        }
                    }
                }
                catch
                {

                }

            }
        }

        /**
         * Your MyLinkedList object will be instantiated and called as such:
         * MyLinkedList obj = new MyLinkedList();
         * int param_1 = obj.Get(index);
         * obj.AddAtHead(val);
         * obj.AddAtTail(val);
         * obj.AddAtIndex(index,val);
         * obj.DeleteAtIndex(index);
         */
    }
}
