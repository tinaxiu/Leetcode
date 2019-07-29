using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class link
    {
        public LinkedListNode<int> getIntersection (LinkedListNode<int> headA, LinkedListNode<int> headB)
        {
            LinkedListNode<int> a = headA;
            LinkedListNode<int> b = headB;
            int lengthA = 0;
            int lengthB = 0;
            LinkedListNode<int> node = headA;

            while(node != null)
            {
                lengthA++;
                node = node.Next;
            }
            node = b;
            while(node!= null)
            {
                lengthB++;
                node = node.Next;
            }

            if(lengthA > lengthB)
            {
                int moves = lengthA - lengthB;
                while (moves != 0)
                {
                    a = a.Next;
                    moves--;
                }

            }
            else if(lengthB > lengthA)
            {
                int moves = lengthB - lengthA;
                while(moves !=0)
                {
                    b = b.Next;
                    moves--;
                }
            }

            while (a != null && b != null)
            {
                if (a == b) return a;
                headA = headA.Next;
                headB = headB.Next;
            }

            return null;
                

        }
    }
}
