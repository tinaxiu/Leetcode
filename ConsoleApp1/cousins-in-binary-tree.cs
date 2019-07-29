using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class cousins_in_binary_tree
    {

            /**
             * Definition for a binary tree node.
             * public class TreeNode {
             *     public int val;
             *     public TreeNode left;
             *     public TreeNode right;
             *     public TreeNode(int x) { val = x; }
             * }
             */
        public class Cousin
        {
            Dictionary<int, int> depth;
            Dictionary<int, Node> parent;

            public bool IsCousins(Node root, int x, int y)
            {
                dfs(root, null);
                if (depth[x] == depth[y])
                    return true;
                else
                    return false;
            }

            public void dfs(Node node, Node par)
            {
                if(node != null)
                {
                    depth.Add(node.value, par != null ? 1 + depth[par.value] : 0);
                    parent.Add(node.value, par);
                    dfs(node.left, node);
                    dfs(node.right, node);
                }
            }

            public bool bfsQueue(Node root, int x, int y)
            {
                if (root == null) return false;
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(root);
                int size = 0;

                


                Node cur;
                while(q != null)
                {
                    size = q.Count;
                    

                    bool Xexist = false;
                    bool Yexist = false;

                    for (int i =0; i < size; i++)
                    {
                        cur = q.Dequeue(); 

                        if (cur.value == x) Xexist = true;
                        if (cur.value == y) Yexist = true;

                        if( cur.left != null && cur.left!= null)
                        {
                            if (cur.left.value == x && cur.right.value == y) return false;
                            if (cur.right.value == y && cur.left.value == x) return false;
                        }


                        if (cur.left != null) q.Enqueue(cur.left);
                        if (cur.right != null) q.Enqueue(cur.right);
                    }

                    if (Xexist == true && Yexist == true) return true;
                }

                return false;


            }






            public bool bfs(Node root, int A, int B)
            {
                if (root == null) return false;

                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while(queue.Count != 0 )
                {
                    int size = queue.Count;
                    bool isAexist = false;
                    bool isBexist = false;

                    for(int i =0; i < size; i++ )
                    {
                        Node cur = queue.Dequeue();
                        if (cur.value == A) isAexist = true;
                        if (cur.value == B) isBexist = true;
                        if (cur.left != null && cur.right != null)
                        {
                            if( cur.left.value == A && cur.right.value == B)
                            {
                                return false;
                            }

                            if(cur.left.value == B && cur.right.value == A)
                            {
                                return false;
                            }
                        }
                        if (cur.left != null)
                        {
                            queue.Enqueue(cur.left);

                        }

                        if(cur.right != null)
                        {
                            queue.Enqueue(cur.right);
                        }
                           
                    }

                    if (isAexist && isBexist) return true;

                }
                return false;
            }
            
        }
    }
}
